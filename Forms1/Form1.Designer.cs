namespace Forms1
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
            IblDisplay = new Label();
            SuspendLayout();
            // 
            // IblDisplay
            // 
            IblDisplay.AutoSize = true;
            IblDisplay.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IblDisplay.Location = new Point(363, 201);
            IblDisplay.Name = "IblDisplay";
            IblDisplay.Size = new Size(53, 17);
            IblDisplay.TabIndex = 0;
            IblDisplay.Text = "level";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(IblDisplay);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label IblDisplay;
    }
}
