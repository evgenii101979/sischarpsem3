// прога ввод x и y x!=0 y!=0 вывод четверти где точка
Console.WriteLine("Введите x ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите y ");
int y = int.Parse(Console.ReadLine());
if(x > 0 && y > 0)
{
    Console.WriteLine("1");
    }
    else if(x < 0 && y < 0)
    {
        Console.WriteLine("3");
    }
    else if(x < 0 && y > 0)
    {
        Console.WriteLine("2");
    }
    else if(x > 0 && y < 0);
    {
        Console.WriteLine("4");
}