namespace Ausgabe
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
            CmdAnzeigen1 = new Button();
            CmdAnzeigen2 = new Button();
            CmdAnzeigen3 = new Button();
            CmdAnzeigen4 = new Button();
            LblAnzeige = new Label();
            CmdEnde = new Button();
            SuspendLayout();
            // 
            // CmdAnzeigen1
            // 
            CmdAnzeigen1.Location = new Point(280, 90);
            CmdAnzeigen1.Name = "CmdAnzeigen1";
            CmdAnzeigen1.Size = new Size(75, 25);
            CmdAnzeigen1.TabIndex = 0;
            CmdAnzeigen1.Text = "Anzeigen 1";
            CmdAnzeigen1.UseVisualStyleBackColor = true;
            CmdAnzeigen1.Click += CmdAnzeigen1_Click;
            // 
            // CmdAnzeigen2
            // 
            CmdAnzeigen2.Location = new Point(280, 130);
            CmdAnzeigen2.Name = "CmdAnzeigen2";
            CmdAnzeigen2.Size = new Size(75, 25);
            CmdAnzeigen2.TabIndex = 1;
            CmdAnzeigen2.Text = "Anzeigen 2";
            CmdAnzeigen2.UseVisualStyleBackColor = true;
            CmdAnzeigen2.Click += CmdAnzeigen2_Click;
            // 
            // CmdAnzeigen3
            // 
            CmdAnzeigen3.Location = new Point(280, 170);
            CmdAnzeigen3.Name = "CmdAnzeigen3";
            CmdAnzeigen3.Size = new Size(75, 25);
            CmdAnzeigen3.TabIndex = 2;
            CmdAnzeigen3.Text = "Anzeigen 3";
            CmdAnzeigen3.UseVisualStyleBackColor = true;
            CmdAnzeigen3.Click += CmdAnzeigen3_Click;
            // 
            // CmdAnzeigen4
            // 
            CmdAnzeigen4.Location = new Point(280, 210);
            CmdAnzeigen4.Name = "CmdAnzeigen4";
            CmdAnzeigen4.Size = new Size(75, 25);
            CmdAnzeigen4.TabIndex = 3;
            CmdAnzeigen4.Text = "Anzeigen 4";
            CmdAnzeigen4.UseVisualStyleBackColor = true;
            CmdAnzeigen4.Click += CmdAnzeigen4_Click;
            // 
            // LblAnzeige
            // 
            LblAnzeige.AutoSize = true;
            LblAnzeige.Location = new Point(30, 30);
            LblAnzeige.Name = "LblAnzeige";
            LblAnzeige.Size = new Size(0, 15);
            LblAnzeige.TabIndex = 4;
            // 
            // CmdEnde
            // 
            CmdEnde.Location = new Point(30, 210);
            CmdEnde.Name = "CmdEnde";
            CmdEnde.Size = new Size(75, 25);
            CmdEnde.TabIndex = 5;
            CmdEnde.Text = "Ende";
            CmdEnde.UseVisualStyleBackColor = true;
            CmdEnde.Click += CmdEnde_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 261);
            Controls.Add(CmdEnde);
            Controls.Add(LblAnzeige);
            Controls.Add(CmdAnzeigen4);
            Controls.Add(CmdAnzeigen3);
            Controls.Add(CmdAnzeigen2);
            Controls.Add(CmdAnzeigen1);
            Name = "Form1";
            Text = "Ausgaben";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdAnzeigen1;
        private Button CmdAnzeigen2;
        private Button CmdAnzeigen3;
        private Button CmdAnzeigen4;
        private Label LblAnzeige;
        private Button CmdEnde;
    }
}
