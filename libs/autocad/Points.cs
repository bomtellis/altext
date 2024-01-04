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
    public class Points
    {
        //private readonly Blocks BlockLib = new Blocks();
        //private readonly Polylines PolylineLib = new Polylines();

        public List<Blocks.SortedBlock> FindClostestPoints(List<Point2d> polylinePoints, List<Blocks.SortedBlock> selectedBlocks)
        {
            // start with first point in polyline points
            // interate through blocks to find closest to point #1
            // remove closest block from blocks and add it as first element in output list
            // interate through reduced block list until last element
            // add last element to output list as final element.
            // return list

            double closest = double.MaxValue;
            List<Blocks.SortedBlock> blocks = selectedBlocks;
            List<Blocks.SortedBlock> result = new List<Blocks.SortedBlock>();
            Blocks.SortedBlock closestBlock = null;

            foreach(Point2d point in polylinePoints)
            {
                // skip the first vertex
                foreach(Blocks.SortedBlock block in blocks)
                {
                    Point2d insertPoint = block.insertPoint;

                    double dx = Math.Pow((point.X - insertPoint.X), 2);
                    double dy = Math.Pow((point.Y - insertPoint.Y), 2);

                    double distance = dx + dy;

                    if(distance < closest)
                    {
                        closest = distance;
                        closestBlock = block;
                    }

                }

                // end of loop add the result to the organised list and remove closest element
                result.Add(closestBlock);
                blocks.Remove(closestBlock);
                closest = double.MaxValue;
            }

            return result;
        }
    }
}
