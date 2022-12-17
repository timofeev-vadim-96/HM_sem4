// Метод, который принимает на вход число и выдает сумму цифр в числе.
System.Console.WriteLine("Введите число");
int numb = Convert.ToInt32(Console.ReadLine());

int NumbersSum (int tithing)
{
    int sum = 0;
    if (tithing < 0) tithing = tithing * -1;
    while (tithing >= 10)
    {
        sum = sum + tithing % 10;
        tithing = tithing / 10;
    }
    sum = sum + tithing; 
    return sum; 
}
NumbersSum(numb);
System.Console.WriteLine($"Сумма цифр в числе {numb} = {NumbersSum(numb)}");