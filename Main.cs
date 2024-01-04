using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // remember to comment out when loading for AutoCAD

// Import Autodesk Dependancies
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.DatabaseServices;
//using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Geometry;

namespace Altext
{
    public class Main
    {
        [CommandMethod("altext", CommandFlags.UsePickSet)]
        public void Altext()
        {
            // Load up interface to perform the *magic*
            MainInterface mainInterface = new MainInterface();
            mainInterface.Show();
        }

        [CommandMethod("altext_version", CommandFlags.UsePickSet)]
        public void altext_version()
        {
            // Load up interface to perform the *magic*
            Editor ed = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor;
            ed.WriteMessage("\nAltext version: 0.2.1");
        }
    }

    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.Run(new MainInterface());
        }
    }
}

