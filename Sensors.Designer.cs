namespace ArduinoTemperatureMonitor
{
    partial class Sensors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sensors));
            this.tempLabelContainer = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.volt_A5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.temp_A2 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.volt_A4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.temp_A1 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.volt_A3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.temp_A0 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.refresh = new System.Windows.Forms.Button();
            this.baudRate = new System.Windows.Forms.TextBox();
            this.comPorts = new System.Windows.Forms.ComboBox();
            this.startStopButton = new System.Windows.Forms.Button();
            this.tempLabelContainer.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tempLabelContainer
            // 
            this.tempLabelContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tempLabelContainer.Controls.Add(this.groupBox4);
            this.tempLabelContainer.Controls.Add(this.groupBox3);
            this.tempLabelContainer.Controls.Add(this.groupBox5);
            this.tempLabelContainer.Controls.Add(this.groupBox2);
            this.tempLabelContainer.Controls.Add(this.groupBox6);
            this.tempLabelContainer.Controls.Add(this.groupBox1);
            this.tempLabelContainer.Location = new System.Drawing.Point(0, 44);
            this.tempLabelContainer.Name = "tempLabelContainer";
            this.tempLabelContainer.Size = new System.Drawing.Size(619, 215);
            this.tempLabelContainer.TabIndex = 15;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox4.Controls.Add(this.volt_A5);
            this.groupBox4.Location = new System.Drawing.Point(415, 109);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Voltage A5";
            // 
            // volt_A5
            // 
            this.volt_A5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.volt_A5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.volt_A5.Font = new System.Drawing.Font("Unispace", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volt_A5.Location = new System.Drawing.Point(9, 16);
            this.volt_A5.Name = "volt_A5";
            this.volt_A5.Size = new System.Drawing.Size(185, 77);
            this.volt_A5.TabIndex = 1;
            this.volt_A5.Tag = "5";
            this.volt_A5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.volt_A5.Click += new System.EventHandler(this.SensorLabel_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.temp_A2);
            this.groupBox3.Location = new System.Drawing.Point(415, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Temperature A2";
            // 
            // temp_A2
            // 
            this.temp_A2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.temp_A2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.temp_A2.Font = new System.Drawing.Font("Unispace", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temp_A2.Location = new System.Drawing.Point(9, 16);
            this.temp_A2.Name = "temp_A2";
            this.temp_A2.Size = new System.Drawing.Size(185, 77);
            this.temp_A2.TabIndex = 1;
            this.temp_A2.Tag = "2";
            this.temp_A2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.temp_A2.Click += new System.EventHandler(this.SensorLabel_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox5.Controls.Add(this.volt_A4);
            this.groupBox5.Location = new System.Drawing.Point(209, 109);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 100);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Voltage A4";
            // 
            // volt_A4
            // 
            this.volt_A4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.volt_A4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.volt_A4.Font = new System.Drawing.Font("Unispace", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volt_A4.Location = new System.Drawing.Point(9, 16);
            this.volt_A4.Name = "volt_A4";
            this.volt_A4.Size = new System.Drawing.Size(185, 77);
            this.volt_A4.TabIndex = 1;
            this.volt_A4.Tag = "4";
            this.volt_A4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.volt_A4.Click += new System.EventHandler(this.SensorLabel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.temp_A1);
            this.groupBox2.Location = new System.Drawing.Point(209, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Temperature A1";
            // 
            // temp_A1
            // 
            this.temp_A1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.temp_A1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.temp_A1.Font = new System.Drawing.Font("Unispace", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temp_A1.Location = new System.Drawing.Point(9, 16);
            this.temp_A1.Name = "temp_A1";
            this.temp_A1.Size = new System.Drawing.Size(185, 77);
            this.temp_A1.TabIndex = 1;
            this.temp_A1.Tag = "1";
            this.temp_A1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.temp_A1.Click += new System.EventHandler(this.SensorLabel_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox6.Controls.Add(this.volt_A3);
            this.groupBox6.Location = new System.Drawing.Point(3, 109);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 100);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Voltage A3";
            // 
            // volt_A3
            // 
            this.volt_A3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.volt_A3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.volt_A3.Font = new System.Drawing.Font("Unispace", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volt_A3.Location = new System.Drawing.Point(9, 16);
            this.volt_A3.Name = "volt_A3";
            this.volt_A3.Size = new System.Drawing.Size(185, 77);
            this.volt_A3.TabIndex = 0;
            this.volt_A3.Tag = "3";
            this.volt_A3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.volt_A3.Click += new System.EventHandler(this.SensorLabel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.temp_A0);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Temperature A0";
            // 
            // temp_A0
            // 
            this.temp_A0.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.temp_A0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.temp_A0.Font = new System.Drawing.Font("Unispace", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temp_A0.Location = new System.Drawing.Point(9, 16);
            this.temp_A0.Name = "temp_A0";
            this.temp_A0.Size = new System.Drawing.Size(185, 77);
            this.temp_A0.TabIndex = 0;
            this.temp_A0.Tag = "0";
            this.temp_A0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.temp_A0.Click += new System.EventHandler(this.SensorLabel_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(464, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Baud Rate:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "COM Port:";
            // 
            // refresh
            // 
            this.refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refresh.Font = new System.Drawing.Font("Wingdings 3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.refresh.Location = new System.Drawing.Point(438, 16);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(23, 23);
            this.refresh.TabIndex = 10;
            this.refresh.Text = "Q";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // baudRate
            // 
            this.baudRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.baudRate.Location = new System.Drawing.Point(467, 18);
            this.baudRate.Name = "baudRate";
            this.baudRate.Size = new System.Drawing.Size(75, 20);
            this.baudRate.TabIndex = 11;
            this.baudRate.Text = "9600";
            this.baudRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comPorts
            // 
            this.comPorts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comPorts.FormattingEnabled = true;
            this.comPorts.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comPorts.Location = new System.Drawing.Point(12, 18);
            this.comPorts.Name = "comPorts";
            this.comPorts.Size = new System.Drawing.Size(420, 21);
            this.comPorts.TabIndex = 9;
            // 
            // startStopButton
            // 
            this.startStopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startStopButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startStopButton.Location = new System.Drawing.Point(548, 16);
            this.startStopButton.Name = "startStopButton";
            this.startStopButton.Size = new System.Drawing.Size(59, 23);
            this.startStopButton.TabIndex = 12;
            this.startStopButton.Text = "Start";
            this.startStopButton.UseVisualStyleBackColor = true;
            this.startStopButton.Click += new System.EventHandler(this.Start_click);
            // 
            // Sensors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 255);
            this.Controls.Add(this.tempLabelContainer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.baudRate);
            this.Controls.Add(this.comPorts);
            this.Controls.Add(this.startStopButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(635, 294);
            this.MinimumSize = new System.Drawing.Size(635, 294);
            this.Name = "Sensors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arduino Sensors";
            this.tempLabelContainer.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel tempLabelContainer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.TextBox baudRate;
        private System.Windows.Forms.ComboBox comPorts;
        private System.Windows.Forms.Button startStopButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label volt_A5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label temp_A2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label volt_A4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label temp_A1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label volt_A3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label temp_A0;
    }
}

