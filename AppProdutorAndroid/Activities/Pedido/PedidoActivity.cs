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
using com.datacoper.appprodutor.Dto.Pedido;

namespace com.datacoper.appprodutor.Activities.Noticia
{
    [Activity(Label = "Pedidos")]
    public class PedidoActivity : BaseActivity
    {

        private ListView ovLV_Pedido { get { return FindViewById<ListView>(Resource.Id.ovLV_Pedido); } }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Pedido);

            ListarPedido();
        }

        private async void ListarPedido()
        {
            SetProgressBarIndeterminateVisibility(true);
            try
            {
                string url = "http://192.168.25.2:8080/api/produtor/1/pedidos";
                var listPedidos = await Core.Utils.Data.GetJSonAsync<List<PedidoDto>>(url);
                ovLV_Pedido.Adapter = new PedidoAdapter(this, listPedidos);
            }
            catch (Exception ex)
            {
                Toast.MakeText(this, "Não foi possível acessar o serviço" + ex.Message, ToastLength.Long).Show();
            }
            SetProgressBarIndeterminateVisibility(false);

        }


    }
}