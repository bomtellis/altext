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
    public class Blocks
    {
        public class SortedBlock
        {
            public Point2d insertPoint;
            public ObjectId blockObjectId;
        }

        public class CSVOutput
        {
            public string oldValue;
            public string newValue;
        }

        public List<ObjectId> SelectBlocks()
        {
            // Setup List to return
            List<ObjectId> blocks = new List<ObjectId>();

            Document acDoc = Application.DocumentManager.MdiActiveDocument;
            // Request for objects to be selected in the drawing area
            var options = new PromptSelectionOptions();
            //options. ("\n Selected object(s) are not polylines");
            //options.AddAllowedClass(typeof(Polyline), true);

            PromptSelectionResult acSSPrompt = acDoc.Editor.GetSelection(options);

            // If the prompt status is OK, objects were selected
            if (acSSPrompt.Status == PromptStatus.OK)
            {
                SelectionSet acSSet = acSSPrompt.Value;

                // Step through the objects in the selection set
                foreach(ObjectId BlockId in acSSet.GetObjectIds())
                {
                    if(BlockId.ObjectClass.Name == "AcDbBlockReference")
                    {
                        blocks.Add(BlockId);
                    }
                }
            }
            else
            {
                return new List<ObjectId>();
            }

            return blocks;
        }

        public List<string> GetAttributes(ObjectId selectedBlock)
        {
            Document doc = Application.DocumentManager.MdiActiveDocument;
            Database db = doc.Database;
            List<string> attributeTags = new List<string>();

            using (var t = db.TransactionManager.StartTransaction())
            {
                //BlockTableRecord acBlkTblRec = t.GetObject(selectedBlock, OpenMode.ForRead) as BlockTableRecord;
                BlockReference blockReference = t.GetObject(selectedBlock, OpenMode.ForRead) as BlockReference;
                // Check to see if the block table record holds any attribute definitions

                if(blockReference != null)
                {
                    AttributeCollection attrCollection = blockReference.AttributeCollection;

                    foreach(ObjectId objID in attrCollection)
                    {
                        DBObject dbObj = t.GetObject(objID, OpenMode.ForRead) as DBObject;
                        if (dbObj is AttributeReference)
                        {
                            AttributeReference attrRef = dbObj as AttributeReference;

                            attributeTags.Add(attrRef.Tag);
                        }
                    }
                }
                
                else
                {
                    attributeTags.Add("Null");
                }

                // close out the transaction
                t.Commit();
            }

            return attributeTags;
        }

        public List<SortedBlock> GetInsertionBasePoints(List<ObjectId> blockIds)
        {
            List<SortedBlock> blockInsertionPoints = new List<SortedBlock>();

            Document doc = Application.DocumentManager.MdiActiveDocument;
            Database db = doc.Database;

            using (var t = db.TransactionManager.StartTransaction())
            {
                foreach(ObjectId objID in blockIds)
                {
                    BlockReference blockReference = t.GetObject(objID, OpenMode.ForRead) as BlockReference;

                    if (blockReference != null)
                    {
                        SortedBlock block = new SortedBlock
                        {
                            insertPoint = new Point2d(blockReference.Position.X, blockReference.Position.Y),
                            blockObjectId = objID
                        };

                        blockInsertionPoints.Add(block);
                    }
                }

                // close out the transaction
                t.Commit();
            }

            return blockInsertionPoints;
        }

        public void IncrementBlockAttribute(int incrementAmount, List<SortedBlock> blocks, string tagName, bool leadingZeros, bool leadingString, string leadingText, string filePath, bool csvExport = false)
        {
            int modifiedCount = 0;
            Document doc = Application.DocumentManager.MdiActiveDocument;
            Database db = doc.Database;
            Editor ed = doc.Editor;

            List<CSVOutput> csvOutput = new List<CSVOutput>();

            using(var docLock = doc.LockDocument())
            {
                using (var t = db.TransactionManager.StartTransaction())
                {
                    for (var i = 0; i < blocks.Count; i++)
                    {
                        CSVOutput tempCSV = new CSVOutput();
                        // alter each block find the tag by name and replace value with incremented value unless == 1

                        BlockReference blockReference = t.GetObject(blocks[i].blockObjectId, OpenMode.ForRead) as BlockReference;
                        // Check to see if the block table record holds any attribute definitions

                        if (blockReference != null)
                        {
                            AttributeCollection attrCollection = blockReference.AttributeCollection;

                            foreach (ObjectId objID in attrCollection)
                            {
                                DBObject dbObj = t.GetObject(objID, OpenMode.ForRead) as DBObject;
                                if (dbObj is AttributeReference)
                                {
                                    AttributeReference attrRef = dbObj as AttributeReference;

                                    if (attrRef.Tag.ToUpper() == tagName.ToUpper())
                                    {
                                        if(csvExport == true)
                                        {
                                            tempCSV.oldValue = attrRef.TextString;
                                        }

                                        // make it writeable
                                        dbObj.UpgradeOpen();

                                        // find the old string and increment replace with new string.
                                        int newValue = 1;

                                        if(i > 0)
                                        {
                                            if (incrementAmount == 1)
                                            {
                                                newValue = i + 1;
                                            }
                                            else
                                            {
                                                newValue += incrementAmount * i;
                                            }
                                        }

                                        if (leadingZeros == true)
                                        {
                                            string s = "";
                                            for (int y = 0; y < 3; y++)
                                            {
                                                s += "0";
                                            }

                                            attrRef.TextString = newValue.ToString(s);
                                        }
                                        else
                                        {
                                            attrRef.TextString = newValue.ToString();
                                        }

                                        if(leadingString == true)
                                        {
                                            attrRef.TextString = String.Concat(leadingText, attrRef.TextString);
                                        }

                                        modifiedCount++;

                                        if(csvExport == true)
                                        {
                                            tempCSV.newValue = attrRef.TextString;
                                            csvOutput.Add(tempCSV);
                                        }

                                        //make readonly again
                                        dbObj.DowngradeOpen();
                                    }
                                }
                            }
                        }
                    }

                    // commit the changes to db
                    t.Commit();

                }

                ed.WriteMessage("Total changes: " + modifiedCount);
            }

            // export to CSV to complete task
            if(csvExport == true)
            {
                CsvExport csvLib = new CsvExport();
                csvLib.WriteListToFile(csvOutput, filePath);
            }
            
        }

        public void IncrementOnly(int incrementAmount, List<SortedBlock> blocks, string tagName, bool leadingZeros, bool leadingString, string leadingText, string filePath, bool csvExport = false)
        {
            int modifiedCount = 0;
            Document doc = Application.DocumentManager.MdiActiveDocument;
            Database db = doc.Database;
            Editor ed = doc.Editor;

            List<CSVOutput> csvOutput = new List<CSVOutput>();

            using (var docLock = doc.LockDocument())
            {
                using (var t = db.TransactionManager.StartTransaction())
                {
                    for (var i = 0; i < blocks.Count; i++)
                    {
                        CSVOutput tempCSV = new CSVOutput();
                        // alter each block find the tag by name and replace value with incremented value unless == 1

                        BlockReference blockReference = t.GetObject(blocks[i].blockObjectId, OpenMode.ForRead) as BlockReference;
                        // Check to see if the block table record holds any attribute definitions

                        if (blockReference != null)
                        {
                            AttributeCollection attrCollection = blockReference.AttributeCollection;

                            foreach (ObjectId objID in attrCollection)
                            {
                                DBObject dbObj = t.GetObject(objID, OpenMode.ForRead) as DBObject;
                                if (dbObj is AttributeReference)
                                {
                                    AttributeReference attrRef = dbObj as AttributeReference;

                                    if (attrRef.Tag.ToUpper() == tagName.ToUpper())
                                    {
                                        if (csvExport == true)
                                        {
                                            tempCSV.oldValue = attrRef.TextString;
                                        }

                                        // make it writeable
                                        dbObj.UpgradeOpen();

                                        // find the old string and increment replace with new string.
                                        int newValue = 0;

                                        try
                                        {
                                            newValue = int.Parse(attrRef.TextString);
                                        }
                                        catch
                                        {
                                            newValue = 0;
                                        }

                                        if (i > 0)
                                        {
                                            if (incrementAmount == 1)
                                            {
                                                newValue += i + 1;
                                            }
                                            else
                                            {
                                                newValue += incrementAmount + i + 1;
                                            }
                                        }

                                        if (leadingZeros == true)
                                        {
                                            string s = "";
                                            for (int y = 0; y < 3; y++)
                                            {
                                                s += "0";
                                            }

                                            attrRef.TextString = newValue.ToString(s);
                                        }
                                        else
                                        {
                                            attrRef.TextString = newValue.ToString();
                                        }

                                        if (leadingString == true)
                                        {
                                            attrRef.TextString = String.Concat(leadingText, attrRef.TextString);
                                        }

                                        modifiedCount++;

                                        if (csvExport == true)
                                        {
                                            tempCSV.newValue = attrRef.TextString;
                                            csvOutput.Add(tempCSV);
                                        }

                                        //make readonly again
                                        dbObj.DowngradeOpen();
                                    }
                                }
                            }
                        }
                    }

                    // commit the changes to db
                    t.Commit();

                }

                ed.WriteMessage("Total changes: " + modifiedCount);
            }

            // export to CSV to complete task
            if (csvExport == true)
            {
                CsvExport csvLib = new CsvExport();
                csvLib.WriteListToFile(csvOutput, filePath);
            }

        }

        public void IncrementBlockAttributeBetweenValues(int incrementAmount, List<SortedBlock> blocks, string tagName, bool leadingZeros, bool leadingString, string leadingText, int startValue, int higherBound, string filePath, bool csvExport = false)
        {
            int modifiedCount = 0;
            Document doc = Application.DocumentManager.MdiActiveDocument;
            Database db = doc.Database;
            Editor ed = doc.Editor;

            List<CSVOutput> csvOutput = new List<CSVOutput>();

            using (var docLock = doc.LockDocument())
            {
                using (var t = db.TransactionManager.StartTransaction())
                {
                    for (var i = 0; i < blocks.Count; i++)
                    {
                        CSVOutput tempCSV = new CSVOutput();
                        // alter each block find the tag by name and replace value with incremented value unless == 1

                        BlockReference blockReference = t.GetObject(blocks[i].blockObjectId, OpenMode.ForRead) as BlockReference;
                        // Check to see if the block table record holds any attribute definitions

                        if (blockReference != null)
                        {
                            AttributeCollection attrCollection = blockReference.AttributeCollection;

                            foreach (ObjectId objID in attrCollection)
                            {
                                DBObject dbObj = t.GetObject(objID, OpenMode.ForRead) as DBObject;
                                if (dbObj is AttributeReference)
                                {
                                    AttributeReference attrRef = dbObj as AttributeReference;

                                    if (attrRef.Tag.ToUpper() == tagName.ToUpper())
                                    {
                                        // find the old string and increment replace with new string.
                                        int oldValue = int.Parse(attrRef.TextString);
                                        int newValue;

                                        if(oldValue >= startValue && oldValue <= higherBound)
                                        {
                                            // make it writeable
                                            dbObj.UpgradeOpen();

                                            newValue = startValue + i;

                                            if (i > 0)
                                            {
                                                if (incrementAmount == 1)
                                                {
                                                    newValue = i + 1;
                                                }
                                                else
                                                {
                                                    newValue += incrementAmount * i;
                                                }
                                            }

                                            if (leadingZeros == true)
                                            {
                                                string s = "";
                                                for (int y = 0; y < 3; y++)
                                                {
                                                    s += "0";
                                                }

                                                attrRef.TextString = newValue.ToString(s);
                                            }
                                            else
                                            {
                                                attrRef.TextString = newValue.ToString();
                                            }

                                            if (leadingString == true)
                                            {
                                                attrRef.TextString = String.Concat(leadingText, attrRef.TextString);
                                            }

                                            modifiedCount++;

                                            if(csvExport == true)
                                            {
                                                tempCSV.oldValue = oldValue.ToString();
                                                tempCSV.newValue = attrRef.TextString;
                                                csvOutput.Add(tempCSV);
                                            }

                                            //make readonly again
                                            dbObj.DowngradeOpen();
                                        }                                        
                                    }
                                }
                            }
                        }
                    }

                    // commit the changes to db
                    t.Commit();

                }

                ed.WriteMessage("Total changes: " + modifiedCount);
            }

            // export to CSV to complete task
            if (csvExport == true)
            {
                CsvExport csvLib = new CsvExport();
                csvLib.WriteListToFile(csvOutput, filePath);
            }
        }

        public void IncrementBlockWithStartValue(int incrementAmount, List<SortedBlock> blocks, string tagName, bool leadingZeros, bool leadingString, string leadingText, int startValue, string filePath, bool csvExport = false)
        {
            int modifiedCount = 0;
            Document doc = Application.DocumentManager.MdiActiveDocument;
            Database db = doc.Database;
            Editor ed = doc.Editor;

            List<CSVOutput> csvOutput = new List<CSVOutput>();

            using (var docLock = doc.LockDocument())
            {
                using (var t = db.TransactionManager.StartTransaction())
                {
                    for (var i = 0; i < blocks.Count; i++)
                    {
                        CSVOutput tempCSV = new CSVOutput();
                        // alter each block find the tag by name and replace value with incremented value unless == 1

                        BlockReference blockReference = t.GetObject(blocks[i].blockObjectId, OpenMode.ForRead) as BlockReference;
                        // Check to see if the block table record holds any attribute definitions

                        if (blockReference != null)
                        {
                            AttributeCollection attrCollection = blockReference.AttributeCollection;

                            foreach (ObjectId objID in attrCollection)
                            {
                                DBObject dbObj = t.GetObject(objID, OpenMode.ForRead) as DBObject;
                                if (dbObj is AttributeReference)
                                {
                                    AttributeReference attrRef = dbObj as AttributeReference;

                                    if (attrRef.Tag.ToUpper() == tagName.ToUpper())
                                    {
                                            // do work
                                            int oldValue = int.Parse(attrRef.TextString);

                                            // make it writeable
                                            dbObj.UpgradeOpen();

                                            // find the old string and increment replace with new string.
                                            int newValue = startValue;

                                            if (i > 0)
                                            {
                                                if (incrementAmount == 1)
                                                {
                                                    newValue += i;
                                                }
                                                else
                                                {
                                                    newValue += incrementAmount * i;
                                                }
                                            }

                                            if (leadingZeros == true)
                                            {
                                                string s = "";
                                                for (int y = 0; y < 3; y++)
                                                {
                                                    s += "0";
                                                }

                                                attrRef.TextString = newValue.ToString(s);
                                            }
                                            else
                                            {
                                                attrRef.TextString = newValue.ToString();
                                            }

                                            if (leadingString == true)
                                            {
                                                attrRef.TextString = String.Concat(leadingText, attrRef.TextString);
                                            }

                                            modifiedCount++;

                                            if(csvExport == true)
                                            {
                                                tempCSV.oldValue = oldValue.ToString();
                                                tempCSV.newValue = attrRef.TextString;
                                                csvOutput.Add(tempCSV);
                                            }

                                            //make readonly again
                                            dbObj.DowngradeOpen();
                                    }
                                }
                            }
                        }
                    }

                    // commit the changes to db
                    t.Commit();

                }

                ed.WriteMessage("Total changes: " + modifiedCount);
            }

            // export to CSV to complete task
            if (csvExport == true)
            {
                CsvExport csvLib = new CsvExport();
                csvLib.WriteListToFile(csvOutput, filePath);
            }
        }

        public void IncrementBlockAttributeToValue(int incrementAmount, List<SortedBlock> blocks, string tagName, bool leadingZeros, bool leadingString, string leadingText, int higherBound, string filePath, bool csvExport = false)
        {
            int modifiedCount = 0;
            Document doc = Application.DocumentManager.MdiActiveDocument;
            Database db = doc.Database;
            Editor ed = doc.Editor;

            List<CSVOutput> csvOutput = new List<CSVOutput>();

            using (var docLock = doc.LockDocument())
            {
                using (var t = db.TransactionManager.StartTransaction())
                {
                    for (var i = 0; i < blocks.Count; i++)
                    {
                        CSVOutput tempCSV = new CSVOutput();
                        // alter each block find the tag by name and replace value with incremented value unless == 1

                        BlockReference blockReference = t.GetObject(blocks[i].blockObjectId, OpenMode.ForRead) as BlockReference;
                        // Check to see if the block table record holds any attribute definitions

                        if (blockReference != null)
                        {
                            AttributeCollection attrCollection = blockReference.AttributeCollection;

                            foreach (ObjectId objID in attrCollection)
                            {
                                DBObject dbObj = t.GetObject(objID, OpenMode.ForRead) as DBObject;
                                if (dbObj is AttributeReference)
                                {
                                    AttributeReference attrRef = dbObj as AttributeReference;

                                    if (attrRef.Tag.ToUpper() == tagName.ToUpper())
                                    {
                                        int oldString = int.Parse(attrRef.TextString);

                                        if(oldString <= higherBound)
                                        {
                                            // make it writeable
                                            dbObj.UpgradeOpen();

                                            // find the old string and increment replace with new string.
                                            int newValue = 1;

                                            if (i > 0)
                                            {
                                                if (incrementAmount == 1)
                                                {
                                                    newValue = i + 1;
                                                }
                                                else
                                                {
                                                    newValue += incrementAmount + i + 1;
                                                }
                                            }

                                            if (leadingZeros == true)
                                            {
                                                string s = "";
                                                for (int y = 0; y < 3; y++)
                                                {
                                                    s += "0";
                                                }

                                                attrRef.TextString = newValue.ToString(s);
                                            }
                                            else
                                            {
                                                attrRef.TextString = newValue.ToString();
                                            }

                                            modifiedCount++;

                                            if (leadingString == true)
                                            {
                                                attrRef.TextString = String.Concat(leadingText, attrRef.TextString);
                                            }

                                            if (csvExport == true)
                                            {
                                                tempCSV.oldValue = oldString.ToString();
                                                tempCSV.newValue = attrRef.TextString;
                                                csvOutput.Add(tempCSV);
                                            }

                                            //make readonly again
                                            dbObj.DowngradeOpen();
                                        }
                                    }
                                }
                            }
                        }
                    }

                    // commit the changes to db
                    t.Commit();

                }

                ed.WriteMessage("Total changes: " + modifiedCount);
            }

            // export to CSV to complete task
            if (csvExport == true)
            {
                CsvExport csvLib = new CsvExport();
                csvLib.WriteListToFile(csvOutput, filePath);
            }
        }

    }
}
