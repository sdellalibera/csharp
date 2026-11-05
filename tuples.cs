var pt = (X: 1, Y: 2);
var slope = (double)pt.Y / (double)pt.X;
Console.WriteLine($"A line from the origin to the point {pt} has a slope of {slope}.");
var subscript = (A: 0, B: 0);
subscript = pt;
Console.WriteLine(subscript);
pt.X = pt.X + 5;
Console.WriteLine($"The point is now at {pt}.");
var pt2 = pt with { Y = 10 };
Console.WriteLine($"The point 'pt2' is at {pt2}.");

var pt3 = pt with {Y = 10};

Point pt4 = new Point(2,2);

double slopeResult = pt4.Slope();

public record Point(int X, int Y)
{
    public double Slope() => (double)Y / (double)X;
}
