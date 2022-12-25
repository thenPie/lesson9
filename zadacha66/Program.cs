Console.Write("Введите два числа через пробел: ");
var input = Console.ReadLine();
var space = input.Split(" ");
int m = int.Parse(space[0]);
int n = int.Parse(space[1]);

int sum = 0;

if(m <= n) {
    while(m <= n) {
        sum = sum + m;
        m++;
    }
} else if(n <= m) {
    while(n <= m) {
        sum = sum + n;
        n++;
    }
}

Console.Write(sum);