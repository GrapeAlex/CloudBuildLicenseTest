namespace CloudLicensingTest
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.c1FlexGrid1 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.fpSpread1 = new FarPoint.Win.Spread.FpSpread();
            this.fpSpread1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.adomdDataAdapter1 = new Microsoft.AnalysisServices.AdomdClient.AdomdDataAdapter();
            this.designer1 = new GrapeCity.ActiveReports.Design.Designer();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1FlexGrid1
            // 
            this.c1FlexGrid1.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.c1FlexGrid1.Location = new System.Drawing.Point(0, 0);
            this.c1FlexGrid1.Name = "c1FlexGrid1";
            this.c1FlexGrid1.Rows.DefaultSize = 19;
            this.c1FlexGrid1.TabIndex = 0;
            // 
            // fpSpread1
            // 
            this.fpSpread1.AccessibleDescription = "";
            this.fpSpread1.Location = new System.Drawing.Point(12, 12);
            this.fpSpread1.Name = "fpSpread1";
            this.fpSpread1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.fpSpread1_Sheet1});
            this.fpSpread1.Size = new System.Drawing.Size(200, 100);
            this.fpSpread1.TabIndex = 1;
            // 
            // fpSpread1_Sheet1
            // 
            this.fpSpread1_Sheet1.Reset();
            this.fpSpread1_Sheet1.SheetName = "Sheet1";
            // 
            // adomdDataAdapter1
            // 
            this.adomdDataAdapter1.SelectCommand = null;
            // 
            // designer1
            // 
            this.designer1.IsDirty = false;
            this.designer1.Location = new System.Drawing.Point(12, 222);
            this.designer1.LockControls = false;
            this.designer1.Name = "designer1";
            this.designer1.PreviewPages = 10;
            this.designer1.PromptUser = true;
            this.designer1.PropertyGrid = null;
            this.designer1.ReportPartsDirectory = "C:\\Users\\alex.risch\\Documents\\GrapeCity Reports Library";
            this.designer1.ReportTabsVisible = true;
            this.designer1.ShowDataSourceIcon = true;
            this.designer1.Size = new System.Drawing.Size(728, 348);
            this.designer1.TabIndex = 3;
            this.designer1.Toolbox = null;
            this.designer1.ToolBoxItem = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 569);
            this.Controls.Add(this.designer1);
            this.Controls.Add(this.fpSpread1);
            this.Name = "Form1";
            this.Text = "                                  ";
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private C1.Win.C1FlexGrid.C1FlexGrid c1FlexGrid1;
        private FarPoint.Win.Spread.FpSpread fpSpread1;
        private FarPoint.Win.Spread.SheetView fpSpread1_Sheet1;
        private Microsoft.AnalysisServices.AdomdClient.AdomdDataAdapter adomdDataAdapter1;
        private GrapeCity.ActiveReports.Design.Designer designer1;
    }
}

