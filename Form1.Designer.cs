namespace ArduinoTemperatureMonitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tempLabelContainer = new System.Windows.Forms.Panel();
            this.temp_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.refresh = new System.Windows.Forms.Button();
            this.baudRate = new System.Windows.Forms.TextBox();
            this.comPorts = new System.Windows.Forms.ComboBox();
            this.startStopButton = new System.Windows.Forms.Button();
            this.tempLabelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tempLabelContainer
            // 
            this.tempLabelContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tempLabelContainer.Controls.Add(this.temp_label);
            this.tempLabelContainer.Location = new System.Drawing.Point(0, 44);
            this.tempLabelContainer.Name = "tempLabelContainer";
            this.tempLabelContainer.Size = new System.Drawing.Size(329, 87);
            this.tempLabelContainer.TabIndex = 15;
            // 
            // temp_label
            // 
            this.temp_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.temp_label.BackColor = System.Drawing.SystemColors.Control;
            this.temp_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.temp_label.Font = new System.Drawing.Font("Unispace", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temp_label.Location = new System.Drawing.Point(0, 0);
            this.temp_label.Name = "temp_label";
            this.temp_label.Size = new System.Drawing.Size(329, 83);
            this.temp_label.TabIndex = 1;
            this.temp_label.Text = "No Data";
            this.temp_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.temp_label.Click += new System.EventHandler(this.TempLabel_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 2);
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
            this.refresh.Location = new System.Drawing.Point(148, 16);
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
            this.baudRate.Location = new System.Drawing.Point(177, 18);
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
            this.comPorts.Size = new System.Drawing.Size(130, 21);
            this.comPorts.TabIndex = 9;
            // 
            // startStopButton
            // 
            this.startStopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startStopButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startStopButton.Location = new System.Drawing.Point(258, 16);
            this.startStopButton.Name = "startStopButton";
            this.startStopButton.Size = new System.Drawing.Size(59, 23);
            this.startStopButton.TabIndex = 12;
            this.startStopButton.Text = "Start";
            this.startStopButton.UseVisualStyleBackColor = true;
            this.startStopButton.Click += new System.EventHandler(this.Start_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 127);
            this.Controls.Add(this.tempLabelContainer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.baudRate);
            this.Controls.Add(this.comPorts);
            this.Controls.Add(this.startStopButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arduino Temperature Monitor";
            this.tempLabelContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel tempLabelContainer;
        private System.Windows.Forms.Label temp_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.TextBox baudRate;
        private System.Windows.Forms.ComboBox comPorts;
        private System.Windows.Forms.Button startStopButton;
    }
}

