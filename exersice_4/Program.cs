// Напишите программу, которая принимает на вход 
//три числа и выдает максимальное из этих чисел.
Console.Clear();
Console.Write(" Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());

Console.Write(" Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());

Console.Write(" Введите третье число: ");
int number3 = int.Parse(Console.ReadLine());

if(number1 > number2 && number1 > number3) {
    Console.WriteLine($" {number1} максимальное из трёх чисел");
}

if(number2 > number3 && number2 > number1) {
    Console.WriteLine($" {number2} максимальное из трёх чисел");
}

if(number3 > number1 && number3 > number2) {
    Console.WriteLine($" {number3} максимальное из трёх чисел");
}

if (number1 == number2 && number1 == number3 && number3 == number2) {                     //в условии задачи этого нет, 
    Console.WriteLine(" Все числа равны");                                                //но я добавил данную проверку.
}