using Android.App;
using Android.Content.PM;
using Android.OS;

namespace QRCodeScanner.Droid
{
  [Activity(Label = "QRCodeScanner", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
  public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
  {
    protected override void OnCreate(Bundle bundle)
    {
      base.OnCreate(bundle);

      global::Xamarin.Forms.Forms.Init(this, bundle);
      LoadApplication(new App());

      ZXing.Net.Mobile.Forms.Android.Platform.Init();
    }

    public override void OnRequestPermissionsResult(int requestCode, string[] permissions, Permission[] grantResults)
    {
      ZXing.Net.Mobile.Forms.Android.PermissionsHandler.OnRequestPermissionsResult(requestCode, permissions, grantResults);
    }
  }
}

