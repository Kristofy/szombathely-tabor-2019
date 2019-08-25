namespace Adatbázisok
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nevTextBox = new System.Windows.Forms.TextBox();
            this.korTextBox = new System.Windows.Forms.TextBox();
            this.ferfiRadioButton = new System.Windows.Forms.RadioButton();
            this.noRadioButton = new System.Windows.Forms.RadioButton();
            this.tulajdonsagokCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mentesButton = new System.Windows.Forms.Button();
            this.torlesButton = new System.Windows.Forms.Button();
            this.megseButton = new System.Windows.Forms.Button();
            this.tanulokDataGridView = new System.Windows.Forms.DataGridView();
            this.nemComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tanulokDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nem:";
            // 
            // nevTextBox
            // 
            this.nevTextBox.Location = new System.Drawing.Point(93, 22);
            this.nevTextBox.Name = "nevTextBox";
            this.nevTextBox.Size = new System.Drawing.Size(220, 20);
            this.nevTextBox.TabIndex = 1;
            // 
            // korTextBox
            // 
            this.korTextBox.Location = new System.Drawing.Point(93, 58);
            this.korTextBox.Name = "korTextBox";
            this.korTextBox.Size = new System.Drawing.Size(220, 20);
            this.korTextBox.TabIndex = 2;
            // 
            // ferfiRadioButton
            // 
            this.ferfiRadioButton.AutoSize = true;
            this.ferfiRadioButton.Checked = true;
            this.ferfiRadioButton.Location = new System.Drawing.Point(92, 94);
            this.ferfiRadioButton.Name = "ferfiRadioButton";
            this.ferfiRadioButton.Size = new System.Drawing.Size(45, 17);
            this.ferfiRadioButton.TabIndex = 3;
            this.ferfiRadioButton.TabStop = true;
            this.ferfiRadioButton.Text = "Férfi";
            this.ferfiRadioButton.UseVisualStyleBackColor = true;
            // 
            // noRadioButton
            // 
            this.noRadioButton.AutoSize = true;
            this.noRadioButton.Location = new System.Drawing.Point(153, 94);
            this.noRadioButton.Name = "noRadioButton";
            this.noRadioButton.Size = new System.Drawing.Size(39, 17);
            this.noRadioButton.TabIndex = 4;
            this.noRadioButton.TabStop = true;
            this.noRadioButton.Text = "Nő";
            this.noRadioButton.UseVisualStyleBackColor = true;
            // 
            // tulajdonsagokCheckedListBox
            // 
            this.tulajdonsagokCheckedListBox.CheckOnClick = true;
            this.tulajdonsagokCheckedListBox.FormattingEnabled = true;
            this.tulajdonsagokCheckedListBox.Items.AddRange(new object[] {
            "Bátor",
            "Merész",
            "Vakmező",
            "Udvarias",
            "Ambiciózus",
            "Vezető egyéniség",
            "Határozott",
            "Ravasz",
            "Kedves",
            "Barátságos",
            "Önzetlen",
            "Hűséges",
            "Kreatív",
            "Bölcs",
            "Inteligens",
            "Okos"});
            this.tulajdonsagokCheckedListBox.Location = new System.Drawing.Point(92, 168);
            this.tulajdonsagokCheckedListBox.Name = "tulajdonsagokCheckedListBox";
            this.tulajdonsagokCheckedListBox.Size = new System.Drawing.Size(220, 244);
            this.tulajdonsagokCheckedListBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tulajdonságok:";
            // 
            // mentesButton
            // 
            this.mentesButton.Location = new System.Drawing.Point(39, 476);
            this.mentesButton.Name = "mentesButton";
            this.mentesButton.Size = new System.Drawing.Size(75, 23);
            this.mentesButton.TabIndex = 6;
            this.mentesButton.Text = "Mentés";
            this.mentesButton.UseVisualStyleBackColor = true;
            this.mentesButton.Click += new System.EventHandler(this.mentesButton_Click);
            // 
            // torlesButton
            // 
            this.torlesButton.Location = new System.Drawing.Point(139, 476);
            this.torlesButton.Name = "torlesButton";
            this.torlesButton.Size = new System.Drawing.Size(75, 23);
            this.torlesButton.TabIndex = 7;
            this.torlesButton.Text = "Törlés";
            this.torlesButton.UseVisualStyleBackColor = true;
            this.torlesButton.Click += new System.EventHandler(this.torlesButton_Click);
            // 
            // megseButton
            // 
            this.megseButton.Location = new System.Drawing.Point(237, 476);
            this.megseButton.Name = "megseButton";
            this.megseButton.Size = new System.Drawing.Size(75, 23);
            this.megseButton.TabIndex = 8;
            this.megseButton.Text = "Mégse";
            this.megseButton.UseVisualStyleBackColor = true;
            this.megseButton.Click += new System.EventHandler(this.megseButton_Click);
            // 
            // tanulokDataGridView
            // 
            this.tanulokDataGridView.AllowUserToAddRows = false;
            this.tanulokDataGridView.AllowUserToDeleteRows = false;
            this.tanulokDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.tanulokDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tanulokDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tanulokDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.tanulokDataGridView.Location = new System.Drawing.Point(356, 25);
            this.tanulokDataGridView.Name = "tanulokDataGridView";
            this.tanulokDataGridView.RowHeadersVisible = false;
            this.tanulokDataGridView.Size = new System.Drawing.Size(522, 474);
            this.tanulokDataGridView.TabIndex = 6;
            this.tanulokDataGridView.DoubleClick += new System.EventHandler(this.tanulokDataGridView_DoubleClick);
            // 
            // nemComboBox
            // 
            this.nemComboBox.FormattingEnabled = true;
            this.nemComboBox.Items.AddRange(new object[] {
            "Férfi",
            "Nő"});
            this.nemComboBox.Location = new System.Drawing.Point(469, 3);
            this.nemComboBox.Name = "nemComboBox";
            this.nemComboBox.Size = new System.Drawing.Size(121, 21);
            this.nemComboBox.TabIndex = 9;
            this.nemComboBox.SelectedIndexChanged += new System.EventHandler(this.nemComboBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 523);
            this.Controls.Add(this.nemComboBox);
            this.Controls.Add(this.tanulokDataGridView);
            this.Controls.Add(this.megseButton);
            this.Controls.Add(this.torlesButton);
            this.Controls.Add(this.mentesButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tulajdonsagokCheckedListBox);
            this.Controls.Add(this.noRadioButton);
            this.Controls.Add(this.ferfiRadioButton);
            this.Controls.Add(this.korTextBox);
            this.Controls.Add(this.nevTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "TeszlekSuveg";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tanulokDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nevTextBox;
        private System.Windows.Forms.TextBox korTextBox;
        private System.Windows.Forms.RadioButton ferfiRadioButton;
        private System.Windows.Forms.RadioButton noRadioButton;
        private System.Windows.Forms.CheckedListBox tulajdonsagokCheckedListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button mentesButton;
        private System.Windows.Forms.Button torlesButton;
        private System.Windows.Forms.Button megseButton;
        private System.Windows.Forms.DataGridView tanulokDataGridView;
        private System.Windows.Forms.ComboBox nemComboBox;
    }
}

