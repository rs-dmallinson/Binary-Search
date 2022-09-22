namespace Binary_Search
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_Index1 = new System.Windows.Forms.TextBox();
            this.txt_Index2 = new System.Windows.Forms.TextBox();
            this.txt_Index3 = new System.Windows.Forms.TextBox();
            this.txtSearchNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(333, 84);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 0;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_Index1
            // 
            this.txt_Index1.Location = new System.Drawing.Point(140, 163);
            this.txt_Index1.Name = "txt_Index1";
            this.txt_Index1.Size = new System.Drawing.Size(100, 23);
            this.txt_Index1.TabIndex = 1;
            // 
            // txt_Index2
            // 
            this.txt_Index2.Location = new System.Drawing.Point(321, 163);
            this.txt_Index2.Name = "txt_Index2";
            this.txt_Index2.Size = new System.Drawing.Size(100, 23);
            this.txt_Index2.TabIndex = 2;
            // 
            // txt_Index3
            // 
            this.txt_Index3.Location = new System.Drawing.Point(503, 163);
            this.txt_Index3.Name = "txt_Index3";
            this.txt_Index3.Size = new System.Drawing.Size(100, 23);
            this.txt_Index3.TabIndex = 3;
            // 
            // txtSearchNumber
            // 
            this.txtSearchNumber.Location = new System.Drawing.Point(321, 28);
            this.txtSearchNumber.Name = "txtSearchNumber";
            this.txtSearchNumber.Size = new System.Drawing.Size(100, 23);
            this.txtSearchNumber.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSearchNumber);
            this.Controls.Add(this.txt_Index3);
            this.Controls.Add(this.txt_Index2);
            this.Controls.Add(this.txt_Index1);
            this.Controls.Add(this.btn_Search);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button btn_Search;
        private TextBox txt_Index1;
        private TextBox txt_Index2;
        private TextBox txt_Index3;
        private TextBox txtSearchNumber;
    }
}