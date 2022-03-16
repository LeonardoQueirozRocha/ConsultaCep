using Microsoft.AspNetCore.Mvc;
using Pjus.App.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Pjus.App.Controllers
{
    public class EnderecosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index(string cep)
        {
            EnderecoViewModel endereco = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44336/api/");

                var responseTask = client.GetAsync($"enderecos/ObterEndereco/{cep}");
                responseTask.Wait();
                var result = responseTask.Result;

                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<EnderecoViewModel>();
                    readTask.Wait();
                    endereco = readTask.Result;
                }

                return View(endereco);
            }

        }
    }
}
