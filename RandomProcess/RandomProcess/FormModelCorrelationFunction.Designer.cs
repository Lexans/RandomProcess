namespace RandomProcess
{
    partial class FormModelCorrelationFunction
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
            this.comboBoxSelectionCorrelationFunction = new System.Windows.Forms.ComboBox();
            this.labelModelCorrelationFunction = new System.Windows.Forms.Label();
            this.labelOption = new System.Windows.Forms.Label();
            this.labelOption1 = new System.Windows.Forms.Label();
            this.labelOption2 = new System.Windows.Forms.Label();
            this.buttonAgo = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.textBoxOption1 = new System.Windows.Forms.TextBox();
            this.textBoxOption2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBoxSelectionCorrelationFunction
            // 
            this.comboBoxSelectionCorrelationFunction.FormattingEnabled = true;
            this.comboBoxSelectionCorrelationFunction.Location = new System.Drawing.Point(25, 68);
            this.comboBoxSelectionCorrelationFunction.Name = "comboBoxSelectionCorrelationFunction";
            this.comboBoxSelectionCorrelationFunction.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSelectionCorrelationFunction.TabIndex = 0;
            // 
            // labelModelCorrelationFunction
            // 
            this.labelModelCorrelationFunction.AutoSize = true;
            this.labelModelCorrelationFunction.Location = new System.Drawing.Point(22, 28);
            this.labelModelCorrelationFunction.Name = "labelModelCorrelationFunction";
            this.labelModelCorrelationFunction.Size = new System.Drawing.Size(238, 17);
            this.labelModelCorrelationFunction.TabIndex = 1;
            this.labelModelCorrelationFunction.Text = "Модель корреляционной функции:";
            // 
            // labelOption
            // 
            this.labelOption.AutoSize = true;
            this.labelOption.Location = new System.Drawing.Point(22, 109);
            this.labelOption.Name = "labelOption";
            this.labelOption.Size = new System.Drawing.Size(88, 17);
            this.labelOption.TabIndex = 2;
            this.labelOption.Text = "Параметры:";
            // 
            // labelOption1
            // 
            this.labelOption1.AutoSize = true;
            this.labelOption1.Location = new System.Drawing.Point(22, 160);
            this.labelOption1.Name = "labelOption1";
            this.labelOption1.Size = new System.Drawing.Size(82, 17);
            this.labelOption1.TabIndex = 3;
            this.labelOption1.Text = "Параметр1";
            // 
            // labelOption2
            // 
            this.labelOption2.AutoSize = true;
            this.labelOption2.Location = new System.Drawing.Point(22, 191);
            this.labelOption2.Name = "labelOption2";
            this.labelOption2.Size = new System.Drawing.Size(82, 17);
            this.labelOption2.TabIndex = 4;
            this.labelOption2.Text = "Параметр2";
            // 
            // buttonAgo
            // 
            this.buttonAgo.Location = new System.Drawing.Point(25, 230);
            this.buttonAgo.Name = "buttonAgo";
            this.buttonAgo.Size = new System.Drawing.Size(100, 33);
            this.buttonAgo.TabIndex = 5;
            this.buttonAgo.Text = "Назад";
            this.buttonAgo.UseVisualStyleBackColor = true;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(162, 230);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(108, 33);
            this.buttonNext.TabIndex = 6;
            this.buttonNext.Text = "Далее";
            this.buttonNext.UseVisualStyleBackColor = true;
            // 
            // textBoxOption1
            // 
            this.textBoxOption1.Location = new System.Drawing.Point(133, 155);
            this.textBoxOption1.Name = "textBoxOption1";
            this.textBoxOption1.Size = new System.Drawing.Size(100, 22);
            this.textBoxOption1.TabIndex = 7;
            // 
            // textBoxOption2
            // 
            this.textBoxOption2.Location = new System.Drawing.Point(133, 186);
            this.textBoxOption2.Name = "textBoxOption2";
            this.textBoxOption2.Size = new System.Drawing.Size(100, 22);
            this.textBoxOption2.TabIndex = 8;
            // 
            // FormModelCorrelationFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 281);
            this.Controls.Add(this.textBoxOption2);
            this.Controls.Add(this.textBoxOption1);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonAgo);
            this.Controls.Add(this.labelOption2);
            this.Controls.Add(this.labelOption1);
            this.Controls.Add(this.labelOption);
            this.Controls.Add(this.labelModelCorrelationFunction);
            this.Controls.Add(this.comboBoxSelectionCorrelationFunction);
            this.Name = "FormModelCorrelationFunction";
            this.Text = "Модель корреляционной функции";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSelectionCorrelationFunction;
        private System.Windows.Forms.Label labelModelCorrelationFunction;
        private System.Windows.Forms.Label labelOption;
        private System.Windows.Forms.Label labelOption1;
        private System.Windows.Forms.Label labelOption2;
        private System.Windows.Forms.Button buttonAgo;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.TextBox textBoxOption1;
        private System.Windows.Forms.TextBox textBoxOption2;
    }
}