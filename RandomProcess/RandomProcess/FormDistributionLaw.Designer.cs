namespace RandomProcess
{
    partial class FormDistributionLaw
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
            this.labelDistributionLaw = new System.Windows.Forms.Label();
            this.labelOption = new System.Windows.Forms.Label();
            this.labelOption1 = new System.Windows.Forms.Label();
            this.labelOption2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBoxOption1 = new System.Windows.Forms.TextBox();
            this.textBoxOption2 = new System.Windows.Forms.TextBox();
            this.buttonNext = new System.Windows.Forms.Button();
            this.comboBoxChoiceLawDistribution = new System.Windows.Forms.ComboBox();
            this.buttonAgo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDistributionLaw
            // 
            this.labelDistributionLaw.AutoSize = true;
            this.labelDistributionLaw.Location = new System.Drawing.Point(16, 21);
            this.labelDistributionLaw.Name = "labelDistributionLaw";
            this.labelDistributionLaw.Size = new System.Drawing.Size(159, 17);
            this.labelDistributionLaw.TabIndex = 0;
            this.labelDistributionLaw.Text = "Закон распределения:";
            this.labelDistributionLaw.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelOption
            // 
            this.labelOption.AutoSize = true;
            this.labelOption.Location = new System.Drawing.Point(16, 92);
            this.labelOption.Name = "labelOption";
            this.labelOption.Size = new System.Drawing.Size(88, 17);
            this.labelOption.TabIndex = 1;
            this.labelOption.Text = "Параметры:";
            // 
            // labelOption1
            // 
            this.labelOption1.AutoSize = true;
            this.labelOption1.Location = new System.Drawing.Point(16, 145);
            this.labelOption1.Name = "labelOption1";
            this.labelOption1.Size = new System.Drawing.Size(86, 17);
            this.labelOption1.TabIndex = 2;
            this.labelOption1.Text = "Параметр1:";
            // 
            // labelOption2
            // 
            this.labelOption2.AutoSize = true;
            this.labelOption2.Location = new System.Drawing.Point(16, 182);
            this.labelOption2.Name = "labelOption2";
            this.labelOption2.Size = new System.Drawing.Size(86, 17);
            this.labelOption2.TabIndex = 3;
            this.labelOption2.Text = "Параметр2:";
            // 
            // textBoxOption1
            // 
            this.textBoxOption1.Location = new System.Drawing.Point(125, 142);
            this.textBoxOption1.Name = "textBoxOption1";
            this.textBoxOption1.Size = new System.Drawing.Size(100, 22);
            this.textBoxOption1.TabIndex = 4;
            // 
            // textBoxOption2
            // 
            this.textBoxOption2.Location = new System.Drawing.Point(125, 182);
            this.textBoxOption2.Name = "textBoxOption2";
            this.textBoxOption2.Size = new System.Drawing.Size(100, 22);
            this.textBoxOption2.TabIndex = 5;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(177, 227);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(115, 36);
            this.buttonNext.TabIndex = 6;
            this.buttonNext.Text = "Далее";
            this.buttonNext.UseVisualStyleBackColor = true;
            // 
            // comboBoxChoiceLawDistribution
            // 
            this.comboBoxChoiceLawDistribution.FormattingEnabled = true;
            this.comboBoxChoiceLawDistribution.Location = new System.Drawing.Point(19, 50);
            this.comboBoxChoiceLawDistribution.Name = "comboBoxChoiceLawDistribution";
            this.comboBoxChoiceLawDistribution.Size = new System.Drawing.Size(121, 24);
            this.comboBoxChoiceLawDistribution.TabIndex = 7;
            // 
            // buttonAgo
            // 
            this.buttonAgo.Location = new System.Drawing.Point(25, 227);
            this.buttonAgo.Name = "buttonAgo";
            this.buttonAgo.Size = new System.Drawing.Size(115, 36);
            this.buttonAgo.TabIndex = 8;
            this.buttonAgo.Text = "Назад";
            this.buttonAgo.UseVisualStyleBackColor = true;
            // 
            // FormDistributionLaw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 275);
            this.Controls.Add(this.buttonAgo);
            this.Controls.Add(this.comboBoxChoiceLawDistribution);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.textBoxOption2);
            this.Controls.Add(this.textBoxOption1);
            this.Controls.Add(this.labelOption2);
            this.Controls.Add(this.labelOption1);
            this.Controls.Add(this.labelOption);
            this.Controls.Add(this.labelDistributionLaw);
            this.Name = "FormDistributionLaw";
            this.Text = "Закон распределения";
            this.Load += new System.EventHandler(this.FormDistributionLaw_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDistributionLaw;
        private System.Windows.Forms.Label labelOption;
        private System.Windows.Forms.Label labelOption1;
        private System.Windows.Forms.Label labelOption2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBoxOption1;
        private System.Windows.Forms.TextBox textBoxOption2;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.ComboBox comboBoxChoiceLawDistribution;
        private System.Windows.Forms.Button buttonAgo;
    }
}