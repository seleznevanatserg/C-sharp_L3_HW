//Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53




Console.WriteLine ("Enter 3D-coordinates fo point A (XYZ)");
double ax = InPutDoubleNumberTryParse ();
double ay = InPutDoubleNumberTryParse ();
double az = InPutDoubleNumberTryParse ();
Console.WriteLine ("Enter 3D-coordinates fo point B (XYZ)");
double bx = InPutDoubleNumberTryParse ();
double by = InPutDoubleNumberTryParse ();
double bz = InPutDoubleNumberTryParse ();



double distance = DistanceBetweenTwoPointIn3DSpace(ax,ay,az,bx,by,bz);

Console.WriteLine ($"Distance between points A and B = {distance}");

double InPutDoubleNumberTryParse ()
{
    Console.WriteLine("Enter number, please.");
    bool isParsed = double.TryParse(Console.ReadLine(), out double Num);

    if (!isParsed)
    {
        Console.WriteLine("Sorry, but You entered bullshit. Please, number enter.");
        return -1;
    }
    else
    {
        return Num;
    }
}
double DistanceBetweenTwoPointIn3DSpace (double ax, double ay, double az, double bx, double by, double bz)
{
    double result = Math.Sqrt(Math.Pow((ax-bx),2) + Math.Pow((ay-by),2) + Math.Pow((az-bz),2));

    return result;
}