using System.Drawing;

namespace MapPathFinderApp.Dijkstra
{
    class PathsObject
    {
        public PointF StartLocation
        {
            get
            {
                return _startLocation;
            }
            set
            {
                _startLocation = value;
            }
        }
        private PointF _startLocation;

        public PointF EndLocation
        {
            get
            {
                return _endLocation;
            }
            set
            {
                _endLocation = value;
            }
        }
        private PointF _endLocation;

        public PointF North
        {
            get
            {
                return _north;
            }
            set
            {
                _north = value;
            }
        }
        private PointF _north;

        public PointF[] WaterMarkArray
        {
            get
            {
                return _waterMarkArray;
            }
            set
            {
                _waterMarkArray = value;
            }
        }
        private PointF[] _waterMarkArray;


        public PointF[] ShortestWayPaths
        {
            get
            {
                return _shortestWayPaths;
            }
            set
            {
                _shortestWayPaths = value;
            }
        }
        private PointF[] _shortestWayPaths;
    }
}
