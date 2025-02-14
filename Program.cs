double? a = null;
double? b = null;

String[] Menu = ["1) ввести A",
                 "2) ввести B",
                 "3) выполнить операцию '+'",
                 "4) выполнить операцию '-'",
                 "5) выполнить операцию '*'",
                 "6) выполнить операцию '/'"];


void ShowMenu() {
    foreach (string option in Menu) {
        Console.WriteLine(option);
    }
}

int ReadOperation() {
    String line = Console.ReadLine();
    int choice;
    try {
        choice = Convert.ToInt32(line);
        if (choice < 1 || choice > 6) throw new Exception("");
        return choice;
    } catch {
        Console.WriteLine("Некорректный выбор опции\n");
        ShowMenu();
        return ReadOperation();
    }
}

void Divide(double? a, double? b) {
    if (a == null) Console.WriteLine("Число A не указано");
    else if (b == null) Console.WriteLine("Число B не указано");
    else Console.WriteLine($"A / B = {a / b}");
}

void Times(double? a, double? b) {
    if (a == null) Console.WriteLine("Число A не указано");
    else if (b == null) Console.WriteLine("Число B не указано");
    else Console.WriteLine($"A * B = {a * b}");
}

void InputA() {
    Console.Write("Введите число A: ");
    String line = Console.ReadLine();
    double numberA;
    try {
        numberA = Convert.ToDouble(line);
        a = numberA;
        Console.WriteLine($"A = {a}\n");
    } catch {
        Console.WriteLine("Некорректный ввод числа\n");
    }
}

void InputB() {
    Console.Write("Введите число B: ");
    String line = Console.ReadLine();
    double numberB;
    try {
        numberB = Convert.ToDouble(line);
        b = numberB;
        Console.WriteLine($"B = {b}\n");
    } catch {
        Console.WriteLine("Некорректный ввод числа\n");
    }
}

void Plus(double? a, double? b) {
    if (a == null) Console.WriteLine("Число A не указано");
    else if (b == null) Console.WriteLine("Число B не указано");
    else Console.WriteLine($"A + B = {a + b}");
}

void Minus(double? a, double? b) {
    if (a == null) Console.WriteLine("Число A не указано");
    else if (b == null) Console.WriteLine("Число B не указано");
    else Console.WriteLine($"A - B = {a - b}");
}

while (true) {
    ShowMenu();
    int op = ReadOperation();
    switch (op) {
        case 1:
            InputA();
            break;
        case 2:
            InputB();
            break;
        case 3:
            Plus(a, b);
            break;
        case 4:
            Minus(a, b);
            break;
        case 5:
            Times(a, b);
            break;
        case 6:
            Divide(a, b);
            break;
        default:
            break;
    }
}

