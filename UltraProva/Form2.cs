using Infragistics.Documents.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UltraProva
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'dataSet2.macchine'. È possibile spostarla o rimuoverla se necessario.
            this.macchineTableAdapter.Fill(this.dataSet2.macchine);
            // TODO: questa riga di codice carica i dati nella tabella 'dataSet2.Custumer'. È possibile spostarla o rimuoverla se necessario.
            this.custumerTableAdapter.Fill(this.dataSet2.Custumer);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.ultraGridExcelExporter1.Export(this.ultraGrid1, @"C:\Users\simone.denardi\source\repos\UltraProva\UltraProva\bin\Debug\GridData.xls");
            Workbook wb = new Workbook();

            //proprietà del documento
            wb.DocumentProperties.Author = "simone";
            wb.DocumentProperties.Company = "lasportiva";

            //popola celle
            Worksheet ws1 = wb.Worksheets.Add("Worksheet1");
            ws1.Rows[0].Cells[0].Value = "Ciao";
            ws1.Rows[0].Cells[1].Value = "Ciao";
            ws1.Rows[0].Cells[2].Value = "Ciao";

            //stile
            ws1.Rows[0].Cells[0].CellFormat.FillPattern = FillPatternStyle.HorizontalStripe;
            ws1.Rows[0].Cells[1].CellFormat.FillPatternBackgroundColor = Color.Red;

            wb.Save("prova.xls");
        }

        private void caricaFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Workbook wb = Workbook.Load("prova.xls");
            custumerBindingSource.DataSource = wb;
        }
    }
}
