using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int meret = 50;
        int[,] allapotTer;
        bool animateing;

        private void Form1_Load(object sender, EventArgs e)
        {
            jatszoterDataGridView.DataSource = null;
            jatszoterDataGridView.ColumnCount = 50;
            jatszoterDataGridView.RowCount = 50;
            for (int i = 0; i < meret; i++)
            {
                jatszoterDataGridView.Columns[i].Width = 10;
                jatszoterDataGridView.Rows[i].Height= 10;
            }
            jatszoterDataGridView.AutoSize = true;
            this.AutoSize = true;
            allapotTer = new int[meret, meret];
            kiinduloAlakzatokComboBox.Items.Add("üres");
            kiinduloAlakzatokComboBox.Items.Add("vonal");
            kiinduloAlakzatokComboBox.Items.Add("robbanás");
            kiinduloAlakzatokComboBox.Items.Add("random");
        }

        private void jatszoterDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(allapotTer[e.RowIndex, e.ColumnIndex] == 0)
            {
                jatszoterDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Green;
                allapotTer[e.RowIndex, e.ColumnIndex]=1;
            }
            else
            {
                jatszoterDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
                allapotTer[e.RowIndex, e.ColumnIndex] = 0;
            }
        }

        void gameOfLifeLepes()
        {
            // halál
            for (int i = 0; i < meret; i++)
            {
                for (int k = 0; k < meret; k++)
                {
                    int szomszedok=0;
                    for (int x = -1; x <= 1; x++)
                    {
                        for (int y = -1; y <= 1; y++)
                        {
                            if (!(x==0 && y==0))
                            {
                                if (i+x>=0&&i+x<meret&&k+y>=0&&k+y<meret)
                                {
                                    if (allapotTer[i + x, k + y]  == 1 || allapotTer[i + x, k + y] == -1)
                                    {
                                        szomszedok++;
                                    }
                                }
                            }

                        }
                    }
                    if ((szomszedok < 2 || szomszedok > 3)&&(allapotTer[i,k] == 1 || allapotTer[i,k] == -1))
                    {
                        allapotTer[i, k] = -1;
                        
                    }else if (szomszedok == 3 && (allapotTer[i, k] == 0 || allapotTer[i, k] == 2))
                    {
                        allapotTer[i, k] = 2;   
                    }
                }
            }

            //szuletes
            for (int i = 0; i < meret; i++)
            {
                for (int k = 0; k < meret; k++)
                {

                    if (allapotTer[i, k] > 0)
                    {
                        allapotTer[i, k] = 1;
                        jatszoterDataGridView.Rows[i].Cells[k].Style.BackColor = Color.Black;
                    }
                    else if (allapotTer[i, k] == -1)
                    {
                        allapotTer[i, k] = 0;
                        jatszoterDataGridView.Rows[i].Cells[k].Style.BackColor = Color.White;
                    }
                }
            }
        }

        private void kovetkezoButton_Click(object sender, EventArgs e)
        {
            gameOfLifeLepes();

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (animateing)
            {
                animateingTimer.Stop();
                startButton.Text = "Start";
            }
            else
            {
                animateingTimer.Start();
                startButton.Text = "Stop";
            }

            animateing = !animateing;
            
        }



        void gameOfLifeLepesAsync()
        {
           
        }

        private void jatszoterDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            jatszoterDataGridView.ClearSelection();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            gameOfLifeLepes();
        }

        private void kiinduloAlakzatokComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kiinduloAlakzatokComboBox.SelectedItem == null) return;
           string current = kiinduloAlakzatokComboBox.GetItemText(kiinduloAlakzatokComboBox.SelectedItem);
            int center = meret / 2;
            if (current == "üres")
            {
                for (int i = 0; i < meret; i++)
                    for (int k = 0; k < meret; k++)
                        allapotTer[i, k] = 0;


            }
            else if (current == "vonal")
            {
                for (int i = 0; i < meret; i++)
                    for (int k = 0; k < meret; k++)
                        allapotTer[i, k] = 0;

                for (int i = -3; i <= 3; i++)
                allapotTer[center, center + i] = 1;
       
            }
            else if (current == "robbanás")
            {
                for (int i = 0; i < meret; i++)
                    for (int k = 0; k < meret; k++)
                        allapotTer[i, k] = 0;

                allapotTer[center, center] = 1;
                allapotTer[center-1, center] = 1;
                allapotTer[center, center-1] = 1;
                allapotTer[center, center+1] = 1;
                allapotTer[center+1, center + 1] = 1;
                allapotTer[center+1, center -1] = 1;
                allapotTer[center+2, center] = 1;

            }else if(current == "random")
            {
                Random rnd = new Random();
                for (int i = 0; i < meret; i++)
                    for (int k = 0; k < meret; k++)
                        if (rnd.Next(1, 100) < 15)
                            allapotTer[i, k] = 1;
                        else
                            allapotTer[i, k] = 0;
            }
            redraw();
        }

        private void redraw()
        {
            for (int i = 0; i < meret; i++)
            {
                for (int k = 0; k < meret; k++)
                {
                    if (allapotTer[i, k] == 1)
                    {
                        jatszoterDataGridView.Rows[i].Cells[k].Style.BackColor = Color.Black;
                    }
                    else if (allapotTer[i, k] == 0)
                    {
                        jatszoterDataGridView.Rows[i].Cells[k].Style.BackColor = Color.White;
                    }
                }
            }
        }
    }
}
