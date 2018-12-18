namespace INNForm
{
    partial class INN
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SeriyaInn = new System.Windows.Forms.TextBox();
            this.InnInForm = new System.Windows.Forms.TextBox();
            this.IDInn = new System.Windows.Forms.TextBox();
            this.DateInn = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Seriya";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "INN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "№";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Date";
            // 
            // SeriyaInn
            // 
            this.SeriyaInn.Location = new System.Drawing.Point(84, 177);
            this.SeriyaInn.Name = "SeriyaInn";
            this.SeriyaInn.Size = new System.Drawing.Size(82, 20);
            this.SeriyaInn.TabIndex = 11;
            // 
            // InnInForm
            // 
            this.InnInForm.Location = new System.Drawing.Point(225, 177);
            this.InnInForm.Name = "InnInForm";
            this.InnInForm.Size = new System.Drawing.Size(74, 20);
            this.InnInForm.TabIndex = 10;
            // 
            // IDInn
            // 
            this.IDInn.Location = new System.Drawing.Point(225, 105);
            this.IDInn.Name = "IDInn";
            this.IDInn.Size = new System.Drawing.Size(74, 20);
            this.IDInn.TabIndex = 9;
            // 
            // DateInn
            // 
            this.DateInn.Location = new System.Drawing.Point(84, 105);
            this.DateInn.Name = "DateInn";
            this.DateInn.Size = new System.Drawing.Size(82, 20);
            this.DateInn.TabIndex = 8;
            // 
            // INN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 280);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SeriyaInn);
            this.Controls.Add(this.InnInForm);
            this.Controls.Add(this.IDInn);
            this.Controls.Add(this.DateInn);
            this.Name = "INN";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.INN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SeriyaInn;
        private System.Windows.Forms.TextBox InnInForm;
        private System.Windows.Forms.TextBox IDInn;
        private System.Windows.Forms.TextBox DateInn;
    }
}

