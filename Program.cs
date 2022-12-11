// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

Console.Write($"Введите пятизначное число: ");
            string number = Console.ReadLine();
            char[] N5 = number.ToCharArray();
            Array.Reverse(N5);
            string number_rev = new String(N5);
 
            if (number == number_rev) Console.WriteLine("Это палиндром");
            else Console.WriteLine("Это не палиндром");
// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
int Ax, Ay, Az, Bx, By, Bz;
Console.Write($"Введите координату x точки А: ");
int.TryParse(Console.ReadLine(), out Ax);
Console.Write($"Введите координату y точки А: ");
int.TryParse(Console.ReadLine(), out Ay);
Console.Write($"Введите координату z точки А: ");
int.TryParse(Console.ReadLine(), out Az);
Console.Write($"Введите координату x точки B: ");
int.TryParse(Console.ReadLine(), out Bx);
Console.Write($"Введите координату y точки B: ");
int.TryParse(Console.ReadLine(), out By);
Console.Write($"Введите координату z точки B: ");
int.TryParse(Console.ReadLine(), out Bz);

double answer = Math.Round(Math.Sqrt(PointSqr(Bx, Ax) + PointSqr(By, Ay) + PointSqr(Bz, Az)), 2);
Console.Write($"Расстояние между точками А и В = {answer}");

//Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int number, i = 1, cube, a;
Console.Write($"Введите натуральное число: ");
int.TryParse(Console.ReadLine(), out number);
while (i <= number)
{
    cube = Math.Sqrt(a,i);
    Console.Write($"{cube}, ");
    i += 1;
}
