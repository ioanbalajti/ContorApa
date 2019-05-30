using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContorApa.Models
{
    public class CRUDIndexRepository : ICRUDIndexRepository
    {
        private readonly AppDbContext _appDbContext;

        public CRUDIndexRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void AddIndex(ContorIndex contorIndex)
        {
            _appDbContext.ContorIndexes.Add(contorIndex);
            _appDbContext.SaveChanges();
        }

        public void UpdateIndex(ContorIndex contorIndex)
        {
            _appDbContext.ContorIndexes.Update(contorIndex);
            _appDbContext.SaveChanges();
        }

        public void DeleteIndex(ContorIndex contorIndex)
        {
            _appDbContext.ContorIndexes.Remove(contorIndex);
            _appDbContext.SaveChanges();
        }
    }
}
