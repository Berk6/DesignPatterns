using DesignPatterns.Structural.Composite.Graphic;
using DesignPatterns.Structural.Composite.Graphic.Interface;

namespace DesignPatterns.Structural.Composite
{
    internal class Process
    {
        void Graphic()
        {
            ICompositeGraphic display = new Canvas("Display", "Light Green");

            Circle redCircle = new ("Red Circle", "Red");
            display.AddGraphic(redCircle);

            Circle blueCircle = new ("Blue Circle", "Blue");
            display.AddGraphic(blueCircle);

            Ellipse ellipse = new ("Black Ellipse", "Black");
            display.AddGraphic(ellipse);

            Triangle triangle = new ("Triangle", "Yellow");
            display.AddGraphic(triangle);

            Rectangle yellowRectangle = new ("Rectangle", "Yellow");
            display.AddGraphic(yellowRectangle);

            Rectangle greenRectangle = new ("Rectangle", "Green");
            display.AddGraphic(greenRectangle);

            display.ListGraphic();

            IGraphic graphic = (IGraphic)display;
            graphic.Draw();
            graphic.Paint();

            Rectangle greenRectangle2 = new ("Rectangle2", "Green");
            greenRectangle2.Draw();
        }
    }
}
