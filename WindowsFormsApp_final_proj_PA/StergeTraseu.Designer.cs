namespace WindowsFormsApp_final_proj_PA
{
    partial class StergeTraseu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StergeTraseu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIDT = new System.Windows.Forms.TextBox();
            this.listBoxDen = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxidper = new System.Windows.Forms.TextBox();
            this.listBoxPer = new System.Windows.Forms.ListBox();
            this.buttonStPer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RosyBrown;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(85, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(505, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecteaza Denumirea Traseului";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LemonChiffon;
            this.label2.Font = new System.Drawing.Font("Copperplate Gothic Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID-ul Traseului";
            // 
            // textBoxIDT
            // 
            this.textBoxIDT.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxIDT.Font = new System.Drawing.Font("Copperplate Gothic Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIDT.Location = new System.Drawing.Point(325, 417);
            this.textBoxIDT.Name = "textBoxIDT";
            this.textBoxIDT.Size = new System.Drawing.Size(211, 32);
            this.textBoxIDT.TabIndex = 2;
            // 
            // listBoxDen
            // 
            this.listBoxDen.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxDen.FormattingEnabled = true;
            this.listBoxDen.ItemHeight = 26;
            this.listBoxDen.Location = new System.Drawing.Point(36, 126);
            this.listBoxDen.Name = "listBoxDen";
            this.listBoxDen.Size = new System.Drawing.Size(612, 264);
            this.listBoxDen.TabIndex = 3;
            this.listBoxDen.SelectedIndexChanged += new System.EventHandler(this.listBoxDen_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RosyBrown;
            this.button1.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(161, 503);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(246, 74);
            this.button1.TabIndex = 4;
            this.button1.Text = "Sterge Traseu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label3.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(346, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Selecteaza Perioada";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.textBoxidper);
            this.groupBox1.Controls.Add(this.listBoxPer);
            this.groupBox1.Controls.Add(this.buttonStPer);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(753, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 399);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sterge Perioada";
            // 
            // textBoxidper
            // 
            this.textBoxidper.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxidper.Font = new System.Drawing.Font("Copperplate Gothic Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxidper.Location = new System.Drawing.Point(295, 282);
            this.textBoxidper.Name = "textBoxidper";
            this.textBoxidper.Size = new System.Drawing.Size(97, 32);
            this.textBoxidper.TabIndex = 7;
            // 
            // listBoxPer
            // 
            this.listBoxPer.Font = new System.Drawing.Font("Copperplate Gothic Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPer.FormattingEnabled = true;
            this.listBoxPer.ItemHeight = 20;
            this.listBoxPer.Location = new System.Drawing.Point(21, 112);
            this.listBoxPer.Name = "listBoxPer";
            this.listBoxPer.Size = new System.Drawing.Size(386, 164);
            this.listBoxPer.TabIndex = 8;
            this.listBoxPer.SelectedIndexChanged += new System.EventHandler(this.listBoxPer_SelectedIndexChanged);
            // 
            // buttonStPer
            // 
            this.buttonStPer.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonStPer.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStPer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonStPer.Location = new System.Drawing.Point(63, 320);
            this.buttonStPer.Name = "buttonStPer";
            this.buttonStPer.Size = new System.Drawing.Size(300, 53);
            this.buttonStPer.TabIndex = 7;
            this.buttonStPer.Text = "Sterge Perioada";
            this.buttonStPer.UseVisualStyleBackColor = false;
            this.buttonStPer.Click += new System.EventHandler(this.buttonStPer_Click);
            // 
            // StergeTraseu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1225, 616);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxDen);
            this.Controls.Add(this.textBoxIDT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StergeTraseu";
            this.Text = "StergeTraseu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxIDT;
        private System.Windows.Forms.ListBox listBoxDen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxPer;
        private System.Windows.Forms.Button buttonStPer;
        private System.Windows.Forms.TextBox textBoxidper;
    }
}