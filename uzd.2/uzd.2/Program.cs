
using System;
public class Point
    //Definē x,y kas būs figūras punktu koordinātas
{
    public int x, y;
    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}

class uzd2
{
    public static int orientation(Point p1, Point p2, Point p3)
    {
      // Formula, kas aprēķina vai figūras punkti veido pozitīvu vai negatīvu iznākumu
        int val = (p2.y - p1.y) * (p3.x - p2.x) - (p2.x - p1.x) * (p3.y - p2.y);

        // Ja pozitīvs tad piesķir vertibu 1, ja negatvīvs tad 2
        return (val > 0) ? 1 : 2;
    } 
	
	// Programma, kas pārbauda augšējo funkciju
    // definē figūras punktus
	public static void Main(String[] args)
    {
        Point p1 = new Point(5, 10);
        Point p2 = new Point(20, 7);
        Point p3 = new Point(15, 20);

        int o = orientation(p1, p2, p3);

        // Ja 1 tad "Clockwise", ja 2 tad "CounterClockwise"
        if (o == 1)
            Console.WriteLine("Clockwise");
        else
            Console.WriteLine("CounterClockwise");

    }
}
// Ar Visual Studio kompilatoru palaist programmu