using Android.Content;
using Android.Widget;
using System;

namespace App1.Droid
{
    public class UploadService : IUploadService
    {
        public void StartUpload(string fileName)
        {
            MainActivity mainActivity = Xamarin.Forms.Forms.Context as MainActivity;
            mainActivity.StartUpload(fileName);
        }
    }
}