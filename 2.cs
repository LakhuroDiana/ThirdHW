void Input(double[] array)
{
    int i=0;
    string number;
while(i<3)
{
    number = Console.ReadLine();
    array[i] = Convert.ToInt32(number);
    i++;
}
}

double[] first=new double[3];
double[] second=new double[3];
System.Console.WriteLine("Введите координаты первой точки");
Input(first);
System.Console.WriteLine("Введите координаты второй точки");
Input(second);

System.Console.WriteLine("Расстояние между точками = " +
Math.Sqrt(
(first[0]-second[0])*(first[0]-second[0])+
(first[1]-second[1])*(first[1]-second[1])+
(first[2]-second[2])*(first[2]-second[2]))
);

