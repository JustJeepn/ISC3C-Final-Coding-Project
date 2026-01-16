namespace ISC3C_Final_Coding_Project
{
    partial class Form2
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
            returnButton = new Button();
            runButton = new Button();
            label2 = new Label();
            blueButton = new Button();
            redButton = new Button();
            greenButton = new Button();
            yellowButton = new Button();
            SuspendLayout();
            // 
            // returnButton
            // 
            returnButton.BackColor = Color.FromArgb(128, 255, 128);
            returnButton.Font = new Font("Arial Rounded MT Bold", 6.6F);
            returnButton.Location = new Point(12, 12);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(123, 58);
            returnButton.TabIndex = 1;
            returnButton.Text = "CLICK ME TO RETURN TO INSTRUCTION PAGE";
            returnButton.UseVisualStyleBackColor = false;
            returnButton.Click += returnButton_Click;
            // 
            // runButton
            // 
            runButton.BackColor = Color.FromArgb(128, 255, 128);
            runButton.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            runButton.Location = new Point(409, 124);
            runButton.Name = "runButton";
            runButton.Size = new Size(147, 81);
            runButton.TabIndex = 3;
            runButton.Text = "CLICK ME TO START THE GAME!";
            runButton.UseVisualStyleBackColor = false;
            runButton.Click += runButton_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.Black;
            label2.Location = new Point(281, 233);
            label2.Name = "label2";
            label2.Size = new Size(400, 400);
            label2.TabIndex = 5;
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // blueButton
            // 
            blueButton.BackColor = Color.DodgerBlue;
            blueButton.Location = new Point(313, 451);
            blueButton.Name = "blueButton";
            blueButton.Size = new Size(150, 150);
            blueButton.TabIndex = 6;
            blueButton.UseVisualStyleBackColor = false;
            // 
            // redButton
            // 
            redButton.BackColor = Color.Maroon;
            redButton.Location = new Point(313, 264);
            redButton.Name = "redButton";
            redButton.Size = new Size(150, 150);
            redButton.TabIndex = 7;
            redButton.UseVisualStyleBackColor = false;
            redButton.Click += redButton_Click;
            // 
            // greenButton
            // 
            greenButton.BackColor = Color.Green;
            greenButton.Location = new Point(500, 264);
            greenButton.Name = "greenButton";
            greenButton.Size = new Size(150, 150);
            greenButton.TabIndex = 8;
            greenButton.UseVisualStyleBackColor = false;
            // 
            // yellowButton
            // 
            yellowButton.BackColor = Color.Goldenrod;
            yellowButton.Location = new Point(500, 451);
            yellowButton.Name = "yellowButton";
            yellowButton.Size = new Size(150, 150);
            yellowButton.TabIndex = 9;
            yellowButton.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(963, 866);
            Controls.Add(yellowButton);
            Controls.Add(greenButton);
            Controls.Add(redButton);
            Controls.Add(blueButton);
            Controls.Add(label2);
            Controls.Add(runButton);
            Controls.Add(returnButton);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button startButton;
        private Button returnButton;
        private Button runButton;
        private Label label2;
        private Button blueButton;
        private Button redButton;
        private Button greenButton;
        private Button yellowButton;
    }
}