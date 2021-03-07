using System;
using System.IO;

namespace Lab2.Models
{
    public class SaveData 
    {
        public void SaveEnteredData(string path, string text)
        {
            File.WriteAllText(path, string.Empty);
            File.AppendAllText(path, text);
        }
        public void SaveResults(string path, string text, string result, string method)
        {
            File.WriteAllText(path, string.Empty);
            File.AppendAllText(path, @"Вы ввели следующий текст: " + Environment.NewLine + text + Environment.NewLine + Environment.NewLine);
            File.AppendAllText(path, @"Способ шифрования: " + Environment.NewLine + method + Environment.NewLine);
            File.AppendAllText(path, 
                Environment.NewLine + @"Результат шифрования/дешифрования " + Environment.NewLine + result +
                Environment.NewLine);
        }
    }
}
