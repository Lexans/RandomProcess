namespace RandomProcess
{
    partial class FormModelingCF
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
            System.Windows.Forms.ListViewItem listViewItem45 = new System.Windows.Forms.ListViewItem("MX");
            System.Windows.Forms.ListViewItem listViewItem46 = new System.Windows.Forms.ListViewItem("DX");
            System.Windows.Forms.ListViewItem listViewItem47 = new System.Windows.Forms.ListViewItem("Ka");
            System.Windows.Forms.ListViewItem listViewItem48 = new System.Windows.Forms.ListViewItem("Kε");
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonSaveArray = new System.Windows.Forms.Button();
            this.buttonNewArray = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listViewChar = new System.Windows.Forms.ListView();
            this.columnHeaderChar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStatValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonCorrF = new System.Windows.Forms.RadioButton();
            this.radioButtonDistrFunction = new System.Windows.Forms.RadioButton();
            this.radioButtonDensity = new System.Windows.Forms.RadioButton();
            this.saveFileDialogSample = new System.Windows.Forms.SaveFileDialog();
            this.labelYName = new System.Windows.Forms.Label();
            this.panelCanvas = new System.Windows.Forms.Panel();
            this.labelYMin = new System.Windows.Forms.Label();
            this.labelYmax = new System.Windows.Forms.Label();
            this.labelXName = new System.Windows.Forms.Label();
            this.labelXMax = new System.Windows.Forms.Label();
            this.labelXMin = new System.Windows.Forms.Label();
            this.labelN = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonExit.Location = new System.Drawing.Point(368, 378);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(105, 30);
            this.buttonExit.TabIndex = 20;
            this.buttonExit.Text = "Завершить";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBack.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonBack.Location = new System.Drawing.Point(17, 378);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(117, 30);
            this.buttonBack.TabIndex = 19;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonSaveArray
            // 
            this.buttonSaveArray.Location = new System.Drawing.Point(150, 292);
            this.buttonSaveArray.Name = "buttonSaveArray";
            this.buttonSaveArray.Size = new System.Drawing.Size(197, 30);
            this.buttonSaveArray.TabIndex = 18;
            this.buttonSaveArray.Text = "Сохранить выборку в файл";
            this.buttonSaveArray.UseVisualStyleBackColor = true;
            this.buttonSaveArray.Click += new System.EventHandler(this.buttonSaveArray_Click);
            // 
            // buttonNewArray
            // 
            this.buttonNewArray.Location = new System.Drawing.Point(150, 257);
            this.buttonNewArray.Name = "buttonNewArray";
            this.buttonNewArray.Size = new System.Drawing.Size(197, 29);
            this.buttonNewArray.TabIndex = 23;
            this.buttonNewArray.Text = "Новая выборка";
            this.buttonNewArray.UseVisualStyleBackColor = true;
            this.buttonNewArray.Click += new System.EventHandler(this.buttonNewArray_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listViewChar);
            this.groupBox2.Location = new System.Drawing.Point(12, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(482, 177);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Числовые характеристики";
            // 
            // listViewChar
            // 
            this.listViewChar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderChar,
            this.columnHeaderStatValue});
            this.listViewChar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewChar.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem45,
            listViewItem46,
            listViewItem47,
            listViewItem48});
            this.listViewChar.Location = new System.Drawing.Point(3, 18);
            this.listViewChar.Name = "listViewChar";
            this.listViewChar.Size = new System.Drawing.Size(476, 156);
            this.listViewChar.TabIndex = 7;
            this.listViewChar.UseCompatibleStateImageBehavior = false;
            this.listViewChar.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderChar
            // 
            this.columnHeaderChar.Text = "Характеристика";
            this.columnHeaderChar.Width = 216;
            // 
            // columnHeaderStatValue
            // 
            this.columnHeaderStatValue.Text = "Статистическая оценка";
            this.columnHeaderStatValue.Width = 247;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelN);
            this.groupBox1.Controls.Add(this.labelXName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelXMax);
            this.groupBox1.Controls.Add(this.labelXMin);
            this.groupBox1.Controls.Add(this.labelYMin);
            this.groupBox1.Controls.Add(this.labelYmax);
            this.groupBox1.Controls.Add(this.labelYName);
            this.groupBox1.Controls.Add(this.panelCanvas);
            this.groupBox1.Controls.Add(this.radioButtonCorrF);
            this.groupBox1.Controls.Add(this.radioButtonDistrFunction);
            this.groupBox1.Controls.Add(this.radioButtonDensity);
            this.groupBox1.Location = new System.Drawing.Point(500, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 388);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вероятностные характеристики";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButtonCorrF
            // 
            this.radioButtonCorrF.AutoSize = true;
            this.radioButtonCorrF.Location = new System.Drawing.Point(12, 349);
            this.radioButtonCorrF.Name = "radioButtonCorrF";
            this.radioButtonCorrF.Size = new System.Drawing.Size(203, 21);
            this.radioButtonCorrF.TabIndex = 9;
            this.radioButtonCorrF.Text = "Корреляционная функция";
            this.radioButtonCorrF.UseVisualStyleBackColor = true;
            this.radioButtonCorrF.CheckedChanged += new System.EventHandler(this.radioButtonCorrF_CheckedChanged);
            // 
            // radioButtonDistrFunction
            // 
            this.radioButtonDistrFunction.AutoSize = true;
            this.radioButtonDistrFunction.Location = new System.Drawing.Point(12, 322);
            this.radioButtonDistrFunction.Name = "radioButtonDistrFunction";
            this.radioButtonDistrFunction.Size = new System.Drawing.Size(195, 21);
            this.radioButtonDistrFunction.TabIndex = 5;
            this.radioButtonDistrFunction.Text = "Функция распределения";
            this.radioButtonDistrFunction.UseVisualStyleBackColor = true;
            this.radioButtonDistrFunction.CheckedChanged += new System.EventHandler(this.radioButtonDistrFunction_CheckedChanged);
            // 
            // radioButtonDensity
            // 
            this.radioButtonDensity.AutoSize = true;
            this.radioButtonDensity.Checked = true;
            this.radioButtonDensity.Location = new System.Drawing.Point(12, 295);
            this.radioButtonDensity.Name = "radioButtonDensity";
            this.radioButtonDensity.Size = new System.Drawing.Size(99, 21);
            this.radioButtonDensity.TabIndex = 6;
            this.radioButtonDensity.TabStop = true;
            this.radioButtonDensity.Text = "Плотность";
            this.radioButtonDensity.UseVisualStyleBackColor = true;
            this.radioButtonDensity.CheckedChanged += new System.EventHandler(this.radioButtonDensity_CheckedChanged);
            // 
            // saveFileDialogSample
            // 
            this.saveFileDialogSample.DefaultExt = "csv";
            this.saveFileDialogSample.Filter = "CSV|*.csv";
            this.saveFileDialogSample.ShowHelp = true;
            this.saveFileDialogSample.Title = "Сохранение выборки в файл";
            // 
            // labelYName
            // 
            this.labelYName.AutoSize = true;
            this.labelYName.Location = new System.Drawing.Point(19, 27);
            this.labelYName.Name = "labelYName";
            this.labelYName.Size = new System.Drawing.Size(28, 17);
            this.labelYName.TabIndex = 21;
            this.labelYName.Text = "f(x)";
            // 
            // panelCanvas
            // 
            this.panelCanvas.Location = new System.Drawing.Point(45, 37);
            this.panelCanvas.Name = "panelCanvas";
            this.panelCanvas.Size = new System.Drawing.Size(424, 234);
            this.panelCanvas.TabIndex = 16;
            this.panelCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCanvas_Paint_1);
            // 
            // labelYMin
            // 
            this.labelYMin.AutoSize = true;
            this.labelYMin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelYMin.Location = new System.Drawing.Point(-1, 253);
            this.labelYMin.MinimumSize = new System.Drawing.Size(45, 0);
            this.labelYMin.Name = "labelYMin";
            this.labelYMin.Size = new System.Drawing.Size(45, 17);
            this.labelYMin.TabIndex = 23;
            this.labelYMin.Text = "0.0#";
            this.labelYMin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelYmax
            // 
            this.labelYmax.AutoSize = true;
            this.labelYmax.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelYmax.Location = new System.Drawing.Point(0, 48);
            this.labelYmax.MinimumSize = new System.Drawing.Size(45, 0);
            this.labelYmax.Name = "labelYmax";
            this.labelYmax.Size = new System.Drawing.Size(45, 17);
            this.labelYmax.TabIndex = 22;
            this.labelYmax.Text = "0.0#";
            this.labelYmax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelXName
            // 
            this.labelXName.AutoSize = true;
            this.labelXName.Location = new System.Drawing.Point(474, 254);
            this.labelXName.Name = "labelXName";
            this.labelXName.Size = new System.Drawing.Size(14, 17);
            this.labelXName.TabIndex = 24;
            this.labelXName.Text = "x";
            // 
            // labelXMax
            // 
            this.labelXMax.AutoSize = true;
            this.labelXMax.Location = new System.Drawing.Point(408, 274);
            this.labelXMax.MinimumSize = new System.Drawing.Size(60, 0);
            this.labelXMax.Name = "labelXMax";
            this.labelXMax.Size = new System.Drawing.Size(60, 17);
            this.labelXMax.TabIndex = 26;
            this.labelXMax.Text = "0.0#___";
            this.labelXMax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelXMin
            // 
            this.labelXMin.AutoSize = true;
            this.labelXMin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelXMin.Location = new System.Drawing.Point(45, 275);
            this.labelXMin.MinimumSize = new System.Drawing.Size(45, 0);
            this.labelXMin.Name = "labelXMin";
            this.labelXMin.Size = new System.Drawing.Size(60, 17);
            this.labelXMin.TabIndex = 25;
            this.labelXMin.Text = "___0.0#";
            this.labelXMin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Location = new System.Drawing.Point(397, 300);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(48, 17);
            this.labelN.TabIndex = 25;
            this.labelN.Text = "00000";
            this.labelN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Объём выборки:";
            // 
            // FormModelingCF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 420);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonSaveArray);
            this.Controls.Add(this.buttonNewArray);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormModelingCF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Результаты моделирования";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormModelingCF_FormClosed);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonSaveArray;
        private System.Windows.Forms.Button buttonNewArray;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listViewChar;
        private System.Windows.Forms.ColumnHeader columnHeaderChar;
        private System.Windows.Forms.ColumnHeader columnHeaderStatValue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonCorrF;
        private System.Windows.Forms.RadioButton radioButtonDistrFunction;
        private System.Windows.Forms.RadioButton radioButtonDensity;
        private System.Windows.Forms.SaveFileDialog saveFileDialogSample;
        private System.Windows.Forms.Label labelYName;
        private System.Windows.Forms.Panel panelCanvas;
        private System.Windows.Forms.Label labelYMin;
        private System.Windows.Forms.Label labelYmax;
        private System.Windows.Forms.Label labelXName;
        private System.Windows.Forms.Label labelXMax;
        private System.Windows.Forms.Label labelXMin;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Label label1;

    }
}