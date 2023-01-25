namespace cs_cipher
{
    public interface IAlgorithm
    {
        string Name { get; } 
        string To(string input); // This is the method that encrypts the input
        string From(string input); // This is the method that decrypts the input
    }
}