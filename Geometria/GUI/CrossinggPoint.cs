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
    public partial class CrossinggPoint : Form
    {
        public List<LineModel> list;
        public List<LineModel> selectedList = new List<LineModel>();
        LineModel Lmodel = new LineModel();
        public double[] SLE = new double[2];
        public AddLine al;
        public bool didAdd = false;
        Computador compute = new Computador();
        public int i = 0;

        public CrossinggPoint(List<LineModel> passed)
        {
            list = passed;
            InitializeComponent();
            wireUp();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!validate())
            {
                MessageBox.Show("Select at lest 2 lines");
                this.DialogResult = DialogResult.None;
            }
        }

        private void addNewLineLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            didAdd = true;
            al = new AddLine();
            if (al.ShowDialog() == DialogResult.OK)
            {
                if (al.line == null)
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

        private void selectButton_Click(object sender, EventArgs e)
        {
            if ((LineModel)comboBoxNewLinesList.SelectedItem != null && selectedList.Count < 2)
            {
                selectedList.Add((LineModel)comboBoxNewLinesList.SelectedItem);
                wireUp();
            }
            else if (selectedList.Count >= 2)  MessageBox.Show("max 2 lines"); 
            else MessageBox.Show("you have to select something");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectedList.Remove((LineModel)selectedItemsListBox.SelectedItem);
            wireUp();
        }


        private void wireUp()
        {
            comboBoxNewLinesList.DataSource = null;
            comboBoxNewLinesList.DataSource = list;
            comboBoxNewLinesList.DisplayMember = "Display";

            selectedItemsListBox.DataSource = null;
            selectedItemsListBox.DataSource = selectedList;
            selectedItemsListBox.DisplayMember = "Display";
        }
        bool validate()
        {
            bool output = true;

            if (selectedList.Count<2 || selectedList.Count>2)
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

        private void comboBoxNewLinesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((LineModel)comboBoxNewLinesList.SelectedItem != null)
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
    }
}
