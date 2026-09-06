using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmScheduleTest : Form
    {
        private int _LocalDrivingLicenseApplication = 0;
        private clsTestType.enTestType _TestType = clsTestType.enTestType.VisionTest;
        private int _AppointmentID = -1;
        public frmScheduleTest(int LocalDrivingApplication,clsTestType.enTestType TestType,int AppointmentID = -1)
        {
            InitializeComponent();
            _LocalDrivingLicenseApplication = LocalDrivingApplication;
            _TestType = TestType;
            _AppointmentID = AppointmentID;
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmScheduleTest_Load(object sender, EventArgs e)
        {
            ctrlScheduleTest1.TestTypeID = _TestType;
            ctrlScheduleTest1.LoadInfo(_LocalDrivingLicenseApplication,_AppointmentID);
        }

        private void ctrlScheduleTest1_Load(object sender, EventArgs e)
        {

        }
    }
}
