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
using UPVApp;

namespace Prog2
{
    public partial class LetterForm : Form
    {
        UserParcelView upvList;

        public LetterForm(UserParcelView upv)
        {
            upvList = upv;
            InitializeComponent();            
        }
               
        ErrorProvider errorproviderAll = new ErrorProvider();// Error provider for validation

        
        public string OriginAddress
        {
            //Precondition: none
            //Postcondition: Returns text of origin address
            get
            {
                return originInput.Text;
            }
        }

        public string DestinationAddress
        {
            //Precondition: none
            //Postcondition: Returns text of destination address
            get
            {
                return destinationInput.Text;
            }
        }

        public decimal FixedCost
        {
            //Precondition: none
            //Postcondition: Returns text of fixed cost
            get
            {
                return System.Convert.ToDecimal(costInput.Text);
            }
            //Precondition: Must be able to convert value
            //Postcondition: Value of the fixed cost is stored
            set
            {
                costInput.Text = System.Convert.ToString(value);
            }
        }
        // Precondition: attempting to change focus from control
        // postcondition: tested for validation
        private void originInput_Validating(object sender, CancelEventArgs e)
        {
            if (originInput.Text == destinationInput.Text)
            {
                e.Cancel = true;
                errorproviderAll.SetError(originInput, "The Origin Address and Destination Address can not be the same");
            }
            else if (originInput.SelectedIndex == -1)
            {
                e.Cancel = true;
                errorproviderAll.SetError(originInput, "Please select a valid Address");
            }
        }
        //Precondition: Something is entered
        //Postcondition: the control is validated and error is gone
        private void originInput_Validated(object sender, EventArgs e)
        {
            errorproviderAll.SetError(originInput, "");
            errorproviderAll.Clear();
        }
        // Precondition: attempting to change focus from control
        // postcondition: tested for validation
        private void destinationInput_Validating(object sender, CancelEventArgs e)
        {
            if (destinationInput.Text == originInput.Text)
            {
                e.Cancel = true;
                errorproviderAll.SetError(destinationInput, "The Origin Address and Destination Address can not be the same");
            }
            else if (destinationInput.SelectedIndex == -1)
            {
                e.Cancel = true;
                errorproviderAll.SetError(destinationInput, "Please select a valid Address");
            }
        }
        //Precondition: Something is entered
        //Postcondition: the control is validated and error is gone
        private void destinationInput_Validated(object sender, EventArgs e)
        {
            errorproviderAll.SetError(destinationInput, "");
            errorproviderAll.Clear();
        }
        // Precondition: attempting to change focus from control
        // postcondition: tested for validation
        private void costInput_Validating(object sender, CancelEventArgs e)
        {
            int fixCostHolder;

            if (!int.TryParse(costInput.Text, out fixCostHolder) || fixCostHolder < 0)
            {
                e.Cancel = true;
                errorproviderAll.SetError(costInput, "Please enter a valid fixed cost");
            }
        }
        //Precondition: Something is entered
        //Postcondition: the control is validated and error is gone
        private void costInput_Validated(object sender, EventArgs e)
        {
            errorproviderAll.SetError(costInput, "");
            errorproviderAll.Clear();
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

        private void LetterForm_Load(object sender, EventArgs e)
        {

            for (int n = 0; n < upvList.AddressCount; n++)
            {
                originInput.Items.Add(upvList.AddressAt(n));
                destinationInput.Items.Add(upvList.AddressAt(n));
            }


            
        }
    }
}
