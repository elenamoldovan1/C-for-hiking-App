namespace WindowsFormsApp_final_proj_PA
{
    partial class Interogare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interogare));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxDisp = new System.Windows.Forms.ListBox();
            this.listBoxTip = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDurata = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxPer = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPret = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxidT = new System.Windows.Forms.TextBox();
            this.textBoxidP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkCyan;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(100, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alege tipul traseului";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkGreen;
            this.label2.Font = new System.Drawing.Font("Copperplate Gothic Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(737, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(368, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Traseele disponibile";
            // 
            // listBoxDisp
            // 
            this.listBoxDisp.BackColor = System.Drawing.Color.Honeydew;
            this.listBoxDisp.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxDisp.FormattingEnabled = true;
            this.listBoxDisp.ItemHeight = 26;
            this.listBoxDisp.Location = new System.Drawing.Point(650, 233);
            this.listBoxDisp.Name = "listBoxDisp";
            this.listBoxDisp.Size = new System.Drawing.Size(536, 186);
            this.listBoxDisp.TabIndex = 3;
            this.listBoxDisp.SelectedIndexChanged += new System.EventHandler(this.listBoxDisp_SelectedIndexChanged);
            // 
            // listBoxTip
            // 
            this.listBoxTip.BackColor = System.Drawing.Color.Azure;
            this.listBoxTip.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxTip.FormattingEnabled = true;
            this.listBoxTip.ItemHeight = 26;
            this.listBoxTip.Location = new System.Drawing.Point(83, 332);
            this.listBoxTip.Name = "listBoxTip";
            this.listBoxTip.Size = new System.Drawing.Size(419, 160);
            this.listBoxTip.TabIndex = 4;
            this.listBoxTip.SelectedIndexChanged += new System.EventHandler(this.listBoxTip_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkCyan;
            this.label3.Font = new System.Drawing.Font("Copperplate Gothic Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(80, 517);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 35);
            this.label3.TabIndex = 5;
            this.label3.Text = "Durata";
            // 
            // textBoxDurata
            // 
            this.textBoxDurata.BackColor = System.Drawing.Color.Azure;
            this.textBoxDurata.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDurata.Location = new System.Drawing.Point(275, 518);
            this.textBoxDurata.Name = "textBoxDurata";
            this.textBoxDurata.Size = new System.Drawing.Size(227, 34);
            this.textBoxDurata.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.CadetBlue;
            this.label4.Font = new System.Drawing.Font("Copperplate Gothic Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(27, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1189, 44);
            this.label4.TabIndex = 7;
            this.label4.Text = "Verifica traseele disponibile in functie de tipul lor";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxPer
            // 
            this.listBoxPer.BackColor = System.Drawing.Color.LightCyan;
            this.listBoxPer.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPer.FormattingEnabled = true;
            this.listBoxPer.ItemHeight = 26;
            this.listBoxPer.Location = new System.Drawing.Point(650, 497);
            this.listBoxPer.Name = "listBoxPer";
            this.listBoxPer.Size = new System.Drawing.Size(536, 186);
            this.listBoxPer.TabIndex = 9;
            this.listBoxPer.SelectedIndexChanged += new System.EventHandler(this.listBoxPer_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.SteelBlue;
            this.label5.Font = new System.Drawing.Font("Copperplate Gothic Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(737, 444);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(367, 35);
            this.label5.TabIndex = 8;
            this.label5.Text = "Perioade disponibile";
            // 
            // textBoxPret
            // 
            this.textBoxPret.BackColor = System.Drawing.Color.Azure;
            this.textBoxPret.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPret.Location = new System.Drawing.Point(275, 616);
            this.textBoxPret.Name = "textBoxPret";
            this.textBoxPret.Size = new System.Drawing.Size(227, 34);
            this.textBoxPret.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkCyan;
            this.label6.Font = new System.Drawing.Font("Copperplate Gothic Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(80, 615);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 35);
            this.label6.TabIndex = 10;
            this.label6.Text = "Pret";
            // 
            // textBoxidT
            // 
            this.textBoxidT.BackColor = System.Drawing.Color.Azure;
            this.textBoxidT.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxidT.Location = new System.Drawing.Point(1158, 184);
            this.textBoxidT.Name = "textBoxidT";
            this.textBoxidT.Size = new System.Drawing.Size(58, 34);
            this.textBoxidT.TabIndex = 12;
            // 
            // textBoxidP
            // 
            this.textBoxidP.BackColor = System.Drawing.Color.Azure;
            this.textBoxidP.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxidP.Location = new System.Drawing.Point(1158, 444);
            this.textBoxidP.Name = "textBoxidP";
            this.textBoxidP.Size = new System.Drawing.Size(58, 34);
            this.textBoxidP.TabIndex = 13;
            // 
            // Interogare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1313, 745);
            this.Controls.Add(this.textBoxidP);
            this.Controls.Add(this.textBoxidT);
            this.Controls.Add(this.textBoxPret);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBoxPer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDurata);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxTip);
            this.Controls.Add(this.listBoxDisp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Interogare";
            this.Text = "Interogare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxDisp;
        private System.Windows.Forms.ListBox listBoxTip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDurata;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxPer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPret;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxidT;
        private System.Windows.Forms.TextBox textBoxidP;
    }
}