using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Cars BlueCar = new Cars();
        key action = new key();
        
        int direction;
        int i = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            Cars BlueCar= new Cars();

            BlueCar.size = new Size(30, 60);
            car.Size = BlueCar.size;

            BlueCar.location = new Point(300,300); 
            car.Location=BlueCar.location;
            
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {   Cars BlueCar = new Cars();  
            Move move  = new Move();
            //Повысить передачу
            if (e.KeyValue == action.Shift && i < 5)
            {
                i++;
                label1.Text = i.ToString();
            }
            //Понизить передачу
            if (e.KeyValue == action.Ctrl && i > -1)
            {
                i--;
                label1.Text = i.ToString();
            }
            ////Повернуть налево 
            if (e.KeyValue ==action.Left)
            { 
                BlueCar.size= new Size(60,30);
                car.Size = BlueCar.size;
                car.Left = car.Left - 5 * i;
                
                car.Image = move.imageLeft;
                direction = 1;
            }
            //Повернуть направо 
            if (e.KeyValue == action.Righ)
            {
                BlueCar.size = new Size(60, 30);
                car.Size = BlueCar.size;
                car.Left = car.Left + 5 * i;
                car.Image = move.carRight;
                direction = 2;
            }
            //Повернуть вверх
            if (e.KeyValue == action.Up)
            {
                BlueCar.size = new Size(30, 60);
                car.Size = BlueCar.size;
                car.Top = car.Top - 5 * i;
                car.Image = move.carUp;
                direction = 3;
            }
            //Повернуть вниз 
            if (e.KeyValue == action.Down)
            {
                BlueCar.size = new Size(30, 60);
                car.Size = BlueCar.size;
                car.Top = car.Top + 5 * i;
                car.Image = move.carDown;
                direction = 4;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (direction == 1&&i!=0) 
                car.Left =car.Left -5 * i;

            if (direction == 2 && i != 0)
                car.Left = car.Left + 5 * i;

            if (direction == 3 && i != 0)
                car.Top = car.Top - 5*i;

            if (direction == 4 && i != 0)
                car.Top = car.Top + 5*i;
            
        }

        private void fuel_Tick(object sender, EventArgs e)
        {
            
           
            int k = 50;

            if (label2.Text!="0") 
            {
                k--;
                label2.Text=k.ToString();
            }
            

        }
    }
}
