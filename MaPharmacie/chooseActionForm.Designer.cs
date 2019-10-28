namespace MaPharmacie
{
    partial class chooseActionForm
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
            this.buttonStatusMgmt = new System.Windows.Forms.Button();
            this.buttonDrugs = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonStatusMgmt
            // 
            this.buttonStatusMgmt.Font = new System.Drawing.Font("Sitka Text", 14.25F);
            this.buttonStatusMgmt.Location = new System.Drawing.Point(130, 46);
            this.buttonStatusMgmt.Name = "buttonStatusMgmt";
            this.buttonStatusMgmt.Size = new System.Drawing.Size(372, 88);
            this.buttonStatusMgmt.TabIndex = 0;
            this.buttonStatusMgmt.Text = "Gestion de statut";
            this.buttonStatusMgmt.UseVisualStyleBackColor = true;
            this.buttonStatusMgmt.Click += new System.EventHandler(this.buttonStatusMgmt_Click);
            // 
            // buttonDrugs
            // 
            this.buttonDrugs.Font = new System.Drawing.Font("Sitka Text", 14.25F);
            this.buttonDrugs.Location = new System.Drawing.Point(130, 195);
            this.buttonDrugs.Name = "buttonDrugs";
            this.buttonDrugs.Size = new System.Drawing.Size(372, 88);
            this.buttonDrugs.TabIndex = 1;
            this.buttonDrugs.Text = "Gestion de médicaments";
            this.buttonDrugs.UseVisualStyleBackColor = true;
            this.buttonDrugs.Click += new System.EventHandler(this.buttonDrugs_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.buttonExit.Location = new System.Drawing.Point(538, 306);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(90, 35);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Quitter";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // chooseActionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(636, 347);
            this.ControlBox = false;
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonDrugs);
            this.Controls.Add(this.buttonStatusMgmt);
            this.Name = "chooseActionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ma Pharmacie";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.chooseActionForm_FormClosing);
            this.Load += new System.EventHandler(this.chooseActionForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStatusMgmt;
        private System.Windows.Forms.Button buttonDrugs;
        private System.Windows.Forms.Button buttonExit;
    }
}