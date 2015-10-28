namespace RandomProcess
{
    partial class FormMain
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
            this.labelN = new System.Windows.Forms.Label();
            this.textBoxVolumeArray = new System.Windows.Forms.TextBox();
            this.radioButtonDistributionLaw = new System.Windows.Forms.RadioButton();
            this.radioButtonCorrelationFunction = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(283, 109);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(121, 48);
            this.buttonNext.TabIndex = 0;
            this.buttonNext.Text = "Далее";
            this.buttonNext.UseVisualStyleBackColor = true;
            // 
            // labelVolumeArray
            // 
            this.labelVolumeArray.AutoSize = true;
            this.labelVolumeArray.Location = new System.Drawing.Point(12, 103);
            this.labelVolumeArray.Name = "labelVolumeArray";
            this.labelVolumeArray.Size = new System.Drawing.Size(113, 17);
            this.labelVolumeArray.TabIndex = 1;
            this.labelVolumeArray.Text = "Объем выборки";
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Location = new System.Drawing.Point(12, 138);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(22, 17);
            this.labelN.TabIndex = 2;
            this.labelN.Text = "N:";
            this.labelN.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxVolumeArray
            // 
            this.textBoxVolumeArray.Location = new System.Drawing.Point(54, 135);
            this.textBoxVolumeArray.Name = "textBoxVolumeArray";
            this.textBoxVolumeArray.Size = new System.Drawing.Size(133, 22);
            this.textBoxVolumeArray.TabIndex = 3;
            // 
            // radioButtonDistributionLaw
            // 
            this.radioButtonDistributionLaw.AutoSize = true;
            this.radioButtonDistributionLaw.Location = new System.Drawing.Point(12, 12);
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
            this.radioButtonCorrelationFunction.Location = new System.Drawing.Point(12, 54);
            this.radioButtonCorrelationFunction.Name = "radioButtonCorrelationFunction";
            this.radioButtonCorrelationFunction.Size = new System.Drawing.Size(223, 21);
            this.radioButtonCorrelationFunction.TabIndex = 5;
            this.radioButtonCorrelationFunction.TabStop = true;
            this.radioButtonCorrelationFunction.Text = "По корреляционной функции";
            this.radioButtonCorrelationFunction.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 191);
            this.Controls.Add(this.radioButtonCorrelationFunction);
            this.Controls.Add(this.radioButtonDistributionLaw);
            this.Controls.Add(this.textBoxVolumeArray);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.labelVolumeArray);
            this.Controls.Add(this.buttonNext);
            this.Name = "FormMain";
            this.Text = "Способ моделирования";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label labelVolumeArray;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.TextBox textBoxVolumeArray;
        private System.Windows.Forms.RadioButton radioButtonDistributionLaw;
        private System.Windows.Forms.RadioButton radioButtonCorrelationFunction;
    }
}

