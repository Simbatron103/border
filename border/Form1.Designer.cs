namespace border
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Location = new Point(755, 1);
            label2.Name = "label2";
            label2.Size = new Size(18, 23);
            label2.TabIndex = 1;
            label2.Text = "_";
            label2.Click += label2_Click;
            label2.MouseClick += Label2_MouseClick;
            // 
            // label3
            // 
            label3.BackColor = Color.Red;
            label3.Location = new Point(779, 1);
            label3.Name = "label3";
            label3.Size = new Size(24, 23);
            label3.TabIndex = 2;
            label3.Text = "X";
            label3.Click += label3_Click;
            label3.MouseClick += Label3_MouseClick;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Location = new Point(-1, 1);
            label1.Name = "label1";
            label1.Size = new Size(750, 23);
            label1.TabIndex = 3;
            label1.Text = "Border";
            label1.MouseDown += Label1_MouseDown;
            label1.MouseMove += Label1_MouseMove;
            label1.MouseUp += Label1_MouseUp;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private Label label3;
        private Label label1;
    }
}
