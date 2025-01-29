namespace GUI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.labelMessage = new System.Windows.Forms.Label();
            this.textBoxGuess = new System.Windows.Forms.TextBox();
            this.buttonGuess = new System.Windows.Forms.Button();
            this.listBoxResults = new System.Windows.Forms.ListBox();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(12, 9);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(209, 16);
            this.labelMessage.TabIndex = 0;
            this.labelMessage.Text = "Thử đoán 1 số có đủ 4 chữ số nào.";
            // 
            // textBoxGuess
            // 
            this.textBoxGuess.Location = new System.Drawing.Point(12, 47);
            this.textBoxGuess.Name = "textBoxGuess";
            this.textBoxGuess.Size = new System.Drawing.Size(101, 22);
            this.textBoxGuess.TabIndex = 1;
            this.textBoxGuess.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxGuess_KeyPress);
            // 
            // buttonGuess
            // 
            this.buttonGuess.Location = new System.Drawing.Point(136, 47);
            this.buttonGuess.Name = "buttonGuess";
            this.buttonGuess.Size = new System.Drawing.Size(75, 23);
            this.buttonGuess.TabIndex = 2;
            this.buttonGuess.Text = "Đoán";
            this.buttonGuess.UseVisualStyleBackColor = true;
            this.buttonGuess.Click += new System.EventHandler(this.buttonGuess_Click);
            // 
            // listBoxResults
            // 
            this.listBoxResults.FormattingEnabled = true;
            this.listBoxResults.ItemHeight = 16;
            this.listBoxResults.Location = new System.Drawing.Point(231, 36);
            this.listBoxResults.Name = "listBoxResults";
            this.listBoxResults.Size = new System.Drawing.Size(198, 276);
            this.listBoxResults.TabIndex = 3;
            // 
            // buttonRestart
            // 
            this.buttonRestart.Location = new System.Drawing.Point(12, 90);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(199, 49);
            this.buttonRestart.TabIndex = 4;
            this.buttonRestart.Text = "Chơi lại";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonGuess;
            this.ClientSize = new System.Drawing.Size(446, 323);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.listBoxResults);
            this.Controls.Add(this.buttonGuess);
            this.Controls.Add(this.textBoxGuess);
            this.Controls.Add(this.labelMessage);
            this.Name = "Form1";
            this.Text = "Bulls and Cows";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.TextBox textBoxGuess;
        private System.Windows.Forms.Button buttonGuess;
        private System.Windows.Forms.ListBox listBoxResults;
        private System.Windows.Forms.Button buttonRestart;
    }
}
