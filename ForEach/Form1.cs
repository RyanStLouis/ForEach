/*
 * Created by: Ryan St. Louis
 * Created on: 2015-10-19
 * Created for: ICS3U
 * Daily Assignment – Daily Assignment #3-12
 * This program changes the font colour when pressing a button
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForEach
{
    public partial class frmForEach : Form
    {
        public frmForEach()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            foreach (Control aControl in this.Controls)
            {
                aControl.ForeColor = Color.Aquamarine;
            }
        }
    }
}
