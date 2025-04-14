using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Model
{
    public interface IProvideRepository
    {
        IEnumerable<Provide> GetAllProvides();
        Provide GetProvide(int id);
        void AddProvide(Provide provide);
        void SaveProvide(int id, Provide provide);
    }
}
