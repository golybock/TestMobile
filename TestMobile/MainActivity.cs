using System;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using TestMobile.Api.Models;

namespace TestMobile
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private Button _loginButton;
        private EditText _codeEditText;
        private Api.Api _api;
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            _loginButton = FindViewById<Button>(Resource.Id.login_button);
            _codeEditText = FindViewById<EditText>(Resource.Id.code_edit_text);

            _api = new Api.Api();

            _loginButton.Click += delegate
            {
                LoginAsync();
            };
            
        }

        private async void LoginAsync()
        {
            var code = _codeEditText.Text;

            try
            {
                var res = await _api.Login(code);
            
                if (res)
                {
                    RunOnUiThread(() =>
                    {
                        var passActivity = new Intent(this, typeof(PassActivity));
                        StartActivity(passActivity);
                    });

                }
                else
                {
                    RunOnUiThread(() =>
                    {
                        var toast = Toast.MakeText(this, "Неверный логин или пароль", ToastLength.Short);
                        toast.Show();
                    });
                }
            }
            catch (Exception e)
            {
                RunOnUiThread(() =>
                {
                    var error = Toast.MakeText(this, "Ошибка подключения", ToastLength.Short);
                    error.Show();
                    _codeEditText.Text = e.ToString();
                });

            }

        }
    }
}