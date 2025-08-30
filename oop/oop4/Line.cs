namespace oop4
{
    public class Line
    {
        // Composition  
        public Point Start { get; set; } = new Point(0, 0);
        public Point End { get; set; } = new Point(0, 0);

        // Aggregation  
        public Color LineColor { get; set; } = null;


        //ctor with color
        public Line(Point start, Point end, Color color)
        {
            //if (start == null || end == null)
            //{
            //    start = new Point(0, 0);
            //    end = new Point(0, 0);
            //}
            Start = start;
            End = end;
            LineColor = color;
        }


        //ctor without color
        public Line(Point start, Point end)
        {
            
            Start = start;
            End = end;
          
        }

        public void Draw()
        {
            Console.WriteLine($"Line from ({Start.X},{Start.Y}) to ({End.X},{End.Y}) with color {LineColor?.Name}");
        }
    }
}
