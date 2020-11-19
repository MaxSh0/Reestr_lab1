using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ReestrLab1
{
    class miniLift
    {
        private PictureBox Sprite;
        public int CurrentFloor = 1;
        private Lift lift = new Lift();
        private Dictionary<int,int> floorsCoordinate = new Dictionary<int,int>();
        public miniLift()
        {
        }

        public miniLift(PictureBox Sprite, Lift lift)
        {
            this.Sprite = Sprite;
            this.lift = lift;
            floorsCoordinate.Add(1, 340);
            floorsCoordinate.Add(2, 260);
            floorsCoordinate.Add(3, 180);
            floorsCoordinate.Add(4, 100);
            floorsCoordinate.Add(5, 20);
        }

        public async Task MovementBetweenFloors(int FloorNumber)
        {
            if (lift.OpenDoor) 
            {
                lift.closeDoor();
            }
            
            if (lift.OpenDoor == false)
            {
                
                Timer timer = new Timer();
                Timer timerClose = new Timer();
                timer.Interval = 10; // каждые 30 миллисекунд
                int countFloor = Math.Abs(FloorNumber - this.CurrentFloor);
                int count = 0;
                int max = 50;
                int speed = 0;
                bool tRun = true;
                if (this.CurrentFloor < FloorNumber)
                {
                    speed = -8;
                }
                if (this.CurrentFloor > FloorNumber)
                {
                    speed = 8;
                }

                timer.Tick += new EventHandler((o, ev) =>
                {
                    //this.Sprite.Location = new Point(this.Sprite.Location.X, this.Sprite.Location.Y + speed);
                    count++;

                    if (count == max)
                    {
                        //lift.openDoor();
                        this.Sprite.Location = new Point(this.Sprite.Location.X, floorsCoordinate[FloorNumber]);
                        CurrentFloor = FloorNumber;
                        Timer t = o as Timer;
                        t.Stop();
                        tRun = false;
                    }
                });
                timer.Start();
                while (tRun) { Application.DoEvents(); }
            }

        }
    }


}
