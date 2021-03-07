namespace Lab2.Models
{
    public interface ICipher
    {
        string Encode(string text);
        string Decode(string text);
    }
}
