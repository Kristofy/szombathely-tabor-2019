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
        public enum State { URES, EL, MEGHAL, SZULETIK };

        public Form1()
        {
            InitializeComponent();
        }

        int meret = 50;
        State[,] allapotTer;
        bool animateing;

        private void Form1_Load(object sender, EventArgs e)
        {
            int minMeret = this.Size.Height - 60 < this.Size.Width - 20 ? this.Size.Height - 60: this.Size.Width - 20;
            jatszoterDataGridView.Size = new Size(minMeret,minMeret);
            jatszoterDataGridView.DataSource = null;
            jatszoterDataGridView.ColumnCount = meret;
            jatszoterDataGridView.RowCount = meret;
            for (int i = 0; i < meret; i++)
            {
                jatszoterDataGridView.Columns[i].Width = jatszoterDataGridView.Size.Width / meret;
                jatszoterDataGridView.Rows[i].Height = jatszoterDataGridView.Size.Height / meret;
            }
            jatszoterDataGridView.AutoSize = false;
            this.AutoSize = true;
            allapotTer = new State[meret, meret];
            kiinduloAlakzatokComboBox.Items.Add("üres");
            kiinduloAlakzatokComboBox.Items.Add("vonal");
            kiinduloAlakzatokComboBox.Items.Add("kis robbanás");
            kiinduloAlakzatokComboBox.Items.Add("random");
            kiinduloAlakzatokComboBox.Items.Add("nagy robbanás");
        }

        private void jatszoterDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (allapotTer[e.RowIndex, e.ColumnIndex] == State.URES)
            {
                jatszoterDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Green;
                allapotTer[e.RowIndex, e.ColumnIndex] = State.EL;
            }
            else
            {
                jatszoterDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
                allapotTer[e.RowIndex, e.ColumnIndex] = State.URES;
            }
        }

        void gameOfLifeLepes()
        {
            // halál
            for (int i = 0; i < meret; i++)
            {
                for (int k = 0; k < meret; k++)
                {
                    int szomszedok = 0;
                    for (int x = -1; x <= 1; x++)
                    {
                        for (int y = -1; y <= 1; y++)
                        {
                            if (!(x == 0 && y == 0))
                            {
                                if (i + x >= 0 && i + x < meret && k + y >= 0 && k + y < meret)
                                {
                                    if (allapotTer[i + x, k + y] == State.EL || allapotTer[i + x, k + y] == State.MEGHAL)
                                    {
                                        szomszedok++;
                                    }
                                }
                            }

                        }
                    }
                    if ((szomszedok < 2 || szomszedok > 3) && (allapotTer[i, k] == State.EL || allapotTer[i, k] == State.MEGHAL))
                    {
                        allapotTer[i, k] = State.MEGHAL;

                    } else if (szomszedok == 3 && allapotTer[i, k] == State.URES)
                    {
                        allapotTer[i, k] = State.SZULETIK;
                    }
                }
            }

            //szuletes
            for (int i = 0; i < meret; i++)
            {
                for (int k = 0; k < meret; k++)
                {

                    if (allapotTer[i, k] == State.SZULETIK)
                    {
                        allapotTer[i, k] = State.EL;
                        jatszoterDataGridView.Rows[i].Cells[k].Style.BackColor = Color.Black;
                    }
                    else if (allapotTer[i, k] == State.MEGHAL)
                    {
                        allapotTer[i, k] = State.URES;
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

            if (current == "üres")
            {
                clear();
            }
            else if (current == "vonal")
            {
                clear();
                vonal();

            }
            else if (current == "kis robbanás")
            {
                clear();

                explode();

            } else if (current == "nagy robbanás") {
                clear();
                bigExpodition();
            } else if (current == "random")
            {
                fillWithRandom();
            }
            redraw();
        }

        private void vonal()
        {
            int center = meret / 2;
            for (int i = 0; i < meret; i++)
                for (int k = 0; k < meret; k++)
                    allapotTer[i, k] = 0;

            for (int i = -3; i <= 3; i++)
                allapotTer[center, center + i] = State.EL;
        }

        private void fillWithRandom()
        {
            Random rnd = new Random();
            for (int i = 0; i < meret; i++)
                for (int k = 0; k < meret; k++)
                    if (rnd.Next(1, 100) < 15)
                        allapotTer[i, k] = State.EL;
                    else
                        allapotTer[i, k] = 0;
        }

        private void bigExpodition()
        {
            int center = meret / 2;

            for (int i = -2; i <= 2; i++)
            {
                allapotTer[center + i, center - 2] = State.EL;
                allapotTer[center + i, center + 2] = State.EL;
            }
            allapotTer[center - 2, center] = State.EL;
            allapotTer[center + 2, center] = State.EL;

        }

        private void explode()
        {
            int center = meret / 2;
            allapotTer[center, center] = State.EL;
            allapotTer[center - 1, center] = State.EL;
            allapotTer[center, center - 1] = State.EL;
            allapotTer[center, center + 1] = State.EL;
            allapotTer[center + 1, center + 1] = State.EL;
            allapotTer[center + 1, center - 1] = State.EL;
            allapotTer[center + 2, center] = State.EL;
        }

        private void clear()
        {
            for (int i = 0; i < meret; i++)
                for (int k = 0; k < meret; k++)
                    allapotTer[i, k] = State.URES;
        }

        private void redraw()
        {
            for (int i = 0; i < meret; i++)
            {
                for (int k = 0; k < meret; k++)
                {
                    if (allapotTer[i, k] == State.EL)
                    {
                        jatszoterDataGridView.Rows[i].Cells[k].Style.BackColor = Color.Black;
                    }
                    else if (allapotTer[i, k] == State.URES)
                    {
                        jatszoterDataGridView.Rows[i].Cells[k].Style.BackColor = Color.White;
                    }
                }
            }
        }

        private void resetGrid()
        {
            jatszoterDataGridView.ColumnCount = meret;
            jatszoterDataGridView.RowCount = meret;
            for (int i = 0; i < meret; i++)
            {
                jatszoterDataGridView.Columns[i].Width = jatszoterDataGridView.Size.Width / meret;
                jatszoterDataGridView.Rows[i].Height = jatszoterDataGridView.Size.Height / meret;
            }
            allapotTer = new State[meret, meret];
        }

        private void speedTrackBar_Scroll(object sender, EventArgs e)
        {
            animateingTimer.Interval = speedTrackBar.Value;
            speedLabel.Text = Convert.ToString(speedTrackBar.Value) + "ms";
        }

        private void meretTrackBar_Scroll(object sender, EventArgs e)
        {
            meret = meretTrackBar.Value;
            resetGrid();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            int minMeret = this.Size.Height - 60 < this.Size.Width - 20 ? this.Size.Height - 60 : this.Size.Width - 20;
            jatszoterDataGridView.Size = new Size(minMeret, minMeret);
            resetGrid();
        }
    }
}
