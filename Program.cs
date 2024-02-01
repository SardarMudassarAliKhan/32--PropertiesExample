using System;

class Rectangle
{
    private double length;
    private double width;

    // Property to get or set the length
    public double Length
    {
        get { return length; }
        set
        {
            if(value > 0)
                length = value;
            else
                throw new ArgumentException("Length must be greater than zero");
        }
    }

    // Property to get or set the width
    public double Width
    {
        get { return width; }
        set
        {
            if(value > 0)
                width = value;
            else
                throw new ArgumentException("Width must be greater than zero");
        }
    }

    // Property to calculate and get the area of the rectangle
    public double Area
    {
        get { return length * width; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Rectangle rectangle = new Rectangle();
        rectangle.Length = 5;
        rectangle.Width = 3;

        Console.WriteLine("Length: " + rectangle.Length);
        Console.WriteLine("Width: " + rectangle.Width);
        Console.WriteLine("Area: " + rectangle.Area);
    }
}
