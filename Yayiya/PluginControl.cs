using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using Advanced_Combat_Tracker;

namespace Yayiya
{
    public partial class PluginControl : UserControl
    {
        public static readonly string SettingsFile = Path.Combine(ActGlobals.oFormActMain.AppDataFolder.FullName, "Config\\Yayiya.config.xml");
        public PluginControl()
        {
            InitializeComponent();
            this.YaCombo.SelectedIndex = 0;
            this.comboBoxKey.SelectedIndex = 0;
            YaToolTip.SetToolTip(this.radioButtonAlwaysNQ, "只以NQ物品为价格基准复制");
            YaToolTip.SetToolTip(this.radioButtonAlwaysHQ, "只以HQ物品为价格基准复制，仅考察列表前10项物品，如其中无HQ则以NQ物品为价格基准");
            YaToolTip.SetToolTip(this.radioButtonHandle, "先在键盘上按住下面选择的按键不放，点击游戏中“查看市场中的时价”按钮，松开键盘，以HQ物品为价格基准复制 \r\n不按住按键则以NQ物品为价格基准复制");
            YaToolTip.SetToolTip(this.comboBoxKey, "选择一个按键");
            YaToolTip.SetToolTip(this.YaPanel, "免费插件，禁止咸鱼小店");
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

        public void SaveSettings()
        {
            FileStream fs = new FileStream(SettingsFile, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
            XmlTextWriter xWriter = new XmlTextWriter(fs, Encoding.UTF8) { Formatting = Formatting.Indented, Indentation = 1, IndentChar = '\t' };
            xWriter.WriteStartDocument(true);
            xWriter.WriteStartElement("Config");    // <Config>
            xWriter.WriteElementString("YaCombo", YaCombo.SelectedIndex.ToString());
            xWriter.WriteElementString("YaText", YaText.Text);

            xWriter.WriteElementString("radioButtonAlwaysHQ", radioButtonAlwaysHQ.Checked.ToString());
            xWriter.WriteElementString("radioButtonAlwaysNQ", radioButtonAlwaysNQ.Checked.ToString());
            xWriter.WriteElementString("radioButtonHandle", radioButtonHandle.Checked.ToString());
            xWriter.WriteElementString("comboBoxKey", comboBoxKey.SelectedIndex.ToString());

            xWriter.WriteEndElement();              // </Config>
            xWriter.WriteEndDocument();             // Tie up loose ends (shouldn't be any)
            xWriter.Flush();                        // Flush the file buffer to disk
            xWriter.Close();
        }

        public void LoadSettings()
        {
            if (File.Exists(SettingsFile))
            {
                XmlDocument xdo = new XmlDocument();
                xdo.Load(SettingsFile);
                XmlNode head = xdo.SelectSingleNode("Config");
                YaCombo.SelectedIndex = int.Parse(head?.SelectSingleNode("YaCombo")?.InnerText ?? "0");
                YaText.Text = head?.SelectSingleNode("YaText")?.InnerText ?? "114514";
                radioButtonAlwaysHQ.Checked = bool.Parse(head?.SelectSingleNode("radioButtonAlwaysHQ")?.InnerText ?? "true");
                radioButtonAlwaysNQ.Checked = bool.Parse(head?.SelectSingleNode("radioButtonAlwaysNQ")?.InnerText ?? "false");
                radioButtonHandle.Checked = bool.Parse(head?.SelectSingleNode("radioButtonHandle")?.InnerText ?? "false");
                comboBoxKey.SelectedIndex = int.Parse(head?.SelectSingleNode("comboBoxKey")?.InnerText ?? "0");
            }
        }
    }
}
