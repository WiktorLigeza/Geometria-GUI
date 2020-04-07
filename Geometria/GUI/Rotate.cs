using Geometria;
using Geometria.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Rotate : Form
    {
        public List<LineModel> list;
        public LineModel Lmodel = new LineModel();
        public double degree;
        public bool terms;
        Computador compute = new Computador();
        public double[] SLE = new double[2];
        public AddLine al;
        public bool didAdd = false;
        public int i = 0;


        public Rotate(List<LineModel> passed)
        {
            list = passed;
            InitializeComponent();
            wireUp();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Lmodel = (LineModel)comboBoxNewLinesList.SelectedItem;
            if (!validate())
            {
                MessageBox.Show("Invalid data set");
                this.DialogResult = DialogResult.None;
            }
            if (AinB.Checked == true)
            {
                terms = true;
            }
            else terms = false;
            
        }
        private void addNewLineLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            didAdd = true;
            al = new AddLine();
            if (al.ShowDialog() == DialogResult.OK)
            {
                if(al.line == null)
                {
                    SLE = al.SLE;
                    SLEtoLine();
                }
                else
                {
                    list.Add(al.line);
                }
                i++;
            }
            wireUp();
        }
        private void comboBoxNewLinesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxNewLinesList.SelectedItem != null)
            {
                double[] arr = compute.SLE((LineModel)comboBoxNewLinesList.SelectedItem);
                if (arr[1] == 0)
                {
                    textBoxSLE.Text = (float)arr[0] + "x";
                }
                else if (arr[1] > 0)
                {
                    textBoxSLE.Text = (float)arr[0] + "x +" + (float)arr[1];
                }
                else textBoxSLE.Text = (float)arr[0] + "x" + (float)arr[1];
            }

        }

        private void wireUp()
        {
            comboBoxNewLinesList.DataSource = null;
            comboBoxNewLinesList.DataSource = list;
            comboBoxNewLinesList.DisplayMember = "Display";
        }
        bool validate()
        {
            bool output = true;


            if (!double.TryParse(textBoxDegree.Text, out degree))
            {
                output = false;
            }
            if (Lmodel == null)
            {
                output = false;
            }
            if (AinB.Checked == false && BinA.Checked == false)
            {
                output = false;
            }

            return output;
        }

        private void SLEtoLine()
        {
            LineModel l = new LineModel();
            if (SLE[0] >= 0)
            {
                l.A.x = 215;
                l.B.x = -215;
            }
            else if (SLE[0] < 0)
            {
                l.A.x = -215;
                l.B.x = 215;
            }
            l.A.y = SLE[0] * l.A.x + SLE[1];
            l.B.y = SLE[0] * l.B.x + SLE[1];
            list.Add(l);
        }
      
    }
}
