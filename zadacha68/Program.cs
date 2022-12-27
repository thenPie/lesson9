Console.Write("Введите два числа через пробел: ");
var input = Console.ReadLine();
var space = input.Split(" ");
int m = int.Parse(space[0]);
int n = int.Parse(space[1]);

int ack(int m, int n) {
    if (m == 0) {
        return n + 1;
    }
    else if ((m > 0) && (n == 0)) {
        return ack(m - 1, 1);
    }
    else if ((m > 0) && (n > 0)) {
        return ack(m - 1, ack(m, n - 1));
    } else
        return n + 1;
}

if(0 < m && 0 < n) {
    Console.Write(ack(m, n));
} else {
    Console.Write("No");
}