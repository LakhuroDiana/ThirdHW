System.Console.WriteLine("Введите число");
string number = Console.ReadLine();
int N = Convert.ToInt32(number);
int i=0;
int k=1;
int result=1;
while (i<N)
{
    result=k;
    System.Console.WriteLine(result*result*result);
    i++;
    k++;
}
