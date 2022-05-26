using System;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        private IUploadService _uploadService;

        public MainPage()
        {
            InitializeComponent();
            this._uploadService = DependencyService.Get<IUploadService>();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            this._uploadService.StartUpload("text.pdf");
        }
    }
}
