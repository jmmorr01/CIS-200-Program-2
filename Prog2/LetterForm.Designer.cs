namespace Prog2
{
    partial class LetterForm
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
            this.originLabel = new System.Windows.Forms.Label();
            this.destinationLabel = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.originInput = new System.Windows.Forms.ComboBox();
            this.destinationInput = new System.Windows.Forms.ComboBox();
            this.costInput = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // originLabel
            // 
            this.originLabel.AutoSize = true;
            this.originLabel.Location = new System.Drawing.Point(19, 32);
            this.originLabel.Name = "originLabel";
            this.originLabel.Size = new System.Drawing.Size(78, 13);
            this.originLabel.TabIndex = 0;
            this.originLabel.Text = "Origin Address:";
            // 
            // destinationLabel
            // 
            this.destinationLabel.AutoSize = true;
            this.destinationLabel.Location = new System.Drawing.Point(12, 90);
            this.destinationLabel.Name = "destinationLabel";
            this.destinationLabel.Size = new System.Drawing.Size(104, 13);
            this.destinationLabel.TabIndex = 1;
            this.destinationLabel.Text = "Destination Address:";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(38, 151);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(59, 13);
            this.costLabel.TabIndex = 2;
            this.costLabel.Text = "Fixed Cost:";
            // 
            // originInput
            // 
            this.originInput.FormattingEnabled = true;
            this.originInput.Location = new System.Drawing.Point(140, 32);
            this.originInput.Name = "originInput";
            this.originInput.Size = new System.Drawing.Size(121, 21);
            this.originInput.TabIndex = 3;
            this.originInput.Validating += new System.ComponentModel.CancelEventHandler(this.originInput_Validating);
            this.originInput.Validated += new System.EventHandler(this.originInput_Validated);
            // 
            // destinationInput
            // 
            this.destinationInput.FormattingEnabled = true;
            this.destinationInput.Location = new System.Drawing.Point(140, 87);
            this.destinationInput.Name = "destinationInput";
            this.destinationInput.Size = new System.Drawing.Size(121, 21);
            this.destinationInput.TabIndex = 2;
            this.destinationInput.Validating += new System.ComponentModel.CancelEventHandler(this.destinationInput_Validating);
            this.destinationInput.Validated += new System.EventHandler(this.destinationInput_Validated);
            // 
            // costInput
            // 
            this.costInput.Location = new System.Drawing.Point(161, 148);
            this.costInput.Name = "costInput";
            this.costInput.Size = new System.Drawing.Size(100, 20);
            this.costInput.TabIndex = 1;
            this.costInput.Validating += new System.ComponentModel.CancelEventHandler(this.costInput_Validating);
            this.costInput.Validated += new System.EventHandler(this.costInput_Validated);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(41, 226);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(161, 226);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // LetterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.costInput);
            this.Controls.Add(this.destinationInput);
            this.Controls.Add(this.originInput);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.destinationLabel);
            this.Controls.Add(this.originLabel);
            this.Name = "LetterForm";
            this.Text = "Letter";
            this.Load += new System.EventHandler(this.LetterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label originLabel;
        private System.Windows.Forms.Label destinationLabel;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.ComboBox originInput;
        private System.Windows.Forms.ComboBox destinationInput;
        private System.Windows.Forms.TextBox costInput;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}