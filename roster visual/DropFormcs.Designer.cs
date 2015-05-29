namespace roster_visual
{
    partial class DropForm
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
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label amountLabel;
            System.Windows.Forms.Label paidLabel;
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.dropInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paidCheckBox = new System.Windows.Forms.CheckBox();
            this.refundRadioButton = new System.Windows.Forms.RadioButton();
            this.balanceRadioButton = new System.Windows.Forms.RadioButton();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Drop_btn = new System.Windows.Forms.Button();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            paidLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(13, 27);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(60, 13);
            firstNameLabel.TabIndex = 1;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(12, 53);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(61, 13);
            lastNameLabel.TabIndex = 2;
            lastNameLabel.Text = "Last Name:";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(210, 28);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(46, 13);
            amountLabel.TabIndex = 4;
            amountLabel.Text = "Amount:";
            // 
            // paidLabel
            // 
            paidLabel.AutoSize = true;
            paidLabel.Location = new System.Drawing.Point(225, 58);
            paidLabel.Name = "paidLabel";
            paidLabel.Size = new System.Drawing.Size(31, 13);
            paidLabel.TabIndex = 6;
            paidLabel.Text = "Paid:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(79, 24);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.ReadOnly = true;
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextBox.TabIndex = 2;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(roster_visual.Student);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(79, 50);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.ReadOnly = true;
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 3;
            // 
            // amountTextBox
            // 
            this.amountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dropInfoBindingSource, "Amount", true));
            this.amountTextBox.Location = new System.Drawing.Point(262, 25);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(52, 20);
            this.amountTextBox.TabIndex = 5;
            // 
            // dropInfoBindingSource
            // 
            this.dropInfoBindingSource.DataSource = typeof(roster_visual.DropInfo);
            // 
            // paidCheckBox
            // 
            this.paidCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.dropInfoBindingSource, "Paid", true));
            this.paidCheckBox.Location = new System.Drawing.Point(262, 53);
            this.paidCheckBox.Name = "paidCheckBox";
            this.paidCheckBox.Size = new System.Drawing.Size(23, 24);
            this.paidCheckBox.TabIndex = 7;
            this.paidCheckBox.UseVisualStyleBackColor = true;
            // 
            // refundRadioButton
            // 
            this.refundRadioButton.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dropInfoBindingSource, "Refund", true));
            this.refundRadioButton.Location = new System.Drawing.Point(16, 105);
            this.refundRadioButton.Name = "refundRadioButton";
            this.refundRadioButton.Size = new System.Drawing.Size(98, 24);
            this.refundRadioButton.TabIndex = 9;
            this.refundRadioButton.Text = "Refund";
            this.refundRadioButton.UseVisualStyleBackColor = true;
            this.refundRadioButton.CheckedChanged += new System.EventHandler(this.refundRadioButton_CheckedChanged);
            // 
            // balanceRadioButton
            // 
            this.balanceRadioButton.AutoSize = true;
            this.balanceRadioButton.Checked = true;
            this.balanceRadioButton.Location = new System.Drawing.Point(16, 129);
            this.balanceRadioButton.Name = "balanceRadioButton";
            this.balanceRadioButton.Size = new System.Drawing.Size(64, 17);
            this.balanceRadioButton.TabIndex = 10;
            this.balanceRadioButton.TabStop = true;
            this.balanceRadioButton.Text = "Balance";
            this.balanceRadioButton.UseVisualStyleBackColor = true;
            this.balanceRadioButton.CheckedChanged += new System.EventHandler(this.refundRadioButton_CheckedChanged);
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dropInfoBindingSource, "Date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(131, 125);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateDateTimePicker.TabIndex = 11;
            // 
            // Drop_btn
            // 
            this.Drop_btn.Location = new System.Drawing.Point(357, 154);
            this.Drop_btn.Name = "Drop_btn";
            this.Drop_btn.Size = new System.Drawing.Size(75, 23);
            this.Drop_btn.TabIndex = 12;
            this.Drop_btn.Text = "Drop";
            this.Drop_btn.UseVisualStyleBackColor = true;
            this.Drop_btn.Click += new System.EventHandler(this.Drop_btn_Click);
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_btn.Location = new System.Drawing.Point(276, 154);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.Cancel_btn.TabIndex = 13;
            this.Cancel_btn.Text = "Cancel";
            this.Cancel_btn.UseVisualStyleBackColor = true;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(134, 109);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(75, 13);
            this.dateLabel.TabIndex = 14;
            this.dateLabel.Text = "To be paid by:";
            // 
            // DropForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 189);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.Drop_btn);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(this.balanceRadioButton);
            this.Controls.Add(this.refundRadioButton);
            this.Controls.Add(paidLabel);
            this.Controls.Add(this.paidCheckBox);
            this.Controls.Add(amountLabel);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Name = "DropForm";
            this.Text = "Drop Student";
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.BindingSource dropInfoBindingSource;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.CheckBox paidCheckBox;
        private System.Windows.Forms.RadioButton refundRadioButton;
        private System.Windows.Forms.RadioButton balanceRadioButton;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.Button Drop_btn;
        private System.Windows.Forms.Button Cancel_btn;
        private System.Windows.Forms.Label dateLabel;

    }
}