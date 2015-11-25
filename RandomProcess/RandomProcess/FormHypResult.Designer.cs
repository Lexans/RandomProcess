namespace RandomProcess
{
    partial class FormHypResult
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
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelValueStatistics = new System.Windows.Forms.Label();
            this.labelCriticalRegion = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.textBoxStat = new System.Windows.Forms.TextBox();
            this.textBoxCritPoint = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(133, 155);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(83, 35);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelValueStatistics
            // 
            this.labelValueStatistics.AutoSize = true;
            this.labelValueStatistics.Location = new System.Drawing.Point(16, 24);
            this.labelValueStatistics.Name = "labelValueStatistics";
            this.labelValueStatistics.Size = new System.Drawing.Size(151, 34);
            this.labelValueStatistics.TabIndex = 1;
            this.labelValueStatistics.Text = "Значение статистики\r\nкритерия:";
            // 
            // labelCriticalRegion
            // 
            this.labelCriticalRegion.AutoSize = true;
            this.labelCriticalRegion.Location = new System.Drawing.Point(16, 77);
            this.labelCriticalRegion.Name = "labelCriticalRegion";
            this.labelCriticalRegion.Size = new System.Drawing.Size(140, 17);
            this.labelCriticalRegion.TabIndex = 3;
            this.labelCriticalRegion.Text = "Критическая точка:";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(130, 119);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(86, 17);
            this.labelResult.TabIndex = 4;
            this.labelResult.Text = "\"Результат\"";
            // 
            // textBoxStat
            // 
            this.textBoxStat.Location = new System.Drawing.Point(197, 24);
            this.textBoxStat.Name = "textBoxStat";
            this.textBoxStat.ReadOnly = true;
            this.textBoxStat.Size = new System.Drawing.Size(131, 22);
            this.textBoxStat.TabIndex = 5;
            // 
            // textBoxCritPoint
            // 
            this.textBoxCritPoint.Location = new System.Drawing.Point(197, 77);
            this.textBoxCritPoint.Name = "textBoxCritPoint";
            this.textBoxCritPoint.ReadOnly = true;
            this.textBoxCritPoint.Size = new System.Drawing.Size(131, 22);
            this.textBoxCritPoint.TabIndex = 7;
            // 
            // FormCheckResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 212);
            this.Controls.Add(this.textBoxCritPoint);
            this.Controls.Add(this.textBoxStat);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelCriticalRegion);
            this.Controls.Add(this.labelValueStatistics);
            this.Controls.Add(this.buttonOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCheckResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Результат проверки гипотезы";
            this.Load += new System.EventHandler(this.FormCheckResult_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelValueStatistics;
        private System.Windows.Forms.Label labelCriticalRegion;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox textBoxStat;
        private System.Windows.Forms.TextBox textBoxCritPoint;
    }
}