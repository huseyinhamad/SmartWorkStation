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
    public class Alarm
    {
        public int AlarmId { get; set; }
        public int WorkStationId { get; set; }
        public double MinimumTemperature { get; set; }
        public double MaximumTemperature { get; set; }
        public double MinimumPressure { get; set; }
        public double MaximumPressure { get; set; }
    }
}
