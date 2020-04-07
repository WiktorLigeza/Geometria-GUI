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
    public partial class circleIntersection : Form
    {
        List<LineModel> lineList;
        List<CircleModel> circleList;

        public LineModel line = new LineModel();
        public CircleModel circle = new CircleModel();

        Computador compute = new Computador();
        public double[] SLE = new double[2];

        public circleIntersection(List<LineModel> LL, List<CircleModel> CL)
        {
            lineList = LL;
            circleList = CL;
            InitializeComponent();
            wireUp();
        }

   

        private void button1_Click(object sender, EventArgs e)
        {
             if (comboBoxNewCirclesList.SelectedItem != null && comboBoxNewLinesList.SelectedItem != null)
            {
                circle = (CircleModel)comboBoxNewCirclesList.SelectedItem;
                line = (LineModel)comboBoxNewLinesList.SelectedItem;
            }
            else
            {
                MessageBox.Show("you have to select something");
                this.DialogResult = DialogResult.None;
            }
        }

        private void circleIntersection_Load(object sender, EventArgs e)
        {

        }
        private void wireUp()
        {
            comboBoxNewLinesList.DataSource = null;
            comboBoxNewLinesList.DataSource = lineList;
            comboBoxNewLinesList.DisplayMember = "Display";

            comboBoxNewCirclesList.DataSource = null;
            comboBoxNewCirclesList.DataSource = circleList;
            comboBoxNewCirclesList.DisplayMember = "Display";
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addNewCircleLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddCircle ac = new AddCircle();
            if (ac.ShowDialog() == DialogResult.OK)
            {
                circleList.Add(ac.circle);
            }
            wireUp();
        }
    }
}
