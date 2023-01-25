namespace cs_cipher
{
    public class CezarAlgorithm : IAlgorithm
    {
        public int Offset { get; set;}

        public string Name => "Cäsar";

        public string From(string input) {
            // This is the method that encrypts the input
            return Rotate(input, -Offset);
        }

        public string To(string input) {
            // This is the method that decrypts the input
            return Rotate(input, Offset);
        }

        private string Rotate(string input, int offset) {
            string alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] ascii = input.ToCharArray();

            // This is the method that rotates the input by the offset without symbols
            for (int i = 0; i < ascii.Length; i++)
            {
                int index = alphabet.IndexOf(ascii[i]);
                if (index != -1)
                {
                    int newIndex = (index + offset) % alphabet.Length;
                    if (newIndex < 0) { newIndex += alphabet.Length; }
                    ascii[i] = alphabet[newIndex];
                }
            }
            return new string(ascii);
        }

    }
}