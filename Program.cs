Console.WriteLine("Введите элементы массива (через пробел):");
string input = Console.ReadLine();
string[] inputArray = input.Split(' ');

int count = 0;
for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            count++;
        }
    }

string[] resultArray = new string[count];
int index = 0;
for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            resultArray[index] = inputArray[i];
            index++;
        }
    }

Console.WriteLine();

Console.Write("Массив: [");
for (int i = 0; i < inputArray.Length; i++)
    {
        if (i != 0)
            Console.Write(", ");
        Console.Write("\"" + inputArray[i] + "\"");
    }
Console.WriteLine("]");

Console.WriteLine();

Console.Write("Результат работы программы: [");
for (int i = 0; i < resultArray.Length; i++)
    {
        if (i != 0)
            Console.Write(", ");
        Console.Write("\"" + resultArray[i] + "\"");
    }
    Console.WriteLine("]");
