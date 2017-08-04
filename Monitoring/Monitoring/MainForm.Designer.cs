namespace Monitoring
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label = new System.Windows.Forms.Label();
            this.viewLogButton = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sensorLabel8 = new System.Windows.Forms.Label();
            this.sensorLabel7 = new System.Windows.Forms.Label();
            this.sensorLabel6 = new System.Windows.Forms.Label();
            this.sensorLabel5 = new System.Windows.Forms.Label();
            this.sensorLabel4 = new System.Windows.Forms.Label();
            this.sensorLabel3 = new System.Windows.Forms.Label();
            this.sensorLabel2 = new System.Windows.Forms.Label();
            this.sensorLabel1 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lastInsLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusString = new System.Windows.Forms.Label();
            this.statusColor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.configButton = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("굴림", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label.Location = new System.Drawing.Point(12, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(101, 48);
            this.label.TabIndex = 1;
            this.label.Text = "IDS";
            // 
            // viewLogButton
            // 
            this.viewLogButton.BackColor = System.Drawing.Color.Transparent;
            this.viewLogButton.FlatAppearance.BorderSize = 0;
            this.viewLogButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewLogButton.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.viewLogButton.Location = new System.Drawing.Point(1197, 15);
            this.viewLogButton.Name = "viewLogButton";
            this.viewLogButton.Size = new System.Drawing.Size(134, 34);
            this.viewLogButton.TabIndex = 2;
            this.viewLogButton.Text = "로그 확인";
            this.viewLogButton.UseVisualStyleBackColor = false;
            this.viewLogButton.Click += new System.EventHandler(this.viewLogButton_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.Control;
            this.panel.Controls.Add(this.panel2);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.lastInsLabel);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.statusString);
            this.panel.Controls.Add(this.statusColor);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.chart);
            this.panel.Location = new System.Drawing.Point(12, 69);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1319, 605);
            this.panel.TabIndex = 3;
            this.panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sensorLabel_MouseDown);
            this.panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.sensorLabel_MouseMove);
            this.panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.sensorLabel_MouseUp);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.sensorLabel8);
            this.panel2.Controls.Add(this.sensorLabel7);
            this.panel2.Controls.Add(this.sensorLabel6);
            this.panel2.Controls.Add(this.sensorLabel5);
            this.panel2.Controls.Add(this.sensorLabel4);
            this.panel2.Controls.Add(this.sensorLabel3);
            this.panel2.Controls.Add(this.sensorLabel2);
            this.panel2.Controls.Add(this.sensorLabel1);
            this.panel2.Controls.Add(this.pictureBox);
            this.panel2.Location = new System.Drawing.Point(8, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(749, 596);
            this.panel2.TabIndex = 11;
            // 
            // sensorLabel8
            // 
            this.sensorLabel8.AutoSize = true;
            this.sensorLabel8.BackColor = System.Drawing.Color.Transparent;
            this.sensorLabel8.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sensorLabel8.Location = new System.Drawing.Point(486, 6);
            this.sensorLabel8.Name = "sensorLabel8";
            this.sensorLabel8.Size = new System.Drawing.Size(63, 19);
            this.sensorLabel8.TabIndex = 17;
            this.sensorLabel8.Text = "센서 8";
            this.sensorLabel8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sensorLabel_MouseDown);
            this.sensorLabel8.MouseMove += new System.Windows.Forms.MouseEventHandler(this.sensorLabel_MouseMove);
            this.sensorLabel8.MouseUp += new System.Windows.Forms.MouseEventHandler(this.sensorLabel_MouseUp);
            // 
            // sensorLabel7
            // 
            this.sensorLabel7.AutoSize = true;
            this.sensorLabel7.BackColor = System.Drawing.Color.Transparent;
            this.sensorLabel7.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sensorLabel7.Location = new System.Drawing.Point(417, 6);
            this.sensorLabel7.Name = "sensorLabel7";
            this.sensorLabel7.Size = new System.Drawing.Size(63, 19);
            this.sensorLabel7.TabIndex = 16;
            this.sensorLabel7.Text = "센서 7";
            this.sensorLabel7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sensorLabel_MouseDown);
            this.sensorLabel7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.sensorLabel_MouseMove);
            this.sensorLabel7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.sensorLabel_MouseUp);
            // 
            // sensorLabel6
            // 
            this.sensorLabel6.AutoSize = true;
            this.sensorLabel6.BackColor = System.Drawing.Color.Transparent;
            this.sensorLabel6.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sensorLabel6.Location = new System.Drawing.Point(348, 6);
            this.sensorLabel6.Name = "sensorLabel6";
            this.sensorLabel6.Size = new System.Drawing.Size(63, 19);
            this.sensorLabel6.TabIndex = 15;
            this.sensorLabel6.Text = "센서 6";
            this.sensorLabel6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sensorLabel_MouseDown);
            this.sensorLabel6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.sensorLabel_MouseMove);
            this.sensorLabel6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.sensorLabel_MouseUp);
            // 
            // sensorLabel5
            // 
            this.sensorLabel5.AutoSize = true;
            this.sensorLabel5.BackColor = System.Drawing.Color.Transparent;
            this.sensorLabel5.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sensorLabel5.Location = new System.Drawing.Point(279, 6);
            this.sensorLabel5.Name = "sensorLabel5";
            this.sensorLabel5.Size = new System.Drawing.Size(63, 19);
            this.sensorLabel5.TabIndex = 14;
            this.sensorLabel5.Text = "센서 5";
            this.sensorLabel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sensorLabel_MouseDown);
            this.sensorLabel5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.sensorLabel_MouseMove);
            this.sensorLabel5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.sensorLabel_MouseUp);
            // 
            // sensorLabel4
            // 
            this.sensorLabel4.AutoSize = true;
            this.sensorLabel4.BackColor = System.Drawing.Color.Transparent;
            this.sensorLabel4.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sensorLabel4.Location = new System.Drawing.Point(210, 6);
            this.sensorLabel4.Name = "sensorLabel4";
            this.sensorLabel4.Size = new System.Drawing.Size(63, 19);
            this.sensorLabel4.TabIndex = 13;
            this.sensorLabel4.Text = "센서 4";
            this.sensorLabel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sensorLabel_MouseDown);
            this.sensorLabel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.sensorLabel_MouseMove);
            this.sensorLabel4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.sensorLabel_MouseUp);
            // 
            // sensorLabel3
            // 
            this.sensorLabel3.AutoSize = true;
            this.sensorLabel3.BackColor = System.Drawing.Color.Transparent;
            this.sensorLabel3.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sensorLabel3.Location = new System.Drawing.Point(141, 6);
            this.sensorLabel3.Name = "sensorLabel3";
            this.sensorLabel3.Size = new System.Drawing.Size(63, 19);
            this.sensorLabel3.TabIndex = 12;
            this.sensorLabel3.Text = "센서 3";
            this.sensorLabel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sensorLabel_MouseDown);
            this.sensorLabel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.sensorLabel_MouseMove);
            this.sensorLabel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.sensorLabel_MouseUp);
            // 
            // sensorLabel2
            // 
            this.sensorLabel2.AutoSize = true;
            this.sensorLabel2.BackColor = System.Drawing.Color.Transparent;
            this.sensorLabel2.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sensorLabel2.Location = new System.Drawing.Point(72, 6);
            this.sensorLabel2.Name = "sensorLabel2";
            this.sensorLabel2.Size = new System.Drawing.Size(63, 19);
            this.sensorLabel2.TabIndex = 11;
            this.sensorLabel2.Text = "센서 2";
            this.sensorLabel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sensorLabel_MouseDown);
            this.sensorLabel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.sensorLabel_MouseMove);
            this.sensorLabel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.sensorLabel_MouseUp);
            // 
            // sensorLabel1
            // 
            this.sensorLabel1.AutoSize = true;
            this.sensorLabel1.BackColor = System.Drawing.Color.Transparent;
            this.sensorLabel1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sensorLabel1.Location = new System.Drawing.Point(3, 6);
            this.sensorLabel1.Name = "sensorLabel1";
            this.sensorLabel1.Size = new System.Drawing.Size(63, 19);
            this.sensorLabel1.TabIndex = 10;
            this.sensorLabel1.Text = "센서 1";
            this.sensorLabel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sensorLabel_MouseDown);
            this.sensorLabel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.sensorLabel_MouseMove);
            this.sensorLabel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.sensorLabel_MouseUp);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(3, 6);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(742, 577);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(783, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "센서별 침입 빈도";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(787, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 12);
            this.label4.TabIndex = 7;
            // 
            // lastInsLabel
            // 
            this.lastInsLabel.AutoSize = true;
            this.lastInsLabel.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lastInsLabel.Location = new System.Drawing.Point(897, 98);
            this.lastInsLabel.Name = "lastInsLabel";
            this.lastInsLabel.Size = new System.Drawing.Size(21, 21);
            this.lastInsLabel.TabIndex = 6;
            this.lastInsLabel.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(783, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "최근 침입:";
            // 
            // statusString
            // 
            this.statusString.AutoSize = true;
            this.statusString.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.statusString.Location = new System.Drawing.Point(885, 30);
            this.statusString.Name = "statusString";
            this.statusString.Size = new System.Drawing.Size(84, 21);
            this.statusString.TabIndex = 4;
            this.statusString.Text = "Peaceful";
            // 
            // statusColor
            // 
            this.statusColor.AutoSize = true;
            this.statusColor.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.statusColor.ForeColor = System.Drawing.Color.LimeGreen;
            this.statusColor.Location = new System.Drawing.Point(848, 30);
            this.statusColor.Name = "statusColor";
            this.statusColor.Size = new System.Drawing.Size(31, 21);
            this.statusColor.TabIndex = 3;
            this.statusColor.Text = "●";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(783, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "상태:";
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            legend1.Title = "센서별 침입 빈도";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(763, 227);
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(544, 362);
            this.chart.TabIndex = 1;
            this.chart.Text = "chart1";
            // 
            // configButton
            // 
            this.configButton.BackColor = System.Drawing.Color.Transparent;
            this.configButton.BackgroundImage = global::Monitoring.Properties.Resources.settings;
            this.configButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.configButton.FlatAppearance.BorderSize = 0;
            this.configButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.configButton.Location = new System.Drawing.Point(119, 17);
            this.configButton.Name = "configButton";
            this.configButton.Size = new System.Drawing.Size(35, 35);
            this.configButton.TabIndex = 0;
            this.configButton.UseVisualStyleBackColor = false;
            this.configButton.Click += new System.EventHandler(this.configButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1343, 686);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.viewLogButton);
            this.Controls.Add(this.label);
            this.Controls.Add(this.configButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button configButton;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button viewLogButton;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lastInsLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label statusString;
        private System.Windows.Forms.Label statusColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sensorLabel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label sensorLabel8;
        private System.Windows.Forms.Label sensorLabel7;
        private System.Windows.Forms.Label sensorLabel6;
        private System.Windows.Forms.Label sensorLabel5;
        private System.Windows.Forms.Label sensorLabel4;
        private System.Windows.Forms.Label sensorLabel3;
        private System.Windows.Forms.Label sensorLabel2;
    }
}