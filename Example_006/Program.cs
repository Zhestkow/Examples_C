int numberA = new Random().Next(1,100);
Console.WriteLine (numberA);
int numberB = new Random().Next(1,100);
Console.WriteLine (numberB);
int numberC = new Random().Next(1,100);
Console.WriteLine (numberC);
int numberD = new Random().Next(1,100);
Console.WriteLine (numberD);
int numberE = new Random().Next(1,100);
Console.WriteLine (numberE);
int max = numberA;

if(numberA>max) max = numberA;
if(numberB>max) max = numberB;
if(numberC>max) max = numberC;
if(numberD>max) max = numberD;
if(numberE>max) max = numberE;

Console.Write("Максимальное число -  ");
Console.WriteLine(max);