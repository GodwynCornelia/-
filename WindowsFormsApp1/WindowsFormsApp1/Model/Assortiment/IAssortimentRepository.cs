using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model.Assortiment
{
    public interface IAssortimentRepository
    {
        IEnumerable<Delish> GetAllDelish();
        
        Delish GetDelish(int Id);
        void AddDelish(Delish delish);
        void SaveDelish(int Id, Delish delish);
    }
}
