namespace rpbd2.GUI
{
    partial class EditCruise
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
            this.label6 = new System.Windows.Forms.Label();
            this.shipComboBox = new System.Windows.Forms.ComboBox();
            this.generalCargoTypeComboBox = new System.Windows.Forms.ComboBox();
            this.departurePortComboBox = new System.Windows.Forms.ComboBox();
            this.destinationPortComboBox = new System.Windows.Forms.ComboBox();
            this.chartererComboBox = new System.Windows.Forms.ComboBox();
            this.portEntriesGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addPortEntryButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portEntriesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.shipComboBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.generalCargoTypeComboBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.departurePortComboBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.destinationPortComboBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.chartererComboBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.portEntriesGridView, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(439, 289);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ship:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "General cargo type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Departure port:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Destination port:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Charterer:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Port entries:";
            // 
            // shipComboBox
            // 
            this.shipComboBox.FormattingEnabled = true;
            this.shipComboBox.Location = new System.Drawing.Point(118, 3);
            this.shipComboBox.Name = "shipComboBox";
            this.shipComboBox.Size = new System.Drawing.Size(312, 23);
            this.shipComboBox.TabIndex = 6;
            // 
            // generalCargoTypeComboBox
            // 
            this.generalCargoTypeComboBox.FormattingEnabled = true;
            this.generalCargoTypeComboBox.Location = new System.Drawing.Point(118, 32);
            this.generalCargoTypeComboBox.Name = "generalCargoTypeComboBox";
            this.generalCargoTypeComboBox.Size = new System.Drawing.Size(312, 23);
            this.generalCargoTypeComboBox.TabIndex = 7;
            // 
            // departurePortComboBox
            // 
            this.departurePortComboBox.FormattingEnabled = true;
            this.departurePortComboBox.Location = new System.Drawing.Point(118, 61);
            this.departurePortComboBox.Name = "departurePortComboBox";
            this.departurePortComboBox.Size = new System.Drawing.Size(312, 23);
            this.departurePortComboBox.TabIndex = 8;
            // 
            // destinationPortComboBox
            // 
            this.destinationPortComboBox.FormattingEnabled = true;
            this.destinationPortComboBox.Location = new System.Drawing.Point(118, 90);
            this.destinationPortComboBox.Name = "destinationPortComboBox";
            this.destinationPortComboBox.Size = new System.Drawing.Size(312, 23);
            this.destinationPortComboBox.TabIndex = 9;
            // 
            // chartererComboBox
            // 
            this.chartererComboBox.FormattingEnabled = true;
            this.chartererComboBox.Location = new System.Drawing.Point(118, 119);
            this.chartererComboBox.Name = "chartererComboBox";
            this.chartererComboBox.Size = new System.Drawing.Size(312, 23);
            this.chartererComboBox.TabIndex = 10;
            // 
            // portEntriesGridView
            // 
            this.portEntriesGridView.AllowUserToAddRows = false;
            this.portEntriesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.portEntriesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.portEntriesGridView.Location = new System.Drawing.Point(118, 148);
            this.portEntriesGridView.MultiSelect = false;
            this.portEntriesGridView.Name = "portEntriesGridView";
            this.portEntriesGridView.ReadOnly = true;
            this.portEntriesGridView.RowTemplate.Height = 25;
            this.portEntriesGridView.Size = new System.Drawing.Size(312, 135);
            this.portEntriesGridView.TabIndex = 11;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Port";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Destination";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Departure";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // addPortEntryButton
            // 
            this.addPortEntryButton.Location = new System.Drawing.Point(318, 307);
            this.addPortEntryButton.Name = "addPortEntryButton";
            this.addPortEntryButton.Size = new System.Drawing.Size(124, 23);
            this.addPortEntryButton.TabIndex = 1;
            this.addPortEntryButton.Text = "Add port entry...";
            this.addPortEntryButton.UseVisualStyleBackColor = true;
            this.addPortEntryButton.Click += new System.EventHandler(this.addPortEntryButton_Click);
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(367, 336);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 2;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // EditCruise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 369);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.addPortEntryButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EditCruise";
            this.Text = "EditCruise";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portEntriesGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox shipComboBox;
        private ComboBox generalCargoTypeComboBox;
        private ComboBox departurePortComboBox;
        private ComboBox destinationPortComboBox;
        private ComboBox chartererComboBox;
        public DataGridView portEntriesGridView;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Button addPortEntryButton;
        private Button applyButton;
    }
}