namespace RandomProcess
{
    partial class FormSelectCF
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
            this.comboBoxCF = new System.Windows.Forms.ComboBox();
            this.labelModelCorrelationFunction = new System.Windows.Forms.Label();
            this.labelParam1 = new System.Windows.Forms.Label();
            this.labelParam2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownParam2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownParam1 = new System.Windows.Forms.NumericUpDown();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownParam2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownParam1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCF
            // 
            this.comboBoxCF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCF.FormattingEnabled = true;
            this.comboBoxCF.Items.AddRange(new object[] {
            "Колебательная",
            "Затухающая"});
            this.comboBoxCF.Location = new System.Drawing.Point(25, 46);
            this.comboBoxCF.Name = "comboBoxCF";
            this.comboBoxCF.Size = new System.Drawing.Size(225, 24);
            this.comboBoxCF.TabIndex = 0;
            this.comboBoxCF.SelectedIndexChanged += new System.EventHandler(this.comboBoxCF_SelectedIndexChanged);
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
            // labelParam1
            // 
            this.labelParam1.AutoSize = true;
            this.labelParam1.Location = new System.Drawing.Point(6, 32);
            this.labelParam1.Name = "labelParam1";
            this.labelParam1.Size = new System.Drawing.Size(16, 17);
            this.labelParam1.TabIndex = 3;
            this.labelParam1.Text = "α";
            // 
            // labelParam2
            // 
            this.labelParam2.AutoSize = true;
            this.labelParam2.Location = new System.Drawing.Point(7, 67);
            this.labelParam2.Name = "labelParam2";
            this.labelParam2.Size = new System.Drawing.Size(25, 17);
            this.labelParam2.TabIndex = 4;
            this.labelParam2.Text = "ω0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownParam2);
            this.groupBox1.Controls.Add(this.numericUpDownParam1);
            this.groupBox1.Controls.Add(this.labelParam1);
            this.groupBox1.Controls.Add(this.labelParam2);
            this.groupBox1.Location = new System.Drawing.Point(15, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 98);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры";
            // 
            // numericUpDownParam2
            // 
            this.numericUpDownParam2.DecimalPlaces = 2;
            this.numericUpDownParam2.Location = new System.Drawing.Point(49, 67);
            this.numericUpDownParam2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownParam2.Name = "numericUpDownParam2";
            this.numericUpDownParam2.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownParam2.TabIndex = 6;
            this.numericUpDownParam2.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numericUpDownParam1
            // 
            this.numericUpDownParam1.DecimalPlaces = 2;
            this.numericUpDownParam1.Location = new System.Drawing.Point(49, 30);
            this.numericUpDownParam1.Name = "numericUpDownParam1";
            this.numericUpDownParam1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownParam1.TabIndex = 5;
            this.numericUpDownParam1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonPrev
            // 
            this.buttonPrev.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonPrev.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonPrev.Location = new System.Drawing.Point(12, 202);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(115, 36);
            this.buttonPrev.TabIndex = 11;
            this.buttonPrev.Text = "Назад";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNext.Location = new System.Drawing.Point(214, 202);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(123, 36);
            this.buttonNext.TabIndex = 10;
            this.buttonNext.Text = "Далее";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // FormSelectCF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 244);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelModelCorrelationFunction);
            this.Controls.Add(this.comboBoxCF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSelectCF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Корреляционная функция";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.FormSelectCF_HelpButtonClicked);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownParam2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownParam1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCF;
        private System.Windows.Forms.Label labelModelCorrelationFunction;
        private System.Windows.Forms.Label labelParam1;
        private System.Windows.Forms.Label labelParam2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownParam2;
        private System.Windows.Forms.NumericUpDown numericUpDownParam1;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonNext;
    }
}