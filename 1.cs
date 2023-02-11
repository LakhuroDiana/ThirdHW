System.Console.WriteLine("Введите пятизначное число");
string number = Console.ReadLine();
int N = Convert.ToInt32(number);
if (N % 10 == N / 10000 || N / 1000 % 10 == N % 100 / 10)
{
    System.Console.WriteLine("-> Да");
}
else
{
    System.Console.WriteLine("-> Нет");
}