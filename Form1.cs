using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 0;
        int nap = 0;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {   
            speed gear = new speed();
            move action = new move();
            //тормоз
            if (e.KeyValue == action.brake)
            {
                i = 0;
                label1.Text = "0";
            }
            ////кпп
            if (e.KeyValue == gear.up1 && i < 4)
            {
                i = i + gear.up;
                label1.Text = i.ToString();
            }
            if (e.KeyValue == gear.down1 && i > -1)
            {
                i = i + gear.down;
                label1.Text = i.ToString();

            }
            //передвежение
            //вверх
            if (e.KeyValue == action.up)
            {
                car.Image = Image.FromFile("C:\\MKod\\С#\\OOP\\Resources\\carUp.png");
                car.Height = 101;
                car.Width = 65;
                car.Top = car.Top - 5 * i;
                nap = 1;
            }
            //вниз
            if (e.KeyValue == action.down)
            {
                car.Image = Image.FromFile("C:\\MKod\\С#\\OOP\\Resources\\CarDown.png");
                
                car.Height = 101;
                car.Width = 65;
                car.Top = car.Top + 5 * i;
                nap = 2;
                
            }
            //влево
            if (e.KeyValue == action.left)
            {
                car.Image = Image.FromFile("C:\\MKod\\С#\\OOP\\Resources\\carLeft.png");

                car.Height = 65;
                car.Width = 101;
                car.Left = car.Left - 5 * i;
                nap = 3;
            }
            //вправо
            if (e.KeyValue == action.righ)
            {
                car.Image = Image.FromFile("C:\\MKod\\С#\\OOP\\Resources\\carRight.png");
                
                car.Height = 65;
                car.Width = 101;
                car.Left = car.Left + 5 * i;
                nap= 4;
            }
            //вл
            //if (e.key == action.up && e.KeyValue == action.left)
            //{
            //    car.Top = car.Top - 5 * i;//up
            //    car.Left = car.Left - 5 * i;//left

            //}
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (nap == 4)
                car.Left = car.Left + 5 * i;
            if  (nap==3)
               car.Left = car.Left - 5 * i;
            if (nap==2)
                car.Top = car.Top + 5 * i;
            if (nap==1)
                car.Top = car.Top - 5 * i;

        }
    }
}
