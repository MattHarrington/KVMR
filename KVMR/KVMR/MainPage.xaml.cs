using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace KVMR
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //imgLogo.Source = Device.OnPlatform(ImageSource.FromFile("Logo.png"),
            //                                   ImageSource.FromFile("Logo.png"),
            //                                   ImageSource.FromUri(new Uri("http://xamarin.com/images/index/ide-xamarin-studio.png")));
        }
    }
}
