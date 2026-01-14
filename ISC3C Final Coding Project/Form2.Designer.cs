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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            returnButton = new Button();
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
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(963, 866);
            Controls.Add(returnButton);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button startButton;
        private Button returnButton;
    }
}