using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Messenger
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewContact : ContentPage
    {
        public NewContact()
        {
            InitializeComponent();
        }

        private async void contacts_button_Clicked(object sender, EventArgs e)
        {
            var secondPage = new Contacts();

            await Navigation.PushAsync(secondPage);
        }

        private async void status_button_Clicked(object sender, EventArgs e)
        {
            var secondPage = new Settings();

            await Navigation.PushAsync(secondPage);
        }

        private async void chats_button_Clicked(object sender, EventArgs e)
        {
            var secondPage = new MainPage();

            await Navigation.PushAsync(secondPage);
        }

        private async void settings_button_Clicked(object sender, EventArgs e)
        {
            var secondPage = new Settings();

            await Navigation.PushAsync(secondPage);
        }
    }
}