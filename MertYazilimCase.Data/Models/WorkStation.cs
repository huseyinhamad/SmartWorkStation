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
    public class WorkStation
    {
        public WorkStation()
        {
            this.Personels = new HashSet<Personel>();
            this.Sensors = new HashSet<Sensor>();
        }
        public int WorkStationId { get; set; }
        public int ProductLineId { get; set; }
        public string WorkStationName { get; set; }
        public ICollection<Personel> Personels { get; set; }
        public ICollection<Sensor> Sensors { get; set; }

    }
}
