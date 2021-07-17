using System;

namespace july7._8
{
     class Encrypter
    {
        public static string Encrypt(string text)
        {
            int textInt = 0;
            char inputText = ' ';
            string textEncripted = "";
            for (int i = 0; i < text.Length; i++)
            {
                textInt = (int)text[i] + 1;
                inputText = (char)textInt;
                textEncripted += inputText.ToString();
            }
            return textEncripted;
        }

        public static string Decrypt(string text)
        {
            int textInt = 0;
            char inputText = ' ';
            string textDecripted = "";
            for (int i = 0; i < text.Length; i++)
            {
                textInt = (int)text[i] - 1;
                inputText = (char)textInt;
                textDecripted += inputText.ToString();
            }
            return textDecripted;
        }
    }

    class TextEncripted
    {
        static void Main()
        {
            bool debug = true;

            string newText = Encrypter.Encrypt("Hello");
            Console.WriteLine("Text encripted: {0}", newText);
            string TextDecripted = Encrypter.Decrypt(newText);
            Console.WriteLine("Text Decripted: {0}", TextDecripted);

            if (debug)
                Console.ReadLine();
        }
    }
} 

    

