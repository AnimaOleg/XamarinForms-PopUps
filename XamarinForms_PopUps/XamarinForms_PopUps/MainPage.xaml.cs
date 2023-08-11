using XamarinForms_PopUps.Pages;
using XamarinForms_PopUps.Pages2;
using Rg.Plugins.Popup.Animations;
using Rg.Plugins.Popup.Enums;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinForms_PopUps
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        /***************************************
         * First Part
         ***************************************/
        async void OpenPopUp_Animado(object sender, EventArgs e)
        {
            PopupNavigation.PushAsync(new MyPopupPage_Animado());
        }

        async void OpenPopUp_Simple(object sender, EventArgs e)
        {
            PopupNavigation.PushAsync(new MyPopupPage_Simple());
        }

        async void OpenPopUp_Personalizado(object sender, EventArgs e)
        {
            // Both ways work
            //PopupNavigation.PushAsync(new MyPopupPage_Personalizado());
            await PopupNavigation.Instance.PushAsync(new MyPopupPage_Personalizado());
        }

        async void OpenPopUp_PersonalizadoAnimado(object sender, EventArgs e)
        {
            var popupProperties = new MyPopupPage_PropiedadesAnimacion();
            var scaleAnimation = new ScaleAnimation
            {
                PositionIn = MoveAnimationOptions.Right,
                PositionOut = MoveAnimationOptions.Left
            };

            popupProperties.Animation = scaleAnimation;
            await PopupNavigation.PushAsync(popupProperties);
        }

        private void PopupAnimationPage(object sender, EventArgs e)
        {
            var animationPopup = new PopupAnimationPage();
            var scaleAnimation = new ScaleAnimation {
                PositionIn = MoveAnimationOptions.Top,
                PositionOut = MoveAnimationOptions.Bottom,
                ScaleIn = 1.2,
                ScaleOut = 0.8,
                DurationIn = 400,
                DurationOut = 800,
                EasingIn = Easing.BounceIn,
                EasingOut = Easing.CubicOut,
                HasBackgroundAnimation = false
            };
            animationPopup.Animation = scaleAnimation;
            PopupNavigation.PushAsync(animationPopup);
        }



        /***************************************
         * Second Part
         ***************************************/
        async void Open_BasicPopup(object sender, EventArgs e)
        {
            await PopupNavigation.PushAsync(new BasicPopup());
        }

        async void Open_StilizedPopup(object sender, EventArgs e)
        {
            await PopupNavigation.PushAsync(new StilizedPopup());
        }

        async void Open_PropertiesPopup(object sender, EventArgs e)
        {
            var propertiedPopup = new PropertiesPopup();

            propertiedPopup.Animation = new FadeAnimation();  // Posibilities: Scale, Move y Fade:
            propertiedPopup.BackgroundColor = Color.FromRgba(0, 0, 0, 0.25);
            propertiedPopup.CloseWhenBackgroundIsClicked = true;

            await PopupNavigation.PushAsync(propertiedPopup);
        }


        async void Open_CustomAnimation(object sender, EventArgs e)
        {
            var propertiedPopup = new PropertiesPopup();

            var scaleAnimation = new ScaleAnimation
            {
                PositionIn = MoveAnimationOptions.Top,
                PositionOut = MoveAnimationOptions.Bottom,
                ScaleIn = 1.2,
                ScaleOut = 0.8,
                DurationIn = 400,
                DurationOut = 800,
                EasingIn = Easing.BounceIn,
                EasingOut = Easing.CubicOut,
                HasBackgroundAnimation = false
            };

            propertiedPopup.Animation = scaleAnimation;
            await PopupNavigation.PushAsync(propertiedPopup);
        }



        //protected override void OnAppearing(){base.OnAppearing();}
        //protected override void OnDisappearing(){base.OnDisappearing();}

    }
}
