using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContorApa.Models
{
    public interface ICRUDIndexRepository
    {
        void AddIndex(ContorIndex contorIndex);
        void DeleteIndex(ContorIndex contorIndex);
        void UpdateIndex(ContorIndex contorIndex);

    }
}
