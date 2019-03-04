using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace pusshy
{
    public partial class frmpusshy : Form
    {
        //It holds the name of the header column when a cell is right-clicked
        //Used for hiding columns
        string strColumnHeader; 
        //When a user hits enter, the next selected cell is on the right, not the bottom one
        //It allows horizontal scrolling when typing, not vertical
        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        {
            int intColumn = gridHosts.CurrentCell.ColumnIndex;
            int intRow = gridHosts.CurrentCell.RowIndex;
            if (keyData == Keys.Enter)
            {
                if (intColumn == gridHosts.Columns.Count - 1)
                {
                    gridHosts.Rows.Add();
                    gridHosts.CurrentCell = gridHosts[0, intRow + 1];
                }
                else
                {
                    gridHosts.CurrentCell = gridHosts[intColumn + 1, intRow];
                }
                return true;
            }
            else
                return base.ProcessCmdKey(ref msg, keyData);
        }

        public frmpusshy()
        {
            InitializeComponent();
        }

        private void frmpusshy_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Save the current size and position of the window
            //Used to remember these settings when the program is started next time
            Properties.Settings.Default["Location"] = this.Location;
            Properties.Settings.Default["Size"] = this.Size;
            Properties.Settings.Default.Save();
            //The local app data folder where settings and the data will be saved
            var strLocalAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            //The data is in pusshy.csv file under C:\Users\<username>\AppData\Local\pusshy
            var strFileName = strLocalAppData + "/pusshy/" + "pusshy.csv";
            string strCellValue;
            //Open the file for saving
            StreamWriter csvFileWriter = new StreamWriter(strFileName, false);
            int intColumnCount = gridHosts.ColumnCount - 1;
            int intColCount = gridHosts.Columns.Count;
            //Iterate through the grid and save
            foreach (DataGridViewRow dataRowObject in gridHosts.Rows)
            {
                if (!dataRowObject.IsNewRow)
                {
                    string strDataFromGrid = "";                    
                    for (int i = 0; i <= intColumnCount; i++)
                    {
                        try
                        {
                            strCellValue = dataRowObject.Cells[i].Value.ToString();
                        }
                        //If the cell has no value, replace it with blank string instead of null
                        catch (System.NullReferenceException exception)
                        {
                            strCellValue = "";
                        }
                        //Create a comma separated line
                        if (i != 0)
                        {
                            strDataFromGrid = strDataFromGrid + ',' + strCellValue;
                        }
                        else
                        {
                            strDataFromGrid = strCellValue;
                        }
                    }
                    csvFileWriter.WriteLine(strDataFromGrid);
                }
            }
            csvFileWriter.Flush();
            csvFileWriter.Close();
        }
        //Tag the whole row if there is a password in the password column (column=2). Used to hide password cells
        private void gridHosts_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {            
            if (gridHosts.CurrentRow.Tag != null && gridHosts.CurrentCell.ColumnIndex == 2)
            {
                e.Control.Text = gridHosts.CurrentRow.Tag.ToString();
            }
        }
        //Replace the text in the password cell (column=2) with dots
        private void gridHosts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.Value != null)
            {                
                gridHosts.Rows[e.RowIndex].Tag = e.Value;
                e.Value = new String('\u25CF', e.Value.ToString().Length);
            }
        }
        //Right-click on row header or column header
        private void gridHosts_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hit = gridHosts.HitTest(e.X, e.Y);
                var intCurrentColumnIndex = hit.ColumnIndex;
                //If the user right-clicks the column header display this menu
                if ((hit.Type == DataGridViewHitTestType.ColumnHeader))
                {
                    strColumnHeader = gridHosts.Columns[intCurrentColumnIndex].HeaderText;
                    menuRightColumnClick.Show(MousePosition);
                }
                //If the user right-clicks the column header display this menu
                if ((hit.Type == DataGridViewHitTestType.RowHeader))
                {
                    menuRightRowClick.Show(MousePosition);
                }
            }
        }
        //Hide the column that was selected
        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridHosts.Columns[strColumnHeader].Visible = false;
        }       
        //Delete a row
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in gridHosts.SelectedRows)
            {
                try
                {
                    gridHosts.Rows.Remove(row);
                }
                //Can't delete the bottom row. Catch the exception
                catch (InvalidOperationException exception)
                {
                    return;
                }
            }
        }

        private void frmpusshy_Load(object sender, EventArgs e)
        {
            //The local app data folder where settings and the data will be saved
            var strLocalAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            //The data is in pusshy.csv file under C:\Users\<username>\AppData\Local\pusshy
            var strFileName = strLocalAppData + "/pusshy/" + "pusshy.csv";
            if (!File.Exists(strFileName))
            {
                return;
            }   
            //Clear the grid and load the pusshy.csv file
            gridHosts.Rows.Clear();
            StreamReader fileReader = new StreamReader(strFileName, false);
            int i = 0;
            while (fileReader.Peek() != -1)
            {
                var fileRow = fileReader.ReadLine();
                var fileDataField = fileRow.Split(',');
                gridHosts.Rows.Add(fileDataField);
                //var rd = fileDataField[2];                
                i++;
            }
            fileReader.Dispose();
            fileReader.Close();
            //Change the size and the position of the application on load
            //With the settings that were saved last time the app was used
            this.Location = Properties.Settings.Default.Location;
            this.Size = Properties.Settings.Default.Size;
        }
        //When the user chooses Show All, all hidden columns will become visible
        private void showAllToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            foreach (DataGridViewColumn column in gridHosts.Columns)
            {
                string strHeaderCaptionText = column.HeaderText;
                gridHosts.Columns[strHeaderCaptionText].Visible = true;
            }                    
        }
        //When the user double-clicks a cell, launch the terminal
        private void gridHosts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string strCommand = "";
            int intRowIndex = gridHosts.CurrentCell.RowIndex;  
            //Get all values from the row
            string strHost = gridHosts.Rows[intRowIndex].Cells[0].Value.ToString();
            string strLogin = gridHosts.Rows[intRowIndex].Cells[1].Value.ToString();
            string strPwd = gridHosts.Rows[intRowIndex].Cells[2].Value.ToString();
            string strCert = gridHosts.Rows[intRowIndex].Cells[3].Value.ToString();
            //If the password cell is empty, start the terminal with certificate
            if (strPwd == "")
            {
                strCommand = "\"C:/windows/sysnative/OpenSSH/ssh.exe\" -l " + strLogin + " " + "-i " + strCert + " " + strHost;
            } else
            //Or without password
            {
                strCommand = "\"C:/windows/sysnative/OpenSSH/ssh.exe\" -l " + strLogin + " " + strHost;
            }
            Process.Start("powershell.exe", strCommand);            
        }
    }
}
