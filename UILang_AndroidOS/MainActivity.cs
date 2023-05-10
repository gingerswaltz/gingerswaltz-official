using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Content;
using AndroidX.AppCompat.App;
using Google.Android.Material.BottomNavigation;
using System;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;

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
          //  Button myButton = FindViewById<Button>(Resource.Id.myButton);
          //  myButton.Click += MyButton_Click;

        }

        private async void MyButton_Click(object sender, EventArgs e)
        {
            try
            {
                decimal exchangeRate = await GetExchangeRate();
                Toast.MakeText(this, $"Курс доллара США к евро: {exchangeRate}", ToastLength.Long).Show();
            }
            catch (Exception ex)
            {
                Toast.MakeText(this, ex.Message, ToastLength.Long).Show();
            }
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
                
            }
            return false;
        }

        private async Task<decimal> GetExchangeRate()
        {
            // URL для получения курса валют от ECB
            string url = "https://api.exchangerate-api.com/v4/latest/USD";

            // Создание экземпляра HttpClient
            HttpClient httpClient = new HttpClient();

            // Выполнение запроса и получение ответа
            HttpResponseMessage response = await httpClient.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                // Чтение ответа и получение курса доллара США к евро
                string responseString = await response.Content.ReadAsStringAsync();
                dynamic responseData = JsonConvert.DeserializeObject(responseString);
              decimal exchangeRate = responseData.rates.EUR;

                return 1;
            }
            else
            {
                // Обработка ошибки
                throw new Exception("Ошибка при получении курса валют");
            }
        }

    }


}

