namespace companion
{
    partial class MainForm
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
      this.reloadButton = new System.Windows.Forms.Button();
      this.outputText = new System.Windows.Forms.TextBox();
      this.clearButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // reloadButton
      // 
      this.reloadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.reloadButton.Location = new System.Drawing.Point(558, 395);
      this.reloadButton.Name = "reloadButton";
      this.reloadButton.Size = new System.Drawing.Size(75, 23);
      this.reloadButton.TabIndex = 1;
      this.reloadButton.Text = "Reload";
      this.reloadButton.UseVisualStyleBackColor = true;
      // 
      // outputText
      // 
      this.outputText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.outputText.Location = new System.Drawing.Point(13, 13);
      this.outputText.Multiline = true;
      this.outputText.Name = "outputText";
      this.outputText.Size = new System.Drawing.Size(620, 376);
      this.outputText.TabIndex = 2;
      // 
      // clearButton
      // 
      this.clearButton.Location = new System.Drawing.Point(13, 395);
      this.clearButton.Name = "clearButton";
      this.clearButton.Size = new System.Drawing.Size(75, 23);
      this.clearButton.TabIndex = 3;
      this.clearButton.Text = "Clear";
      this.clearButton.UseVisualStyleBackColor = true;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(645, 430);
      this.Controls.Add(this.clearButton);
      this.Controls.Add(this.outputText);
      this.Controls.Add(this.reloadButton);
      this.MaximizeBox = false;
      this.Name = "MainForm";
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.Text = "Companion";
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reloadButton;
        private System.Windows.Forms.TextBox outputText;
        private System.Windows.Forms.Button clearButton;

    }
}

