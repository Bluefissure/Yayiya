using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Advanced_Combat_Tracker;
using FFXIV_ACT_Plugin.Common;
using Yayiya.Structures;

namespace Yayiya
{
    public class YayiyaPlugin : IActPluginV1
    {
        internal Label statusLabel;
        internal bool initialized = false;
        internal Definitions _definitions;
        FFXIV_ACT_Plugin.FFXIV_ACT_Plugin ffxivPlugin;
        PluginControl control;

        private object GetFfxivPlugin()
        {
            ffxivPlugin = null;

            var plugins = ActGlobals.oFormActMain.ActPlugins;
            foreach (var plugin in plugins)
                if (plugin.pluginFile.Name.ToUpper().Contains("FFXIV_ACT_Plugin".ToUpper()) &&
                    plugin.lblPluginStatus.Text.ToUpper().Contains("Started.".ToUpper()))
                    ffxivPlugin = (FFXIV_ACT_Plugin.FFXIV_ACT_Plugin)plugin.pluginObj;

            if (ffxivPlugin == null)
                throw new Exception("Could not find FFXIV plugin. Make sure that it is loaded before Yayiya.");

            return ffxivPlugin;
        }
        public void DeInitPlugin()
        {
            if (initialized)
            {
                var subs = ffxivPlugin.GetType().GetProperty("DataSubscription").GetValue(ffxivPlugin, null);
                var networkReceivedDelegateType = typeof(NetworkReceivedDelegate);
                var networkReceivedDelegate = Delegate.CreateDelegate(networkReceivedDelegateType, (object)this, "NetworkReceived", true);
                subs.GetType().GetEvent("NetworkReceived").RemoveEventHandler(subs, networkReceivedDelegate);
                statusLabel.Text = "Exit :|";
            }
            else
            {
                statusLabel.Text = "Error :(";
            }
        }

        public void InitPlugin(TabPage pluginScreenSpace, Label pluginStatusText)
        {
            statusLabel = pluginStatusText;
            control = new PluginControl();
            pluginScreenSpace.Text = "Yayiya";
            pluginScreenSpace.Controls.Add(control);
            GetFfxivPlugin();
            _definitions = Definitions.Get();
            var subs = ffxivPlugin.GetType().GetProperty("DataSubscription").GetValue(ffxivPlugin, null);
            var networkReceivedDelegateType = typeof(NetworkReceivedDelegate);
            var networkReceivedDelegate = Delegate.CreateDelegate(networkReceivedDelegateType, (object)this, "NetworkReceived", true);
            subs.GetType().GetEvent("NetworkReceived").AddEventHandler(subs, networkReceivedDelegate);
            initialized = true;
            statusLabel.Text = "Wroking :D";
        }

        void NetworkReceived(string connection, long epoch, byte[] message)
        {
            var opCode = BitConverter.ToInt16(message, 0x12);

            if (opCode == _definitions.MarketBoardOfferings)
            {
                var listing = MarketBoardCurrentOfferings.Read(message.Skip(0x20).ToArray());
                if (listing.ListingIndexStart == 0)
                {
                    var minPrice = listing.ItemListings[0].PricePerUnit;
                    double targetPrice = minPrice;
                    if (control.YaCombo.SelectedIndex == 0)
                    {
                        targetPrice = minPrice - 1;
                    }
                    else if (control.YaCombo.SelectedIndex == 1)
                    {
                        targetPrice = minPrice / 2;
                    }
                    else if (control.YaCombo.SelectedIndex == 2)
                    {
                        int.TryParse(control.YaText.Text, out int yaPrice);
                        targetPrice = minPrice - yaPrice;
                    }
                    else if (control.YaCombo.SelectedIndex == 3)
                    {
                        int.TryParse(control.YaText.Text, out int yaPercentage);
                        targetPrice = minPrice * (1.0 - (yaPercentage * 1.0 / 100.0));
                    }
                    uint finalPrice = (uint)Math.Max(1, (int)targetPrice);
                    Thread thread = new(() => Clipboard.SetText(finalPrice.ToString()));
                    thread.SetApartmentState(ApartmentState.STA);
                    thread.Start();
                    thread.Join();
                }
            }
        }
    }
}
