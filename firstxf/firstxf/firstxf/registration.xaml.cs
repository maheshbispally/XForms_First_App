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
    public partial class registration : ContentPage
    {
        public registration()
        {
            InitializeComponent();
        }

        private async void btn_cancel(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new basic_login_view());
        }
    }
}