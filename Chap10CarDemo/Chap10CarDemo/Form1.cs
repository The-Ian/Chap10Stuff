using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chap10CarDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetCarData(Car car)
        {
            int mileage;
            decimal price;
            int doors;

            car.Make = makeTB.Text;
            car.Model = modelTB.Text;

            if (int.TryParse(mileageTB.Text, out mileage))
            {
                car.Mileage = mileage;

                if (decimal.TryParse(priceTB.Text, out price))
                {
                    car.Price = price;

                    if (int.TryParse(doorsTB.Text, out doors))
                    {
                        car.Doors = doors;
                    }

                    else
                    {
                        MessageBox.Show("Invalid Number of Doors");
                    }

                }

                else
                {
                    MessageBox.Show("Invalid Price");
                }
            }

            else
            {
                MessageBox.Show("Invalid Mileage");
            }

        }

        private void createObjBtn_Click(object sender, EventArgs e)
        {
            Car myCar = new Car();

            GetCarData(myCar);

            makeLbl.Text = myCar.Make;
            modelLbl.Text = myCar.Model;
            mileageLbl.Text = myCar.Mileage.ToString();
            priceLbl.Text = myCar.Price.ToString("c");
            doorsLbl.Text = myCar.Doors.ToString();

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
