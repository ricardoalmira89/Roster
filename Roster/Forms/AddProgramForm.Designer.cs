namespace Roster.Forms
{
    partial class AddProgramForm
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
            System.Windows.Forms.Label slugLabel;
            System.Windows.Forms.Label nameLabel;
            this.add_program_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.slugTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.programsGridView = new System.Windows.Forms.DataGridView();
            this.programMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slugDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            slugLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programsGridView)).BeginInit();
            this.programMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // add_program_btn
            // 
            this.add_program_btn.Location = new System.Drawing.Point(244, 248);
            this.add_program_btn.Name = "add_program_btn";
            this.add_program_btn.Size = new System.Drawing.Size(90, 23);
            this.add_program_btn.TabIndex = 1;
            this.add_program_btn.Text = "Add Program";
            this.add_program_btn.UseVisualStyleBackColor = true;
            this.add_program_btn.Click += new System.EventHandler(this.add_program_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_btn.Location = new System.Drawing.Point(163, 248);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel_btn.TabIndex = 2;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(slugLabel);
            this.groupBox1.Controls.Add(this.slugTextBox);
            this.groupBox1.Controls.Add(nameLabel);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 54);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Program Information";
            // 
            // slugLabel
            // 
            slugLabel.AutoSize = true;
            slugLabel.Location = new System.Drawing.Point(172, 25);
            slugLabel.Name = "slugLabel";
            slugLabel.Size = new System.Drawing.Size(31, 13);
            slugLabel.TabIndex = 9;
            slugLabel.Text = "Slug:";
            // 
            // slugTextBox
            // 
            this.slugTextBox.Location = new System.Drawing.Point(207, 22);
            this.slugTextBox.Name = "slugTextBox";
            this.slugTextBox.Size = new System.Drawing.Size(100, 20);
            this.slugTextBox.TabIndex = 10;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(14, 25);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 7;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(56, 22);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.programsGridView);
            this.groupBox2.Location = new System.Drawing.Point(12, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 173);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current Programs";
            // 
            // programsGridView
            // 
            this.programsGridView.AutoGenerateColumns = false;
            this.programsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.programsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.id,
            this.slugDataGridViewTextBoxColumn});
            this.programsGridView.ContextMenuStrip = this.programMenuStrip;
            this.programsGridView.DataSource = this.programBindingSource;
            this.programsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.programsGridView.Location = new System.Drawing.Point(3, 16);
            this.programsGridView.Name = "programsGridView";
            this.programsGridView.RowHeadersVisible = false;
            this.programsGridView.Size = new System.Drawing.Size(316, 154);
            this.programsGridView.TabIndex = 1;
            this.programsGridView.SelectionChanged += new System.EventHandler(this.programsGridView_SelectionChanged);
            // 
            // programMenuStrip
            // 
            this.programMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.newScheduleToolStripMenuItem});
            this.programMenuStrip.Name = "programMenuStrip";
            this.programMenuStrip.Size = new System.Drawing.Size(150, 48);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 190;
            // 
            // slugDataGridViewTextBoxColumn
            // 
            this.slugDataGridViewTextBoxColumn.DataPropertyName = "slug";
            this.slugDataGridViewTextBoxColumn.HeaderText = "Slug";
            this.slugDataGridViewTextBoxColumn.Name = "slugDataGridViewTextBoxColumn";
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataSource = typeof(Roster.Model.Program);
            // 
            // newScheduleToolStripMenuItem
            // 
            this.newScheduleToolStripMenuItem.Name = "newScheduleToolStripMenuItem";
            this.newScheduleToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.newScheduleToolStripMenuItem.Text = "New Schedule";
            // 
            // AddProgramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 276);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.add_program_btn);
            this.Name = "AddProgramForm";
            this.Text = "AddProgramForm";
            this.Load += new System.EventHandler(this.AddProgramForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.programsGridView)).EndInit();
            this.programMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource programBindingSource;
        private System.Windows.Forms.Button add_program_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox slugTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView programsGridView;
        private System.Windows.Forms.ContextMenuStrip programMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn slugDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem newScheduleToolStripMenuItem;
    }
}