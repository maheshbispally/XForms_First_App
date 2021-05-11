using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace firstxf.ViewModel
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        Command RegistrationCommand;
        ICommand LoginCommand;

        public LoginViewModel()
        {
            // RegistrationCommand = new Command(async()=> { await Navigation.PushAsync(new RegistrationView()); });
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
