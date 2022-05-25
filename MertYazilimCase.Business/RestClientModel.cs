using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using MertYazilimCase.Data.Models;

namespace MertYazilimCase.Business
{
    public class RestClientModel
    {
        private string BASE_URL = "http://localhost:5000/api/sensor/";

        public Task<HttpResponseMessage> create(Sensor sensor)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                return client.PostAsJsonAsync("create", sensor);
            }
            catch
            {
                return null;
            }
        }

    }
}