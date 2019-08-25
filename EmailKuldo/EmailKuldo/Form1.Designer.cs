namespace EmailKuldo
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
            this.send = new System.Windows.Forms.Button();
            this.kuldoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.jelszoTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cimzettToTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.targyTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.szovegTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.csatolmanyTextBox = new System.Windows.Forms.TextBox();
            this.sdf = new System.Windows.Forms.Label();
            this.csatolmanyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(225, 543);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(75, 23);
            this.send.TabIndex = 8;
            this.send.Text = "Elküld";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // kuldoTextBox
            // 
            this.kuldoTextBox.Location = new System.Drawing.Point(120, 30);
            this.kuldoTextBox.Name = "kuldoTextBox";
            this.kuldoTextBox.Size = new System.Drawing.Size(233, 20);
            this.kuldoTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // jelszoTextBox
            // 
            this.jelszoTextBox.Location = new System.Drawing.Point(120, 67);
            this.jelszoTextBox.Name = "jelszoTextBox";
            this.jelszoTextBox.PasswordChar = '*';
            this.jelszoTextBox.Size = new System.Drawing.Size(233, 20);
            this.jelszoTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jelszó";
            // 
            // cimzettToTextBox
            // 
            this.cimzettToTextBox.Location = new System.Drawing.Point(120, 122);
            this.cimzettToTextBox.Name = "cimzettToTextBox";
            this.cimzettToTextBox.Size = new System.Drawing.Size(292, 20);
            this.cimzettToTextBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Címzett";
            // 
            // targyTextBox
            // 
            this.targyTextBox.Location = new System.Drawing.Point(120, 159);
            this.targyTextBox.Name = "targyTextBox";
            this.targyTextBox.Size = new System.Drawing.Size(292, 20);
            this.targyTextBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tárgy";
            // 
            // szovegTextBox
            // 
            this.szovegTextBox.Location = new System.Drawing.Point(120, 217);
            this.szovegTextBox.Multiline = true;
            this.szovegTextBox.Name = "szovegTextBox";
            this.szovegTextBox.Size = new System.Drawing.Size(292, 239);
            this.szovegTextBox.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Szöveg";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(359, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "@gmail.com";
            // 
            // csatolmanyTextBox
            // 
            this.csatolmanyTextBox.Location = new System.Drawing.Point(120, 493);
            this.csatolmanyTextBox.Name = "csatolmanyTextBox";
            this.csatolmanyTextBox.ReadOnly = true;
            this.csatolmanyTextBox.Size = new System.Drawing.Size(192, 20);
            this.csatolmanyTextBox.TabIndex = 6;
            // 
            // sdf
            // 
            this.sdf.AutoSize = true;
            this.sdf.Location = new System.Drawing.Point(17, 493);
            this.sdf.Name = "sdf";
            this.sdf.Size = new System.Drawing.Size(61, 13);
            this.sdf.TabIndex = 10;
            this.sdf.Text = "Csatolmány";
            // 
            // csatolmanyButton
            // 
            this.csatolmanyButton.Location = new System.Drawing.Point(337, 491);
            this.csatolmanyButton.Name = "csatolmanyButton";
            this.csatolmanyButton.Size = new System.Drawing.Size(75, 23);
            this.csatolmanyButton.TabIndex = 7;
            this.csatolmanyButton.Text = "Tallóz";
            this.csatolmanyButton.UseVisualStyleBackColor = true;
            this.csatolmanyButton.Click += new System.EventHandler(this.csatolmanyButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 597);
            this.Controls.Add(this.csatolmanyButton);
            this.Controls.Add(this.sdf);
            this.Controls.Add(this.csatolmanyTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.szovegTextBox);
            this.Controls.Add(this.targyTextBox);
            this.Controls.Add(this.cimzettToTextBox);
            this.Controls.Add(this.jelszoTextBox);
            this.Controls.Add(this.kuldoTextBox);
            this.Controls.Add(this.send);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "EmailKuldo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button send;
        private System.Windows.Forms.TextBox kuldoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox jelszoTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cimzettToTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox targyTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox szovegTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox csatolmanyTextBox;
        private System.Windows.Forms.Label sdf;
        private System.Windows.Forms.Button csatolmanyButton;
    }
}

