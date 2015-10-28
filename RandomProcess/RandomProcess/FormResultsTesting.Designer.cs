namespace RandomProcess
{
    partial class FormResultsTesting
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
            this.labelCriterion = new System.Windows.Forms.Label();
            this.labelCriticalRegion = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(184, 160);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(83, 35);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // labelValueStatistics
            // 
            this.labelValueStatistics.AutoSize = true;
            this.labelValueStatistics.Location = new System.Drawing.Point(8, 32);
            this.labelValueStatistics.Name = "labelValueStatistics";
            this.labelValueStatistics.Size = new System.Drawing.Size(151, 17);
            this.labelValueStatistics.TabIndex = 1;
            this.labelValueStatistics.Text = "Значение статистики";
            // 
            // labelCriterion
            // 
            this.labelCriterion.AutoSize = true;
            this.labelCriterion.Location = new System.Drawing.Point(8, 69);
            this.labelCriterion.Name = "labelCriterion";
            this.labelCriterion.Size = new System.Drawing.Size(76, 17);
            this.labelCriterion.TabIndex = 2;
            this.labelCriterion.Text = "Критерий:";
            // 
            // labelCriticalRegion
            // 
            this.labelCriticalRegion.AutoSize = true;
            this.labelCriticalRegion.Location = new System.Drawing.Point(8, 99);
            this.labelCriticalRegion.Name = "labelCriticalRegion";
            this.labelCriticalRegion.Size = new System.Drawing.Size(155, 17);
            this.labelCriticalRegion.TabIndex = 3;
            this.labelCriticalRegion.Text = "Критическая область:";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(181, 127);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(86, 17);
            this.labelResult.TabIndex = 4;
            this.labelResult.Text = "\"Результат\"";
            // 
            // FormResultsTesting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 212);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelCriticalRegion);
            this.Controls.Add(this.labelCriterion);
            this.Controls.Add(this.labelValueStatistics);
            this.Controls.Add(this.buttonOK);
            this.Name = "FormResultsTesting";
            this.Text = "Результат проверки гипотезы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelValueStatistics;
        private System.Windows.Forms.Label labelCriterion;
        private System.Windows.Forms.Label labelCriticalRegion;
        private System.Windows.Forms.Label labelResult;
    }
}