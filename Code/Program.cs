Console.WriteLine("Сколько элементов будет в массиве?");
bool countElements = int.TryParse(Console.ReadLine(), out int count);

if (countElements == false)
{
    Console.WriteLine("Введены некорректные данные!");
}

string[] FillArray(int count)
{
    string[] arr = new string[count];

    for (int i = 0; i < count; i++)
    {
        Console.WriteLine("Введите что-нибудь");
        string element = Convert.ToString(Console.ReadLine());
        arr[i] = element;
    }
    return arr;
}

int GetCountElementsThreeSymbols(string[] arr)
{
    count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        string checkElement = arr[i];
        int simbolsElement = checkElement.Length;

        if (simbolsElement <= 3)
        {
            count++;
        }
    }
    return count;

}

string[] CreateArrFromeElementsTillThreeSimbols(string[] arr, int count)
{
    int index = 0;

    string[] resArr = new string[count];

    for (int i = 0; i < arr.Length; i++)
    {
        string checkElement = arr[i];
        int simbolsElement = checkElement.Length;

        if (simbolsElement <= 3)
        {
            resArr[index] = arr[i];
            index++;
        }
    }
    return resArr;
}

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

Console.WriteLine();
string[] arrElements = FillArray(count);
int sizeResArr = GetCountElementsThreeSymbols(arrElements);
string[] resArr = CreateArrFromeElementsTillThreeSimbols(arrElements, sizeResArr);
PrintArray(arrElements);
Console.WriteLine();
PrintArray(resArr);

