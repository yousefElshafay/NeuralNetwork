using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuroNetWorkExperiment
{
    public partial class Form1 : Form
    {
        Graphics g = null;
        NeuralNetworkManager NeuralManager;
       
        public Form1()
        {
            InitializeComponent();
            NeuralManager = new NeuralNetworkManager();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pen mypen = new Pen(Color.Black);
            g = Canvas.CreateGraphics();
            SolidBrush brush = new SolidBrush(Color.Gray);
            g.FillEllipse(brush, 50, 50, 25, 25);

            ControlPaint.DrawGrid(g, new Rectangle(50, 50, 900, 500), new Size(10, 10), Color.Red);
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Canvas_DoubleClick(object sender, EventArgs e)
        {

        }

        private void Canvas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
        }

        private void BtnCreateNetwork_Click(object sender, EventArgs e)
        {
            //as a demo we will create a network of three layer each layer has 3 neurons 
            NeuralManager.CreateNetWork(6,4);
            

            //there is a better way to handle this but i did not find it jet 



            // this logic has been moved to the neuralNetworkManager

            //RegularNeuron regularNeuron; 

            //foreach (NetWorkLayer layer in NeuralManager.GetNetWorkLayers())
            //{
            //    for (int i = 0; i < NeuralManager.GetNumberOfLayers(); i++)
            //    {
            //        regularNeuron = new RegularNeuron();
            //        layer.AddNeuronToLayer(regularNeuron);
            //    }
            //}

        }
    }
}
