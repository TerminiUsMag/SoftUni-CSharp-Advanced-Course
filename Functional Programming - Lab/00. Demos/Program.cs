
Func<int, int> twice = x => x * x;

var func =
    () => 
    { 
        Console.WriteLine("Hello !");
        Console.WriteLine("I am an annonymous function !!");
    };

func();

Console.WriteLine();

func = Print;

func();

void Print()
{
    Console.WriteLine("Hello, I am Print() !");
    Console.WriteLine("And I am named function !!");
}
