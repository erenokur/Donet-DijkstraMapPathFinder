using MapPathFinderApp.Dijkstra;
using MapPathFinderApp.Image;
using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Drawing;
using System.Windows.Forms;

namespace MapPathFinderApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            FormEvenets = new ObservableCollection<object>();
            FormEvenets.CollectionChanged += FormEvenets_CollectionChanged;
            ImageConvert = new ImageManager();
            ImageConvert.InitializeImageConverter();
            InitializeComponent();
        }
        void FormEvenets_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
            {
                for (int i = 0; i < FormEvenets.Count; i++)
                {
                    if (FormEvenets[i].GetType().Name == "String")
                    {
                        if (FormEvenets[i].ToString() == "PictureLoaded")
                        {
                            MapPanel.BackgroundImage = ImageConvert.UnManagedImage;
                        }
                    }
                    else if (FormEvenets[i].GetType().Name == "Int32")
                    {
                        int CurrentPageNumber = Convert.ToInt32(FormEvenets[i]);
                    }
                    else if (FormEvenets[i].GetType().ToString().Contains(".Controls."))
                    {

                    }
                }
                FormEvenets.Clear();
            }
        }

        private void AddMap_Click(object sender, System.EventArgs e)
        {
            MapPanel.BackgroundImage = Properties.Resources.WaitAMoment;
            ImageConvert.Clean();
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                ImageConvert.ImagePath = open.FileName;
                ImageConvert.UnManagedImage = new Bitmap(open.FileName);
                ImageManager.NewImageAdded.Add(true);
            }
            else
            {
                MapPanel.BackgroundImage = null;
            }
        }

        private void FindPath_Click(object sender, System.EventArgs e)
        {

        }

        private void ClearAll_Click(object sender, System.EventArgs e)
        {
            ImageConvert.Clean();
        }

        private void SendPathRobot_Click(object sender, System.EventArgs e)
        {
            PathFindManager.test();
        }

        public static ImageManager ImageConvert;
        public static ObservableCollection<object> FormEvenets;
    }
}
