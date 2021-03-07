using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Models
{
    public interface ICipher
    {
        string Text { get; set; }

        string Encode(string text);
        string Decode(string text);
    }
}
