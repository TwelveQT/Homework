Console.Clear();

Console.WriteLine("Задача 19");
Console.Write("Введите число ");

string? number = Console.ReadLine();

void Checkingnumber(string number){
    if (number[0] == number [4] || number[1] == number[3]){
        Console.WriteLine("Это число палиндром.");
    }
    else Console.WriteLine("Это число не палидром.");
}

if (number!.Length == 5){
    Checkingnumber(number);
}
else Console.WriteLine("Введите правильное число");
