namespace Memory_Game_Mustafa_Abdullah
{
    partial class Giris
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
            this.Izgara_lbl = new System.Windows.Forms.Label();
            this.Mod_lbl = new System.Windows.Forms.Label();
            this.Dort_izgara = new System.Windows.Forms.CheckBox();
            this.Alti_izgara = new System.Windows.Forms.CheckBox();
            this.Sekiz_izgara = new System.Windows.Forms.CheckBox();
            this.Easy_Mod = new System.Windows.Forms.CheckBox();
            this.Normal_Mod = new System.Windows.Forms.CheckBox();
            this.Expert_Mod = new System.Windows.Forms.CheckBox();
            this.Start_btn = new System.Windows.Forms.Button();
            this.Clear_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Izgara_lbl
            // 
            this.Izgara_lbl.AutoSize = true;
            this.Izgara_lbl.Location = new System.Drawing.Point(36, 110);
            this.Izgara_lbl.Name = "Izgara_lbl";
            this.Izgara_lbl.Size = new System.Drawing.Size(75, 15);
            this.Izgara_lbl.TabIndex = 0;
            this.Izgara_lbl.Text = "izgara sayisi :";
            // 
            // Mod_lbl
            // 
            this.Mod_lbl.AutoSize = true;
            this.Mod_lbl.Location = new System.Drawing.Point(36, 147);
            this.Mod_lbl.Name = "Mod_lbl";
            this.Mod_lbl.Size = new System.Drawing.Size(38, 15);
            this.Mod_lbl.TabIndex = 1;
            this.Mod_lbl.Text = "Mod :";
            // 
            // Dort_izgara
            // 
            this.Dort_izgara.AutoSize = true;
            this.Dort_izgara.Location = new System.Drawing.Point(154, 110);
            this.Dort_izgara.Name = "Dort_izgara";
            this.Dort_izgara.Size = new System.Drawing.Size(32, 19);
            this.Dort_izgara.TabIndex = 2;
            this.Dort_izgara.Text = "4";
            this.Dort_izgara.UseVisualStyleBackColor = true;
            this.Dort_izgara.CheckedChanged += new System.EventHandler(this.Dort_izgara_CheckedChanged);
            // 
            // Alti_izgara
            // 
            this.Alti_izgara.AutoSize = true;
            this.Alti_izgara.Location = new System.Drawing.Point(225, 109);
            this.Alti_izgara.Name = "Alti_izgara";
            this.Alti_izgara.Size = new System.Drawing.Size(32, 19);
            this.Alti_izgara.TabIndex = 3;
            this.Alti_izgara.Text = "6";
            this.Alti_izgara.UseVisualStyleBackColor = true;
            this.Alti_izgara.CheckedChanged += new System.EventHandler(this.Alti_izgara_CheckedChanged);
            // 
            // Sekiz_izgara
            // 
            this.Sekiz_izgara.AutoSize = true;
            this.Sekiz_izgara.Location = new System.Drawing.Point(318, 110);
            this.Sekiz_izgara.Name = "Sekiz_izgara";
            this.Sekiz_izgara.Size = new System.Drawing.Size(32, 19);
            this.Sekiz_izgara.TabIndex = 4;
            this.Sekiz_izgara.Text = "8";
            this.Sekiz_izgara.UseVisualStyleBackColor = true;
            this.Sekiz_izgara.CheckedChanged += new System.EventHandler(this.Sekiz_izgara_CheckedChanged);
            // 
            // Easy_Mod
            // 
            this.Easy_Mod.AutoSize = true;
            this.Easy_Mod.Location = new System.Drawing.Point(137, 147);
            this.Easy_Mod.Name = "Easy_Mod";
            this.Easy_Mod.Size = new System.Drawing.Size(49, 19);
            this.Easy_Mod.TabIndex = 5;
            this.Easy_Mod.Text = "Easy";
            this.Easy_Mod.UseVisualStyleBackColor = true;
            this.Easy_Mod.CheckedChanged += new System.EventHandler(this.Easy_Mod_CheckedChanged);
            // 
            // Normal_Mod
            // 
            this.Normal_Mod.AutoSize = true;
            this.Normal_Mod.Location = new System.Drawing.Point(215, 147);
            this.Normal_Mod.Name = "Normal_Mod";
            this.Normal_Mod.Size = new System.Drawing.Size(66, 19);
            this.Normal_Mod.TabIndex = 6;
            this.Normal_Mod.Text = "Normal";
            this.Normal_Mod.UseVisualStyleBackColor = true;
            this.Normal_Mod.CheckedChanged += new System.EventHandler(this.Normal_Mod_CheckedChanged);
            // 
            // Expert_Mod
            // 
            this.Expert_Mod.AutoSize = true;
            this.Expert_Mod.Location = new System.Drawing.Point(318, 147);
            this.Expert_Mod.Name = "Expert_Mod";
            this.Expert_Mod.Size = new System.Drawing.Size(59, 19);
            this.Expert_Mod.TabIndex = 7;
            this.Expert_Mod.Text = "Expert";
            this.Expert_Mod.UseVisualStyleBackColor = true;
            this.Expert_Mod.CheckedChanged += new System.EventHandler(this.Expert_Mod_CheckedChanged);
            // 
            // Start_btn
            // 
            this.Start_btn.Location = new System.Drawing.Point(358, 212);
            this.Start_btn.Name = "Start_btn";
            this.Start_btn.Size = new System.Drawing.Size(75, 23);
            this.Start_btn.TabIndex = 8;
            this.Start_btn.Text = "Yeni Oyun";
            this.Start_btn.UseVisualStyleBackColor = true;
            this.Start_btn.Click += new System.EventHandler(this.Start_btn_Click);
            // 
            // Clear_btn
            // 
            this.Clear_btn.Location = new System.Drawing.Point(33, 209);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(54, 26);
            this.Clear_btn.TabIndex = 9;
            this.Clear_btn.Text = "Temizle";
            this.Clear_btn.UseVisualStyleBackColor = true;
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.Clear_btn);
            this.Controls.Add(this.Start_btn);
            this.Controls.Add(this.Expert_Mod);
            this.Controls.Add(this.Normal_Mod);
            this.Controls.Add(this.Easy_Mod);
            this.Controls.Add(this.Sekiz_izgara);
            this.Controls.Add(this.Alti_izgara);
            this.Controls.Add(this.Dort_izgara);
            this.Controls.Add(this.Mod_lbl);
            this.Controls.Add(this.Izgara_lbl);
            this.Name = "Giris";
            this.Text = "Giris";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Izgara_lbl;
        private Label Mod_lbl;
        private CheckBox Dort_izgara;
        private CheckBox Alti_izgara;
        private CheckBox Sekiz_izgara;
        private CheckBox Easy_Mod;
        private CheckBox Normal_Mod;
        private CheckBox Expert_Mod;
        private Button Start_btn;
        private Button Clear_btn;
    }
}