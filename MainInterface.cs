using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

// autocad libs
using Altext.libs.autocad;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;

namespace Altext
{
    public partial class MainInterface : Form
    {
        private bool csvOutputEnable = false; // inverse operation, enables the save dialog and path box
        private readonly Blocks BlocksLib = new Blocks();
        private readonly Polylines polylines = new Polylines();
        private readonly Points points = new Points();

        private List<ObjectId> blocks = new List<ObjectId>();
        private ObjectId polylineId = new ObjectId();

        public MainInterface()
        {
            InitializeComponent();
            FilePathTxtBox.Enabled = csvOutputEnable;
            SavePathBtn.Enabled = csvOutputEnable;
            LeadingLetterTxtBox.Enabled = LeadingLetterCheckBox.Checked;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CsvOutputCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            csvOutputEnable = CsvOutputCheckBox.Checked;
            FilePathTxtBox.Enabled = csvOutputEnable;
            SavePathBtn.Enabled = csvOutputEnable;
        }

        private void ModeComboBox_TextChanged(object sender, EventArgs e)
        {
            switch (ModeComboBox.Text)
            {
                //Renumber all
                //Increment from value

                case "Renumber all":
                    StartNumberTxtBox.Enabled = false;
                    StartBtn.Enabled = true;
                    break;
                case "Increment from value":
                    StartNumberTxtBox.Enabled = true;
                    StartBtn.Enabled = true;
                    break;
                default:
                    StartNumberTxtBox.Enabled = false;
                    StartBtn.Enabled = false;
                    break;
            }
        }

        private void PickBlockBtn_Click(object sender, EventArgs e)
        {
            // some code to pick blocks
            this.Hide(); // hide the form so the blocks can be selected

            List<ObjectId> selectedBlocks = BlocksLib.SelectBlocks(); // get the blocks
            this.blocks = selectedBlocks; // save object id list

            // Clear Items and load in list of strings to combo box
            AttributeComboBox.DataSource = null;
            AttributeComboBox.Items.Clear();
            AttributeComboBox.DataSource = BlocksLib.GetAttributes(selectedBlocks.First());

            this.Show(); // show the form with the new list appended to combo box

            // enable the combo box to select which one to alter
            AttributeComboBox.Enabled = true;
        }

        private void PickPolylineBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // hide the form to select polyline
            ObjectId polyline = polylines.SelectPolyline();
            this.polylineId = polyline;
            PolylineStatusTxtBox.Text = "Selected";
            this.Show();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            bool runProgram = false;
            int programType = 0;

            if (ModeComboBox.Text != "")
            {
                switch (ModeComboBox.Text)
                {
                    case "Renumber all":
                        StartNumberTxtBox.Enabled = false;
                        if(IncrementTxtBox.Text != "")
                        {
                            runProgram = true;
                            programType = 0;
                        }
                        break;
                    case "Increment from value":
                        StartNumberTxtBox.Enabled = true;
                        if (IncrementTxtBox.Text != "" && StartNumberTxtBox.Text != "")
                        {
                            runProgram = true;
                            programType = 4;
                        }
                        break;
                    default:
                        StartNumberTxtBox.Enabled = false;
                        StartBtn.Enabled = false;
                        programType = 0;
                        break;
                }
            }

            if(blocks.Count == 0 && polylineId.IsNull)
            {
                runProgram = false;
            }

            if(csvOutputEnable && FilePathTxtBox.Text != "")
            {
                runProgram = true;
            }

            //get vertices of polyline
            List<Point2d> polylinePoints = polylines.GetPolylineVertices(polylineId);

            // check if the polyline duplicate box is checked
            if (PLineDuplicates.Checked)
            {
                polylinePoints = polylinePoints.Distinct(new PolylineDistinct()).ToList();
            }

            //get insertion points of blocks
            List<Blocks.SortedBlock> blockInsertionPoints = BlocksLib.GetInsertionBasePoints(blocks);

            // get blocks organised following the polyline
            List<Blocks.SortedBlock> organisedBlocks = points.FindClostestPoints(polylinePoints, blockInsertionPoints);

            // Check number of points in polyline match number of blocks in group
            if (polylinePoints.Count != blocks.Count)
            {
                runProgram = false;
            }

            if (runProgram)
            {
                switch (programType)
                {
                    case 0:
                        // do the job
                        BlocksLib.IncrementBlockAttribute(int.Parse(IncrementTxtBox.Text), organisedBlocks, AttributeComboBox.Text, LeadingZerosCheckBox.Checked, LeadingLetterCheckBox.Checked, LeadingLetterTxtBox.Text, FilePathTxtBox.Text, CsvOutputCheckBox.Checked);
                        break;
                    case 4:
                        // do the job
                        BlocksLib.IncrementBlockWithStartValue(int.Parse(IncrementTxtBox.Text), organisedBlocks, AttributeComboBox.Text, LeadingZerosCheckBox.Checked, LeadingLetterCheckBox.Checked, LeadingLetterTxtBox.Text, int.Parse(StartNumberTxtBox.Text), FilePathTxtBox.Text, CsvOutputCheckBox.Checked);
                        break;
                    default:
                        break;
                }

                this.Close();
            }
            else
            {
                // Check number of points in polyline match number of blocks in group
                if (polylinePoints.Count != blocks.Count)
                {
                    MessageBox.Show("The number of polyline vertices doesn\'t match the number of blocks selected.");
                }

                MessageBox.Show("Please fill in the fields required");
            }
        }

        private void SavePathBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "CSV Files (*.csv)|*.csv|All files (*.*)|*.*"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FilePathTxtBox.Text = Path.GetFullPath(saveFileDialog.FileName);
            }
        }

        private void SaveFileDialogCSV_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void ModeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LeadingLetterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            LeadingLetterTxtBox.Enabled = LeadingLetterCheckBox.Checked;
        }
    }
}
