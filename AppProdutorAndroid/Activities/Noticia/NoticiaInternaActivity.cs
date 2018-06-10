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
using com.datacoper.appprodutor.Adapters.Noticia;
using com.datacoper.appprodutor.Dto.Noticia;

namespace com.datacoper.appprodutor.Activities.Noticia
{
    [Activity(Label = "Notícias Internas")]
    public class NoticiaInternaActivity : BaseActivity
    {

        private ListView ovLV_Noticia { get { return FindViewById<ListView>(Resource.Id.ovLV_Noticia); } }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Noticias);

            ListarNoticiaInterna();
        }

        private async void ListarNoticiaInterna()
        {
            SetProgressBarIndeterminateVisibility(true);
            try
            {
                string url = "http://192.168.25.2:8080/api/produtor/1/noticias";
                var listNoticia = await Core.Utils.Data.GetJSonAsync<List<NoticiaInternaDto>>(url);
                ovLV_Noticia.Adapter = new NoticiaInternaAdapter(this, listNoticia);
            }
            catch (Exception ex)
            {
                Toast.MakeText(this, "Não foi possível acessar o serviço" + ex.Message, ToastLength.Long).Show();
            }
            SetProgressBarIndeterminateVisibility(false);

        }


    }
}