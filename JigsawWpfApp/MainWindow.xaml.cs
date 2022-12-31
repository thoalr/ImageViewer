using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Path = System.Windows.Shapes.Path;

namespace JigsawWpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

        public MainWindow()
        {
            InitializeComponent();
            JigFunc();
            //QuadBezierJigsaw();
        }

        private void JigFunc()
        {
            // Generate a random jigsaw piece shape
            //List<Point> points = new List<Point>() { new Point(0d, 0d),
            //                                         new Point(0.2, 0d), new Point(0.41, -0.06), new Point(0.45, 0.0),
            //                                         new Point(0.49, 0.08), new Point(0.42, 0.13),
            //                                         new Point(0.35, 0.15), new Point(0.35, 0.22),
            //                                         new Point(0.38, 0.3), new Point(0.5, 0.3), // middle
            //                                         new Point(0.62, 0.3), new Point(0.65, 0.22),
            //                                         new Point(0.65, 0.15), new Point(0.58, 0.13),
            //                                         new Point(0.51, 0.08), new Point(0.55, 0.0),
            //                                         new Point(0.59, -0.06), new Point(0.8, 0d), new Point(1.0, 0.0),}
            //                     .Select((p) => { p.X = p.X * 300d + 60d; p.Y = p.Y * 300d + 60d; return p; }).ToList();

            List<Point> points = new List<Point>() { new Point(0.0, 0.0),
                                                     new Point(0.45, -0.08), new Point(0.51, 0.03), new Point(0.4, 0.12),
                                                     new Point(0.3, 0.15),new Point(0.3, 0.3), new Point(0.5, 0.3), // middle
                                                     new Point(0.7, 0.3), new Point(0.7, 0.15), new Point(0.6, 0.12),
                                                     new Point(0.49, 0.03), new Point(0.55, -0.08), new Point(1.0, 0.0),}
                                 .Select((p) => { p.X = p.X * 300d + 60d; p.Y = p.Y * 300d + 60d; return p; }).ToList();

            // Create a path to represent the jigsaw piece
            Path path = new Path();
            path.Stroke = Brushes.Black;
            path.StrokeThickness = 1;

            // Create a figure to represent the jigsaw piece
            PathFigure figure = new PathFigure();
            figure.StartPoint = points[0];
            for (int i = 1; i < points.Count - 2; i += 3)
            {
                BezierSegment segment = new BezierSegment();
                segment.Point1 = points[i];
                segment.Point2 = points[i + 1];
                segment.Point3 = points[i + 2];
                figure.Segments.Add(segment);
            }

            figure.IsClosed = true;

            // Add the figure to the path
            PathGeometry geometry = new PathGeometry();
            geometry.Figures.Add(figure);
            path.Data = geometry;

            // Add the path to the canvas
            PuzzleCanvas.Children.Add(path);
            // draw points
            DrawPoints(points);
        }

        private void QuadBezierJigsaw()
        {
            // Generate a random jigsaw piece shape
            List<Point> points = new List<Point>() { new Point(0.0, 0.0),
                                                     new Point(0.41, -0.06), new Point(0.45, 0.0),
                                                     new Point(0.49, 0.08), new Point(0.42, 0.13),
                                                     new Point(0.35, 0.15), new Point(0.35, 0.22),
                                                     new Point(0.38, 0.3), new Point(0.5, 0.3), // middle
                                                     new Point(0.62, 0.3), new Point(0.65, 0.22),
                                                     new Point(0.65, 0.15), new Point(0.58, 0.13),
                                                     new Point(0.51, 0.08), new Point(0.55, 0.0),
                                                     new Point(0.59, -0.06), new Point(1.0, 0.0),}
                                 .Select((p) => { p.X = p.X * 300d + 60d; p.Y = p.Y * 300d + 60d; return p; }).ToList();

            // Create a path to represent the jigsaw piece
            Path path = new Path();
            path.Stroke = Brushes.Black;
            path.StrokeThickness = 1;

            // Create a figure to represent the jigsaw piece
            PathFigure figure = new PathFigure();
            figure.StartPoint = points[0];

            for (int i = 1; i < points.Count - 1; i += 2)
            {
                var segment = new QuadraticBezierSegment();
                segment.Point1 = points[i];
                segment.Point2 = points[i + 1];
                figure.Segments.Add(segment);
            }

            figure.IsClosed = true;

            // Add the figure to the path
            PathGeometry geometry = new PathGeometry();
            geometry.Figures.Add(figure);
            path.Data = geometry;

            // Add the path to the canvas
            PuzzleCanvas.Children.Add(path);
            // draw points
            DrawPoints(points);
        }

       private void DrawPoints(List<Point> points)
        {
            // draw points
            foreach (var p in points)
            {
                var myLine = new Line();
                myLine.Stroke = Brushes.Black;
                myLine.X1 = p.X - 1;
                myLine.X2 = p.X + 1;
                myLine.Y1 = p.Y - 1;
                myLine.Y2 = p.Y + 1;
                myLine.HorizontalAlignment = HorizontalAlignment.Left;
                myLine.VerticalAlignment = VerticalAlignment.Top;
                myLine.StrokeThickness = 4;
                PuzzleCanvas.Children.Add(myLine);
            }
        }
    }
}
