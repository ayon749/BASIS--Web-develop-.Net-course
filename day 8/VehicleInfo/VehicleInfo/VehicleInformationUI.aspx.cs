using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VehicleInfo
{
	public partial class VehicleInformationUI : System.Web.UI.Page
	{
		Vehicle aVehicle = new Vehicle();

		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void createButton_Click(object sender, EventArgs e)
		{
			aVehicle.VehicleName = vehicleNameTextBox.Text;
			aVehicle.RegNo = regNoTextBox.Text;
			ViewState["AVehicle"] = aVehicle;
			
			

		}

		protected void speedEnterButton_Click(object sender, EventArgs e)
		{
			Vehicle tempVehicle =( Vehicle) ViewState["AVehicle"];
			tempVehicle.Speed.Add(Convert.ToDouble(speedTextBox.Text));



			ViewState["AVehicle"] =tempVehicle;
			speedTextBox.Text = string.Empty;


		}

		protected void showButton_Click(object sender, EventArgs e)
		{
			Vehicle bVehicle = (Vehicle)ViewState["AVehicle"];

			double maxSpeed = bVehicle.GetMaxSpeed();
			double minSpeed = bVehicle.GetMMinSpeed();
			double avgSpeed = bVehicle.GetAvgSpeed();
			avgSpeed = Math.Round(avgSpeed, 2);
			maxSpeedLabel.Text = maxSpeed.ToString();
			minSpeedLabel.Text = minSpeed.ToString();
			avgSpeedLabel.Text = avgSpeed.ToString();
			vehicleNameTextBox.Text = string.Empty;
			regNoTextBox.Text = string.Empty;


		}
	}
}