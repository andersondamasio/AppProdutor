using com.datacoper.appprodutor.Dto.Usuario;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace com.datacoper.appprodutor.Core.Utils
{
    public class Data
    {
        public static async Task<T> GetJSonAsync<T>(string url)
        {
            T result = default(T);
            try
            {
                HttpClient httpClient = new HttpClient();

                httpClient.DefaultRequestHeaders.Add("Accept", "application/json");

                Task<string> task = httpClient.GetStringAsync(url);
                var retorno = await task;
                result = JsonConvert.DeserializeObject<T>(retorno);
            }
            catch (Exception ex)
            {
                return result;
            }
            return result;
        }

        public static async Task<String> GetTokenJSonAsync(string url, string data)
        {
            string retorno = null;
            try
            {
                var httpClient = new HttpClient();

                HttpContent conteudo = new StringContent(data);
                conteudo.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                httpClient.DefaultRequestHeaders.Add("Accept", "application/json");

                var response = await httpClient.PostAsync(url, conteudo);

                response.EnsureSuccessStatusCode();

                retorno = await response.Content.ReadAsStringAsync();

                return retorno;

            }
            catch (Exception ex)
            {

            }
            return retorno;
        }


        public static async Task<String> AutenticarAsync(string usuario, string senha, bool lembrarSenha)
        {
            string retorno = null;
            try
            {

                UsuarioDto usuarioDto = new UsuarioDto();
                usuarioDto.username = usuario;
                usuarioDto.password = senha;
                usuarioDto.rememberMe = lembrarSenha;

                string json = JsonConvert.SerializeObject(usuarioDto);

                string url = "http://192.168.25.2:8080/api/authenticate";
                retorno = await Core.Utils.Data.GetTokenJSonAsync(url, json);//"{username: "admin", password: "admin", rememberMe: true}");

            }
            catch
            {
                return null;

            }
            return retorno;
        }

    }
}
