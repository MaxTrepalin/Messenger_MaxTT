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
    public partial class Settings : ContentPage
    {
        public Settings()
        {
            InitializeComponent();
        }

        private async void chats_button_Clicked(object sender, EventArgs e)
        {
            var secondPage = new ListViewPage1();

            await Navigation.PushAsync(secondPage);
        }

        private async void status_button_Clicked(object sender, EventArgs e)
        {
            var mainPage = new MainPage();

            await Navigation.PushAsync(mainPage);
        }
      
        private async void chats_button_Clicked_1(object sender, EventArgs e)
        {
            var mainPage = new ListViewPage1();

            await Navigation.PushAsync(mainPage);
        }

      
        private async void button_registration_Clicked(object sender, EventArgs e)
        {
            var mainPage = new Registration();

            await Navigation.PushAsync(mainPage);
        }

        private async void contacts_button_Clicked(object sender, EventArgs e)
        {
            var secondPage = new Contacts();

            await Navigation.PushAsync(secondPage);
        }
    }
}