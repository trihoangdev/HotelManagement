using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.Forms
{
    public partial class HomeFrm : Form
    {
        public HomeFrm()
        {
            InitializeComponent();
        }

        private void btnCreateNewCustomer_Click(object sender, EventArgs e)
        {
            //Kích hoạt các control
            txtCustomerId.Enabled = true;
            txtCustomerName.Enabled = true;
            txtCustomerAddress.Enabled = true;
            txtCustomerEmail.Enabled = true;    
            txtCustomerPhone.Enabled = true;
            dtCustomerBirthDate.Enabled = true;
            dtCustomerDateJoined.Value = DateTime.Now;  
            gbCustomerGender.Enabled = true;
            txtCustomerNote.Enabled = true;

        }

        private void btnCreateNewRoom_Click(object sender, EventArgs e)
        {
            //Kích hoạt các control
            numbericCapacity.Enabled = true;
            txtRoomPrice.Enabled = true;
            comboRoomType.Enabled = true;
            btnAddNewCustomer.Enabled = true;

            //Khởi tạo mã phòng tự động tăng
        }


    }
}
