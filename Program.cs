// Цикл, который принимает на вход два числ (А и В) и возводит число А в натуральную степень В.
// Учитаны случаи ввода 0 и отрицательного значения числ В
System.Console.WriteLine("Введите первое число");
double A = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число");
double B = Convert.ToInt32(Console.ReadLine());
double Exponentiation (double FirstNumb, double SecondNumb)
{
    double product = 1;
    if (SecondNumb == 0) product = 1;
    else
    {
        if (SecondNumb > 0)
        {
            for (int i = 0; i < SecondNumb; i++)
            {
                product = product * FirstNumb;
            }
        }
        else
        {
            for (int i = 0; i > SecondNumb; i--)
            {
                product = product * (1/FirstNumb);
            }
        }
    }
System.Console.WriteLine($"Число {A} в степени {B} = {product}");
return product; 
}
Exponentiation(A, B);
