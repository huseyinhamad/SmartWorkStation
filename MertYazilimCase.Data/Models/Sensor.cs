using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MertYazilimCase.Data.Models
{
    public class Sensor
    {
        private List<Sensor> filteredSensors;

        public Sensor()
        {

        }
        public Sensor(List<Sensor> filteredSensors)
        {
            foreach (var sensor in filteredSensors)
            {
                this.SensorId = sensor.SensorId;
                this.WorkStationId = sensor.WorkStationId;
                this.Temperature = sensor.Temperature;
                this.Pressure = sensor.Pressure;
                this.Status = sensor.Status;
                this.Date = sensor.Date;
            }
        }

        public int SensorId { get; set; }
        public int WorkStationId { get; set; }
        public double Temperature { get; set; }
        public double Pressure { get; set; }
        public bool Status { get; set; }
        public DateTime Date { get; set; }
    }
}
