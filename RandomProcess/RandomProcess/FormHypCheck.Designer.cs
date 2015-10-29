namespace RandomProcess
{
    partial class FormHypCheck
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
            this.radioButtonPirson = new System.Windows.Forms.RadioButton();
            this.radioButtonKolmogorov = new System.Windows.Forms.RadioButton();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.labelLevelImportance = new System.Windows.Forms.Label();
            this.comboBoxA = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonPirson
            // 
            this.radioButtonPirson.AutoSize = true;
            this.radioButtonPirson.Checked = true;
            this.radioButtonPirson.Location = new System.Drawing.Point(6, 35);
            this.radioButtonPirson.Name = "radioButtonPirson";
            this.radioButtonPirson.Size = new System.Drawing.Size(86, 21);
            this.radioButtonPirson.TabIndex = 0;
            this.radioButtonPirson.TabStop = true;
            this.radioButtonPirson.Text = "Пирсона";
            this.radioButtonPirson.UseVisualStyleBackColor = true;
            // 
            // radioButtonKolmogorov
            // 
            this.radioButtonKolmogorov.AutoSize = true;
            this.radioButtonKolmogorov.Location = new System.Drawing.Point(6, 73);
            this.radioButtonKolmogorov.Name = "radioButtonKolmogorov";
            this.radioButtonKolmogorov.Size = new System.Drawing.Size(115, 21);
            this.radioButtonKolmogorov.TabIndex = 1;
            this.radioButtonKolmogorov.Text = "Колмогорова";
            this.radioButtonKolmogorov.UseVisualStyleBackColor = true;
            // 
            // buttonPrev
            // 
            this.buttonPrev.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonPrev.Location = new System.Drawing.Point(64, 200);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(101, 33);
            this.buttonPrev.TabIndex = 2;
            this.buttonPrev.Text = "Назад";
            this.buttonPrev.UseVisualStyleBackColor = true;
            // 
            // buttonCheck
            // 
            this.buttonCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCheck.Location = new System.Drawing.Point(212, 200);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(121, 33);
            this.buttonCheck.TabIndex = 3;
            this.buttonCheck.Text = "Проверить";
            this.buttonCheck.UseVisualStyleBackColor = true;
            // 
            // labelLevelImportance
            // 
            this.labelLevelImportance.AutoSize = true;
            this.labelLevelImportance.Location = new System.Drawing.Point(15, 144);
            this.labelLevelImportance.Name = "labelLevelImportance";
            this.labelLevelImportance.Size = new System.Drawing.Size(161, 17);
            this.labelLevelImportance.TabIndex = 5;
            this.labelLevelImportance.Text = "Уровень значимости α:";
            // 
            // comboBoxA
            // 
            this.comboBoxA.FormattingEnabled = true;
            this.comboBoxA.Location = new System.Drawing.Point(18, 164);
            this.comboBoxA.Name = "comboBoxA";
            this.comboBoxA.Size = new System.Drawing.Size(223, 24);
            this.comboBoxA.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonPirson);
            this.groupBox1.Controls.Add(this.radioButtonKolmogorov);
            this.groupBox1.Location = new System.Drawing.Point(18, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Критерий";
            // 
            // FormHypCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 245);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxA);
            this.Controls.Add(this.labelLevelImportance);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.buttonPrev);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormHypCheck";
            this.Text = "Проверка гипотезы";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonPirson;
        private System.Windows.Forms.RadioButton radioButtonKolmogorov;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Label labelLevelImportance;
        private System.Windows.Forms.ComboBox comboBoxA;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}