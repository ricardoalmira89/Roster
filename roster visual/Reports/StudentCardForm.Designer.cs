namespace roster_visual.Reports
{
    partial class StudentCardForm
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.StudentCardReport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.StudentviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.StudentviewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentCardReport
            // 
            this.StudentCardReport.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.StudentviewBindingSource;
            this.StudentCardReport.LocalReport.DataSources.Add(reportDataSource1);
            this.StudentCardReport.LocalReport.ReportEmbeddedResource = "roster_visual.Reports.StudentCard.rdlc";
            this.StudentCardReport.Location = new System.Drawing.Point(0, 0);
            this.StudentCardReport.Name = "StudentCardReport";
            this.StudentCardReport.Size = new System.Drawing.Size(855, 532);
            this.StudentCardReport.TabIndex = 0;
            this.StudentCardReport.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // StudentviewBindingSource
            // 
            this.StudentviewBindingSource.DataSource = typeof(roster_visual.Studentview);
            // 
            // StudentCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 532);
            this.Controls.Add(this.StudentCardReport);
            this.Name = "StudentCardForm";
            this.Text = "StudentCardForm";
            this.Load += new System.EventHandler(this.StudentCardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentviewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer StudentCardReport;
        private System.Windows.Forms.BindingSource StudentviewBindingSource;
    }
}