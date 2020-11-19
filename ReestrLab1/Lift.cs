using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ReestrLab1
{
    class Lift
    {
        private PictureBox LeftDoor;
        private PictureBox RightDoor;
        public bool OpenDoor = false;

        public Lift() 
        {
        }

        public Lift(PictureBox LeftDoor, PictureBox RightDoor) 
        {
            this.LeftDoor = LeftDoor;
            this.RightDoor = RightDoor;
        }


        public void openDoor()
        {
            if (!this.OpenDoor)
            {
                this.OpenDoor = true;
                Timer timer = new Timer();
                timer.Interval = 30; // каждые 30 миллисекунд
                int count = 0;
                int max = 10;
                timer.Tick += new EventHandler((o, ev) =>
                {

                    this.LeftDoor.Location = new Point(this.LeftDoor.Location.X - 10, this.LeftDoor.Location.Y);
                    this.RightDoor.Location = new Point(this.RightDoor.Location.X + 10, this.RightDoor.Location.Y);
                    count++;

                    if (count == max)
                    {
                        Timer t = o as Timer; // можно тут просто воспользоваться timer
                        t.Stop();
                    }
                });
                timer.Start();   // запустили, а остановится он сам  

            }

        }


        public void closeDoor()
        {
            if (this.OpenDoor)
            {
                this.OpenDoor = false;
                Timer timer = new Timer();
                timer.Interval = 30; // каждые 30 миллисекунд
                int count = 0;
                int max = 10;
                timer.Tick += new EventHandler((o, ev) =>
                {

                    this.LeftDoor.Location = new Point(this.LeftDoor.Location.X + 10, this.LeftDoor.Location.Y);
                    this.RightDoor.Location = new Point(this.RightDoor.Location.X - 10, this.RightDoor.Location.Y);
                    count++;

                    if (count == max)
                    {
                        Timer t = o as Timer; // можно тут просто воспользоваться timer
                        t.Stop();
                    }
                });
                timer.Start();   // запустили, а остановится он сам  

            }

        }
    }
}
