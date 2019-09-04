namespace VectorLayerConversion
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputFileTextBox = new System.Windows.Forms.TextBox();
            this.selectInputFileButton = new System.Windows.Forms.Button();
            this.outputFileTextBox = new System.Windows.Forms.TextBox();
            this.selectOutputFileDirectoryButton = new System.Windows.Forms.Button();
            this.radioButtonsGroupBox = new System.Windows.Forms.GroupBox();
            this.gmlRadioButton = new System.Windows.Forms.RadioButton();
            this.geojsonRadioButton = new System.Windows.Forms.RadioButton();
            this.convertButton = new System.Windows.Forms.Button();
            this.deleteInputFilecheckBox = new System.Windows.Forms.CheckBox();
            this.radioButtonsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputFileTextBox
            // 
            this.inputFileTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputFileTextBox.Location = new System.Drawing.Point(12, 23);
            this.inputFileTextBox.Name = "inputFileTextBox";
            this.inputFileTextBox.Size = new System.Drawing.Size(401, 24);
            this.inputFileTextBox.TabIndex = 0;
            // 
            // selectInputFileButton
            // 
            this.selectInputFileButton.Location = new System.Drawing.Point(431, 24);
            this.selectInputFileButton.Name = "selectInputFileButton";
            this.selectInputFileButton.Size = new System.Drawing.Size(37, 23);
            this.selectInputFileButton.TabIndex = 2;
            this.selectInputFileButton.Text = ". . .";
            this.selectInputFileButton.UseVisualStyleBackColor = true;
            this.selectInputFileButton.Click += new System.EventHandler(this.SelectInputFileButton_Click);
            // 
            // outputFileTextBox
            // 
            this.outputFileTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputFileTextBox.Location = new System.Drawing.Point(12, 67);
            this.outputFileTextBox.Name = "outputFileTextBox";
            this.outputFileTextBox.Size = new System.Drawing.Size(401, 24);
            this.outputFileTextBox.TabIndex = 1;
            // 
            // selectOutputFileDirectoryButton
            // 
            this.selectOutputFileDirectoryButton.Location = new System.Drawing.Point(431, 68);
            this.selectOutputFileDirectoryButton.Name = "selectOutputFileDirectoryButton";
            this.selectOutputFileDirectoryButton.Size = new System.Drawing.Size(37, 23);
            this.selectOutputFileDirectoryButton.TabIndex = 3;
            this.selectOutputFileDirectoryButton.Text = ". . .";
            this.selectOutputFileDirectoryButton.UseVisualStyleBackColor = true;
            this.selectOutputFileDirectoryButton.Click += new System.EventHandler(this.SelectOutputFileDirectoryButton_Click);
            // 
            // radioButtonsGroupBox
            // 
            this.radioButtonsGroupBox.Controls.Add(this.gmlRadioButton);
            this.radioButtonsGroupBox.Controls.Add(this.geojsonRadioButton);
            this.radioButtonsGroupBox.Location = new System.Drawing.Point(362, 140);
            this.radioButtonsGroupBox.Name = "radioButtonsGroupBox";
            this.radioButtonsGroupBox.Size = new System.Drawing.Size(106, 58);
            this.radioButtonsGroupBox.TabIndex = 5;
            this.radioButtonsGroupBox.TabStop = false;
            // 
            // gmlRadioButton
            // 
            this.gmlRadioButton.AutoSize = true;
            this.gmlRadioButton.Location = new System.Drawing.Point(0, 35);
            this.gmlRadioButton.Name = "gmlRadioButton";
            this.gmlRadioButton.Size = new System.Drawing.Size(48, 17);
            this.gmlRadioButton.TabIndex = 1;
            this.gmlRadioButton.Text = "GML";
            this.gmlRadioButton.UseVisualStyleBackColor = true;
            this.gmlRadioButton.CheckedChanged += new System.EventHandler(this.GmlRadioButton_CheckedChanged);
            // 
            // geojsonRadioButton
            // 
            this.geojsonRadioButton.AutoSize = true;
            this.geojsonRadioButton.Checked = true;
            this.geojsonRadioButton.Location = new System.Drawing.Point(0, 9);
            this.geojsonRadioButton.Name = "geojsonRadioButton";
            this.geojsonRadioButton.Size = new System.Drawing.Size(67, 17);
            this.geojsonRadioButton.TabIndex = 0;
            this.geojsonRadioButton.TabStop = true;
            this.geojsonRadioButton.Text = "GeoJson";
            this.geojsonRadioButton.UseVisualStyleBackColor = true;
            this.geojsonRadioButton.CheckedChanged += new System.EventHandler(this.GeojsonRadioButton_CheckedChanged);
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(224, 188);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(75, 23);
            this.convertButton.TabIndex = 6;
            this.convertButton.Text = "Go";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // deleteInputFilecheckBox
            // 
            this.deleteInputFilecheckBox.AutoSize = true;
            this.deleteInputFilecheckBox.Location = new System.Drawing.Point(235, 150);
            this.deleteInputFilecheckBox.Name = "deleteInputFilecheckBox";
            this.deleteInputFilecheckBox.Size = new System.Drawing.Size(121, 17);
            this.deleteInputFilecheckBox.TabIndex = 7;
            this.deleteInputFilecheckBox.Text = "Удалить исх. файл";
            this.deleteInputFilecheckBox.UseVisualStyleBackColor = true;
            this.deleteInputFilecheckBox.CheckedChanged += new System.EventHandler(this.DeleteInputFileCheckBox_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 223);
            this.Controls.Add(this.deleteInputFilecheckBox);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.radioButtonsGroupBox);
            this.Controls.Add(this.selectOutputFileDirectoryButton);
            this.Controls.Add(this.selectInputFileButton);
            this.Controls.Add(this.outputFileTextBox);
            this.Controls.Add(this.inputFileTextBox);
            this.Name = "MainForm";
            this.Text = "Конвертатор";
            this.radioButtonsGroupBox.ResumeLayout(false);
            this.radioButtonsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputFileTextBox;
        private System.Windows.Forms.Button selectInputFileButton;
        private System.Windows.Forms.TextBox outputFileTextBox;
        private System.Windows.Forms.Button selectOutputFileDirectoryButton;
        private System.Windows.Forms.GroupBox radioButtonsGroupBox;
        private System.Windows.Forms.RadioButton gmlRadioButton;
        private System.Windows.Forms.RadioButton geojsonRadioButton;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.CheckBox deleteInputFilecheckBox;
    }
}

