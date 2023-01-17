// See https://aka.ms/new-console-template for more information
using BasicExamples;
using System.Text.RegularExpressions;

Console.WriteLine("Hello, World!");

//

void String_Reverse_FOR()
{
    string name = "First example";
    string result = string.Empty;
    for (int i = 0; i < name.Length; i++)
    {
        result = $"{name[i]}{result}";
    }
    Console.WriteLine(result);
}

void CharArray_Reverse()
{
    string name = "First example";
    string result = string.Empty;
    char[] cName = name.ToCharArray();
    Array.Reverse(cName);
    Console.WriteLine(cName);
    result = new String(cName);
    Console.WriteLine(result);
}

// 
CountCharacterRepeated_ForEach();
void CountCharacterRepeated_ForEach()
{
    string characters = "eufjnasdasdfjkkjlbgfkjdf09834jkgdsfn,mfdipt90fjdkg";
    char character = 'j';
    int count = 0;
    foreach (char c in characters)
    {
        if(c == character)
            count++;
    }
    Console.WriteLine($"Caracter: {character}, se repite: {count} veces.");

}

CountCharacterRepeated_Linq();
void CountCharacterRepeated_Linq()
{
    string characters = "eufjnasdasdfjkkjlbgfkjdf09834jkgdsfn,mfdipt90fjdkg";
    char character = 'j';
    int count = characters.Where(c=> c == character).Count();
    Console.WriteLine($"Caracter: {character}, se repite: {count} veces.");

}

HammingDistance();
void HammingDistance()
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