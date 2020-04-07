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
    public partial class Triangle : Form
    {
        public TriangleModel triangle = new TriangleModel();
        public PointModel point = new PointModel();
        public List<TriangleModel> triangleList;
        public List<PointModel> pointsList;

        public Triangle(List<TriangleModel> TL, List<PointModel> PL)
        {
            triangleList = TL;
            pointsList = PL;
            InitializeComponent();
            wireUp();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxNewPointsList.SelectedItem != null && comboBoxNewTrianglesList.SelectedItem != null)
            {
                point = (PointModel)comboBoxNewPointsList.SelectedItem;
                triangle = (TriangleModel)comboBoxNewTrianglesList.SelectedItem;
            }
            else
            { 
                MessageBox.Show("you have to select something");
                this.DialogResult = DialogResult.None;
            }

          
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
            comboBoxNewPointsList.DataSource = null;
            comboBoxNewPointsList.DataSource = pointsList;
            comboBoxNewPointsList.DisplayMember = "Display";

            comboBoxNewTrianglesList.DataSource = null;
            comboBoxNewTrianglesList.DataSource = triangleList;
            comboBoxNewTrianglesList.DisplayMember = "Display";
        }

        private void Triangle_Load(object sender, EventArgs e)
        {


        }

       
    }
}
