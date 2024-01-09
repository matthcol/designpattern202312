using Geometry.Model;
using GeometryObservable.GeneralObserver;
using GeometryObservable.Obervers;


void ShortTermObservation(Circle c)
{
    // paint counter observer
    CirclePaintCounter circlePaintCounter = new CirclePaintCounter(c);
    c.AddObserver(circlePaintCounter);

    // modify circle locally
    c.Radius *= 10;
    c.Name = "C2";

    //
    Console.WriteLine($"Paint total surface: {circlePaintCounter.TotalArea}");

    // unregister local observer
    c.RemoveObserver(circlePaintCounter);
}

void DemoObservables()
{
    // subjects
    Point p1 = new Point("A", 0, 0);
    Point p2 = new Point("B", 1.5, 3.5);
    Circle c = new Circle("C1", p1, 10);
    // console observer
    IObserver consoleObserver1 = new ConsoleLogger(c);
    c.AddObserver(consoleObserver1);
    IObserver consoleObserver2 = new ConsoleLogger(p1);
    p1.AddObserver(consoleObserver2);
    IObserver consoleObserver3 = new ConsoleLogger(p2);
    p2.AddObserver(consoleObserver3);
    
    // modify subjet(s)
    c.Name = "C0";
    c.Radius = 9.5;
    c.Center = p2;
    p1.X = 2;
    p2.X = 3.5;

    ShortTermObservation(c);

    c.Radius = 1;
}

DemoObservables();