using System.Windows.Forms;

namespace NotifyIconAppTemplate
{
    public static class ToolStripItemCollectionExtension
    {
        public static void AddRangeAbove(this ToolStripItemCollection @self, ToolStripItem[] toolStripItems)
        {
            ContextMenuStrip baseMenu = new ContextMenuStrip();
            while (@self.Count > 0)
                baseMenu.Items.Add(@self[0]);

            @self.Clear();
            @self.AddRange(toolStripItems);
            while (baseMenu.Items.Count > 0)
                @self.Add(baseMenu.Items[0]);
        }

        public static void AddRangeAbove(this ToolStripItemCollection @self, ToolStripItemCollection toolStripItems)
        {
            ContextMenuStrip baseMenu = new ContextMenuStrip();
            while (@self.Count > 0)
                baseMenu.Items.Add(@self[0]);

            @self.Clear();
            @self.AddRange(toolStripItems);
            while (baseMenu.Items.Count > 0)
                @self.Add(baseMenu.Items[0]);
        }
    }
}