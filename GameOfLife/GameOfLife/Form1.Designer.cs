using System;

namespace GameOfLife
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
            this.components = new System.ComponentModel.Container();
            this.jatszoterDataGridView = new System.Windows.Forms.DataGridView();
            this.kiinduloAlakzatokComboBox = new System.Windows.Forms.ComboBox();
            this.startButton = new System.Windows.Forms.Button();
            this.kovetkezoButton = new System.Windows.Forms.Button();
            this.animateingTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.jatszoterDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // jatszoterDataGridView
            // 
            this.jatszoterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jatszoterDataGridView.Location = new System.Drawing.Point(29, 53);
            this.jatszoterDataGridView.Name = "jatszoterDataGridView";
            this.jatszoterDataGridView.Size = new System.Drawing.Size(240, 150);
            this.jatszoterDataGridView.TabIndex = 0;
            this.jatszoterDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.jatszoterDataGridView_CellClick);
            this.jatszoterDataGridView.SelectionChanged += new System.EventHandler(this.jatszoterDataGridView_SelectionChanged);
            // 
            // kiinduloAlakzatokComboBox
            // 
            this.kiinduloAlakzatokComboBox.FormattingEnabled = true;
            this.kiinduloAlakzatokComboBox.Location = new System.Drawing.Point(29, 12);
            this.kiinduloAlakzatokComboBox.Name = "kiinduloAlakzatokComboBox";
            this.kiinduloAlakzatokComboBox.Size = new System.Drawing.Size(121, 21);
            this.kiinduloAlakzatokComboBox.TabIndex = 1;
            this.kiinduloAlakzatokComboBox.SelectedIndexChanged += new System.EventHandler(this.kiinduloAlakzatokComboBox_SelectedIndexChanged);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(259, 10);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // kovetkezoButton
            // 
            this.kovetkezoButton.Location = new System.Drawing.Point(168, 12);
            this.kovetkezoButton.Name = "kovetkezoButton";
            this.kovetkezoButton.Size = new System.Drawing.Size(75, 23);
            this.kovetkezoButton.TabIndex = 3;
            this.kovetkezoButton.Text = "Következő";
            this.kovetkezoButton.UseVisualStyleBackColor = true;
            this.kovetkezoButton.Click += new System.EventHandler(this.kovetkezoButton_Click);
            // 
            // animateingTimer
            // 
            this.animateingTimer.Interval = 10;
            this.animateingTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kovetkezoButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.kiinduloAlakzatokComboBox);
            this.Controls.Add(this.jatszoterDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "GameOfLife";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jatszoterDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView jatszoterDataGridView;
        private System.Windows.Forms.ComboBox kiinduloAlakzatokComboBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button kovetkezoButton;
        private System.Windows.Forms.Timer animateingTimer;
    }
}

