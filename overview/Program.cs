int a = 1;
char c = 'A';
float f = 123.45f;
decimal d = 400.85m;
int b = default;
bool tf = default;

Console.WriteLine($"{a}, {b}, {tf}, {c}, {f}, {d}");
//implicit type convesion and type casting
Console.WriteLine($"{c+a}");
Console.WriteLine($"{(char)(c+a)}");
