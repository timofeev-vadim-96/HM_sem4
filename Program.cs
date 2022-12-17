// Программа, которая задает массив из 8 элементов и выводит их на экран.
int [] array = new int[8];
void CreateArray (int [] array)
{
for (int i = 0; i < array.Length; i++)
{
    array [i] = new Random().Next(1,10);
}
}   
void PrintArray (int [] array)
{
    System.Console.Write($"[{array[0]},");
    for (int i = 1; i < array.Length; i++)
    {
        if (i == array.Length-1)
        {
            System.Console.Write($"{array[i]}]");
        }
        else System.Console.Write($"{array[i]},");
        
    }
    System.Console.WriteLine();
}
CreateArray(array);
PrintArray(array);