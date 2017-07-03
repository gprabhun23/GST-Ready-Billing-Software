/*
 * Created by SharpDevelop.
 * User: Ganesh
 * Date: 7/2/2017
 * Time: 5:14 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FirebirdSql.Data.Client;
using FirebirdSql.Data.FirebirdClient;
using FirebirdSql.Data;

namespace SimpleInvoice
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class SimpleInvoice : Form
	{
		FbConnection mConn;
		public SimpleInvoice()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
//			string con="User id=SYSDBA ; Password=masterkey; Dialect=3; DataSource=localhost; Database: D://TECHNOLINE.fdb; ServerType=1;";
//			mConn=new FbConnection(con);
//			mConn.Open();
		}
		void BtnCloseClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void CbGSTpercentEnter(object sender, EventArgs e)
		{
			SendKeys.Send("{F4}");
		}
		void CbInterstateEnter(object sender, EventArgs e)
		{
			SendKeys.Send("{F4}");
		}
		void CbUnitEnter(object sender, EventArgs e)
		{
			SendKeys.Send("{F4}");
		}
		void BtnMinimizeClick(object sender, EventArgs e)
		{
			this.WindowState=FormWindowState.Minimized;
		}
		void TbPartyNameKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Enter)
			{
				if(tbPartyName.Text!="")
				{
					tbPartyAddress.Focus();
				}
				else
				{
					tbPartyName.Focus();
				}
			}
		}
		void TbPartyAddressKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Enter)
			{
				if(tbPartyAddress.Text!="")
				{
					tbInvoiceNo.Focus();
				}
				else
				{
					tbPartyAddress.Focus();
				}
			}
		}
		void TbInvoiceNoKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Enter)
			{
				if(tbInvoiceNo.Text!="")
				{
					dtpInvoiceDate.Focus();
				}
				else
				{
					tbInvoiceNo.Focus();
				}
			}
		}
		void DtpInvoiceDateKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Enter)
			{
				if(dtpInvoiceDate.Text!="")
				{
					tbGSTno.Focus();
				}
				else
				{
					dtpInvoiceDate.Focus();
				}
			}
		}
		void TbItemNameKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Enter)
			{
				if(tbItemName.Text!="")
				{
					tbQty.Focus();
				}
				else
				{
					tbItemName.Focus();
				}
			}
		}
		void TbQtyKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Enter)
			{
				if(tbQty.Text!="")
				{
					cbUnit.Focus();
				}
				else
				{
					tbQty.Focus();
				}
			}
		}
		void CbUnitKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Enter)
			{
				if(cbUnit.Text!="")
				{
					tbPrice.Focus();
				}
				else
				{
					cbUnit.Focus();
				}
			}
		}
		void TbPriceKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Enter)
			{
				if(tbPrice.Text!="")
				{
					cbGSTpercent.Focus();
				}
				else
				{
					tbPrice.Focus();
				}
			}
		}
		void CbGSTpercentKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Enter)
			{
				if(cbGSTpercent.Text!="")
				{
					cbInterstate.Focus();
				}
				else
				{
					cbGSTpercent.Focus();
				}
			}
		}
		void CbInterstateKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Enter)
			{
				if(cbInterstate.Text!="")
				{
					tbAmount.Focus();
				}
				else
				{
					cbInterstate.Focus();
				}
			}
		}
		void TbGSTnoKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Enter)
			{
				if(tbGSTno.Text!="")
				{
					tbItemName.Focus();
				}
				else
				{
					tbGSTno.Focus();
				}
			}
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
		
		private decimal CalculateAmount(int taxPercentage,decimal Price)
		{
			try {
				decimal cgstTaxAmt=0,sgstTaxAmt=0,igstTaxAmt=0,amt=0;
				cgstTaxAmt=Price*(taxPercentage/100);
				sgstTaxAmt=Price*(taxPercentage/100);
				igstTaxAmt=Price*(taxPercentage/100);
				amt=Price+cgstTaxAmt+sgstTaxAmt+igstTaxAmt;
			return amt;
			} catch (Exception) {
				return 0;
				throw;
			}
		}
		void CbGSTpercentLeave(object sender, EventArgs e)
		{
			
		}
	}
}
