﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrepareForFinal.UI
{
    public partial class frm_main : Form
    {
        Color background1 = Color.FromArgb(242, 222, 186); // Màu da đậm
        Color background2 = Color.FromArgb(255, 239, 214); // Màu da nhạt
        public frm_main()
        {
            InitializeComponent();
        }

        private void hideUIItem()
        {
            this.us_employeeUI.Visible = false;
            this.us_productUI.Visible = false;
            this.us_customerUI.Visible = false;
            this.us_accountUI.Visible = false;
            this.us_supplyUI.Visible = false;
            this.us_paymentUI.Visible = false;
        }

        private void makeDefaulColor()
        {
            this.btn_showPaymentUI.BackColor = background1;
            this.btn_showProductUI.BackColor = background1;
            this.btn_showCustomerUI.BackColor = background1;
            this.btn_showEmployeeUI.BackColor = background1;
            this.btn_showEmployeeUI.BackColor = background1;
            this.btn_showStatistic.BackColor = background1;
            this.btn_showSupplyUI.BackColor = background1;
            this.btn_showAccountUI.BackColor = background1;
            this.pn_navigation.BackColor= background1;
        }
        private void frm_main_Load(object sender, EventArgs e)
        {
            hideUIItem();
        }

        private void btn_showPaymentUI_Click(object sender, EventArgs e)
        {
            pn_notify.Text = "Đây là trang thanh toán";
            makeDefaulColor();
            hideUIItem();
            this.btn_showPaymentUI.BackColor = background2;
            us_paymentUI.Visible = true;
            us_paymentUI.BringToFront();
        }

        private void btn_showProductUI_Click(object sender, EventArgs e)
        {
            pn_notify.Text = "Đây là trang sản phẩm";
            makeDefaulColor();
            hideUIItem();
            this.btn_showProductUI.BackColor = background2;
            us_productUI.Visible = true;
            us_productUI.BringToFront();
        }

        private void us_productUI1_Load(object sender, EventArgs e)
        {

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_showEmployeeUI_Click(object sender, EventArgs e)
        {
            pn_notify.Text = "Đây là trang nhân viên";
            makeDefaulColor();
            hideUIItem();
            this.btn_showEmployeeUI.BackColor = background2;
            us_employeeUI.Visible = true;
            us_employeeUI.BringToFront();

        }

        private void btn_showCustomerUI_Click(object sender, EventArgs e)
        {
            pn_notify.Text = "Đây là trang khách hàng";
            makeDefaulColor();
            hideUIItem();
            this.btn_showCustomerUI.BackColor = background2;
            us_customerUI.Visible = true;
            us_customerUI.BringToFront();
        }

        private void btn_showAccountUI_Click(object sender, EventArgs e)
        {
            pn_notify.Text = "Đây là trang tài khoản";
            makeDefaulColor();
            hideUIItem();
            this.btn_showAccountUI.BackColor = background2;
            us_accountUI.Visible = true;
            us_accountUI.BringToFront();
        }

        private void btn_showSupplyUI_Click(object sender, EventArgs e)
        {
            pn_notify.Text = "Đây là trang nhà cung cấp";
            makeDefaulColor();
            hideUIItem();
            this.btn_showSupplyUI.BackColor = background2;
            us_supplyUI.Visible = true;
            us_supplyUI.BringToFront();
        }
    }
}
