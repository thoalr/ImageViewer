using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using static System.Net.Mime.MediaTypeNames;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        //Transform ImageTransform = Transform.Identity;
        //TranslateTransform ImagePanTransform = new TranslateTransform(0, 0);
        //ScaleTransform ImageZoomTransform = new ScaleTransform(1, 1, 0, 0);

        private Point _previousMousePosition = new Point(0,0);
        private int _zoomFactor = 100;
        private double _zoom = 1.0;
        private double _translationX = 0.0;
        private double _translationY = 0.0;

        
        public MainWindow()
        {
            InitializeComponent();
            
            
        }



        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            KeepImageCenteredWhenInsideContainer(0, 0);
            ImageControl.RenderTransform = new TransformGroup
            {
                Children =
                {
                    new ScaleTransform(_zoom, _zoom), //, imagePos.X, imagePos.Y),
                    new TranslateTransform(_translationX, _translationY)
                }
            };
        }


        private void KeepImageCenteredWhenInsideContainer(double dx, double dy) {

            //var imLocation = new Point(0, 0);// ImageControl.TranslatePoint(new Point(0, 0), ImageGridContainer);

            var imSize = ImageControl.RenderSize; 
            bool wider = imSize.Width * _zoom > ImageGridContainer.ActualWidth;
            bool heigher = imSize.Height * _zoom > ImageGridContainer.ActualHeight;
            
            if (!wider)
            {
                _translationX = ((ImageGridContainer.ActualWidth - (imSize.Width * _zoom)) / 2.0); // - _imageLocation.X;
            }
            else
            {
                _translationX += dx;
            }
            
            if (!heigher)
            {
                _translationY = ((ImageGridContainer.ActualHeight - (imSize.Height * _zoom)) / 2.0); // - _imageLocation.Y;
            }
            else
            {
                _translationY += dy;
            }


        }

        private void ImageControl_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            if(e.LeftButton != MouseButtonState.Released) { return; }
            
            _zoomFactor += e.Delta > 0 ? 10 : -10;
            _zoomFactor = Math.Max(_zoomFactor, 10);
            _zoomFactor = Math.Min(_zoomFactor, 1000);
            double prevZoom = _zoom;
            _zoom = ((double)_zoomFactor / 100.0);

            var mousePos = e.GetPosition(ImageGridContainer);
            var imageLocation = ImageControl.TranslatePoint(new Point(0,0), ImageGridContainer);
            var imageDeltaX = ((prevZoom - _zoom)/ prevZoom ) * (mousePos.X - imageLocation.X);
            var imageDeltaY = ((prevZoom - _zoom) / prevZoom) * (mousePos.Y - imageLocation.Y);

            //_translationX += imageDeltaX;
            //_translationY += imageDeltaY;

            /* https://stackoverflow.com/questions/16349798/reposition-rectangle-after-zooming
            Width delta is the new width minus the old width.
            Height delta is the new height minus the old height.
            Mouse x relative is the x-coordinate relative to the rect's left side
            Mouse y relative is the y-coordinate relative to the rect's top side 
            */

            // center when size is less than ImageGridConatainer
            KeepImageCenteredWhenInsideContainer(imageDeltaX, imageDeltaY);

            ImageControl.RenderTransform = new TransformGroup
            {
                Children =
                {
                    new ScaleTransform(_zoom, _zoom), //, imagePos.X, imagePos.Y),
                    new TranslateTransform(_translationX, _translationY)
                }
            };
        }

        private void ImageControl_MouseDown(object sender, MouseEventArgs e)
        {
            _previousMousePosition = e.GetPosition(this);

        }

        private void ImageControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Released)
            {
                return;
            }

            var currentPos = e.GetPosition(this);
            var movement = currentPos - _previousMousePosition;

            // center image
            KeepImageCenteredWhenInsideContainer(movement.X, movement.Y);

            ImageControl.RenderTransform = new TransformGroup
            {
                Children =
                    {
                        new ScaleTransform(_zoom, _zoom),
                        new TranslateTransform(_translationX, _translationY)
                    }
            };

            _previousMousePosition = currentPos;

        }

        private void Reset_Button_Click(object sender, RoutedEventArgs e)
        {
            ResetImageView();
        }


        public void ResetImageView()
        {
            _zoom = 1.0;
            _zoomFactor = 100;

            _translationX = 0;
            _translationY = 0;

            ImageControl.RenderTransform = Transform.Identity;
            
        }

        private void ImageGridContainer_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            KeepImageCenteredWhenInsideContainer(0, 0);
        }



        /*
         * 
         * 
         * 
         // Load the image and set it as the source for the Image control
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Replace "image.jpg" with the path to your image file
            string filePath = "image.jpg";
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(filePath);
            bitmap.EndInit();
            image.Source = bitmap;
        }

        // Track the mouse position and update the image transform when the mouse moves
        private void image_MouseMove(object sender, MouseEventArgs e)
        {
            Point mousePos = e.GetPosition(image);
            image.RenderTransform = new TranslateTransform(mousePos.X, mousePos.Y);
        }

        // Zoom the image in or out when the mouse wheel is scrolled
        private void image_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            double zoom = e.Delta > 0 ? 1.1 : 0.9;
            image.RenderTransform = new ScaleTransform(zoom, zoom, e.GetPosition(image).X, e.GetPosition(image).Y);
        }
         
         */
    }
}
