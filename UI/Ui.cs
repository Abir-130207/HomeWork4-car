using BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;

namespace UI
{
    public partial class Ui : Form
    {
        Bo bl = new Bo();
        Car s = new Car();
        Graphics g;
        Char keyPress;
        int x;
        int y;
        public Ui()
        {
            InitializeComponent();
            g = carPanel.CreateGraphics();
            int x = bl.x;
            int y = bl.y;
            keyPress = 'r';
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            info.Text = null;
            switch (keyPress)
            {
                case 'u':
                   s.carUp(g);
                    break;
                case 'd':
                    s.carDown(g);
                    break;
                case 'r':
                    s.carRight(g);
                    break;
                case 'l':
                    s.carLeft(g);
                    break;
            }
            if (bl.speedCalculation() != 0 && !String.IsNullOrEmpty(currentInfoLabel.Text))
            {
                timer1.Interval = bl.speedCalculation();
                timer1.Start();
            }
        }
        private void stopButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
        private void speedButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(speedBox.Text))
                MessageBox.Show("Please, enter speed correctly.");
            else
            {
                Car c = new Car();
                c.speed = Convert.ToInt32(speedBox.Text);
                if (bl.saveSpeed(c))
                {
                    info.Text = "Now, Press 'Start'";
                    currentInfoLabel.Text = Convert.ToString(bl.getData());
                }
                else
                {
                    MessageBox.Show("error");
                    info.Text = null;
                }

            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            bl.changeAxes(keyPress);
            carPanel.Location = new Point(bl.x, bl.y);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                keyPress = 'u';
                g.Clear(Color.ForestGreen);
                s.carUp(g);
            }
            else if (e.KeyCode == Keys.Down)
            {
                keyPress = 'd';
                g.Clear(Color.ForestGreen);
                s.carDown(g);
            }
            else if (e.KeyCode == Keys.Left)
            {
                keyPress = 'l';
                g.Clear(Color.ForestGreen);
                s.carLeft(g);
            }
            else if (e.KeyCode == Keys.Right)
            {
                keyPress = 'r';
                g.Clear(Color.ForestGreen);
                s.carRight(g);
            }
        }

        private void carPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel100_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel118_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel119_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
