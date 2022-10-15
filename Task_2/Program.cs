
Console.WriteLine("Введите часло А");
int namber_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите часло B");
int namber_2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите часло C");
int namber_3 = Convert.ToInt32(Console.ReadLine());
int max = namber_1;

if(max < namber_2)
{
    max = namber_2;
}
if(max < namber_3)
{
   max = namber_3;
}
Console.WriteLine(max);
