using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutOfClass5
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            for (int i = 1940; i <= 2019; i++)
            {
                yearBox.Items.Add(i);
            }
        }

        //They are being tracked if any of these apply
        //= winter month
        //= born in 2000
        //= someone looked at them
        //= if they got a targeted ad

    public void truthBtn_Click(object sender, EventArgs e)
        {

            //month checks
            if (monthBox.SelectedItem.ToString() == "November"
                || monthBox.SelectedItem.ToString() == "December"
                || monthBox.SelectedItem.ToString() == "January"
                || monthBox.SelectedItem.ToString() == "February")
            {
                TruthForm myTruthForm = new TruthForm();
                myTruthForm.ShowDialog();
            }
            //someone looked at them
            else if (yesBtn.Checked)
            {
                TruthForm myTruthForm = new TruthForm();
                myTruthForm.ShowDialog();
            }
            //born in 2000
            else if (yearBox.SelectedItem.ToString() == "2000")
            {
                TruthForm myTruthForm = new TruthForm();
                myTruthForm.ShowDialog();
            }
            //if they get a targeted ad
            else if (adBox.SelectedItem.ToString() == "Yes")
            {
                TruthForm myTruthForm = new TruthForm();
                myTruthForm.ShowDialog();
            }
            else
                MessageBox.Show("You are safe, but be careful.");

        }
       
    }

}
