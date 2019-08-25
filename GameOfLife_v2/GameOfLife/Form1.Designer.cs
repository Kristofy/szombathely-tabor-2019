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
            this.speedTrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.speedLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.meretTrackBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.jatszoterDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meretTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // jatszoterDataGridView
            // 
            this.jatszoterDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.jatszoterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jatszoterDataGridView.ColumnHeadersVisible = false;
            this.jatszoterDataGridView.Location = new System.Drawing.Point(10, 50);
            this.jatszoterDataGridView.Name = "jatszoterDataGridView";
            this.jatszoterDataGridView.RowHeadersVisible = false;
            this.jatszoterDataGridView.Size = new System.Drawing.Size(800, 800);
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
            this.startButton.Location = new System.Drawing.Point(249, 12);
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
            this.animateingTimer.Interval = 50;
            this.animateingTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // speedTrackBar
            // 
            this.speedTrackBar.Location = new System.Drawing.Point(404, 2);
            this.speedTrackBar.Maximum = 100;
            this.speedTrackBar.Minimum = 1;
            this.speedTrackBar.Name = "speedTrackBar";
            this.speedTrackBar.Size = new System.Drawing.Size(131, 45);
            this.speedTrackBar.TabIndex = 4;
            this.speedTrackBar.Value = 50;
            this.speedTrackBar.Scroll += new System.EventHandler(this.speedTrackBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(330, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "sebesség:";
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Location = new System.Drawing.Point(541, 13);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(32, 13);
            this.speedLabel.TabIndex = 6;
            this.speedLabel.Text = "50ms";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(579, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "méret:";
            // 
            // meretTrackBar
            // 
            this.meretTrackBar.Location = new System.Drawing.Point(633, 2);
            this.meretTrackBar.Maximum = 200;
            this.meretTrackBar.Minimum = 10;
            this.meretTrackBar.Name = "meretTrackBar";
            this.meretTrackBar.Size = new System.Drawing.Size(131, 45);
            this.meretTrackBar.TabIndex = 8;
            this.meretTrackBar.Value = 50;
            this.meretTrackBar.Scroll += new System.EventHandler(this.meretTrackBar_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.meretTrackBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.speedTrackBar);
            this.Controls.Add(this.kovetkezoButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.kiinduloAlakzatokComboBox);
            this.Controls.Add(this.jatszoterDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "GameOfLife";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.jatszoterDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meretTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView jatszoterDataGridView;
        private System.Windows.Forms.ComboBox kiinduloAlakzatokComboBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button kovetkezoButton;
        private System.Windows.Forms.Timer animateingTimer;
        private System.Windows.Forms.TrackBar speedTrackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar meretTrackBar;
    }
}

