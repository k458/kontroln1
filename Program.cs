string[] strings = new string[5];
int wordsAdded = 0;

void PrintStringArray(string[] strings)
{
    Console.Write("[");
    for (int i = 0; i < strings.Length; i++)
    {
        if (strings[i].Length >= 4) continue;
        Console.Write('"' + strings[i] + '"');
        if (i < strings.Length - 1) Console.Write(", ");
    }
    Console.Write("]");
}

while (true)
{
    if (wordsAdded >= 5) break;
    Console.Write($"Введите слово({1 + wordsAdded} из 5): ");
    string input = Console.ReadLine();
    if (input == "start" && wordsAdded > 0) break;
    strings[wordsAdded] = input;
    wordsAdded++;
}
Console.WriteLine("Results: ");

