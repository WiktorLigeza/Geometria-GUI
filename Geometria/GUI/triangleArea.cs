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
    public partial class triangleArea : Form
    {
        public TriangleModel triangle = new TriangleModel();
        public List<TriangleModel> triangleList;
        public double area;
        Computador compute = new Computador();
        public triangleArea(List<TriangleModel> TL)
        {
            triangleList = TL;
            InitializeComponent();
            wireUp();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( comboBoxNewTrianglesList.SelectedItem != null)
            {
                triangle = (TriangleModel)comboBoxNewTrianglesList.SelectedItem;
                area = compute.triangleArea((TriangleModel)comboBoxNewTrianglesList.SelectedItem);
            }
            else
            {
                MessageBox.Show("you have to select something");
                this.DialogResult = DialogResult.None;
            }
        }
        private void wireUp()
        {
            comboBoxNewTrianglesList.DataSource = null;
            comboBoxNewTrianglesList.DataSource = triangleList;
            comboBoxNewTrianglesList.DisplayMember = "Display";
        }

        private void addNewTriangleLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddTriangle at = new AddTriangle();
            if (at.ShowDialog() == DialogResult.OK)
            {
                triangleList.Add(at.triangle);
            }
            wireUp();
        }

        private void comboBoxNewTrianglesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxNewTrianglesList.SelectedItem != null)
            {
                textBoxArea.Text = "" + Math.Abs((float)compute.triangleArea((TriangleModel)comboBoxNewTrianglesList.SelectedItem));
            }
            
        }
    }

}
