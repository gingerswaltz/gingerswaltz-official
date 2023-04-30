using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Content;
using AndroidX.AppCompat.App;
using Google.Android.Material.BottomNavigation;
using System;
namespace UILang_AndroidOS
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity, BottomNavigationView.IOnNavigationItemSelectedListener
    {
        TextView textMessage;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            textMessage = FindViewById<TextView>(Resource.Id.message);
            BottomNavigationView navigation = FindViewById<BottomNavigationView>(Resource.Id.navigation);
            navigation.SetOnNavigationItemSelectedListener(this);
            Button myButton = FindViewById<Button>(Resource.Id.myButton);
            myButton.Click += MyButton_Click;

        }

        private void MyButton_Click(object sender, EventArgs e)
        {
            Android.App.AlertDialog.Builder builder = new Android.App.AlertDialog.Builder(this);
            builder.SetMessage("Капибара?");
            bool isCancelPressed = false;

            builder.SetNegativeButton("Cancel", (sender, args) =>
            {
                builder.SetCancelable(false);
                builder.SetMessage("Капибара осуждает вас");
                isCancelPressed = true;
                builder.Show();
            });

            builder.SetPositiveButton("OK", (sender, args) =>
            {
                if (!isCancelPressed)
                {
                    var uri = Android.Net.Uri.Parse("https://i.gifer.com/9ZNS.gif");
                    var intent = new Intent(Intent.ActionView, uri);
                    StartActivity(intent);
                }
            });

            Android.App.AlertDialog dialog = builder.Create();
            dialog.Show();



        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
        public bool OnNavigationItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.navigation_home:
                    textMessage.SetText(Resource.String.title_home);
                    return true;
                case Resource.Id.navigation_dashboard:
                    textMessage.SetText(Resource.String.title_dashboard);
                    return true;
                case Resource.Id.navigation_notifications:
                    textMessage.SetText(Resource.String.title_notifications);
                    return true;
            }
            return false;
        }
    }
}

