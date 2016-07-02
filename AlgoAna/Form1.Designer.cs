namespace AlgoAna
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
            this.cmbSize = new System.Windows.Forms.ComboBox();
            this.cmbAlgo = new System.Windows.Forms.ComboBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtbefore = new System.Windows.Forms.TextBox();
            this.txtafter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbSize
            // 
            this.cmbSize.FormattingEnabled = true;
            this.cmbSize.Items.AddRange(new object[] {
            "10",
            "100",
            "10000",
            "100000"});
            this.cmbSize.Location = new System.Drawing.Point(26, 22);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(121, 21);
            this.cmbSize.TabIndex = 0;
            // 
            // cmbAlgo
            // 
            this.cmbAlgo.FormattingEnabled = true;
            this.cmbAlgo.Items.AddRange(new object[] {
            "Shell Sort",
            "Heap Sort",
            "Bucket Sort"});
            this.cmbAlgo.Location = new System.Drawing.Point(182, 22);
            this.cmbAlgo.Name = "cmbAlgo";
            this.cmbAlgo.Size = new System.Drawing.Size(144, 21);
            this.cmbAlgo.TabIndex = 1;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(182, 65);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(211, 20);
            this.txtTime.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(275, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtbefore
            // 
            this.txtbefore.Location = new System.Drawing.Point(26, 148);
            this.txtbefore.Multiline = true;
            this.txtbefore.Name = "txtbefore";
            this.txtbefore.Size = new System.Drawing.Size(211, 205);
            this.txtbefore.TabIndex = 4;
            // 
            // txtafter
            // 
            this.txtafter.Location = new System.Drawing.Point(264, 148);
            this.txtafter.Multiline = true;
            this.txtafter.Name = "txtafter";
            this.txtafter.Size = new System.Drawing.Size(211, 205);
            this.txtafter.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 365);
            this.Controls.Add(this.txtafter);
            this.Controls.Add(this.txtbefore);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.cmbAlgo);
            this.Controls.Add(this.cmbSize);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSize;
        private System.Windows.Forms.ComboBox cmbAlgo;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtbefore;
        private System.Windows.Forms.TextBox txtafter;
    }
}

