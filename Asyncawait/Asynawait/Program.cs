// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
method1();
Console.WriteLine("Hello, World! 2");
Console.WriteLine("Hello, World! 3");
Console.WriteLine("Hello, World! 4");
Console.WriteLine("Hello, World! 5");


Console.Read();
static async Task method1()
{
        Console.WriteLine("Before Method 1");
    await method2();
    Console.WriteLine("After Method 1");
}

static async Task method2()
{
    Console.WriteLine("Before Method 2");
    await method3();
    Console.WriteLine("After Method 2");
}

static async Task method3()
{
    Console.WriteLine("Before Method 3");
    await Task.Delay(1);
    Console.WriteLine("After Method 3");
}

