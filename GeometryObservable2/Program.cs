using Geometry.Model;
using GeometryObservable.GeneralObserver;
using GeometryObservable.Model;
using GeometryObservable.Obervers;


void ShortTermObservation(Circle c)
{
    // paint counter observer
    AreaPaintCounter circlePaintCounter = new AreaPaintCounter();
    c.Subscribe(circlePaintCounter);
    {


        // modify circle locally
        c.Radius *= 10;
        c.Name = "C2";
        c.Radius *= 2;

        //
        Console.WriteLine($"Paint total surface: {circlePaintCounter.TotalArea}");

    }
    c.Unsubscribe();
} // GC after this point: delete CirclePAintCouner

void DemoObservables()
{
    // subjects
    Point p1 = new Point("A", 0, 0);
    Point p2 = new Point("B", 1.5, 3.5);
    Circle c = new Circle("C1", p1, 10);
    // console observer
    IObserver<AbstractForm> consoleObserver = new ConsoleLogger();
    using (FileLogger fileLogger = new FileLogger("log_forms.txt"))
    {
        using (c.Subscribe(fileLogger))
        using (c.Subscribe(consoleObserver))
        {
            using (p1.Subscribe(fileLogger))
            using (p2.Subscribe(fileLogger))
            using (p1.Subscribe(consoleObserver))
            using (p2.Subscribe(consoleObserver))
            {
                // modify subjet(s)
                c.Name = "C0";
                c.Radius = 9.5;
                c.Center = p2;
                p1.X = 2;
                p2.X = 3.5;
            }

            ShortTermObservation(c);

            c.Radius = 1;
        }
        // no more observers
        c.Radius = 10;
        p1.Y = 3;
    } // close file logger
}

DemoObservables();