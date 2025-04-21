using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WindowsFormsApp1.Model.Assortiment.Interface;

namespace WindowsFormsApp1.Model.Assortiment
{
    public class FirstJsonRepository : IFirstRepository
    {
        public readonly string JsonPath;
        public List<Delish> delishs;


        public FirstJsonRepository(string filename)
        {
            Console.WriteLine(Path.GetTempPath());
            JsonPath = Path.Combine(Path.GetTempPath(), filename);
            if (!File.Exists(JsonPath))
            {
                CreateFirstJsonStub();
            }

            LoadFromFile();
        }

        public void CreateFirstJsonStub()
        {

            List<Delish> Delishs = new List<Delish>
                {
                new Delish("БОРЩ", "Первые блюда", "280.00", "350", "Традиционный суп на основе свеклы с мясом и овощами."),
                new Delish("СОЛЯНКА", "Первые блюда", "320.00", "300", "Насыщенный суп с копченостями, солеными огурцами и маслинами."),
                new Delish("УХА", "Первые блюда", "300.00", "350", "Наваристый рыбный суп."),
                new Delish("КРЕМ-СУП ГРИБНОЙ", "Первые блюда", "250.00", "300", "Нежный крем-суп из шампиньонов."),
                new Delish("МИСО-СУП", "Первые блюда", "280.00", "250", "Традиционный японский суп на основе мисо-пасты.")
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

        public IEnumerable<Delish> GetAllFirst()
        {
            return delishs;
        }
        public Delish GetFirst(int id)
        {
            return delishs[id];
        }



        public void AddFirst(Delish delish)
        {
            delishs.Add(delish);
            SaveDelishList(delishs);
        }
        public void SaveFirst(int id, Delish delish)
        {
            delishs[id] = delish;
            SaveDelishList(delishs);
        }
    }
}
