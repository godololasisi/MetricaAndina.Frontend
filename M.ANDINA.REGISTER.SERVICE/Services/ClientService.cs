using M.ANDINA.REGISTER.APPLICATION.Interfaces;
using M.ANDINA.REGISTER.DOMAIN;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace M.ANDINA.REGISTER.SERVICE.Services
{
    public class ClientService : IClientService
    {
        private readonly IConfiguration _config;
        private readonly string _baseurl;
        public ClientService(IConfiguration config)
        {
            _config = config;
            _baseurl = _config[$"microservices:client:url"]!;

        }
        public async Task<Client> GetClientService()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseurl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var httpResponse = await client.GetAsync($"clients/");
                var resultContent = httpResponse.Content.ReadAsStringAsync().Result;
                if (httpResponse.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<Client>(resultContent)!;
                }
                throw new InvalidOperationException("There was an error calling the Microservice. " + resultContent ?? "");
            }
            throw new InvalidOperationException("There was an issue when calling the microservice.");
        }
    }
}
