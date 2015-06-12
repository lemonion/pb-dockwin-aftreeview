namespace PB_DockWin_AFTreeView
{
    partial class AFTreeControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.afPicker = new OSIsoft.AF.UI.PISystemPicker();
            this.afDbPicker = new OSIsoft.AF.UI.AFDatabasePicker();
            this.afTreeView = new OSIsoft.AF.UI.AFTreeView();
            this.SuspendLayout();
            // 
            // afPicker
            // 
            this.afPicker.AccessibleDescription = "PI System Picker";
            this.afPicker.AccessibleName = "PI System Picker";
            this.afPicker.Cursor = System.Windows.Forms.Cursors.Default;
            this.afPicker.Location = new System.Drawing.Point(4, 4);
            this.afPicker.Name = "afPicker";
            this.afPicker.ShowBegin = false;
            this.afPicker.ShowDelete = false;
            this.afPicker.ShowEnd = false;
            this.afPicker.ShowFind = false;
            this.afPicker.ShowNavigation = false;
            this.afPicker.ShowNew = false;
            this.afPicker.ShowNext = false;
            this.afPicker.ShowPrevious = false;
            this.afPicker.ShowProperties = false;
            this.afPicker.Size = new System.Drawing.Size(237, 22);
            this.afPicker.TabIndex = 0;
            // 
            // afDbPicker
            // 
            this.afDbPicker.AccessibleDescription = "Database Picker";
            this.afDbPicker.AccessibleName = "Database Picker";
            this.afDbPicker.Location = new System.Drawing.Point(4, 33);
            this.afDbPicker.Name = "afDbPicker";
            this.afDbPicker.ShowBegin = false;
            this.afDbPicker.ShowDelete = false;
            this.afDbPicker.ShowEnd = false;
            this.afDbPicker.ShowFind = false;
            this.afDbPicker.ShowNavigation = false;
            this.afDbPicker.ShowNew = false;
            this.afDbPicker.ShowNext = false;
            this.afDbPicker.ShowPrevious = false;
            this.afDbPicker.ShowProperties = false;
            this.afDbPicker.Size = new System.Drawing.Size(237, 22);
            this.afDbPicker.TabIndex = 1;
            this.afDbPicker.SelectionChange += new OSIsoft.AF.UI.SelectionChangeEventHandler(this.afDbPicker_SelectionChange);
            // 
            // afTreeView
            // 
            this.afTreeView.HideSelection = false;
            this.afTreeView.Location = new System.Drawing.Point(4, 62);
            this.afTreeView.Name = "afTreeView";
            this.afTreeView.ShowNodeToolTips = true;
            this.afTreeView.Size = new System.Drawing.Size(237, 440);
            this.afTreeView.TabIndex = 2;
            this.afTreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.afTreeView_NodeMouseDoubleClick);
            // 
            // AFTreeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.afTreeView);
            this.Controls.Add(this.afDbPicker);
            this.Controls.Add(this.afPicker);
            this.Name = "AFTreeControl";
            this.Size = new System.Drawing.Size(244, 505);
            this.ResumeLayout(false);

        }

        #endregion

        private OSIsoft.AF.UI.PISystemPicker afPicker;
        private OSIsoft.AF.UI.AFDatabasePicker afDbPicker;
        private OSIsoft.AF.UI.AFTreeView afTreeView;


    }
}
