namespace whileLoop
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
            this.Even = new System.Windows.Forms.ListBox();
            this.btnEven = new System.Windows.Forms.Button();
            this.Odd = new System.Windows.Forms.ListBox();
            this.btnOdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Even
            // 
            this.Even.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Even.FormattingEnabled = true;
            this.Even.ItemHeight = 24;
            this.Even.Location = new System.Drawing.Point(51, 59);
            this.Even.Name = "Even";
            this.Even.Size = new System.Drawing.Size(152, 316);
            this.Even.TabIndex = 5;
            // 
            // btnEven
            // 
            this.btnEven.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEven.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEven.ForeColor = System.Drawing.Color.White;
            this.btnEven.Location = new System.Drawing.Point(51, 392);
            this.btnEven.Name = "btnEven";
            this.btnEven.Size = new System.Drawing.Size(146, 51);
            this.btnEven.TabIndex = 4;
            this.btnEven.Text = "Even";
            this.btnEven.UseVisualStyleBackColor = false;
            this.btnEven.Click += new System.EventHandler(this.btnEven_Click);
            // 
            // Odd
            // 
            this.Odd.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Odd.FormattingEnabled = true;
            this.Odd.ItemHeight = 24;
            this.Odd.Location = new System.Drawing.Point(271, 59);
            this.Odd.Name = "Odd";
            this.Odd.Size = new System.Drawing.Size(152, 316);
            this.Odd.TabIndex = 6;
            // 
            // btnOdd
            // 
            this.btnOdd.BackColor = System.Drawing.Color.Red;
            this.btnOdd.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdd.ForeColor = System.Drawing.Color.White;
            this.btnOdd.Location = new System.Drawing.Point(277, 392);
            this.btnOdd.Name = "btnOdd";
            this.btnOdd.Size = new System.Drawing.Size(146, 51);
            this.btnOdd.TabIndex = 7;
            this.btnOdd.Text = "Odd";
            this.btnOdd.UseVisualStyleBackColor = false;
            this.btnOdd.Click += new System.EventHandler(this.btnOdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 512);
            this.Controls.Add(this.btnOdd);
            this.Controls.Add(this.Odd);
            this.Controls.Add(this.Even);
            this.Controls.Add(this.btnEven);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Even;
        private System.Windows.Forms.Button btnEven;
        private System.Windows.Forms.ListBox Odd;
        private System.Windows.Forms.Button btnOdd;
    }
}

