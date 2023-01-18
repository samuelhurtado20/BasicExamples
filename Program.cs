// See https://aka.ms/new-console-template for more information
using BasicExamples;

Console.WriteLine("Hello, World!");

// 
Tests tests = new Tests();

CountCharacterRepeated_ForEach();
void CountCharacterRepeated_ForEach()
{
    string characters = "sdffqwrtpo34587gnvoq348rqtg5bsñldfaiowefsdfgzxaerqazzaq";
    char character = 'a';
    tests.CountCharacterRepeated_ForEach(characters, character);
}

CountCharacterRepeated_Linq();
void CountCharacterRepeated_Linq()
{
    string characters = "sdffqwrtpo34587gnvoq348rqtg5bsñldfaiowefsdfgzxaerqazzaq";
    char character = 'a';
    tests.CountCharacterRepeated_Linq(characters, character);
}

HammingDistance();
void HammingDistance()
{
    throw new NotImplementedException();
}

WordCounter();
void WordCounter()
{
    throw new NotImplementedException();
}

NumberCounter();
void NumberCounter()
{
    throw new NotImplementedException();
}

IsPrimeNumber();
void IsPrimeNumber()
{
    Console.Write($"Ingresa un numero para comprobar si es Primo:");
    int number = int.Parse(Console.ReadLine() ?? "5");
    bool resp = tests.IsPrimeNumber(number);
    Console.WriteLine(resp ? $"El numero {number} es primo." : $"El numero {number} no es primo.");
}