using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WindowsFormsApp1.Model.Assortiment
{
    public class Delish
    {
        public string Name { get; set; }
        public string Group { get; set; }

        public string Price { get; set; }
        public string Exit { get; set; }
        public string Description { get; set; }


        public Delish(string name=".", string group = ".", string price = ".", string exit=".", string description=".")
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Название поставщика не может быть пустым.");
            if (string.IsNullOrWhiteSpace(group))
                throw new ArgumentException("Название группы не может быть пустой.");
            if (string.IsNullOrWhiteSpace(price))
                throw new ArgumentException("цена за блюдо не может быть пустым.");
            if (string.IsNullOrWhiteSpace(exit))
                throw new ArgumentException("Выходной вес не может быть пустым.");
            if (string.IsNullOrWhiteSpace(description))
                throw new ArgumentException("Описание не может быть пустым.");



            Name = name;
            Group = group;
            Exit = exit;
            Description = description;
            Price = price;


        }


    }

}
