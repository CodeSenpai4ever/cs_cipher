namespace cs_cipher {
    public class AtBashAlgorithm : IAlgorithm {
        public string Name => "AtBash";
        char[] _shift = new char[char.MaxValue];

        public AtBashAlgorithm()
        {
            // initialize the shift array
            for (int i = 0; i < char.MaxValue; i++)
            {
                _shift[i] = (char)i;
            }
            for (char c = 'A'; c <= 'Z'; c++)
            {
                _shift[(int)c] = (char)('Z' + 'A' - c);
            }

            for (char c = 'a'; c <= 'z'; c++)
            {
                _shift[(int)c] = (char)('z' + 'a' - c);
            }
        }

        public string From(string input)
        {
            // this is the method that encrypts the input
            return Rotate(input);
        }

        public string To(string input)
        {
            // this is the method that decrypts the input
            return Rotate(input);
        }

        private string Rotate(string value) {
            // convert the input string to ascii then use atbash to encrypt
            char[] ascii = value.ToCharArray();
            for (int i = 0; i < ascii.Length; i++)
            {
                ascii[i] = _shift[ascii[i]];
            }
            return new string(ascii);
        }
    }
}
