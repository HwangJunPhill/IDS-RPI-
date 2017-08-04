namespace Monitoring
{
    partial class ViewLogForm
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
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.logListView = new System.Windows.Forms.ListView();
            this.센서 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.시간 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.lookupButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox
            // 
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "모든 센서",
            "1번 센서",
            "2번 센서",
            "3번 센서",
            "4번 센서",
            "5번 센서",
            "6번 센서",
            "7번 센서",
            "8번 센서"});
            this.comboBox.Location = new System.Drawing.Point(12, 59);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(217, 20);
            this.comboBox.TabIndex = 0;
            // 
            // logListView
            // 
            this.logListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.센서,
            this.시간,
            this.columnHeader3});
            this.logListView.Location = new System.Drawing.Point(12, 122);
            this.logListView.Name = "logListView";
            this.logListView.Size = new System.Drawing.Size(487, 451);
            this.logListView.TabIndex = 2;
            this.logListView.UseCompatibleStateImageBehavior = false;
            this.logListView.View = System.Windows.Forms.View.Details;
            // 
            // 센서
            // 
            this.센서.Text = "센서";
            this.센서.Width = 100;
            // 
            // 시간
            // 
            this.시간.Text = "시간";
            this.시간.Width = 300;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "침입 여부";
            this.columnHeader3.Width = 80;
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(247, 62);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(116, 16);
            this.checkBox.TabIndex = 3;
            this.checkBox.Text = "침입 기록만 확인";
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // lookupButton
            // 
            this.lookupButton.BackColor = System.Drawing.Color.Transparent;
            this.lookupButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.lookupButton.FlatAppearance.BorderSize = 0;
            this.lookupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lookupButton.Location = new System.Drawing.Point(369, 49);
            this.lookupButton.Name = "lookupButton";
            this.lookupButton.Size = new System.Drawing.Size(130, 39);
            this.lookupButton.TabIndex = 4;
            this.lookupButton.Text = "조회";
            this.lookupButton.UseVisualStyleBackColor = false;
            this.lookupButton.Click += new System.EventHandler(this.lookupButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "필터 옵션 :";
            // 
            // ViewLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(511, 585);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lookupButton);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.logListView);
            this.Controls.Add(this.comboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewLogForm";
            this.Text = "로그 확인";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.ListView logListView;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Button lookupButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader 센서;
        private System.Windows.Forms.ColumnHeader 시간;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}