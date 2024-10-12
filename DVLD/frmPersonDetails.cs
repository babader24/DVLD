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

            PersonInfo._ID = ID;
            InitializeComponent();
            
        }


    }
}
