using System;

class Rectangle
{
    public delegate void rectDelegate(double height, double width);
    public void area(double height,double width)
    {
        Console.WriteLine("area is {0}",(width*height));
    }
    public void perimeter(double height, double width)
    {
        Console.WriteLine("perimeter is {0}", 2*(width + height));
    }


    static void Main(String[] args)
    {
        Rectangle rect = new Rectangle();
        rectDelegate delerec = new rectDelegate(rect.area);
        delerec += rect.perimeter;
        delerec.Invoke(2,3);


    }

}
