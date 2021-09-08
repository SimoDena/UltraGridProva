namespace UltraProva
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("agenti", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn42 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("id");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn43 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("codice");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn44 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("descrizione");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn45 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("stato", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn46 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("agenti_periferia");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("agenti_periferia", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn47 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("id_row");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn48 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("nome");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn49 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("mail");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn50 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("nomedatabase");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn51 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("codage");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn52 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("codcli");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn53 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("codlistino");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn54 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Paese");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn55 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("lingua");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn56 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("agentecliente");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn57 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("macroarea");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn58 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("invioarchivi");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn59 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("prgnew");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn60 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("progressivoord");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn61 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("dataprogressivoord");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn62 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("subagenti");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn63 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("progressivosos");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn64 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("dataprogressivosos");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ultraGridRowEditTemplate1 = new Infragistics.Win.UltraWinGrid.UltraGridRowEditTemplate();
            this.ugcpstato = new Infragistics.Win.UltraWinGrid.UltraGridCellProxy();
            this.lblstato = new Infragistics.Win.Misc.UltraLabel();
            this.ugcpdescrizione = new Infragistics.Win.UltraWinGrid.UltraGridCellProxy();
            this.lbldescrizione = new Infragistics.Win.Misc.UltraLabel();
            this.ugcpcodice = new Infragistics.Win.UltraWinGrid.UltraGridCellProxy();
            this.lblcodice = new Infragistics.Win.Misc.UltraLabel();
            this.ugcpid = new Infragistics.Win.UltraWinGrid.UltraGridCellProxy();
            this.lblid = new Infragistics.Win.Misc.UltraLabel();
            this.btnTemplateOk = new Infragistics.Win.Misc.UltraButton();
            this.btnTemplateCancel = new Infragistics.Win.Misc.UltraButton();
            this.ultraGridRowEditTemplate2 = new Infragistics.Win.UltraWinGrid.UltraGridRowEditTemplate();
            this.ugcpsubagenti = new Infragistics.Win.UltraWinGrid.UltraGridCellProxy();
            this.lblsubagenti = new Infragistics.Win.Misc.UltraLabel();
            this.ugcpdataprogressivoord = new Infragistics.Win.UltraWinGrid.UltraGridCellProxy();
            this.lbldataprogressivoord = new Infragistics.Win.Misc.UltraLabel();
            this.ugcplingua = new Infragistics.Win.UltraWinGrid.UltraGridCellProxy();
            this.lbllingua = new Infragistics.Win.Misc.UltraLabel();
            this.ugcpPaese = new Infragistics.Win.UltraWinGrid.UltraGridCellProxy();
            this.lblPaese = new Infragistics.Win.Misc.UltraLabel();
            this.ugcpcodlistino = new Infragistics.Win.UltraWinGrid.UltraGridCellProxy();
            this.lblcodlistino = new Infragistics.Win.Misc.UltraLabel();
            this.ugcpcodcli = new Infragistics.Win.UltraWinGrid.UltraGridCellProxy();
            this.lblcodcli = new Infragistics.Win.Misc.UltraLabel();
            this.ugcpcodage = new Infragistics.Win.UltraWinGrid.UltraGridCellProxy();
            this.lblcodage = new Infragistics.Win.Misc.UltraLabel();
            this.ugcpnomedatabase = new Infragistics.Win.UltraWinGrid.UltraGridCellProxy();
            this.lblnomedatabase = new Infragistics.Win.Misc.UltraLabel();
            this.ugcpmail = new Infragistics.Win.UltraWinGrid.UltraGridCellProxy();
            this.lblmail = new Infragistics.Win.Misc.UltraLabel();
            this.ugcpnome = new Infragistics.Win.UltraWinGrid.UltraGridCellProxy();
            this.lblnome = new Infragistics.Win.Misc.UltraLabel();
            this.ugcpid_row = new Infragistics.Win.UltraWinGrid.UltraGridCellProxy();
            this.lblid_row = new Infragistics.Win.Misc.UltraLabel();
            this.btnTemplateOk1 = new Infragistics.Win.Misc.UltraButton();
            this.btnTemplateCancel1 = new Infragistics.Win.Misc.UltraButton();
            this.ultraGrid1 = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.agentiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new UltraProva.DataSet1();
            this.agentiTableAdapter = new UltraProva.DataSet1TableAdapters.agentiTableAdapter();
            this.periferiaTableAdapter1 = new UltraProva.DataSet1TableAdapters.periferiaTableAdapter();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGridRowEditTemplate1)).BeginInit();
            this.ultraGridRowEditTemplate1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGridRowEditTemplate2)).BeginInit();
            this.ultraGridRowEditTemplate2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ultraGridRowEditTemplate1
            // 
            this.ultraGridRowEditTemplate1.AutoScroll = true;
            this.ultraGridRowEditTemplate1.BandHierarchyLevel = 0;
            this.ultraGridRowEditTemplate1.BandKey = "agenti";
            this.ultraGridRowEditTemplate1.ColumnData.Add(new Infragistics.Win.UltraWinGrid.UltraGridRowEditTemplate.ColumnDescriptorData("id", typeof(int), "agenti", 0));
            this.ultraGridRowEditTemplate1.ColumnData.Add(new Infragistics.Win.UltraWinGrid.UltraGridRowEditTemplate.ColumnDescriptorData("codice", typeof(string), "agenti", 0));
            this.ultraGridRowEditTemplate1.ColumnData.Add(new Infragistics.Win.UltraWinGrid.UltraGridRowEditTemplate.ColumnDescriptorData("descrizione", typeof(string), "agenti", 0));
            this.ultraGridRowEditTemplate1.ColumnData.Add(new Infragistics.Win.UltraWinGrid.UltraGridRowEditTemplate.ColumnDescriptorData("stato", typeof(string), "agenti", 0));
            this.ultraGridRowEditTemplate1.Controls.Add(this.ugcpstato);
            this.ultraGridRowEditTemplate1.Controls.Add(this.lblstato);
            this.ultraGridRowEditTemplate1.Controls.Add(this.ugcpdescrizione);
            this.ultraGridRowEditTemplate1.Controls.Add(this.lbldescrizione);
            this.ultraGridRowEditTemplate1.Controls.Add(this.ugcpcodice);
            this.ultraGridRowEditTemplate1.Controls.Add(this.lblcodice);
            this.ultraGridRowEditTemplate1.Controls.Add(this.ugcpid);
            this.ultraGridRowEditTemplate1.Controls.Add(this.lblid);
            this.ultraGridRowEditTemplate1.Controls.Add(this.btnTemplateOk);
            this.ultraGridRowEditTemplate1.Controls.Add(this.btnTemplateCancel);
            this.ultraGridRowEditTemplate1.DialogSettings.AcceptButton = this.btnTemplateOk;
            this.ultraGridRowEditTemplate1.DialogSettings.CancelButton = this.btnTemplateCancel;
            this.ultraGridRowEditTemplate1.Location = new System.Drawing.Point(434, 101);
            this.ultraGridRowEditTemplate1.Name = "ultraGridRowEditTemplate1";
            this.ultraGridRowEditTemplate1.Size = new System.Drawing.Size(300, 148);
            this.ultraGridRowEditTemplate1.TabIndex = 1;
            this.ultraGridRowEditTemplate1.Visible = false;
            // 
            // ugcpstato
            // 
            this.ugcpstato.ColumnKey = "stato";
            this.ugcpstato.Location = new System.Drawing.Point(110, 80);
            this.ugcpstato.Name = "ugcpstato";
            this.ugcpstato.Size = new System.Drawing.Size(120, 20);
            this.ugcpstato.TabIndex = 7;
            this.ugcpstato.Text = "stato";
            // 
            // lblstato
            // 
            this.lblstato.Location = new System.Drawing.Point(5, 80);
            this.lblstato.Name = "lblstato";
            this.lblstato.Size = new System.Drawing.Size(100, 20);
            this.lblstato.TabIndex = 6;
            this.lblstato.Tag = "stato";
            this.lblstato.Text = "stato:";
            // 
            // ugcpdescrizione
            // 
            this.ugcpdescrizione.ColumnKey = "descrizione";
            this.ugcpdescrizione.Location = new System.Drawing.Point(110, 55);
            this.ugcpdescrizione.Name = "ugcpdescrizione";
            this.ugcpdescrizione.Size = new System.Drawing.Size(120, 20);
            this.ugcpdescrizione.TabIndex = 5;
            this.ugcpdescrizione.Text = "descrizione";
            // 
            // lbldescrizione
            // 
            this.lbldescrizione.Location = new System.Drawing.Point(5, 55);
            this.lbldescrizione.Name = "lbldescrizione";
            this.lbldescrizione.Size = new System.Drawing.Size(100, 20);
            this.lbldescrizione.TabIndex = 4;
            this.lbldescrizione.Tag = "descrizione";
            this.lbldescrizione.Text = "descrizione:";
            // 
            // ugcpcodice
            // 
            this.ugcpcodice.ColumnKey = "codice";
            this.ugcpcodice.Location = new System.Drawing.Point(110, 30);
            this.ugcpcodice.Name = "ugcpcodice";
            this.ugcpcodice.Size = new System.Drawing.Size(120, 20);
            this.ugcpcodice.TabIndex = 3;
            this.ugcpcodice.Text = "codice";
            // 
            // lblcodice
            // 
            this.lblcodice.Location = new System.Drawing.Point(5, 30);
            this.lblcodice.Name = "lblcodice";
            this.lblcodice.Size = new System.Drawing.Size(100, 20);
            this.lblcodice.TabIndex = 2;
            this.lblcodice.Tag = "codice";
            this.lblcodice.Text = "codice:";
            // 
            // ugcpid
            // 
            this.ugcpid.ColumnKey = "id";
            this.ugcpid.Location = new System.Drawing.Point(110, 5);
            this.ugcpid.Name = "ugcpid";
            this.ugcpid.Size = new System.Drawing.Size(120, 20);
            this.ugcpid.TabIndex = 1;
            this.ugcpid.Text = "id";
            // 
            // lblid
            // 
            this.lblid.Location = new System.Drawing.Point(5, 5);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(100, 20);
            this.lblid.TabIndex = 0;
            this.lblid.Tag = "id";
            this.lblid.Text = "id:";
            // 
            // btnTemplateOk
            // 
            this.btnTemplateOk.Location = new System.Drawing.Point(5, 105);
            this.btnTemplateOk.Name = "btnTemplateOk";
            this.btnTemplateOk.Size = new System.Drawing.Size(75, 23);
            this.btnTemplateOk.TabIndex = 8;
            this.btnTemplateOk.Text = "&OK";
            this.btnTemplateOk.Click += new System.EventHandler(this.btnTemplateOk_Click);
            // 
            // btnTemplateCancel
            // 
            this.btnTemplateCancel.Location = new System.Drawing.Point(85, 105);
            this.btnTemplateCancel.Name = "btnTemplateCancel";
            this.btnTemplateCancel.Size = new System.Drawing.Size(75, 23);
            this.btnTemplateCancel.TabIndex = 9;
            this.btnTemplateCancel.Text = "&Cancel";
            this.btnTemplateCancel.Click += new System.EventHandler(this.btnTemplateCancel_Click);
            // 
            // ultraGridRowEditTemplate2
            // 
            this.ultraGridRowEditTemplate2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraGridRowEditTemplate2.AutoScroll = true;
            this.ultraGridRowEditTemplate2.BandHierarchyLevel = 1;
            this.ultraGridRowEditTemplate2.BandKey = "agenti_periferia";
            this.ultraGridRowEditTemplate2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ultraGridRowEditTemplate2.ColumnData.Add(new Infragistics.Win.UltraWinGrid.UltraGridRowEditTemplate.ColumnDescriptorData("id_row", typeof(int), "agenti_periferia", 1));
            this.ultraGridRowEditTemplate2.ColumnData.Add(new Infragistics.Win.UltraWinGrid.UltraGridRowEditTemplate.ColumnDescriptorData("nome", typeof(string), "agenti_periferia", 1));
            this.ultraGridRowEditTemplate2.ColumnData.Add(new Infragistics.Win.UltraWinGrid.UltraGridRowEditTemplate.ColumnDescriptorData("mail", typeof(string), "agenti_periferia", 1));
            this.ultraGridRowEditTemplate2.ColumnData.Add(new Infragistics.Win.UltraWinGrid.UltraGridRowEditTemplate.ColumnDescriptorData("nomedatabase", typeof(string), "agenti_periferia", 1));
            this.ultraGridRowEditTemplate2.ColumnData.Add(new Infragistics.Win.UltraWinGrid.UltraGridRowEditTemplate.ColumnDescriptorData("codage", typeof(string), "agenti_periferia", 1));
            this.ultraGridRowEditTemplate2.ColumnData.Add(new Infragistics.Win.UltraWinGrid.UltraGridRowEditTemplate.ColumnDescriptorData("codcli", typeof(string), "agenti_periferia", 1));
            this.ultraGridRowEditTemplate2.ColumnData.Add(new Infragistics.Win.UltraWinGrid.UltraGridRowEditTemplate.ColumnDescriptorData("codlistino", typeof(string), "agenti_periferia", 1));
            this.ultraGridRowEditTemplate2.ColumnData.Add(new Infragistics.Win.UltraWinGrid.UltraGridRowEditTemplate.ColumnDescriptorData("Paese", typeof(string), "agenti_periferia", 1));
            this.ultraGridRowEditTemplate2.ColumnData.Add(new Infragistics.Win.UltraWinGrid.UltraGridRowEditTemplate.ColumnDescriptorData("lingua", typeof(string), "agenti_periferia", 1));
            this.ultraGridRowEditTemplate2.ColumnData.Add(new Infragistics.Win.UltraWinGrid.UltraGridRowEditTemplate.ColumnDescriptorData("agentecliente", typeof(string), "agenti_periferia", 1));
            this.ultraGridRowEditTemplate2.ColumnData.Add(new Infragistics.Win.UltraWinGrid.UltraGridRowEditTemplate.ColumnDescriptorData("macroarea", typeof(string), "agenti_periferia", 1));
            this.ultraGridRowEditTemplate2.ColumnData.Add(new Infragistics.Win.UltraWinGrid.UltraGridRowEditTemplate.ColumnDescriptorData("invioarchivi", typeof(bool), "agenti_periferia", 1));
            this.ultraGridRowEditTemplate2.ColumnData.Add(new Infragistics.Win.UltraWinGrid.UltraGridRowEditTemplate.ColumnDescriptorData("prgnew", typeof(string), "agenti_periferia", 1));
            this.ultraGridRowEditTemplate2.ColumnData.Add(new Infragistics.Win.UltraWinGrid.UltraGridRowEditTemplate.ColumnDescriptorData("progressivoord", typeof(string), "agenti_periferia", 1));
            this.ultraGridRowEditTemplate2.ColumnData.Add(new Infragistics.Win.UltraWinGrid.UltraGridRowEditTemplate.ColumnDescriptorData("dataprogressivoord", typeof(System.DateTime), "agenti_periferia", 1));
            this.ultraGridRowEditTemplate2.ColumnData.Add(new Infragistics.Win.UltraWinGrid.UltraGridRowEditTemplate.ColumnDescriptorData("subagenti", typeof(string), "agenti_periferia", 1));
            this.ultraGridRowEditTemplate2.ColumnData.Add(new Infragistics.Win.UltraWinGrid.UltraGridRowEditTemplate.ColumnDescriptorData("progressivosos", typeof(string), "agenti_periferia", 1));
            this.ultraGridRowEditTemplate2.ColumnData.Add(new Infragistics.Win.UltraWinGrid.UltraGridRowEditTemplate.ColumnDescriptorData("dataprogressivosos", typeof(System.DateTime), "agenti_periferia", 1));
            this.ultraGridRowEditTemplate2.ColumnData.Add(new Infragistics.Win.UltraWinGrid.UltraGridRowEditTemplate.ColumnDescriptorData("id", typeof(int), "agenti", 0));
            this.ultraGridRowEditTemplate2.ColumnData.Add(new Infragistics.Win.UltraWinGrid.UltraGridRowEditTemplate.ColumnDescriptorData("codice", typeof(string), "agenti", 0));
            this.ultraGridRowEditTemplate2.ColumnData.Add(new Infragistics.Win.UltraWinGrid.UltraGridRowEditTemplate.ColumnDescriptorData("descrizione", typeof(string), "agenti", 0));
            this.ultraGridRowEditTemplate2.ColumnData.Add(new Infragistics.Win.UltraWinGrid.UltraGridRowEditTemplate.ColumnDescriptorData("stato", typeof(string), "agenti", 0));
            this.ultraGridRowEditTemplate2.Controls.Add(this.ugcpsubagenti);
            this.ultraGridRowEditTemplate2.Controls.Add(this.lblsubagenti);
            this.ultraGridRowEditTemplate2.Controls.Add(this.ugcpdataprogressivoord);
            this.ultraGridRowEditTemplate2.Controls.Add(this.lbldataprogressivoord);
            this.ultraGridRowEditTemplate2.Controls.Add(this.ugcplingua);
            this.ultraGridRowEditTemplate2.Controls.Add(this.lbllingua);
            this.ultraGridRowEditTemplate2.Controls.Add(this.ugcpPaese);
            this.ultraGridRowEditTemplate2.Controls.Add(this.lblPaese);
            this.ultraGridRowEditTemplate2.Controls.Add(this.ugcpcodlistino);
            this.ultraGridRowEditTemplate2.Controls.Add(this.lblcodlistino);
            this.ultraGridRowEditTemplate2.Controls.Add(this.ugcpcodcli);
            this.ultraGridRowEditTemplate2.Controls.Add(this.lblcodcli);
            this.ultraGridRowEditTemplate2.Controls.Add(this.ugcpcodage);
            this.ultraGridRowEditTemplate2.Controls.Add(this.lblcodage);
            this.ultraGridRowEditTemplate2.Controls.Add(this.ugcpnomedatabase);
            this.ultraGridRowEditTemplate2.Controls.Add(this.lblnomedatabase);
            this.ultraGridRowEditTemplate2.Controls.Add(this.ugcpmail);
            this.ultraGridRowEditTemplate2.Controls.Add(this.lblmail);
            this.ultraGridRowEditTemplate2.Controls.Add(this.ugcpnome);
            this.ultraGridRowEditTemplate2.Controls.Add(this.lblnome);
            this.ultraGridRowEditTemplate2.Controls.Add(this.ugcpid_row);
            this.ultraGridRowEditTemplate2.Controls.Add(this.lblid_row);
            this.ultraGridRowEditTemplate2.Controls.Add(this.btnTemplateOk1);
            this.ultraGridRowEditTemplate2.Controls.Add(this.btnTemplateCancel1);
            this.ultraGridRowEditTemplate2.DialogSettings.AcceptButton = this.btnTemplateOk1;
            this.ultraGridRowEditTemplate2.DialogSettings.CancelButton = this.btnTemplateCancel1;
            this.ultraGridRowEditTemplate2.Location = new System.Drawing.Point(272, 255);
            this.ultraGridRowEditTemplate2.Name = "ultraGridRowEditTemplate2";
            this.ultraGridRowEditTemplate2.Size = new System.Drawing.Size(705, 155);
            this.ultraGridRowEditTemplate2.TabIndex = 2;
            this.ultraGridRowEditTemplate2.Visible = false;
            // 
            // ugcpsubagenti
            // 
            this.ugcpsubagenti.ColumnKey = "subagenti";
            this.ugcpsubagenti.Location = new System.Drawing.Point(570, 55);
            this.ugcpsubagenti.Name = "ugcpsubagenti";
            this.ugcpsubagenti.Size = new System.Drawing.Size(120, 20);
            this.ugcpsubagenti.TabIndex = 21;
            this.ugcpsubagenti.Text = "subagenti";
            // 
            // lblsubagenti
            // 
            this.lblsubagenti.Location = new System.Drawing.Point(465, 55);
            this.lblsubagenti.Name = "lblsubagenti";
            this.lblsubagenti.Size = new System.Drawing.Size(100, 20);
            this.lblsubagenti.TabIndex = 20;
            this.lblsubagenti.Tag = "subagenti";
            this.lblsubagenti.Text = "subagenti:";
            // 
            // ugcpdataprogressivoord
            // 
            this.ugcpdataprogressivoord.ColumnKey = "dataprogressivoord";
            this.ugcpdataprogressivoord.Location = new System.Drawing.Point(570, 30);
            this.ugcpdataprogressivoord.Name = "ugcpdataprogressivoord";
            this.ugcpdataprogressivoord.Size = new System.Drawing.Size(120, 20);
            this.ugcpdataprogressivoord.TabIndex = 19;
            this.ugcpdataprogressivoord.Text = "dataprogressivoord";
            // 
            // lbldataprogressivoord
            // 
            this.lbldataprogressivoord.Location = new System.Drawing.Point(465, 30);
            this.lbldataprogressivoord.Name = "lbldataprogressivoord";
            this.lbldataprogressivoord.Size = new System.Drawing.Size(100, 20);
            this.lbldataprogressivoord.TabIndex = 18;
            this.lbldataprogressivoord.Tag = "dataprogressivoord";
            this.lbldataprogressivoord.Text = "dataprogressivoord:";
            // 
            // ugcplingua
            // 
            this.ugcplingua.ColumnKey = "lingua";
            this.ugcplingua.Location = new System.Drawing.Point(570, 5);
            this.ugcplingua.Name = "ugcplingua";
            this.ugcplingua.Size = new System.Drawing.Size(120, 20);
            this.ugcplingua.TabIndex = 17;
            this.ugcplingua.Text = "lingua";
            // 
            // lbllingua
            // 
            this.lbllingua.Location = new System.Drawing.Point(465, 5);
            this.lbllingua.Name = "lbllingua";
            this.lbllingua.Size = new System.Drawing.Size(100, 20);
            this.lbllingua.TabIndex = 16;
            this.lbllingua.Tag = "lingua";
            this.lbllingua.Text = "lingua:";
            // 
            // ugcpPaese
            // 
            this.ugcpPaese.ColumnKey = "Paese";
            this.ugcpPaese.Location = new System.Drawing.Point(340, 80);
            this.ugcpPaese.Name = "ugcpPaese";
            this.ugcpPaese.Size = new System.Drawing.Size(120, 20);
            this.ugcpPaese.TabIndex = 15;
            this.ugcpPaese.Text = "Paese";
            // 
            // lblPaese
            // 
            this.lblPaese.Location = new System.Drawing.Point(235, 80);
            this.lblPaese.Name = "lblPaese";
            this.lblPaese.Size = new System.Drawing.Size(100, 20);
            this.lblPaese.TabIndex = 14;
            this.lblPaese.Tag = "Paese";
            this.lblPaese.Text = "Paese:";
            // 
            // ugcpcodlistino
            // 
            this.ugcpcodlistino.ColumnKey = "codlistino";
            this.ugcpcodlistino.Location = new System.Drawing.Point(340, 55);
            this.ugcpcodlistino.Name = "ugcpcodlistino";
            this.ugcpcodlistino.Size = new System.Drawing.Size(120, 20);
            this.ugcpcodlistino.TabIndex = 13;
            this.ugcpcodlistino.Text = "codlistino";
            // 
            // lblcodlistino
            // 
            this.lblcodlistino.Location = new System.Drawing.Point(235, 55);
            this.lblcodlistino.Name = "lblcodlistino";
            this.lblcodlistino.Size = new System.Drawing.Size(100, 20);
            this.lblcodlistino.TabIndex = 12;
            this.lblcodlistino.Tag = "codlistino";
            this.lblcodlistino.Text = "codlistino:";
            // 
            // ugcpcodcli
            // 
            this.ugcpcodcli.ColumnKey = "codcli";
            this.ugcpcodcli.Location = new System.Drawing.Point(340, 30);
            this.ugcpcodcli.Name = "ugcpcodcli";
            this.ugcpcodcli.Size = new System.Drawing.Size(120, 20);
            this.ugcpcodcli.TabIndex = 11;
            this.ugcpcodcli.Text = "codcli";
            // 
            // lblcodcli
            // 
            this.lblcodcli.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblcodcli.Location = new System.Drawing.Point(235, 30);
            this.lblcodcli.Name = "lblcodcli";
            this.lblcodcli.Size = new System.Drawing.Size(100, 20);
            this.lblcodcli.TabIndex = 10;
            this.lblcodcli.Tag = "codcli";
            this.lblcodcli.Text = "codcli:";
            // 
            // ugcpcodage
            // 
            this.ugcpcodage.ColumnKey = "codage";
            this.ugcpcodage.Location = new System.Drawing.Point(343, 5);
            this.ugcpcodage.Name = "ugcpcodage";
            this.ugcpcodage.Size = new System.Drawing.Size(120, 20);
            this.ugcpcodage.TabIndex = 9;
            this.ugcpcodage.Text = "codage";
            // 
            // lblcodage
            // 
            this.lblcodage.Location = new System.Drawing.Point(235, 5);
            this.lblcodage.Name = "lblcodage";
            this.lblcodage.Size = new System.Drawing.Size(100, 20);
            this.lblcodage.TabIndex = 8;
            this.lblcodage.Tag = "codage";
            this.lblcodage.Text = "codage:";
            // 
            // ugcpnomedatabase
            // 
            this.ugcpnomedatabase.ColumnKey = "nomedatabase";
            this.ugcpnomedatabase.Location = new System.Drawing.Point(110, 80);
            this.ugcpnomedatabase.Name = "ugcpnomedatabase";
            this.ugcpnomedatabase.Size = new System.Drawing.Size(120, 20);
            this.ugcpnomedatabase.TabIndex = 7;
            this.ugcpnomedatabase.Text = "nomedatabase";
            // 
            // lblnomedatabase
            // 
            this.lblnomedatabase.Location = new System.Drawing.Point(5, 80);
            this.lblnomedatabase.Name = "lblnomedatabase";
            this.lblnomedatabase.Size = new System.Drawing.Size(100, 20);
            this.lblnomedatabase.TabIndex = 6;
            this.lblnomedatabase.Tag = "nomedatabase";
            this.lblnomedatabase.Text = "nomedatabase:";
            // 
            // ugcpmail
            // 
            this.ugcpmail.ColumnKey = "mail";
            this.ugcpmail.Location = new System.Drawing.Point(110, 55);
            this.ugcpmail.Name = "ugcpmail";
            this.ugcpmail.Size = new System.Drawing.Size(120, 20);
            this.ugcpmail.TabIndex = 5;
            this.ugcpmail.Text = "mail";
            // 
            // lblmail
            // 
            this.lblmail.Location = new System.Drawing.Point(5, 55);
            this.lblmail.Name = "lblmail";
            this.lblmail.Size = new System.Drawing.Size(100, 20);
            this.lblmail.TabIndex = 4;
            this.lblmail.Tag = "mail";
            this.lblmail.Text = "mail:";
            // 
            // ugcpnome
            // 
            this.ugcpnome.ColumnKey = "nome";
            this.ugcpnome.Location = new System.Drawing.Point(110, 30);
            this.ugcpnome.Name = "ugcpnome";
            this.ugcpnome.Size = new System.Drawing.Size(120, 20);
            this.ugcpnome.TabIndex = 3;
            this.ugcpnome.Text = "nome";
            // 
            // lblnome
            // 
            this.lblnome.Location = new System.Drawing.Point(5, 30);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(100, 20);
            this.lblnome.TabIndex = 2;
            this.lblnome.Tag = "nome";
            this.lblnome.Text = "nome:";
            // 
            // ugcpid_row
            // 
            this.ugcpid_row.ColumnKey = "id_row";
            this.ugcpid_row.Location = new System.Drawing.Point(110, 5);
            this.ugcpid_row.Name = "ugcpid_row";
            this.ugcpid_row.Size = new System.Drawing.Size(120, 20);
            this.ugcpid_row.TabIndex = 1;
            this.ugcpid_row.Text = "id_row";
            // 
            // lblid_row
            // 
            this.lblid_row.Location = new System.Drawing.Point(5, 5);
            this.lblid_row.Name = "lblid_row";
            this.lblid_row.Size = new System.Drawing.Size(100, 20);
            this.lblid_row.TabIndex = 0;
            this.lblid_row.Tag = "id_row";
            this.lblid_row.Text = "id_row:";
            // 
            // btnTemplateOk1
            // 
            this.btnTemplateOk1.Location = new System.Drawing.Point(5, 105);
            this.btnTemplateOk1.Name = "btnTemplateOk1";
            this.btnTemplateOk1.Size = new System.Drawing.Size(75, 23);
            this.btnTemplateOk1.TabIndex = 22;
            this.btnTemplateOk1.Text = "&OK";
            this.btnTemplateOk1.Click += new System.EventHandler(this.btnTemplateOk1_Click);
            // 
            // btnTemplateCancel1
            // 
            this.btnTemplateCancel1.Location = new System.Drawing.Point(85, 105);
            this.btnTemplateCancel1.Name = "btnTemplateCancel1";
            this.btnTemplateCancel1.Size = new System.Drawing.Size(75, 23);
            this.btnTemplateCancel1.TabIndex = 23;
            this.btnTemplateCancel1.Text = "&Cancel";
            this.btnTemplateCancel1.Click += new System.EventHandler(this.btnTemplateCancel1_Click);
            // 
            // ultraGrid1
            // 
            this.ultraGrid1.DataSource = this.agentiBindingSource;
            appearance1.BackColor = System.Drawing.SystemColors.Window;
            appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.ultraGrid1.DisplayLayout.Appearance = appearance1;
            this.ultraGrid1.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn42.Header.VisiblePosition = 0;
            ultraGridColumn42.Width = 216;
            ultraGridColumn43.Header.VisiblePosition = 1;
            ultraGridColumn43.Width = 298;
            ultraGridColumn44.Header.VisiblePosition = 2;
            ultraGridColumn44.Width = 293;
            ultraGridColumn45.Header.VisiblePosition = 3;
            ultraGridColumn45.Width = 296;
            ultraGridColumn46.Header.VisiblePosition = 4;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn42,
            ultraGridColumn43,
            ultraGridColumn44,
            ultraGridColumn45,
            ultraGridColumn46});
            ultraGridBand1.RowEditTemplate = this.ultraGridRowEditTemplate1;
            ultraGridColumn47.Header.VisiblePosition = 0;
            ultraGridColumn47.Width = 45;
            ultraGridColumn48.Header.VisiblePosition = 1;
            ultraGridColumn48.Width = 153;
            ultraGridColumn49.Header.VisiblePosition = 2;
            ultraGridColumn49.Width = 150;
            ultraGridColumn50.Header.VisiblePosition = 3;
            ultraGridColumn50.Width = 170;
            ultraGridColumn51.Header.VisiblePosition = 4;
            ultraGridColumn51.Width = 38;
            ultraGridColumn52.Header.VisiblePosition = 5;
            ultraGridColumn52.Width = 38;
            ultraGridColumn53.Header.VisiblePosition = 6;
            ultraGridColumn53.Width = 38;
            ultraGridColumn54.Header.VisiblePosition = 7;
            ultraGridColumn54.Width = 38;
            ultraGridColumn55.Header.VisiblePosition = 8;
            ultraGridColumn55.Width = 38;
            ultraGridColumn56.Header.VisiblePosition = 9;
            ultraGridColumn56.Width = 38;
            ultraGridColumn57.Header.VisiblePosition = 10;
            ultraGridColumn57.Width = 38;
            ultraGridColumn58.Header.VisiblePosition = 11;
            ultraGridColumn58.Width = 48;
            ultraGridColumn59.Header.VisiblePosition = 12;
            ultraGridColumn59.Width = 38;
            ultraGridColumn60.Header.VisiblePosition = 13;
            ultraGridColumn60.Width = 40;
            ultraGridColumn61.Header.VisiblePosition = 14;
            ultraGridColumn61.Width = 48;
            ultraGridColumn62.Header.VisiblePosition = 15;
            ultraGridColumn62.Width = 38;
            ultraGridColumn63.Header.VisiblePosition = 16;
            ultraGridColumn63.Width = 40;
            ultraGridColumn64.Header.VisiblePosition = 17;
            ultraGridColumn64.Width = 48;
            ultraGridBand2.Columns.AddRange(new object[] {
            ultraGridColumn47,
            ultraGridColumn48,
            ultraGridColumn49,
            ultraGridColumn50,
            ultraGridColumn51,
            ultraGridColumn52,
            ultraGridColumn53,
            ultraGridColumn54,
            ultraGridColumn55,
            ultraGridColumn56,
            ultraGridColumn57,
            ultraGridColumn58,
            ultraGridColumn59,
            ultraGridColumn60,
            ultraGridColumn61,
            ultraGridColumn62,
            ultraGridColumn63,
            ultraGridColumn64});
            ultraGridBand2.RowEditTemplate = this.ultraGridRowEditTemplate2;
            this.ultraGrid1.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.ultraGrid1.DisplayLayout.BandsSerializer.Add(ultraGridBand2);
            this.ultraGrid1.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.ultraGrid1.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance2.BorderColor = System.Drawing.SystemColors.Window;
            this.ultraGrid1.DisplayLayout.GroupByBox.Appearance = appearance2;
            appearance3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ultraGrid1.DisplayLayout.GroupByBox.BandLabelAppearance = appearance3;
            this.ultraGrid1.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance4.BackColor2 = System.Drawing.SystemColors.Control;
            appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ultraGrid1.DisplayLayout.GroupByBox.PromptAppearance = appearance4;
            this.ultraGrid1.DisplayLayout.MaxColScrollRegions = 1;
            this.ultraGrid1.DisplayLayout.MaxRowScrollRegions = 1;
            appearance5.BackColor = System.Drawing.SystemColors.Window;
            appearance5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ultraGrid1.DisplayLayout.Override.ActiveCellAppearance = appearance5;
            appearance6.BackColor = System.Drawing.SystemColors.Highlight;
            appearance6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ultraGrid1.DisplayLayout.Override.ActiveRowAppearance = appearance6;
            this.ultraGrid1.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed;
            this.ultraGrid1.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None;
            this.ultraGrid1.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.ultraGrid1.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance7.BackColor = System.Drawing.SystemColors.Window;
            this.ultraGrid1.DisplayLayout.Override.CardAreaAppearance = appearance7;
            appearance8.BorderColor = System.Drawing.Color.Silver;
            appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.ultraGrid1.DisplayLayout.Override.CellAppearance = appearance8;
            this.ultraGrid1.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.ultraGrid1.DisplayLayout.Override.CellPadding = 0;
            appearance9.BackColor = System.Drawing.SystemColors.Control;
            appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance9.BorderColor = System.Drawing.SystemColors.Window;
            this.ultraGrid1.DisplayLayout.Override.GroupByRowAppearance = appearance9;
            appearance10.TextHAlignAsString = "Left";
            this.ultraGrid1.DisplayLayout.Override.HeaderAppearance = appearance10;
            this.ultraGrid1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.ultraGrid1.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance11.BackColor = System.Drawing.SystemColors.Window;
            appearance11.BorderColor = System.Drawing.Color.Silver;
            this.ultraGrid1.DisplayLayout.Override.RowAppearance = appearance11;
            this.ultraGrid1.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            appearance12.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ultraGrid1.DisplayLayout.Override.TemplateAddRowAppearance = appearance12;
            this.ultraGrid1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.ultraGrid1.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.ultraGrid1.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraGrid1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraGrid1.Location = new System.Drawing.Point(0, 0);
            this.ultraGrid1.Name = "ultraGrid1";
            this.ultraGrid1.Size = new System.Drawing.Size(1124, 450);
            this.ultraGrid1.TabIndex = 0;
            this.ultraGrid1.Text = "ultraGrid1";
            // 
            // agentiBindingSource
            // 
            this.agentiBindingSource.DataMember = "agenti";
            this.agentiBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agentiTableAdapter
            // 
            this.agentiTableAdapter.ClearBeforeFill = true;
            // 
            // periferiaTableAdapter1
            // 
            this.periferiaTableAdapter1.ClearBeforeFill = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.agentiBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.toolStripButton1,
            this.toolStripButton2});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1124, 25);
            this.bindingNavigator1.TabIndex = 3;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Aggiungi nuovo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(34, 22);
            this.bindingNavigatorCountItem.Text = "di {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Numero totale di elementi";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Elimina";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Sposta in prima posizione";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Sposta indietro";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posizione";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posizione corrente";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Sposta avanti";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Sposta in ultima posizione";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 450);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.ultraGridRowEditTemplate2);
            this.Controls.Add(this.ultraGridRowEditTemplate1);
            this.Controls.Add(this.ultraGrid1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGridRowEditTemplate1)).EndInit();
            this.ultraGridRowEditTemplate1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGridRowEditTemplate2)).EndInit();
            this.ultraGridRowEditTemplate2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infragistics.Win.UltraWinGrid.UltraGrid ultraGrid1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource agentiBindingSource;
        private DataSet1TableAdapters.agentiTableAdapter agentiTableAdapter;
        private DataSet1TableAdapters.periferiaTableAdapter periferiaTableAdapter1;
        private Infragistics.Win.UltraWinGrid.UltraGridRowEditTemplate ultraGridRowEditTemplate1;
        private Infragistics.Win.UltraWinGrid.UltraGridCellProxy ugcpstato;
        private Infragistics.Win.Misc.UltraLabel lblstato;
        private Infragistics.Win.UltraWinGrid.UltraGridCellProxy ugcpdescrizione;
        private Infragistics.Win.Misc.UltraLabel lbldescrizione;
        private Infragistics.Win.UltraWinGrid.UltraGridCellProxy ugcpcodice;
        private Infragistics.Win.Misc.UltraLabel lblcodice;
        private Infragistics.Win.UltraWinGrid.UltraGridCellProxy ugcpid;
        private Infragistics.Win.Misc.UltraLabel lblid;
        private Infragistics.Win.Misc.UltraButton btnTemplateOk;
        private Infragistics.Win.Misc.UltraButton btnTemplateCancel;
        private Infragistics.Win.UltraWinGrid.UltraGridRowEditTemplate ultraGridRowEditTemplate2;
        private Infragistics.Win.UltraWinGrid.UltraGridCellProxy ugcpsubagenti;
        private Infragistics.Win.Misc.UltraLabel lblsubagenti;
        private Infragistics.Win.UltraWinGrid.UltraGridCellProxy ugcpdataprogressivoord;
        private Infragistics.Win.Misc.UltraLabel lbldataprogressivoord;
        private Infragistics.Win.UltraWinGrid.UltraGridCellProxy ugcplingua;
        private Infragistics.Win.Misc.UltraLabel lbllingua;
        private Infragistics.Win.UltraWinGrid.UltraGridCellProxy ugcpPaese;
        private Infragistics.Win.Misc.UltraLabel lblPaese;
        private Infragistics.Win.UltraWinGrid.UltraGridCellProxy ugcpcodlistino;
        private Infragistics.Win.Misc.UltraLabel lblcodlistino;
        private Infragistics.Win.UltraWinGrid.UltraGridCellProxy ugcpcodcli;
        private Infragistics.Win.Misc.UltraLabel lblcodcli;
        private Infragistics.Win.UltraWinGrid.UltraGridCellProxy ugcpcodage;
        private Infragistics.Win.Misc.UltraLabel lblcodage;
        private Infragistics.Win.UltraWinGrid.UltraGridCellProxy ugcpnomedatabase;
        private Infragistics.Win.Misc.UltraLabel lblnomedatabase;
        private Infragistics.Win.UltraWinGrid.UltraGridCellProxy ugcpmail;
        private Infragistics.Win.Misc.UltraLabel lblmail;
        private Infragistics.Win.UltraWinGrid.UltraGridCellProxy ugcpnome;
        private Infragistics.Win.Misc.UltraLabel lblnome;
        private Infragistics.Win.UltraWinGrid.UltraGridCellProxy ugcpid_row;
        private Infragistics.Win.Misc.UltraLabel lblid_row;
        private Infragistics.Win.Misc.UltraButton btnTemplateOk1;
        private Infragistics.Win.Misc.UltraButton btnTemplateCancel1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}

