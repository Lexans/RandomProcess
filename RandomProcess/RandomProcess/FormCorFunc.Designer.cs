namespace RandomProcess
{
    partial class FormCorFunc
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
            this.comboBoxCorFunc = new System.Windows.Forms.ComboBox();
            this.labelModelCorrelationFunction = new System.Windows.Forms.Label();
            this.labelOption1 = new System.Windows.Forms.Label();
            this.labelOption2 = new System.Windows.Forms.Label();
            this.buttonAgo = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCorFunc
            // 
            this.comboBoxCorFunc.FormattingEnabled = true;
            this.comboBoxCorFunc.Location = new System.Drawing.Point(25, 46);
            this.comboBoxCorFunc.Name = "comboBoxCorFunc";
            this.comboBoxCorFunc.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCorFunc.TabIndex = 0;
            // 
            // labelModelCorrelationFunction
            // 
            this.labelModelCorrelationFunction.AutoSize = true;
            this.labelModelCorrelationFunction.Location = new System.Drawing.Point(12, 26);
            this.labelModelCorrelationFunction.Name = "labelModelCorrelationFunction";
            this.labelModelCorrelationFunction.Size = new System.Drawing.Size(238, 17);
            this.labelModelCorrelationFunction.TabIndex = 1;
            this.labelModelCorrelationFunction.Text = "Модель корреляционной функции:";
            // 
            // labelOption1
            // 
            this.labelOption1.AutoSize = true;
            this.labelOption1.Location = new System.Drawing.Point(6, 32);
            this.labelOption1.Name = "labelOption1";
            this.labelOption1.Size = new System.Drawing.Size(82, 17);
            this.labelOption1.TabIndex = 3;
            this.labelOption1.Text = "Параметр1";
            // 
            // labelOption2
            // 
            this.labelOption2.AutoSize = true;
            this.labelOption2.Location = new System.Drawing.Point(7, 67);
            this.labelOption2.Name = "labelOption2";
            this.labelOption2.Size = new System.Drawing.Size(82, 17);
            this.labelOption2.TabIndex = 4;
            this.labelOption2.Text = "Параметр2";
            // 
            // buttonAgo
            // 
            this.buttonAgo.Location = new System.Drawing.Point(84, 205);
            this.buttonAgo.Name = "buttonAgo";
            this.buttonAgo.Size = new System.Drawing.Size(100, 33);
            this.buttonAgo.TabIndex = 5;
            this.buttonAgo.Text = "Назад";
            this.buttonAgo.UseVisualStyleBackColor = true;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(226, 205);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(108, 33);
            this.buttonNext.TabIndex = 6;
            this.buttonNext.Text = "Далее";
            this.buttonNext.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.labelOption1);
            this.groupBox1.Controls.Add(this.labelOption2);
            this.groupBox1.Location = new System.Drawing.Point(15, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 110);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(105, 65);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown2.TabIndex = 6;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(105, 27);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 5;
            // 
            // FormCorFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 246);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonAgo);
            this.Controls.Add(this.labelModelCorrelationFunction);
            this.Controls.Add(this.comboBoxCorFunc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCorFunc";
            this.Text = "Корреляционная функция";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCorFunc;
        private System.Windows.Forms.Label labelModelCorrelationFunction;
        private System.Windows.Forms.Label labelOption1;
        private System.Windows.Forms.Label labelOption2;
        private System.Windows.Forms.Button buttonAgo;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}