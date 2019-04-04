// Grading ID 2937
// Program 2
// Due: 10/23/17
// Section 200-01
// Description: this program allows you to add addresses and to a list and to take those addresses and create letter objects.
using Prog2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPVApp
{
    public partial class Prog2Form : Form
    {
        private UserParcelView upv;

        public Prog2Form()
        {
            InitializeComponent();

            upv = new UserParcelView();

            upv.AddAddress("John Smith", "123 Any St.", "Apt. 45",
            "Louisville", "KY", 40202); // Test Address 1
            upv.AddAddress("Jane Doe", "987 Main St.", "",
            "Beverly Hills", "CA", 90210); // Test Address 2
            upv.AddAddress("James Kirk", "654 Roddenberry Way", "Suite 321",
            "El Paso", "TX", 79901); // Test Address 3
            upv.AddAddress("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 04101); // Test Address 4
            upv.AddAddress("John Doe", "111 Market St.", "",
                "Jeffersonville", "IN", 47130); // Test Address 5
            upv.AddAddress("Jane Smith", "55 Hollywood Blvd.", "Apt. 9",
                "Los Angeles", "CA", 90212); // Test Address 6
            upv.AddAddress("Captain Robert Crunch", "21 Cereal Rd.", "Room 987",
                "Bethesda", "MD", 20810); // Test Address 7
            upv.AddAddress("Vlad Dracula", "6543 Vampire Way", "Apt. 1",
                "Bloodsucker City", "TN", 37210); // Test Address 8

            upv.AddLetter(upv.AddressAt(0), upv.AddressAt(1), 3.95M);
            upv.AddLetter(upv.AddressAt(2), upv.AddressAt(3), 4.25M);
            upv.AddGroundPackage(upv.AddressAt(4), upv.AddressAt(5), 14, 10, 5, 12.5);
            upv.AddGroundPackage(upv.AddressAt(6), upv.AddressAt(7), 12, 9, 6, 10);
            upv.AddNextDayAirPackage(upv.AddressAt(0), upv.AddressAt(2), 25, 15, 10, 11, 7.0M);
            upv.AddNextDayAirPackage(upv.AddressAt(2), upv.AddressAt(4), 20, 10, 8, 15, 10.5M);
            upv.AddNextDayAirPackage(upv.AddressAt(4), upv.AddressAt(6), 15, 12, 12, 10, 6.5M);
        }

        // Precondition: Button must be clicked
        // postcondition: form will close
        private void exitToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            this.Close();
        }
        // Precondition: Button must be clicked
        // postcondition: about message box will appear.
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            MessageBox.Show("Grading ID 2937" + System.Environment.NewLine + "CIS 200-01" + System.Environment.NewLine + "Program 2" + System.Environment.NewLine + "Due: 10/23/2017");

        }
        // Precondition: Button must be clicked
        // postcondition: the address form will be opened
        private void addressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddressForm addressForm = new AddressForm();
            DialogResult addressResult;
            addressResult = addressForm.ShowDialog();

            if (addressResult == DialogResult.OK)
            {
                int zip;
                int.TryParse(addressForm.zipText, out zip);
                upv.AddAddress(addressForm.nameText, addressForm.address1Text, addressForm.address2Text, addressForm.cityText, addressForm.stateText, zip);
            }
        }
        // Precondition: Button must be clicked
        // postcondition: the letter form will be opened
        private void letterToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            LetterForm letterForm = new LetterForm(upv);
            DialogResult letterResult;
            letterResult = letterForm.ShowDialog();

            if (letterResult == DialogResult.OK)
            {
                
                upv.AddLetter(letterForm.OriginAddress, letterForm.DestinationAddress, letterForm.FixedCost);
            }
        }
        // Precondition: Button must be clicked
        // postcondition: list of addresses will be displayed
        private void listOfAddressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            outputBox.Clear();
            foreach (var address in upv.AddressList)
            {
                outputBox.AppendText(Environment.NewLine);
                outputBox.AppendText(address.ToString());
                outputBox.AppendText(Environment.NewLine);
            }
        }

        // Precondition: Button must be clicked
        // postcondition: list of parcels will be displayed
        private void listParcelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            outputBox.Clear();
            foreach (var address in upv.ParcelList)
            {
                outputBox.AppendText(Environment.NewLine);
                outputBox.AppendText(address.ToString());
                outputBox.AppendText(Environment.NewLine);


            }
        }
    }
}
