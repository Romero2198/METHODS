//Ввод данных
int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
//Заполнение массива
void FillArray(int[] array)
{
    for(int i = 0; i< array.Length; i++)
        {
            array[i] = new Random().Next(0, 124);
        }
}
//Вывод массива
void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
//Рекурсия
void ToBin(int number)
{
    if(number == 0)
    {
        return;
    }
    ToBin(number / 2);
    Console.Write(number % 2);
}