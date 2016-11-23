using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
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

		void ExecuteBuildTasks (SingleThreadedSynchronizationContext context)
		{
			Task [] tasks = new Task [Count];

			for (int i = 0; i < Count; i++)
				tasks [i] = this [i].Execute (this);
			
			Task.Factory.StartNew (async () =>
			{
				await Task.WhenAll (tasks);
				context.SetCompleted ();
			}, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.FromCurrentSynchronizationContext ());
		}

		public void Execute ()
		{
			if (Count == 0)
				return;

			var savedContext = SynchronizationContext.Current;
			try {
				var context = new SingleThreadedSynchronizationContext ();
				SynchronizationContext.SetSynchronizationContext (context);
				ExecuteBuildTasks (context);
				context.Run ();
			} finally {
				SynchronizationContext.SetSynchronizationContext (savedContext);
			}
		}
	}

	public abstract class BuildTask
	{
		static int counter;
		int ID = counter++;

		TaskCompletionSource<bool> started_task = new TaskCompletionSource<bool> ();
		TaskCompletionSource<bool> completion_task = new TaskCompletionSource<bool> ();
		List<BuildTask> dependencies = new List<BuildTask> ();

		public IEnumerable<BuildTask> Dependencies {
			get {
				return dependencies;
			}
		}

		public Task CompletionTask {
			get {
				return completion_task.Task;
			}
		}

		public void SetCompleted ()
		{
			completion_task.SetResult (true);
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
				Console.WriteLine ("Launching task #{1}: {0}", GetType ().Name, ID);
				foreach (var dep in Dependencies) {
					Console.WriteLine ("Task #{1} ({0}) is waiting for task #{2} ({3}).", GetType ().Name, ID, dep.ID, dep.GetType ().Name);
					await dep.Execute (build_tasks);
					Console.WriteLine ("Task #{1} ({0}) done waiting for task #{2} ({3}).", GetType ().Name, ID, dep.ID, dep.GetType ().Name);
				}
				Console.WriteLine ("Task #{1} ({0})'s dependencies are complete.", GetType ().Name, ID);
				await build_tasks.AcquireSemaphore ();
				var watch = new System.Diagnostics.Stopwatch ();
				watch.Start ();
				Console.WriteLine ("Executing task #{1}: {0}", GetType ().Name, ID);
				await ExecuteAsync ();
				Console.WriteLine ("Completed task #{1}: {0} in {2} s", GetType ().Name, ID, watch.Elapsed.TotalSeconds);
				SetCompleted ();
				build_tasks.ReleaseSemaphore ();
			} else {
				Console.WriteLine ("Waitind for started task #{1}: {0}", GetType ().Name, ID);
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
			Tuple<SendOrPostCallback, object> item;

			while ((item = queue.Take ()) != null) {
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
