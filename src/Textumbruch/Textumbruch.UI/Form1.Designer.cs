namespace Textumbruch.UI
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
            this.btn_Umbrechen = new System.Windows.Forms.Button();
            this.ctrl_Eingabe = new System.Windows.Forms.TextBox();
            this.ctrl_Ausgabe = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrl_BreiteInZeichen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Umbrechen
            // 
            this.btn_Umbrechen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Umbrechen.Location = new System.Drawing.Point(418, 37);
            this.btn_Umbrechen.Name = "btn_Umbrechen";
            this.btn_Umbrechen.Size = new System.Drawing.Size(225, 93);
            this.btn_Umbrechen.TabIndex = 0;
            this.btn_Umbrechen.Text = "Umbrechen";
            this.btn_Umbrechen.UseVisualStyleBackColor = true;
            this.btn_Umbrechen.Click += new System.EventHandler(this.btn_Umbrechen_Click);
            // 
            // ctrl_Eingabe
            // 
            this.ctrl_Eingabe.Location = new System.Drawing.Point(12, 48);
            this.ctrl_Eingabe.Multiline = true;
            this.ctrl_Eingabe.Name = "ctrl_Eingabe";
            this.ctrl_Eingabe.Size = new System.Drawing.Size(978, 213);
            this.ctrl_Eingabe.TabIndex = 1;
            // 
            // ctrl_Ausgabe
            // 
            this.ctrl_Ausgabe.Location = new System.Drawing.Point(12, 325);
            this.ctrl_Ausgabe.Multiline = true;
            this.ctrl_Ausgabe.Name = "ctrl_Ausgabe";
            this.ctrl_Ausgabe.ReadOnly = true;
            this.ctrl_Ausgabe.Size = new System.Drawing.Size(978, 213);
            this.ctrl_Ausgabe.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ctrl_BreiteInZeichen);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_Umbrechen);
            this.panel1.Location = new System.Drawing.Point(12, 551);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(978, 149);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Breite in Zeichen:";
            // 
            // ctrl_BreiteInZeichen
            // 
            this.ctrl_BreiteInZeichen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrl_BreiteInZeichen.Location = new System.Drawing.Point(32, 89);
            this.ctrl_BreiteInZeichen.Name = "ctrl_BreiteInZeichen";
            this.ctrl_BreiteInZeichen.Size = new System.Drawing.Size(365, 41);
            this.ctrl_BreiteInZeichen.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nachher:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "Vorher:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 712);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ctrl_Eingabe);
            this.Controls.Add(this.ctrl_Ausgabe);
            this.Name = "Form1";
            this.Text = "Textumbruch";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Umbrechen;
        private System.Windows.Forms.TextBox ctrl_Eingabe;
        private System.Windows.Forms.TextBox ctrl_Ausgabe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox ctrl_BreiteInZeichen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

