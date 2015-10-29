namespace RandomProcess
{
    partial class FormRegen
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
            this.labelNewN = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.numericUpDownNewValue = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNewValue)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNewN
            // 
            this.labelNewN.AutoSize = true;
            this.labelNewN.Location = new System.Drawing.Point(12, 9);
            this.labelNewN.Name = "labelNewN";
            this.labelNewN.Size = new System.Drawing.Size(175, 17);
            this.labelNewN.TabIndex = 0;
            this.labelNewN.Text = "Новый объем выборки N:";
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.Location = new System.Drawing.Point(121, 80);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(93, 23);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // numericUpDownNewValue
            // 
            this.numericUpDownNewValue.Location = new System.Drawing.Point(35, 39);
            this.numericUpDownNewValue.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownNewValue.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownNewValue.Name = "numericUpDownNewValue";
            this.numericUpDownNewValue.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownNewValue.TabIndex = 2;
            this.numericUpDownNewValue.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(229, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormRegenArray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 115);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDownNewValue);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelNewN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRegenArray";
            this.Text = "Генерация новой выборки";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNewValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNewN;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.NumericUpDown numericUpDownNewValue;
        private System.Windows.Forms.Button button1;
    }
}