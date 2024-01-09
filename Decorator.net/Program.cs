// See https://aka.ms/new-console-template for more information
using Decorator.net.Model;

// TODO: decarotae with a Frame, Glass, Alarm
IPaint CreateAndDecorePaint() {
    return new AlarmDecorator()
    {
        DecoratedPaint = new ArmoredGlassDecorator()
        {
            DecoratedPaint = new AlarmDecorator()
            {
                DecoratedPaint = new FrameDecorator()
                {
                    DecoratedPaint = new Paint()
                    {
                        Content = "Jolie montagne enneigée"
                    },
                    Color = "red"
                }
            }
        }
    };
}

void ViewPaint(IPaint paint)
{
    Console.WriteLine(paint.Visual());
}


// main code
IPaint paint = CreateAndDecorePaint();
ViewPaint(paint);
    




