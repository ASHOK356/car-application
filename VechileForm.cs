using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car_application
{
    public partial class VechileForm : Form
    {
        Car a;
        public VechileForm()
        {
            InitializeComponent();
            cmbMake.Items.Add("Select Car Type");
            cmbMake.Items.Add("Fiat-Chrysler");
            cmbMake.Items.Add("Hyundai");
            cmbMake.Items.Add("Maruti");
            cmbMake.Items.Add("Ford Motor");
            cmbMake.Items.Add("Renault-Nissan Alliance");
            cmbColor.Items.Add("Select Color");
            cmbColor.Items.Add("Black");
            cmbColor.Items.Add("Brown");
            cmbColor.Items.Add("Grey");
            cmbColor.Items.Add("White");
            cmbColor.Items.Add("Red");
            cmbColor.SelectedIndex = 0;
            cmbMake.SelectedIndex = 0;
            cmbModel.SelectedText = "Select Model";

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Vehicleid.Text);
            string RegNo = this.RegNo.Text;
            DateTime dateOfManufacture = dateTimePicker1.Value;
            string make = cmbMake.Text;
            string model = cmbModel.Text;
            decimal price = decimal.Parse(Price.Text);
           string  Status  = currentstatus.Text;
            a = new Car(RegNo, make, model, price, dateOfManufacture);

        }


        private void btnGet_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Text = a.DateOfManufacture.ToString();
            RegNo.Text = a.RegNo.ToString();
            cmbModel.Text = a.Model;
            Price.Text = a.Price.ToString();
            cmbMake.Text = a.Make;
            Speed.Text = a.Speed.ToString();
            Vehicleid.Text = a.VehicleId.ToString();
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            RegNo.Clear();
            cmbColor.Text = "";
            cmbModel.Text = "";
            Price.Clear();
            cmbMake.Text = "";
            Speed.Clear();
            Vehicleid.Text = "";
        }

        private void Start_Click(object sender, EventArgs e)
        {
            a.Start();
            currentstatus.Text = a.Status;
            Speed.Text = "20";
            if ((DateTime.Now.Year - a.DateOfManufacture.Year) > Car.ServiceYear)
            {
                throw new ApplicationException("Your car service year has expired");
            }

        }

        private void Stop_Click(object sender, EventArgs e)
        {
            a = null;
            Speed.Text = null;
        }

        private void Accelerate_Click(object sender, EventArgs e)
        {
            
            a.acclerate(Convert.ToInt32(Speed.Text));
            currentstatus.Text = a.ToString();
        }

        private void Deaccelerate_Click(object sender, EventArgs e)
        {
            
            a.Deacclerate(Convert.ToInt32(Speed.Text));
            currentstatus.Text = a.ToString();
        }

      
        
        
    }
}

