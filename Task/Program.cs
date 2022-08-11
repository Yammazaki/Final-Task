// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше или равна 3 символам

Console.Write("Введите размер массива: ");
int size = 0;

if (int.TryParse(Console.ReadLine(), out size))
{
    Console.Write($"Ваше размер массива = {size}\n"); 
}
else Console.Write($"Вы неправильно ввели данные!");

string [] array = new string[size];

for ( int i = 0; i < size; i++)
{
    Console.Write($"Введите [{i}] элемент: ");
    string temp = Console.ReadLine();
    array[i] = temp;
}

for (int j = 0; j < size; j++)
Console.Write($"{array[j]} ");

string [] newArray = new string [size];
Console.WriteLine();
void WeWillFindIt (string [] array)
{
    for ( int k = 0; k < array.Length; k++)
        if (array[k].Length <= 3)
        {
            newArray [k] = array[k];
            Console.Write($"{newArray[k]} ");
        }
        else Console.Write("Строки с такой длиной нет ");
}

WeWillFindIt(array);
Console.WriteLine();
for (int l = 0; l < size; l++)
Console.Write($"{newArray[l]} ");