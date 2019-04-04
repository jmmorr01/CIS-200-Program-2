namespace Prog2
{
    partial class AddressForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameLabel = new System.Windows.Forms.Label();
            this.address1Label = new System.Windows.Forms.Label();
            this.address2Label = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.zipLabel = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.address1Input = new System.Windows.Forms.TextBox();
            this.address2Input = new System.Windows.Forms.TextBox();
            this.cityInput = new System.Windows.Forms.TextBox();
            this.zipInput = new System.Windows.Forms.TextBox();
            this.stateInput = new System.Windows.Forms.ComboBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(31, 19);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // address1Label
            // 
            this.address1Label.AutoSize = true;
            this.address1Label.Location = new System.Drawing.Point(14, 52);
            this.address1Label.Name = "address1Label";
            this.address1Label.Size = new System.Drawing.Size(57, 13);
            this.address1Label.TabIndex = 1;
            this.address1Label.Text = "Address 1:";
            // 
            // address2Label
            // 
            this.address2Label.AutoSize = true;
            this.address2Label.Location = new System.Drawing.Point(14, 89);
            this.address2Label.Name = "address2Label";
            this.address2Label.Size = new System.Drawing.Size(57, 13);
            this.address2Label.TabIndex = 2;
            this.address2Label.Text = "Address 2:";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(42, 132);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(27, 13);
            this.cityLabel.TabIndex = 3;
            this.cityLabel.Text = "City:";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(34, 172);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(35, 13);
            this.stateLabel.TabIndex = 4;
            this.stateLabel.Text = "State:";
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Location = new System.Drawing.Point(44, 204);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(25, 13);
            this.zipLabel.TabIndex = 5;
            this.zipLabel.Text = "Zip:";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(156, 12);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(100, 20);
            this.nameInput.TabIndex = 6;
            this.nameInput.Validating += new System.ComponentModel.CancelEventHandler(this.nameInput_Validating);
            this.nameInput.Validated += new System.EventHandler(this.nameInput_Validated);
            // 
            // address1Input
            // 
            this.address1Input.Location = new System.Drawing.Point(156, 45);
            this.address1Input.Name = "address1Input";
            this.address1Input.Size = new System.Drawing.Size(100, 20);
            this.address1Input.TabIndex = 7;
            this.address1Input.Validating += new System.ComponentModel.CancelEventHandler(this.address1Input_Validating);
            this.address1Input.Validated += new System.EventHandler(this.address1Input_Validated);
            // 
            // address2Input
            // 
            this.address2Input.Location = new System.Drawing.Point(156, 82);
            this.address2Input.Name = "address2Input";
            this.address2Input.Size = new System.Drawing.Size(100, 20);
            this.address2Input.TabIndex = 8;
            // 
            // cityInput
            // 
            this.cityInput.Location = new System.Drawing.Point(156, 125);
            this.cityInput.Name = "cityInput";
            this.cityInput.Size = new System.Drawing.Size(100, 20);
            this.cityInput.TabIndex = 9;
            this.cityInput.Validating += new System.ComponentModel.CancelEventHandler(this.cityInput_Validating);
            this.cityInput.Validated += new System.EventHandler(this.cityInput_Validated);
            // 
            // zipInput
            // 
            this.zipInput.Location = new System.Drawing.Point(156, 197);
            this.zipInput.Name = "zipInput";
            this.zipInput.Size = new System.Drawing.Size(100, 20);
            this.zipInput.TabIndex = 10;
            this.zipInput.Validating += new System.ComponentModel.CancelEventHandler(this.zipInput_Validating);
            this.zipInput.Validated += new System.EventHandler(this.zipInput_Validated);
            // 
            // stateInput
            // 
            this.stateInput.FormattingEnabled = true;
            this.stateInput.Items.AddRange(new object[] {
            "KY",
            "WA",
            "NY",
            "TN"});
            this.stateInput.Location = new System.Drawing.Point(135, 164);
            this.stateInput.Name = "stateInput";
            this.stateInput.Size = new System.Drawing.Size(121, 21);
            this.stateInput.TabIndex = 11;
            this.stateInput.Validating += new System.ComponentModel.CancelEventHandler(this.stateInput_Validating);
            this.stateInput.Validated += new System.EventHandler(this.stateInput_Validated);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(47, 255);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 12;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(181, 255);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // AddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 290);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.stateInput);
            this.Controls.Add(this.zipInput);
            this.Controls.Add(this.cityInput);
            this.Controls.Add(this.address2Input);
            this.Controls.Add(this.address1Input);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.zipLabel);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.address2Label);
            this.Controls.Add(this.address1Label);
            this.Controls.Add(this.nameLabel);
            this.Name = "AddressForm";
            this.Text = "Address";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label address1Label;
        private System.Windows.Forms.Label address2Label;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TextBox address1Input;
        private System.Windows.Forms.TextBox address2Input;
        private System.Windows.Forms.TextBox cityInput;
        private System.Windows.Forms.TextBox zipInput;
        private System.Windows.Forms.ComboBox stateInput;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}