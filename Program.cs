﻿double a;
double b;

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

while (true) {
    ShowMenu();
    int op = ReadOperation();
    switch (op) {
        case 1:
            InputA();
            break;
        case 2:
            break;
        case 3:
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

