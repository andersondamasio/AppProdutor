using Android.App;
using Android.Views;
using Android.Widget;
using com.datacoper.appprodutor.Dto.Cotacao;
using System.Collections.Generic;

namespace com.datacoper.appprodutor.Adapters.Cotacao
{
    public class CotacaoAdapter : ArrayAdapter<CotacaoDto>
    {

        private Activity context;
        private List<CotacaoDto> itens;

        public CotacaoAdapter(Activity context, List<CotacaoDto> itens)
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

            View view = convertView ?? context.LayoutInflater.Inflate(Resource.Layout.CotacaoTemplate, null);

            TextView ovTV_IdProduto = view.FindViewById<TextView>(Resource.Id.ovTV_IdProduto);
            TextView ovTV_Descricao = view.FindViewById<TextView>(Resource.Id.ovTV_Descricao);
            TextView ovTV_ValorCotacao = view.FindViewById<TextView>(Resource.Id.ovTV_ValorCotacao);
            TextView ovTV_DataCotacao = view.FindViewById<TextView>(Resource.Id.ovTV_DataCotacao);

            ovTV_IdProduto.Text = $"Código: {item.idProduto.ToString()}";
            ovTV_Descricao.Text = $"Descricao: {item.descricao}";
            ovTV_ValorCotacao.Text = $"Valor: {item.valorCotacao.ToString("C")}";
            ovTV_DataCotacao.Text = $"Data: {item.dataCotacao.ToShortDateString()}";

            return view;
        }

    }
}