using System.Drawing;
using System.Windows.Forms;

namespace MapPathFinderApp.Image
{
    public class ImageObject : PictureBox
    {
        public string ImagePath
        {
            get
            {
                return _imagePath;
            }
            set
            {
                _imagePath = value;
            }
        }
        private string _imagePath;

        public Bitmap UnManagedImage
        {
            get
            {
                return _unmanagedImage;
            }
            set
            {
                _unmanagedImage = value;
            }
        }
        private Bitmap _unmanagedImage;

        public Bitmap BlackWhiteMap
        {
            get
            {
                return _blackWhiteMap;
            }
            set
            {
                _blackWhiteMap = value;
            }
        }
        private Bitmap _blackWhiteMap;

        public Color[][] MapMatrix
        {
            get
            {
                return _mapMatrix;
            }
            set
            {
                _mapMatrix = value;
            }
        }
        private Color[][] _mapMatrix;

        public void Clean()
        {
            ImagePath = null;
            if (UnManagedImage != null)
            {
                UnManagedImage.Dispose();
            }
            UnManagedImage = null;
            if (BlackWhiteMap != null)
            {
                BlackWhiteMap.Dispose();
            }
            BlackWhiteMap = null;
        }
    }
}
