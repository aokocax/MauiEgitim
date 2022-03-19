using Android.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiEgitim.Pages
{
    public partial class ShowCamera
    {
		private async Task<PermissionStatus> GetPermission()
		{
			var status = Permissions.RequestAsync<Permissions.Camera>();
			if (status.Result != PermissionStatus.Granted)
			{
				await Application.Current.MainPage.DisplayAlert("Yetki", "Yetki sağlanamadı", "OK");

			}
			return await status;
		}
		async void ShowIt()
		{

			var result = await MediaPicker.CaptureVideoAsync(); 
		}
	}
}
