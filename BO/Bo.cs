using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace BO
{
    public class Bo
    {
        Dal d = new Dal();
        public int x = 3;
        public int y = 3;
        public char key = 'r';
        public bool saveSpeed(Car c)
        {
            return d.save(Convert.ToString(c.speed));
        }
        public int speedCalculation()
        {
            Car c = d.getData();
            if (c.speed == 10)
                return 1000;
            else if (c.speed == 20)
                return 650;
            else if (c.speed == 30)
                return 350;
            else if (c.speed == 40)
                return 250;
            else if (c.speed == 50)
                return 180;
            else if (c.speed == 60)
                return 100;
            else if (c.speed == 70)
                return 65;
            else if (c.speed == 80)
                return 40;
            else if (c.speed == 90)
                return 20;
            else if (c.speed == 100)
                return 1;
            else
                return 0;
        }

        public int getData()
        {
            Car c = d.getData();
            int speed = c.speed;
            return speed;
        }
        public void changeAxes(char key)
        {
            if (key == 'u')
            {
                if (y == 1 && (x >= 1 && x<= 1049))
                    y = y + 0;
                else if ((y == 241) && ((x >= 75 && x <= 425) || (x >= 491 && x <= 860)))
                    y = y + 0; 
                else
                    y = y -  2;
            }
            else if (key == 'd')
            {
                if (y == 327 && (x >= 1 && x <= 1049))
                    y = y + 0;
                else if ((y == 105) && ((x >= 56 && x <= 425) || (x >= 601 && x <= 860)))
                    y = y + 0;
                else
                y = y + 2;
            }
            else if (key == 'l')
            {
                if ((x >= 0 && x <= 1) && (y >= 1 && y <= 400))
                    x = x + 0;
                else if ((x == 457) && (y >= 33 && y <= 273))
                    x = x + 0;
                else if ((x == 855) && (y >= 33 && y <= 273))
                    x = x + 0;
                else
                x = x - 2;
            }
            else if (key == 'r')
            {
                if ((x == 905) && (y >= 1 && y <= 401))
                    x = x + 0;
                else if((x>=85) && (y>=79 && y<=217))
                    x = x + 0;
                else if ((x == 505) && (y >= 79 && y <= 217))
                    x = x + 0;
                else
                    x = x + 2;
            }
        }
        public void setKey(char c)
        {
            key = 'c';
        }
        public char getKey()
        {
            return key;
        }
    }
}
