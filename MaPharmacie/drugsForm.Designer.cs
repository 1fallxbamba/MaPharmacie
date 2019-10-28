namespace MaPharmacie
{
    partial class drugsForm
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
            this.comboBoxDrugs = new System.Windows.Forms.ComboBox();
            this.buttonAvail = new System.Windows.Forms.Button();
            this.buttonNoAvail = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxDrugs
            // 
            this.comboBoxDrugs.FormattingEnabled = true;
            this.comboBoxDrugs.Location = new System.Drawing.Point(398, 275);
            this.comboBoxDrugs.Name = "comboBoxDrugs";
            this.comboBoxDrugs.Size = new System.Drawing.Size(324, 21);
            this.comboBoxDrugs.TabIndex = 0;
            this.comboBoxDrugs.SelectedIndexChanged += new System.EventHandler(this.comboBoxDrugs_SelectedIndexChanged);
            // 
            // buttonAvail
            // 
            this.buttonAvail.Font = new System.Drawing.Font("Sitka Text", 14.25F);
            this.buttonAvail.Location = new System.Drawing.Point(301, 365);
            this.buttonAvail.Name = "buttonAvail";
            this.buttonAvail.Size = new System.Drawing.Size(179, 65);
            this.buttonAvail.TabIndex = 1;
            this.buttonAvail.Text = "Disponible";
            this.buttonAvail.UseVisualStyleBackColor = true;
            this.buttonAvail.Click += new System.EventHandler(this.buttonAvail_Click);
            // 
            // buttonNoAvail
            // 
            this.buttonNoAvail.Font = new System.Drawing.Font("Sitka Text", 14.25F);
            this.buttonNoAvail.Location = new System.Drawing.Point(543, 365);
            this.buttonNoAvail.Name = "buttonNoAvail";
            this.buttonNoAvail.Size = new System.Drawing.Size(179, 65);
            this.buttonNoAvail.TabIndex = 2;
            this.buttonNoAvail.Text = "Non Disponible";
            this.buttonNoAvail.UseVisualStyleBackColor = true;
            this.buttonNoAvail.Click += new System.EventHandler(this.buttonNoAvail_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.buttonExit.Location = new System.Drawing.Point(975, 433);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(90, 35);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Quitter";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Heading", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(717, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cette fenêtre sert à mettre à jour la disponibilité d\'un ou plusieurs médicaments" +
    "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(469, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "1. Si un médicament n\'est pas/plus disponible dans votre pharmacie :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Azure;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(460, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "- Sélectionnez le dans la liste déroulante ET cliquez sur \'Non disponible\'";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Heading", 12F);
            this.label4.Location = new System.Drawing.Point(548, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(489, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "2. Si un médicament n\'était pas disponible et est de nouveau disponible :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Azure;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(558, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(433, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "- Sélectionnez le dans la liste déroulante ET cliquez sur \'Disponible\'";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Azure;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Sitka Heading", 12F);
            this.label6.Location = new System.Drawing.Point(463, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Instructions";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 9.75F);
            this.label7.Location = new System.Drawing.Point(298, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Médicaments :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // drugsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1072, 474);
            this.ControlBox = false;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonNoAvail);
            this.Controls.Add(this.buttonAvail);
            this.Controls.Add(this.comboBoxDrugs);
            this.Name = "drugsForm";
            this.Text = "Ma Pharmacie - Gestion de médicaments";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.drugsForm_FormClosing);
            this.Load += new System.EventHandler(this.drugsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDrugs;
        private System.Windows.Forms.Button buttonAvail;
        private System.Windows.Forms.Button buttonNoAvail;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}