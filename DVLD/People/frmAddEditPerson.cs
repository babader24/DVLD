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
    public partial class frmAddEdit : Form
    {
        
        public frmAddEdit(int ID)
        {                  
            InitializeComponent();
            SendID(ID); 
        }

        private void SendID(int PersonID)
        {
            ucAddEdit person = this.Controls.OfType<ucAddEdit>().FirstOrDefault();
            if (person != null)
            {
                person.ID = PersonID;
                person._Loadata();
            }
        }

    }
}
