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
    public partial class PolygonSide : Form
    {
        public List<PointModel> PolygonVertices = new List<PointModel>();
        public List<PointModel> pointsList = new List<PointModel>();
        public PointModel point = new PointModel();
        public int elements;
        public AddPoligon aPol;
        public AddPoint ap;
        public PolygonSide(List<PointModel> PL)
        {
            pointsList = PL;
            InitializeComponent();
            wireUp();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBoxNewPointsList.SelectedItem != null && PolygonVertices.Count > 0)
            {
                point = (PointModel)comboBoxNewPointsList.SelectedItem;
            }
            else
            {
                MessageBox.Show("you have to select point or c");
                this.DialogResult = DialogResult.None;
            }
        }

        private void addNewPointLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ap = new AddPoint();
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

        }

        private void addNewPolygonLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            aPol = new AddPoligon();
            if (aPol.ShowDialog() == DialogResult.OK)
            {
                PolygonVertices = aPol.PolygonVertices;
            }
        }
    }
}
