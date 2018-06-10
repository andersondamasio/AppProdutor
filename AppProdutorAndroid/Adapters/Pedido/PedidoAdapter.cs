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
using com.datacoper.appprodutor.Dto.Noticia;
using com.datacoper.appprodutor.Dto.Pedido;

namespace com.datacoper.appprodutor.Adapters.Noticia
{
    public class PedidoAdapter : ArrayAdapter<PedidoDto>
    {

        private Activity context;
        private List<PedidoDto> itens;

        public PedidoAdapter(Activity context, List<PedidoDto> itens)
            : base(context, Android.Resource.Layout.SimpleListItem1, itens)
        {
            this.context = context;
            this.itens = itens;
        }


        public override int Count
        {
            get { return itens.Count; }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override Android.Views.View GetView(int position, Android.Views.View convertView, Android.Views.ViewGroup parent)
        {
            var item = itens[position];

            View view = convertView ?? context.LayoutInflater.Inflate(Resource.Layout.PedidoTemplate, null);


            TextView ovTV_Data = view.FindViewById<TextView>(Resource.Id.ovTV_Data);
            TextView ovTV_NumeroPedido = view.FindViewById<TextView>(Resource.Id.ovTV_NumeroPedido);
            TextView ovTV_Quantidade = view.FindViewById<TextView>(Resource.Id.ovTV_Quantidade);
            TextView ovTV_Produto = view.FindViewById<TextView>(Resource.Id.ovTV_Produto);
            TextView ovTV_ValorUnitario = view.FindViewById<TextView>(Resource.Id.ovTV_ValorUnitario);
            TextView ovTV_ValorTotal = view.FindViewById<TextView>(Resource.Id.ovTV_ValorTotal);
            TextView ovTV_QuantidadeFaturada = view.FindViewById<TextView>(Resource.Id.ovTV_QuantidadeFaturada);
            TextView ovTV_ValorFatudaro = view.FindViewById<TextView>(Resource.Id.ovTV_ValorFatudaro);
            TextView ovTV_ValorAFaturar = view.FindViewById<TextView>(Resource.Id.ovTV_ValorAFaturar);
            TextView ovTV_QuantidadeAFaturar = view.FindViewById<TextView>(Resource.Id.ovTV_QuantidadeAFaturar);
            TextView ovTV_Produtor = view.FindViewById<TextView>(Resource.Id.ovTV_Produtor);
            TextView ovTV_Status = view.FindViewById<TextView>(Resource.Id.ovTV_Status);


            ovTV_Data.Text = $"Data: {item.data}";
            ovTV_NumeroPedido.Text = $"N.: {item.numeroPedido.ToString()}";
            ovTV_Quantidade.Text = $"Quant: {item.quantidade.ToString()}";
            ovTV_Produto.Text = $"Num: {item.produto.ToString()}";
            ovTV_ValorUnitario.Text = $"Valor Un: {item.valorUnitario.ToString()}";
            ovTV_ValorTotal.Text = $"Valor Tot: {item.valorTotal.ToString("C")}";
            ovTV_QuantidadeFaturada.Text = $"Quant. Fat: {item.quantidadeFaturada.ToString()}";
            ovTV_ValorFatudaro.Text = $"Valor Fat: {item.valorFatudaro.ToString("C")}";
            ovTV_ValorAFaturar.Text = $"Valor a Fat: {item.valorAFaturar.ToString("C")}";
            ovTV_QuantidadeAFaturar.Text = $"Quant. a Fat: {item.quantidadeAFaturar.ToString("C")}";
            ovTV_Produtor.Text = $"Produtor: {item.produtor}";
            ovTV_Status.Text = $"Status: {item.status}";

            return view;
        }

    }
}