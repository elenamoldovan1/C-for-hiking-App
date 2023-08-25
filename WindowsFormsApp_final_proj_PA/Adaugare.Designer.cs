namespace WindowsFormsApp_final_proj_PA
{
    partial class Adaugare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adaugare));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDenT = new System.Windows.Forms.TextBox();
            this.comboBoxTipT = new System.Windows.Forms.ComboBox();
            this.textBoxidTip = new System.Windows.Forms.TextBox();
            this.textBoxid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAdaug = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxPer = new System.Windows.Forms.ComboBox();
            this.textBoxIdPer = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxpret = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adauga denumirea traseului";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alege tipul traseului";
            // 
            // textBoxDenT
            // 
            this.textBoxDenT.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDenT.Location = new System.Drawing.Point(527, 131);
            this.textBoxDenT.Name = "textBoxDenT";
            this.textBoxDenT.Size = new System.Drawing.Size(520, 34);
            this.textBoxDenT.TabIndex = 3;
            // 
            // comboBoxTipT
            // 
            this.comboBoxTipT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipT.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTipT.FormattingEnabled = true;
            this.comboBoxTipT.Location = new System.Drawing.Point(527, 268);
            this.comboBoxTipT.Name = "comboBoxTipT";
            this.comboBoxTipT.Size = new System.Drawing.Size(520, 34);
            this.comboBoxTipT.TabIndex = 7;
            this.comboBoxTipT.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipT_SelectedIndexChanged);
            // 
            // textBoxidTip
            // 
            this.textBoxidTip.Location = new System.Drawing.Point(1074, 276);
            this.textBoxidTip.Name = "textBoxidTip";
            this.textBoxidTip.Size = new System.Drawing.Size(100, 26);
            this.textBoxidTip.TabIndex = 8;
            // 
            // textBoxid
            // 
            this.textBoxid.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxid.Location = new System.Drawing.Point(526, 196);
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.Size = new System.Drawing.Size(520, 34);
            this.textBoxid.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(99, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 26);
            this.label3.TabIndex = 11;
            this.label3.Text = "Adauga ID Traseu";
            // 
            // buttonAdaug
            // 
            this.buttonAdaug.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonAdaug.Font = new System.Drawing.Font("Copperplate Gothic Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdaug.Location = new System.Drawing.Point(439, 579);
            this.buttonAdaug.Name = "buttonAdaug";
            this.buttonAdaug.Size = new System.Drawing.Size(373, 125);
            this.buttonAdaug.TabIndex = 13;
            this.buttonAdaug.Text = "Adauga Traseu Nou";
            this.buttonAdaug.UseVisualStyleBackColor = false;
            this.buttonAdaug.Click += new System.EventHandler(this.buttonAdaug_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(99, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 26);
            this.label5.TabIndex = 14;
            this.label5.Text = "Alege perioada";
            // 
            // comboBoxPer
            // 
            this.comboBoxPer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPer.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPer.FormattingEnabled = true;
            this.comboBoxPer.Location = new System.Drawing.Point(527, 331);
            this.comboBoxPer.Name = "comboBoxPer";
            this.comboBoxPer.Size = new System.Drawing.Size(520, 34);
            this.comboBoxPer.TabIndex = 15;
            this.comboBoxPer.SelectedIndexChanged += new System.EventHandler(this.comboBoxPer_SelectedIndexChanged);
            // 
            // textBoxIdPer
            // 
            this.textBoxIdPer.Location = new System.Drawing.Point(1074, 339);
            this.textBoxIdPer.Name = "textBoxIdPer";
            this.textBoxIdPer.Size = new System.Drawing.Size(100, 26);
            this.textBoxIdPer.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Eras Light ITC", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(527, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 73);
            this.button1.TabIndex = 18;
            this.button1.Text = "Adauga perioada noua";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(99, 483);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(334, 26);
            this.label7.TabIndex = 19;
            this.label7.Text = "Indica pretul Traseului";
            // 
            // textBoxpret
            // 
            this.textBoxpret.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxpret.Location = new System.Drawing.Point(527, 480);
            this.textBoxpret.Name = "textBoxpret";
            this.textBoxpret.Size = new System.Drawing.Size(520, 34);
            this.textBoxpret.TabIndex = 20;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Olive;
            this.button2.Font = new System.Drawing.Font("Copperplate Gothic Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(616, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(368, 37);
            this.button2.TabIndex = 21;
            this.button2.Text = "Vezi Trasee Deja Disponibile";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Adaugare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1294, 755);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxpret);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxIdPer);
            this.Controls.Add(this.comboBoxPer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonAdaug);
            this.Controls.Add(this.textBoxid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxidTip);
            this.Controls.Add(this.comboBoxTipT);
            this.Controls.Add(this.textBoxDenT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Adaugare";
            this.Text = "Adaugare Traseu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDenT;
        private System.Windows.Forms.ComboBox comboBoxTipT;
        private System.Windows.Forms.TextBox textBoxidTip;
        private System.Windows.Forms.TextBox textBoxid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAdaug;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxPer;
        private System.Windows.Forms.TextBox textBoxIdPer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxpret;
        private System.Windows.Forms.Button button2;
    }
}