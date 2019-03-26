using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Runtime.CompilerServices;

namespace Ahp
{
    public partial class Izracuni_tabel : Form
    {
        public List<string> drevo { get; set; }
        private List<string> otrokikorena { get; set; }


        public Izracuni_tabel()
        {
            InitializeComponent();

        }

        public Izracuni_tabel(List<string> tree, List<string> otrkor)
        {
            InitializeComponent();
            drevo = tree;
            otrokikorena = otrkor;

            foreach (var item in drevo)
            {
                dataGridView1.Rows.Add(item);
            }

            for (int i = 1; i < dataGridView1.Columns.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    dataGridView1.Rows[j].Cells[i].Value = 1;
                }
            }
        }

        private void dodaj_alternative_Click(object sender, EventArgs e)
        {
            if (ime_alt_tb.Text != "")
            {
                dataGridView1.Columns.Add(ime_alt_tb.Text, ime_alt_tb.Text);
                ime_alt_tb.Text = "";
            }
            else
            {
                MessageBox.Show("vpisi ime alternative");
            }
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex.Equals(3) && e.RowIndex != -1)
            {
                if (dataGridView1.CurrentCell != null && dataGridView1.CurrentCell.Value != null)
                    MessageBox.Show(dataGridView1.CurrentCell.Value.ToString());
            }
        }

        private void izbris_alt_Click(object sender, EventArgs e)
        {
            int columnIndex = dataGridView1.CurrentCell.ColumnIndex;
            //   int rowIndex = dataGridView1.CurrentCell.RowIndex;

            if (columnIndex > 1)
            {
                dataGridView1.Columns.Remove(dataGridView1.Columns[columnIndex]);
            }
            else
            {
                MessageBox.Show("izberi alternativo");
            }
        }

        private void spremeni_Click(object sender, EventArgs e)
        {
            int columnIndex = dataGridView1.CurrentCell.ColumnIndex;
            //   int rowIndex = dataGridView1.CurrentCell.RowIndex;

            if (columnIndex > 1)
            {
                dataGridView1.Columns[columnIndex].HeaderText = spremeni_tb.Text;
                spremeni_tb.Text = "";
            }
            else if (spremeni_tb.Text == "")
            {
                MessageBox.Show("vpisi ime");
            }
            else
            {
                MessageBox.Show("izberi alternativo");
            }
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].ErrorText = "";
            double newDouble;


            if (dataGridView1.Columns[e.ColumnIndex].HeaderText != "Parametri")
            {
                //if (dataGridView1.Rows[e.RowIndex].IsNewRow) { return; }
                if (!double.TryParse(e.FormattedValue.ToString(), out newDouble) || newDouble > 1 || newDouble < 0)
                {
                    e.Cancel = true;
                    dataGridView1.Rows[e.RowIndex].ErrorText = "the vrednost mora biti večje od 0 in manjše od 1";
                }
            }
        }

        private void dataGridView2_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            dataGridView2.Rows[e.RowIndex].ErrorText = "";
            double newdouble;

            if (dataGridView2.Columns[e.ColumnIndex].Index != 0)
            {
                //   if (dataGridView2.Rows[e.RowIndex].IsNewRow) { return; }
                if (!double.TryParse(e.FormattedValue.ToString(),
                    out newdouble) || newdouble > 10 || newdouble < 0)
                {
                    e.Cancel = true;
                    dataGridView2.Rows[e.RowIndex].ErrorText = "the vrednost mora biti večje od 0 in manjše od 10";
                }
            }
        }
             
        private void addstolpec_bt_Click(object sender, EventArgs e)
        {
            if (ime_atr_tb.Text != "")
            {
                dataGridView2.Columns.Add(ime_atr_tb.Text, ime_atr_tb.Text);
                dataGridView2.Rows.Add(ime_atr_tb.Text);
                ime_atr_tb.Text = "";
            }
            else
            {
                MessageBox.Show("vpisi ime alternative");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (dataGridView2.CurrentCell != null)
            {
                int columnIndex = dataGridView2.CurrentCell.ColumnIndex;
                if (columnIndex > 0)
                {
                    dataGridView2.Columns.Remove(dataGridView2.Columns[columnIndex]);
                }
                else
                {
                    MessageBox.Show("izberi drugi stolpec");
                }
            }
            else
            {
                MessageBox.Show("izberi stolpec");
            }
        }

        private void deli_bt_Click(object sender, EventArgs e)
        {

            double intindex;

            if (!double.TryParse(stevec.Text, out intindex) || intindex < 0 || intindex > 10 && !double.TryParse(imenovalec.Text, out intindex) || intindex < 0 || intindex > 10 )
            {
                MessageBox.Show("vpisi stevilo med 0 in 10");
            }
            else
            {
                var rezultat = Math.Round(double.Parse(stevec.Text) / double.Parse(imenovalec.Text), 3);
                rezulta_delj.Text = rezultat.ToString();
            }

        }

        private void izracunaj_ut_korist_Click(object sender, EventArgs e)
        {
            bool tabelapolna = preveritabelo(dataGridView2);
            List<double> koristnostaliutez = new List<double>();
            double reztati = 0;
            double koncnirezultat = 0;
            List<List<double>> izracunanistolpcizsestevkom = new List<List<double>>();

            if (tabelapolna == false || dataGridView2.Columns.Count <=2)
            {
                MessageBox.Show("napolni vse celice ali dodaj stolpec");
            }
            else
            {
                var sestevektabel = izracunsestevka(dataGridView2);

                izracunanistolpcizsestevkom = deljenjezsestevki(dataGridView2, sestevektabel);

                for (int i = 0; i < izracunanistolpcizsestevkom.Count; i++)
                {
                    for (int j = 0; j < izracunanistolpcizsestevkom.Count; j++)
                    {
                        reztati += izracunanistolpcizsestevkom[j][i];                       
                    }
                    koncnirezultat = Math.Round(reztati / izracunanistolpcizsestevkom.Count,2);
                    koristnostaliutez.Add(koncnirezultat);
                    koncnirezultat = 0;
                    reztati = 0;
                }

                dataGridView2.Columns.Add("Koristnost/utez", "Koristnost/utez");
                dodajanjevtabelo(dataGridView2, koristnostaliutez);
            }

        }

        private void izbrisi_tabelo_bt_Click(object sender, EventArgs e)
        {
            dataGridView2.Columns.Clear();         
            dataGridView2.Rows.Clear();

            dataGridView2.Columns.Add("Atribut", "Atribut");
        }



        private bool preveritabelo(DataGridView dt)
        {
            bool vrednost = false;
             
            for (int i = 1; i < dt.Columns.Count; i++)
            {
                for (int j = 0; j < dt.Rows.Count; j++)
                {
                    if(dt.Rows[j].Cells[i].Value == null)
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


        private List<double> izracunsestevka(DataGridView dt)
        {
            List<double> sestevek = new List<double>();
            double stevilo =0;
            for (int i = 1; i < dt.Columns.Count; i++)
            {
                for (int j = 0; j < dt.Rows.Count; j++)
                {
                    stevilo += double.Parse(Convert.ToString(dt.Rows[j].Cells[i].Value));
                }
                sestevek.Add(stevilo);
                stevilo = 0;
            }
            return sestevek;
        }



        private List<List<double>> deljenjezsestevki(DataGridView dt, List<double> sestevki)
        {
            List<List<double>> sestevek = new List<List<double>>();
            
            double stevilo = 0;
            int stevec = 0;

            for (int i = 1; i < dt.Columns.Count; i++)
            {
                List<double> rezultat = new List<double>();
                for (int j = 0; j < dt.Rows.Count; j++)
                {
                    stevilo = double.Parse(Convert.ToString(dt.Rows[j].Cells[i].Value)) / sestevki[stevec] ;
                    rezultat.Add(stevilo);
                }
                sestevek.Add(rezultat);
                stevec++;
                stevilo = 0;
            }
            return sestevek;
        }


        private List<string> pridobiheadertexte(DataGridView dt)
        {
            List<string> headertexti = new List<string>();
            if (dt.Columns.Count >= 2)
            {
                for (int i = 2; i < dt.Columns.Count; i++)
                {
                    string header = dt.Columns[i].HeaderText;

                    headertexti.Add(header);
                }
            }
            return headertexti;
        }
        private void dodajanjevtabelo(DataGridView dt , List<double> d)
        {
            for (int i = 1; i < dt.Columns.Count; i++)
            {
                for (int j = 0; j < dt.Rows.Count; j++)
                {
                    if (dt.Rows[j].Cells[i].Value == null)
                    {
                        dt.Rows[j].Cells[i].Value = d[j];
                    }
                    else
                    {
                        continue;
                    }
                }
            }
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

        private void shrani_tabelo_bt_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "tabela_ahp_metode.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // Copy DataGridView results to clipboard
                copyAlltoClipboard();

                object misValue = System.Reflection.Missing.Value;
                Microsoft.Office.Interop.Excel.Application xlexcel = new Microsoft.Office.Interop.Excel.Application();

                xlexcel.DisplayAlerts = false; // Without this you will get two confirm overwrite prompts
                Microsoft.Office.Interop.Excel.Workbook xlWorkBook = xlexcel.Workbooks.Add(misValue);
                Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                // Format column D as text before pasting results, this was required for my data
                Microsoft.Office.Interop.Excel.Range rng = xlWorkSheet.get_Range("D:D").Cells;
                rng.NumberFormat = "@";

                // Paste clipboard results to worksheet range
                Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
                CR.Select();
                xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

                Microsoft.Office.Interop.Excel.Range delRng = xlWorkSheet.get_Range("A:A").Cells;
                delRng.Delete(Type.Missing);
                xlWorkSheet.get_Range("A1").Select();

                // Save the excel file under the captured location from the SaveFileDialog
                xlWorkBook.SaveAs(sfd.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlexcel.DisplayAlerts = true;
                xlWorkBook.Close(true, misValue, misValue);
                xlexcel.Quit();

                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlexcel);

                // Clear Clipboard and DataGridView selection
                Clipboard.Clear();
                dataGridView1.ClearSelection();

                // Open the newly saved excel file
                if (File.Exists(sfd.FileName))
                    System.Diagnostics.Process.Start(sfd.FileName);
            }
        }

        private void copyAlltoClipboard()
        {

            dataGridView1.SelectAll();

            DataObject dataObj = dataGridView1.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occurred while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void izracun_starsev_bt_Click(object sender, EventArgs e)
        {
            List<string> alternative = new List<string>();
            List<string> imenadrevesa = new List<string>();

                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    if (dataGridView1.Columns[0].HeaderText == "Parametri" )
                    {
                        string imena = dataGridView1.Rows[j].Cells[0].Value.ToString();
                        imenadrevesa.Add(imena);
                    }
                    else
                    {
                        break;
                    }

                }         
            if (pridobiheadertexte(dataGridView1).Count > 0)
            {
                alternative = pridobiheadertexte(dataGridView1);
                Izracun_koristnosti izk = new Izracun_koristnosti(alternative, imenadrevesa);
                izk.Show();
            }
            else
            {
                MessageBox.Show("dodaj alternative");
            }

        }

        private void izbrisivrstico_Click(object sender, EventArgs e)
        {

            if (dataGridView2.CurrentCell != null)
            {
                int rowIndex = dataGridView2.CurrentCell.RowIndex;

                if (rowIndex > 0)
                {
                    dataGridView2.Rows.Remove(dataGridView2.Rows[rowIndex]);
                }
                else
                {
                    MessageBox.Show("izberi vrstico");
                }
            }
            else
            {
                MessageBox.Show("izberi vrstico");
            }
        }

        private void deli_bt_Click_1(object sender, EventArgs e)
        {
            double stevilo;
            if (stevec.Text != "" && imenovalec.Text != "")
            {
                stevilo = double.Parse(stevec.Text) / double.Parse(imenovalec.Text);
                rezulta_delj.Text = Math.Round(stevilo, 2).ToString();
            }
            else
            {
                MessageBox.Show("stevec ali imenovalec je prazni");
            }
    }

        private void prikazigraf_Click(object sender, EventArgs e)
        {

            Dictionary<string, double> vrednosti = new Dictionary<string, double>();
            if(preveritabelo(dataGridView1) == true)
            {
                List<double> nekaj = new List<double>();
                var headrtexti = pridobiheadertexte(dataGridView1);
                for (int i = 2; i < dataGridView1.Columns.Count; ++i)
                {
                    nekaj.Add(Convert.ToDouble(dataGridView1.Rows[0].Cells[i].Value)); // za hranjevanje uteži
                }

                for (int i = 0; i < headrtexti.Count; i++)
                {
                    vrednosti.Add(headrtexti[i], nekaj[i]);
                }

                Chart graf = new Chart() { Dock = DockStyle.Fill }; ;

                var grafForm = new Form
                {
                    Visible = false,
                    TopMost = true,
                    Width = 1000,
                    Height = 800
                };


                var chartArea = new ChartArea("graf");
                graf.ChartAreas.Add(chartArea);
                graf.Legends.Add("legend1");

                graf.Titles.Add("ahp metoda");

                foreach (var item in vrednosti)
                {
                    graf.Series.Add(item.Key);
                    graf.Series[item.Key].LegendText = item.Key;
                    graf.Series[item.Key].ChartType = SeriesChartType.Column;
                    //  graf.Series[item.Key].Label = item.Key;

                    graf.Series[item.Key].Points.AddXY(item.Key, item.Value);

                }
                grafForm.Controls.Add(graf);
                grafForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("tabela more biti napolnjena");
            }
        }

        private void izracunutezistolpec_Click(object sender, EventArgs e)
        {
            var alternative = pridobiheadertexte(dataGridView1);
            if (alternative.Count != 0)
            {
                foreach (var item in alternative)
                {
                    dataGridView2.Columns.Add(item, item);
                    dataGridView2.Rows.Add(item);
                }
            }
            else
            {
                MessageBox.Show("Ni podanih alternativ");
            }
        }
    }     
}
