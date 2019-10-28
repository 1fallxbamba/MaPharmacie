namespace MaPharmacie
{
    partial class managementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(managementForm));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonChangeStatus = new System.Windows.Forms.Button();
            this.radioButtonGuard = new System.Windows.Forms.RadioButton();
            this.radioButtonClosed = new System.Windows.Forms.RadioButton();
            this.radioButtonOpened = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonChangeStatus);
            this.groupBox1.Controls.Add(this.radioButtonGuard);
            this.groupBox1.Controls.Add(this.radioButtonClosed);
            this.groupBox1.Controls.Add(this.radioButtonOpened);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // buttonChangeStatus
            // 
            this.buttonChangeStatus.BackColor = System.Drawing.Color.Transparent;
            this.buttonChangeStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.buttonChangeStatus, "buttonChangeStatus");
            this.buttonChangeStatus.Name = "buttonChangeStatus";
            this.buttonChangeStatus.UseVisualStyleBackColor = false;
            this.buttonChangeStatus.Click += new System.EventHandler(this.ButtonChangeStatus_Click);
            // 
            // radioButtonGuard
            // 
            this.radioButtonGuard.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.radioButtonGuard, "radioButtonGuard");
            this.radioButtonGuard.Name = "radioButtonGuard";
            this.radioButtonGuard.TabStop = true;
            this.radioButtonGuard.UseVisualStyleBackColor = false;
            this.radioButtonGuard.CheckedChanged += new System.EventHandler(this.RadioButtonGuard_CheckedChanged);
            // 
            // radioButtonClosed
            // 
            this.radioButtonClosed.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.radioButtonClosed, "radioButtonClosed");
            this.radioButtonClosed.Name = "radioButtonClosed";
            this.radioButtonClosed.TabStop = true;
            this.radioButtonClosed.UseVisualStyleBackColor = false;
            this.radioButtonClosed.CheckedChanged += new System.EventHandler(this.RadioButtonClosed_CheckedChanged);
            // 
            // radioButtonOpened
            // 
            this.radioButtonOpened.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.radioButtonOpened, "radioButtonOpened");
            this.radioButtonOpened.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonOpened.Name = "radioButtonOpened";
            this.radioButtonOpened.TabStop = true;
            this.radioButtonOpened.UseVisualStyleBackColor = false;
            this.radioButtonOpened.CheckedChanged += new System.EventHandler(this.RadioButtonOpened_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // managementForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "managementForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManagementForm_FormClosing);
            this.Load += new System.EventHandler(this.ManagementForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonGuard;
        private System.Windows.Forms.RadioButton radioButtonClosed;
        private System.Windows.Forms.RadioButton radioButtonOpened;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonChangeStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}