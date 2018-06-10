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
using com.datacoper.appprodutor.Activities.PrevisaoTempo;
using com.datacoper.appprodutor.Activities.Cotacao;
using com.datacoper.appprodutor.Activities.Noticia;

namespace com.datacoper.appprodutor.Activities.Principal
{
    [Activity(Label = "App do Produtor")]
    public class PrincipalActivity : BaseActivity
    {
        private ImageButton ovIB_Clima { get { return FindViewById<ImageButton>(Resource.Id.ovIB_Clima); } }
        private ImageButton ovIB_Cotacao { get { return FindViewById<ImageButton>(Resource.Id.ovIB_Cotacao); } }
        private ImageButton ovIB_Noticias { get { return FindViewById<ImageButton>(Resource.Id.ovIB_Noticias); } }
        private ImageButton ovIB_NoticiasInternas { get { return FindViewById<ImageButton>(Resource.Id.ovIB_NoticiasInternas); } }
        private ImageButton ovIB_Pedido { get { return FindViewById<ImageButton>(Resource.Id.ovIB_Pedido); } }


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Principal);

            ovIB_Clima.Click += OvIB_Clima_Click;
            ovIB_Cotacao.Click += OvIB_Cotacao_Click;
            ovIB_Noticias.Click += OvIB_Noticias_Click;
            ovIB_NoticiasInternas.Click += OvIB_NoticiasInternas_Click;
            ovIB_Pedido.Click += OvIB_Pedido_Click;
        }

        private void OvIB_Clima_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(PrevisaoTempoActivity));
            StartActivity(intent);
        }

        private void OvIB_Cotacao_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(CotacaoActivity));
            StartActivity(intent);
        }

        private void OvIB_Noticias_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(NoticiaActivity));
            StartActivity(intent);
        }
        private void OvIB_NoticiasInternas_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(NoticiaInternaActivity));
            StartActivity(intent);
        }

        private void OvIB_Pedido_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(PedidoActivity));
            StartActivity(intent);
        }
  
    }
}