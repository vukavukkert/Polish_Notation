using polishNotation;

while (true)
{
    Console.Write("Введите выражение: ");
    Console.WriteLine(PolishNotation.Calculate(Console.ReadLine()));
}