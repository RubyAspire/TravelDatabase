namespace TravelDatabase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblDowntownT = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHolidayNo = new System.Windows.Forms.TextBox();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtDepartureDate = new System.Windows.Forms.TextBox();
            this.txtNoOfDays = new System.Windows.Forms.TextBox();
            this.chkAvailable = new System.Windows.Forms.CheckBox();
            this.txtRecordCount = new System.Windows.Forms.TextBox();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.picBoxBar = new System.Windows.Forms.PictureBox();
            this.picBoxRome = new System.Windows.Forms.PictureBox();
            this.picBoxTokyo = new System.Windows.Forms.PictureBox();
            this.picBoxParis = new System.Windows.Forms.PictureBox();
            this.picBoxDubai = new System.Windows.Forms.PictureBox();
            this.printPrvDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.dataGVHoliday = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTokyo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxParis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDubai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVHoliday)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDowntownT
            // 
            this.lblDowntownT.AutoSize = true;
            this.lblDowntownT.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDowntownT.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblDowntownT.Location = new System.Drawing.Point(270, 43);
            this.lblDowntownT.Name = "lblDowntownT";
            this.lblDowntownT.Size = new System.Drawing.Size(231, 38);
            this.lblDowntownT.TabIndex = 0;
            this.lblDowntownT.Text = "Downtown Travel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Holiday Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Destination";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Cost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Departure Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(148, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "No Of days";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(148, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Available";
            // 
            // txtHolidayNo
            // 
            this.txtHolidayNo.Location = new System.Drawing.Point(277, 108);
            this.txtHolidayNo.Name = "txtHolidayNo";
            this.txtHolidayNo.Size = new System.Drawing.Size(127, 20);
            this.txtHolidayNo.TabIndex = 1;
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(277, 137);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(156, 20);
            this.txtDestination.TabIndex = 2;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(277, 168);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(72, 20);
            this.txtCost.TabIndex = 3;
            this.txtCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDepartureDate
            // 
            this.txtDepartureDate.Location = new System.Drawing.Point(277, 197);
            this.txtDepartureDate.Name = "txtDepartureDate";
            this.txtDepartureDate.Size = new System.Drawing.Size(72, 20);
            this.txtDepartureDate.TabIndex = 4;
            // 
            // txtNoOfDays
            // 
            this.txtNoOfDays.Location = new System.Drawing.Point(277, 229);
            this.txtNoOfDays.Name = "txtNoOfDays";
            this.txtNoOfDays.Size = new System.Drawing.Size(45, 20);
            this.txtNoOfDays.TabIndex = 5;
            // 
            // chkAvailable
            // 
            this.chkAvailable.AutoSize = true;
            this.chkAvailable.Location = new System.Drawing.Point(277, 262);
            this.chkAvailable.Name = "chkAvailable";
            this.chkAvailable.Size = new System.Drawing.Size(15, 14);
            this.chkAvailable.TabIndex = 6;
            this.chkAvailable.UseVisualStyleBackColor = true;
            // 
            // txtRecordCount
            // 
            this.txtRecordCount.Location = new System.Drawing.Point(312, 362);
            this.txtRecordCount.Name = "txtRecordCount";
            this.txtRecordCount.Size = new System.Drawing.Size(77, 20);
            this.txtRecordCount.TabIndex = 9;
            this.txtRecordCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnFirst
            // 
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFirst.Location = new System.Drawing.Point(142, 353);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(79, 37);
            this.btnFirst.TabIndex = 7;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrev.Location = new System.Drawing.Point(227, 353);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(79, 37);
            this.btnPrev.TabIndex = 8;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Location = new System.Drawing.Point(395, 353);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(79, 37);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLast.Location = new System.Drawing.Point(480, 353);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(79, 37);
            this.btnLast.TabIndex = 11;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Location = new System.Drawing.Point(587, 99);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(89, 43);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Location = new System.Drawing.Point(587, 148);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 43);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Location = new System.Drawing.Point(587, 197);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 43);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrint.Location = new System.Drawing.Point(587, 247);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(89, 43);
            this.btnPrint.TabIndex = 15;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Location = new System.Drawing.Point(587, 298);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 43);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Location = new System.Drawing.Point(587, 347);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 43);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // picBoxBar
            // 
            this.picBoxBar.Image = global::TravelDatabase.Properties.Resources.barc;
            this.picBoxBar.Location = new System.Drawing.Point(576, 24);
            this.picBoxBar.Name = "picBoxBar";
            this.picBoxBar.Size = new System.Drawing.Size(100, 69);
            this.picBoxBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxBar.TabIndex = 6;
            this.picBoxBar.TabStop = false;
            // 
            // picBoxRome
            // 
            this.picBoxRome.Image = global::TravelDatabase.Properties.Resources.Rome;
            this.picBoxRome.Location = new System.Drawing.Point(576, 24);
            this.picBoxRome.Name = "picBoxRome";
            this.picBoxRome.Size = new System.Drawing.Size(100, 69);
            this.picBoxRome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxRome.TabIndex = 7;
            this.picBoxRome.TabStop = false;
            // 
            // picBoxTokyo
            // 
            this.picBoxTokyo.Image = global::TravelDatabase.Properties.Resources.tokyo;
            this.picBoxTokyo.Location = new System.Drawing.Point(576, 24);
            this.picBoxTokyo.Name = "picBoxTokyo";
            this.picBoxTokyo.Size = new System.Drawing.Size(100, 69);
            this.picBoxTokyo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxTokyo.TabIndex = 8;
            this.picBoxTokyo.TabStop = false;
            // 
            // picBoxParis
            // 
            this.picBoxParis.Image = global::TravelDatabase.Properties.Resources.Paris;
            this.picBoxParis.Location = new System.Drawing.Point(576, 24);
            this.picBoxParis.Name = "picBoxParis";
            this.picBoxParis.Size = new System.Drawing.Size(100, 69);
            this.picBoxParis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxParis.TabIndex = 9;
            this.picBoxParis.TabStop = false;
            // 
            // picBoxDubai
            // 
            this.picBoxDubai.Image = global::TravelDatabase.Properties.Resources.Dubai;
            this.picBoxDubai.Location = new System.Drawing.Point(576, 24);
            this.picBoxDubai.Name = "picBoxDubai";
            this.picBoxDubai.Size = new System.Drawing.Size(100, 69);
            this.picBoxDubai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxDubai.TabIndex = 10;
            this.picBoxDubai.TabStop = false;
            // 
            // printPrvDialog1
            // 
            this.printPrvDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPrvDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPrvDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPrvDialog1.Enabled = true;
            this.printPrvDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPrvDialog1.Icon")));
            this.printPrvDialog1.Name = "printPrvDialog1";
            this.printPrvDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // dataGVHoliday
            // 
            this.dataGVHoliday.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGVHoliday.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGVHoliday.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVHoliday.Location = new System.Drawing.Point(48, 445);
            this.dataGVHoliday.Name = "dataGVHoliday";
            this.dataGVHoliday.RowHeadersVisible = false;
            this.dataGVHoliday.Size = new System.Drawing.Size(670, 460);
            this.dataGVHoliday.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(724, 425);
            this.Controls.Add(this.dataGVHoliday);
            this.Controls.Add(this.picBoxDubai);
            this.Controls.Add(this.picBoxParis);
            this.Controls.Add(this.picBoxTokyo);
            this.Controls.Add(this.picBoxRome);
            this.Controls.Add(this.picBoxBar);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.txtRecordCount);
            this.Controls.Add(this.chkAvailable);
            this.Controls.Add(this.txtNoOfDays);
            this.Controls.Add(this.txtDepartureDate);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.txtHolidayNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDowntownT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTokyo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxParis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDubai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVHoliday)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDowntownT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHolidayNo;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtDepartureDate;
        private System.Windows.Forms.TextBox txtNoOfDays;
        private System.Windows.Forms.CheckBox chkAvailable;
        private System.Windows.Forms.TextBox txtRecordCount;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox picBoxBar;
        private System.Windows.Forms.PictureBox picBoxRome;
        private System.Windows.Forms.PictureBox picBoxTokyo;
        private System.Windows.Forms.PictureBox picBoxParis;
        private System.Windows.Forms.PictureBox picBoxDubai;
        private System.Windows.Forms.PrintPreviewDialog printPrvDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DataGridView dataGVHoliday;
    }
}

