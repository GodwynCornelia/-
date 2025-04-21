using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model.Assortiment.Interface
{
    public interface IDesertRepository
    {
        IEnumerable<Delish> GetAllDesert();

        Delish GetDesert(int Id);
        void AddDesert(Delish delish);
        void SaveDesert(int Id, Delish delish);
    }
}
