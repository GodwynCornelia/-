using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model.Assortiment.Interface
{
    public interface ISaladRepository
    {
        IEnumerable<Delish> GetAllSalad();

        Delish GetSalad(int Id);
        void AddSalad(Delish delish);
        void SaveSalad(int Id, Delish delish);
    }
}
