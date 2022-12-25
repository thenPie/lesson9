void AskToDescend() {
    Console.Write("Введите число: ");
    string input = Console.ReadLine();
    if(int.TryParse(input, out int value)) {
        DescendShow(value);
    }
}

void DescendShow(int num) {
    if(0 < num) {
        Console.Write($"{num} ");
        num--;
        DescendShow(num);
    }
}

AskToDescend();