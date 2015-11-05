namespace RandomProcess
{
    partial class FormMethod
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonNext = new System.Windows.Forms.Button();
            this.labelVolumeArray = new System.Windows.Forms.Label();
            this.radioButtonDistributionLaw = new System.Windows.Forms.RadioButton();
            this.radioButtonCorrelationFunction = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownN = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownN)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNext.Location = new System.Drawing.Point(351, 164);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(101, 36);
            this.buttonNext.TabIndex = 0;
            this.buttonNext.Text = "Далее";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // labelVolumeArray
            // 
            this.labelVolumeArray.AutoSize = true;
            this.labelVolumeArray.Location = new System.Drawing.Point(15, 132);
            this.labelVolumeArray.Name = "labelVolumeArray";
            this.labelVolumeArray.Size = new System.Drawing.Size(131, 17);
            this.labelVolumeArray.TabIndex = 1;
            this.labelVolumeArray.Text = "Объем выборки N:";
            // 
            // radioButtonDistributionLaw
            // 
            this.radioButtonDistributionLaw.AutoSize = true;
            this.radioButtonDistributionLaw.Checked = true;
            this.radioButtonDistributionLaw.Location = new System.Drawing.Point(6, 31);
            this.radioButtonDistributionLaw.Name = "radioButtonDistributionLaw";
            this.radioButtonDistributionLaw.Size = new System.Drawing.Size(203, 21);
            this.radioButtonDistributionLaw.TabIndex = 4;
            this.radioButtonDistributionLaw.TabStop = true;
            this.radioButtonDistributionLaw.Text = "По закону распределения";
            this.radioButtonDistributionLaw.UseVisualStyleBackColor = true;
            // 
            // radioButtonCorrelationFunction
            // 
            this.radioButtonCorrelationFunction.AutoSize = true;
            this.radioButtonCorrelationFunction.Location = new System.Drawing.Point(6, 58);
            this.radioButtonCorrelationFunction.Name = "radioButtonCorrelationFunction";
            this.radioButtonCorrelationFunction.Size = new System.Drawing.Size(223, 21);
            this.radioButtonCorrelationFunction.TabIndex = 5;
            this.radioButtonCorrelationFunction.TabStop = true;
            this.radioButtonCorrelationFunction.Text = "По корреляционной функции";
            this.radioButtonCorrelationFunction.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonDistributionLaw);
            this.groupBox1.Controls.Add(this.radioButtonCorrelationFunction);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 98);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Способ моделирования";
            // 
            // numericUpDownN
            // 
            this.numericUpDownN.Location = new System.Drawing.Point(44, 152);
            this.numericUpDownN.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownN.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownN.Name = "numericUpDownN";
            this.numericUpDownN.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownN.TabIndex = 7;
            this.numericUpDownN.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // FormMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 212);
            this.Controls.Add(this.numericUpDownN);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelVolumeArray);
            this.Controls.Add(this.buttonNext);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMethod";
            this.Text = "Способ моделирования";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label labelVolumeArray;
        private System.Windows.Forms.RadioButton radioButtonDistributionLaw;
        private System.Windows.Forms.RadioButton radioButtonCorrelationFunction;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownN;
    }
}

