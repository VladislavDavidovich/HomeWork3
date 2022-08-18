// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//int lengthX = x2 - x1;
//int lengthY = y2 - y1;
//double distance = Math.Sqrt(lengthX * lengthX + lengthY * lengthY);
//Console.WriteLine($"A({x1}, {y1}); B({x2}, {y2}) -> {distance}");

//int ReadInt(string message)
//{
//Console.Write(message);
//return Convert.ToInt32(Console.ReadLine());
//}

//int x1 = ReadInt("Введите координату X1 точки А: ");
//int y1 = ReadInt("Введите координату Y1 точки А: ");
//int z1 = ReadInt("Введите координату Z1 точки А: ");
//int x2 = ReadInt("Введите координату X2 точки В: ");
//int y2 = ReadInt("Введите координату Y2 точки В: ");
//int z2 = ReadInt("Введите координату Z3 точки В: ");

int x1 = ReadInt("X1", "А");
int y1 = ReadInt("Y1", "A");
int z1 = ReadInt("Z1", "A");
int x2 = ReadInt("X2", "B");
int y2 = ReadInt("Y2", "B");
int z2 = ReadInt("Z3", "B");

int ReadInt(string message1, string message2)
{
    Console.Write($"Введите координату {message1} точки {message2}: ");
    return Convert.ToInt32(Console.ReadLine());
}

double Decision(double x1, double x2, double y1, double y2, double z1, double z2)
{
  return Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2));
}

double distance =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );

Console.WriteLine($"Расстояние равно {distance}");