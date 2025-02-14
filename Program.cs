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

void Plus(double? a, double? b) {
    if (a == null) Console.WriteLine("Число A не указано");
    else if (b == null) Console.WriteLine("Число B не указано");
    else Console.WriteLine($"A + B = {a + b}");
}

while (true) {
    ShowMenu();
    int op = ReadOperation();
    switch (op) {
        case 1:
            break;
        case 2:
            break;
        case 3:
            Plus(a, b);
            break;
        case 4:
            break;
        case 5:
            break;
        case 6:
            break;
        default:
            break;
    }
}

