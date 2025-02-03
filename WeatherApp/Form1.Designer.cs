namespace WeatherApp
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
            panel1 = new Panel();
            searchBtn = new Button();
            localTBox = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.FromArgb(50, 50, 55);
            panel1.Controls.Add(searchBtn);
            panel1.Controls.Add(localTBox);
            panel1.Location = new Point(-1, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(625, 74);
            panel1.TabIndex = 0;
            // 
            // searchBtn
            // 
            searchBtn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBtn.Location = new Point(436, 21);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(171, 32);
            searchBtn.TabIndex = 1;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            // 
            // localTBox
            // 
            localTBox.BackColor = Color.FromArgb(45, 45, 55);
            localTBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            localTBox.ForeColor = Color.LightGray;
            localTBox.Location = new Point(20, 21);
            localTBox.Name = "localTBox";
            localTBox.PlaceholderText = "Location";
            localTBox.Size = new Size(374, 32);
            localTBox.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 60, 70);
            ClientSize = new Size(623, 450);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox localTBox;
        private Button searchBtn;
    }
}
