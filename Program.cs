string[] strings = new string[5];
int wordsAdded = 0;

void PrintStringArray(string[] strings)
{
    if (strings == null) return;
    Console.Write("[");
    for (int i = 0; i < strings.Length; i++)
    {
        Console.Write('"' + strings[i] + '"');
        if (i < strings.Length - 1) Console.Write(", ");
    }
    Console.Write("]");
}
string[] GetFilteredStringArray(string[] strings)
{
    string[] ret = new string[strings.Length];
    int iRet = 0;
    for (int i = 0; i < strings.Length; i++)
    {
        if (strings[i].Length >= 4) continue;
        ret[iRet] = strings[i];
        iRet++;
    }
    if (iRet < strings.Length)
    {
        string[] ret1 = new string[iRet];
        for (int i = 0; i < iRet; i++)
        {
            ret1[i] = ret[i];
        }
        ret = ret1;
    }
    return ret;
}

while (true)
{
    if (wordsAdded >= 5) break;
    Console.Write($"Input words({1 + wordsAdded} of 5): ");
    string input = Console.ReadLine();
    if (input == "start" && wordsAdded > 0) break;
    strings[wordsAdded] = input;
    wordsAdded++;
}
PrintStringArray(strings);
Console.Write(" → ");
PrintStringArray(GetFilteredStringArray(strings));

