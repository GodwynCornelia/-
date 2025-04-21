using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using WindowsFormsApp1.Model.Assortiment.Interface;
using WindowsFormsApp1.Model.Product;

namespace WindowsFormsApp1.Model.Assortiment
{
    public class SaladJsonRepository: ISaladRepository
    {
        public readonly string JsonPath;
        public List<Delish> delishs;


        public SaladJsonRepository(string filename)
        {
            Console.WriteLine(Path.GetTempPath());
            JsonPath = Path.Combine(Path.GetTempPath(), filename);
            if (!File.Exists(JsonPath))
            {
                CreateSaladJsonStub();
            }

            LoadFromFile();
        }

        public void CreateSaladJsonStub()
        {

            List<Delish> Delishs = new List<Delish>
                {
                new Delish("ГРЕЧЕСКИЙ", "Салаты", "320.00", "200", "Классический салат из свежих овощей, феты и маслин."),
                new Delish("ЦЕЗАРЬ С КУРИЦЕЙ", "Салаты", "380.00", "220", "Салат с куриным филе, гренками и соусом Цезарь."),
                new Delish("ОЛИВЬЕ", "Салаты", "280.00", "180", "Традиционный салат с вареными овощами, яйцами и колбасой."),
                new Delish("ВИНИГРЕТ", "Салаты", "250.00", "150", "Салат из вареных овощей и квашеной капусты."),
                new Delish("КРАБОВЫЙ", "Салаты", "300.00", "170", "Салат с крабовыми палочками, кукурузой и яйцами."),
                new Delish("СЕЛЬДЬ ПОД ШУБОЙ", "Салаты", "350.00", "250", "Салат из сельди, свеклы, моркови и картофеля.")
                };

            SaveDelishList(Delishs);
        }
        public void SaveDelishList(List<Delish> delishs)
        {
            var json = JsonSerializer.Serialize(delishs, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(JsonPath, json);
        }

        public void LoadFromFile()
        {
            var json = File.ReadAllText(JsonPath);
            delishs = JsonSerializer.Deserialize<List<Delish>>(json);
        }

        public IEnumerable<Delish> GetAllSalad()
        {
            return delishs;
        }
        public Delish GetSalad(int id)
        {
            return delishs[id];
        }



        public void AddSalad(Delish delish)
        {
            delishs.Add(delish);
            SaveDelishList(delishs);
        }
        public void SaveSalad(int id, Delish delish)
        {
            delishs[id] = delish;
            SaveDelishList(delishs);
        }
    }
}
