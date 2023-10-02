namespace _3_yazılıyı_toplama
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
            this.btnHeapla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.txtSayı1 = new System.Windows.Forms.TextBox();
            this.txtSayı2 = new System.Windows.Forms.TextBox();
            this.txtSayı3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnHeapla
            // 
            this.btnHeapla.Location = new System.Drawing.Point(29, 207);
            this.btnHeapla.Name = "btnHeapla";
            this.btnHeapla.Size = new System.Drawing.Size(182, 61);
            this.btnHeapla.TabIndex = 0;
            this.btnHeapla.Text = "toplamını hesapla";
            this.btnHeapla.UseVisualStyleBackColor = true;
            this.btnHeapla.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "sayı1=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "sayı2=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "sayı3=";
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(10, 155);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(47, 15);
            this.lblSonuc.TabIndex = 4;
            this.lblSonuc.Text = "sonuç=";
            // 
            // txtSayı1
            // 
            this.txtSayı1.Location = new System.Drawing.Point(73, 23);
            this.txtSayı1.Name = "txtSayı1";
            this.txtSayı1.Size = new System.Drawing.Size(100, 23);
            this.txtSayı1.TabIndex = 5;
            // 
            // txtSayı2
            // 
            this.txtSayı2.Location = new System.Drawing.Point(73, 54);
            this.txtSayı2.Name = "txtSayı2";
            this.txtSayı2.Size = new System.Drawing.Size(100, 23);
            this.txtSayı2.TabIndex = 6;
            // 
            // txtSayı3
            // 
            this.txtSayı3.Location = new System.Drawing.Point(73, 89);
            this.txtSayı3.Name = "txtSayı3";
            this.txtSayı3.Size = new System.Drawing.Size(100, 23);
            this.txtSayı3.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 450);
            this.Controls.Add(this.txtSayı3);
            this.Controls.Add(this.txtSayı2);
            this.Controls.Add(this.txtSayı1);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHeapla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnHeapla;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblSonuc;
        private TextBox txtSayı1;
        private TextBox txtSayı2;
        private TextBox txtSayı3;
    }
}