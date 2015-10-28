namespace RandomProcess
{
    partial class FormSimulationResultsCF
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
            this.buttonSaveArray = new System.Windows.Forms.Button();
            this.buttonAgo = new System.Windows.Forms.Button();
            this.buttonComplete = new System.Windows.Forms.Button();
            this.labelStatisticalEvaluation = new System.Windows.Forms.Label();
            this.labelProbabilisticCharacteristics = new System.Windows.Forms.Label();
            this.radioButtonDistributionFunction = new System.Windows.Forms.RadioButton();
            this.radioButtonDensity = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // buttonSaveArray
            // 
            this.buttonSaveArray.Location = new System.Drawing.Point(123, 397);
            this.buttonSaveArray.Name = "buttonSaveArray";
            this.buttonSaveArray.Size = new System.Drawing.Size(118, 73);
            this.buttonSaveArray.TabIndex = 0;
            this.buttonSaveArray.Text = "Сохранить выборку в файл";
            this.buttonSaveArray.UseVisualStyleBackColor = true;
            // 
            // buttonAgo
            // 
            this.buttonAgo.Location = new System.Drawing.Point(363, 440);
            this.buttonAgo.Name = "buttonAgo";
            this.buttonAgo.Size = new System.Drawing.Size(117, 30);
            this.buttonAgo.TabIndex = 1;
            this.buttonAgo.Text = "Назад";
            this.buttonAgo.UseVisualStyleBackColor = true;
            // 
            // buttonComplete
            // 
            this.buttonComplete.Location = new System.Drawing.Point(606, 440);
            this.buttonComplete.Name = "buttonComplete";
            this.buttonComplete.Size = new System.Drawing.Size(105, 30);
            this.buttonComplete.TabIndex = 2;
            this.buttonComplete.Text = "Завершить";
            this.buttonComplete.UseVisualStyleBackColor = true;
            // 
            // labelStatisticalEvaluation
            // 
            this.labelStatisticalEvaluation.AutoSize = true;
            this.labelStatisticalEvaluation.Location = new System.Drawing.Point(120, 48);
            this.labelStatisticalEvaluation.Name = "labelStatisticalEvaluation";
            this.labelStatisticalEvaluation.Size = new System.Drawing.Size(170, 17);
            this.labelStatisticalEvaluation.TabIndex = 3;
            this.labelStatisticalEvaluation.Text = "Статистические оценки:";
            // 
            // labelProbabilisticCharacteristics
            // 
            this.labelProbabilisticCharacteristics.AutoSize = true;
            this.labelProbabilisticCharacteristics.Location = new System.Drawing.Point(402, 48);
            this.labelProbabilisticCharacteristics.Name = "labelProbabilisticCharacteristics";
            this.labelProbabilisticCharacteristics.Size = new System.Drawing.Size(225, 17);
            this.labelProbabilisticCharacteristics.TabIndex = 4;
            this.labelProbabilisticCharacteristics.Text = "Вероятностные характеристики:";
            // 
            // radioButtonDistributionFunction
            // 
            this.radioButtonDistributionFunction.AutoSize = true;
            this.radioButtonDistributionFunction.Location = new System.Drawing.Point(405, 354);
            this.radioButtonDistributionFunction.Name = "radioButtonDistributionFunction";
            this.radioButtonDistributionFunction.Size = new System.Drawing.Size(195, 21);
            this.radioButtonDistributionFunction.TabIndex = 5;
            this.radioButtonDistributionFunction.TabStop = true;
            this.radioButtonDistributionFunction.Text = "Функция распределения";
            this.radioButtonDistributionFunction.UseVisualStyleBackColor = true;
            // 
            // radioButtonDensity
            // 
            this.radioButtonDensity.AutoSize = true;
            this.radioButtonDensity.Location = new System.Drawing.Point(405, 397);
            this.radioButtonDensity.Name = "radioButtonDensity";
            this.radioButtonDensity.Size = new System.Drawing.Size(99, 21);
            this.radioButtonDensity.TabIndex = 6;
            this.radioButtonDensity.TabStop = true;
            this.radioButtonDensity.Text = "Плотность";
            this.radioButtonDensity.UseVisualStyleBackColor = true;
            // 
            // FormSimulationResultsCF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 511);
            this.Controls.Add(this.radioButtonDensity);
            this.Controls.Add(this.radioButtonDistributionFunction);
            this.Controls.Add(this.labelProbabilisticCharacteristics);
            this.Controls.Add(this.labelStatisticalEvaluation);
            this.Controls.Add(this.buttonComplete);
            this.Controls.Add(this.buttonAgo);
            this.Controls.Add(this.buttonSaveArray);
            this.Name = "FormSimulationResultsCF";
            this.Text = "Результаты моделирования";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSaveArray;
        private System.Windows.Forms.Button buttonAgo;
        private System.Windows.Forms.Button buttonComplete;
        private System.Windows.Forms.Label labelStatisticalEvaluation;
        private System.Windows.Forms.Label labelProbabilisticCharacteristics;
        private System.Windows.Forms.RadioButton radioButtonDistributionFunction;
        private System.Windows.Forms.RadioButton radioButtonDensity;
    }
}