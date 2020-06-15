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
        /// This must be kept in sync with CircleCollection.
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
        }

        private void RedrawCircleCollection()
        {
            CircleCollection.Items.Clear();
            foreach (var circle in this.circles)
            {
                CircleCollection.Items.Add(circle.ToString());
            }
        }

        private void ShowArray_Click(object sender, EventArgs e)
        {
            String msg;

            msg =  "Radius    Diameter\n";
            msg += "---------------------\n";
            foreach (var c in this.circles)
            {
                msg += String.Format("{0}              {1}\n", c.getRadius(), c.getDiameter());
            }

            // TODO Set to monospaced font so is properly aligned.

            MessageBox.Show(msg);
        }

        private void SetRadius_Click(object sender, EventArgs e)
        {
            double newRadius = Convert.ToDouble(CircleInput.Text);
            var c = circles[CircleCollection.SelectedIndex];

            c.setRadius(newRadius);
            this.RedrawCircleCollection();
        }

        private void CircleCollection_SelectedIndexChanged(object sender, EventArgs e)
        {
            var c = circles[CircleCollection.SelectedIndex];

            CircleData.Text = String.Format("Radius: {0}\nDiameter: {1}", c.getRadius(), c.getDiameter());
        }

    }
}
