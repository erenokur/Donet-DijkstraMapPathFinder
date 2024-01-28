using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Threading;

namespace MapPathFinderApp.Image
{
    public class ImageManager : ImageConvertMatrix
    {
        public void InitializeImageConverter()
        {
            NewImageAdded = new ObservableCollection<bool>();
            NewImageAdded.CollectionChanged += NewImageAdded_CollectionChanged;
        }
        void NewImageAdded_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
            {
                if (_startConvertation == null || !_startConvertation.IsAlive)
                {
                    _startConvertation = new Thread(() => StartConverting());
                    _startConvertation.IsBackground = true;
                    _startConvertation.Start();
                }
                NewImageAdded.Clear();
            }
        }

        private void StartConverting()
        {
            BlackWhiteMap = MakeGrayscale(UnManagedImage);
            MapMatrix = GetBitMapColorMatrix(BlackWhiteMap);
            MainForm.FormEvenets.Add("PictureLoaded");
        }

        private Thread _startConvertation;
        public static ObservableCollection<bool> NewImageAdded;
    }
}
