using ChildCaseMgt.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChildCaseMgt
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new FirstScreen());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
