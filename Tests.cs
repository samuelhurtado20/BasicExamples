using System.Text.RegularExpressions;

namespace BasicExamples;

public class Tests
{
    public Tests()
    {
    }

    internal void String_Reverse_FOR(string str)
    {
        string result = string.Empty;
        for (int i = 0; i < str.Length; i++)
        {
            result = $"{str[i]}{result}";
        }
        Console.WriteLine(result);
    }

    internal void CharArray_Reverse(string str)
    {
        string result = string.Empty;
        char[] cName = str.ToCharArray();
        Array.Reverse(cName);
        Console.WriteLine(cName);
        result = new String(cName);
        Console.WriteLine(result);
    }

    internal void CountCharacterRepeated_ForEach(string characters, char character)
    {
        int count = 0;
        foreach (char c in characters)
        {
            if (c == character)
                count++;
        }
        Console.WriteLine($"Caracter: {character}, se repite: {count} veces.");

    }

    internal void CountCharacterRepeated_Linq(string characters, char character)
    {
        int count = characters.Where(c => c == character).Count();
        Console.WriteLine($"Caracter: {character}, se repite: {count} veces.");
    }

    internal void HammingDistance()
    {
        string wordOne = "Canibales";
        string wordTwo = "Hanibalos";
        int distance = 0;
        if (wordOne.Length != wordTwo.Length) throw new Exception("the words does not have the same length");

        for (int i = 0; i < wordOne.Length; i++)
        {
            if (wordOne[i] != wordTwo[i])
                distance++;
        }
        Console.WriteLine($"Hamming Distance is: {distance}, between: {wordOne} and {wordTwo}.");
    }

    internal void WordCounter()
    {
        string text = "¡Ja, ja! Esta es la historia de las tres caravelas La Niña, la Pinta y la Santa MaríaAy, no, no, no, no, no Esas eran de don Cristóbal Colón No, yo voy a cantar el barco chiquito El barco de Cepillín";
        int count = 0;

        text = Regex.Replace(text, @"\s+", " ").Trim();
        count = text.Split(" ").Length;


        Console.WriteLine($"Numero de palabras en el texto es: {count}");
    }

    internal void NumberCounter()
    {
        string text = "En la edición 2022, el informe señala que el número de usuarios de internet en el mundo alcanzó los 4,950 millones de personas, lo que representa al 62,5% de la población mundial (7.910 millones de personas).";
        int count = 0;
        string pattern = @"[0-9]";
        var regex = new Regex(pattern);
        count = regex.Matches(text).Count();
        Console.WriteLine($"Total de numeros en el texto es: {count}");
    }

    internal bool IsPrimeNumber(int number)
    {
        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }
}
