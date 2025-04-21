using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model.Assortiment.Interface
{
    public interface IDrinkRepository
    {
        IEnumerable<Delish> GetAllDrink();

        Delish GetDrink(int Id);
        void AddDrink(Delish delish);
        void SaveDrink(int Id, Delish delish);
    }
}
