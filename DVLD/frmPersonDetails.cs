using DVLD_BusneissLayer;
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
    public partial class frmPersonDetails : Form
    {
        
       
        public frmPersonDetails(int ID)
        {

            //PersonInfo._ID = ID;
            InitializeComponent();
            SendID(ID);
            
        }

        private void SendID(int PersonID)
        {
            ucPersonInfo person = this.Controls.OfType<ucPersonInfo>().FirstOrDefault();
            if (person != null)
            {
                person._ID = PersonID;
                person._LaodData();
            }
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
