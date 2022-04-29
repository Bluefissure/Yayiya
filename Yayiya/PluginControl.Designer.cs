
namespace Yayiya
{
    partial class PluginControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.YaLabel = new System.Windows.Forms.Label();
            this.YaCombo = new System.Windows.Forms.ComboBox();
            this.YaText = new System.Windows.Forms.TextBox();
            this.YaType = new System.Windows.Forms.Label();
            this.YaPanel = new System.Windows.Forms.Panel();
            this.radioButtonAlwaysNQ = new System.Windows.Forms.RadioButton();
            this.radioButtonAlwaysHQ = new System.Windows.Forms.RadioButton();
            this.radioButtonHandle = new System.Windows.Forms.RadioButton();
            this.comboBoxKey = new System.Windows.Forms.ComboBox();
            this.YaToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.YaPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // YaLabel
            // 
            this.YaLabel.AutoSize = true;
            this.YaLabel.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.YaLabel.Location = new System.Drawing.Point(23, 22);
            this.YaLabel.Name = "YaLabel";
            this.YaLabel.Size = new System.Drawing.Size(17, 12);
            this.YaLabel.TabIndex = 0;
            this.YaLabel.Text = "压";
            // 
            // YaCombo
            // 
            this.YaCombo.FormattingEnabled = true;
            this.YaCombo.Items.AddRange(new object[] {
            "一块",
            "一半",
            "固定数值",
            "固定比例"});
            this.YaCombo.Location = new System.Drawing.Point(48, 19);
            this.YaCombo.Name = "YaCombo";
            this.YaCombo.Size = new System.Drawing.Size(121, 20);
            this.YaCombo.TabIndex = 1;
            this.YaCombo.SelectedIndexChanged += new System.EventHandler(this.YaCombo_SelectedIndexChanged);
            // 
            // YaText
            // 
            this.YaText.Enabled = false;
            this.YaText.Location = new System.Drawing.Point(175, 20);
            this.YaText.Name = "YaText";
            this.YaText.Size = new System.Drawing.Size(100, 21);
            this.YaText.TabIndex = 2;
            this.YaText.TextChanged += new System.EventHandler(this.YaText_TextChanged);
            // 
            // YaType
            // 
            this.YaType.AutoSize = true;
            this.YaType.Location = new System.Drawing.Point(281, 22);
            this.YaType.Name = "YaType";
            this.YaType.Size = new System.Drawing.Size(17, 12);
            this.YaType.TabIndex = 3;
            this.YaType.Text = "块";
            // 
            // YaPanel
            // 
            this.YaPanel.Controls.Add(this.radioButtonAlwaysHQ);
            this.YaPanel.Controls.Add(this.comboBoxKey);
            this.YaPanel.Controls.Add(this.radioButtonAlwaysNQ);
            this.YaPanel.Controls.Add(this.radioButtonHandle);
            this.YaPanel.Location = new System.Drawing.Point(12, 47);
            this.YaPanel.Name = "YaPanel";
            this.YaPanel.Size = new System.Drawing.Size(477, 279);
            this.YaPanel.TabIndex = 4;
            // 
            // radioButtonAlwaysNQ
            // 
            this.radioButtonAlwaysNQ.AutoSize = true;
            this.radioButtonAlwaysNQ.Checked = true;
            this.radioButtonAlwaysNQ.Location = new System.Drawing.Point(13, 13);
            this.radioButtonAlwaysNQ.Name = "radioButtonAlwaysNQ";
            this.radioButtonAlwaysNQ.Size = new System.Drawing.Size(107, 16);
            this.radioButtonAlwaysNQ.TabIndex = 5;
            this.radioButtonAlwaysNQ.TabStop = true;
            this.radioButtonAlwaysNQ.Text = "默认参考NQ价格";
            this.radioButtonAlwaysNQ.UseVisualStyleBackColor = true;
            // 
            // radioButtonAlwaysHQ
            // 
            this.radioButtonAlwaysHQ.AutoSize = true;
            this.radioButtonAlwaysHQ.Location = new System.Drawing.Point(13, 35);
            this.radioButtonAlwaysHQ.Name = "radioButtonAlwaysHQ";
            this.radioButtonAlwaysHQ.Size = new System.Drawing.Size(107, 16);
            this.radioButtonAlwaysHQ.TabIndex = 5;
            this.radioButtonAlwaysHQ.Text = "默认参考HQ价格";
            this.radioButtonAlwaysHQ.UseVisualStyleBackColor = true;
            // 
            // radioButtonHandle
            // 
            this.radioButtonHandle.AutoSize = true;
            this.radioButtonHandle.Location = new System.Drawing.Point(13, 57);
            this.radioButtonHandle.Name = "radioButtonHandle";
            this.radioButtonHandle.Size = new System.Drawing.Size(263, 16);
            this.radioButtonHandle.TabIndex = 5;
            this.radioButtonHandle.Text = "仅在按住以下按键的时候切换为参考HQ价格：";
            this.radioButtonHandle.UseVisualStyleBackColor = true;
            // 
            // comboBoxKey
            // 
            this.comboBoxKey.FormattingEnabled = true;
            this.comboBoxKey.Items.AddRange(new object[] {
            "Ctrl",
            "Alt",
            "Shift"});
            this.comboBoxKey.Location = new System.Drawing.Point(29, 79);
            this.comboBoxKey.Name = "comboBoxKey";
            this.comboBoxKey.Size = new System.Drawing.Size(82, 20);
            this.comboBoxKey.TabIndex = 1;
            this.comboBoxKey.SelectedIndexChanged += new System.EventHandler(this.YaCombo_SelectedIndexChanged);
            // 
            // YaToolTip
            // 
            this.YaToolTip.AutoPopDelay = 5000;
            this.YaToolTip.InitialDelay = 300;
            this.YaToolTip.IsBalloon = true;
            this.YaToolTip.ReshowDelay = 50;
            this.YaToolTip.ShowAlways = true;
            // 
            // PluginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.YaPanel);
            this.Controls.Add(this.YaType);
            this.Controls.Add(this.YaText);
            this.Controls.Add(this.YaCombo);
            this.Controls.Add(this.YaLabel);
            this.Name = "PluginControl";
            this.Size = new System.Drawing.Size(588, 505);
            this.YaPanel.ResumeLayout(false);
            this.YaPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label YaLabel;
        internal System.Windows.Forms.ComboBox YaCombo;
        internal System.Windows.Forms.TextBox YaText;
        internal System.Windows.Forms.Label YaType;
        internal System.Windows.Forms.Panel YaPanel;
        internal System.Windows.Forms.RadioButton radioButtonHandle;
        internal System.Windows.Forms.RadioButton radioButtonAlwaysHQ;
        internal System.Windows.Forms.RadioButton radioButtonAlwaysNQ;
        internal System.Windows.Forms.ComboBox comboBoxKey;
        private System.Windows.Forms.ToolTip YaToolTip;
    }
}
