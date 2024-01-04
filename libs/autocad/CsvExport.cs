using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Altext.libs.autocad
{
    public class CsvExport
    {
        public void WriteListToFile(List<Blocks.CSVOutput> list, string filePath)
        {
            // format list as csv
            string csvString = "Old Address, New Address\n";
            foreach(Blocks.CSVOutput block in list)
            {
                csvString += block.oldValue + "," + block.newValue + "\n";
            }

            File.WriteAllText(filePath, csvString);
        }
    }
}
