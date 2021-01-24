namespace Async_Practical
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
            System.Windows.Forms.ColumnHeader url;
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lstScaningResult = new System.Windows.Forms.ListView();
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            url = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(488, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Process";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter URL";
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(105, 5);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(683, 20);
            this.txtURL.TabIndex = 2;
            this.txtURL.Text = "http://www.argumentexception.com";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(641, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Process Async";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // lstScaningResult
            // 
            this.lstScaningResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            url,
            this.status});
            this.lstScaningResult.GridLines = true;
            this.lstScaningResult.HideSelection = false;
            this.lstScaningResult.Location = new System.Drawing.Point(37, 80);
            this.lstScaningResult.Name = "lstScaningResult";
            this.lstScaningResult.Size = new System.Drawing.Size(751, 338);
            this.lstScaningResult.TabIndex = 4;
            this.lstScaningResult.UseCompatibleStateImageBehavior = false;
            this.lstScaningResult.View = System.Windows.Forms.View.Details;
            // 
            // url
            // 
            url.Text = "URL";
            url.Width = 546;
            // 
            // status
            // 
            this.status.Text = "Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstScaningResult);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Web Scanner - By Shahid Riaz Bhatti";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView lstScaningResult;
        private System.Windows.Forms.ColumnHeader status;
    }
}

