namespace TicketApplicationSystem
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTicketApplication = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblDistance = new System.Windows.Forms.Label();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // Form1
            this.Text = "Ticketing System";
            this.Size = new System.Drawing.Size(480, 500);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);

            // lblTitle
            this.lblTitle.Text = "Ticketing System";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Height = 50;
            this.lblTitle.BackColor = System.Drawing.Color.LightSteelBlue;

            // lblTicketApplication
            this.lblTicketApplication.Text = "TICKET APPLICATION";
            this.lblTicketApplication.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTicketApplication.Location = new System.Drawing.Point(30, 70);
            this.lblTicketApplication.Size = new System.Drawing.Size(400, 25);
            this.lblTicketApplication.ForeColor = System.Drawing.Color.Navy;

            // lblName
            this.lblName.Text = "Name";
            this.lblName.Location = new System.Drawing.Point(30, 110);
            this.lblName.Size = new System.Drawing.Size(100, 25);

            // txtName
            this.txtName.Location = new System.Drawing.Point(150, 108);
            this.txtName.Size = new System.Drawing.Size(250, 25);
            this.txtName.Name = "txtName";

            // lblGender
            this.lblGender.Text = "Gender";
            this.lblGender.Location = new System.Drawing.Point(30, 150);
            this.lblGender.Size = new System.Drawing.Size(100, 25);

            // rbtnMale
            this.rbtnMale.Text = "MALE";
            this.rbtnMale.Location = new System.Drawing.Point(150, 148);
            this.rbtnMale.Size = new System.Drawing.Size(80, 25);
            this.rbtnMale.Name = "rbtnMale";

            // rbtnFemale
            this.rbtnFemale.Text = "FEMALE";
            this.rbtnFemale.Location = new System.Drawing.Point(240, 148);
            this.rbtnFemale.Size = new System.Drawing.Size(90, 25);
            this.rbtnFemale.Name = "rbtnFemale";

            // lblAge
            this.lblAge.Text = "Age";
            this.lblAge.Location = new System.Drawing.Point(30, 190);
            this.lblAge.Size = new System.Drawing.Size(100, 25);

            // txtAge
            this.txtAge.Location = new System.Drawing.Point(150, 188);
            this.txtAge.Size = new System.Drawing.Size(100, 25);
            this.txtAge.Name = "txtAge";

            // lblCategory
            this.lblCategory.Text = "Category";
            this.lblCategory.Location = new System.Drawing.Point(30, 230);
            this.lblCategory.Size = new System.Drawing.Size(100, 25);

            // cboCategory
            this.cboCategory.Location = new System.Drawing.Point(150, 228);
            this.cboCategory.Size = new System.Drawing.Size(150, 25);
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Items.AddRange(new object[] { "Category One", "Category Two", "Category Three" });

            // lblDistance
            this.lblDistance.Text = "Distance";
            this.lblDistance.Location = new System.Drawing.Point(30, 270);
            this.lblDistance.Size = new System.Drawing.Size(100, 25);

            // txtDistance
            this.txtDistance.Location = new System.Drawing.Point(150, 268);
            this.txtDistance.Size = new System.Drawing.Size(100, 25);
            this.txtDistance.Name = "txtDistance";

            // btnCalculate
            this.btnCalculate.Text = "CALCULATE";
            this.btnCalculate.Location = new System.Drawing.Point(60, 330);
            this.btnCalculate.Size = new System.Drawing.Size(100, 35);
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);

            // btnClear
            this.btnClear.Text = "CLEAR";
            this.btnClear.Location = new System.Drawing.Point(190, 330);
            this.btnClear.Size = new System.Drawing.Size(100, 35);
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Name = "btnClear";
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);

            // btnExit
            this.btnExit.Text = "EXIT";
            this.btnExit.Location = new System.Drawing.Point(320, 330);
            this.btnExit.Size = new System.Drawing.Size(100, 35);
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Name = "btnExit";
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);

            // Add controls to form
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblTicketApplication);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.rbtnMale);
            this.Controls.Add(this.rbtnFemale);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.txtDistance);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // Control declarations 
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTicketApplication;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}