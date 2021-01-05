namespace car_application
{
    partial class VechileForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.Vehicleid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RegNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Color = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.Accelerate = new System.Windows.Forms.Button();
            this.Deaccelerate = new System.Windows.Forms.Button();
            this.Speed = new System.Windows.Forms.TextBox();
            this.currentstatus = new System.Windows.Forms.Label();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.cmbMake = new System.Windows.Forms.ComboBox();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "VehicleId";
            // 
            // Vehicleid
            // 
            this.Vehicleid.Location = new System.Drawing.Point(79, 35);
            this.Vehicleid.Name = "Vehicleid";
            this.Vehicleid.Size = new System.Drawing.Size(128, 20);
            this.Vehicleid.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "RegNo.";
            // 
            // RegNo
            // 
            this.RegNo.Location = new System.Drawing.Point(79, 67);
            this.RegNo.Name = "RegNo";
            this.RegNo.Size = new System.Drawing.Size(128, 20);
            this.RegNo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date of Manufacture";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 142);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // Color
            // 
            this.Color.AutoSize = true;
            this.Color.Location = new System.Drawing.Point(9, 195);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(31, 13);
            this.Color.TabIndex = 6;
            this.Color.Text = "Color";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Make";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Model";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Price";
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(79, 337);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(128, 20);
            this.Price.TabIndex = 11;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(261, 72);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(76, 25);
            this.btnCreate.TabIndex = 12;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(358, 72);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(75, 25);
            this.btnGet.TabIndex = 13;
            this.btnGet.Text = "Get";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(474, 72);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 25);
            this.Clear.TabIndex = 14;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(261, 115);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(76, 28);
            this.Start.TabIndex = 15;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(358, 115);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(75, 28);
            this.Stop.TabIndex = 16;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Accelerate
            // 
            this.Accelerate.Location = new System.Drawing.Point(261, 165);
            this.Accelerate.Name = "Accelerate";
            this.Accelerate.Size = new System.Drawing.Size(93, 23);
            this.Accelerate.TabIndex = 17;
            this.Accelerate.Text = "Accelerate";
            this.Accelerate.UseVisualStyleBackColor = true;
            this.Accelerate.Click += new System.EventHandler(this.Accelerate_Click);
            // 
            // Deaccelerate
            // 
            this.Deaccelerate.Location = new System.Drawing.Point(460, 165);
            this.Deaccelerate.Name = "Deaccelerate";
            this.Deaccelerate.Size = new System.Drawing.Size(110, 23);
            this.Deaccelerate.TabIndex = 18;
            this.Deaccelerate.Text = "Deaccelerate";
            this.Deaccelerate.UseVisualStyleBackColor = true;
            this.Deaccelerate.Click += new System.EventHandler(this.Deaccelerate_Click);
            // 
            // Speed
            // 
            this.Speed.Location = new System.Drawing.Point(364, 167);
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(79, 20);
            this.Speed.TabIndex = 19;
            // 
            // currentstatus
            // 
            this.currentstatus.AutoSize = true;
            this.currentstatus.Location = new System.Drawing.Point(275, 217);
            this.currentstatus.Name = "currentstatus";
            this.currentstatus.Size = new System.Drawing.Size(126, 13);
            this.currentstatus.TabIndex = 20;
            this.currentstatus.Text = "Current Status Of Vehicle";
            // 
            // cmbModel
            // 
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(79, 288);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(128, 21);
            this.cmbModel.TabIndex = 22;
            // 
            // cmbMake
            // 
            this.cmbMake.FormattingEnabled = true;
            this.cmbMake.Location = new System.Drawing.Point(79, 234);
            this.cmbMake.Name = "cmbMake";
            this.cmbMake.Size = new System.Drawing.Size(128, 21);
            this.cmbMake.TabIndex = 21;
            // 
            // cmbColor
            // 
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(79, 192);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(128, 21);
            this.cmbColor.TabIndex = 23;
            // 
            // VechileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 388);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.cmbModel);
            this.Controls.Add(this.cmbMake);
            this.Controls.Add(this.currentstatus);
            this.Controls.Add(this.Speed);
            this.Controls.Add(this.Deaccelerate);
            this.Controls.Add(this.Accelerate);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Color);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RegNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Vehicleid);
            this.Controls.Add(this.label1);
            this.Name = "VechileForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Vehicleid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RegNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label Color;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Accelerate;
        private System.Windows.Forms.Button Deaccelerate;
        private System.Windows.Forms.TextBox Speed;
        private System.Windows.Forms.Label currentstatus;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.ComboBox cmbMake;
        private System.Windows.Forms.ComboBox cmbColor;
    }
}

