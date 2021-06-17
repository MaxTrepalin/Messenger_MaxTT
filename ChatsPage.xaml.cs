using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Messenger
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage1 : ContentPage
    {
        public List<Chat> Chat1 { get; set; }

        public ObservableCollection<string> Items { get; set; }

        public ListViewPage1()
        {
            InitializeComponent();

            Chat1 = new List<Chat>
            {
                new Chat {name = "Max", message = "hi" },
          };
            ChatsPageList.ItemsSource = Chat1;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;

        }

        private async void status_button_Clicked(object sender, EventArgs e)
        {
            var Page1 = new MainPage();

            await Navigation.PushAsync(Page1);
        }

        private void Send_button_Clicked(object sender, EventArgs e)
        {

             Chat_StackLayout.Children.Add(new Label { Text = Entry_chat.Text, BackgroundColor = Color.LightGreen });
        }

        private  async void settings_button_Clicked(object sender, EventArgs e)
        {
            var setPage = new Settings();

            await Navigation.PushAsync(setPage);
        }

        private async void contacts_button_Clicked(object sender, EventArgs e)
        {
            var secondPage = new Contacts();

            await Navigation.PushAsync(secondPage);
        }
    }
}
