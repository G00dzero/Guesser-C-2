namespace Guesser__C__2
{
    partial class Form1
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
            guessTextBox = new TextBox();
            guessButton = new Button();
            statusLabel = new Label();
            SuspendLayout();
            // 
            // guessTextBox
            // 
            guessTextBox.Location = new Point(330, 194);
            guessTextBox.Name = "guessTextBox";
            guessTextBox.Size = new Size(125, 27);
            guessTextBox.TabIndex = 0;
            // 
            // guessButton
            // 
            guessButton.BackColor = SystemColors.ActiveCaption;
            guessButton.Cursor = Cursors.Hand;
            guessButton.FlatStyle = FlatStyle.Popup;
            guessButton.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guessButton.ForeColor = SystemColors.ButtonHighlight;
            guessButton.Location = new Point(342, 242);
            guessButton.Name = "guessButton";
            guessButton.Size = new Size(94, 29);
            guessButton.TabIndex = 1;
            guessButton.Text = "Guess";
            guessButton.UseVisualStyleBackColor = false;
            guessButton.Click += guessButton_Click_1;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.BorderStyle = BorderStyle.Fixed3D;
            statusLabel.Font = new Font("Elephant", 11.999999F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            statusLabel.ForeColor = SystemColors.ControlLightLight;
            statusLabel.Location = new Point(25, 141);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(217, 28);
            statusLabel.TabIndex = 2;
            statusLabel.Text = "Guess the Number\r\n";
            statusLabel.TextAlign = ContentAlignment.TopCenter;
            statusLabel.Click += guessButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(statusLabel);
            Controls.Add(guessButton);
            Controls.Add(guessTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox guessTextBox;
        private Button guessButton;
        private Label statusLabel;
    }
}
