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

namespace com.datacoper.appprodutor.Adapters.Noticia
{
   public class NoticiaInternaAdapter : ArrayAdapter<NoticiaInternaDto>
    {

        private Activity context;
        private List<NoticiaInternaDto> itens;

        public NoticiaInternaAdapter(Activity context, List<NoticiaInternaDto> itens)
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

            View view = convertView ?? context.LayoutInflater.Inflate(Resource.Layout.NoticiaInternaTemplate, null);

            TextView ovTV_Titulo = view.FindViewById<TextView>(Resource.Id.ovTV_Titulo);
            TextView ovTV_Conteudo = view.FindViewById<TextView>(Resource.Id.ovTV_Conteudo);

            ovTV_Titulo.Text = $"Código: {item.titulo.ToString()}";
            ovTV_Conteudo.Text = $"Descricao: {item.conteudo}";

            return view;
        }

    }
}