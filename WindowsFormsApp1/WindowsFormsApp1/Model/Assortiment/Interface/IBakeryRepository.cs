using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model.Assortiment
{
    public interface IBakeryRepository
    {
        IEnumerable<Delish> GetAllBakery();

        Delish GetBakery(int Id);
        void AddBakery(Delish delish);
        void SaveBakery(int Id, Delish delish);
    }
}
