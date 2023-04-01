// See https://aka.ms/new-console-template for more information
int ReadInt ( string message)
{
System.Console.Write($"{message}");
int value = Convert.ToInt32(Console.ReadLine());
return value;
}
int num = ReadInt("Укажите число");
while(num > 1000)
{
num = num /10;
}
if(num >100)
{
num = num % 10;
System.Console.WriteLine($"Третья цифра является {num}");
}
else
{
System.Console.WriteLine("нет цифры!");
}




