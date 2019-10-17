using System;

namespace NotifyIconAppTemplate
{
    public partial class Main : NotifyIconAppTemplate.NotifyIconForm
    {
        public Main()
        {
            InitializeComponent();
            base.ContextMenuStrip = contextMenuApplication;
        }
    }
}