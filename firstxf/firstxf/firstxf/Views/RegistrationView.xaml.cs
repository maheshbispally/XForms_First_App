using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace firstxf.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationView : ContentPage
    {
        public RegistrationView()
        {
            InitializeComponent();
        }
        private async void btn_cancel(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginView());
        }

        private void Button_submit(object sender, EventArgs e)
        {
            /*  Name_entry.Text != null;
            var test = Name;
            Name = Name_entry.Text.ToString();
            Age = Convert.ToInt32(Age_entry.Text);
            test = Name;*/

            //Phone=
        }
    }
}