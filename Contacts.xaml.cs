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
    public partial class Contacts : ContentPage
    {
        public Contacts()
        {
            InitializeComponent();
        }

        private async void status_button_Clicked(object sender, EventArgs e)
        {
            var secondPage = new MainPage();

            await Navigation.PushAsync(secondPage);
        }

       
        private async void chats_button_Clicked(object sender, EventArgs e)
        {
            var secondPage = new ListViewPage1();

            await Navigation.PushAsync(secondPage);
        }

        private async void settings_button_Clicked(object sender, EventArgs e)
        {
            var secondPage = new Settings();

            await Navigation.PushAsync(secondPage);
        }

        private void ListContact_Focused(object sender, FocusEventArgs e)
        {

        }

        private async void butoon_newContact_Clicked(object sender, EventArgs e)
        {

            var secondPage = new NewContact();

            await Navigation.PushAsync(secondPage);

        }
    }
}