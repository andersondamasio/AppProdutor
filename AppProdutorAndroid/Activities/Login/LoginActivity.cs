using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using com.datacoper.appprodutor.Activities.Principal;
using com.datacoper.appprodutor.Dto.Result;
using com.datacoper.appprodutor.Dto.Temperatura;
using Org.Json;

namespace com.datacoper.appprodutor.Activities.Login
{
    [Activity(Label = "Login - Entre")]
    public class LoginActivity : BaseActivity
    {
        #region Componentes da Tela
        private Button ovBT_Entrar { get { return FindViewById<Button>(Resource.Id.ovBT_Entrar); } }
        private EditText ovET_Usuario { get { return FindViewById<EditText>(Resource.Id.ovET_Usuario); } }
        private EditText ovET_Senha { get { return FindViewById<EditText>(Resource.Id.ovET_Senha); } }
        private CheckBox ovCB_MeLembrar { get { return FindViewById<CheckBox>(Resource.Id.ovCB_MeLembrar); } }
        
        #endregion
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Login);

            ovBT_Entrar.Click += OvBT_Entrar_Click;

        }

        private async void OvBT_Entrar_Click(object sender, EventArgs e)
        {
           await AutenticarAsync();
        }


       private async System.Threading.Tasks.Task AutenticarAsync()
        {

            try
            {
                SetProgressBarIndeterminateVisibility(true);
                string token = await Core.Utils.Data.AutenticarAsync(ovET_Usuario.Text.Trim(), ovET_Senha.Text.Trim(), ovCB_MeLembrar.Checked);

                if (token == null)
                {
                    RunOnUiThread(() =>
                    {
                        Toast.MakeText(this, "Usuário Incorreto.", ToastLength.Long).Show();
                        SetProgressBarIndeterminateVisibility(false);
                    });
                    return;
                }
                JSONObject obj = new JSONObject(token);
                String id_token = obj.GetString("id_token");

                var listToken = id_token.Split('.');
            }
            catch
            {
                SetProgressBarIndeterminateVisibility(false);
            }

            SetProgressBarIndeterminateVisibility(false);

            Intent intent = new Intent(this, typeof(PrincipalActivity));
            intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
            StartActivity(intent);

        }

    }
}