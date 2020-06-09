using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhatsTheDiameter
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// If circles is modified, RedrawCircleCollection() *must* be called, otherwise the indices will get out of date.
        /// </summary>
        private List<Circle> circles;

        public Form1()
        {
            InitializeComponent();

            this.circles = new List<Circle>();
        }

        private void NewCircle_Click(object sender, EventArgs e)
        {
            var circle = new Circle(Convert.ToDouble(CircleInput.Text));
            this.circles.Add(circle);
            this.RedrawCircleCollection();
            this.ShowCircle(circle);
        }

        private void RedrawCircleCollection()
        {
            CircleCollection.Items.Clear();
            foreach (var circle in this.circles)
            {
                CircleCollection.Items.Add(circle.ToString());
            }
        }

        private void SetRadius_Click(object sender, EventArgs e)
        {
            // First let's find the selected item
            var circle = this.circles[CircleCollection.SelectedIndex];
            circle.setRadius(Convert.ToDouble(CircleInput.Text));
            this.RedrawCircleCollection();
            this.ShowCircle(circle);
        }

        private void ShowCircle(Circle c)
        {
            MessageBox.Show(String.Format("Circle radius: {0}, circumference: {1}, diameter: {2}", c.getRadius(), 0, 0));
        }
    }
}
