
namespace CustomerDataEntry
{
    partial class FormCustomerDataEntry
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
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblHobbies = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.cmbCountries = new System.Windows.Forms.ComboBox();
            this.checkRead = new System.Windows.Forms.CheckBox();
            this.checkPaint = new System.Windows.Forms.CheckBox();
            this.radioSingle = new System.Windows.Forms.RadioButton();
            this.radioMarried = new System.Windows.Forms.RadioButton();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.checkMale = new System.Windows.Forms.CheckBox();
            this.checkFemale = new System.Windows.Forms.CheckBox();
            this.dtgCustomer = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(59, 63);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(133, 20);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Customer Name:-";
            this.lblCustomerName.Click += new System.EventHandler(this.lblCustomerName_Click);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(372, 57);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(126, 26);
            this.txtCustomerName.TabIndex = 1;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(59, 115);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(85, 20);
            this.lblCountry.TabIndex = 2;
            this.lblCountry.Text = "Country   :-";
            this.lblCountry.Click += new System.EventHandler(this.Country_Click);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(59, 158);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(80, 20);
            this.lblGender.TabIndex = 3;
            this.lblGender.Text = "Gender  :-";
            this.lblGender.Click += new System.EventHandler(this.Gender_Click);
            // 
            // lblHobbies
            // 
            this.lblHobbies.AutoSize = true;
            this.lblHobbies.Location = new System.Drawing.Point(59, 209);
            this.lblHobbies.Name = "lblHobbies";
            this.lblHobbies.Size = new System.Drawing.Size(85, 20);
            this.lblHobbies.TabIndex = 4;
            this.lblHobbies.Text = "Hobbies  :-";
            this.lblHobbies.Click += new System.EventHandler(this.Hobbies_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(59, 261);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(73, 20);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Status  :-";
            this.lblStatus.Click += new System.EventHandler(this.Status_Click);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(59, 312);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(89, 20);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Adderss   :-";
            this.lblAddress.Click += new System.EventHandler(this.Address_Click);
            // 
            // cmbCountries
            // 
            this.cmbCountries.FormattingEnabled = true;
            this.cmbCountries.Items.AddRange(new object[] {
            "Afghanistan|Afghanistan",
            "Albania|Albania",
            "Algeria|Algeria",
            "Andorra|Andorra",
            "Angola|Angola",
            "Antigua and Barbuda|Antigua and Barbuda",
            "Argentina|Argentina",
            "Armenia|Armenia",
            "Aruba|Aruba",
            "Australia|Australia",
            "Austria|Austria",
            "Azerbaijan|Azerbaijan",
            "Bahamas, The|Bahamas, The",
            "Bahrain|Bahrain",
            "Bangladesh|Bangladesh",
            "Barbados|Barbados",
            "Belarus|Belarus",
            "Belgium|Belgium",
            "Belize|Belize",
            "Benin|Benin",
            "Bhutan|Bhutan",
            "Bolivia|Bolivia",
            "Bosnia and Herzegovina|Bosnia and Herzegovina",
            "Botswana|Botswana",
            "Brazil|Brazil",
            "Brunei|Brunei",
            "Bulgaria|Bulgaria",
            "Burkina Faso|Burkina Faso",
            "Burma|Burma",
            "Burundi|Burundi",
            "Cambodia|Cambodia",
            "Cameroon|Cameroon",
            "Canada|Canada",
            "Cape Verde|Cape Verde",
            "Central African Republic|Central African Republic",
            "Chad|Chad",
            "Chile|Chile",
            "China|China",
            "Colombia|Colombia",
            "Comoros|Comoros",
            "Congo, Democratic Republic of the|Congo, Democratic Republic of the",
            "Congo, Republic of the|Congo, Republic of the",
            "Costa Rica|Costa Rica",
            "Cote d\'Ivoire|Cote d\'Ivoire",
            "Croatia|Croatia",
            "Cuba|Cuba",
            "Curacao|Curacao",
            "Cyprus|Cyprus",
            "Czech Republic|Czech Republic",
            "Denmark|Denmark",
            "Djibouti|Djibouti",
            "Dominica|Dominica",
            "Dominican Republic|Dominican Republic",
            "East Timor (see Timor-Leste)|East Timor (see Timor-Leste)",
            "Ecuador|Ecuador",
            "Egypt|Egypt",
            "El Salvador|El Salvador",
            "Equatorial Guinea|Equatorial Guinea",
            "Eritrea|Eritrea",
            "Estonia|Estonia",
            "Ethiopia|Ethiopia",
            "Fiji|Fiji",
            "Finland|Finland",
            "France|France",
            "Gabon|Gabon",
            "Gambia, The|Gambia, The",
            "Georgia|Georgia",
            "Germany|Germany",
            "Ghana|Ghana",
            "Greece|Greece",
            "Grenada|Grenada",
            "Guatemala|Guatemala",
            "Guinea|Guinea",
            "Guinea-Bissau|Guinea-Bissau",
            "Guyana|Guyana",
            "Haiti|Haiti",
            "Holy See|Holy See",
            "Honduras|Honduras",
            "Hong Kong|Hong Kong",
            "Hungary|Hungary",
            "Iceland|Iceland",
            "India|India",
            "Indonesia|Indonesia",
            "Iran|Iran",
            "Iraq|Iraq",
            "Ireland|Ireland",
            "Israel|Israel",
            "Italy|Italy",
            "Jamaica|Jamaica",
            "Japan|Japan",
            "Jordan|Jordan",
            "Kazakhstan|Kazakhstan",
            "Kenya|Kenya",
            "Kiribati|Kiribati",
            "Korea, North|Korea, North",
            "Korea, South|Korea, South",
            "Kosovo|Kosovo",
            "Kuwait|Kuwait",
            "Kyrgyzstan|Kyrgyzstan",
            "Laos|Laos",
            "Latvia|Latvia",
            "Lebanon|Lebanon",
            "Lesotho|Lesotho",
            "Liberia|Liberia",
            "Libya|Libya",
            "Liechtenstein|Liechtenstein",
            "Lithuania|Lithuania",
            "Luxembourg|Luxembourg",
            "Macau|Macau",
            "Macedonia|Macedonia",
            "Madagascar|Madagascar",
            "Malawi|Malawi",
            "Malaysia|Malaysia",
            "Maldives|Maldives",
            "Mali|Mali",
            "Malta|Malta",
            "Marshall Islands|Marshall Islands",
            "Mauritania|Mauritania",
            "Mauritius|Mauritius",
            "Mexico|Mexico",
            "Micronesia|Micronesia",
            "Moldova|Moldova",
            "Monaco|Monaco",
            "Mongolia|Mongolia",
            "Montenegro|Montenegro",
            "Morocco|Morocco",
            "Mozambique|Mozambique",
            "Namibia|Namibia",
            "Nauru|Nauru",
            "Nepal|Nepal",
            "Netherlands|Netherlands",
            "Netherlands Antilles|Netherlands Antilles",
            "New Zealand|New Zealand",
            "Nicaragua|Nicaragua",
            "Niger|Niger",
            "Nigeria|Nigeria",
            "North Korea|North Korea",
            "Norway|Norway",
            "Oman|Oman",
            "Pakistan|Pakistan",
            "Palau|Palau",
            "Palestinian Territories|Palestinian Territories",
            "Panama|Panama",
            "Papua New Guinea|Papua New Guinea",
            "Paraguay|Paraguay",
            "Peru|Peru",
            "Philippines|Philippines",
            "Poland|Poland",
            "Portugal|Portugal",
            "Qatar|Qatar",
            "Romania|Romania",
            "Russia|Russia",
            "Rwanda|Rwanda",
            "Saint Kitts and Nevis|Saint Kitts and Nevis",
            "Saint Lucia|Saint Lucia",
            "Saint Vincent and the Grenadines|Saint Vincent and the Grenadines",
            "Samoa|Samoa",
            "San Marino|San Marino",
            "Sao Tome and Principe|Sao Tome and Principe",
            "Saudi Arabia|Saudi Arabia",
            "Senegal|Senegal",
            "Serbia|Serbia",
            "Seychelles|Seychelles",
            "Sierra Leone|Sierra Leone",
            "Singapore|Singapore",
            "Sint Maarten|Sint Maarten",
            "Slovakia|Slovakia",
            "Slovenia|Slovenia",
            "Solomon Islands|Solomon Islands",
            "Somalia|Somalia",
            "South Africa|South Africa",
            "South Korea|South Korea",
            "South Sudan|South Sudan",
            "Spain|Spain",
            "Sri Lanka|Sri Lanka",
            "Sudan|Sudan",
            "Suriname|Suriname",
            "Swaziland|Swaziland",
            "Sweden|Sweden",
            "Switzerland|Switzerland",
            "Syria|Syria",
            "Taiwan|Taiwan",
            "Tajikistan|Tajikistan",
            "Tanzania|Tanzania",
            "Thailand|Thailand",
            "Timor-Leste|Timor-Leste",
            "Togo|Togo",
            "Tonga|Tonga",
            "Trinidad and Tobago|Trinidad and Tobago",
            "Tunisia|Tunisia",
            "Turkey|Turkey",
            "Turkmenistan|Turkmenistan",
            "Tuvalu|Tuvalu",
            "Uganda|Uganda",
            "Ukraine|Ukraine",
            "United Arab Emirates|United Arab Emirates",
            "United Kingdom|United Kingdom",
            "Uruguay|Uruguay",
            "Uzbekistan|Uzbekistan",
            "Vanuatu|Vanuatu",
            "Venezuela|Venezuela",
            "Vietnam|Vietnam",
            "Yemen|Yemen",
            "Zambia|Zambia",
            "Zimbabwe|Zimbabwe"});
            this.cmbCountries.Location = new System.Drawing.Point(372, 107);
            this.cmbCountries.Name = "cmbCountries";
            this.cmbCountries.Size = new System.Drawing.Size(121, 28);
            this.cmbCountries.TabIndex = 7;
            this.cmbCountries.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // checkRead
            // 
            this.checkRead.AutoSize = true;
            this.checkRead.Location = new System.Drawing.Point(372, 204);
            this.checkRead.Name = "checkRead";
            this.checkRead.Size = new System.Drawing.Size(95, 24);
            this.checkRead.TabIndex = 10;
            this.checkRead.Text = "Reading";
            this.checkRead.UseVisualStyleBackColor = true;
            // 
            // checkPaint
            // 
            this.checkPaint.AutoSize = true;
            this.checkPaint.Location = new System.Drawing.Point(478, 204);
            this.checkPaint.Name = "checkPaint";
            this.checkPaint.Size = new System.Drawing.Size(92, 24);
            this.checkPaint.TabIndex = 11;
            this.checkPaint.Text = "Painting";
            this.checkPaint.UseVisualStyleBackColor = true;
            // 
            // radioSingle
            // 
            this.radioSingle.AutoSize = true;
            this.radioSingle.Location = new System.Drawing.Point(478, 257);
            this.radioSingle.Name = "radioSingle";
            this.radioSingle.Size = new System.Drawing.Size(78, 24);
            this.radioSingle.TabIndex = 13;
            this.radioSingle.TabStop = true;
            this.radioSingle.Text = "Single";
            this.radioSingle.UseVisualStyleBackColor = true;
            // 
            // radioMarried
            // 
            this.radioMarried.AutoSize = true;
            this.radioMarried.Location = new System.Drawing.Point(372, 257);
            this.radioMarried.Name = "radioMarried";
            this.radioMarried.Size = new System.Drawing.Size(87, 24);
            this.radioMarried.TabIndex = 12;
            this.radioMarried.TabStop = true;
            this.radioMarried.Text = "Married";
            this.radioMarried.UseVisualStyleBackColor = true;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.SystemColors.Window;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtAddress.Location = new System.Drawing.Point(372, 306);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(126, 26);
            this.txtAddress.TabIndex = 14;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(63, 384);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 39);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.butPreview_Click);
            // 
            // checkMale
            // 
            this.checkMale.AutoSize = true;
            this.checkMale.Location = new System.Drawing.Point(372, 153);
            this.checkMale.Name = "checkMale";
            this.checkMale.Size = new System.Drawing.Size(69, 24);
            this.checkMale.TabIndex = 18;
            this.checkMale.Text = "Male";
            this.checkMale.UseVisualStyleBackColor = true;
            // 
            // checkFemale
            // 
            this.checkFemale.AutoSize = true;
            this.checkFemale.Location = new System.Drawing.Point(478, 153);
            this.checkFemale.Name = "checkFemale";
            this.checkFemale.Size = new System.Drawing.Size(88, 24);
            this.checkFemale.TabIndex = 19;
            this.checkFemale.Text = "Female";
            this.checkFemale.UseVisualStyleBackColor = true;
            // 
            // dtgCustomer
            // 
            this.dtgCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCustomer.Location = new System.Drawing.Point(684, 50);
            this.dtgCustomer.Name = "dtgCustomer";
            this.dtgCustomer.RowHeadersWidth = 62;
            this.dtgCustomer.RowTemplate.Height = 28;
            this.dtgCustomer.Size = new System.Drawing.Size(467, 373);
            this.dtgCustomer.TabIndex = 20;
            this.dtgCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCustomer_CellClick);
            this.dtgCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCustomer_CellContentClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(367, 384);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(126, 39);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(212, 384);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(126, 39);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // FormCustomerDataEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 466);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dtgCustomer);
            this.Controls.Add(this.checkFemale);
            this.Controls.Add(this.checkMale);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.radioSingle);
            this.Controls.Add(this.radioMarried);
            this.Controls.Add(this.checkPaint);
            this.Controls.Add(this.checkRead);
            this.Controls.Add(this.cmbCountries);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblHobbies);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblCustomerName);
            this.Name = "FormCustomerDataEntry";
            this.Text = "CustomerDataEntry";
            this.Load += new System.EventHandler(this.FormCustomerDataEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblHobbies;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.ComboBox cmbCountries;
        private System.Windows.Forms.CheckBox checkRead;
        private System.Windows.Forms.CheckBox checkPaint;
        private System.Windows.Forms.RadioButton radioSingle;
        private System.Windows.Forms.RadioButton radioMarried;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckBox checkMale;
        private System.Windows.Forms.CheckBox checkFemale;
        private System.Windows.Forms.DataGridView dtgCustomer;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
    }
}

