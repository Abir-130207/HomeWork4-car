using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Entity
{
    public class Car
    {
        public int speed;

        public void carRight(Graphics g)
        {
         
            Pen p = new Pen(Color.DarkBlue, 3);
            Pen q = new Pen(Color.DarkBlue, 2);
            Pen r = new Pen(Color.White, 2);
            Pen s = new Pen(Color.White, 1);
            g.DrawLine(p, 25, 10, 100, 10);
            g.DrawLine(p, 12, 30, 25, 10);
            g.DrawLine(p, 12, 30, 2, 30);
            g.DrawLine(p, 2, 45, 2, 30);
            g.DrawLine(p, 112, 30, 100, 10);
            g.DrawLine(p, 115, 30, 138, 30);
            g.DrawLine(p, 138, 45, 138, 30);
            g.DrawLine(p, 2, 45, 25, 45);
            g.FillRectangle(Brushes.Turquoise, 27, 12, 36, 17);
            g.FillRectangle(Brushes.Turquoise, 64, 12, 36, 17);
            g.DrawLine(q, 12, 30, 115, 30);
            g.FillRectangle(Brushes.DarkBlue, 4, 31, 133, 13);
            g.FillEllipse(Brushes.Black, 23, 35, 20, 20);
            g.FillEllipse(Brushes.White, 30, 42, 7, 7);
            g.DrawLine(p, 42, 45, 90, 45);
            g.FillEllipse(Brushes.Black, 88, 35, 20, 20);
            g.FillEllipse(Brushes.White, 95, 42, 7, 7);
            g.DrawLine(p, 138, 45, 107, 45);
            g.DrawLine(r,25, 15, 25, 29);
            g.DrawLine(s, 25, 14, 25, 28);
            g.DrawLine(r, 24, 17, 24, 29);
            g.DrawLine(r, 23, 18, 23, 29);
            g.DrawLine(r, 22, 20, 22, 29);
            g.DrawLine(r, 21, 22, 21, 29);
            g.DrawLine(r, 20, 24, 20, 29);
            g.DrawLine(r, 19, 26, 19, 29);
            g.DrawLine(r, 18, 28, 18, 29);

            g.DrawLine(r, 102, 14, 102, 29);
            g.DrawLine(s, 102, 16, 102, 29);
            g.DrawLine(r, 103, 18, 103, 28);
            g.DrawLine(r, 104, 20, 104, 29);
            g.DrawLine(r, 105, 22, 105, 29);
            g.DrawLine(r, 106, 24, 106, 29);
            g.DrawLine(r, 107, 26, 107, 29);
            g.DrawLine(r, 108, 28, 108, 29);
            g.DrawLine(r, 109, 29, 109, 29);
            g.FillEllipse(Brushes.Yellow, 138, 32, 6, 6);
          
        
          
          
          
        }

         public void carLeft(Graphics g)
        {
           
            Pen p = new Pen(Color.DarkBlue, 3);
            Pen q = new Pen(Color.DarkBlue, 2);
            Pen r = new Pen(Color.White, 2);
            Pen s = new Pen(Color.White, 1);
            g.DrawLine(p, 3, 30, 3, 45);
            g.DrawLine(p, 2, 30, 22, 30);
            g.DrawLine(p, 37, 10, 22, 30);
            g.DrawLine(p, 39, 10, 112, 10);
            g.DrawLine(p, 122, 30, 112, 10);
            g.DrawLine(p, 125, 30, 138, 30);
            g.DrawLine(p, 140, 45, 140, 30);
            g.DrawLine(p, 138, 45, 112, 45);
            g.DrawLine(p, 97, 45, 49, 45);
            g.DrawLine(p, 3, 45, 31, 45);
            g.FillRectangle(Brushes.Turquoise, 38, 12, 36, 17);
            g.FillRectangle(Brushes.Turquoise, 75, 12, 36, 17);
            g.DrawLine(q, 12, 30, 138, 30);
            g.DrawLine(q, 20, 30, 146, 30);
            g.DrawLine(q, 20, 46, 146, 46);
            g.FillRectangle(Brushes.DarkBlue, 5, 31, 138, 13);
            g.FillEllipse(Brushes.Black, 28, 35, 20, 20);
            g.FillEllipse(Brushes.White, 34, 42, 7, 7);
            g.FillEllipse(Brushes.Black, 93, 35, 20, 20);
            g.FillEllipse(Brushes.White, 99, 42, 7, 7);
            g.DrawLine(r, 36, 15, 36, 29);
            g.DrawLine(s, 35, 16, 35, 28);
            g.DrawLine(r, 34, 18, 34, 29);
            g.DrawLine(r, 33, 20, 33, 29);
            g.DrawLine(r, 32, 22, 32, 29);
            g.DrawLine(r, 31, 24, 31, 29);
            g.DrawLine(r, 30, 26, 30, 29);
            g.DrawLine(r, 29, 28, 29, 29);
            g.DrawLine(r, 28, 29, 28, 29);

            g.DrawLine(r, 113, 14, 113, 29);
            g.DrawLine(s, 113, 16, 113, 29);
            g.DrawLine(r, 114, 18, 114, 29);
            g.DrawLine(r, 115, 20, 115, 29);
            g.DrawLine(r, 116, 22, 116, 29);
            g.DrawLine(r, 117, 24, 117, 29);
            g.DrawLine(r, 118, 26, 118, 29);
            g.DrawLine(r, 119, 28, 119, 29);
            g.DrawLine(r, 120, 29, 120, 29);
            g.FillEllipse(Brushes.Yellow, -2, 32, 6, 6);
          
          
        
          
        }
        public void carUp(Graphics g)
        {
            
            Pen p = new Pen(Color.DarkBlue, 3);
            Pen r = new Pen(Color.Turquoise, 2);
            g.DrawLine(p, 20, 43, 20, 103);//left long line
            g.DrawLine(p, 60, 102, 60, 42);//right long line
            g.DrawLine(p, 25, 33, 56, 33);//top mid 1
            g.DrawLine(p, 20, 43, 60, 43);//top mid 2
            g.DrawLine(p, 25, 33, 20, 43);//left top break
            g.DrawLine(p, 55, 33, 60, 43);//right top break
            g.DrawLine(p, 25, 110, 20, 100);//left down break
            g.DrawLine(p, 55, 110, 60, 100);//right down break
            g.DrawLine(p, 60, 100, 20, 100);//down mid 3
            g.DrawLine(p, 25, 110, 55, 110);//down mid 4
            g.FillRectangle(Brushes.DarkBlue, 20, 42, 41, 60);//top rectangle
            g.FillRectangle(Brushes.DarkBlue, 25, 111, 32, 8);//back rectangle
            g.FillRectangle(Brushes.DarkBlue, 24, 12, 32, 20);//front rectangle
            g.DrawLine(r, 59, 103, 22, 103);
            g.DrawLine(r, 60, 101, 22, 101);
            g.DrawLine(r, 56, 105, 25, 105);
            g.DrawLine(r, 56, 107, 25, 107);

            g.DrawLine(r, 55, 35, 27, 35);
            g.DrawLine(r, 54, 36, 26, 36);
            g.DrawLine(r, 56, 37, 25, 37);
            g.DrawLine(r, 57, 38, 24, 38);
            g.DrawLine(r, 58, 39, 23, 39);
            g.DrawLine(r, 59, 40, 22, 40);
            g.FillEllipse(Brushes.Yellow, 28, 7, 6, 6);
            g.FillEllipse(Brushes.Yellow, 46, 7, 6, 6);
            
            
            

        }

        public void carDown(Graphics g)
        {

            Pen p = new Pen(Color.DarkBlue, 3);
            Pen r = new Pen(Color.Turquoise, 2);
            g.DrawLine(p, 20, 20, 20, 80);
            g.DrawLine(p, 60, 80, 20, 80);
            g.DrawLine(p, 60, 80, 60, 20);
            g.DrawLine(p, 20, 20, 60, 20);
            g.DrawLine(p, 25, 10, 20, 20);
            g.DrawLine(p, 55, 10, 60, 20);
            g.DrawLine(p, 25, 10, 55, 10);
            g.DrawLine(p, 25, 90, 20, 80);
            g.DrawLine(p, 55, 90, 60, 80);
            g.DrawLine(p, 25, 90, 55, 90);
            g.FillRectangle(Brushes.DarkBlue, 20, 22, 43, 60);
            g.FillRectangle(Brushes.DarkBlue, 25, 90, 32, 20);
            g.FillRectangle(Brushes.DarkBlue, 25, 03, 32, 10);
            //down
            g.DrawLine(r, 56, 84, 25, 84);
            g.DrawLine(r, 56, 85, 25, 85);
            g.DrawLine(r, 56, 86, 25, 86);
            g.DrawLine(r, 56, 87, 25, 87);
            //up
            g.DrawLine(r, 56, 13, 25, 13);
            g.DrawLine(r, 56, 14, 25, 14);
            g.DrawLine(r, 56, 15, 25, 15);
            g.DrawLine(r, 56, 16, 25, 16);
            g.DrawLine(r, 56, 17, 25, 17);
            g.DrawLine(r, 56, 18, 25, 18);
            g.DrawLine(r, 56, 19, 24, 19);
            g.DrawLine(r, 57, 20, 25, 20);
            g.FillEllipse(Brushes.Yellow, 28, 108, 6, 6);
            g.FillEllipse(Brushes.Yellow, 46, 108, 6, 6);


      }
    }
   
}
