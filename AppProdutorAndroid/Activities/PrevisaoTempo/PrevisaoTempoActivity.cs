using Android.App;
using Android.OS;
using Android.Widget;
using com.datacoper.appprodutor.Adapters.PrevisaoTempo;
using com.datacoper.appprodutor.Dto.Temperatura;
using System;
using System.Collections.Generic;

namespace com.datacoper.appprodutor.Activities.PrevisaoTempo
{
    [Activity(Label = "Previsão do Tempo")]
    public class PrevisaoTempoActivity : BaseActivity
    {
        private ListView ovLV_PrevisaoTempo { get { return FindViewById<ListView>(Resource.Id.ovLV_PrevisaoTempo); } }
    
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.PrevisaoTempo);

            ListarTemperaturas();

        }

        private async void ListarTemperaturas()
        {
            SetProgressBarIndeterminateVisibility(true);

            try
            {
                string url = "http://api.weatherunlocked.com/api/current/-24.942,-53.396?app_id=58ab80e7&app_key=363f6752948a16d995ef907a05fad7ad";
                var listPrevisaoTempo = await Core.Utils.Data.GetJSonAsync<TemperaturaDto>(url);

                /*listPrevisaoTempo = new List<TemperaturaDto>();
                listPrevisaoTempo.Add(new TemperaturaDto() { local = "Cascavel - PR", temp_c = "11 C", windspd_kmh = "30 KM/H" });
                listPrevisaoTempo.Add(new TemperaturaDto() { local = "Curitiba - PR", temp_c = "15 C", windspd_kmh = "21 KM/H" });
                listPrevisaoTempo.Add(new TemperaturaDto() { local = "Londrina - PR",  temp_c = "18 C", windspd_kmh = "10 KM/H" });
                */

                ovLV_PrevisaoTempo.Adapter = new PrevisaoTempoAdapter(this, new List<TemperaturaDto> { listPrevisaoTempo });

            }
            catch (Exception ex)
            {
                Toast.MakeText(this, "Não foi possível acessar o serviço" + ex.Message, ToastLength.Long).Show();
            }

            SetProgressBarIndeterminateVisibility(false);

        }


    }
}