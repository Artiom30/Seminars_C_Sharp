// Межейников Артём
// Задача 1 : Напишите программу, которая на вход принимает два 
//            числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("Imput first number :");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput second number :");
int n2 = Convert.ToInt32(Console.ReadLine());

if (n1 == n2)
{
    Console.WriteLine("Your numbers are equal.");
}
else
    if ( n1 > n2 )
{
        Console.WriteLine($"The number: {n1} - is the maximum. The number: {n2} - is the minimum.");
}
    else
{
        Console.WriteLine($"The number: {n2} - is the maximum. The number: {n1} - is the minimum.");    
}
*/

// Задача 2:Напишите программу, которая принимает на вход три числа
//          и выдаёт максимальное из этих чисел.
/*
Console.Write("Imput first number :");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput second number :");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput third number :");
int n3 = Convert.ToInt32(Console.ReadLine());
int[] numbers = { n1,n2,n3 };
int i = 1;
int nMax = numbers[0];

while ( i < 3 )
{
    if( numbers[i] > nMax )
        nMax = numbers[i];
        i++;
}

Console.WriteLine($"Number: {nMax} - the maximum of all numbers." );

// Пользовался информацией с :https://metanit.com/sharp/tutorial/2.4.php.
*/

// Задача 3. Напишите программу, которая на вход принимает число и 
//           выдаёт, является ли число чётным 
//           (делится ли оно на два без остатка).
/*
Console.WriteLine("Imput a number :");
int n = Convert.ToInt32(Console.ReadLine());

if ( n > 0 )
    if ( n % 2 == 1)
{
        Console.WriteLine("Your number is odd.");
}
    else
{
        Console.WriteLine("Your number is even.");
}
else
{
    Console.WriteLine("Your number is less than one.");
}    
*/

// Задача 4: Напишите программу, которая на вход принимает число (N), 
//           а на выходе показывает все чётные числа от 1 до N.
/*
Console.WriteLine("Imput your namber :");
int n = Convert.ToInt32(Console.ReadLine());
int current = 2;

if (n <= 1)
{
    Console.WriteLine("Your number is 0 or 1.");
}
while (current < n)
{
    Console.Write(current + " ,");
    current = current + 2;
}
*/
// Павел , скажите, нормально ли написана задача 2? просто её можно
// было подругому написать но мне показалось так легче.