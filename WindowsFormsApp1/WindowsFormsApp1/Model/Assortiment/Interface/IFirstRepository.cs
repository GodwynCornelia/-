using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model.Assortiment.Interface
{
    public interface IFirstRepository
    {
        IEnumerable<Delish> GetAllFirst();

        Delish GetFirst(int Id);
        void AddFirst(Delish delish);
        void SaveFirst(int Id, Delish delish);
    }
}
