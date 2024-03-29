﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExpertDatabase;

namespace CMPP248_Workshop
{
    public partial class Form1 : Form
    {
        public travelexpertsDataContext db = new travelexpertsDataContext();
        Package currentPackage;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //package = PackageDB.GetPackages();
            packageBindingSource.DataSource = new travelexpertsDataContext().Packages;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddModify secondForm = new frmAddModify();
            secondForm.isAdd = true;
            secondForm.currentPackage = null; // no current product when inserting
            DialogResult result = secondForm.ShowDialog(); // display second form modal
            if (result == DialogResult.OK) // new row got inserted
            {
                RefreshView();
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            using (travelexpertsDataContext dbContext = new travelexpertsDataContext())
            {
                currentPackage = (from p in dbContext.Packages // LINQ query that returns one record
                                  where p.PackageId.ToString() == packageIdTextBox.Text
                                  select p).Single(); // method Single runs the LINQ query, only when receiving one value
            }

            frmAddModify secondForm = new frmAddModify();
            secondForm.isAdd = false; // Modify mode
            secondForm.currentPackage = currentPackage;
            DialogResult result = secondForm.ShowDialog(); // display second form modal
            if (result == DialogResult.OK || result == DialogResult.Retry) // successful update or concurrency exception
            {
                RefreshView();
            }
        }

        public void RefreshView()
        {
            packageBindingSource.Clear();
            packageBindingSource.Add(new travelexpertsDataContext().Packages);

        }
    }
}