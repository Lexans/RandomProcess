namespace RandomProcess
{
    partial class FormHypothesisTesting
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
            this.radioButtonPirsona = new System.Windows.Forms.RadioButton();
            this.radioButtonKolmogorova = new System.Windows.Forms.RadioButton();
            this.buttonAgo = new System.Windows.Forms.Button();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.labelCriterion = new System.Windows.Forms.Label();
            this.labelLevelImportance = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.comboBoxSelectLevelImportance = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // radioButtonPirsona
            // 
            this.radioButtonPirsona.AutoSize = true;
            this.radioButtonPirsona.Location = new System.Drawing.Point(42, 56);
            this.radioButtonPirsona.Name = "radioButtonPirsona";
            this.radioButtonPirsona.Size = new System.Drawing.Size(86, 21);
            this.radioButtonPirsona.TabIndex = 0;
            this.radioButtonPirsona.TabStop = true;
            this.radioButtonPirsona.Text = "Пирсона";
            this.radioButtonPirsona.UseVisualStyleBackColor = true;
            // 
            // radioButtonKolmogorova
            // 
            this.radioButtonKolmogorova.AutoSize = true;
            this.radioButtonKolmogorova.Location = new System.Drawing.Point(42, 96);
            this.radioButtonKolmogorova.Name = "radioButtonKolmogorova";
            this.radioButtonKolmogorova.Size = new System.Drawing.Size(115, 21);
            this.radioButtonKolmogorova.TabIndex = 1;
            this.radioButtonKolmogorova.TabStop = true;
            this.radioButtonKolmogorova.Text = "Колмогорова";
            this.radioButtonKolmogorova.UseVisualStyleBackColor = true;
            // 
            // buttonAgo
            // 
            this.buttonAgo.Location = new System.Drawing.Point(18, 212);
            this.buttonAgo.Name = "buttonAgo";
            this.buttonAgo.Size = new System.Drawing.Size(101, 33);
            this.buttonAgo.TabIndex = 2;
            this.buttonAgo.Text = "Назад";
            this.buttonAgo.UseVisualStyleBackColor = true;
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(165, 212);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(121, 33);
            this.buttonCheck.TabIndex = 3;
            this.buttonCheck.Text = "Проверить";
            this.buttonCheck.UseVisualStyleBackColor = true;
            // 
            // labelCriterion
            // 
            this.labelCriterion.AutoSize = true;
            this.labelCriterion.Location = new System.Drawing.Point(39, 23);
            this.labelCriterion.Name = "labelCriterion";
            this.labelCriterion.Size = new System.Drawing.Size(76, 17);
            this.labelCriterion.TabIndex = 4;
            this.labelCriterion.Text = "Критерий:";
            // 
            // labelLevelImportance
            // 
            this.labelLevelImportance.AutoSize = true;
            this.labelLevelImportance.Location = new System.Drawing.Point(39, 140);
            this.labelLevelImportance.Name = "labelLevelImportance";
            this.labelLevelImportance.Size = new System.Drawing.Size(149, 17);
            this.labelLevelImportance.TabIndex = 5;
            this.labelLevelImportance.Text = "Уровень значимости:";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(15, 167);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(21, 17);
            this.labelA.TabIndex = 6;
            this.labelA.Text = "A:";
            // 
            // comboBoxSelectLevelImportance
            // 
            this.comboBoxSelectLevelImportance.FormattingEnabled = true;
            this.comboBoxSelectLevelImportance.Location = new System.Drawing.Point(42, 164);
            this.comboBoxSelectLevelImportance.Name = "comboBoxSelectLevelImportance";
            this.comboBoxSelectLevelImportance.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSelectLevelImportance.TabIndex = 7;
            // 
            // FormHypothesisTesting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 277);
            this.Controls.Add(this.comboBoxSelectLevelImportance);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.labelLevelImportance);
            this.Controls.Add(this.labelCriterion);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.buttonAgo);
            this.Controls.Add(this.radioButtonKolmogorova);
            this.Controls.Add(this.radioButtonPirsona);
            this.Name = "FormHypothesisTesting";
            this.Text = "Проверка гипотезы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonPirsona;
        private System.Windows.Forms.RadioButton radioButtonKolmogorova;
        private System.Windows.Forms.Button buttonAgo;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Label labelCriterion;
        private System.Windows.Forms.Label labelLevelImportance;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.ComboBox comboBoxSelectLevelImportance;
    }
}