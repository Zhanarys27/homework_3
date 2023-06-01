Console.Clear();

System.Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

if((num == 0) || (reverse(num, 0) == num) == true)
{
    System.Console.WriteLine("Yes");
}
else
{
    System.Console.WriteLine("No");
}


int reverse(int num, int reverse)
{
    while (num > 0)
    { 
        reverse = reverse * 10 + num % 10; 
        num /= 10; 
    }
    return reverse;
}