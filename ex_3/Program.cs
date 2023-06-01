Console.Clear();

void kub(int num)
{
    int count = 0;
    for (int i = 1; i <= num; i++)
    {
        for (int j = 0; j <= 3; j++)
        {
            count = i*i*i;
        }
        System.Console.Write($"{count} ");
    }
}

System.Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
kub(num);