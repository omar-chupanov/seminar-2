// See https://aka.ms/new-console-template for more information
System.Console.Write("Укажите трехзначное число >");
string value;
value = Console.ReadLine(); 
int number = Convert.ToInt32(value); 
if(number<1000)
{
    if(number>99)
    {   
        int penultimate = number / 10 %10;
        System.Console.Write($"Вторая цифра числа {number} является {penultimate}" );
    }  
    else
    {
        System.Console.Write(" НЕ является трехзначным числом!");
    }  
    
}
else
{
    System.Console.Write("НЕ является трехзначным числом!");
}



