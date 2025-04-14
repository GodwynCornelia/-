using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model.Product
{
    public class Product
    {

        public string Name { get; private set; }

        public string Unit { get; set; }
        public string Overprice { get; set; }
        public string Remains { get; set; }
        public Provide Provide { get; private set; }

        public Product(string name, string unit, string overprice, string remains, Provide provide)
        {

            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Наименование продукта не может быть пустой.");
            if (string.IsNullOrWhiteSpace(unit))
                throw new ArgumentException("Еденица измерения не может быть пустой.");
            if (string.IsNullOrWhiteSpace(overprice))
                throw new ArgumentException("Значение наценки измерения не может быть пустой.");
            if (string.IsNullOrWhiteSpace(remains))
                throw new ArgumentException("Значение остатка не может быть пустой.");
            if (provide == null)
                throw new ArgumentNullException(nameof(provide));



            Name = name;
            Unit = unit;
            Overprice = overprice;
            Remains = remains;
            Provide = provide;

        }
    }
}
