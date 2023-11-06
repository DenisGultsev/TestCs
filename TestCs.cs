Console.WriteLine("Введите строки через запятую:");
string input = Console.ReadLine();
string[] inputArray = input.Split(',');

int count = 0;
for (int i = 0; i < inputArray.Length; i++)
{
    if (inputArray[i].Trim().Length <= 3)
    {
        count++;
    }
}

string[] resultArray = new string[count];
int index = 0;
for (int i = 0; i < inputArray.Length; i++)
{
    if (inputArray[i].Trim().Length <= 3)
    {
        resultArray[index] = inputArray[i].Trim();
        index++;
    }
}

Console.Write("[");
for (int i = 0; i < resultArray.Length; i++)
{
    Console.Write("\"" + resultArray[i] + "\"");
    if (i < resultArray.Length - 1)
    {
        Console.Write(", ");
    }
}
Console.WriteLine("]");