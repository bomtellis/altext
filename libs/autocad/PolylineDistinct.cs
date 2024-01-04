using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Import Autodesk Autocad References
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Colors;

namespace Altext.libs.autocad
{
    public class PolylineDistinct : IEqualityComparer<Point2d>
    {
        public bool Equals(Point2d x, Point2d y)
        {
            return (x.X == y.X && x.Y == y.Y);
        }

        public int GetHashCode(Point2d obj)
        {
            return obj.GetHashCode();
        }
    }
}
