using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace TestProject.Week1.Day1
{
    public static class Reader
    {
        public static async Task<int[]> LoadAsync(string fileName)
        {
            var file = GetFile(fileName);

            List<int> numbers = new();

            using (var reader = new StreamReader(file))
            {
                while (true)
                {
                    var line = await reader.ReadLineAsync();
                    if (line is null)
                    {
                        break;
                    }

                    if (int.TryParse(line, out var number))
                    {
                        numbers.Add(number);
                    }
                }
            }

            return numbers.ToArray();
        }
        

        private static string GetFile(string fileName)
        {
            var files = Directory.GetFiles(
                Directory.GetCurrentDirectory(),
                fileName,
                SearchOption.AllDirectories
            );
            if (files == null || files.Length == 0)
                throw new Exception("ExpenseFile not found.");
            
            return files[0];
        }
    }
}