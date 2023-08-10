using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinForms_PopUps
{

    // Based on: https://github.com/rotorgames/Rg.Plugins.Popup
    // https://github.com/rotorgames/Rg.Plugins.Popup/wiki
    // mas ejemplos de animaciones: https://csharp.hotexamples.com/es/examples/Rg.Plugins.Popup.Pages/PopupPage/-/php-popuppage-class-examples.html

    // Initializated at MainActivity.cs(android) & AppDelegate.cs(ios)

    // Examples pages: https://vicenteguzman.mx/2018/using-rg-plugins-popup-xamarin-forms/
    // searching at google: ejemplo uso Rg.Plugins.Popup

    // More examples:
    // https://xamarinlatino.com/como-trabajar-con-ventanas-emergentes-pop-up-avanzados-en-xamarin-forms-7ebe109b0a37
    // https://thatcsharpguy.github.io/post/popups-avanzados-xamarin-forms/


    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());

        }

        // Handle when your app starts
        protected override void OnStart() { }

        // Handle when your app sleeps
        protected override void OnSleep() { }

        // Handle when your app resumes
        protected override void OnResume() { }

    }
}
