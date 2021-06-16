using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Messenger
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
                   
        }
                     

        private async void chats_button_Clicked(object sender, EventArgs e)
        {
            var secondPage = new ListViewPage1();

            await Navigation.PushAsync(secondPage);
        }

        private async void ListView_Focused(object sender, FocusEventArgs e)
        {
            var secondPage = new ListViewPage1();

            await Navigation.PushAsync(secondPage);
        }

        private async void settings_button_Clicked(object sender, EventArgs e)
        {
            var setPage = new Settings();

            await Navigation.PushAsync(setPage);
        }

        private async void contacts_button_Clicked(object sender, EventArgs e)
        {
            var contactPage = new Contacts();

            await Navigation.PushAsync(contactPage);
        }
    }
    
}
