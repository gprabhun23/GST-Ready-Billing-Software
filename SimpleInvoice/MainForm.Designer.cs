/*
 * Created by SharpDevelop.
 * User: Ganesh
 * Date: 7/2/2017
 * Time: 5:14 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SimpleInvoice
{
	partial class SimpleInvoice
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox tbPartyName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox tbPartyAddress;
		private System.Windows.Forms.TextBox tbInvoiceNo;
		private System.Windows.Forms.TextBox tbGSTno;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ComboBox cbGSTpercent;
		private System.Windows.Forms.ComboBox cbUnit;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox tbAmount;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox tbQty;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox tbPrice;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox tbItemName;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.ComboBox cbInterstate;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.DateTimePicker dtpInvoiceDate;
		private System.Windows.Forms.Button btnMinimize;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.button9 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.tbPartyName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.tbPartyAddress = new System.Windows.Forms.TextBox();
			this.tbInvoiceNo = new System.Windows.Forms.TextBox();
			this.tbGSTno = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label9 = new System.Windows.Forms.Label();
			this.cbInterstate = new System.Windows.Forms.ComboBox();
			this.cbGSTpercent = new System.Windows.Forms.ComboBox();
			this.label14 = new System.Windows.Forms.Label();
			this.cbUnit = new System.Windows.Forms.ComboBox();
			this.label11 = new System.Windows.Forms.Label();
			this.tbAmount = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.tbQty = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.tbPrice = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.tbItemName = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.btnMinimize = new System.Windows.Forms.Button();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.dtpInvoiceDate = new System.Windows.Forms.DateTimePicker();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel6.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
			this.panel1.Controls.Add(this.button9);
			this.panel1.Controls.Add(this.button8);
			this.panel1.Controls.Add(this.button7);
			this.panel1.Controls.Add(this.button6);
			this.panel1.Controls.Add(this.button5);
			this.panel1.Controls.Add(this.btnAdd);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(151, 734);
			this.panel1.TabIndex = 0;
			// 
			// button9
			// 
			this.button9.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button9.ForeColor = System.Drawing.Color.Beige;
			this.button9.Location = new System.Drawing.Point(4, 531);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(144, 38);
			this.button9.TabIndex = 5;
			this.button9.Text = "EXIT";
			this.button9.UseVisualStyleBackColor = false;
			// 
			// button8
			// 
			this.button8.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button8.ForeColor = System.Drawing.Color.Beige;
			this.button8.Location = new System.Drawing.Point(4, 487);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(144, 38);
			this.button8.TabIndex = 4;
			this.button8.Text = "CANCEL";
			this.button8.UseVisualStyleBackColor = false;
			// 
			// button7
			// 
			this.button7.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button7.ForeColor = System.Drawing.Color.Beige;
			this.button7.Location = new System.Drawing.Point(4, 443);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(144, 38);
			this.button7.TabIndex = 3;
			this.button7.Text = "SAVE";
			this.button7.UseVisualStyleBackColor = false;
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button6.ForeColor = System.Drawing.Color.Beige;
			this.button6.Location = new System.Drawing.Point(4, 399);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(144, 38);
			this.button6.TabIndex = 2;
			this.button6.Text = "BROWSE";
			this.button6.UseVisualStyleBackColor = false;
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.ForeColor = System.Drawing.Color.Beige;
			this.button5.Location = new System.Drawing.Point(4, 355);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(144, 38);
			this.button5.TabIndex = 1;
			this.button5.Text = "ADD ITEMS";
			this.button5.UseVisualStyleBackColor = false;
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.ForeColor = System.Drawing.Color.Beige;
			this.btnAdd.Location = new System.Drawing.Point(4, 311);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(144, 38);
			this.btnAdd.TabIndex = 0;
			this.btnAdd.Text = "ADD";
			this.btnAdd.UseVisualStyleBackColor = false;
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.Tomato;
			this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
			this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnClose.Location = new System.Drawing.Point(899, 6);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(45, 37);
			this.btnClose.TabIndex = 1;
			this.btnClose.Text = "X";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.BtnCloseClick);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Britannic Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(0, 5);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(963, 42);
			this.label1.TabIndex = 0;
			this.label1.Text = "TECHNOLINE COMPUTERS";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.MintCream;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dataGridView1.Location = new System.Drawing.Point(10, 97);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(910, 353);
			this.dataGridView1.TabIndex = 12;
			// 
			// tbPartyName
			// 
			this.tbPartyName.BackColor = System.Drawing.Color.White;
			this.tbPartyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbPartyName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.tbPartyName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbPartyName.Location = new System.Drawing.Point(295, 70);
			this.tbPartyName.Name = "tbPartyName";
			this.tbPartyName.Size = new System.Drawing.Size(303, 23);
			this.tbPartyName.TabIndex = 1;
			this.tbPartyName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbPartyNameKeyDown);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label2.Location = new System.Drawing.Point(167, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 9;
			this.label2.Text = "PARTY NAME";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label3.Location = new System.Drawing.Point(167, 105);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(122, 23);
			this.label3.TabIndex = 10;
			this.label3.Text = "PARTY ADDRESS";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label5.Location = new System.Drawing.Point(640, 70);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 11;
			this.label5.Text = "INVOICE NO.";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label6.Location = new System.Drawing.Point(640, 107);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 12;
			this.label6.Text = "INVOICE DATE";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tbPartyAddress
			// 
			this.tbPartyAddress.BackColor = System.Drawing.Color.White;
			this.tbPartyAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.tbPartyAddress.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbPartyAddress.Location = new System.Drawing.Point(295, 104);
			this.tbPartyAddress.Multiline = true;
			this.tbPartyAddress.Name = "tbPartyAddress";
			this.tbPartyAddress.Size = new System.Drawing.Size(303, 69);
			this.tbPartyAddress.TabIndex = 2;
			this.tbPartyAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbPartyAddressKeyDown);
			// 
			// tbInvoiceNo
			// 
			this.tbInvoiceNo.BackColor = System.Drawing.Color.White;
			this.tbInvoiceNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.tbInvoiceNo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbInvoiceNo.Location = new System.Drawing.Point(762, 70);
			this.tbInvoiceNo.Name = "tbInvoiceNo";
			this.tbInvoiceNo.Size = new System.Drawing.Size(303, 23);
			this.tbInvoiceNo.TabIndex = 3;
			this.tbInvoiceNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbInvoiceNoKeyDown);
			// 
			// tbGSTno
			// 
			this.tbGSTno.BackColor = System.Drawing.Color.White;
			this.tbGSTno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.tbGSTno.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbGSTno.Location = new System.Drawing.Point(762, 143);
			this.tbGSTno.Name = "tbGSTno";
			this.tbGSTno.Size = new System.Drawing.Size(303, 23);
			this.tbGSTno.TabIndex = 5;
			this.tbGSTno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbGSTnoKeyDown);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label4.Location = new System.Drawing.Point(640, 144);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 13;
			this.label4.Text = "GST NO.";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.SystemColors.Menu;
			this.panel3.Controls.Add(this.dataGridView1);
			this.panel3.Controls.Add(this.label9);
			this.panel3.Controls.Add(this.cbInterstate);
			this.panel3.Controls.Add(this.cbGSTpercent);
			this.panel3.Controls.Add(this.label14);
			this.panel3.Controls.Add(this.cbUnit);
			this.panel3.Controls.Add(this.label11);
			this.panel3.Controls.Add(this.tbAmount);
			this.panel3.Controls.Add(this.label12);
			this.panel3.Controls.Add(this.tbQty);
			this.panel3.Controls.Add(this.label10);
			this.panel3.Controls.Add(this.tbPrice);
			this.panel3.Controls.Add(this.label8);
			this.panel3.Controls.Add(this.tbItemName);
			this.panel3.Controls.Add(this.label7);
			this.panel3.Location = new System.Drawing.Point(157, 191);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(936, 453);
			this.panel3.TabIndex = 6;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label9.Location = new System.Drawing.Point(703, 15);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(73, 23);
			this.label9.TabIndex = 6;
			this.label9.Text = "UNIT";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cbInterstate
			// 
			this.cbInterstate.BackColor = System.Drawing.Color.White;
			this.cbInterstate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbInterstate.FormattingEnabled = true;
			this.cbInterstate.Items.AddRange(new object[] {
			"Y",
			"N"});
			this.cbInterstate.Location = new System.Drawing.Point(577, 52);
			this.cbInterstate.Name = "cbInterstate";
			this.cbInterstate.Size = new System.Drawing.Size(85, 24);
			this.cbInterstate.TabIndex = 4;
			this.cbInterstate.Enter += new System.EventHandler(this.CbInterstateEnter);
			this.cbInterstate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CbInterstateKeyDown);
			// 
			// cbGSTpercent
			// 
			this.cbGSTpercent.BackColor = System.Drawing.Color.White;
			this.cbGSTpercent.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbGSTpercent.FormattingEnabled = true;
			this.cbGSTpercent.Items.AddRange(new object[] {
			"0",
			"5",
			"12",
			"18",
			"28"});
			this.cbGSTpercent.Location = new System.Drawing.Point(338, 52);
			this.cbGSTpercent.Name = "cbGSTpercent";
			this.cbGSTpercent.Size = new System.Drawing.Size(85, 24);
			this.cbGSTpercent.TabIndex = 4;
			this.cbGSTpercent.Enter += new System.EventHandler(this.CbGSTpercentEnter);
			this.cbGSTpercent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CbGSTpercentKeyDown);
			this.cbGSTpercent.Leave += new System.EventHandler(this.CbGSTpercentLeave);
			// 
			// label14
			// 
			this.label14.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label14.Location = new System.Drawing.Point(461, 51);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(100, 23);
			this.label14.TabIndex = 8;
			this.label14.Text = "INTERSTATE";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cbUnit
			// 
			this.cbUnit.BackColor = System.Drawing.Color.White;
			this.cbUnit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbUnit.FormattingEnabled = true;
			this.cbUnit.Items.AddRange(new object[] {
			"Pcs."});
			this.cbUnit.Location = new System.Drawing.Point(782, 15);
			this.cbUnit.Name = "cbUnit";
			this.cbUnit.Size = new System.Drawing.Size(114, 24);
			this.cbUnit.TabIndex = 2;
			this.cbUnit.Enter += new System.EventHandler(this.CbUnitEnter);
			this.cbUnit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CbUnitKeyDown);
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label11.Location = new System.Drawing.Point(267, 49);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(100, 23);
			this.label11.TabIndex = 8;
			this.label11.Text = "GST %";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tbAmount
			// 
			this.tbAmount.BackColor = System.Drawing.Color.White;
			this.tbAmount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbAmount.Location = new System.Drawing.Point(782, 54);
			this.tbAmount.Name = "tbAmount";
			this.tbAmount.Size = new System.Drawing.Size(114, 23);
			this.tbAmount.TabIndex = 5;
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label12.Location = new System.Drawing.Point(703, 54);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(65, 23);
			this.label12.TabIndex = 7;
			this.label12.Text = "AMOUNT";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tbQty
			// 
			this.tbQty.BackColor = System.Drawing.Color.White;
			this.tbQty.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbQty.Location = new System.Drawing.Point(577, 14);
			this.tbQty.Name = "tbQty";
			this.tbQty.Size = new System.Drawing.Size(85, 23);
			this.tbQty.TabIndex = 1;
			this.tbQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbQtyKeyDown);
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label10.Location = new System.Drawing.Point(506, 13);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(65, 23);
			this.label10.TabIndex = 9;
			this.label10.Text = "QTY.";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tbPrice
			// 
			this.tbPrice.BackColor = System.Drawing.Color.White;
			this.tbPrice.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbPrice.Location = new System.Drawing.Point(138, 52);
			this.tbPrice.Name = "tbPrice";
			this.tbPrice.Size = new System.Drawing.Size(85, 23);
			this.tbPrice.TabIndex = 3;
			this.tbPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbPriceKeyDown);
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label8.Location = new System.Drawing.Point(10, 52);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 11;
			this.label8.Text = "PRICE";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tbItemName
			// 
			this.tbItemName.BackColor = System.Drawing.Color.White;
			this.tbItemName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.tbItemName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbItemName.Location = new System.Drawing.Point(138, 14);
			this.tbItemName.Name = "tbItemName";
			this.tbItemName.Size = new System.Drawing.Size(303, 23);
			this.tbItemName.TabIndex = 0;
			this.tbItemName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbItemNameKeyDown);
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label7.Location = new System.Drawing.Point(10, 14);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 10;
			this.label7.Text = "ITEM NAME";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.SystemColors.HotTrack;
			this.panel4.Controls.Add(this.btnMinimize);
			this.panel4.Controls.Add(this.btnClose);
			this.panel4.Controls.Add(this.label1);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(151, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(964, 48);
			this.panel4.TabIndex = 14;
			// 
			// btnMinimize
			// 
			this.btnMinimize.BackColor = System.Drawing.Color.PaleGreen;
			this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
			this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen;
			this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMinimize.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnMinimize.Location = new System.Drawing.Point(848, 5);
			this.btnMinimize.Name = "btnMinimize";
			this.btnMinimize.Size = new System.Drawing.Size(45, 37);
			this.btnMinimize.TabIndex = 1;
			this.btnMinimize.Text = "---";
			this.btnMinimize.UseVisualStyleBackColor = false;
			this.btnMinimize.Click += new System.EventHandler(this.BtnMinimizeClick);
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.SystemColors.HotTrack;
			this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel5.Location = new System.Drawing.Point(1092, 48);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(23, 599);
			this.panel5.TabIndex = 8;
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.SystemColors.HotTrack;
			this.panel6.Controls.Add(this.textBox9);
			this.panel6.Controls.Add(this.label13);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel6.Location = new System.Drawing.Point(151, 647);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(964, 87);
			this.panel6.TabIndex = 7;
			// 
			// textBox9
			// 
			this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox9.Location = new System.Drawing.Point(828, 15);
			this.textBox9.Name = "textBox9";
			this.textBox9.Size = new System.Drawing.Size(114, 22);
			this.textBox9.TabIndex = 0;
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label13.Location = new System.Drawing.Point(719, 15);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(105, 23);
			this.label13.TabIndex = 1;
			this.label13.Text = "TOTAL C/O";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dtpInvoiceDate
			// 
			this.dtpInvoiceDate.CalendarFont = new System.Drawing.Font("Matura MT Script Capitals", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpInvoiceDate.CustomFormat = "dd/MM/yyyy";
			this.dtpInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpInvoiceDate.Location = new System.Drawing.Point(762, 107);
			this.dtpInvoiceDate.Name = "dtpInvoiceDate";
			this.dtpInvoiceDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dtpInvoiceDate.RightToLeftLayout = true;
			this.dtpInvoiceDate.Size = new System.Drawing.Size(138, 20);
			this.dtpInvoiceDate.TabIndex = 15;
			this.dtpInvoiceDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DtpInvoiceDateKeyDown);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.MintCream;
			this.ClientSize = new System.Drawing.Size(1115, 734);
			this.Controls.Add(this.dtpInvoiceDate);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.panel6);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbGSTno);
			this.Controls.Add(this.tbPartyAddress);
			this.Controls.Add(this.tbInvoiceNo);
			this.Controls.Add(this.tbPartyName);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TechnolineComputers";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
