// Рекурсия: числа фибаначи
// 1 1 2 3 5 8 13 21 ...
// fn = fn-1 + fn-2

 // f(1) = 1
 // f(2) = 1
 // f(n) = f(n-1) + f(n-2)

double Fibanacci(int n)
{
    if(n == 1 || n == 2) return 1;
    else  return Fibanacci(n-1) + Fibanacci(n-2);
}
for (int i =1; i < 50; i++)
{
    Console.WriteLine($"f({i}) = {Fibanacci(i)}");
}
