using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_Agency
{
    public partial class FindVehicleType : Form
    {
        public FindVehicleType()
        {
            InitializeComponent();
            vehicleTypeDataGridView.CellClick += VehicleTypeDataGridView_CellClick;
        }

        private void VehicleTypeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }
        void Bind_Data()
        {
            String query = $"SELECT * FROM VehicleType;";
            DataTable table = Database.getDataTableAfterRunningQuery(query);
            General.validTextboxEntry(queryResultLabel, query, vehicleTypeDataGridView);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FindVehicleType_Load(object sender, EventArgs e)
        {
            Bind_Data();
        }

        private void vehicletypesearchbtn_Click(object sender, EventArgs e)
        {
            queryResultLabel.Visible = true;
            String VehicleName = vehicleTypeNameTextbox.Text.TrimEnd();

            if (VehicleName == "")
            {
                queryResultLabel.Text = "Uh oh! Branch Name cannot be empty!";
                queryResultLabel.ForeColor = Color.FromArgb(255, 255, 255);
            }

            else
            {
                String query = $"SELECT * FROM VehicleType WHERE Vtype = '{VehicleName}';";
                General.validTextboxEntry(queryResultLabel, query, vehicleTypeDataGridView);

            }

            vehicleTypeNameTextbox.Text = "";
        }
    }
}
