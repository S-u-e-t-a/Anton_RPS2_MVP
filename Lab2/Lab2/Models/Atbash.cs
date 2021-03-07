namespace Lab2.Models
{
    public class Atbash : ICipher
    {
        private const int SmthGoesWrong = -1;
        public string Text { get; set; }

        private const string AlphabetEng = @"abcdefghijklmnopqrstuvwxyz";
        private const string AlphabetRus = @"абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

        private string Reverse(string inputText)
        {
            var reversedText = string.Empty;
            foreach (var s in inputText)
            {
                reversedText = s + reversedText; //добавляем символ в начало строки
            }
            return reversedText;
        }
        private string EncryptDecrypt(char letter, string symbols, string cipher)
        {
            var outputText = string.Empty;
            var index = symbols.IndexOf(letter); //поиск позиции символа в строке алфавита
            if (index >= 0)
            {
                outputText += cipher[index].ToString(); //замена символа на шифр
            }
            return outputText;
        }
        private bool IsLatin(char letter)
        {
            if (AlphabetEng.IndexOf(char.ToLower(letter)) == SmthGoesWrong)
                return false;
            return true;
        }
        public string Encode(string text)
        {
            var result = string.Empty;
            var lettersText = text.ToCharArray();
            for (var i = 0; i < lettersText.Length; i++)
            {
                if (char.IsLetter(lettersText[i]))
                {
                    var isLowerCase = char.IsLower(lettersText[i]);
                    lettersText[i] = char.ToLower(lettersText[i]);
                    if (IsLatin(lettersText[i]))
                        if (isLowerCase)
                        {
                            result += EncryptDecrypt(lettersText[i], AlphabetEng, Reverse(AlphabetEng));
                        }
                        else
                        {
                            var tempRes = EncryptDecrypt(lettersText[i], AlphabetEng, Reverse(AlphabetEng));
                            result += tempRes.ToUpper();
                        }
                    else
                    {
                        if (isLowerCase)
                        {
                            result += EncryptDecrypt(lettersText[i], AlphabetRus, Reverse(AlphabetRus));
                        }
                        else
                        {
                            var tempRes = EncryptDecrypt(lettersText[i], AlphabetRus, Reverse(AlphabetRus));
                            result += tempRes.ToUpper();
                        }
                    }
                }
                else
                {
                    result += lettersText[i];
                }
            }
            return string.Join("", result);
        }

        public string Decode(string text)
        {
            var result = string.Empty;
            var lettersText = text.ToCharArray();
            for (var i = 0; i < lettersText.Length; i++)
            {
                if (char.IsLetter(lettersText[i]))
                {
                    var isLowerCase = char.IsLower(lettersText[i]);
                    lettersText[i] = char.ToLower(lettersText[i]);
                    if (IsLatin(lettersText[i]))
                        if (isLowerCase)
                        {
                            result += EncryptDecrypt(lettersText[i], Reverse(AlphabetEng), AlphabetEng);
                        }
                        else
                        {
                            var tempRes = EncryptDecrypt(lettersText[i], Reverse(AlphabetEng), AlphabetEng);
                            result += tempRes.ToUpper();
                        }
                    else
                    {
                        if (isLowerCase)
                        {
                            result += EncryptDecrypt(lettersText[i], Reverse(AlphabetRus), AlphabetRus);
                        }
                        else
                        {
                            var tempRes = EncryptDecrypt(lettersText[i], Reverse(AlphabetRus), AlphabetRus);
                            result += tempRes.ToUpper();
                        }
                    }
                }
                else
                {
                    result += lettersText[i];
                }
            }
            return string.Join("", result);
        }
    }
}
