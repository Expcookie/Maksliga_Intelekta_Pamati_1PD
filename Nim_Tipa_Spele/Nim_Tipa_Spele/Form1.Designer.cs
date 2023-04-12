namespace Nim_Tipa_Spele
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
            this.Nonemt_Poga = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Punkti = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Ievads = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Nonemt_Poga
            // 
            this.Nonemt_Poga.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Nonemt_Poga.Location = new System.Drawing.Point(414, 185);
            this.Nonemt_Poga.Name = "Nonemt_Poga";
            this.Nonemt_Poga.Size = new System.Drawing.Size(102, 50);
            this.Nonemt_Poga.TabIndex = 0;
            this.Nonemt_Poga.Text = "Nonemt";
            this.Nonemt_Poga.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(4, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kaulinu atlikusais daudzums:";
            // 
            // Punkti
            // 
            this.Punkti.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.Punkti.Location = new System.Drawing.Point(294, 197);
            this.Punkti.Multiline = true;
            this.Punkti.Name = "Punkti";
            this.Punkti.ReadOnly = true;
            this.Punkti.Size = new System.Drawing.Size(34, 38);
            this.Punkti.TabIndex = 2;
            this.Punkti.Text = "0";
            this.Punkti.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(504, 78);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sveicināts manā spēlē!\r\nLūdzu izvēlies cik kauliņus to noņemsi no kaudzes.\r\n(Izvē" +
    "lies skaitli no 1-3 ieskaitot)";
            // 
            // Ievads
            // 
            this.Ievads.Location = new System.Drawing.Point(17, 99);
            this.Ievads.Multiline = true;
            this.Ievads.Name = "Ievads";
            this.Ievads.Size = new System.Drawing.Size(100, 50);
            this.Ievads.TabIndex = 4;
            this.Ievads.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(12, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dators nonemis X.kauliņu(s)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 246);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Ievads);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Punkti);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nonemt_Poga);
            this.Name = "Form1";
            this.Text = "Mana Spele";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Nonemt_Poga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Punkti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Ievads;
        private System.Windows.Forms.Label label3;
    }
}

