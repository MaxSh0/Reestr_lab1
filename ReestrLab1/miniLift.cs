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
        await Task.Delay(2000);
        this.Sprite.Location = new Point(this.Sprite.Location.X, floorsCoordinate[FloorNumber]);
        CurrentFloor = FloorNumber;
         

        }
    }


}
