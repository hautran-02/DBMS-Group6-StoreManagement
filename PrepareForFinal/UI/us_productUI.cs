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
    public partial class us_productUI : UserControl
    {
        frm_typeList typeListForm;
        public us_productUI()
        {
            InitializeComponent();
        }

        private void gb_productInfo_Click(object sender, EventArgs e)
        {

        }

        private void btn_typeShowList_Click(object sender, EventArgs e)
        {
            this.typeListForm=new frm_typeList();
            this.typeListForm.Show();
        }
    }
}
