using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model.Assortiment
{
    public class BakeryJsonRepository : IBakeryRepository
    {
        public readonly string JsonPath;
        public List<Delish> delishs;


        public BakeryJsonRepository(string filename)
        {
            Console.WriteLine(Path.GetTempPath());
            JsonPath = Path.Combine(Path.GetTempPath(), filename);
            if (!File.Exists(JsonPath))
            {
                CreateBakeryJsonStub();
            }

            LoadFromFile();
        }

        public void CreateBakeryJsonStub()
        {

            List<Delish> Delishs = new List<Delish>
                {
                new Delish("ВАТРУШКА С ТВОРОГОМ", "Выпечка", "80.00", "100", "Булочка из дрожжевого теста с творожной начинкой"),
                new Delish("ЭКЛЕР С ЗАВАРНЫМ КРЕМОМ", "Выпечка", "90.00", "70", "Заварное пирожное с нежным заварным кремом"),
                new Delish("ПИРОЖОК С КАПУСТОЙ", "Выпечка", "60.00", "80", "Жареный пирожок с капустой"),
                new Delish("ПИРОЖОК С КАРТОШКОЙ", "Выпечка", "60.00", "80", "Жареный пирожок с картофельной начинкой"),
                new Delish("КРУАССАН С ШОКОЛАДОМ", "Выпечка", "120.00", "60", "Слоеный круассан с шоколадной начинкой")
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

        public IEnumerable<Delish> GetAllBakery()
        {
            return delishs;
        }
        public Delish GetBakery(int id)
        {
            return delishs[id];
        }



        public void AddBakery(Delish delish)
        {
            delishs.Add(delish);
            SaveDelishList(delishs);
        }
        public void SaveBakery(int id, Delish delish)
        {
            delishs[id] = delish;
            SaveDelishList(delishs);
        }
    }
}
