using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ahp
{
    public partial class Izracun_koristnosti : Form
    {

        List<string> alternative = new List<string>();
        List<string> imenastrukturedrevesa = new List<string>();

        public Izracun_koristnosti(List<string> imena, List<string> imenadrevesa)
        {
            InitializeComponent();
            alternative = imena;
            imenastrukturedrevesa = imenadrevesa;

            foreach (var item in alternative)
            {
                dataGridView2.Columns.Add(item, item);
            }

            foreach (var item in imenastrukturedrevesa)
            {
                ((DataGridViewComboBoxColumn)dataGridView2.Columns[0]).Items.Add(item);
            }
        }

        private void addvrstica_bt_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add();

        }

        private void izbris_vrstice_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView2.CurrentCell.RowIndex;
            if (rowIndex > 0)
            {
                dataGridView2.Rows.Remove(dataGridView2.Rows[rowIndex]);
            }
            else
            {
                MessageBox.Show("izberi drugi cell");
            }
        }

        private void izbris_tabele_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
        }

        private void spremeniimeattr_bt_Click(object sender, EventArgs e)
        {
            if (spremeni_atrr_tb.Text != "")
            {
                dataGridView2.Columns[0].HeaderText = "";

                dataGridView2.Columns[0].HeaderText = spremeni_atrr_tb.Text;

                spremeni_atrr_tb.Text = "";
            }
            else
            {
                MessageBox.Show("textbox za spreminjanje imena je prazen");
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.CurrentCell.ColumnIndex.Equals(3) && e.RowIndex != -1)
            {
                if (dataGridView2.CurrentCell != null && dataGridView2.CurrentCell.Value != null)
                    MessageBox.Show(dataGridView2.CurrentCell.Value.ToString());
            }
        }



        private bool preveritabelo(DataGridView dt)
        {
            bool vrednost = false;

            for (int i = 1; i < dt.Columns.Count; i++)
            {
                for (int j = 0; j < dt.Rows.Count; j++)
                {
                    if (dt.Rows[j].Cells[i].Value == null)
                    {
                        vrednost = false;
                    }
                    else
                    {
                        vrednost = true;
                    }
                }
            }
            return vrednost;
        }

        private void izracunajkoristnost_bt_Click(object sender, EventArgs e)
        {
            textBox1_rez.Text = "";
            if (preveritabelo(dataGridView2) == true)
            {             
               var n = izracunikoristnost(dataGridView2);

                foreach (var item in n)
                {
                    textBox1_rez.Text += item.Key + " = " + item.Value + "\r\n";
                }
            }
            else
            {
                MessageBox.Show("napolni vse vrednosti");
            }
        }


        public List<double> shranjevanje_uteži_podatkov()
        {
            List<double> utezi = new List<double>();
            for (int i = 0; i < dataGridView2.Rows.Count; ++i)
            {
                utezi.Add(Convert.ToDouble(dataGridView2.Rows[i].Cells[1].Value)); // za hranjevanje uteži
            }

            return utezi;
        }



        public Dictionary<string, double> izracunikoristnost(DataGridView dt)
        {
            var utezi = shranjevanje_uteži_podatkov();
            Dictionary<string, double> vrednosti = new Dictionary<string, double>();
            double sum=0;
            string imena = "";
            for (int i = 2; i < dt.Columns.Count; i++) // skozi alternative
            {
                for (int j = 0; j < dt.Rows.Count; ++j)  // skozi vse rowe
                {
                    imena = dataGridView2.Columns[i].HeaderText;
                    sum += double.Parse(Convert.ToString(dt.Rows[j].Cells[i].Value)) * utezi[j]; // množenje med uteži in točkami

                }
                vrednosti.Add(imena,Math.Round(sum,2));
                sum = 0;
            }

            return vrednosti;
        }
    }
}
