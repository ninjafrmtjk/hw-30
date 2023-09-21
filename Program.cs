using System.Collections.Generic;
using System.Threading;

// Task 1.
Thread t1 = new Thread(PrintNumbers1);
Thread t2 = new Thread(PrintNumbers2);

t1.Start();
t2.Start();

t1.Join();
t2.Join();

Console.WriteLine("Press any key to exit.");
Console.ReadKey();

void PrintNumbers1()
{
    for (int i = 1; i <= 100; i++)
        Console.Write(i + " ");
}

void PrintNumbers2()
{
    for (int i = 101; i <= 200; i++)
        Console.Write(i + " ");
}

// Task 2.
Thread thread1 = new(Print1);
Thread thread2 = new(Print2);

thread1.Start();
thread2.Start();

thread1.Join();
thread2.Join();

Console.WriteLine("Press any key to exit.");
Console.ReadKey();

void Print1()
{
    for (int i = 0; i <= 100; i += 2)
        Console.WriteLine("Thread 1: " + i);
}

void Print2()
{
    for (int i = 1; i <= 99; i += 2)
        Console.WriteLine("Thread 2: " + i);
}

// Task 3.
Thread thr1 = new(Num1);
Thread thr2 = new(Num2);
Thread thr3 = new(Num3);

thr1.Start();
thr2.Start();
thr3.Start();

thr1.Join();
thr2.Join();
thr3.Join();

Console.WriteLine("Press any key to exit.");
Console.ReadKey();

void Num1()
{
    for (int i = 1; i <= 33; i++)
        Console.WriteLine("Thread 1: " + i);
}

void Num2()
{
    for (int i = 34; i <= 66; i++)
        Console.WriteLine("Thread 2: " + i);
}

void Num3()
{
    for (int i = 64; i <= 100; i++)
        Console.WriteLine("Thread 3: " + i);
}

// Task 4.
Thread th1 = new Thread(PrintLetters1);
Thread th2 = new Thread(PrintLetters2);

th1.Start();
th2.Start();


void PrintLetters1()
{
    for (char c = 'A'; c <= 'M'; c++)
    {
        Console.Write(c);
    }
}

void PrintLetters2()
{
    for (char c = 'N'; c <= 'Z'; c++)
    {
        Console.Write(c);
    }
}

// Task 5.
Thread thrr1 = new Thread(PrintMultiplesOfThree);
Thread thrr2 = new Thread(PrintMultiplesOfFive);

thrr1.Start();
thrr2.Start();

void PrintMultiplesOfThree()
{
    for (int i = 1; i <= 100; i++)
    {
        if (i % 3 == 0)
        {
            Console.Write(i + " ");
        }
    }
}

void PrintMultiplesOfFive()
{
    for (int i = 1; i <= 100; i++)
    {
        if (i % 5 == 0)
        {
            Console.Write(i + " ");
        }
    }
}

// Task 6.

Thread p1 = new Thread(PrintPrimes);
Thread p2 = new Thread(PrintComposites);

p1.Start();
p2.Start();


void PrintPrimes()
{
    Console.Write("Primes: ");
    for (int i = 2; i <= 100; i++)
    {
        bool isPrime = true;
        for (int j = 2; j < i; j++)
        {
            if (i % j == 0)
            {
                isPrime = false;
                break;
            }
        }
        if (isPrime)
        {
            Console.Write(i + " ");
        }
    }
    Console.WriteLine();
}

void PrintComposites()
{
    Console.Write("Composites: ");
    for (int i = 2; i <= 100; i++)
    {
        bool isPrime = true;
        for (int j = 2; j < i; j++)
        {
            if (i % j == 0)
            {
                isPrime = false;
                break;
            }
        }
        if (!isPrime)
        {
            Console.Write(i + " ");
        }
    }
    Console.WriteLine();
}

// Task 7.
int sum = 0;
int product = 1;

Thread x1 = new Thread(Sum);
Thread x2 = new Thread(Product);

x1.Start();
x2.Start();

x1.Join();
x2.Join();

Console.WriteLine("The sum of numbers from 1 to 100 is: " + sum);
Console.WriteLine("The product of numbers from 1 to 100 is: " + product);


void Sum()
{
    for (int i = 1; i <= 100; i++)
    {
        sum += i;
    }
}

void Product()
{
    for (int i = 1; i <= 100; i++)
    {
        product *= i;
    }
}

// Task 8.
Thread potok1 = new Thread(ThreeAndFive);
Thread potok2 = new Thread(NotThreeAndFive);

potok1.Start();
potok2.Start();

potok1.Join();
potok2.Join();

void ThreeAndFive()
{
    for (int i = 1; i <= 100; i++)
    {
        if (i % 3 == 0 || i % 5 == 0)
        {
            Console.WriteLine("Thread 1: " + i);
        }
    }
}

void NotThreeAndFive()
{
    for (int i = 1; i <= 100; i++)
    {
        if (!(i % 3 == 0 || i % 5 == 0))
        {
            Console.WriteLine("Thread 2: " + i);
        }
    }
}

// Task 9.
Thread u1 = new Thread(Forward);
Thread u2 = new Thread(Reverse);

u1.Start();
u2.Start();

u1.Join();
u2.Join();

void Forward()
{
    for (int i = 1; i <= 50; i++)
    {
        Console.WriteLine("Thread 1: " + i);
    }
}

void Reverse()
{
    for (int i = 100; i >= 51; i--)
    {
        Console.WriteLine("Thread 2: " + i);
    }
}

// Task 10.
Thread c1 = new(Printing);
Thread c2 = new(Squared);

c1.Start();
c2.Start();

c1.Join();
c2.Join();

void Printing()
{
    for (int o = 1; o <= 100; o++)
        Console.WriteLine(o);
}

void Squared()
{
    for (int o = 1; o <= 100; o++)
        Console.WriteLine(o * o);
}