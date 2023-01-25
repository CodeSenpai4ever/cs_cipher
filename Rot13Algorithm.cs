using System.Text;
using System.Text.RegularExpressions;

namespace cs_cipher {
    public class Rot13Algorithm : IAlgorithm {
        public string Name => "ROT13";
        public string To(string input) {
            // This is the method that encrypts the input
            return Rotate(input, 13);
        }

        public string From(string input) {
            // This is the method that decrypts the input
            return Rotate(input, -13);
        }
        
        private string Rotate(string input, int offset) {
            // This is the method that rotates the input by the offset without symbols
            char[] ascii = input.ToCharArray();
            for (int i = 0; i < ascii.Length; i++) {
                if (char.IsLetter(ascii[i])) {
                    ascii[i] = (char)(ascii[i] + offset);
                }
            }
            return new string(ascii);
        }
    }
}