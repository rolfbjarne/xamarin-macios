using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Xamarin.Bundler
{
	// This contains all the tasks that builds the final output.
	// Intermediate tasks do not have to be in this list (as long as they're in another task's dependencies),
	// but it doesn't hurt if they're here either.
	public class BuildTasks : List<BuildTask>
	{
		SemaphoreSlim semaphore;

		public BuildTasks ()
		{
			semaphore = new SemaphoreSlim (Driver.Concurrency, Driver.Concurrency);
			Driver.Log (5, $"Created task scheduler with concurrency {Driver.Concurrency}.");
		}

		public async Task AcquireSemaphore ()
		{
			await semaphore.WaitAsync ();
		}

		public void ReleaseSemaphore ()
		{
			semaphore.Release ();
		}

		void ExecuteBuildTasks (SingleThreadedSynchronizationContext context, List<Exception> exceptions)
		{
			Task [] tasks = new Task [Count];

			for (int i = 0; i < Count; i++)
				tasks [i] = this [i].Execute (this);
			
			Task.Factory.StartNew (async () =>
			{
				try {
					await Task.WhenAll (tasks);
				} catch (Exception e) {
					exceptions.Add (e);
				} finally {
					context.SetCompleted ();
				}
			}, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.FromCurrentSynchronizationContext ());
		}

		public void Execute ()
		{
			if (Count == 0)
				return;

			var savedContext = SynchronizationContext.Current;
			var exceptions = new List<Exception> ();
			try {
				var context = new SingleThreadedSynchronizationContext ();
				SynchronizationContext.SetSynchronizationContext (context);
				ExecuteBuildTasks (context, exceptions);
				context.Run ();
			} finally {
				SynchronizationContext.SetSynchronizationContext (savedContext);
			}
			if (exceptions.Count > 0)
				throw new AggregateException (exceptions);
		}

		public void Dump (bool dot = true)
		{
			if (dot) {
				Console.WriteLine ("digraph build {");
			} else {
				Console.WriteLine ("{0} build tasks.", Count);
			}
			foreach (var task in this)
				DumpTask (task, 0, dot);
			if (dot)
				Console.WriteLine ("}");
		}

		void DumpTask (BuildTask task, int indent, bool dot)
		{
			if (dot) {
				Console.WriteLine ("    X{0} [label=\"{1}\"];", task.ID, task.ToString ());
				foreach (var t in task.Dependencies) {
					Console.WriteLine ("    X{0} -> X{1};", t.ID, task.ID);
					DumpTask (t, indent + 1, dot);
				}
			} else {
				if (task.Dependencies.Any ()) {
					Console.WriteLine ($"{new string (' ', indent * 4)}#{task.ID}: {task}. {task.Dependencies.Count ()} dependencies:");
					foreach (var t in task.Dependencies)
						DumpTask (t, indent + 1, dot);
				} else {
					Console.WriteLine ($"{new string (' ', indent * 4)}#{task.ID}: {task}.");
				}
			}
		}
	}

	public abstract class BuildTask
	{
		static int counter;
		public readonly int ID = counter++;

		TaskCompletionSource<bool> started_task = new TaskCompletionSource<bool> ();
		TaskCompletionSource<bool> completion_task = new TaskCompletionSource<bool> ();
		List<BuildTask> dependencies = new List<BuildTask> ();

		public IEnumerable<BuildTask> Dependencies {
			get {
				return dependencies;
			}
			set {
				dependencies.AddRange (value);
			}
		}

		public BuildTask Dependency {
			set {
				if (value != null)
					dependencies.Add (value);
			}
		}

		public Task CompletionTask {
			get {
				return completion_task.Task;
			}
		}

		public void AddDependency (params BuildTask [] dependencies)
		{
			this.dependencies.AddRange (dependencies);
		}

		public void AddDependency (IEnumerable<BuildTask> dependencies)
		{
			if (dependencies == null)
				return;
			this.dependencies.AddRange (dependencies);
		}

		public async Task Execute (BuildTasks build_tasks)
		{
			if (started_task.TrySetResult (true)) {
				var watch = new System.Diagnostics.Stopwatch ();
				try {
					Console.WriteLine ("Launching task #{1}: {0}", GetType ().Name, ID);
					foreach (var dep in Dependencies) {
						Console.WriteLine ("Task #{1} ({0}) is waiting for task #{2} ({3}).", GetType ().Name, ID, dep.ID, dep.GetType ().Name);
						await dep.Execute (build_tasks);
						Console.WriteLine ("Task #{1} ({0}) done waiting for task #{2} ({3}).", GetType ().Name, ID, dep.ID, dep.GetType ().Name);
					}
					Console.WriteLine ("Task #{1} ({0})'s dependencies are complete.", GetType ().Name, ID);
					await build_tasks.AcquireSemaphore ();
					try {
						Console.WriteLine ("Executing task #{1}: {0}", GetType ().Name, ID);
						watch.Start ();
						await ExecuteAsync ();
						watch.Stop ();
						Console.WriteLine ("Completed task #{1}: {0} in {2} s", GetType ().Name, ID, watch.Elapsed.TotalSeconds);
						completion_task.SetResult (true);
					} finally {
						build_tasks.ReleaseSemaphore ();
					}
				} catch (Exception e) {
					Console.WriteLine ("Completed task #{1}: {0} in {2} s with exception: {3}", GetType ().Name, ID, watch.Elapsed.TotalSeconds, e.Message);
					completion_task.SetException (e);
					throw;
				}
			} else {
				Console.WriteLine ("Waiting for started task #{1}: {0}", GetType ().Name, ID);
				await completion_task.Task;
				Console.WriteLine ("Waited for started task #{1}: {0}", GetType ().Name, ID);
			}
		}

		protected virtual Task ExecuteAsync ()
		{
			return Task.Run (() => Execute ());
		}

		protected virtual void Execute ()
		{
			throw new Exception ("Either Execute or ExecuteAsync must be overridden.");
		}

		public override string ToString ()
		{
			return GetType ().Name;
		}
	}

	class SingleThreadedSynchronizationContext : SynchronizationContext
	{
		BlockingCollection<Tuple<SendOrPostCallback, object>> queue = new BlockingCollection<Tuple<SendOrPostCallback, object>> ();

		public override void Post (SendOrPostCallback d, object state)
		{
			queue.Add (new Tuple<SendOrPostCallback, object> (d, state));
		}

		public override void Send (SendOrPostCallback d, object state)
		{
			d (state);
		}

		public int Run ()
		{
			int counter = 0;

			while (!queue.IsCompleted) {
				var item = queue.Take ();
				counter++;
				item.Item1 (item.Item2);
			}
			Console.WriteLine ("Executed {0} posted callbacks in SingleThreadedSynchronizationContext.", counter);
			return counter;
		}

		public void SetCompleted ()
		{
			queue.CompleteAdding ();
		}
	}
}
