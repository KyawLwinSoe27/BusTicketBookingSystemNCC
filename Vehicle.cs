using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusTicketBookingSystem
{
    public partial class Vehicle : Form
    {
        BusDSTableAdapters.vehicleTableAdapter adapter = new BusDSTableAdapters.vehicleTableAdapter();
        public Vehicle()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Vehicle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsVehicle cv = new clsVehicle();

            cv.cVehicle_ID = textBox1.Text;
            cv.cVehicle_Name = VehicleName.Text;
            cv.cVehicle_Type = VehicleType.Text;
            cv.cTotal_Seat = Convert.ToInt32(totalSeat.Value);
           



            int data = adapter.Insert(cv.cVehicle_ID,cv.cVehicle_Name,cv.cVehicle_Type,cv.cTotal_Seat);

            if (data > 0)
            {
                MessageBox.Show("Vehicle Entry Successfully", "Vehicle Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
