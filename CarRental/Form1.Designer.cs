namespace CarRental
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
            this.AddVehicleLabel = new System.Windows.Forms.Label();
            this.VehicleTypeLabel = new System.Windows.Forms.Label();
            this.VehicleTypeSelect = new System.Windows.Forms.ComboBox();
            this.DistanceLabel = new System.Windows.Forms.Label();
            this.DistanceInput = new System.Windows.Forms.NumericUpDown();
            this.FuelLabel = new System.Windows.Forms.Label();
            this.EuroLabel = new System.Windows.Forms.Label();
            this.FuelInput = new System.Windows.Forms.NumericUpDown();
            this.StartDateLabel = new System.Windows.Forms.Label();
            this.StartDateInput = new System.Windows.Forms.DateTimePicker();
            this.EndDateInput = new System.Windows.Forms.DateTimePicker();
            this.EndDateLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.VehicleOverview = new System.Windows.Forms.DataGridView();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.End = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.CostLabel = new System.Windows.Forms.Label();
            this.CostOverview = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DistanceInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FuelInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VehicleOverview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostOverview)).BeginInit();
            this.SuspendLayout();
            // 
            // AddVehicleLabel
            // 
            this.AddVehicleLabel.AutoSize = true;
            this.AddVehicleLabel.Location = new System.Drawing.Point(12, 9);
            this.AddVehicleLabel.Name = "AddVehicleLabel";
            this.AddVehicleLabel.Size = new System.Drawing.Size(66, 13);
            this.AddVehicleLabel.TabIndex = 0;
            this.AddVehicleLabel.Text = "Add vehicle:";
            // 
            // VehicleTypeLabel
            // 
            this.VehicleTypeLabel.AutoSize = true;
            this.VehicleTypeLabel.Location = new System.Drawing.Point(12, 31);
            this.VehicleTypeLabel.Name = "VehicleTypeLabel";
            this.VehicleTypeLabel.Size = new System.Drawing.Size(68, 13);
            this.VehicleTypeLabel.TabIndex = 1;
            this.VehicleTypeLabel.Text = "Vehicle type:";
            // 
            // VehicleTypeSelect
            // 
            this.VehicleTypeSelect.FormattingEnabled = true;
            this.VehicleTypeSelect.Location = new System.Drawing.Point(15, 48);
            this.VehicleTypeSelect.Name = "VehicleTypeSelect";
            this.VehicleTypeSelect.Size = new System.Drawing.Size(340, 21);
            this.VehicleTypeSelect.TabIndex = 2;
            // 
            // DistanceLabel
            // 
            this.DistanceLabel.AutoSize = true;
            this.DistanceLabel.Location = new System.Drawing.Point(12, 72);
            this.DistanceLabel.Name = "DistanceLabel";
            this.DistanceLabel.Size = new System.Drawing.Size(95, 13);
            this.DistanceLabel.TabIndex = 3;
            this.DistanceLabel.Text = "Distance travelled:";
            // 
            // DistanceInput
            // 
            this.DistanceInput.Location = new System.Drawing.Point(15, 88);
            this.DistanceInput.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.DistanceInput.Name = "DistanceInput";
            this.DistanceInput.Size = new System.Drawing.Size(340, 20);
            this.DistanceInput.TabIndex = 4;
            // 
            // FuelLabel
            // 
            this.FuelLabel.AutoSize = true;
            this.FuelLabel.Location = new System.Drawing.Point(12, 111);
            this.FuelLabel.Name = "FuelLabel";
            this.FuelLabel.Size = new System.Drawing.Size(78, 13);
            this.FuelLabel.TabIndex = 5;
            this.FuelLabel.Text = "Fuel expenses:";
            // 
            // EuroLabel
            // 
            this.EuroLabel.AutoSize = true;
            this.EuroLabel.Location = new System.Drawing.Point(12, 129);
            this.EuroLabel.Name = "EuroLabel";
            this.EuroLabel.Size = new System.Drawing.Size(13, 13);
            this.EuroLabel.TabIndex = 6;
            this.EuroLabel.Text = "€";
            // 
            // FuelInput
            // 
            this.FuelInput.DecimalPlaces = 2;
            this.FuelInput.Location = new System.Drawing.Point(31, 127);
            this.FuelInput.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.FuelInput.Name = "FuelInput";
            this.FuelInput.Size = new System.Drawing.Size(324, 20);
            this.FuelInput.TabIndex = 7;
            // 
            // StartDateLabel
            // 
            this.StartDateLabel.AutoSize = true;
            this.StartDateLabel.Location = new System.Drawing.Point(12, 150);
            this.StartDateLabel.Name = "StartDateLabel";
            this.StartDateLabel.Size = new System.Drawing.Size(88, 13);
            this.StartDateLabel.TabIndex = 8;
            this.StartDateLabel.Text = "Rental start date:";
            // 
            // StartDateInput
            // 
            this.StartDateInput.CustomFormat = "yyyy-MM-dd";
            this.StartDateInput.Location = new System.Drawing.Point(15, 166);
            this.StartDateInput.Name = "StartDateInput";
            this.StartDateInput.Size = new System.Drawing.Size(340, 20);
            this.StartDateInput.TabIndex = 9;
            // 
            // EndDateInput
            // 
            this.EndDateInput.CustomFormat = "yyyy-MM-dd";
            this.EndDateInput.Location = new System.Drawing.Point(15, 205);
            this.EndDateInput.Name = "EndDateInput";
            this.EndDateInput.Size = new System.Drawing.Size(340, 20);
            this.EndDateInput.TabIndex = 11;
            // 
            // EndDateLabel
            // 
            this.EndDateLabel.AutoSize = true;
            this.EndDateLabel.Location = new System.Drawing.Point(12, 189);
            this.EndDateLabel.Name = "EndDateLabel";
            this.EndDateLabel.Size = new System.Drawing.Size(86, 13);
            this.EndDateLabel.TabIndex = 10;
            this.EndDateLabel.Text = "Rental end date:";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(12, 231);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 13;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // VehicleOverview
            // 
            this.VehicleOverview.AllowUserToAddRows = false;
            this.VehicleOverview.AllowUserToDeleteRows = false;
            this.VehicleOverview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VehicleOverview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type,
            this.Start,
            this.End});
            this.VehicleOverview.Location = new System.Drawing.Point(12, 260);
            this.VehicleOverview.Name = "VehicleOverview";
            this.VehicleOverview.ReadOnly = true;
            this.VehicleOverview.Size = new System.Drawing.Size(343, 150);
            this.VehicleOverview.TabIndex = 14;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Start
            // 
            this.Start.HeaderText = "Start";
            this.Start.Name = "Start";
            this.Start.ReadOnly = true;
            // 
            // End
            // 
            this.End.HeaderText = "End";
            this.End.Name = "End";
            this.End.ReadOnly = true;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(12, 416);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveButton.TabIndex = 15;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(374, 9);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(36, 13);
            this.CostLabel.TabIndex = 16;
            this.CostLabel.Text = "Costs:";
            // 
            // CostOverview
            // 
            this.CostOverview.AllowUserToAddRows = false;
            this.CostOverview.AllowUserToDeleteRows = false;
            this.CostOverview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CostOverview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.CostOverview.Location = new System.Drawing.Point(377, 26);
            this.CostOverview.Name = "CostOverview";
            this.CostOverview.ReadOnly = true;
            this.CostOverview.Size = new System.Drawing.Size(243, 384);
            this.CostOverview.TabIndex = 17;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.CostOverview);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.VehicleOverview);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.EndDateInput);
            this.Controls.Add(this.EndDateLabel);
            this.Controls.Add(this.StartDateInput);
            this.Controls.Add(this.StartDateLabel);
            this.Controls.Add(this.FuelInput);
            this.Controls.Add(this.EuroLabel);
            this.Controls.Add(this.FuelLabel);
            this.Controls.Add(this.DistanceInput);
            this.Controls.Add(this.DistanceLabel);
            this.Controls.Add(this.VehicleTypeSelect);
            this.Controls.Add(this.VehicleTypeLabel);
            this.Controls.Add(this.AddVehicleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DistanceInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FuelInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VehicleOverview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostOverview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddVehicleLabel;
        private System.Windows.Forms.Label VehicleTypeLabel;
        private System.Windows.Forms.ComboBox VehicleTypeSelect;
        private System.Windows.Forms.Label DistanceLabel;
        private System.Windows.Forms.NumericUpDown DistanceInput;
        private System.Windows.Forms.Label FuelLabel;
        private System.Windows.Forms.Label EuroLabel;
        private System.Windows.Forms.NumericUpDown FuelInput;
        private System.Windows.Forms.Label StartDateLabel;
        private System.Windows.Forms.DateTimePicker StartDateInput;
        private System.Windows.Forms.DateTimePicker EndDateInput;
        private System.Windows.Forms.Label EndDateLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridView VehicleOverview;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Start;
        private System.Windows.Forms.DataGridViewTextBoxColumn End;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.DataGridView CostOverview;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

