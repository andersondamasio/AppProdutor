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
using com.datacoper.appprodutor.Dto.Cotacao;
using com.datacoper.appprodutor.Adapters.Cotacao;

namespace com.datacoper.appprodutor.Activities.Cotacao
{
    [Activity(Label = "Cotações")]
    public class CotacaoActivity : BaseActivity
    {

        private ListView ovLV_Cotacao { get { return FindViewById<ListView>(Resource.Id.ovLV_Cotacao); } }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Cotacao);

            ListarCotacao();
        }

        private async void ListarCotacao()
        {
            SetProgressBarIndeterminateVisibility(true);
            try
            {
                string url = "http://192.168.25.217:8080/api/produtor/1/produtos";
                var listCotacao = await Core.Utils.Data.GetJSonAsync<List<CotacaoDto>>(url);
                ovLV_Cotacao.Adapter = new CotacaoAdapter(this, listCotacao);
            }
            catch (Exception ex)
            {
                Toast.MakeText(this, "Não foi possível acessar o serviço" + ex.Message, ToastLength.Long).Show();
            }
            SetProgressBarIndeterminateVisibility(false);

        }


    }
}