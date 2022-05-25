using MertYazilimCase.Business;
using MertYazilimCase.Data.DataLayer;
using MertYazilimCase.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MertYazilimCase.ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MainAsync().Wait();
        }
        static async Task MainAsync()
        {
            DatabaseContext context = new DatabaseContext();
            RestClientModel restClientModel = new RestClientModel();
            var random = new Random();

            var workStations = context.WorkStations.ToList();
            int index = random.Next(workStations.Count);

            var sensor = new Sensor
            {
                WorkStationId = workStations[index].WorkStationId,
                Temperature = Math.Round(random.NextDouble() * (120 - 40) + 40, 2),
                Pressure = Math.Round(random.NextDouble() * (20 - 10) + 10, 2),
                Status = true,
                Date = DateTime.UtcNow
            };
            HttpResponseMessage httpResponseMessage = restClientModel.create(sensor).Result;

            HttpStatusCode httpStatusCode = httpResponseMessage.StatusCode;
            Console.WriteLine("Status Code: " + httpStatusCode);

            bool isSuccessStatusCode = httpResponseMessage.IsSuccessStatusCode;
            Console.WriteLine("IsSuccessStatusCode: " + isSuccessStatusCode);

            Console.ReadLine();
        }
    }
}