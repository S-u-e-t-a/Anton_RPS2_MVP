using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2.Models
{
    public class SaveData 
    {
        public void SaveEnteredData(string path, string text)
        {
            File.WriteAllText(path, string.Empty);
            File.AppendAllText(path, text);
        }
        public void SaveResults(string path, string text, string result)
        {
            File.WriteAllText(path, string.Empty);
            File.AppendAllText(path, @"Вы ввели следующий текст: " + Environment.NewLine + text + Environment.NewLine);
            File.AppendAllText(path, 
                Environment.NewLine + @"Результат шифрования/дешифрования " + Environment.NewLine + result +
                Environment.NewLine);
        }
    }
}
