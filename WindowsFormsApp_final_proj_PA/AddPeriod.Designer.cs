namespace WindowsFormsApp_final_proj_PA
{
    partial class AddPeriod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPeriod));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPerNoua = new System.Windows.Forms.TextBox();
            this.comboBoxTipTr = new System.Windows.Forms.ComboBox();
            this.textBoxid = new System.Windows.Forms.TextBox();
            this.buttonAddper = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Indica Perioada";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 169);
            this.label2.MaximumSize = new System.Drawing.Size(300, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "Selecteaza tipul traseului la care aceasta perioada se refera";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Handwriting", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "in format DD Month YYYY";
            // 
            // textBoxPerNoua
            // 
            this.textBoxPerNoua.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPerNoua.Location = new System.Drawing.Point(307, 68);
            this.textBoxPerNoua.Name = "textBoxPerNoua";
            this.textBoxPerNoua.Size = new System.Drawing.Size(363, 37);
            this.textBoxPerNoua.TabIndex = 3;
            // 
            // comboBoxTipTr
            // 
            this.comboBoxTipTr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipTr.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTipTr.FormattingEnabled = true;
            this.comboBoxTipTr.Location = new System.Drawing.Point(346, 178);
            this.comboBoxTipTr.Name = "comboBoxTipTr";
            this.comboBoxTipTr.Size = new System.Drawing.Size(324, 31);
            this.comboBoxTipTr.TabIndex = 4;
            this.comboBoxTipTr.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipTr_SelectedIndexChanged);
            // 
            // textBoxid
            // 
            this.textBoxid.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxid.Location = new System.Drawing.Point(582, 215);
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.Size = new System.Drawing.Size(79, 32);
            this.textBoxid.TabIndex = 5;
            // 
            // buttonAddper
            // 
            this.buttonAddper.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonAddper.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddper.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAddper.Location = new System.Drawing.Point(194, 253);
            this.buttonAddper.Name = "buttonAddper";
            this.buttonAddper.Size = new System.Drawing.Size(295, 80);
            this.buttonAddper.TabIndex = 6;
            this.buttonAddper.Text = "Adauga Perioada Noua";
            this.buttonAddper.UseVisualStyleBackColor = false;
            this.buttonAddper.Click += new System.EventHandler(this.buttonAddper_Click);
            // 
            // AddPeriod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(729, 373);
            this.Controls.Add(this.buttonAddper);
            this.Controls.Add(this.textBoxid);
            this.Controls.Add(this.comboBoxTipTr);
            this.Controls.Add(this.textBoxPerNoua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddPeriod";
            this.Text = "AddPeriod";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPerNoua;
        private System.Windows.Forms.ComboBox comboBoxTipTr;
        private System.Windows.Forms.TextBox textBoxid;
        private System.Windows.Forms.Button buttonAddper;
    }
}