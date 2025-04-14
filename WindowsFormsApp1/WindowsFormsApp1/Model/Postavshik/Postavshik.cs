using System;
using System.Collections.Generic;


namespace WindowsFormsApp1
{
    public class Provide
    {
        public string Name { get; private set; }
        public string Addres { get; set; }
        public string FIO { get; set; }
        public string Phone { get; set; }
        public string Bank { get; set; }
        public string Check { get; set; }
        public string INN { get; set; }

        public Provide(string name=".", string addres=".", string fio=".", string phone=".", string bank = ".", string check = ".", string inn = ".")
        {

            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Название поставщика не может быть пустым.");
            if (string.IsNullOrWhiteSpace(addres))
                throw new ArgumentException("Адрес поставщика не может быть пустым.");
            if (string.IsNullOrWhiteSpace(fio))
                throw new ArgumentException("ФИО поставщика не может быть пустым");
            if (string.IsNullOrWhiteSpace(phone))
                throw new ArgumentException("Телефон поставщика не может быть пустым.");
            if (string.IsNullOrWhiteSpace(bank))
                throw new ArgumentException("Наименование банка не может быть пустым");
            if (string.IsNullOrWhiteSpace(check))
                throw new ArgumentException("Расчётный счёт не может быть пустым");
            if (string.IsNullOrWhiteSpace(inn))
                throw new ArgumentException("ИНН не может быть пустым.");

            Name = name;
            Addres = addres;
            FIO = fio;
            Phone = phone;
            Bank = bank;
            Check = check;
            INN = inn;
        }
    }
}
