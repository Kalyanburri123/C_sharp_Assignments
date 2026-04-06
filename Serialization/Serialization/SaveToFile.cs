using System.IO;
using System.Text.Json;

namespace Serialization
{
    public static class SaveToFile
    {
        private static string filePath = @"C:\Users\DELL\OneDrive\Documents\Json.txt";

        public static void Save(Account acc)
        {
            string json = JsonSerializer.Serialize(acc);
            File.WriteAllText(filePath, json);
        }

        public static Account Load()
        {
            if (!File.Exists(filePath))
                return null;

            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<Account>(json);
        }
    }
}
