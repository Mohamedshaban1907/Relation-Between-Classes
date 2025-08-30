using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop4
{








    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

   

    


    public class Color
    {
        public string Name { get; set; }

        public Color(string name)
        {
            Name = name;
        }
    }



    public class Line
    {
        // Composition  
        public Point Start { get; set; }
        public Point End { get; set; }

        // Aggregation  
        public Color LineColor { get; set; } = null;

        public Line(Point start, Point end, Color color)
        {
            if (start == null || end == null)
            {
                start = new Point(0, 0);
                end = new Point(0, 0);
            }
            Start = start;
            End = end;
            LineColor = color;
        }



        public Line(Point start, Point end)
        {
            if (start == null || end == null)
            {
                start = new Point(0, 0);
                end = new Point(0, 0);
            }
            Start = start;
            End = end;
          
        }

        public void Draw()
        {
            Console.WriteLine($"Line from ({Start.X},{Start.Y}) to ({End.X},{End.Y}) with color {LineColor?.Name}");
        }
    }
}
