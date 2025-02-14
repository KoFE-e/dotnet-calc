int a;
int b;

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

while (true) {
    ShowMenu();
    ReadOperation();
}

