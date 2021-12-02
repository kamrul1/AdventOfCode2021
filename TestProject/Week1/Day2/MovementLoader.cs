using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace TestProject.Week1.Day2
{
    public static class MovementLoader
    {
        private static string GetFile(string fileName)
        {
            var files = Directory.GetFiles(
                Directory.GetCurrentDirectory(),
                fileName,
                SearchOption.AllDirectories
            );
            if (files == null || files.Length == 0)
                throw new Exception($"File: {fileName} not found.");
            
            return files[0];
        }
        
        public static async Task<string[]> LoadAsync(string fileName)
        {
            var file = GetFile(fileName);

            List<string> movement = new();

            using (var reader = new StreamReader(file))
            {
                while (true)
                {
                    var line = await reader.ReadLineAsync();
                    if (line is null)
                    {
                        break;
                    }
                    movement.Add(line);
                }
            }

            return movement.ToArray();
        }
    }
}