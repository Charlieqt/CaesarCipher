using System;

class CaesarCipher
{
    static void Main()
    {
        Console.Write("Enter the word to encrypt: ");
        string originalText = Console.ReadLine();

        Console.Write("Enter the shift value: ");
        int shift = int.Parse(Console.ReadLine());

        string encryptedText = Encrypt(originalText, shift);
        Console.WriteLine($"Encrypted: {encryptedText}");

        string decryptedText = Decrypt(encryptedText, shift);
        Console.WriteLine($"Decrypted: {decryptedText}");
    }

    static string Encrypt(string text, int shift)
    {
        char[] result = new char[text.Length];

        for (int i = 0; i < text.Length; i++)
        {
            char character = text[i];

            if (char.IsLetter(character))
            {
                char baseLetter = char.IsUpper(character) ? 'A' : 'a';
                result[i] = (char)((character - baseLetter + shift + 26) % 26 + baseLetter);
            }
            else
            {
                result[i] = character;
            }
        }

        return new string(result);
    }

    static string Decrypt(string text, int shift)
    {
        return Encrypt(text, -shift);
    }
}
