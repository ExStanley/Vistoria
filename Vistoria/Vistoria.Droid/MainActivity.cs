using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Vistoria.Droid
{
    [Activity(Label = "Vistoria", Icon = "@drawable/VistoriaMobile", Theme = "@style/MainTheme", 
        MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            Xamarin.Forms.Forms.Init(this, bundle);

            var x = typeof(Xamarin.Forms.Themes.DarkThemeResources);
            x = typeof(Xamarin.Forms.Themes.LightThemeResources);
            x = typeof(Xamarin.Forms.Themes.Android.UnderlineEffect);

            LoadApplication(new App());
        }
    }
}

