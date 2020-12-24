using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReestrLab1
{
    public partial class Form1 : Form
    {
        Lift lift1 = new Lift();
        Lift lift2 = new Lift();
        miniLift miniLift1 = new miniLift();
        miniLift miniLift2 = new miniLift();
        List<int> listTask1 = new List<int>();
        List<int> listTask2 = new List<int>();


        public Form1()
        {
            InitializeComponent();
            lift1 = new Lift(pictureBoxDoorLeft1, pictureBoxDoorRight1);
            lift2 = new Lift(pictureBoxDoorLeft2, pictureBoxDoorRight2);
            miniLift1 = new miniLift(pictureBoxMiniLift1, lift1);
            miniLift2 = new miniLift(pictureBoxMiniLift2, lift2);


        }

        //Первый лифт вверх
        private void button1_Click(object sender, EventArgs e)
        {
            
            
            this.Invoke(new Action(() =>
            {
                distribution(miniLift1.CurrentFloor, miniLift2.CurrentFloor, 1, listTask1, listTask2);
            }
            ));
            move2(listTask2);
            move1(listTask1);

        }
        private void button2_Click(object sender, EventArgs e)
        {

            this.Invoke(new Action(() =>
            {
                distribution(miniLift1.CurrentFloor, miniLift2.CurrentFloor, 2, listTask1, listTask2);
            }
            ));
            move2(listTask2);
            move1(listTask1);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Invoke(new Action(() =>
            {
                distribution(miniLift1.CurrentFloor, miniLift2.CurrentFloor, 3, listTask1, listTask2);
            }
            ));
            move2(listTask2);
            move1(listTask1);

        }

        private void button4_Click(object sender, EventArgs e)
        {

            this.Invoke(new Action(() =>
            {
                distribution(miniLift1.CurrentFloor, miniLift2.CurrentFloor, 4, listTask1, listTask2);
            }
            ));
            move2(listTask2);
            move1(listTask1);
        }

        private void button5_Click(object sender, EventArgs e)
        {

            this.Invoke(new Action(() =>
            {
                distribution(miniLift1.CurrentFloor, miniLift2.CurrentFloor, 5, listTask1, listTask2);
            }
            ));
            move2(listTask2);
            move1(listTask1);
        }

        private void button6_Click(object sender, EventArgs e)
        {

            this.Invoke(new Action(() =>
            {
                distribution(miniLift1.CurrentFloor, miniLift2.CurrentFloor, 1, listTask1, listTask2);
            }
            ));
            move2(listTask2);
            move1(listTask1);
        }

        private void button7_Click(object sender, EventArgs e)
        {

            this.Invoke(new Action(() =>
            {
                distribution(miniLift1.CurrentFloor, miniLift2.CurrentFloor, 2, listTask1, listTask2);
            }
            ));
            move2(listTask2);
            move1(listTask1);
        }

        private void button8_Click(object sender, EventArgs e)
        {

            this.Invoke(new Action(() =>
            {
                distribution(miniLift1.CurrentFloor, miniLift2.CurrentFloor, 3, listTask1, listTask2);
            }
            ));
            move2(listTask2);
            move1(listTask1);
        }

        private void button9_Click(object sender, EventArgs e)
        {

            this.Invoke(new Action(() =>
            {
                distribution(miniLift1.CurrentFloor, miniLift2.CurrentFloor, 4, listTask1, listTask2);
            }
            ));
            move2(listTask2);
            move1(listTask1);
        }

        private void button10_Click(object sender, EventArgs e)
        {

            this.Invoke(new Action(() =>
            {
                distribution(miniLift1.CurrentFloor, miniLift2.CurrentFloor, 5, listTask1, listTask2);
            }
            ));
            move2(listTask2);
            move1(listTask1);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Add_Sort(label20, listTask1, 1, miniLift1.CurrentFloor);
            move1(listTask1);
        }
        private void button14_Click(object sender, EventArgs e)
        {
            Add_Sort(label20, listTask1, 2, miniLift1.CurrentFloor);
            move1(listTask1);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Add_Sort(label20, listTask1, 3, miniLift1.CurrentFloor);
            move1(listTask1);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Add_Sort(label20, listTask1, 4, miniLift1.CurrentFloor);
            move1(listTask1);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Add_Sort(label20, listTask1, 5, miniLift1.CurrentFloor);
            move1(listTask1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Add_Sort(label9, listTask2, 1, miniLift2.CurrentFloor);
            move2(listTask2);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Add_Sort(label9, listTask2, 1, miniLift2.CurrentFloor);
            move2(listTask2);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Add_Sort(label9, listTask2, 2, miniLift2.CurrentFloor);
            move2(listTask2);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Add_Sort(label9, listTask2, 3, miniLift2.CurrentFloor);
            move2(listTask2);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Add_Sort(label9, listTask2, 4, miniLift2.CurrentFloor);
            move2(listTask2);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Add_Sort(label9, listTask2, 5, miniLift2.CurrentFloor);
            move2(listTask2);
        }

        private async void move1(List<int> listTask) 
        {
            await Task.Delay(3000);
            foreach (int floor in listTask.ToArray())
            {
               
                await miniLift1.MovementBetweenFloors(floor);
                label1.Text = floor.ToString();
                listTask.Remove(floor);
                Drawing_queue(label20, listTask);

            }
        }

        private async void move2(List<int> listTask)
        {
            await Task.Delay(3000);
            foreach (int floor in listTask.ToArray())
            {
                await miniLift2.MovementBetweenFloors(floor);
                label2.Text = floor.ToString();
                listTask.Remove(floor);
                Drawing_queue(label9, listTask);

            }
        }


        private void distribution(int CurrentFloor1, int CurrentFloor2, int Floor, List<int> listTask1, List<int> listTask2)
        {

            if (Math.Abs(Floor - CurrentFloor1) <= Math.Abs(Floor - CurrentFloor2)) 
            {
                Add_Sort(label20, listTask1, Floor, CurrentFloor1);
            }
            else 
            {
                Add_Sort(label9, listTask2, Floor, CurrentFloor2);
            }
        }


        private void Add_Sort(Label label, List<int> listTask, int Floor, int CurrentFloor) 
        {
            Sort_In increase = new Sort_In();
            Sort_de decrease = new Sort_de();
            label.Text = " ";

            if (Floor - CurrentFloor > 0)
            {
                listTask.Add(Floor);
                listTask.Sort(increase);
            }
            else if (Floor - CurrentFloor < 0)
            {
                listTask.Add(Floor);
                listTask.Sort(decrease);
            }


            foreach (int floor in listTask.ToArray())
            {
                label.Text += floor.ToString();
            }
        }


        private void Drawing_queue(Label label, List<int> listTask) 
        {
            label.Text = "";
            foreach (int floor in listTask.ToArray())
            {
                label.Text += floor.ToString();
            }
        }

    }





}
