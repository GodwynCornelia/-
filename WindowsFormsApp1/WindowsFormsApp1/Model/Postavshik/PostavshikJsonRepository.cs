using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace WindowsFormsApp1.Model
{
    public class ProvideJsonRepository: IProvideRepository
    {
        public readonly string JsonPath;
        public List<Provide> provides;

        public ProvideJsonRepository(string filename)
        {
            JsonPath = Path.Combine(Path.GetTempPath(), filename);
            if (!File.Exists(JsonPath))
            {
                CreateProvideJsonStub();
            }

            LoadFromFile();
        }
        public void CreateProvideJsonStub()
        {
            List<Provide> Provides = new List<Provide>
            {
                 new Provide("ООО 'Первый поставщик'", "ул. Центральная, 1", "Иванов И.И.", "123-45-67", "Сбербанк", "1234567890", "7701234567"),
                 new Provide("ЗАО 'Второй поставщик'", "просп. Мира, 10", "Петров П.П.", "987-65-43", "ВТБ", "0987654321", "7702345678"),
                 new Provide("ООО 'Третий поставщик'", "ул. Советская, 15", "Сидоров С.С.", "555-12-34", "Альфа-Банк", "5432109876", "7703456789"),
                 new Provide("ИП 'Четвертый поставщик'", "ул. Ленина, 20", "Кузнецов К.К.", "111-22-33", "Тинькофф", "6789012345", "7704567890"),
                 new Provide("ООО 'Пятый поставщик'", "ул. Гагарина, 5", "Смирнова А.А.", "444-55-66", "Райффайзенбанк", "2468013579", "7705678901"),
                 new Provide("ЗАО 'Шестой поставщик'", "ул. Пушкина, 12", "Попов В.В.", "777-88-99", "Газпромбанк", "9182736450", "7706789012")
            };
            SaveProvideList(Provides);
        }

        public void SaveProvideList(List<Provide> provides)
        {
            var json = JsonSerializer.Serialize(provides);
            File.WriteAllText(JsonPath, json);
        }

        public void LoadFromFile()
        {
            var json = File.ReadAllText(JsonPath);
            provides = JsonSerializer.Deserialize<List<Provide>>(json);
        }

        public IEnumerable<Provide> GetAllProvides()
        {
            return provides;
        }
        public Provide GetProvide(int id)
        {
            return provides[id];
        }
        public void AddProvide(Provide provide)
        {
            provides.Add(provide);
            SaveProvideList(provides);
        }

        public void SaveProvide(int id, Provide provide)
        {
            provides[id] = provide;
            SaveProvideList(provides);
        }
       
    }
}
