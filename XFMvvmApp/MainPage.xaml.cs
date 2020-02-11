using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DK.SlidingPanel.Interface;
using Plugin.FacebookClient;
using Plugin.FacebookClient.Abstractions;
using Xamarin.Forms;

namespace XFMvvmApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //body.TranslationY = Main.Height + 500;
        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            //string discAmnt = price.Text;
            //Debug.WriteLine("String :" +discAmnt);
            //Debug.WriteLine("Double :" + Convert.ToDouble(discAmnt));
            //Debug.WriteLine("Int :" + Convert.ToInt32(discAmnt));
            FacebookResponse<bool> response = await CrossFacebookClient.Current.LoginAsync(new string[] { "email", "public_profile" });

        }
        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            SlidingPanelConfig config = new SlidingPanelConfig();
            //config.MainStackLayout = mainStackLayout;

            StackLayout titleStackLayout = new StackLayout();
            titleStackLayout.Children.Add(new Label { Text = "Test Title x" });
            //config.TitleStackLayout = titleStackLayout;
            config.TitleBackgroundColor = Color.Green;

            //spTest.ApplyConfig(config);
        }
    }
}
