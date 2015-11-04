namespace RandomProcess
{
    partial class FormModelingCor
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
            this.buttonSaveArray = new System.Windows.Forms.Button();
            this.buttonAgo = new System.Windows.Forms.Button();
            this.buttonComplete = new System.Windows.Forms.Button();
            this.radioButtonDistrFunction = new System.Windows.Forms.RadioButton();
            this.radioButtonDensity = new System.Windows.Forms.RadioButton();
            this.listViewChar = new System.Windows.Forms.ListView();
            this.columnHeaderChar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelCanvas = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonNewArray = new System.Windows.Forms.Button();
            this.radioButtonCorFunc = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSaveArray
            // 
            this.buttonSaveArray.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonSaveArray.Location = new System.Drawing.Point(18, 416);
            this.buttonSaveArray.Name = "buttonSaveArray";
            this.buttonSaveArray.Size = new System.Drawing.Size(197, 30);
            this.buttonSaveArray.TabIndex = 0;
            this.buttonSaveArray.Text = "Сохранить выборку в файл";
            this.buttonSaveArray.UseVisualStyleBackColor = true;
            // 
            // buttonAgo
            // 
            this.buttonAgo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAgo.Location = new System.Drawing.Point(645, 410);
            this.buttonAgo.Name = "buttonAgo";
            this.buttonAgo.Size = new System.Drawing.Size(117, 30);
            this.buttonAgo.TabIndex = 1;
            this.buttonAgo.Text = "Назад";
            this.buttonAgo.UseVisualStyleBackColor = true;
            // 
            // buttonComplete
            // 
            this.buttonComplete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonComplete.Location = new System.Drawing.Point(780, 410);
            this.buttonComplete.Name = "buttonComplete";
            this.buttonComplete.Size = new System.Drawing.Size(105, 30);
            this.buttonComplete.TabIndex = 2;
            this.buttonComplete.Text = "Завершить";
            this.buttonComplete.UseVisualStyleBackColor = true;
            // 
            // radioButtonDistrFunction
            // 
            this.radioButtonDistrFunction.AutoSize = true;
            this.radioButtonDistrFunction.Location = new System.Drawing.Point(24, 328);
            this.radioButtonDistrFunction.Name = "radioButtonDistrFunction";
            this.radioButtonDistrFunction.Size = new System.Drawing.Size(195, 21);
            this.radioButtonDistrFunction.TabIndex = 5;
            this.radioButtonDistrFunction.Text = "Функция распределения";
            this.radioButtonDistrFunction.UseVisualStyleBackColor = true;
            // 
            // radioButtonDensity
            // 
            this.radioButtonDensity.AutoSize = true;
            this.radioButtonDensity.Checked = true;
            this.radioButtonDensity.Location = new System.Drawing.Point(24, 301);
            this.radioButtonDensity.Name = "radioButtonDensity";
            this.radioButtonDensity.Size = new System.Drawing.Size(99, 21);
            this.radioButtonDensity.TabIndex = 6;
            this.radioButtonDensity.TabStop = true;
            this.radioButtonDensity.Text = "Плотность";
            this.radioButtonDensity.UseVisualStyleBackColor = true;
            // 
            // listViewChar
            // 
            this.listViewChar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderChar,
            this.columnHeaderValue});
            this.listViewChar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewChar.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.listViewChar.Location = new System.Drawing.Point(3, 18);
            this.listViewChar.Name = "listViewChar";
            this.listViewChar.Size = new System.Drawing.Size(380, 171);
            this.listViewChar.TabIndex = 7;
            this.listViewChar.UseCompatibleStateImageBehavior = false;
            this.listViewChar.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderChar
            // 
            this.columnHeaderChar.Text = "Характеристика";
            this.columnHeaderChar.Width = 157;
            // 
            // columnHeaderValue
            // 
            this.columnHeaderValue.Text = "Статистическая оценка";
            this.columnHeaderValue.Width = 213;
            // 
            // panelCanvas
            // 
            this.panelCanvas.Location = new System.Drawing.Point(11, 31);
            this.panelCanvas.Name = "panelCanvas";
            this.panelCanvas.Size = new System.Drawing.Size(455, 252);
            this.panelCanvas.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonCorFunc);
            this.groupBox1.Controls.Add(this.radioButtonDistrFunction);
            this.groupBox1.Controls.Add(this.panelCanvas);
            this.groupBox1.Controls.Add(this.radioButtonDensity);
            this.groupBox1.Location = new System.Drawing.Point(404, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 388);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вероятностные характеристики";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listViewChar);
            this.groupBox2.Location = new System.Drawing.Point(12, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 192);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Статистические оценки";
            // 
            // buttonNewArray
            // 
            this.buttonNewArray.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonNewArray.Location = new System.Drawing.Point(18, 378);
            this.buttonNewArray.Name = "buttonNewArray";
            this.buttonNewArray.Size = new System.Drawing.Size(197, 29);
            this.buttonNewArray.TabIndex = 11;
            this.buttonNewArray.Text = "Новая выборка";
            this.buttonNewArray.UseVisualStyleBackColor = true;
            // 
            // radioButtonCorFunc
            // 
            this.radioButtonCorFunc.AutoSize = true;
            this.radioButtonCorFunc.Location = new System.Drawing.Point(24, 355);
            this.radioButtonCorFunc.Name = "radioButtonCorFunc";
            this.radioButtonCorFunc.Size = new System.Drawing.Size(203, 21);
            this.radioButtonCorFunc.TabIndex = 9;
            this.radioButtonCorFunc.Text = "Корреляционная функция";
            this.radioButtonCorFunc.UseVisualStyleBackColor = true;
            // 
            // FormModelingCor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 452);
            this.Controls.Add(this.buttonNewArray);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonComplete);
            this.Controls.Add(this.buttonAgo);
            this.Controls.Add(this.buttonSaveArray);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormModelingCor";
            this.Text = "Результаты моделирования";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSaveArray;
        private System.Windows.Forms.Button buttonAgo;
        private System.Windows.Forms.Button buttonComplete;
        private System.Windows.Forms.RadioButton radioButtonDistrFunction;
        private System.Windows.Forms.RadioButton radioButtonDensity;
        private System.Windows.Forms.ListView listViewChar;
        private System.Windows.Forms.ColumnHeader columnHeaderChar;
        private System.Windows.Forms.ColumnHeader columnHeaderValue;
        private System.Windows.Forms.Panel panelCanvas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonNewArray;
        private System.Windows.Forms.RadioButton radioButtonCorFunc;
    }
}