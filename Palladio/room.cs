using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Windows.Forms;


namespace Palladio
{
    public class room
    {
        //fields
        
        public int x1 { get; set; }
        public int y1 { get; set; }
        public int x2 { get; set; }
        public int y2 { get; set; }
        public double area { get; set; }

             
        //method
        public void DrawRoom(System.Windows.Forms.Panel canvas, System.Drawing.Color color)
        {
            System.Drawing.Pen myPen = new System.Drawing.Pen(color);
            Graphics formGraphics;
            formGraphics = canvas.CreateGraphics();
            formGraphics.DrawRectangle(myPen, new Rectangle(x1,y1,x2,y2));
            myPen.Dispose();
            formGraphics.Dispose();
        }

       public room SplitRoomVert(int split)

        {
            
            int splitsize = split;
            room temproom = new room { };

            //for (int i = 1; i < splitsize; i++)
                //create the room and add it to the villa
                temproom.x1 = x1 ;
                temproom.x2 = x2 ;
                temproom.y1 = y1 ;
                temproom.y2 = y2 / splitsize;

            return temproom;


        }

        public room SplitRoomHor(int split)

        {

            int splitsize = split;
            room temproom = new room { };

            //for (int i = 1; i < splitsize; i++)
            //create the room and add it to the villa
            temproom.x1 = x1;
            temproom.x2 = x2 / splitsize;
            temproom.y1 = y1;
            temproom.y2 = y2 ;

            return temproom;


        }

        private Graphics CreateGraphics()
        {
            throw new NotImplementedException();
        }
    }
}
