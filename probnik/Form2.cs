using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace probnik
{
    public partial class Form2 : Form
    {
        DAL dal = new DAL();
        public Form2()
        {
            InitializeComponent();
            ArrayList array = dal.GetPrepod();
            dataGridView1.DataSource = array;
        }
    }
}
