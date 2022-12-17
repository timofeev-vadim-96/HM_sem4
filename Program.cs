// Цикл, который принимает на вход два числ (А и В) и возводит число А в натуральную степень В.
System.Console.WriteLine("Введите первое число");
int A = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int B = Convert.ToInt32(Console.ReadLine());
int Exponentiation (int FirstNumb, int SecondNumb)
{
    int product = 1;
    for (int i = 0; i < SecondNumb; i++)
    {
        product = product*FirstNumb;
    }
    System.Console.WriteLine($"Число {A} в степени {B} = {product}");
    return product; 
}
Exponentiation(A, B);
// double sum = Math.Pow(A,B);
// System.Console.WriteLine(sum);