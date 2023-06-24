int Prompt(string message)
{
    System.Console.Write($"{message} >");
    string inputeStr = Console.ReadLine();
    int value;
    if ( int.TryParse(inputeStr, out value))
    {
        return value;
    }
    System.Console.WriteLine("Извините, но вы ввели не число");
    Environment.Exit(0);
    return 0;
}
int r=0;
int c=0;
int sum = 0;
int number = Prompt("Введите число");

while (number>9)
{
     c = c+(number%10);
    number=number/10;
     sum = sum +1;
     if (number<=9)
     {
        r=c+number;
     } 
     

}

Console.WriteLine (r);