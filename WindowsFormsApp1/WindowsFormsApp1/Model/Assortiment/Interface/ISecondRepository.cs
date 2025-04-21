using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model.Assortiment.Interface
{
    public interface ISecondRepository
    {
        IEnumerable<Delish> GetAllSecond();

        Delish GetSecond(int Id);
        void AddSecond(Delish delish);
        void SaveSecond(int Id, Delish delish);
    }
}
