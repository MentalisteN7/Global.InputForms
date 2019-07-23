using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Switch = Global.InputForms.Switch;

namespace SampleApp.Views
{
    public class SwitchExample : ContentPage
    {
        Switch switchTest;
        Switch switchTest2;
        Switch switchTest3;
        Switch switchTest4;
        public SwitchExample()
        {

            Label _label = new Label
            {
                Text = "Harrison",
                //BackgroundColor = Color.Green,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
        };

            Label _labelLeft = new Label
            {
                Text = "Sportes",
                BackgroundColor = Color.YellowGreen,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
            };

            Label _label2 = new Label
            {
                Text = "Harrison",
                BackgroundColor = Color.Green,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
            };

            Label _labelLeft2 = new Label
            {
                Text = "Sportes",
                BackgroundColor = Color.YellowGreen,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
            };
            Label _label3 = new Label
            {
                Text = "Harrison",
                BackgroundColor = Color.Green,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
            };

            Label _labelLeft3 = new Label
            {
                Text = "Sportes",
                BackgroundColor = Color.YellowGreen,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
            };
            Label _label4 = new Label
            {
                Text = "Harrison",
                BackgroundColor = Color.Green,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
            };

            Label _labelLeft4 = new Label
            {
                Text = "Sportes",
                BackgroundColor = Color.YellowGreen,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
            };

            var layout = new StackLayout();

            switchTest = new Switch();
            switchTest.GridColor = Color.Red;

            switchTest.HorizontalOptions = LayoutOptions.Center;
            switchTest.VerticalOptions = LayoutOptions.Center;

            switchTest.RightView = _label;
            switchTest.LeftView = _labelLeft;

            switchTest.Content = _label;
            //switchTest2.IconSwitch.Content = _label2;
            // switchTest.WidthRequest = 400;*
            // switchTest.GridWidth = 300;
            switchTest.SwitchHeightRequest = 100;
            switchTest.SwitchWidthRequest = 150;
            switchTest.BackgroundHeightRequest = 100;
            switchTest.BackgroundWidthRequest = 300;
            switchTest.BackgroundColor = Color.Beige;
            switchTest.BackgroundContent = new Label() { Text = "OUIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII", VerticalOptions = LayoutOptions.Center };

            // switchTest.Toggled += TapSwitch;
            switchTest.Toggled += ToggledEvent;


            layout.Children.Add(switchTest);

            switchTest2 = new Switch();
            switchTest2.HorizontalOptions = LayoutOptions.Center;
            switchTest2.VerticalOptions = LayoutOptions.Center;

            switchTest2.RightView = _label2;
            switchTest2.LeftView = _labelLeft2;

            switchTest2.Content = _label2;
            // switchTest2.WidthRequest = 400;*
            // switchTest2.GridWidth = 300;
            switchTest2.SwitchHeightRequest = 110;
            switchTest2.SwitchWidthRequest = 150;
            switchTest2.BackgroundHeightRequest = 75;
            switchTest2.BackgroundWidthRequest = 150;
            // switchTest2.BackgroundFitSwitch();
            //
            //
            // switchTest2.WidthRequest = 100;
            //switchTest2.SpaceSize(30);
            //switchTest2.PrincipalFrame.HeightRequest = 100;
            //switchTest2.PrincipalFrame.WidthRequest = 50;

            layout.Children.Add(switchTest2);

            switchTest3 = new Switch();
            switchTest3.HorizontalOptions = LayoutOptions.Center;
            switchTest3.VerticalOptions = LayoutOptions.Center;

            switchTest3.RightView = _label3;
            switchTest3.LeftView = _labelLeft3;

            switchTest3.Content = _label3;
            // switchTest3.WidthRequest = 400;*
            // switchTest3.GridWidth = 300;
            switchTest3.SwitchHeightRequest = 75;
            switchTest3.SwitchWidthRequest = 75;
            switchTest3.BackgroundHeightRequest = 120;
            switchTest3.BackgroundWidthRequest = 200;
            // switchTest3.BackgroundFitSwitch();
            //
            //
            // switchTest3.WidthRequest = 100;
            //switchTest3.SpaceSize(30);
            //switchTest3.PrincipalFrame.HeightRequest = 100;
            //switchTest3.PrincipalFrame.WidthRequest = 50;

            layout.Children.Add(switchTest3);

            switchTest4 = new Switch();
            switchTest4.HorizontalOptions = LayoutOptions.Center;
            switchTest4.VerticalOptions = LayoutOptions.Center;

            switchTest4.RightView = _label4;
            switchTest4.LeftView = _labelLeft4;

            switchTest4.Content = _label4;
            // switchTest4.WidthRequest = 400;*
            // switchTest4.GridWidth = 300;
            switchTest4.SwitchHeightRequest = 80;
            switchTest4.SwitchWidthRequest = 100;
            switchTest4.BackgroundHeightRequest = 100;
            switchTest4.BackgroundWidthRequest = 220;
            // switchTest4.BackgroundFitSwitch();
            //
            //
            // switchTest4.WidthRequest = 100;
            //switchTest4.SpaceSize(30);
            //switchTest4.PrincipalFrame.HeightRequest = 100;
            //switchTest4.PrincipalFrame.WidthRequest = 50;

            layout.Children.Add(switchTest4);

            Button _button = new Button
            {
                Text = "ClickOnMe",
                BackgroundColor = Color.Red,
                WidthRequest = 100,
                
                VerticalOptions = LayoutOptions.Center,
            };
            _button.Clicked += ChangeLabel;
            layout.Children.Add(_button);

            // Tester de metttre un button qui change la vue de droite !
            Content = layout;
            var lol = switchTest.IconSwitch.HeightRequest;
        }

        private void TapSwitch(object sender, ToggledEventArgs e)
        {

            Label _labelRight = new Label
            {
                Text = "SUCCESSSSS",
                HeightRequest = 100,
                WidthRequest = 50,
                BackgroundColor = Color.Pink,
            };
            switchTest.LeftView = _labelRight;
        }

        private void ChangeLabel(object sender, EventArgs e)
        {
      //      Label _labelRight = new Label
      //      {
      //          Text = "Gonon",
      //          HeightRequest = 100,
      //          WidthRequest = 50,
      //          BackgroundColor = Color.Pink,
      //      };
      //      switchTest.BackgroundFitSwitch();
      ////      switchTest.TouchActionType.Off;
      //      //switchTest.RightView = _labelRight;
      //      //switchTest.LeftView = _labelRight;
      //      //switchTest.IconSwitch.Content = _labelRight;
        }

        public void ToggledEvent(object sender, ToggledEventArgs e)
        {
            //Toggled?.Invoke(sender, e);
            bool lol = e.Value;
        }
    }
}