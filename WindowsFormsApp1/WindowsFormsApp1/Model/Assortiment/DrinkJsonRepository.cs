using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model.Assortiment
{
    public class DrinkJsonRepository : IAssortimentRepository
    {
        public readonly string JsonPath;
        public List<Delish> delishs;


        public DrinkJsonRepository(string filename)
        {
            Console.WriteLine(Path.GetTempPath());
            JsonPath = Path.Combine(Path.GetTempPath(), filename);
            if (!File.Exists(JsonPath))
            {
                CreateDrinkJsonStub();
            }

            LoadFromFile();
        }

        public void CreateDrinkJsonStub()
        {

            List<Delish> Delishs = new List<Delish>
                {
                new Delish("КОФЕ АМЕРИКАНО", "Напитки", "120.00", "200", "Черный кофе, приготовленный методом добавления воды в эспрессо"),
                new Delish("ЧАЙ ЗЕЛЕНЫЙ", "Напитки", "80.00", "250", "Зеленый чай, заваренный кипятком"),
                new Delish("КАПУЧИНО", "Напитки", "150.00", "180", "Кофе на основе эспрессо с добавлением вспененного молока"),
                new Delish("ЛАТТЕ", "Напитки", "160.00", "200", "Кофе на основе эспрессо с добавлением молока"),
                new Delish("ФРЕШ АПЕЛЬСИНОВЫЙ", "Напитки", "200.00", "250", "Свежевыжатый апельсиновый сок")
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
