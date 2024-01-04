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
    public class Polylines
    {
        public ObjectId SelectPolyline()
        {
            // Setup List to return
            ObjectId polyline = new ObjectId();

            Document acDoc = Application.DocumentManager.MdiActiveDocument;
            Editor ed = acDoc.Editor;
            // Request for objects to be selected in the drawing area
            var options = new PromptEntityOptions("\nSelect Polyline: ");
            options.SetRejectMessage("\nNo Polyline selected");
            options.AddAllowedClass(typeof(Polyline), true);

            PromptEntityResult acSSPrompt = ed.GetEntity(options);

            // If the prompt status is OK, objects were selected
            if (acSSPrompt.Status == PromptStatus.OK)
            {
                polyline = acSSPrompt.ObjectId;
            }

            return polyline;
        }

        public List<Point2d> GetPolylineVertices(ObjectId polylineObjectId)
        {
            List<Point2d> polylineVertices = new List<Point2d>();
            Document doc = Application.DocumentManager.MdiActiveDocument;
            Database db = doc.Database;

            using(var t = db.TransactionManager.StartTransaction())
            {
                DBObject dbObj = t.GetObject(polylineObjectId, OpenMode.ForRead);
                if (dbObj != null)
                {
                    // record found!
                    Polyline polyline = dbObj as Polyline;
                    for(var i = 0; i < polyline.NumberOfVertices; i++)
                    {
                        polylineVertices.Add(polyline.GetPoint2dAt(i));
                        //ed.WriteMessage(String.Concat("Vertex Number: ", i + 1, " X: ", polylineVertices[i].X, " Y: ", polylineVertices[i].Y, "\n"));
                    }
                }
                else
                {
                    // no record in db
                }

                // close out the transaction
                t.Commit();
            }

            return polylineVertices;
        }
    }
}
