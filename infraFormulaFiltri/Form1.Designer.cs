namespace infraFormulaFiltri
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
            Infragistics.Win.Appearance appearance28 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand4 = new Infragistics.Win.UltraWinGrid.UltraGridBand("macchine", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn28 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMacchina");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn29 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("marca");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn30 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("modello");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn31 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("costo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn32 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("bollo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn33 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("benzina");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn34 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("immatricolazione");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn35 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("macchine_Custumer");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand5 = new Infragistics.Win.UltraWinGrid.UltraGridBand("macchine_Custumer", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn36 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCliente");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn37 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("nome");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn38 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("macchina");
            Infragistics.Win.Appearance appearance29 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance30 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance31 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance32 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance33 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance34 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance35 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance36 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance37 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance38 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance39 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("macchine", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn42 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMacchina");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn43 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("marca");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn44 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("modello");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn45 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("costo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn46 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("bollo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn47 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("benzina");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn48 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("immatricolazione");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn49 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("macchine_Custumer");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn50 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CostoTotale", 0);
            Infragistics.Win.UltraWinGrid.SummarySettings summarySettings1 = new Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Formula, "sum( [CostoTotale] )", null, -1, false, null, -1, Infragistics.Win.UltraWinGrid.SummaryPosition.Left, null, -1, false);
            Infragistics.Win.Appearance appearance17 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand3 = new Infragistics.Win.UltraWinGrid.UltraGridBand("macchine_Custumer", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn51 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCliente");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn52 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("nome");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn53 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("macchina");
            Infragistics.Win.Appearance appearance18 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance19 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance20 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance21 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance22 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance23 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance24 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance25 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance26 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance27 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("macchine_Custumer", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn39 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCliente");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn40 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("nome");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn41 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("macchina");
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
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn1 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCliente");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn2 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("nome");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn3 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("macchina");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn4 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMacchina");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn5 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("marca");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn6 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("modello");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn7 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("costo");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn8 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("bollo");
            this.ultraCurrencyEditor1 = new Infragistics.Win.UltraWinEditors.UltraCurrencyEditor();
            this.ultraProgressBar1 = new Infragistics.Win.UltraWinProgressBar.UltraProgressBar();
            this.ultraDateTimeEditor1 = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            this.ultraGridRowEditTemplate1 = new Infragistics.Win.UltraWinGrid.UltraGridRowEditTemplate();
            this.ugcpCostoTotale = new Infragistics.Win.UltraWinGrid.UltraGridCellProxy();
            this.lblCostoTotale = new Infragistics.Win.Misc.UltraLabel();
            this.ugcpimmatricolazione = new Infragistics.Win.UltraWinGrid.UltraGridCellProxy();
            this.lblimmatricolazione = new Infragistics.Win.Misc.UltraLabel();
            this.ugcpbenzina = new Infragistics.Win.UltraWinGrid.UltraGridCellProxy();
            this.lblbenzina = new Infragistics.Win.Misc.UltraLabel();
            this.ugcpbollo = new Infragistics.Win.UltraWinGrid.UltraGridCellProxy();
            this.lblbollo = new Infragistics.Win.Misc.UltraLabel();
            this.ugcpcosto = new Infragistics.Win.UltraWinGrid.UltraGridCellProxy();
            this.lblcosto = new Infragistics.Win.Misc.UltraLabel();
            this.ugcpmodello = new Infragistics.Win.UltraWinGrid.UltraGridCellProxy();
            this.lblmodello = new Infragistics.Win.Misc.UltraLabel();
            this.ugcpmarca = new Infragistics.Win.UltraWinGrid.UltraGridCellProxy();
            this.lblmarca = new Infragistics.Win.Misc.UltraLabel();
            this.ugcpIdMacchina = new Infragistics.Win.UltraWinGrid.UltraGridCellProxy();
            this.lblIdMacchina = new Infragistics.Win.Misc.UltraLabel();
            this.btnTemplateOk = new Infragistics.Win.Misc.UltraButton();
            this.btnTemplateCancel = new Infragistics.Win.Misc.UltraButton();
            this.ultraCombo1 = new Infragistics.Win.UltraWinGrid.UltraCombo();
            this.ultraCalcManager1 = new Infragistics.Win.UltraWinCalcManager.UltraCalcManager(this.components);
            this.macchineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new infraFormulaFiltri.DataSet1();
            this.ultraGrid1 = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.ubtSalva = new Infragistics.Win.Misc.UltraButton();
            this.ultraGridFilterUIProvider1 = new Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider(this.components);
            this.ultraGrid2 = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.macchineCustumerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ultraDataSource1 = new Infragistics.Win.UltraWinDataSource.UltraDataSource(this.components);
            this.ultraDataSource2 = new Infragistics.Win.UltraWinDataSource.UltraDataSource(this.components);
            this.macchineTableAdapter = new infraFormulaFiltri.DataSet1TableAdapters.macchineTableAdapter();
            this.custumerTableAdapter1 = new infraFormulaFiltri.DataSet1TableAdapters.CustumerTableAdapter();
            this.custumerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ultraCurrencyEditor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDateTimeEditor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGridRowEditTemplate1)).BeginInit();
            this.ultraGridRowEditTemplate1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCombo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCalcManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.macchineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.macchineCustumerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custumerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraCurrencyEditor1
            // 
            this.ultraCurrencyEditor1.Location = new System.Drawing.Point(121, 316);
            this.ultraCurrencyEditor1.Name = "ultraCurrencyEditor1";
            this.ultraCurrencyEditor1.Size = new System.Drawing.Size(100, 21);
            this.ultraCurrencyEditor1.TabIndex = 2;
            this.ultraCurrencyEditor1.Visible = false;
            // 
            // ultraProgressBar1
            // 
            this.ultraProgressBar1.Location = new System.Drawing.Point(121, 287);
            this.ultraProgressBar1.Name = "ultraProgressBar1";
            this.ultraProgressBar1.Size = new System.Drawing.Size(75, 23);
            this.ultraProgressBar1.TabIndex = 4;
            this.ultraProgressBar1.Text = "[Formatted]";
            this.ultraProgressBar1.Visible = false;
            // 
            // ultraDateTimeEditor1
            // 
            this.ultraDateTimeEditor1.Location = new System.Drawing.Point(688, 306);
            this.ultraDateTimeEditor1.Name = "ultraDateTimeEditor1";
            this.ultraDateTimeEditor1.Size = new System.Drawing.Size(144, 21);
            this.ultraDateTimeEditor1.TabIndex = 7;
            this.ultraDateTimeEditor1.Visible = false;
            // 
            // ultraGridRowEditTemplate1
            // 
            this.ultraGridRowEditTemplate1.AutoScroll = true;
            this.ultraGridRowEditTemplate1.BandHierarchyLevel = 0;
            this.ultraGridRowEditTemplate1.BandKey = "macchine";
            this.ultraGridRowEditTemplate1.ColumnData.Add(new Infragistics.Win.UltraWinGrid.UltraGridRowEditTemplate.ColumnDescriptorData("IdMacchina", typeof(int), "macchine", 0));
            this.ultraGridRowEditTemplate1.ColumnData.Add(new Infragistics.Win.UltraWinGrid.UltraGridRowEditTemplate.ColumnDescriptorData("marca", typeof(string), "macchine", 0));
            this.ultraGridRowEditTemplate1.ColumnData.Add(new Infragistics.Win.UltraWinGrid.UltraGridRowEditTemplate.ColumnDescriptorData("modello", typeof(string), "macchine", 0));
            this.ultraGridRowEditTemplate1.ColumnData.Add(new Infragistics.Win.UltraWinGrid.UltraGridRowEditTemplate.ColumnDescriptorData("costo", typeof(double), "macchine", 0));
            this.ultraGridRowEditTemplate1.ColumnData.Add(new Infragistics.Win.UltraWinGrid.UltraGridRowEditTemplate.ColumnDescriptorData("bollo", typeof(double), "macchine", 0));
            this.ultraGridRowEditTemplate1.ColumnData.Add(new Infragistics.Win.UltraWinGrid.UltraGridRowEditTemplate.ColumnDescriptorData("benzina", typeof(int), "macchine", 0));
            this.ultraGridRowEditTemplate1.ColumnData.Add(new Infragistics.Win.UltraWinGrid.UltraGridRowEditTemplate.ColumnDescriptorData("immatricolazione", typeof(System.DateTime), "macchine", 0));
            this.ultraGridRowEditTemplate1.ColumnData.Add(new Infragistics.Win.UltraWinGrid.UltraGridRowEditTemplate.ColumnDescriptorData("CostoTotale", typeof(double), "macchine", 0));
            this.ultraGridRowEditTemplate1.Controls.Add(this.ugcpCostoTotale);
            this.ultraGridRowEditTemplate1.Controls.Add(this.lblCostoTotale);
            this.ultraGridRowEditTemplate1.Controls.Add(this.ugcpimmatricolazione);
            this.ultraGridRowEditTemplate1.Controls.Add(this.lblimmatricolazione);
            this.ultraGridRowEditTemplate1.Controls.Add(this.ugcpbenzina);
            this.ultraGridRowEditTemplate1.Controls.Add(this.lblbenzina);
            this.ultraGridRowEditTemplate1.Controls.Add(this.ugcpbollo);
            this.ultraGridRowEditTemplate1.Controls.Add(this.lblbollo);
            this.ultraGridRowEditTemplate1.Controls.Add(this.ugcpcosto);
            this.ultraGridRowEditTemplate1.Controls.Add(this.lblcosto);
            this.ultraGridRowEditTemplate1.Controls.Add(this.ugcpmodello);
            this.ultraGridRowEditTemplate1.Controls.Add(this.lblmodello);
            this.ultraGridRowEditTemplate1.Controls.Add(this.ugcpmarca);
            this.ultraGridRowEditTemplate1.Controls.Add(this.lblmarca);
            this.ultraGridRowEditTemplate1.Controls.Add(this.ugcpIdMacchina);
            this.ultraGridRowEditTemplate1.Controls.Add(this.lblIdMacchina);
            this.ultraGridRowEditTemplate1.Controls.Add(this.btnTemplateOk);
            this.ultraGridRowEditTemplate1.Controls.Add(this.btnTemplateCancel);
            this.ultraGridRowEditTemplate1.DialogSettings.AcceptButton = this.btnTemplateOk;
            this.ultraGridRowEditTemplate1.DialogSettings.CancelButton = this.btnTemplateCancel;
            this.ultraGridRowEditTemplate1.Location = new System.Drawing.Point(121, 205);
            this.ultraGridRowEditTemplate1.Name = "ultraGridRowEditTemplate1";
            this.ultraGridRowEditTemplate1.Size = new System.Drawing.Size(504, 147);
            this.ultraGridRowEditTemplate1.TabIndex = 8;
            this.ultraGridRowEditTemplate1.Visible = false;
            // 
            // ugcpCostoTotale
            // 
            this.ugcpCostoTotale.ColumnKey = "CostoTotale";
            this.ugcpCostoTotale.Location = new System.Drawing.Point(340, 80);
            this.ugcpCostoTotale.Name = "ugcpCostoTotale";
            this.ugcpCostoTotale.Size = new System.Drawing.Size(120, 20);
            this.ugcpCostoTotale.TabIndex = 15;
            this.ugcpCostoTotale.Text = "CostoTotale";
            // 
            // lblCostoTotale
            // 
            this.lblCostoTotale.Location = new System.Drawing.Point(235, 80);
            this.lblCostoTotale.Name = "lblCostoTotale";
            this.lblCostoTotale.Size = new System.Drawing.Size(100, 20);
            this.lblCostoTotale.TabIndex = 14;
            this.lblCostoTotale.Tag = "CostoTotale";
            this.lblCostoTotale.Text = "CostoTotale:";
            // 
            // ugcpimmatricolazione
            // 
            this.ugcpimmatricolazione.ColumnKey = "immatricolazione";
            this.ugcpimmatricolazione.Location = new System.Drawing.Point(340, 55);
            this.ugcpimmatricolazione.Name = "ugcpimmatricolazione";
            this.ugcpimmatricolazione.Size = new System.Drawing.Size(120, 20);
            this.ugcpimmatricolazione.TabIndex = 13;
            this.ugcpimmatricolazione.Text = "immatricolazione";
            // 
            // lblimmatricolazione
            // 
            this.lblimmatricolazione.Location = new System.Drawing.Point(235, 55);
            this.lblimmatricolazione.Name = "lblimmatricolazione";
            this.lblimmatricolazione.Size = new System.Drawing.Size(100, 20);
            this.lblimmatricolazione.TabIndex = 12;
            this.lblimmatricolazione.Tag = "immatricolazione";
            this.lblimmatricolazione.Text = "immatricolazione:";
            // 
            // ugcpbenzina
            // 
            this.ugcpbenzina.ColumnKey = "benzina";
            this.ugcpbenzina.Location = new System.Drawing.Point(340, 30);
            this.ugcpbenzina.Name = "ugcpbenzina";
            this.ugcpbenzina.Size = new System.Drawing.Size(120, 20);
            this.ugcpbenzina.TabIndex = 11;
            this.ugcpbenzina.Text = "benzina";
            // 
            // lblbenzina
            // 
            this.lblbenzina.Location = new System.Drawing.Point(235, 30);
            this.lblbenzina.Name = "lblbenzina";
            this.lblbenzina.Size = new System.Drawing.Size(100, 20);
            this.lblbenzina.TabIndex = 10;
            this.lblbenzina.Tag = "benzina";
            this.lblbenzina.Text = "benzina:";
            // 
            // ugcpbollo
            // 
            this.ugcpbollo.ColumnKey = "bollo";
            this.ugcpbollo.Location = new System.Drawing.Point(340, 5);
            this.ugcpbollo.Name = "ugcpbollo";
            this.ugcpbollo.Size = new System.Drawing.Size(120, 20);
            this.ugcpbollo.TabIndex = 9;
            this.ugcpbollo.Text = "bollo";
            // 
            // lblbollo
            // 
            this.lblbollo.Location = new System.Drawing.Point(235, 5);
            this.lblbollo.Name = "lblbollo";
            this.lblbollo.Size = new System.Drawing.Size(100, 20);
            this.lblbollo.TabIndex = 8;
            this.lblbollo.Tag = "bollo";
            this.lblbollo.Text = "bollo:";
            // 
            // ugcpcosto
            // 
            this.ugcpcosto.ColumnKey = "costo";
            this.ugcpcosto.Location = new System.Drawing.Point(110, 80);
            this.ugcpcosto.Name = "ugcpcosto";
            this.ugcpcosto.Size = new System.Drawing.Size(120, 20);
            this.ugcpcosto.TabIndex = 7;
            this.ugcpcosto.Text = "costo";
            // 
            // lblcosto
            // 
            this.lblcosto.Location = new System.Drawing.Point(5, 80);
            this.lblcosto.Name = "lblcosto";
            this.lblcosto.Size = new System.Drawing.Size(100, 20);
            this.lblcosto.TabIndex = 6;
            this.lblcosto.Tag = "costo";
            this.lblcosto.Text = "costo:";
            // 
            // ugcpmodello
            // 
            this.ugcpmodello.ColumnKey = "modello";
            this.ugcpmodello.Location = new System.Drawing.Point(110, 55);
            this.ugcpmodello.Name = "ugcpmodello";
            this.ugcpmodello.Size = new System.Drawing.Size(120, 20);
            this.ugcpmodello.TabIndex = 5;
            this.ugcpmodello.Text = "modello";
            // 
            // lblmodello
            // 
            this.lblmodello.Location = new System.Drawing.Point(5, 55);
            this.lblmodello.Name = "lblmodello";
            this.lblmodello.Size = new System.Drawing.Size(100, 20);
            this.lblmodello.TabIndex = 4;
            this.lblmodello.Tag = "modello";
            this.lblmodello.Text = "modello:";
            // 
            // ugcpmarca
            // 
            this.ugcpmarca.ColumnKey = "marca";
            this.ugcpmarca.Location = new System.Drawing.Point(110, 30);
            this.ugcpmarca.Name = "ugcpmarca";
            this.ugcpmarca.Size = new System.Drawing.Size(120, 20);
            this.ugcpmarca.TabIndex = 3;
            this.ugcpmarca.Text = "marca";
            // 
            // lblmarca
            // 
            this.lblmarca.Location = new System.Drawing.Point(5, 30);
            this.lblmarca.Name = "lblmarca";
            this.lblmarca.Size = new System.Drawing.Size(100, 20);
            this.lblmarca.TabIndex = 2;
            this.lblmarca.Tag = "marca";
            this.lblmarca.Text = "marca:";
            // 
            // ugcpIdMacchina
            // 
            this.ugcpIdMacchina.ColumnKey = "IdMacchina";
            this.ugcpIdMacchina.Location = new System.Drawing.Point(110, 5);
            this.ugcpIdMacchina.Name = "ugcpIdMacchina";
            this.ugcpIdMacchina.Size = new System.Drawing.Size(120, 20);
            this.ugcpIdMacchina.TabIndex = 1;
            this.ugcpIdMacchina.Text = "IdMacchina";
            // 
            // lblIdMacchina
            // 
            this.lblIdMacchina.Location = new System.Drawing.Point(5, 5);
            this.lblIdMacchina.Name = "lblIdMacchina";
            this.lblIdMacchina.Size = new System.Drawing.Size(100, 20);
            this.lblIdMacchina.TabIndex = 0;
            this.lblIdMacchina.Tag = "IdMacchina";
            this.lblIdMacchina.Text = "IdMacchina:";
            // 
            // btnTemplateOk
            // 
            this.btnTemplateOk.Location = new System.Drawing.Point(5, 105);
            this.btnTemplateOk.Name = "btnTemplateOk";
            this.btnTemplateOk.Size = new System.Drawing.Size(75, 23);
            this.btnTemplateOk.TabIndex = 16;
            this.btnTemplateOk.Text = "&OK";
            this.btnTemplateOk.Click += new System.EventHandler(this.btnTemplateOk_Click_2);
            // 
            // btnTemplateCancel
            // 
            this.btnTemplateCancel.Location = new System.Drawing.Point(85, 105);
            this.btnTemplateCancel.Name = "btnTemplateCancel";
            this.btnTemplateCancel.Size = new System.Drawing.Size(75, 23);
            this.btnTemplateCancel.TabIndex = 17;
            this.btnTemplateCancel.Text = "&Cancel";
            this.btnTemplateCancel.Click += new System.EventHandler(this.btnTemplateCancel_Click_2);
            // 
            // ultraCombo1
            // 
            this.ultraCombo1.CalcManager = this.ultraCalcManager1;
            this.ultraCombo1.DataSource = this.macchineBindingSource;
            appearance28.BackColor = System.Drawing.SystemColors.Window;
            appearance28.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.ultraCombo1.DisplayLayout.Appearance = appearance28;
            ultraGridColumn28.Header.VisiblePosition = 0;
            ultraGridColumn29.Header.VisiblePosition = 1;
            ultraGridColumn30.Header.VisiblePosition = 2;
            ultraGridColumn31.Header.VisiblePosition = 3;
            ultraGridColumn32.Header.VisiblePosition = 4;
            ultraGridColumn33.Header.VisiblePosition = 5;
            ultraGridColumn34.Header.VisiblePosition = 6;
            ultraGridColumn35.Header.VisiblePosition = 7;
            ultraGridBand4.Columns.AddRange(new object[] {
            ultraGridColumn28,
            ultraGridColumn29,
            ultraGridColumn30,
            ultraGridColumn31,
            ultraGridColumn32,
            ultraGridColumn33,
            ultraGridColumn34,
            ultraGridColumn35});
            ultraGridColumn36.Header.VisiblePosition = 0;
            ultraGridColumn37.Header.VisiblePosition = 1;
            ultraGridColumn38.Header.VisiblePosition = 2;
            ultraGridBand5.Columns.AddRange(new object[] {
            ultraGridColumn36,
            ultraGridColumn37,
            ultraGridColumn38});
            this.ultraCombo1.DisplayLayout.BandsSerializer.Add(ultraGridBand4);
            this.ultraCombo1.DisplayLayout.BandsSerializer.Add(ultraGridBand5);
            this.ultraCombo1.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.ultraCombo1.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance29.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance29.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance29.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance29.BorderColor = System.Drawing.SystemColors.Window;
            this.ultraCombo1.DisplayLayout.GroupByBox.Appearance = appearance29;
            appearance30.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ultraCombo1.DisplayLayout.GroupByBox.BandLabelAppearance = appearance30;
            this.ultraCombo1.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            appearance31.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance31.BackColor2 = System.Drawing.SystemColors.Control;
            appearance31.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance31.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ultraCombo1.DisplayLayout.GroupByBox.PromptAppearance = appearance31;
            this.ultraCombo1.DisplayLayout.MaxColScrollRegions = 1;
            this.ultraCombo1.DisplayLayout.MaxRowScrollRegions = 1;
            appearance32.BackColor = System.Drawing.SystemColors.Window;
            appearance32.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ultraCombo1.DisplayLayout.Override.ActiveCellAppearance = appearance32;
            appearance33.BackColor = System.Drawing.SystemColors.Highlight;
            appearance33.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ultraCombo1.DisplayLayout.Override.ActiveRowAppearance = appearance33;
            this.ultraCombo1.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.ultraCombo1.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance34.BackColor = System.Drawing.SystemColors.Window;
            this.ultraCombo1.DisplayLayout.Override.CardAreaAppearance = appearance34;
            appearance35.BorderColor = System.Drawing.Color.Silver;
            appearance35.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.ultraCombo1.DisplayLayout.Override.CellAppearance = appearance35;
            this.ultraCombo1.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.ultraCombo1.DisplayLayout.Override.CellPadding = 0;
            appearance36.BackColor = System.Drawing.SystemColors.Control;
            appearance36.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance36.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance36.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance36.BorderColor = System.Drawing.SystemColors.Window;
            this.ultraCombo1.DisplayLayout.Override.GroupByRowAppearance = appearance36;
            appearance37.TextHAlignAsString = "Left";
            this.ultraCombo1.DisplayLayout.Override.HeaderAppearance = appearance37;
            this.ultraCombo1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.ultraCombo1.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance38.BackColor = System.Drawing.SystemColors.Window;
            appearance38.BorderColor = System.Drawing.Color.Silver;
            this.ultraCombo1.DisplayLayout.Override.RowAppearance = appearance38;
            this.ultraCombo1.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            appearance39.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ultraCombo1.DisplayLayout.Override.TemplateAddRowAppearance = appearance39;
            this.ultraCombo1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.ultraCombo1.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.ultraCombo1.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraCombo1.DisplayMember = "modello";
            this.ultraCombo1.Location = new System.Drawing.Point(688, 343);
            this.ultraCombo1.Name = "ultraCombo1";
            this.ultraCombo1.Size = new System.Drawing.Size(100, 22);
            this.ultraCombo1.TabIndex = 6;
            this.ultraCombo1.ValueMember = "IdMacchina";
            this.ultraCombo1.Visible = false;
            // 
            // ultraCalcManager1
            // 
            this.ultraCalcManager1.ContainingControl = this;
            // 
            // macchineBindingSource
            // 
            this.macchineBindingSource.DataMember = "macchine";
            this.macchineBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraGrid1
            // 
            this.ultraGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraGrid1.CalcManager = this.ultraCalcManager1;
            this.ultraGrid1.DataSource = this.macchineBindingSource;
            appearance16.BackColor = System.Drawing.Color.White;
            appearance16.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal;
            this.ultraGrid1.DisplayLayout.Appearance = appearance16;
            this.ultraGrid1.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn42.Header.VisiblePosition = 0;
            ultraGridColumn42.Hidden = true;
            ultraGridColumn42.Width = 223;
            ultraGridColumn43.Header.VisiblePosition = 1;
            ultraGridColumn43.Width = 62;
            ultraGridColumn44.Header.VisiblePosition = 2;
            ultraGridColumn44.Width = 82;
            ultraGridColumn45.EditorComponent = this.ultraCurrencyEditor1;
            ultraGridColumn45.Header.VisiblePosition = 3;
            ultraGridColumn45.Width = 37;
            ultraGridColumn46.EditorComponent = this.ultraCurrencyEditor1;
            ultraGridColumn46.Header.VisiblePosition = 4;
            ultraGridColumn46.Width = 37;
            ultraGridColumn47.EditorComponent = this.ultraProgressBar1;
            ultraGridColumn47.Header.VisiblePosition = 5;
            ultraGridColumn47.Width = 45;
            ultraGridColumn48.EditorComponent = this.ultraDateTimeEditor1;
            ultraGridColumn48.Header.VisiblePosition = 6;
            ultraGridColumn48.Width = 87;
            ultraGridColumn49.Header.VisiblePosition = 8;
            ultraGridColumn50.DataType = typeof(double);
            ultraGridColumn50.Format = "c2";
            ultraGridColumn50.Formula = "[costo] + [bollo]";
            ultraGridColumn50.Header.VisiblePosition = 7;
            ultraGridColumn50.Width = 33;
            ultraGridBand2.Columns.AddRange(new object[] {
            ultraGridColumn42,
            ultraGridColumn43,
            ultraGridColumn44,
            ultraGridColumn45,
            ultraGridColumn46,
            ultraGridColumn47,
            ultraGridColumn48,
            ultraGridColumn49,
            ultraGridColumn50});
            ultraGridBand2.RowEditTemplate = this.ultraGridRowEditTemplate1;
            appearance17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            appearance17.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            summarySettings1.Appearance = appearance17;
            ultraGridBand2.Summaries.AddRange(new Infragistics.Win.UltraWinGrid.SummarySettings[] {
            summarySettings1});
            ultraGridBand2.SummaryFooterCaption = "Costo Totale Concessionario";
            ultraGridColumn51.Header.VisiblePosition = 0;
            ultraGridColumn51.Width = 100;
            ultraGridColumn52.Header.VisiblePosition = 1;
            ultraGridColumn52.Width = 140;
            ultraGridColumn53.Header.VisiblePosition = 2;
            ultraGridColumn53.Width = 105;
            ultraGridBand3.Columns.AddRange(new object[] {
            ultraGridColumn51,
            ultraGridColumn52,
            ultraGridColumn53});
            this.ultraGrid1.DisplayLayout.BandsSerializer.Add(ultraGridBand2);
            this.ultraGrid1.DisplayLayout.BandsSerializer.Add(ultraGridBand3);
            appearance18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ultraGrid1.DisplayLayout.CaptionAppearance = appearance18;
            appearance19.BackColor = System.Drawing.Color.Teal;
            this.ultraGrid1.DisplayLayout.GroupByBox.Appearance = appearance19;
            this.ultraGrid1.DisplayLayout.InterBandSpacing = 10;
            this.ultraGrid1.DisplayLayout.MaxColScrollRegions = 1;
            this.ultraGrid1.DisplayLayout.MaxRowScrollRegions = 1;
            appearance20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ultraGrid1.DisplayLayout.Override.ActiveCellAppearance = appearance20;
            appearance21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ultraGrid1.DisplayLayout.Override.ActiveRowAppearance = appearance21;
            appearance22.BackColor = System.Drawing.Color.Yellow;
            this.ultraGrid1.DisplayLayout.Override.AddRowAppearance = appearance22;
            this.ultraGrid1.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraGrid1.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraGrid1.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.True;
            this.ultraGrid1.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance23.BackColor = System.Drawing.Color.Transparent;
            this.ultraGrid1.DisplayLayout.Override.CardAreaAppearance = appearance23;
            this.ultraGrid1.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.ultraGrid1.DisplayLayout.Override.FilterEvaluationTrigger = Infragistics.Win.UltraWinGrid.FilterEvaluationTrigger.OnCellValueChange;
            this.ultraGrid1.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow;
            appearance24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            appearance24.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            appearance24.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance24.ForeColor = System.Drawing.Color.Black;
            appearance24.TextHAlignAsString = "Left";
            appearance24.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraGrid1.DisplayLayout.Override.HeaderAppearance = appearance24;
            this.ultraGrid1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            appearance25.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            this.ultraGrid1.DisplayLayout.Override.RowAppearance = appearance25;
            this.ultraGrid1.DisplayLayout.Override.RowFilterAction = Infragistics.Win.UltraWinGrid.RowFilterAction.HideFilteredOutRows;
            this.ultraGrid1.DisplayLayout.Override.RowFilterMode = Infragistics.Win.UltraWinGrid.RowFilterMode.AllRowsInBand;
            appearance26.BackColor = System.Drawing.Color.Red;
            appearance26.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            appearance26.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance26.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ultraGrid1.DisplayLayout.Override.RowSelectorAppearance = appearance26;
            this.ultraGrid1.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton;
            this.ultraGrid1.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex;
            this.ultraGrid1.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True;
            this.ultraGrid1.DisplayLayout.Override.RowSelectorWidth = 12;
            this.ultraGrid1.DisplayLayout.Override.RowSpacingBefore = 2;
            appearance27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            appearance27.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            appearance27.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance27.ForeColor = System.Drawing.Color.Black;
            this.ultraGrid1.DisplayLayout.Override.SelectedRowAppearance = appearance27;
            this.ultraGrid1.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.Bottom;
            this.ultraGrid1.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            this.ultraGrid1.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraGrid1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.ultraGrid1.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.ultraGrid1.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand;
            this.ultraGrid1.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraGrid1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraGrid1.Location = new System.Drawing.Point(0, 2);
            this.ultraGrid1.Name = "ultraGrid1";
            this.ultraGrid1.Size = new System.Drawing.Size(397, 448);
            this.ultraGrid1.TabIndex = 0;
            this.ultraGrid1.InitializeLayout += new Infragistics.Win.UltraWinGrid.InitializeLayoutEventHandler(this.ultraGrid1_InitializeLayout_1);
            this.ultraGrid1.AfterExitEditMode += new System.EventHandler(this.ultraGrid1_AfterExitEditMode);
            this.ultraGrid1.ClickCell += new Infragistics.Win.UltraWinGrid.ClickCellEventHandler(this.ultraGrid1_ClickCell);
            // 
            // ubtSalva
            // 
            appearance15.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ubtSalva.Appearance = appearance15;
            this.ubtSalva.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Button3D;
            this.ubtSalva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ubtSalva.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ubtSalva.Location = new System.Drawing.Point(0, 415);
            this.ubtSalva.Name = "ubtSalva";
            this.ubtSalva.Size = new System.Drawing.Size(800, 35);
            this.ubtSalva.TabIndex = 1;
            this.ubtSalva.Text = "SALVA ED ESCI";
            this.ubtSalva.UseOsThemes = Infragistics.Win.DefaultableBoolean.False;
            this.ubtSalva.Click += new System.EventHandler(this.ubtSalva_Click);
            // 
            // ultraGrid2
            // 
            this.ultraGrid2.CalcManager = this.ultraCalcManager1;
            this.ultraGrid2.DataSource = this.macchineCustumerBindingSource;
            appearance1.BackColor = System.Drawing.SystemColors.Window;
            appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.ultraGrid2.DisplayLayout.Appearance = appearance1;
            ultraGridBand1.CardView = true;
            ultraGridColumn39.Header.VisiblePosition = 0;
            ultraGridColumn40.Header.VisiblePosition = 1;
            ultraGridColumn41.EditorComponent = this.ultraCombo1;
            ultraGridColumn41.Header.VisiblePosition = 2;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn39,
            ultraGridColumn40,
            ultraGridColumn41});
            this.ultraGrid2.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.ultraGrid2.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.ultraGrid2.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ultraGrid2.DisplayLayout.EmptyRowSettings.RowAppearance = appearance2;
            appearance3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance3.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance3.BorderColor = System.Drawing.SystemColors.Window;
            this.ultraGrid2.DisplayLayout.GroupByBox.Appearance = appearance3;
            appearance4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ultraGrid2.DisplayLayout.GroupByBox.BandLabelAppearance = appearance4;
            this.ultraGrid2.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            appearance5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance5.BackColor2 = System.Drawing.SystemColors.Control;
            appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ultraGrid2.DisplayLayout.GroupByBox.PromptAppearance = appearance5;
            this.ultraGrid2.DisplayLayout.MaxColScrollRegions = 1;
            this.ultraGrid2.DisplayLayout.MaxRowScrollRegions = 1;
            appearance6.BackColor = System.Drawing.SystemColors.Window;
            appearance6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ultraGrid2.DisplayLayout.Override.ActiveCellAppearance = appearance6;
            appearance7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            appearance7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ultraGrid2.DisplayLayout.Override.ActiveRowAppearance = appearance7;
            appearance8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ultraGrid2.DisplayLayout.Override.AddRowAppearance = appearance8;
            this.ultraGrid2.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.ultraGrid2.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance9.BackColor = System.Drawing.SystemColors.Window;
            this.ultraGrid2.DisplayLayout.Override.CardAreaAppearance = appearance9;
            appearance10.BorderColor = System.Drawing.Color.Silver;
            appearance10.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.ultraGrid2.DisplayLayout.Override.CellAppearance = appearance10;
            this.ultraGrid2.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.ultraGrid2.DisplayLayout.Override.CellPadding = 0;
            appearance11.BackColor = System.Drawing.SystemColors.Control;
            appearance11.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance11.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance11.BorderColor = System.Drawing.SystemColors.Window;
            this.ultraGrid2.DisplayLayout.Override.GroupByRowAppearance = appearance11;
            appearance12.BackColor = System.Drawing.Color.Silver;
            appearance12.TextHAlignAsString = "Left";
            this.ultraGrid2.DisplayLayout.Override.HeaderAppearance = appearance12;
            this.ultraGrid2.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.ultraGrid2.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            appearance13.BorderColor = System.Drawing.Color.Silver;
            this.ultraGrid2.DisplayLayout.Override.RowAppearance = appearance13;
            this.ultraGrid2.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton;
            this.ultraGrid2.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            appearance14.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ultraGrid2.DisplayLayout.Override.TemplateAddRowAppearance = appearance14;
            this.ultraGrid2.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.ultraGrid2.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.ultraGrid2.Dock = System.Windows.Forms.DockStyle.Right;
            this.ultraGrid2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraGrid2.Location = new System.Drawing.Point(397, 0);
            this.ultraGrid2.Name = "ultraGrid2";
            this.ultraGrid2.Size = new System.Drawing.Size(403, 415);
            this.ultraGrid2.TabIndex = 3;
            this.ultraGrid2.Text = "ultraGrid2";
            // 
            // macchineCustumerBindingSource
            // 
            this.macchineCustumerBindingSource.DataMember = "macchine_Custumer";
            this.macchineCustumerBindingSource.DataSource = this.macchineBindingSource;
            // 
            // ultraDataSource1
            // 
            ultraDataColumn1.DataType = typeof(int);
            ultraDataColumn3.DataType = typeof(int);
            this.ultraDataSource1.Band.Columns.AddRange(new object[] {
            ultraDataColumn1,
            ultraDataColumn2,
            ultraDataColumn3});
            this.ultraDataSource1.Band.Key = "Custumer";
            // 
            // ultraDataSource2
            // 
            ultraDataColumn4.DataType = typeof(int);
            ultraDataColumn7.DataType = typeof(double);
            ultraDataColumn8.DataType = typeof(double);
            this.ultraDataSource2.Band.Columns.AddRange(new object[] {
            ultraDataColumn4,
            ultraDataColumn5,
            ultraDataColumn6,
            ultraDataColumn7,
            ultraDataColumn8});
            this.ultraDataSource2.Band.Key = "macchine";
            // 
            // macchineTableAdapter
            // 
            this.macchineTableAdapter.ClearBeforeFill = true;
            // 
            // custumerTableAdapter1
            // 
            this.custumerTableAdapter1.ClearBeforeFill = true;
            // 
            // custumerBindingSource
            // 
            this.custumerBindingSource.DataMember = "Custumer";
            this.custumerBindingSource.DataSource = this.dataSet1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ultraGridRowEditTemplate1);
            this.Controls.Add(this.ultraDateTimeEditor1);
            this.Controls.Add(this.ultraCombo1);
            this.Controls.Add(this.ultraProgressBar1);
            this.Controls.Add(this.ultraGrid2);
            this.Controls.Add(this.ultraCurrencyEditor1);
            this.Controls.Add(this.ubtSalva);
            this.Controls.Add(this.ultraGrid1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ultraCurrencyEditor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDateTimeEditor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGridRowEditTemplate1)).EndInit();
            this.ultraGridRowEditTemplate1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraCombo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCalcManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.macchineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.macchineCustumerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custumerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infragistics.Win.UltraWinGrid.UltraGrid ultraGrid1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource macchineBindingSource;
        private DataSet1TableAdapters.macchineTableAdapter macchineTableAdapter;
        private DataSet1TableAdapters.CustumerTableAdapter custumerTableAdapter1;
        private Infragistics.Win.UltraWinCalcManager.UltraCalcManager ultraCalcManager1;
        private Infragistics.Win.Misc.UltraButton ubtSalva;
        private Infragistics.Win.UltraWinEditors.UltraCurrencyEditor ultraCurrencyEditor1;
        private Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider ultraGridFilterUIProvider1;
        private Infragistics.Win.UltraWinGrid.UltraGrid ultraGrid2;
        private System.Windows.Forms.BindingSource custumerBindingSource;
        private Infragistics.Win.UltraWinDataSource.UltraDataSource ultraDataSource1;
        private System.Windows.Forms.BindingSource macchineCustumerBindingSource;
        private Infragistics.Win.UltraWinDataSource.UltraDataSource ultraDataSource2;
        private Infragistics.Win.UltraWinProgressBar.UltraProgressBar ultraProgressBar1;
        private Infragistics.Win.UltraWinGrid.UltraCombo ultraCombo1;
        private Infragistics.Win.UltraWinGrid.UltraGridRowEditTemplate ultraGridRowEditTemplate1;
        private Infragistics.Win.UltraWinGrid.UltraGridCellProxy ugcpCostoTotale;
        private Infragistics.Win.Misc.UltraLabel lblCostoTotale;
        private Infragistics.Win.UltraWinGrid.UltraGridCellProxy ugcpimmatricolazione;
        private Infragistics.Win.Misc.UltraLabel lblimmatricolazione;
        private Infragistics.Win.UltraWinGrid.UltraGridCellProxy ugcpbenzina;
        private Infragistics.Win.Misc.UltraLabel lblbenzina;
        private Infragistics.Win.UltraWinGrid.UltraGridCellProxy ugcpbollo;
        private Infragistics.Win.Misc.UltraLabel lblbollo;
        private Infragistics.Win.UltraWinGrid.UltraGridCellProxy ugcpcosto;
        private Infragistics.Win.Misc.UltraLabel lblcosto;
        private Infragistics.Win.UltraWinGrid.UltraGridCellProxy ugcpmodello;
        private Infragistics.Win.Misc.UltraLabel lblmodello;
        private Infragistics.Win.UltraWinGrid.UltraGridCellProxy ugcpmarca;
        private Infragistics.Win.Misc.UltraLabel lblmarca;
        private Infragistics.Win.UltraWinGrid.UltraGridCellProxy ugcpIdMacchina;
        private Infragistics.Win.Misc.UltraLabel lblIdMacchina;
        private Infragistics.Win.Misc.UltraButton btnTemplateOk;
        private Infragistics.Win.Misc.UltraButton btnTemplateCancel;
        private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor ultraDateTimeEditor1;
    }
}

