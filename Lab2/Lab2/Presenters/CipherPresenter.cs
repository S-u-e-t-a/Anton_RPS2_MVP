using Lab2.Models;
using Lab2.Views;
using System.Windows.Forms;

namespace Lab2.Presenters
{
    public class CipherPresenter 
    {
        ICipherAlgs cipherView;

        public CipherPresenter(ICipherAlgs view)
        {
            cipherView = view;
        }

        public void EncodeAtbash()
        {
            var atbash = new Atbash();
            atbash.Text = cipherView.InputText;

            cipherView.ResultText = atbash.Encode(atbash.Text);
        }
        public void EncodeRot13()
        {
            var rot13 = new ROT13();
            rot13.Text = cipherView.InputText;

            cipherView.ResultText = rot13.Encode(rot13.Text);
        }

        public void DecodeAtbash()
        {
            var atbash = new Atbash();
            atbash.Text = cipherView.InputText;

            cipherView.ResultText = atbash.Decode(atbash.Text);
        }
        public void DecodeRot13()
        {
            var rot13 = new ROT13();
            rot13.Text = cipherView.InputText;

            cipherView.ResultText = rot13.Decode(rot13.Text);
        }

        public void SaveInput()
        {
            var savingInput = new SaveData();
            savingInput.SaveEnteredData(cipherView.Path, cipherView.ResultText);
            MessageBox.Show(@"Данные сохранены",
                @"Информация");
        }

        public void SaveResult()
        {
            var savingRes = new SaveData();
            savingRes.SaveResults(cipherView.Path, cipherView.InputText, cipherView.ResultText, cipherView.CipherMethod);
            MessageBox.Show(@"Результаты сохранены",
                @"Информация");
        }
    }
}
