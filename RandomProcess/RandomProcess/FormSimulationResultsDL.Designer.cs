namespace RandomProcess
{
    partial class FormSimulationResultsDL
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
            this.labelCharacteristics = new System.Windows.Forms.Label();
            this.labelProbabilisticCharacteristics = new System.Windows.Forms.Label();
            this.buttonSaveArray = new System.Windows.Forms.Button();
            this.buttonHypothesisTesting = new System.Windows.Forms.Button();
            this.buttonAgo = new System.Windows.Forms.Button();
            this.buttonComplete = new System.Windows.Forms.Button();
            this.radioButtonDistributionFunction = new System.Windows.Forms.RadioButton();
            this.radioButtonDensityDistribution = new System.Windows.Forms.RadioButton();
            this.radioButtonCorrelationFunction = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // labelCharacteristics
            // 
            this.labelCharacteristics.AutoSize = true;
            this.labelCharacteristics.Location = new System.Drawing.Point(23, 36);
            this.labelCharacteristics.Name = "labelCharacteristics";
            this.labelCharacteristics.Size = new System.Drawing.Size(120, 17);
            this.labelCharacteristics.TabIndex = 0;
            this.labelCharacteristics.Text = "Характеристики:";
            // 
            // labelProbabilisticCharacteristics
            // 
            this.labelProbabilisticCharacteristics.AutoSize = true;
            this.labelProbabilisticCharacteristics.Location = new System.Drawing.Point(404, 36);
            this.labelProbabilisticCharacteristics.Name = "labelProbabilisticCharacteristics";
            this.labelProbabilisticCharacteristics.Size = new System.Drawing.Size(225, 17);
            this.labelProbabilisticCharacteristics.TabIndex = 1;
            this.labelProbabilisticCharacteristics.Text = "Вероятностные характеристики:";
            // 
            // buttonSaveArray
            // 
            this.buttonSaveArray.Location = new System.Drawing.Point(26, 397);
            this.buttonSaveArray.Name = "buttonSaveArray";
            this.buttonSaveArray.Size = new System.Drawing.Size(107, 70);
            this.buttonSaveArray.TabIndex = 2;
            this.buttonSaveArray.Text = "Сохранить выборку в файл";
            this.buttonSaveArray.UseVisualStyleBackColor = true;
            // 
            // buttonHypothesisTesting
            // 
            this.buttonHypothesisTesting.Location = new System.Drawing.Point(193, 421);
            this.buttonHypothesisTesting.Name = "buttonHypothesisTesting";
            this.buttonHypothesisTesting.Size = new System.Drawing.Size(134, 46);
            this.buttonHypothesisTesting.TabIndex = 3;
            this.buttonHypothesisTesting.Text = "Проверка гипотезы";
            this.buttonHypothesisTesting.UseVisualStyleBackColor = true;
            // 
            // buttonAgo
            // 
            this.buttonAgo.Location = new System.Drawing.Point(395, 435);
            this.buttonAgo.Name = "buttonAgo";
            this.buttonAgo.Size = new System.Drawing.Size(107, 32);
            this.buttonAgo.TabIndex = 4;
            this.buttonAgo.Text = "Назад";
            this.buttonAgo.UseVisualStyleBackColor = true;
            // 
            // buttonComplete
            // 
            this.buttonComplete.Location = new System.Drawing.Point(556, 435);
            this.buttonComplete.Name = "buttonComplete";
            this.buttonComplete.Size = new System.Drawing.Size(110, 32);
            this.buttonComplete.TabIndex = 5;
            this.buttonComplete.Text = "Завершить";
            this.buttonComplete.UseVisualStyleBackColor = true;
            // 
            // radioButtonDistributionFunction
            // 
            this.radioButtonDistributionFunction.AutoSize = true;
            this.radioButtonDistributionFunction.Location = new System.Drawing.Point(441, 332);
            this.radioButtonDistributionFunction.Name = "radioButtonDistributionFunction";
            this.radioButtonDistributionFunction.Size = new System.Drawing.Size(195, 21);
            this.radioButtonDistributionFunction.TabIndex = 6;
            this.radioButtonDistributionFunction.TabStop = true;
            this.radioButtonDistributionFunction.Text = "Функция распределения";
            this.radioButtonDistributionFunction.UseVisualStyleBackColor = true;
            // 
            // radioButtonDensityDistribution
            // 
            this.radioButtonDensityDistribution.AutoSize = true;
            this.radioButtonDensityDistribution.Location = new System.Drawing.Point(441, 359);
            this.radioButtonDensityDistribution.Name = "radioButtonDensityDistribution";
            this.radioButtonDensityDistribution.Size = new System.Drawing.Size(206, 21);
            this.radioButtonDensityDistribution.TabIndex = 7;
            this.radioButtonDensityDistribution.TabStop = true;
            this.radioButtonDensityDistribution.Text = "Плотность распределения";
            this.radioButtonDensityDistribution.UseVisualStyleBackColor = true;
            // 
            // radioButtonCorrelationFunction
            // 
            this.radioButtonCorrelationFunction.AutoSize = true;
            this.radioButtonCorrelationFunction.Location = new System.Drawing.Point(441, 386);
            this.radioButtonCorrelationFunction.Name = "radioButtonCorrelationFunction";
            this.radioButtonCorrelationFunction.Size = new System.Drawing.Size(203, 21);
            this.radioButtonCorrelationFunction.TabIndex = 8;
            this.radioButtonCorrelationFunction.TabStop = true;
            this.radioButtonCorrelationFunction.Text = "Корреляционная функция";
            this.radioButtonCorrelationFunction.UseVisualStyleBackColor = true;
            // 
            // FormSimulationResultsDL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 493);
            this.Controls.Add(this.radioButtonCorrelationFunction);
            this.Controls.Add(this.radioButtonDensityDistribution);
            this.Controls.Add(this.radioButtonDistributionFunction);
            this.Controls.Add(this.buttonComplete);
            this.Controls.Add(this.buttonAgo);
            this.Controls.Add(this.buttonHypothesisTesting);
            this.Controls.Add(this.buttonSaveArray);
            this.Controls.Add(this.labelProbabilisticCharacteristics);
            this.Controls.Add(this.labelCharacteristics);
            this.Name = "FormSimulationResultsDL";
            this.Text = "Результаты моделирования";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCharacteristics;
        private System.Windows.Forms.Label labelProbabilisticCharacteristics;
        private System.Windows.Forms.Button buttonSaveArray;
        private System.Windows.Forms.Button buttonHypothesisTesting;
        private System.Windows.Forms.Button buttonAgo;
        private System.Windows.Forms.Button buttonComplete;
        private System.Windows.Forms.RadioButton radioButtonDistributionFunction;
        private System.Windows.Forms.RadioButton radioButtonDensityDistribution;
        private System.Windows.Forms.RadioButton radioButtonCorrelationFunction;
    }
}