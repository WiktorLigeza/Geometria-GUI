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
    public partial class Line : Form
    {
        public PointModel point = new PointModel();
        public LineModel line = new LineModel();
        public List<PointModel> pointsList;
        public List<LineModel> lineList = new List<LineModel>();
        Computador compute = new Computador();
        public double[] SLE = new double[2];

        public Line(List<LineModel> LL, List<PointModel> PL)
        {
            pointsList = PL;
            lineList = LL;
            InitializeComponent();
            wireUp();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxNewPointsList.SelectedItem != null && comboBoxNewLinesList.SelectedItem != null)
            {
                point = (PointModel)comboBoxNewPointsList.SelectedItem;
                line = (LineModel)comboBoxNewLinesList.SelectedItem;
            }
            else
            {
                MessageBox.Show("you have to select something");
                this.DialogResult = DialogResult.None;
            }
        }

        private void addNewLineLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddLine al = new AddLine();
            if (al.ShowDialog() == DialogResult.OK)
            {
                if (al.line == null)
                {
                    SLE = al.SLE;
                    SLEtoLine();
                }
                else
                {
                    lineList.Add(al.line);
                }
            }
            wireUp();
        }
        private void addNewPointLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddPoint ap = new AddPoint();
            if (ap.ShowDialog() == DialogResult.OK)
            {
                pointsList.Add(ap.point);
            }
            wireUp();
        }

        private void wireUp()
        {
            comboBoxNewLinesList.DataSource = null;
            comboBoxNewLinesList.DataSource = lineList;
            comboBoxNewLinesList.DisplayMember = "Display";

            comboBoxNewPointsList.DataSource = null;
            comboBoxNewPointsList.DataSource = pointsList;
            comboBoxNewPointsList.DisplayMember = "Display";
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
            lineList.Add(l);
        }

     

        private void comboBoxNewLinesList_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if(comboBoxNewLinesList.SelectedItem != null)
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
