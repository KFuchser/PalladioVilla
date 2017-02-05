using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Palladio
{
    public partial class Form1 : Form
    {
        List<room> villa = new List<room>();
        int split;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //need to randomize this. For now just set initial split to 3
            split = 3;
            //put the split number in the textbox
            textBox1.Text = "3";
            //create the initial villa 
            room villaroom = new room(); // {x1=100,x2=200,y1=100,y2=200};
            villaroom.x1 = 100;
            villaroom.width = 300;
            villaroom.y1 = 100;
            villaroom.height = 200;
            villaroom.area = villaroom.height * villaroom.width;
            //draw the villa outline. change line width
            villaroom.DrawRoom(panel1, System.Drawing.Color.Black);
            //add the room to the villa collection
            villa.Add(villaroom);
            //put the number of rooms in the villa in the textbox for error checking
            textBoxRooms.Text = Convert.ToString(villa.Count);
        }
    
        private void buttonSplitAll_Click(object sender, EventArgs e)
        {
            split = Convert.ToInt32(textBox1.Text);
            Random rnd = new Random();
           // int or = rnd.Next(1, 20);
            List<room> tempvilla = new List<room>();
            //for everyroom in the villa do this
            foreach (room aroom in villa)
            {
                if (aroom.area >20000)
                {
                   for (int i = 0; i < (split ); i++)
                    {
                        int or = rnd.Next(1, 20);
                        room anotherroom = new room { };
                        anotherroom = aroom.SplitRoom(split,i,or);
                        tempvilla.Add(anotherroom);
                    }
                }

                else
                {
                    textBoxX1.Text = ("too small");
                }
            }

            villa.AddRange(tempvilla);
           

            foreach (room aroom in villa)
            {
                aroom.DrawRoom(panel1, System.Drawing.Color.SteelBlue);
            }
            textBoxRooms.Text = Convert.ToString(villa.Count);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            villa.Clear();
            Graphics formGraphics;
            formGraphics = panel1 .CreateGraphics();
            formGraphics.Clear(System.Drawing.Color.WhiteSmoke);
        }
    }
}
