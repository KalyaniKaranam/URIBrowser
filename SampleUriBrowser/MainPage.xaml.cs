using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SampleUriBrowser
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnurl_Clicked(object sender, EventArgs e)
        {
            var url= "https://stackoverflow.com/questions/27605972/open-a-webpage-without-using-webview";
            Device.OpenUri(new Uri(url));
        }
    }
}
