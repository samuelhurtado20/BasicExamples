using System.Collections;
using System.Globalization;
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

    internal void HammingDistance(string wordOne, string wordTwo)
    {
        int distance = 0;
        if (wordOne.Length != wordTwo.Length) throw new Exception("the words does not have the same length");

        for (int i = 0; i < wordOne.Length; i++)
        {
            if (wordOne[i] != wordTwo[i])
                distance++;
        }
        Console.WriteLine($"Hamming Distance is: {distance}, between: {wordOne} and {wordTwo}.");
    }

    internal void WordCounter(string text)
    {
        //string text = "¡Ja, ja! Esta es la historia de las tres caravelas La Niña, la Pinta y la Santa MaríaAy, no, no, no, no, no Esas eran de don Cristóbal Colón No, yo voy a cantar el barco chiquito El barco de Cepillín";
        text = Regex.Replace(text, @"\s+", " ").Trim();
        int count = text.Split(" ").Length;
        Console.WriteLine($"Numero de palabras en el texto es: {count}");
    }

    internal void NumberCounter(string text)
    {
        string pattern = @"[0-9]";
        var regex = new Regex(pattern);
        //string text = "En la edición 2022, el informe señala que el número de usuarios de internet en el mundo alcanzó los 4,950 millones de personas, lo que representa al 62,5% de la población mundial (7.910 millones de personas).";
        int count = regex.Matches(text).Count();
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

    internal bool TwoNumbresSumOther_FOR(int sum, List<int> numbers)
    {
        for (int i = 0; i < numbers.Count; i++)
        {
            for (int j = 1; j < numbers.Count - 1; j++)
            {
                if (numbers[i] + numbers[j] == sum)
                {
                    Console.WriteLine($"Encontrado. {numbers[i]} mas {numbers[j]} es igual a {sum}");
                    return true;
                }
            }
        }

        Console.WriteLine($"No Encontrado dos numeros que sumen igual a {sum}.");
        return false;
    }

    internal bool TwoNumbresSumOther_HASH(int sum, List<int> numbers)
    {
        HashSet<int> hashSet = new HashSet<int>();
        for (int i = 0; i < numbers.Count; i++)
        {
            if (hashSet.Contains(numbers[i]))
            {
                Console.WriteLine($"Encontrado dos numeros que sumen igual a {sum}.");
                return true;
            }
            hashSet.Add(sum - numbers[i]);
        }

        Console.WriteLine($"No Encontrado dos numeros que sumen igual a {sum}.");
        return false;
    }

    internal void WordRepetitions(string text)
    {
        Dictionary<string, int> list = new();
        string[] separated = text.Split(" ");
        foreach (string word in separated)
        {
            if (list.ContainsKey(word)) ++list[word];
            else list.Add(word, 1);
        }
        foreach (var ele in list)
        {
            Console.WriteLine("{0} = {1}", ele.Key, ele.Value);
        }
    }

    internal IEnumerable GetMonthNames(string culture)
    {
        for (int i = 0; i < 12; i++)
            yield return new DateTime(2020, i + 1, 1)
                .ToString("MMMM", CultureInfo.CreateSpecificCulture(culture));
    }




}
