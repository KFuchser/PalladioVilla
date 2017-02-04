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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "3";
            /*randomize the size of the villa
            //create a collection of rooms
            add the villa to the collection
            button 1 should be create the villa
            draw the villa */
            room aroom = new room(); // {x1=100,x2=200,y1=100,y2=200};
            aroom.x1 = 100;
            aroom.x2 = 200;
            aroom.y1 = 100;
            aroom.y2 = 200;
            aroom.DrawRoom(panel1, System.Drawing.Color.Black);
                                  
        }

       private void Buttonsplit_Click(object sender, EventArgs e)
         {
            /* for each room in the collection 
             *decide if should split
             * if so 
             * then randomize split (3) calculate new rooms and add new rooms to the villa

                */

            int split;
            split = Convert.ToInt32(textBox1.Text);

        room aroom = new room { };
       
        aroom.x1 = 100;
         aroom.y1 = 100;
        aroom.x2 = 200;
        aroom.y2 = 200;
       // aroom.DrawRoom(panel1);
        room anotherroom = new room { };
     //   anotherroom.DrawRoom(panel1);
        anotherroom = aroom.SplitRoomVert(split);
            anotherroom.DrawRoom(panel1, System.Drawing.Color.Aquamarine);
        }

       private void ButtonSplit_ClickHor(object sender, EventArgs e)
        {
            /* for each room in the collection 
             *decide if should split
             * if so 
             * then randomize split (3) calculate new rooms and add new rooms to the villa

                */

            int split;
            
            split = Convert.ToInt32(textBox1.Text);

            room aroom = new room { };
            
            aroom.x1 = 100;
            aroom.y1 = 100;
            aroom.x2 = 200;
            aroom.y2 = 200;
            // aroom.DrawRoom(panel1);
            room anotherroom = new room { };
            //   anotherroom.DrawRoom(panel1);
            anotherroom = aroom.SplitRoomHor(split);
            anotherroom.DrawRoom(panel1, System.Drawing.Color.Blue);
        }

    }
}
