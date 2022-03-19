using Plugin.LocalNotification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiEgitim.Pages
{
    public partial class Notification
    {
		private async void TestNotification()
		{
#if WINDOWS
			Console.WriteLine("windows");
#else
			//Plugin Notification
			var notification = new NotificationRequest
			{
				NotificationId = 100,
				Title = "Notification test",
				Description = "Test Description",
				ReturningData = "Dummy data", // Returning data when tapped on notification.
				//Schedule =
				//{
				//	NotifyTime = DateTime.Now.AddSeconds(1) // Used for Scheduling local notification, if not specified notification will show immediately.
				//}
			};
			await NotificationCenter.Current.Show(notification);
#endif
		}
	}
}
