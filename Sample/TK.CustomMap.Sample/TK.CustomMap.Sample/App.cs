﻿using TK.CustomMap.Api;
using TK.CustomMap.Api.Google;
using Xamarin.Forms;

namespace TK.CustomMap.Sample
{
    public class App : Application
    {
        public App()
        {
            GmsPlace.Init("YOUR API KEY");
            GmsDirection.Init("YOUR API KEY");

            // The root page of your application
            MainPage = new NavigationPage(new SamplePage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
            TKNativePlacesApi.Instance.DisconnectAndRelease();
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
