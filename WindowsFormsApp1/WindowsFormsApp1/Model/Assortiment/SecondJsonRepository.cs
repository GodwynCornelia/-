using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model.Assortiment
{
    public class SecondJsonRepository : IAssortimentRepository
    {
        public readonly string JsonPath;
        public List<Delish> delishs;


        public SecondJsonRepository(string filename)
        {
            Console.WriteLine(Path.GetTempPath());
            JsonPath = Path.Combine(Path.GetTempPath(), filename);
            if (!File.Exists(JsonPath))
            {
                CreateSecondJsonStub();
            }

            LoadFromFile();
        }

        public void CreateSecondJsonStub()
        {

            List<Delish> Delishs = new List<Delish>
                {
                new Delish("ЖАРКОЕ ПО-ДОМАШНЕМУ", "Вторые блюда", "400.00", "300", "Картофель с мясом и овощами, тушеный в горшочке."),
                new Delish("ПЛОВ", "Вторые блюда", "450.00", "350", "Рис с мясом, морковью и специями."),
                new Delish("КОТЛЕТЫ ПО-КИЕВСКИ", "Вторые блюда", "380.00", "200", "Куриная котлета с начинкой из сливочного масла и зелени."),
                new Delish("МАКАРОНЫ ПО-ФЛОТСКИ", "Вторые блюда", "320.00", "250", "Макароны с мясным фаршем."),
                new Delish("ГОЛУБЦЫ", "Вторые блюда", "350.00", "280", "Капустные листья, фаршированные рисом и мясом, тушеные в соусе.")
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
