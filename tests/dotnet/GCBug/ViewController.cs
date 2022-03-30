using System.Net;
using ObjCRuntime;

namespace gctest1;

public partial class ViewController : NSViewController {
	protected ViewController (NativeHandle handle) : base (handle)
	{
	}

	public override void ViewDidLoad ()
	{
		base.ViewDidLoad ();

		Task.Run(() =>
		{
			while (true)
			{
				GC.Collect();
				GC.WaitForPendingFinalizers();
				Thread.Sleep(3);
			}
		});

		Task.Run(() => RunHttpRequest());
		Task.Run(() => RunHttpRequest());
		Task.Run(() => RunHttpRequest());
		Task.Run(() => RunHttpRequest());
		Task.Run(() => RunHttpRequest());

		// Do any additional setup after loading the view.
	}

	public override NSObject RepresentedObject {
		get => base.RepresentedObject;
		set {
			base.RepresentedObject = value;

			// Update the view, if already loaded.
		}
	}

    static async void RunHttpRequest()
    {
        using var handler = new NSUrlSessionHandler();
        handler.CookieContainer = new CookieContainer();

        while (true)
        {
            try
            {
                using var client = new HttpClient(handler);
                var message = new HttpRequestMessage(HttpMethod.Get, "https://google.com");
                var result = await client.SendAsync(message);
            }
            catch (HttpRequestException e)
            {
            }
            catch (TaskCanceledException e)
            {
            }

            await Task.Delay(10);
        }
    }
}
