using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model.Assortiment
{
    public class DesertJsonRepository : IAssortimentRepository
    {
        public readonly string JsonPath;
        public List<Delish> delishs;


        public DesertJsonRepository(string filename)
        {
            Console.WriteLine(Path.GetTempPath());
            JsonPath = Path.Combine(Path.GetTempPath(), filename);
            if (!File.Exists(JsonPath))
            {
                CreateDesertJsonStub();
            }

            LoadFromFile();
        }

        public void CreateDesertJsonStub()
        {

            List<Delish> Delishs = new List<Delish>
                {
                new Delish("МОРОЖЕНОЕ ПЛОМБИР", "Десерты", "70.00", "100", "Классическое мороженое пломбир в вафельном стаканчике"),
                new Delish("ТИРАМИСУ", "Десерты", "220.00", "150", "Итальянский десерт с кофе, маскарпоне и печеньем савоярди"),
                new Delish("ЧИЗКЕЙК НЬЮ-ЙОРК", "Десерты", "250.00", "180", "Классический сливочный чизкейк на песочной основе"),
                new Delish("ШОКОЛАДНЫЙ ФОНДАН", "Десерты", "280.00", "120", "Шоколадный кекс с жидким шоколадом внутри, подается с шариком мороженого"),
                new Delish("МЕДОВИК", "Десерты", "200.00", "150", "Медовый торт с заварным кремом")
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

        public IEnumerable<Delish> GetAllDelish()
        {
            return delishs;
        }
        public Delish GetDelish(int id)
        {
            return delishs[id];
        }



        public void AddDelish(Delish delish)
        {
            delishs.Add(delish);
            SaveDelishList(delishs);
        }
        public void SaveDelish(int id, Delish delish)
        {
            delishs[id] = delish;
            SaveDelishList(delishs);
        }
    }
}
