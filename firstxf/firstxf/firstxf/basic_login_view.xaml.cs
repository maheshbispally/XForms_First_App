using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace firstxf
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class basic_login_view : ContentPage
    {
        public basic_login_view()
        {
            InitializeComponent();
            img_homepage_logo.Source = ImageSource.FromResource("firstxf.Resource.testimg.jpg");
        }

        private async void btn_click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new registration());
        }
    }
}