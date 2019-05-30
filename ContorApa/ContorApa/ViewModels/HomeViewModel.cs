using ContorApa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContorApa.ViewModels
{
    public class HomeViewModel
    {
        public List<ContorIndex> ContorIndexes { get; set; }
        public int TotalHot { get; set; }
        public int TotalCold { get; set; }
    }
}
