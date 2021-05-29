using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yayiya
{
    public partial class PluginControl : UserControl
    {
        public PluginControl()
        {
            InitializeComponent();
            this.YaCombo.SelectedIndex = 0;
        }

        private void YaCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboboxSender = (ComboBox)sender;
            this.YaText.Enabled = (comboboxSender.SelectedIndex > 1);
            this.YaText.Text = "";
            this.YaType.Text = comboboxSender.SelectedIndex switch
            {
                2 => "块",
                3 => "%",
                _ => "",
            };
        }

    private void YaText_TextChanged(object sender, EventArgs e)
    {
        this.YaText.Text = String.Concat(this.YaText.Text.Where(ch => Char.IsDigit(ch)));
    }
}
}
