
for (int h = 1; h <= 255; h++)
{
    Console.WriteLine(h);
}

for (int h = 1; h <= 100; h++)
{
    if (h % 3 == 0 || h % 5 == 0)
    {
        Console.WriteLine(h);
    }
}

for (int h = 1; h <= 100; h++)
{
    if (h % 3 == 0 && h % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (h % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (h % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
}

int i = 0;
while (i <= 255)
{
    Console.WriteLine(i);
    i++;
}

int j = 0;
while (j <= 100)
{
    if (j % 3 == 0 || j % 5 == 0)
    {
        Console.WriteLine(j);
    }

    j++;
}

int k = 0;
while (k <= 100)
{
    if (k % 3 == 0 && k % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (k % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (k % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }

    k++;
}