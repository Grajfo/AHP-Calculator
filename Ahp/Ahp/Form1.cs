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
    public partial class Form1 : Form
    {

        private List<string> drevo = new List<string>();
        private List<string> otrokakorena = new List<string>();
        public Form1()
        {
            InitializeComponent();

        }

        private void dodaj_node_Click(object sender, EventArgs e)
        {
            if (ime_node.Text != "" && treeView1.Nodes.Count == 0)
            {
                TreeNode newNode = new TreeNode(ime_node.Text);
                treeView1.Nodes.Add(newNode);
                ime_node.Text = "";
            }
            else if (treeView1.SelectedNode != null && ime_node.Text != "" && treeView1.Nodes.Count == 1)
            {
                TreeNode childNode = new TreeNode(ime_node.Text);
                treeView1.SelectedNode.Nodes.Add(childNode);
                ime_node.Text = "";
            }
            else
            {
                MessageBox.Show("vpiši ime za node ali izberi vejo");
            }

        }

        private void treeView1_MouseDown(object sender, MouseEventArgs e)
        {
            var hit = treeView1.HitTest(e.X, e.Y);

            if (hit.Node == null)
            {
                treeView1.SelectedNode = null;
            }
        }

        private void izbrisi_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                treeView1.Nodes.Remove(treeView1.SelectedNode);
            }
            else
            {
                MessageBox.Show("ni izbranega noda");
            }
        }


        private void cleardrevo_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
        }

        private void spremeni_Click(object sender, EventArgs e)
        {
            if (spremeni_tb.Text != "" && treeView1.SelectedNode != null)
            {
                treeView1.SelectedNode.Text = spremeni_tb.Text;
                spremeni_tb.Text = "";
            }
            else
            {
                MessageBox.Show("Prosim izberite node ali vpišite spremenjno ime");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (treeView1.Nodes.Count != 0)
            {
                var korennodes = treeView1.Nodes[0];
                int  j = 0;
  
                
                for (int i = 0; i < korennodes.Nodes.Count; i++)
                {
                    otrokakorena.Add(korennodes.Nodes[i].Text);
                }

                var st = otrokakorena.Count - 1;

                foreach (var node in Collect(treeView1.Nodes))
                {
                    if (node.Nodes.Count > 0 && node.Text == korennodes.Text)
                    {
                        drevo.Add(node.Text + " --> " + node.Nodes.Count);
                    }
                    else if (node.Nodes.Count == 0 && node.Text == korennodes.Text)
                    {
                        drevo.Add(node.Text);
                    }

                    else if (node.Text == otrokakorena[j].ToString() && node.Nodes.Count > 0)
                    {
                        drevo.Add("  " + node.Text + " --> " + node.Nodes.Count);
                        if(j == st)
                        {
                            continue;
                        }
                        else
                        {
                            j++;
                        }
                        
                    }
                    else if (node.Text == otrokakorena[j].ToString() && node.Nodes.Count == 0)
                    {
                        drevo.Add("  " + node.Text);
                        if (j == st)
                        {
                            continue;
                        }
                        else
                        {
                            j++;
                        }
                    }

                    else if (node.Text != korennodes.Text && node.Nodes.Count > 0)
                    {
                        drevo.Add("     " + node.Text + " --> "+node.Nodes.Count);
                    }
                    else if (node.Text != korennodes.Text && node.Nodes.Count == 0)
                    {
                        drevo.Add("     " + node.Text);
                    }

                }



                Izracuni_tabel iz = new Izracuni_tabel(drevo, otrokakorena);
                iz.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("prosim sestavite drevo");
            }
            
        }


        IEnumerable<TreeNode> Collect(TreeNodeCollection nodes)
        {
            foreach (TreeNode node in nodes)
            {
                yield return node;

                foreach (var child in Collect(node.Nodes))
                    yield return child;
            }
        }
    }
}
