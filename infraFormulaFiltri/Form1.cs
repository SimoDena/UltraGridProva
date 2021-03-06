using Infragistics.Win;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Infragistics.Win.UltraWinGrid;

namespace infraFormulaFiltri
{
    public partial class Form1 : Form
    {
        private string tmp;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'dataSet1.macchine'. È possibile spostarla o rimuoverla se necessario.
            this.macchineTableAdapter.Fill(this.dataSet1.macchine);
            this.custumerTableAdapter1.Fill(this.dataSet1.Custumer);
            //this.ultraGrid1.DisplayLayout.Override.AllowRowFiltering = DefaultableBoolean.True;
            //this.ultraGrid1.DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow;
            //this.ultraGrid1.DisplayLayout.Override.FilterEvaluationTrigger = FilterEvaluationTrigger.OnLeaveCell;

            this.ultraGrid1.DisplayLayout.Bands[0].Columns[0].CellActivation = Activation.Disabled;
        }

        private void ultraGrid1_InitializeLayout(object sender, InitializeLayoutEventArgs e)
        {
            //e.Layout.Override.RowFilterAction = RowFilterAction.AppearancesOnly;
            //e.Layout.Override.FilteredInCellAppearance.ForeColor = Color.DarkGreen;
            //e.Layout.Override.FilteredOutCellAppearance.ForeColor = Color.DarkRed;
        }

        private void ubtSalva_Click(object sender, EventArgs e)
        {
            macchineBindingSource.EndEdit();
            custumerBindingSource.EndEdit();
            this.macchineTableAdapter.Update(this.dataSet1.macchine);
            this.custumerTableAdapter1.Update(this.dataSet1.Custumer);

            this.Close();
        }

        private void ultraGrid1_InitializeLayout_1(object sender, InitializeLayoutEventArgs e)
        {
            e.Layout.Override.FilterUIProvider = ultraGridFilterUIProvider1;
        }

        private void ultraGrid1_ClickCell(object sender, ClickCellEventArgs e)
        {
            string temp = e.Cell.Value.ToString();
            tmp = temp;
        }

        private void ultraGrid1_AfterExitEditMode(object sender, EventArgs e)
        {
            //if (ultraGrid1.ActiveCell.Value.ToString() != tmp)
            //{              
            //    DialogResult dialogo = MessageBox.Show("Modificare Il contenuto della Cella?", "Confermi?", MessageBoxButtons.YesNo);
            //    if (dialogo == DialogResult.Yes)
            //    {

            //    }
            //    else if (dialogo == DialogResult.No)
            //    {
            //        ultraGrid1.ActiveCell.Value = tmp;
            //    }      
            //}
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("Vuoi Salvare?", "Le modifiche non salvate andranno perse", MessageBoxButtons.YesNo);
            if (dialogo == DialogResult.Yes)
            {
                macchineBindingSource.EndEdit();
                this.macchineTableAdapter.Update(this.dataSet1.macchine);
                this.custumerTableAdapter1.Update(this.dataSet1.Custumer);
                
            }
        }

        private void btnTemplateOk_Click(object sender, EventArgs e)
        {
            // This code was automatically generated by the RowEditTemplate Wizard
            // 
            // Close the template and save any pending changes.
            this.ultraGridRowEditTemplate1.Close(true);

        }

        private void btnTemplateCancel_Click(object sender, EventArgs e)
        {
            // This code was automatically generated by the RowEditTemplate Wizard
            // 
            // Close the template and discard any pending changes.
            this.ultraGridRowEditTemplate1.Close(false);

        }

        private void btnTemplateOk_Click_1(object sender, EventArgs e)
        {
            // This code was automatically generated by the RowEditTemplate Wizard
            // 
            // Close the template and save any pending changes.
            this.ultraGridRowEditTemplate1.Close(true);

        }

        private void btnTemplateCancel_Click_1(object sender, EventArgs e)
        {
            // This code was automatically generated by the RowEditTemplate Wizard
            // 
            // Close the template and discard any pending changes.
            this.ultraGridRowEditTemplate1.Close(false);

        }

        private void btnTemplateOk_Click_2(object sender, EventArgs e)
        {
            // This code was automatically generated by the RowEditTemplate Wizard
            // 
            // Close the template and save any pending changes.
            this.ultraGridRowEditTemplate1.Close(true);

        }

        private void btnTemplateCancel_Click_2(object sender, EventArgs e)
        {
            // This code was automatically generated by the RowEditTemplate Wizard
            // 
            // Close the template and discard any pending changes.
            this.ultraGridRowEditTemplate1.Close(false);

        }
    }
}
