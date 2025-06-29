namespace RecepcjaDlaWeterynarii
{
    partial class frmMain
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
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.btnSearchPatient = new System.Windows.Forms.Button();
            this.userControl21 = new RecepcjaDlaWeterynarii.ucSearchPatient();
            this.userControl11 = new RecepcjaDlaWeterynarii.ucAddPatient();
            this.SuspendLayout();
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.Location = new System.Drawing.Point(12, 165);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(173, 55);
            this.btnAddPatient.TabIndex = 0;
            this.btnAddPatient.Text = "Wprowadź Pacjenta";
            this.btnAddPatient.UseVisualStyleBackColor = true;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // btnSearchPatient
            // 
            this.btnSearchPatient.Location = new System.Drawing.Point(12, 226);
            this.btnSearchPatient.Name = "btnSearchPatient";
            this.btnSearchPatient.Size = new System.Drawing.Size(173, 55);
            this.btnSearchPatient.TabIndex = 1;
            this.btnSearchPatient.Text = "Wyszukaj Pacjenta";
            this.btnSearchPatient.UseVisualStyleBackColor = true;
            this.btnSearchPatient.Click += new System.EventHandler(this.btnSearchPatient_Click);
            // 
            // userControl21
            // 
            this.userControl21.Location = new System.Drawing.Point(191, 12);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(606, 489);
            this.userControl21.TabIndex = 4;
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(191, 65);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(606, 450);
            this.userControl11.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.userControl21);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.btnSearchPatient);
            this.Controls.Add(this.btnAddPatient);
            this.Name = "Form1";
            this.Text = "Recepcja";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.Button btnSearchPatient;
        private ucAddPatient userControl11;
        private RecepcjaDlaWeterynarii.ucSearchPatient userControl21;
    }
}

