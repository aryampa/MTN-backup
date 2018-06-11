namespace MTNBachUpHTTP1v2
{
    partial class GetData
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxSID = new System.Windows.Forms.TextBox();
            this.tbxContNum = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of Contacts:";
            // 
            // tbxSID
            // 
            this.tbxSID.Location = new System.Drawing.Point(47, 13);
            this.tbxSID.Name = "tbxSID";
            this.tbxSID.Size = new System.Drawing.Size(157, 20);
            this.tbxSID.TabIndex = 2;
            // 
            // tbxContNum
            // 
            this.tbxContNum.Location = new System.Drawing.Point(126, 48);
            this.tbxContNum.Name = "tbxContNum";
            this.tbxContNum.Size = new System.Drawing.Size(78, 20);
            this.tbxContNum.TabIndex = 3;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(47, 99);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(156, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // GetData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 134);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbxContNum);
            this.Controls.Add(this.tbxSID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GetData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GetData";
            this.Load += new System.EventHandler(this.GetData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxSID;
        private System.Windows.Forms.TextBox tbxContNum;
        private System.Windows.Forms.Button btnOK;
    }
}