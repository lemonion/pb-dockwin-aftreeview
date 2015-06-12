using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using OSIsoft.AF;
using OSIsoft.AF.UI;
using System.IO;

namespace PB_DockWin_AFTreeView
{
    [ComVisible(true)]
    public partial class AFTreeControl : UserControl
    {
        // The processBook application
        public PBObjLib.Application app;

        // Initialize the AF UI Controls
        public AFTreeControl()
        {
            InitializeComponent();

            // Populate AF Databases from the selected AF server
            afDbPicker.SystemPicker = afPicker;
        }

        // Change the elements in the TreeView to the selected AF system and AF Database
        private void afDbPicker_SelectionChange(object sender, SelectionChangeEventArgs e)
        {
            afTreeView.AFRoot = null;
            AFDatabase myDatabase = afDbPicker.AFDatabase;
            if (myDatabase != null && myDatabase.Elements != null)
                afTreeView.AFRoot = myDatabase.Elements;
        }

        // Open or add a display when the node is double-clicked
        private void afTreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            // parse element path to get the name of the elmement
            string[] path = e.Node.FullPath.Split('\\');
            string filePath = String.Format("C:\\Dev Support\\VBA in PB\\{0}.pdi", path[path.Length - 1]);

            // If the pdi exists, open the file
            if (File.Exists(filePath))
            {
                app.Displays.Open(filePath, false);
            }
            // if pdi doesn't exist, add a display with the name of the element
            else
            {
                app.Displays.Add(path[path.Length - 1]);
            }
        }
       
    }
}
