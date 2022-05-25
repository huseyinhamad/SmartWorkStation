using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MertYazilimCase.Data.Models
{
    public class Personel
    {
        public Personel()
        {
            this.WorkStations = new HashSet<WorkStation>();
        }
        public int PersonelId { get; set; }
        public string? PersonelName { get; set; }
        public string? PersonelMail { get; set; }
        public int WorkStationId { get; set; }
        public ICollection<WorkStation> WorkStations { get; set; }
    }
}
