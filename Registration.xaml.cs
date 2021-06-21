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
    public partial class Registration : ContentPage
    {
        public Registration()
        {
            InitializeComponent();
        }
        private async void settings_button_Clicked(object sender, EventArgs e)
        {
            var secondPage = new Settings();

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

        private async void button_registrationCancel_Clicked(object sender, EventArgs e)
        {
            var secondPage = new Settings();

            await Navigation.PushAsync(secondPage);
        }
        
                

        private void button_registration_Clicked(object sender, EventArgs e)
        {
                        
                string login = label_login.Text;
                string pass1 = label_password.Text;
                string pass2 = label_password.Text;
                if (pass1 != pass2)
                {
                    DisplayAlert("Пароли отличаются", "Проверьте ввод паролей", "Ok");
                }
                else if (login == null)
                {
                    DisplayAlert("Проверьте поле Логин", "Введите логин используя цифры и латинские бурвы", "Ok");
                }
                else
                {
                    DisplayAlert("РЕГИСТРАЦИЯ", "Успешно!", "Ok");
                }
            
        }

        private async void contacts_button_Clicked(object sender, EventArgs e)
        {
            var secondPage = new Contacts();

            await Navigation.PushAsync(secondPage);
        }
    }
}
