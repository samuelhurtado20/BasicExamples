// See https://aka.ms/new-console-template for more information
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
