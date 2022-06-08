
Func<int, int> twice = x => x * x;
Console.WriteLine(twice(2));
Console.WriteLine();

var func =
    () => 
    { 
        Console.WriteLine("Hello !");
        Console.WriteLine("I am an annonymous function !!");
    };

var func2 =
    (int x, int y) => x + y;

func();

Console.WriteLine();
Console.WriteLine(func2(2, 8));
Console.WriteLine();

func = Print;
func();
void Print()
{
    Console.WriteLine("Hello, I am Print() !");
    Console.WriteLine("And I am named function !!");
}
