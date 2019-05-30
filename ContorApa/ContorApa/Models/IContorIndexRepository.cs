using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContorApa.Models
{
    public interface IContorIndexRepository
    {
        IEnumerable<ContorIndex> GetAllIndexes();
        ContorIndex GetContorIndexById(int id);
        int GetTotalHotIndex();
        int GetTotalColdIndex();
    }
}
