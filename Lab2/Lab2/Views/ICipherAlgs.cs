namespace Lab2.Views
{
    public interface ICipherAlgs
    {
        string InputText { get; set; }
        string ResultText { get; set; }
        string Path { get; set; }
        string CipherMethod { get; set; }
    }
}
