
namespace GuessingGame
{
    partial class Form1
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.guessInput = new System.Windows.Forms.TextBox();
            this.guessButton = new System.Windows.Forms.Button();
            this.rangeOutput = new System.Windows.Forms.Label();
            this.hintOutput = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.guessDisplayOuput = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(252, 35);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(566, 83);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Guessing Game";
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.Location = new System.Drawing.Point(155, 238);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(780, 55);
            this.instructionLabel.TabIndex = 1;
            this.instructionLabel.Text = "Enter a number between 1 and 100";
            // 
            // guessInput
            // 
            this.guessInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessInput.Location = new System.Drawing.Point(298, 359);
            this.guessInput.Name = "guessInput";
            this.guessInput.Size = new System.Drawing.Size(100, 53);
            this.guessInput.TabIndex = 2;
            // 
            // guessButton
            // 
            this.guessButton.ForeColor = System.Drawing.Color.Black;
            this.guessButton.Location = new System.Drawing.Point(266, 454);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(182, 71);
            this.guessButton.TabIndex = 3;
            this.guessButton.Text = "Guess";
            this.guessButton.UseVisualStyleBackColor = true;
            this.guessButton.Click += new System.EventHandler(this.guessButton_Click);
            // 
            // rangeOutput
            // 
            this.rangeOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rangeOutput.Location = new System.Drawing.Point(559, 416);
            this.rangeOutput.Name = "rangeOutput";
            this.rangeOutput.Size = new System.Drawing.Size(331, 68);
            this.rangeOutput.TabIndex = 4;
            this.rangeOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hintOutput
            // 
            this.hintOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hintOutput.Location = new System.Drawing.Point(559, 484);
            this.hintOutput.Name = "hintOutput";
            this.hintOutput.Size = new System.Drawing.Size(331, 68);
            this.hintOutput.TabIndex = 5;
            this.hintOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resetButton
            // 
            this.resetButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.resetButton.ForeColor = System.Drawing.Color.Black;
            this.resetButton.Location = new System.Drawing.Point(844, 772);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(249, 71);
            this.resetButton.TabIndex = 6;
            this.resetButton.Text = "New Number";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // guessDisplayOuput
            // 
            this.guessDisplayOuput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessDisplayOuput.Location = new System.Drawing.Point(559, 348);
            this.guessDisplayOuput.Name = "guessDisplayOuput";
            this.guessDisplayOuput.Size = new System.Drawing.Size(331, 68);
            this.guessDisplayOuput.TabIndex = 7;
            this.guessDisplayOuput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 581);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 216);
            this.label1.TabIndex = 8;
            this.label1.Text = "Freezing - more than 50 away\r\nCold       - more than 25 away\r\nCool       - more t" +
    "han 15 away\r\nWarm     - more than 10 away\r\nHot         - more than 5 away\r\nBoili" +
    "ng    - between 1 and 4 away";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1118, 906);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guessDisplayOuput);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.hintOutput);
            this.Controls.Add(this.rangeOutput);
            this.Controls.Add(this.guessButton);
            this.Controls.Add(this.guessInput);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.titleLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Guessing Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.TextBox guessInput;
        private System.Windows.Forms.Button guessButton;
        private System.Windows.Forms.Label rangeOutput;
        private System.Windows.Forms.Label hintOutput;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label guessDisplayOuput;
        private System.Windows.Forms.Label label1;
    }
}

