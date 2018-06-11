namespace MTNBachUpHTTP1v2
{
    partial class Main
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
            this.btnFetch = new System.Windows.Forms.Button();
            this.tbxDisplay = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbxFinalDisplay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnFetch
            // 
            this.btnFetch.Location = new System.Drawing.Point(13, 13);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(75, 23);
            this.btnFetch.TabIndex = 0;
            this.btnFetch.Text = "Fetch";
            this.btnFetch.UseVisualStyleBackColor = true;
            this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click);
            // 
            // tbxDisplay
            // 
            this.tbxDisplay.Location = new System.Drawing.Point(13, 43);
            this.tbxDisplay.Multiline = true;
            this.tbxDisplay.Name = "tbxDisplay";
            this.tbxDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxDisplay.Size = new System.Drawing.Size(465, 74);
            this.tbxDisplay.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(13, 485);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbxFinalDisplay
            // 
            this.tbxFinalDisplay.Location = new System.Drawing.Point(13, 161);
            this.tbxFinalDisplay.Multiline = true;
            this.tbxFinalDisplay.Name = "tbxFinalDisplay";
            this.tbxFinalDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxFinalDisplay.Size = new System.Drawing.Size(465, 318);
            this.tbxFinalDisplay.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Final:";
            // 
            // openFileDlg
            // 
            this.openFileDlg.FileName = "openFileDialog1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 520);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxFinalDisplay);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbxDisplay);
            this.Controls.Add(this.btnFetch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFetch;
        private System.Windows.Forms.TextBox tbxDisplay;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbxFinalDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDlg;
    }
}

