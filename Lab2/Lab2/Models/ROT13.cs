using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Models
{
    class ROT13 : ICipher
    {
        public string Text { get; set; }

        private const string AlphabetEng = @"abcdefghijklmnopqrstuvwxyz";
        private const string AlphabetRus = @"абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        private bool IsLatin(char letter)
        {
            if (AlphabetEng.IndexOf(char.ToLower(letter)) == -1)
                return false;
            return true;
        }
        public string Encode(string text)
        {
            var letters = text.ToCharArray();
            for (var i = 0; i < letters.Length; i++)
                if (char.IsLetter(letters[i]))
                {
                    var isLowerCase = char.IsLower(letters[i]);
                    if (IsLatin(letters[i]))
                        letters[i] = AlphabetEng[(AlphabetEng.IndexOf(char.ToLower(letters[i])) + 13) % AlphabetEng.Length];
                    else
                        letters[i] = AlphabetRus[(AlphabetRus.IndexOf(char.ToLower(letters[i])) + 13) % AlphabetRus.Length];
                    if (!isLowerCase)
                        letters[i] = char.ToUpper(letters[i]);
                }

            return string.Join("", letters);
        }

        public string Decode(string text)
        {
            var letters = text.ToCharArray();
            for (var i = 0; i < letters.Length; i++)
                if (char.IsLetter(letters[i]))
                {
                    var isLowerCase = char.IsLower(letters[i]);
                    if (IsLatin(letters[i]))
                        letters[i] = AlphabetEng[(AlphabetEng.Length + AlphabetEng.IndexOf(char.ToLower(letters[i])) - 13) % AlphabetEng.Length];
                    else
                        letters[i] = AlphabetRus[(AlphabetRus.Length + AlphabetRus.IndexOf(char.ToLower(letters[i])) - 13) % AlphabetRus.Length];
                    if (!isLowerCase)
                        letters[i] = char.ToUpper(letters[i]);
                }

            return string.Join("", letters);
        }
    }
}

