using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2.Views;
using Lab2.Models;

namespace Lab2.Presenters
{
    public class CipherPresenter
    {
        ICipher cipherView;

        public CipherPresenter(ICipher view)
        {
            cipherView = view;
        }

        public void Ciphering()
        {
            var atbash = new Atbash
        }
    }
}
