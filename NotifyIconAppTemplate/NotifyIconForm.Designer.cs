namespace NotifyIconAppTemplate
{
    partial class NotifyIconForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotifyIconForm));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuNotify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuFinalSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.mnuMainForm = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuNotify.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuNotify;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // contextMenuNotify
            // 
            this.contextMenuNotify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFinalSeparator,
            this.mnuMainForm,
            this.mnuExit});
            this.contextMenuNotify.Name = "contextMenuNotify";
            this.contextMenuNotify.Size = new System.Drawing.Size(104, 54);
            // 
            // mnuFinalSeparator
            // 
            this.mnuFinalSeparator.Name = "mnuFinalSeparator";
            this.mnuFinalSeparator.Size = new System.Drawing.Size(100, 6);
            // 
            // mnuMainForm
            // 
            this.mnuMainForm.Name = "mnuMainForm";
            this.mnuMainForm.Size = new System.Drawing.Size(103, 22);
            this.mnuMainForm.Text = "Open";
            this.mnuMainForm.Click += new System.EventHandler(this.mnuMainForm_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(103, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // NotifyIconForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 395);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NotifyIconForm";
            this.ShowInTaskbar = false;
            this.Text = "NotifyIcon Application Template";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NotifyIconForm_FormClosing);
            this.Shown += new System.EventHandler(this.NotifyIconForm_Shown);
            this.contextMenuNotify.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuNotify;
        private System.Windows.Forms.ToolStripSeparator mnuFinalSeparator;
        private System.Windows.Forms.ToolStripMenuItem mnuMainForm;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
    }
}