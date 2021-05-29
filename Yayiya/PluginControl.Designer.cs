
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
            this.YaLabel = new System.Windows.Forms.Label();
            this.YaCombo = new System.Windows.Forms.ComboBox();
            this.YaText = new System.Windows.Forms.TextBox();
            this.YaType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // YaLabel
            // 
            this.YaLabel.AutoSize = true;
            this.YaLabel.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.YaLabel.Location = new System.Drawing.Point(23, 24);
            this.YaLabel.Name = "YaLabel";
            this.YaLabel.Size = new System.Drawing.Size(19, 13);
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
            this.YaCombo.Location = new System.Drawing.Point(48, 21);
            this.YaCombo.Name = "YaCombo";
            this.YaCombo.Size = new System.Drawing.Size(121, 21);
            this.YaCombo.TabIndex = 1;
            this.YaCombo.SelectedIndexChanged += new System.EventHandler(this.YaCombo_SelectedIndexChanged);
            // 
            // YaText
            // 
            this.YaText.Enabled = false;
            this.YaText.Location = new System.Drawing.Point(175, 22);
            this.YaText.Name = "YaText";
            this.YaText.Size = new System.Drawing.Size(100, 20);
            this.YaText.TabIndex = 2;
            this.YaText.TextChanged += new System.EventHandler(this.YaText_TextChanged);
            // 
            // YaType
            // 
            this.YaType.AutoSize = true;
            this.YaType.Location = new System.Drawing.Point(281, 24);
            this.YaType.Name = "YaType";
            this.YaType.Size = new System.Drawing.Size(19, 13);
            this.YaType.TabIndex = 3;
            this.YaType.Text = "块";
            // 
            // PluginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.YaType);
            this.Controls.Add(this.YaText);
            this.Controls.Add(this.YaCombo);
            this.Controls.Add(this.YaLabel);
            this.Name = "PluginControl";
            this.Size = new System.Drawing.Size(588, 547);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label YaLabel;
        internal System.Windows.Forms.ComboBox YaCombo;
        internal System.Windows.Forms.TextBox YaText;
        internal System.Windows.Forms.Label YaType;
    }
}
