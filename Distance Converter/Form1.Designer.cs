namespace Distance_Converter
{
    partial class Form1
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
            this.grpBxConversions = new System.Windows.Forms.GroupBox();
            this.btnMilesToKilometers = new System.Windows.Forms.Button();
            this.btnYardsToMeters = new System.Windows.Forms.Button();
            this.btnFeetToMeters = new System.Windows.Forms.Button();
            this.btnInchToCent = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblEnterValue = new System.Windows.Forms.Label();
            this.txtValueToChange = new System.Windows.Forms.TextBox();
            this.lblConvertFrom = new System.Windows.Forms.Label();
            this.lblEqualsSign = new System.Windows.Forms.Label();
            this.txtConvertedResult = new System.Windows.Forms.TextBox();
            this.lblConvertedTo = new System.Windows.Forms.Label();
            this.grpBxConversions.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBxConversions
            // 
            this.grpBxConversions.Controls.Add(this.btnMilesToKilometers);
            this.grpBxConversions.Controls.Add(this.btnYardsToMeters);
            this.grpBxConversions.Controls.Add(this.btnFeetToMeters);
            this.grpBxConversions.Controls.Add(this.btnInchToCent);
            this.grpBxConversions.ForeColor = System.Drawing.Color.Blue;
            this.grpBxConversions.Location = new System.Drawing.Point(25, 92);
            this.grpBxConversions.Name = "grpBxConversions";
            this.grpBxConversions.Size = new System.Drawing.Size(194, 146);
            this.grpBxConversions.TabIndex = 0;
            this.grpBxConversions.TabStop = false;
            this.grpBxConversions.Text = "Type of conversion";
            // 
            // btnMilesToKilometers
            // 
            this.btnMilesToKilometers.ForeColor = System.Drawing.Color.Black;
            this.btnMilesToKilometers.Location = new System.Drawing.Point(7, 110);
            this.btnMilesToKilometers.Name = "btnMilesToKilometers";
            this.btnMilesToKilometers.Size = new System.Drawing.Size(181, 23);
            this.btnMilesToKilometers.TabIndex = 3;
            this.btnMilesToKilometers.Text = "&Miles to Kilometers";
            this.btnMilesToKilometers.UseVisualStyleBackColor = true;
            this.btnMilesToKilometers.Click += new System.EventHandler(this.btnMilesToKilometers_Click);
            // 
            // btnYardsToMeters
            // 
            this.btnYardsToMeters.ForeColor = System.Drawing.Color.Black;
            this.btnYardsToMeters.Location = new System.Drawing.Point(7, 80);
            this.btnYardsToMeters.Name = "btnYardsToMeters";
            this.btnYardsToMeters.Size = new System.Drawing.Size(181, 23);
            this.btnYardsToMeters.TabIndex = 2;
            this.btnYardsToMeters.Text = "&Yards to Meters";
            this.btnYardsToMeters.UseVisualStyleBackColor = true;
            this.btnYardsToMeters.Click += new System.EventHandler(this.btnYardsToMeters_Click);
            // 
            // btnFeetToMeters
            // 
            this.btnFeetToMeters.ForeColor = System.Drawing.Color.Black;
            this.btnFeetToMeters.Location = new System.Drawing.Point(7, 50);
            this.btnFeetToMeters.Name = "btnFeetToMeters";
            this.btnFeetToMeters.Size = new System.Drawing.Size(181, 23);
            this.btnFeetToMeters.TabIndex = 1;
            this.btnFeetToMeters.Text = "&Feet to Meters";
            this.btnFeetToMeters.UseVisualStyleBackColor = true;
            this.btnFeetToMeters.Click += new System.EventHandler(this.btnFeetToMeters_Click);
            // 
            // btnInchToCent
            // 
            this.btnInchToCent.ForeColor = System.Drawing.Color.Black;
            this.btnInchToCent.Location = new System.Drawing.Point(7, 20);
            this.btnInchToCent.Name = "btnInchToCent";
            this.btnInchToCent.Size = new System.Drawing.Size(181, 23);
            this.btnInchToCent.TabIndex = 0;
            this.btnInchToCent.Text = "&Inches to Centimetres";
            this.btnInchToCent.UseVisualStyleBackColor = true;
            this.btnInchToCent.Click += new System.EventHandler(this.btnInchToCent_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoEllipsis = true;
            this.btnExit.Location = new System.Drawing.Point(236, 205);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(79, 33);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblEnterValue
            // 
            this.lblEnterValue.AutoSize = true;
            this.lblEnterValue.Location = new System.Drawing.Point(25, 23);
            this.lblEnterValue.Name = "lblEnterValue";
            this.lblEnterValue.Size = new System.Drawing.Size(157, 13);
            this.lblEnterValue.TabIndex = 2;
            this.lblEnterValue.Text = "Enter the value to be converted";
            // 
            // txtValueToChange
            // 
            this.txtValueToChange.Location = new System.Drawing.Point(28, 40);
            this.txtValueToChange.Name = "txtValueToChange";
            this.txtValueToChange.Size = new System.Drawing.Size(59, 20);
            this.txtValueToChange.TabIndex = 3;
            // 
            // lblConvertFrom
            // 
            this.lblConvertFrom.AutoSize = true;
            this.lblConvertFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConvertFrom.Location = new System.Drawing.Point(94, 40);
            this.lblConvertFrom.Name = "lblConvertFrom";
            this.lblConvertFrom.Size = new System.Drawing.Size(0, 18);
            this.lblConvertFrom.TabIndex = 4;
            // 
            // lblEqualsSign
            // 
            this.lblEqualsSign.AutoSize = true;
            this.lblEqualsSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEqualsSign.Location = new System.Drawing.Point(173, 36);
            this.lblEqualsSign.Name = "lblEqualsSign";
            this.lblEqualsSign.Size = new System.Drawing.Size(0, 25);
            this.lblEqualsSign.TabIndex = 5;
            // 
            // txtConvertedResult
            // 
            this.txtConvertedResult.Location = new System.Drawing.Point(204, 40);
            this.txtConvertedResult.Name = "txtConvertedResult";
            this.txtConvertedResult.Size = new System.Drawing.Size(85, 20);
            this.txtConvertedResult.TabIndex = 6;
            this.txtConvertedResult.Visible = false;
            // 
            // lblConvertedTo
            // 
            this.lblConvertedTo.AutoSize = true;
            this.lblConvertedTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConvertedTo.Location = new System.Drawing.Point(295, 40);
            this.lblConvertedTo.Name = "lblConvertedTo";
            this.lblConvertedTo.Size = new System.Drawing.Size(0, 18);
            this.lblConvertedTo.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 250);
            this.Controls.Add(this.lblConvertedTo);
            this.Controls.Add(this.txtConvertedResult);
            this.Controls.Add(this.lblEqualsSign);
            this.Controls.Add(this.lblConvertFrom);
            this.Controls.Add(this.txtValueToChange);
            this.Controls.Add(this.lblEnterValue);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpBxConversions);
            this.Name = "Form1";
            this.Text = "Distance Converter";
            this.grpBxConversions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBxConversions;
        private System.Windows.Forms.Button btnMilesToKilometers;
        private System.Windows.Forms.Button btnYardsToMeters;
        private System.Windows.Forms.Button btnFeetToMeters;
        private System.Windows.Forms.Button btnInchToCent;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblEnterValue;
        private System.Windows.Forms.TextBox txtValueToChange;
        private System.Windows.Forms.Label lblConvertFrom;
        private System.Windows.Forms.Label lblEqualsSign;
        private System.Windows.Forms.TextBox txtConvertedResult;
        private System.Windows.Forms.Label lblConvertedTo;
    }
}

