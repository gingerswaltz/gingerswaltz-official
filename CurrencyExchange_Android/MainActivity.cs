using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
namespace CurrencyExchange_Android
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        // Это строка определяет метод OnCreate()
        // и указывает, что он переопределяет базовый метод OnCreate(),
        // который находится в родительском классе Activity.
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState); // Эта строка вызывает метод OnCreate() из базового класса Activity.
            Xamarin.Essentials.Platform.Init(this, savedInstanceState); // Эта строка инициализирует платформу Xamarin.Essentials
            SetContentView(Resource.Layout.activity_main); // Эта строка устанавливает макет для активности.
                                                           // Она загружает макет, определенный в файле activity_main.axml и отображает его на экране устройства.


            /// Эти строки инициализируют и устанавливают тулбар для этой активности. 
            /// FindViewById() используется для получения ссылки на элемент Toolbar из макета, и затем SetSupportActionBar() 
            /// используется для установки этого тулбара в качестве основного действия для этой активности.
            AndroidX.AppCompat.Widget.Toolbar toolbar = FindViewById<AndroidX.AppCompat.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);



            /// Эти строки находят ссылку на кнопку, 
            /// определенную в макете и устанавливают обработчик нажатия на кнопку. 
            /// Когда пользователь нажимает на эту кнопку, метод OnButtonClick() будет вызван.
            Button button = FindViewById<Button>(Resource.Id.button2);
            button.Click += OnButtonClick;


        }
        // Метод добавляет элементы меню, определенные в XML-файле "menu_main" в папке "Menu" в папке "Resources" проекта.
        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }


        /*В этом коде проверяется идентификатор выбранного элемента меню.
            Если он соответствует идентификатору Resource.Id.action_settings, 
            то возвращается значение true, что означает, что событие выбора элемента меню было обработано.
            Если идентификатор не соответствует, то
            метод вызывает базовую реализацию 
            OnOptionsItemSelected и возвращает ее результат.*/
        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_settings)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }



        /// обработка события нажатия кнопки.
        private async void OnButtonClick(object sender, EventArgs e)
        {
            try
            {
                decimal exchangeRate = await GetExchangeRate(); // асинхронно принимаем курс доллара к рублю из метода
                TextView exchangerateTextView = FindViewById<TextView>(Resource.Id.exchangeRateTextView); // получаем ссылку на TextView
                exchangerateTextView.Text = $"Курс доллара США к рублю: {exchangeRate}"; // проецируем курс
            }
            catch (Exception ex)
            {
                Toast.MakeText(this, ex.Message, ToastLength.Long).Show();
            }
        }

        // Этот метод является частью жизненного цикла активности и вызывается, когда приложение запрашивает разрешение
        // у пользователя для выполнения определенных действий,
        // например, доступа к камере или геолокации.
        // Он используется для обработки результатов запроса разрешений, предоставляемых пользователем.

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults); // обрабатывает результаты запроса разрешений.

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults); // Затем метод передает управление методу базового класса, чтобы он тоже мог обработать результаты.
        }




        //Вместо того чтобы блокировать главный поток пользовательского интерфейса (UI),
        //который отвечает за обработку событий ввода-вывода и взаимодействие с пользователем, метод GetExchangeRate() выполняется асинхронно.
        //Это позволяет освободить главный поток пользовательского интерфейса и не допустить замерзания интерфейса во время выполнения длительных операций ввода-вывода.

        //  Операции ввода-вывода выполняются в отдельном потоке, 
        //      который управляется фреймворком.NET.
        //      При этом главный поток пользовательского интерфейса остается доступным для обработки событий 
        //      пользовательского ввода и вывода.Когда операция завершается, результат возвращается в главный поток, 
        //     где он может быть обработан дальше.

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
                decimal exchangeRate = responseData.rates.RUB;

                return exchangeRate;
            }
            else
            {
                // Обработка ошибки
                throw new Exception("Ошибка при получении курса валют");
            }
        }


    }
}
