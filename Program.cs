// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string name = "First example";
string result = string.Empty;

// one
void String_Reverse_FOR()
{
    for (int i = 0; i < name.Length; i++)
    {
        result = $"{name[i]}{result}";
    }
    Console.WriteLine(result);
}

// two
void CharArray_Reverse()
{
    char[] cName = name.ToCharArray();
    Array.Reverse(cName);
    Console.WriteLine(cName);
    result = new String(cName);
    Console.WriteLine(result);

}
