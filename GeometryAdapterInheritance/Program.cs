// See https://aka.ms/new-console-template for more information
using Geometry.Computing;
using Geometry.Model;
using OldGeometry.Model;

Point p = new Point()
{
    X = 12.5,
    Y = 13.25
};


IEnumerable<IMesurable2D> circles = Enumerable.Range(1, 10)
    .Select(r => new CircleAdapter(p, r))
    .ToList();

double area = Compute.TotalArea(circles);
Console.WriteLine(area);
