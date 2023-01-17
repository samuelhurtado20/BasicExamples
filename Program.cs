// See https://aka.ms/new-console-template for more information
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

