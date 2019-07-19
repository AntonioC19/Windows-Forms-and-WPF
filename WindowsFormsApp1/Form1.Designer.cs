namespace WindowsFormsApp1
{
    partial class Form1
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
            this.BtnProcessFile = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnProcessFile
            // 
            this.BtnProcessFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnProcessFile.Location = new System.Drawing.Point(273, 74);
            this.BtnProcessFile.Name = "BtnProcessFile";
            this.BtnProcessFile.Size = new System.Drawing.Size(277, 60);
            this.BtnProcessFile.TabIndex = 0;
            this.BtnProcessFile.Text = "Process FIle";
            this.BtnProcessFile.UseVisualStyleBackColor = true;
            this.BtnProcessFile.Click += new System.EventHandler(this.BtnProcessFile_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(298, 186);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 13);
            this.lblCount.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.BtnProcessFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnProcessFile;
        private System.Windows.Forms.Label lblCount;
    }
}

