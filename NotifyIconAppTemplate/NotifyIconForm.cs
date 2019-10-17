using System;
using System.Windows.Forms;

namespace NotifyIconAppTemplate
{
    public partial class NotifyIconForm : Form
    {
        bool displayedForm;
        bool forceTerminate = false;
        string appName = Application.ProductName;
        protected ContextMenuStrip ContextMenuStrip { get; set; }

        #region Default Form Commands...

        public NotifyIconForm()
        {
            InitializeComponent();
            this.notifyIcon.Icon = this.Icon;
        }

        internal void InjectContextMenu(ContextMenuStrip contextMenuStrip)
        {
            if (contextMenuStrip?.Items.Count > 0)
                this.contextMenuNotify.Items.AddRangeAbove(contextMenuStrip.Items);
            else
                this.contextMenuNotify.Items.Remove(mnuFinalSeparator);
        }

        private void NotifyIconForm_Shown(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                InjectContextMenu(this.ContextMenuStrip);
                StartMiminized();
            }
        }

        private void NotifyIconForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !forceTerminate;
            DisplayControl(ref displayedForm);
        }

        #endregion

        #region Custom Methods...

        private void StartMiminized()
        {
            if (string.IsNullOrEmpty(this.Tag?.ToString()))
            {
                this.Tag += " [Started]";
                this.notifyIcon.Visible = true;
                displayedForm = true;
                PlaceFormAboveNotifyTray();
                DisplayToolTipMessage();
                DisplayControl(ref displayedForm);
            }
        }

        private void PlaceFormAboveNotifyTray()
        {
            this.Top = Screen.PrimaryScreen.WorkingArea.Height - this.Height + 8;
            this.Left = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 8;
        }

        private void DisplayToolTipMessage(string message = null, ToolTipIcon toolTipIcon = ToolTipIcon.Info)
        {
            this.notifyIcon.ShowBalloonTip(0, appName, message ?? "The application will continue to work in the background and can be accessed via TrayIcon...", toolTipIcon);
        }

        protected void DisplayControl(ref bool displayed)
        {
            if (displayed)
            {
                this.Hide();
                this.TopMost = false;
                this.mnuMainForm.Text = "Open";
                displayed = false;
            }
            else
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
                this.BringToFront();
                this.TopMost = true;
                this.mnuMainForm.Text = "Close";
                displayed = true;
            }
        }

        #endregion

        #region Default NotifyIcon Commands...

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            DisplayControl(ref displayedForm);
        }

        private void mnuMainForm_Click(object sender, EventArgs e)
        {
            DisplayControl(ref displayedForm);
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            forceTerminate = true;
            Application.Exit();
        }

        #endregion
    }
}