namespace THB
{
    partial class Scratch
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
            this.BuyPanel = new MetroFramework.Controls.MetroPanel();
            this.SuspendLayout();
            // 
            // BuyPanel
            // 
            this.BuyPanel.HorizontalScrollbarBarColor = true;
            this.BuyPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.BuyPanel.HorizontalScrollbarSize = 10;
            this.BuyPanel.Location = new System.Drawing.Point(37, 50);
            this.BuyPanel.Name = "BuyPanel";
            this.BuyPanel.Size = new System.Drawing.Size(759, 513);
            this.BuyPanel.TabIndex = 1;
            this.BuyPanel.VerticalScrollbarBarColor = true;
            this.BuyPanel.VerticalScrollbarHighlightOnWheel = false;
            this.BuyPanel.VerticalScrollbarSize = 10;
            // 
            // Scratch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 612);
            this.Controls.Add(this.BuyPanel);
            this.Name = "Scratch";
            this.Text = "Scratch";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel BuyPanel;
    }
}