namespace RandomProcess
{
    partial class FormSelectMethod
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
            this.radioButtonDistr = new System.Windows.Forms.RadioButton();
            this.radioButtonCF = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownN = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
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
            // radioButtonDistr
            // 
            this.radioButtonDistr.AutoSize = true;
            this.radioButtonDistr.Checked = true;
            this.radioButtonDistr.Location = new System.Drawing.Point(6, 31);
            this.radioButtonDistr.Name = "radioButtonDistr";
            this.radioButtonDistr.Size = new System.Drawing.Size(203, 21);
            this.radioButtonDistr.TabIndex = 4;
            this.radioButtonDistr.TabStop = true;
            this.radioButtonDistr.Text = "По закону распределения";
            this.radioButtonDistr.UseVisualStyleBackColor = true;
            // 
            // radioButtonCF
            // 
            this.radioButtonCF.AutoSize = true;
            this.radioButtonCF.Location = new System.Drawing.Point(6, 58);
            this.radioButtonCF.Name = "radioButtonCF";
            this.radioButtonCF.Size = new System.Drawing.Size(223, 21);
            this.radioButtonCF.TabIndex = 5;
            this.radioButtonCF.TabStop = true;
            this.radioButtonCF.Text = "По корреляционной функции";
            this.radioButtonCF.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonDistr);
            this.groupBox1.Controls.Add(this.radioButtonCF);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(352, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 27);
            this.button1.TabIndex = 8;
            this.button1.Text = "О системе";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormSelectMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 212);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDownN);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelVolumeArray);
            this.Controls.Add(this.buttonNext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSelectMethod";
            this.Text = "Способ моделирования";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.FormSelectMethod_HelpButtonClicked);
            this.Activated += new System.EventHandler(this.FormSelectMethod_Activated);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label labelVolumeArray;
        private System.Windows.Forms.RadioButton radioButtonDistr;
        private System.Windows.Forms.RadioButton radioButtonCF;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownN;
        private System.Windows.Forms.Button button1;
    }
}

