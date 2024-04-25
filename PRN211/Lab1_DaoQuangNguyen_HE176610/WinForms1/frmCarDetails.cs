using AutomobileLibrary.BusinessObject;
using AutomobileLibrary.Repository;

namespace WinForms1
{
    public partial class frmCarDetails : Form
    {
        public frmCarDetails() => InitializeComponent();
        //-------------------------------------------------------
        public ICarRepository CarRepository { get; set; }
        public bool InsertOrUpdate { get; set; } //Fasle : Insert, True : Update
        public Car CarInfo { get; set; }
        //-------------------------------------------------------
        private void frmCarDetails_Load(object sender, EventArgs e)
        {
            cboManufacturer.SelectedIndex = 0;
            txtCarID.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true) //Update mode
            {
                //Show car to perform updating
                txtCarID.Text = CarInfo.CarID.ToString();
                txtCarName.Text = CarInfo.CarName;
                txtPrice.Text = CarInfo.Price.ToString();
                txtReleaseYear.Text = CarInfo.ReleaseYear.ToString();
                cboManufacturer.Text = CarInfo.Manufacturer.Trim();
            }
        }//end frmCarDetails_Load
        //-------------------------------------------------------
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var car = new Car
                {
                    CarID = int.Parse(txtCarID.Text),
                    CarName = txtCarName.Text,
                    Manufacturer = cboManufacturer.Text,
                    Price = decimal.Parse(txtPrice.Text),
                    ReleaseYear = int.Parse(txtReleaseYear.Text)
                };
                if ( car.ReleaseYear <= 1800)
                {
                    MessageBox.Show("Release Year must be Integer and 1800 > ReleaseYear");
                }
                else
                {
                    if (InsertOrUpdate == false)
                    {
                        CarRepository.InsertCar(car);
                        MessageBox.Show("Add new car successful.");
                    }
                    else
                    {
                        CarRepository.UpdateCar(car);
                        MessageBox.Show("Update car successful");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new car" : "Update a car");
            }
        }//end btnSave_click
         //-------------------------------------------------------
        
        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void txtPrice_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtReleaseYear_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }//end Form
}
