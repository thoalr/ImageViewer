using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace WpfApp1
{
    class ViewController
    {
        // inject view, has function to update view when necessary
        private IViewControl viewControl;

        public ImageSource? Image;

        public List<string>? FileList;
        public string? CurrentDirectory;


        public ViewController() {
            Image = new BitmapImage(new Uri("/gw001.jpg"));
        }


        public void OpenDirectory(string fileName)
        {
            FileInfo f = new FileInfo(fileName);
            var fullFile = Path.Combine(CurrentDirectory, f.Name);
            
        }

    }
}
