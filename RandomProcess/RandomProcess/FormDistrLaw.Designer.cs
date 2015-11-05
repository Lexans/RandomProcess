namespace RandomProcess
{
    partial class FormDistrLaw
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
            this.labelParam1 = new System.Windows.Forms.Label();
            this.labelParam2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonNext = new System.Windows.Forms.Button();
            this.comboBoxChoiceLawDistribution = new System.Windows.Forms.ComboBox();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.numericUpDownParam1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownParam2 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownParam1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownParam2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDistributionLaw
            // 
            this.labelDistributionLaw.AutoSize = true;
            this.labelDistributionLaw.Location = new System.Drawing.Point(20, 25);
            this.labelDistributionLaw.Name = "labelDistributionLaw";
            this.labelDistributionLaw.Size = new System.Drawing.Size(159, 17);
            this.labelDistributionLaw.TabIndex = 0;
            this.labelDistributionLaw.Text = "Закон распределения:";
            // 
            // labelParam1
            // 
            this.labelParam1.AutoSize = true;
            this.labelParam1.Location = new System.Drawing.Point(8, 30);
            this.labelParam1.Name = "labelParam1";
            this.labelParam1.Size = new System.Drawing.Size(30, 17);
            this.labelParam1.TabIndex = 2;
            this.labelParam1.Text = "П1:";
            // 
            // labelParam2
            // 
            this.labelParam2.AutoSize = true;
            this.labelParam2.Location = new System.Drawing.Point(6, 67);
            this.labelParam2.Name = "labelParam2";
            this.labelParam2.Size = new System.Drawing.Size(30, 17);
            this.labelParam2.TabIndex = 3;
            this.labelParam2.Text = "П2:";
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNext.Location = new System.Drawing.Point(224, 221);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(123, 36);
            this.buttonNext.TabIndex = 6;
            this.buttonNext.Text = "Далее";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // comboBoxChoiceLawDistribution
            // 
            this.comboBoxChoiceLawDistribution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChoiceLawDistribution.FormattingEnabled = true;
            this.comboBoxChoiceLawDistribution.Items.AddRange(new object[] {
            "Равномерный",
            "Нормальный",
            "Экспоненциальный"});
            this.comboBoxChoiceLawDistribution.Location = new System.Drawing.Point(34, 59);
            this.comboBoxChoiceLawDistribution.Name = "comboBoxChoiceLawDistribution";
            this.comboBoxChoiceLawDistribution.Size = new System.Drawing.Size(228, 24);
            this.comboBoxChoiceLawDistribution.TabIndex = 7;
            this.comboBoxChoiceLawDistribution.SelectedIndexChanged += new System.EventHandler(this.comboBoxChoiceLawDistribution_SelectedIndexChanged);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonPrev.Location = new System.Drawing.Point(23, 221);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(115, 36);
            this.buttonPrev.TabIndex = 8;
            this.buttonPrev.Text = "Назад";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // numericUpDownParam1
            // 
            this.numericUpDownParam1.DecimalPlaces = 2;
            this.numericUpDownParam1.Location = new System.Drawing.Point(44, 30);
            this.numericUpDownParam1.Name = "numericUpDownParam1";
            this.numericUpDownParam1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownParam1.TabIndex = 9;
            this.numericUpDownParam1.ValueChanged += new System.EventHandler(this.numericUpDownParam1_ValueChanged);
            // 
            // numericUpDownParam2
            // 
            this.numericUpDownParam2.DecimalPlaces = 2;
            this.numericUpDownParam2.Location = new System.Drawing.Point(47, 62);
            this.numericUpDownParam2.Name = "numericUpDownParam2";
            this.numericUpDownParam2.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownParam2.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownParam1);
            this.groupBox1.Controls.Add(this.numericUpDownParam2);
            this.groupBox1.Controls.Add(this.labelParam1);
            this.groupBox1.Controls.Add(this.labelParam2);
            this.groupBox1.Location = new System.Drawing.Point(12, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 112);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры";
            // 
            // FormDistrLaw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 269);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.comboBoxChoiceLawDistribution);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.labelDistributionLaw);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDistrLaw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Закон распределения";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDistrLaw_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownParam1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownParam2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDistributionLaw;
        private System.Windows.Forms.Label labelParam1;
        private System.Windows.Forms.Label labelParam2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.ComboBox comboBoxChoiceLawDistribution;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.NumericUpDown numericUpDownParam1;
        private System.Windows.Forms.NumericUpDown numericUpDownParam2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}