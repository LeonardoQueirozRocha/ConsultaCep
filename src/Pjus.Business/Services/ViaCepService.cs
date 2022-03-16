using Pjus.Business.Interfaces;
using Pjus.Business.Models;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Pjus.Business.Services
{
    public class ViaCepService : IViaCepService
    {
        public async Task<Endereco> ObterEndereco(string cep)
        {
            Endereco endereco = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri($"https://viacep.com.br/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync($"ws/{cep}/json/");
                if (response.IsSuccessStatusCode)
                {
                    endereco = await response.Content.ReadAsAsync<Endereco>();
                }

                return endereco;
            }
        }
    }
}
