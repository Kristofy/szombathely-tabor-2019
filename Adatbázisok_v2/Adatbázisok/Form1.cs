using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adatbázisok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Tanulo tanulo = new Tanulo();

        private void Form1_Load(object sender, EventArgs e)
        {
            tanulokDataGridView.AutoSize = true;
            tulajdonsagokCheckedListBox.Items.Clear();
            this.AutoSize = true;
            (new List<string>() {
                "Kreatív", "Bölcs", "Inteligens", "Okos",
                "Kedves","Barátságos", "Önzetlen","Hűséges",
                "Ravasz","Ambiziózus","Vezető egyéniség","Határozott",
                "Bátor", "Merész","Vakmerő", "Udvarias"})
                .ForEach(t => tulajdonsagokCheckedListBox.Items.Add(t));
            load();            
        }

        private void mentesButton_Click(object sender, EventArgs e)
        {
            if (mentesButton.Text == "Mentés") {
                tanulo.nev = nevTextBox.Text;
                tanulo.kor = Convert.ToInt32(korTextBox.Text);
                tanulo.nem = ferfiRadioButton.Checked ? "férfi" : "nő";
                // Hollóhát , Hugrabug, Mardekár, Griffendél
                int[] hazak = new int[4];
                    foreach (var s in tulajdonsagokCheckedListBox.CheckedItems)
                    {
                        tanulo.tulajdonsagok += s + ",";
                        hazak[tulajdonsagokCheckedListBox.Items.IndexOf(s) / 4]++;
                    }
                tanulo.haz = (new string[]{ "Hollóhát", "Hugrabug", "Mardekár", "Griffendél" })[hazak.ToList().IndexOf(hazak.ToList().Max())];
                writeSingle();


            }
            else
            {

                tanulo.nev = nevTextBox.Text;
                tanulo.kor = Convert.ToInt32(korTextBox.Text);
                tanulo.nem = ferfiRadioButton.Checked ? "férfi" : "nő";
                Connection db = new Connection();
                db.Entry(tanulo).State = EntityState.Modified;
           
                db.SaveChanges();

            }
            tulajdonsagokCheckedListBox.Enabled = true;
            clear();
            load();
            if (mentesButton.Text == "Módosítás")
                mentesButton.Text = "Mentés";
        }

        private void load()
        {
            Connection db = new Connection();
            tanulokDataGridView.DataSource = db.Tanulok.ToList();
            #region TXT
            /*
        tanulok.Clear();
        tanulok = new BindingList<Tanulo>(File.ReadAllLines("Tanulok.txt")
            .Select(e => e.Split(';'))
            .Select(e => new Tanulo(e[0], Convert.ToInt32(e[1]), e[2], e[3], e[4])).ToList());
        tanulokDataGridView.DataSource = tanulok;
        */
            #endregion;

        }
        private void writeSingle()
        {
            Connection db = new Connection();
            db.Tanulok.Add(tanulo);
            db.SaveChanges();

            #region TXT
            /*
            StreamWriter sw = new StreamWriter("Tanulok.txt", append: true);
            sw.WriteLine(tanulo.ToString());
            sw.Close();
            */
            #endregion
        }


        private void clear()
        {
            nevTextBox.Text = "";
            korTextBox.Text = "";
            ferfiRadioButton.Checked = true;
            noRadioButton.Checked=false;
            foreach (int i in tulajdonsagokCheckedListBox.CheckedIndices)
            {
                tulajdonsagokCheckedListBox.SetItemCheckState(i, CheckState.Unchecked);
            }

        }
        private void megseButton_Click(object sender, EventArgs e)
        {
            tulajdonsagokCheckedListBox.Enabled = true;
            clear();
        }

        private void torlesButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Biztosan törölni Szeretné?", "Figyelmeztetés!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                clear();
                return;
            }
            tulajdonsagokCheckedListBox.Enabled = true;
            
            Connection db = new Connection();
            var entry = db.Entry(tanulo);
            if(entry.State == EntityState.Detached)
            {
                db.Tanulok.Attach(tanulo);
            }
            db.Tanulok.Remove(tanulo);
            db.SaveChanges();


            clear();
            load();

        }

        private void tanulokDataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (mentesButton.Text == "Mentés") mentesButton.Text = "Módosítás"; else mentesButton.Text = "Mentes";

            Connection db = new Connection();

            tanulo.ID = Convert.ToInt32(tanulokDataGridView.CurrentRow.Cells["ID"].Value);
            tanulo = db.Tanulok.Where(x => x.ID == tanulo.ID).First();

            nevTextBox.Text = tanulo.nev;
            korTextBox.Text = Convert.ToString(tanulo.kor);
            ferfiRadioButton.Checked = (tanulo.nem=="férfi"?true:false);
            noRadioButton.Checked = (tanulo.nem=="nő"?true:false);
            tulajdonsagokCheckedListBox.Enabled = false;
        }

     
    }
}
