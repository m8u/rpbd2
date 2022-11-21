namespace rpbd2.GUI
{
    partial class EditShip
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.carryCapacityNumeric = new System.Windows.Forms.NumericUpDown();
            this.homeportComboBox = new System.Windows.Forms.ComboBox();
            this.purposeComboBox = new System.Windows.Forms.ComboBox();
            this.overhaulStartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.crewGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberComboBox = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.applyButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carryCapacityNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crewGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.nameTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.carryCapacityNumeric, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.homeportComboBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.purposeComboBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.overhaulStartDatePicker, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.crewGridView, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(329, 249);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Carry capacity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Homeport:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Purpose:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Overhaul start date:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(119, 3);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(206, 23);
            this.nameTextBox.TabIndex = 5;
            // 
            // carryCapacityNumeric
            // 
            this.carryCapacityNumeric.Location = new System.Drawing.Point(119, 32);
            this.carryCapacityNumeric.Name = "carryCapacityNumeric";
            this.carryCapacityNumeric.Size = new System.Drawing.Size(206, 23);
            this.carryCapacityNumeric.TabIndex = 6;
            // 
            // homeportComboBox
            // 
            this.homeportComboBox.FormattingEnabled = true;
            this.homeportComboBox.Location = new System.Drawing.Point(119, 61);
            this.homeportComboBox.Name = "homeportComboBox";
            this.homeportComboBox.Size = new System.Drawing.Size(206, 23);
            this.homeportComboBox.TabIndex = 7;
            // 
            // purposeComboBox
            // 
            this.purposeComboBox.FormattingEnabled = true;
            this.purposeComboBox.Location = new System.Drawing.Point(119, 90);
            this.purposeComboBox.Name = "purposeComboBox";
            this.purposeComboBox.Size = new System.Drawing.Size(206, 23);
            this.purposeComboBox.TabIndex = 8;
            // 
            // overhaulStartDatePicker
            // 
            this.overhaulStartDatePicker.Location = new System.Drawing.Point(119, 119);
            this.overhaulStartDatePicker.Name = "overhaulStartDatePicker";
            this.overhaulStartDatePicker.Size = new System.Drawing.Size(206, 23);
            this.overhaulStartDatePicker.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Crew:";
            // 
            // crewGridView
            // 
            this.crewGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.crewGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.memberComboBox});
            this.crewGridView.Location = new System.Drawing.Point(119, 148);
            this.crewGridView.MultiSelect = false;
            this.crewGridView.Name = "crewGridView";
            this.crewGridView.RowTemplate.Height = 25;
            this.crewGridView.Size = new System.Drawing.Size(206, 101);
            this.crewGridView.TabIndex = 11;
            this.crewGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.crewGridView_CellEndEdit);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // memberComboBox
            // 
            this.memberComboBox.HeaderText = "Member";
            this.memberComboBox.Name = "memberComboBox";
            this.memberComboBox.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // applyButton
            // 
            this.applyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.applyButton.Location = new System.Drawing.Point(266, 267);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 1;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // EditShip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 299);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EditShip";
            this.Text = "Edit ship";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carryCapacityNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crewGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox nameTextBox;
        private NumericUpDown carryCapacityNumeric;
        private ComboBox homeportComboBox;
        private ComboBox purposeComboBox;
        private DateTimePicker overhaulStartDatePicker;
        private Button applyButton;
        private Label label6;
        private DataGridView crewGridView;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewComboBoxColumn memberComboBox;
    }
}