using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContorApa.Models
{
    public class ContorIndexRepository : IContorIndexRepository
    {
        private readonly AppDbContext _appDbContext;

        public ContorIndexRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<ContorIndex> GetAllIndexes()
        {
            return _appDbContext.ContorIndexes;
        }

        public ContorIndex GetContorIndexById(int id)
        {
            return _appDbContext.ContorIndexes.FirstOrDefault(p => p.Id == id);
        }

        public int GetTotalColdIndex()
        {
            return _appDbContext.ContorIndexes.Sum<ContorIndex>(a => a.BaieRece) + _appDbContext.ContorIndexes.Sum<ContorIndex>(b => b.BucatarieRece);
        }

        public int GetTotalHotIndex()
        {
            return _appDbContext.ContorIndexes.Sum<ContorIndex>(a => a.BaieCald) + _appDbContext.ContorIndexes.Sum<ContorIndex>(b => b.BucatarieCald);
        }
    }
}
