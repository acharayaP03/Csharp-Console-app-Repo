namespace CurrencyConverter
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CounterLabel = new Label();
            IncreaseCounterButton = new Button();
            HideButtonCheckbox = new CheckBox();
            SuspendLayout();
            // 
            // CounterLabel
            // 
            CounterLabel.AutoSize = true;
            CounterLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            CounterLabel.Location = new Point(62, 62);
            CounterLabel.Name = "CounterLabel";
            CounterLabel.Size = new Size(33, 37);
            CounterLabel.TabIndex = 0;
            CounterLabel.Text = "0";
            // 
            // IncreaseCounterButton
            // 
            IncreaseCounterButton.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            IncreaseCounterButton.Location = new Point(194, 63);
            IncreaseCounterButton.Name = "IncreaseCounterButton";
            IncreaseCounterButton.Size = new Size(174, 36);
            IncreaseCounterButton.TabIndex = 1;
            IncreaseCounterButton.Text = "Increment";
            IncreaseCounterButton.UseVisualStyleBackColor = true;
            IncreaseCounterButton.Click += IncreaseCounterButton_Click;
            // 
            // HideButtonCheckbox
            // 
            HideButtonCheckbox.AutoSize = true;
            HideButtonCheckbox.Font = new Font("Segoe UI", 20F);
            HideButtonCheckbox.ImageAlign = ContentAlignment.BottomCenter;
            HideButtonCheckbox.Location = new Point(71, 125);
            HideButtonCheckbox.Name = "HideButtonCheckbox";
            HideButtonCheckbox.Size = new Size(280, 41);
            HideButtonCheckbox.TabIndex = 2;
            HideButtonCheckbox.Text = "Hide or show button";
            HideButtonCheckbox.UseVisualStyleBackColor = true;
            HideButtonCheckbox.CheckedChanged += HideButtonChecknbox_CheckboxChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 563);
            Controls.Add(HideButtonCheckbox);
            Controls.Add(IncreaseCounterButton);
            Controls.Add(CounterLabel);
            Name = "MainForm";
            Text = "Currency converter";
            Load += MainFormLoad;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CounterLabel;
        private Button IncreaseCounterButton;
        private CheckBox HideButtonCheckbox;
    }
}
