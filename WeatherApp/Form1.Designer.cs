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
            label1 = new Label();
            lblLocation = new Label();
            lblTemp = new Label();
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
            searchBtn.Click += searchBtn_Click;
            // 
            // localTBox
            // 
            localTBox.BackColor = Color.FromArgb(45, 45, 55);
            localTBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            localTBox.ForeColor = Color.LightGray;
            localTBox.Location = new Point(20, 21);
            localTBox.Name = "localTBox";
            localTBox.PlaceholderText = "Search Location";
            localTBox.Size = new Size(374, 32);
            localTBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(144, 207);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 1;
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLocation.ForeColor = Color.White;
            lblLocation.Location = new Point(19, 88);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(81, 37);
            lblLocation.TabIndex = 2;
            lblLocation.Text = "City:";
            // 
            // lblTemp
            // 
            lblTemp.AutoSize = true;
            lblTemp.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTemp.ForeColor = Color.White;
            lblTemp.Location = new Point(19, 165);
            lblTemp.Name = "lblTemp";
            lblTemp.Size = new Size(105, 37);
            lblTemp.TabIndex = 3;
            lblTemp.Text = "Temp:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 60, 70);
            ClientSize = new Size(623, 450);
            Controls.Add(lblTemp);
            Controls.Add(lblLocation);
            Controls.Add(label1);
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
        private Label label1;
        private Label lblLocation;
        private Label lblTemp;
    }
}
