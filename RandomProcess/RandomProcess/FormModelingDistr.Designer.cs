namespace RandomProcess
{
    partial class FormModelingDistr
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("MX");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("DX");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Ka");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Kε");
            this.buttonHypCheck = new System.Windows.Forms.Button();
            this.buttonComplete = new System.Windows.Forms.Button();
            this.buttonAgo = new System.Windows.Forms.Button();
            this.buttonSaveArray = new System.Windows.Forms.Button();
            this.radioButtonDistrFunction = new System.Windows.Forms.RadioButton();
            this.radioButtonDensity = new System.Windows.Forms.RadioButton();
            this.listViewChar = new System.Windows.Forms.ListView();
            this.columnHeaderChar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStatValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAnalyt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonNewArray = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelN = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelYAnalytMax = new System.Windows.Forms.Label();
            this.labelYMin = new System.Windows.Forms.Label();
            this.labelYName = new System.Windows.Forms.Label();
            this.labelXName = new System.Windows.Forms.Label();
            this.labelXMax = new System.Windows.Forms.Label();
            this.labelXMin = new System.Windows.Forms.Label();
            this.labelYmax = new System.Windows.Forms.Label();
            this.radioButtonCorrF = new System.Windows.Forms.RadioButton();
            this.panelCanvas = new System.Windows.Forms.Panel();
            this.saveFileDialogSample = new System.Windows.Forms.SaveFileDialog();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonHypCheck
            // 
            this.buttonHypCheck.Location = new System.Drawing.Point(150, 231);
            this.buttonHypCheck.Name = "buttonHypCheck";
            this.buttonHypCheck.Size = new System.Drawing.Size(197, 30);
            this.buttonHypCheck.TabIndex = 3;
            this.buttonHypCheck.Text = "Проверка гипотезы";
            this.buttonHypCheck.UseVisualStyleBackColor = true;
            this.buttonHypCheck.Click += new System.EventHandler(this.buttonHypCheck_Click);
            // 
            // buttonComplete
            // 
            this.buttonComplete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonComplete.Location = new System.Drawing.Point(376, 377);
            this.buttonComplete.Name = "buttonComplete";
            this.buttonComplete.Size = new System.Drawing.Size(105, 30);
            this.buttonComplete.TabIndex = 14;
            this.buttonComplete.Text = "Завершить";
            this.buttonComplete.UseVisualStyleBackColor = true;
            this.buttonComplete.Click += new System.EventHandler(this.buttonComplete_Click);
            // 
            // buttonAgo
            // 
            this.buttonAgo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAgo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAgo.Location = new System.Drawing.Point(2, 377);
            this.buttonAgo.Name = "buttonAgo";
            this.buttonAgo.Size = new System.Drawing.Size(117, 30);
            this.buttonAgo.TabIndex = 13;
            this.buttonAgo.Text = "Назад";
            this.buttonAgo.UseVisualStyleBackColor = true;
            this.buttonAgo.Click += new System.EventHandler(this.buttonAgo_Click);
            // 
            // buttonSaveArray
            // 
            this.buttonSaveArray.Location = new System.Drawing.Point(150, 302);
            this.buttonSaveArray.Name = "buttonSaveArray";
            this.buttonSaveArray.Size = new System.Drawing.Size(197, 30);
            this.buttonSaveArray.TabIndex = 12;
            this.buttonSaveArray.Text = "Сохранить выборку в файл";
            this.buttonSaveArray.UseVisualStyleBackColor = true;
            this.buttonSaveArray.Click += new System.EventHandler(this.buttonSaveArray_Click);
            // 
            // radioButtonDistrFunction
            // 
            this.radioButtonDistrFunction.AutoSize = true;
            this.radioButtonDistrFunction.Location = new System.Drawing.Point(11, 326);
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
            this.radioButtonDensity.Location = new System.Drawing.Point(11, 299);
            this.radioButtonDensity.Name = "radioButtonDensity";
            this.radioButtonDensity.Size = new System.Drawing.Size(99, 21);
            this.radioButtonDensity.TabIndex = 6;
            this.radioButtonDensity.TabStop = true;
            this.radioButtonDensity.Text = "Плотность";
            this.radioButtonDensity.UseVisualStyleBackColor = true;
            this.radioButtonDensity.CheckedChanged += new System.EventHandler(this.radioButtonDensity_CheckedChanged);
            // 
            // listViewChar
            // 
            this.listViewChar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderChar,
            this.columnHeaderStatValue,
            this.columnHeaderAnalyt});
            this.listViewChar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewChar.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
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
            this.columnHeaderChar.Width = 121;
            // 
            // columnHeaderStatValue
            // 
            this.columnHeaderStatValue.Text = "Статистическая оценка";
            this.columnHeaderStatValue.Width = 169;
            // 
            // columnHeaderAnalyt
            // 
            this.columnHeaderAnalyt.Text = "Аналитическое значение";
            this.columnHeaderAnalyt.Width = 182;
            // 
            // buttonNewArray
            // 
            this.buttonNewArray.Location = new System.Drawing.Point(150, 267);
            this.buttonNewArray.Name = "buttonNewArray";
            this.buttonNewArray.Size = new System.Drawing.Size(197, 29);
            this.buttonNewArray.TabIndex = 17;
            this.buttonNewArray.Text = "Новая выборка";
            this.buttonNewArray.UseVisualStyleBackColor = true;
            this.buttonNewArray.Click += new System.EventHandler(this.buttonNewArray_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listViewChar);
            this.groupBox2.Location = new System.Drawing.Point(12, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(482, 177);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Числовые характеристики";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelN);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelYAnalytMax);
            this.groupBox1.Controls.Add(this.labelYMin);
            this.groupBox1.Controls.Add(this.labelYName);
            this.groupBox1.Controls.Add(this.labelXName);
            this.groupBox1.Controls.Add(this.labelXMax);
            this.groupBox1.Controls.Add(this.labelXMin);
            this.groupBox1.Controls.Add(this.labelYmax);
            this.groupBox1.Controls.Add(this.radioButtonCorrF);
            this.groupBox1.Controls.Add(this.radioButtonDistrFunction);
            this.groupBox1.Controls.Add(this.panelCanvas);
            this.groupBox1.Controls.Add(this.radioButtonDensity);
            this.groupBox1.Location = new System.Drawing.Point(500, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 395);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вероятностные характеристики";
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Location = new System.Drawing.Point(396, 302);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(48, 17);
            this.labelN.TabIndex = 17;
            this.labelN.Text = "00000";
            this.labelN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Объём выборки:";
            // 
            // labelYAnalytMax
            // 
            this.labelYAnalytMax.AutoSize = true;
            this.labelYAnalytMax.Location = new System.Drawing.Point(6, 70);
            this.labelYAnalytMax.MinimumSize = new System.Drawing.Size(45, 0);
            this.labelYAnalytMax.Name = "labelYAnalytMax";
            this.labelYAnalytMax.Size = new System.Drawing.Size(45, 17);
            this.labelYAnalytMax.TabIndex = 15;
            this.labelYAnalytMax.Text = "0.0#";
            this.labelYAnalytMax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelYMin
            // 
            this.labelYMin.AutoSize = true;
            this.labelYMin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelYMin.Location = new System.Drawing.Point(6, 250);
            this.labelYMin.MinimumSize = new System.Drawing.Size(45, 0);
            this.labelYMin.Name = "labelYMin";
            this.labelYMin.Size = new System.Drawing.Size(45, 17);
            this.labelYMin.TabIndex = 11;
            this.labelYMin.Text = "0.0#";
            this.labelYMin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelYName
            // 
            this.labelYName.AutoSize = true;
            this.labelYName.Location = new System.Drawing.Point(25, 23);
            this.labelYName.Name = "labelYName";
            this.labelYName.Size = new System.Drawing.Size(28, 17);
            this.labelYName.TabIndex = 14;
            this.labelYName.Text = "f(x)";
            // 
            // labelXName
            // 
            this.labelXName.AutoSize = true;
            this.labelXName.Location = new System.Drawing.Point(481, 250);
            this.labelXName.Name = "labelXName";
            this.labelXName.Size = new System.Drawing.Size(14, 17);
            this.labelXName.TabIndex = 0;
            this.labelXName.Text = "x";
            // 
            // labelXMax
            // 
            this.labelXMax.AutoSize = true;
            this.labelXMax.Location = new System.Drawing.Point(415, 270);
            this.labelXMax.MinimumSize = new System.Drawing.Size(60, 0);
            this.labelXMax.Name = "labelXMax";
            this.labelXMax.Size = new System.Drawing.Size(60, 17);
            this.labelXMax.TabIndex = 13;
            this.labelXMax.Text = "0.0#___";
            this.labelXMax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelXMin
            // 
            this.labelXMin.AutoSize = true;
            this.labelXMin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelXMin.Location = new System.Drawing.Point(52, 271);
            this.labelXMin.MinimumSize = new System.Drawing.Size(45, 0);
            this.labelXMin.Name = "labelXMin";
            this.labelXMin.Size = new System.Drawing.Size(60, 17);
            this.labelXMin.TabIndex = 12;
            this.labelXMin.Text = "___0.0#";
            this.labelXMin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelYmax
            // 
            this.labelYmax.AutoSize = true;
            this.labelYmax.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelYmax.Location = new System.Drawing.Point(6, 44);
            this.labelYmax.MinimumSize = new System.Drawing.Size(45, 0);
            this.labelYmax.Name = "labelYmax";
            this.labelYmax.Size = new System.Drawing.Size(45, 17);
            this.labelYmax.TabIndex = 10;
            this.labelYmax.Text = "0.0#";
            this.labelYmax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelYmax.Click += new System.EventHandler(this.labelYmax_Click);
            // 
            // radioButtonCorrF
            // 
            this.radioButtonCorrF.AutoSize = true;
            this.radioButtonCorrF.Location = new System.Drawing.Point(11, 353);
            this.radioButtonCorrF.Name = "radioButtonCorrF";
            this.radioButtonCorrF.Size = new System.Drawing.Size(203, 21);
            this.radioButtonCorrF.TabIndex = 9;
            this.radioButtonCorrF.Text = "Корреляционная функция";
            this.radioButtonCorrF.UseVisualStyleBackColor = true;
            this.radioButtonCorrF.CheckedChanged += new System.EventHandler(this.radioButtonCorrF_CheckedChanged);
            // 
            // panelCanvas
            // 
            this.panelCanvas.Location = new System.Drawing.Point(51, 33);
            this.panelCanvas.Name = "panelCanvas";
            this.panelCanvas.Size = new System.Drawing.Size(424, 234);
            this.panelCanvas.TabIndex = 8;
            this.panelCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCanvas_Paint);
            // 
            // saveFileDialogSample
            // 
            this.saveFileDialogSample.DefaultExt = "csv";
            this.saveFileDialogSample.Filter = "CSV|*.csv";
            this.saveFileDialogSample.ShowHelp = true;
            this.saveFileDialogSample.Title = "Сохранение выборки в файл";
            // 
            // FormModelingDistr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 419);
            this.Controls.Add(this.buttonComplete);
            this.Controls.Add(this.buttonAgo);
            this.Controls.Add(this.buttonSaveArray);
            this.Controls.Add(this.buttonNewArray);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonHypCheck);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormModelingDistr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Результаты моделирования";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.FormModelingDistr_HelpButtonClicked);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormModelingDistr_FormClosed);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonHypCheck;
        private System.Windows.Forms.Button buttonComplete;
        private System.Windows.Forms.Button buttonAgo;
        private System.Windows.Forms.Button buttonSaveArray;
        private System.Windows.Forms.RadioButton radioButtonDistrFunction;
        private System.Windows.Forms.RadioButton radioButtonDensity;
        private System.Windows.Forms.ListView listViewChar;
        private System.Windows.Forms.ColumnHeader columnHeaderChar;
        private System.Windows.Forms.ColumnHeader columnHeaderStatValue;
        private System.Windows.Forms.ColumnHeader columnHeaderAnalyt;
        private System.Windows.Forms.Button buttonNewArray;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonCorrF;
        private System.Windows.Forms.SaveFileDialog saveFileDialogSample;
        private System.Windows.Forms.Panel panelCanvas;
        private System.Windows.Forms.Label labelYName;
        private System.Windows.Forms.Label labelXName;
        private System.Windows.Forms.Label labelXMax;
        private System.Windows.Forms.Label labelXMin;
        private System.Windows.Forms.Label labelYMin;
        private System.Windows.Forms.Label labelYmax;
        private System.Windows.Forms.Label labelYAnalytMax;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Label label1;
    }
}