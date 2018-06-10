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
using com.datacoper.appprodutor.Dto.Temperatura;

namespace com.datacoper.appprodutor.Adapters.PrevisaoTempo
{
    public class PrevisaoTempoAdapter : ArrayAdapter<TemperaturaDto>
    {
  
        private Activity context;
        private List<TemperaturaDto> itens;


        public PrevisaoTempoAdapter(Activity context, List<TemperaturaDto> itens)
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

            View view = convertView ?? context.LayoutInflater.Inflate(Resource.Layout.PrevisaoTempoTemplate, null);

            TextView ovTV_Local = view.FindViewById<TextView>(Resource.Id.ovTV_Local);
            TextView ovTV_TemperaturaMaxima = view.FindViewById<TextView>(Resource.Id.ovTV_TemperaturaMaxima);
            TextView ovTV_Condicoes = view.FindViewById<TextView>(Resource.Id.ovTV_Condicoes);

            ovTV_Local.Text = "Cascavel - PR";
            ovTV_TemperaturaMaxima.Text =  $"Temp. Max: {item.temp_c}";
            ovTV_Condicoes.Text = $"Condições: {(item.wx_desc.Equals("Mostly cloudy") ? "Parcialmente Nublado" : item.wx_desc)}";

            return view;
        }

    }
}
