﻿using PFC___StandBy_CSharp.Context;
using PFC___StandBy_CSharp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFC___StandBy_CSharp.Forms.Pagamento
{
    public partial class form_Pagamento : Form
    {
        List<string> lista = new List<string>();
        public form_Pagamento()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Uncomment next line to set the total number of data records stored within your source
            //unboundSource1.SetRowCount(42);
            // This line of code is generated by Data Source Configuration Wizard
            this.unboundSource1.ValueNeeded += unboundSource1_ValueNeeded;
            // This line of code is generated by Data Source Configuration Wizard
            this.unboundSource1.ValuePushed += unboundSource1_ValuePushed;
        }

        private void btnConcluirServicoPagamento_Click(object sender, EventArgs e)
        {
        }

        // This event is generated by Data Source Configuration Wizard
        void unboundSource1_ValueNeeded(object sender, DevExpress.Data.UnboundSourceValueNeededEventArgs e)
        {
            // Handle this event to obtain data from your data source
            // e.Value = something /* TODO: Assign the real data here.*/
            lista.ForEach(x=> e.Value= x);
        }

        // This event is generated by Data Source Configuration Wizard
        void unboundSource1_ValuePushed(object sender, DevExpress.Data.UnboundSourceValuePushedEventArgs e)
        {
            // Handle this event to save modified data back to your data source
            // something = e.Value; /* TODO: Propagate the value into the storage.*/
            lista.Add(e.Value.ToString());
        }
    }
}
