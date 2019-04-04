// Grading ID 2937
// Program 2
// Due: 10/23/17
// Section 200-01
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog2
{
    public partial class AddressForm : Form
    {
        public AddressForm()
        {
            InitializeComponent();
        }

        ErrorProvider errorProviderAll = new ErrorProvider(); // Error provider for validation

        public string nameText
        {
            //Precondition: None
            //Postcondition: The textbox content returned
            get
            {
                return nameInput.Text;
            }
            //Precondition: None
            //Postcondition: The textbox value has been set.
            set
            {
                nameInput.Text = value;
            }
        }

        public string address1Text
        {
            //Precondition: None
            //Postcondition: The textbox content returned
            get
            {
                return address1Input.Text;
            }
            //Precondition: None
            //Postcondition: The textbox value has been set.
            set
            {
                address1Input.Text = value;
            }
        }

        public string address2Text
        {
            //Precondition: None
            //Postcondition: The textbox content returned
            get
            {
                return address2Input.Text;
            }
            //Precondition: None
            //Postcondition: The textbox value has been set.
            set
            {
                address2Input.Text = value;
            }
        }

        public string cityText
        {
            //Precondition: None
            //Postcondition: The textbox content returned
            get
            {
                return cityInput.Text;
            }
            //Precondition: None
            //Postcondition: The textbox value has been set.
            set
            {
                cityInput.Text = value;
            }
        }

        public string stateText
        {
            //Precondition: None
            //Postcondition: The textbox content returned
            get
            {
                return stateInput.Text;
            }

        }

        public string zipText
        {
            //Precondition: None
            //Postcondition: The textbox content returned
            get
            {
                return zipInput.Text;
            }
            //Precondition: None
            //Postcondition: The textbox value has been set.
            set
            {
                zipInput.Text = value.ToString();
            }
        }
        // Precondition: Button must be clicked
        // postcondition: The form will enter the data and perform its task given it has passed validation
        private void okButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }
        // Precondition: Button must be clicked
        // postcondition: form will close
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Precondition: attempting to change focus from control
        // postcondition: tested for validation
        private void nameInput_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameInput.Text))
            {
                e.Cancel = true;
                errorProviderAll.SetError(nameInput, "Enter Valid Name");
                nameInput.SelectAll();
            }
        }
        //Precondition: Something is entered
        //Postcondition: the control is validated and error is gone
        private void nameInput_Validated(object sender, EventArgs e)
        {
            errorProviderAll.SetError(nameInput, "");
            errorProviderAll.Clear();
        }
        // Precondition: attempting to change focus from control
        // postcondition: tested for validation
        private void address1Input_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(address1Input.Text))
            {
                e.Cancel = true;
                errorProviderAll.SetError(address1Input, "Enter Valid Address");
                nameInput.SelectAll();
            }
        }
        //Precondition: Something is entered
        //Postcondition: the control is validated and error is gone
        private void address1Input_Validated(object sender, EventArgs e)
        {
            errorProviderAll.SetError(address1Input, "");
            errorProviderAll.Clear();
        }
        // Precondition: attempting to change focus from control
        // postcondition: tested for validation
        private void cityInput_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cityInput.Text))
            {
                e.Cancel = true;
                errorProviderAll.SetError(cityInput, "Enter Valid City");
                nameInput.SelectAll();
            }
        }
        //Precondition: Something is entered
        //Postcondition: the control is validated and error is gone
        private void cityInput_Validated(object sender, EventArgs e)
        {
            errorProviderAll.SetError(cityInput, "");
            errorProviderAll.Clear();
        }
        // Precondition: attempting to change focus from control
        // postcondition: tested for validation
        private void stateInput_Validating(object sender, CancelEventArgs e)
        {
            if (stateInput.SelectedIndex == -1)
            {
                e.Cancel = true;
                errorProviderAll.SetError(cityInput, "Enter Valid State");
                nameInput.SelectAll();
            }
        }
        //Precondition: Something is entered
        //Postcondition: the control is validated and error is gone
        private void stateInput_Validated(object sender, EventArgs e)
        {
            errorProviderAll.SetError(stateInput, "");
            errorProviderAll.Clear();
        }
        // Precondition: attempting to change focus from control
        // postcondition: tested for validation
        private void zipInput_Validating(object sender, CancelEventArgs e)
        {
            const int zipMax = 99999;
            const int zipMin = 00000;
            int zipCodeHolder;

            if (!int.TryParse(zipInput.Text, out zipCodeHolder) || zipCodeHolder <= zipMin || zipCodeHolder >= zipMax)
            {
                e.Cancel = true;
                errorProviderAll.SetError(zipInput, "Enter Valid State");
                nameInput.SelectAll();
            }
        }
        //Precondition: Something is entered
        //Postcondition: the control is validated and error is gone
        private void zipInput_Validated(object sender, EventArgs e)
        {
            errorProviderAll.SetError(stateInput, "");
            errorProviderAll.Clear();
        }
    }
}
