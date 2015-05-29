using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace roster_visual
{
    public class Security
    {
        private TabControl _mainTab;
        private BindingNavigator _navigator;
        private List<TabPage> TabPages = new List<TabPage>();

        public Security(TabControl tab, BindingNavigator navigator)
        {
            _mainTab = tab;
            _navigator = navigator;
            TabPages.AddRange(_mainTab.TabPages.Cast<TabPage>());
        }

        public Security()
        { 
            
        }

        public void Hide(string commaSeparatedTabs)
        {
            string[] pages = commaSeparatedTabs.Split(',');
            foreach (string item in pages) 
                _mainTab.TabPages.RemoveByKey(item);
        }

        public void Show(string commaSeparatedTabs)
        {
            string[] pages = commaSeparatedTabs.Split(',');
            TabPage tab;
            foreach (string item in pages)
            {
                tab = TabPages.First(l => l.Name == item);
                if (!_mainTab.TabPages.Contains(tab)) _mainTab.TabPages.Add(tab);
            }
        }

        private void HideAll()
        {
            _mainTab.TabPages.Clear();
        }

        public void DrawTabs(User _user)
        {
            HideAll();
            Show(_user.Role.Access);

           /* _navigator.Items.Cast<ToolStripItem>().First(l => l.Name == "save_btn").Enabled = false;
            _navigator.Items.Cast<ToolStripItem>().First(l => l.Name == "add_btn").Enabled = false;*/
            
        }

    }
}
