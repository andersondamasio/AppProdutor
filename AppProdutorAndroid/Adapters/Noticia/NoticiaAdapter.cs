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
   public class NoticiaAdapter : ArrayAdapter<NoticiaDto>
    {

        private Activity context;
        private List<NoticiaDto> itens;

        public NoticiaAdapter(Activity context, List<NoticiaDto> itens)
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

            View view = convertView ?? context.LayoutInflater.Inflate(Resource.Layout.NoticiaTemplate, null);

            TextView ovTV_Titulo = view.FindViewById<TextView>(Resource.Id.ovTV_Titulo);
            TextView ovTV_Conteudo = view.FindViewById<TextView>(Resource.Id.ovTV_Conteudo);
            TextView ovTV_Autor = view.FindViewById<TextView>(Resource.Id.ovTV_Autor);
            TextView ovTV_Data = view.FindViewById<TextView>(Resource.Id.ovTV_Data);

            ovTV_Titulo.Text = $"Código: {item.title.ToString()}";
            ovTV_Conteudo.Text = $"Descricao: {item.content}";
            ovTV_Autor.Text = $"Valor: {item.author}";
            ovTV_Data.Text = $"Data: {item.pubDate.ToShortDateString()}";

            return view;
        }

    }
}