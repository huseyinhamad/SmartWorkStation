using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MertYazilimCase.Data.Models
{
    public class ProductLine
    {
        private WorkStation workStation;
        private List<WorkStation> workStationsInProductLine;
     
        public int ProductLineId { get; set; }
        public string? ProductLineName { get; set; }
        public ICollection<WorkStation> WorkStations { get; set; }

    }
}
