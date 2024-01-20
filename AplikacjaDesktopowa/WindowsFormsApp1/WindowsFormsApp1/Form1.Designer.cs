namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bAZAMALARNIADataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewZlecenieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DODAJZLECENIE = new System.Windows.Forms.Button();
            this.multipage = new System.Windows.Forms.TabControl();
            this.tabZLECENIE = new System.Windows.Forms.TabPage();
            this.btnEDYTZLEC = new System.Windows.Forms.Button();
            this.btnPOKAZZLEC = new System.Windows.Forms.Button();
            this.dgvZLECENIE = new System.Windows.Forms.DataGridView();
            this.tabOPERACJETECHNOLOGICZNE = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numZUZMAT = new System.Windows.Forms.NumericUpDown();
            this.numCZASOP = new System.Windows.Forms.NumericUpDown();
            this.dtDATAOPERACJI = new System.Windows.Forms.DateTimePicker();
            this.cbWOPERACJI = new System.Windows.Forms.ComboBox();
            this.oPERACJEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bAZA_MALARNIADataSet9 = new WindowsFormsApp1.BAZA_MALARNIADataSet9();
            this.dgvOPERACJE = new System.Windows.Forms.DataGridView();
            this.btnDODAJOPER = new System.Windows.Forms.Button();
            this.cbNRZLECENIA = new System.Windows.Forms.ComboBox();
            this.zLECENIABindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.wYSZUKANIE_OPERACJI_ZLECENIA = new WindowsFormsApp1.WYSZUKANIE_OPERACJI_ZLECENIA();
            this.tabSLOWNIKDANYCH = new System.Windows.Forms.TabPage();
            this.tbDOPERACJE = new System.Windows.Forms.TextBox();
            this.tbDSTATUS = new System.Windows.Forms.TextBox();
            this.tbDTYPRAL = new System.Windows.Forms.TextBox();
            this.tbDPOLYSK = new System.Windows.Forms.TextBox();
            this.tbDPOWIERZCHNIA = new System.Windows.Forms.TextBox();
            this.tbDKLIENT = new System.Windows.Forms.TextBox();
            this.tbDRAL = new System.Windows.Forms.TextBox();
            this.tbDDOSTAWCE = new System.Windows.Forms.TextBox();
            this.btnDODAJOPERACJE = new System.Windows.Forms.Button();
            this.btnDODAJSTATUS = new System.Windows.Forms.Button();
            this.btnDODAJTYP = new System.Windows.Forms.Button();
            this.btnDODAJPOLYSK = new System.Windows.Forms.Button();
            this.btnDODAJPOWIERZCHNIE = new System.Windows.Forms.Button();
            this.btnDODAJKLIENT = new System.Windows.Forms.Button();
            this.btnDODAJRAL = new System.Windows.Forms.Button();
            this.btnDODAJDOSTAWCA = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpPLAN = new System.Windows.Forms.DateTimePicker();
            this.btnDODAJDOPLANU = new System.Windows.Forms.Button();
            this.cbIDDOPLANU = new System.Windows.Forms.ComboBox();
            this.btnDODAJPLAN = new System.Windows.Forms.Button();
            this.dtgPLAN = new System.Windows.Forms.DataGridView();
            this.cbPLAN = new System.Windows.Forms.ComboBox();
            this.pLANZLECENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bAZA_MALARNIADataSet26 = new WindowsFormsApp1.BAZA_MALARNIADataSet26();
            this.dANEOPERACJIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bAZA_MALARNIADataSet22 = new WindowsFormsApp1.BAZA_MALARNIADataSet22();
            this.oPERACJEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bAZA_MALARNIADataSet20 = new WindowsFormsApp1.BAZA_MALARNIADataSet20();
            this.viewZlecenieBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bAZA_MALARNIADataSet2 = new WindowsFormsApp1.BAZA_MALARNIADataSet2();
            this.view_ZlecenieTableAdapter1 = new WindowsFormsApp1.BAZA_MALARNIADataSet2TableAdapters.View_ZlecenieTableAdapter();
            this.bAZA_MALARNIADataSet8 = new WindowsFormsApp1.BAZA_MALARNIADataSet8();
            this.zLECENIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zLECENIATableAdapter = new WindowsFormsApp1.BAZA_MALARNIADataSet8TableAdapters.ZLECENIATableAdapter();
            this.zLECENIATableAdapter1 = new WindowsFormsApp1.WYSZUKANIE_OPERACJI_ZLECENIATableAdapters.ZLECENIATableAdapter();
            this.oPERACJETableAdapter = new WindowsFormsApp1.BAZA_MALARNIADataSet9TableAdapters.OPERACJETableAdapter();
            this.oPERACJETableAdapter1 = new WindowsFormsApp1.BAZA_MALARNIADataSet20TableAdapters.OPERACJETableAdapter();
            this.dANE_OPERACJITableAdapter = new WindowsFormsApp1.BAZA_MALARNIADataSet22TableAdapters.DANE_OPERACJITableAdapter();
            this.pLAN_ZLECENTableAdapter = new WindowsFormsApp1.BAZA_MALARNIADataSet26TableAdapters.PLAN_ZLECENTableAdapter();
            this.btnWYDZLECEN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bAZAMALARNIADataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewZlecenieBindingSource)).BeginInit();
            this.multipage.SuspendLayout();
            this.tabZLECENIE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZLECENIE)).BeginInit();
            this.tabOPERACJETECHNOLOGICZNE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numZUZMAT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCZASOP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPERACJEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAZA_MALARNIADataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOPERACJE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zLECENIABindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wYSZUKANIE_OPERACJI_ZLECENIA)).BeginInit();
            this.tabSLOWNIKDANYCH.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPLAN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLANZLECENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAZA_MALARNIADataSet26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dANEOPERACJIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAZA_MALARNIADataSet22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPERACJEBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAZA_MALARNIADataSet20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewZlecenieBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAZA_MALARNIADataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAZA_MALARNIADataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zLECENIABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // viewZlecenieBindingSource
            // 
            this.viewZlecenieBindingSource.DataMember = "View_Zlecenie";
            // 
            // DODAJZLECENIE
            // 
            this.DODAJZLECENIE.Location = new System.Drawing.Point(176, 19);
            this.DODAJZLECENIE.Name = "DODAJZLECENIE";
            this.DODAJZLECENIE.Size = new System.Drawing.Size(97, 23);
            this.DODAJZLECENIE.TabIndex = 6;
            this.DODAJZLECENIE.Text = "Dodaj Zlecenie";
            this.DODAJZLECENIE.UseVisualStyleBackColor = true;
            this.DODAJZLECENIE.Click += new System.EventHandler(this.DODAJZLECENIE_Click);
            // 
            // multipage
            // 
            this.multipage.Controls.Add(this.tabZLECENIE);
            this.multipage.Controls.Add(this.tabOPERACJETECHNOLOGICZNE);
            this.multipage.Controls.Add(this.tabSLOWNIKDANYCH);
            this.multipage.Controls.Add(this.tabPage1);
            this.multipage.Location = new System.Drawing.Point(12, 12);
            this.multipage.Name = "multipage";
            this.multipage.SelectedIndex = 0;
            this.multipage.Size = new System.Drawing.Size(1118, 461);
            this.multipage.TabIndex = 7;
            // 
            // tabZLECENIE
            // 
            this.tabZLECENIE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabZLECENIE.Controls.Add(this.btnWYDZLECEN);
            this.tabZLECENIE.Controls.Add(this.btnEDYTZLEC);
            this.tabZLECENIE.Controls.Add(this.btnPOKAZZLEC);
            this.tabZLECENIE.Controls.Add(this.dgvZLECENIE);
            this.tabZLECENIE.Controls.Add(this.DODAJZLECENIE);
            this.tabZLECENIE.Location = new System.Drawing.Point(4, 22);
            this.tabZLECENIE.Name = "tabZLECENIE";
            this.tabZLECENIE.Padding = new System.Windows.Forms.Padding(3);
            this.tabZLECENIE.Size = new System.Drawing.Size(1110, 435);
            this.tabZLECENIE.TabIndex = 0;
            this.tabZLECENIE.Text = "ZLECENIE";
            // 
            // btnEDYTZLEC
            // 
            this.btnEDYTZLEC.Location = new System.Drawing.Point(291, 19);
            this.btnEDYTZLEC.Name = "btnEDYTZLEC";
            this.btnEDYTZLEC.Size = new System.Drawing.Size(94, 23);
            this.btnEDYTZLEC.TabIndex = 9;
            this.btnEDYTZLEC.Text = "Edytuj Zlecenie";
            this.btnEDYTZLEC.UseVisualStyleBackColor = true;
            this.btnEDYTZLEC.Click += new System.EventHandler(this.btnEDYTZLEC_Click);
            // 
            // btnPOKAZZLEC
            // 
            this.btnPOKAZZLEC.Location = new System.Drawing.Point(22, 19);
            this.btnPOKAZZLEC.Name = "btnPOKAZZLEC";
            this.btnPOKAZZLEC.Size = new System.Drawing.Size(137, 23);
            this.btnPOKAZZLEC.TabIndex = 8;
            this.btnPOKAZZLEC.Text = "Wyświetl Zlecenia";
            this.btnPOKAZZLEC.UseVisualStyleBackColor = true;
            this.btnPOKAZZLEC.Click += new System.EventHandler(this.btnPOKAZZLEC_Click);
            // 
            // dgvZLECENIE
            // 
            this.dgvZLECENIE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZLECENIE.Location = new System.Drawing.Point(22, 48);
            this.dgvZLECENIE.Name = "dgvZLECENIE";
            this.dgvZLECENIE.ReadOnly = true;
            this.dgvZLECENIE.Size = new System.Drawing.Size(1064, 365);
            this.dgvZLECENIE.TabIndex = 7;
            // 
            // tabOPERACJETECHNOLOGICZNE
            // 
            this.tabOPERACJETECHNOLOGICZNE.BackColor = System.Drawing.SystemColors.Control;
            this.tabOPERACJETECHNOLOGICZNE.Controls.Add(this.label9);
            this.tabOPERACJETECHNOLOGICZNE.Controls.Add(this.label4);
            this.tabOPERACJETECHNOLOGICZNE.Controls.Add(this.label3);
            this.tabOPERACJETECHNOLOGICZNE.Controls.Add(this.label2);
            this.tabOPERACJETECHNOLOGICZNE.Controls.Add(this.label1);
            this.tabOPERACJETECHNOLOGICZNE.Controls.Add(this.numZUZMAT);
            this.tabOPERACJETECHNOLOGICZNE.Controls.Add(this.numCZASOP);
            this.tabOPERACJETECHNOLOGICZNE.Controls.Add(this.dtDATAOPERACJI);
            this.tabOPERACJETECHNOLOGICZNE.Controls.Add(this.cbWOPERACJI);
            this.tabOPERACJETECHNOLOGICZNE.Controls.Add(this.dgvOPERACJE);
            this.tabOPERACJETECHNOLOGICZNE.Controls.Add(this.btnDODAJOPER);
            this.tabOPERACJETECHNOLOGICZNE.Controls.Add(this.cbNRZLECENIA);
            this.tabOPERACJETECHNOLOGICZNE.Location = new System.Drawing.Point(4, 22);
            this.tabOPERACJETECHNOLOGICZNE.Name = "tabOPERACJETECHNOLOGICZNE";
            this.tabOPERACJETECHNOLOGICZNE.Padding = new System.Windows.Forms.Padding(3);
            this.tabOPERACJETECHNOLOGICZNE.Size = new System.Drawing.Size(1110, 435);
            this.tabOPERACJETECHNOLOGICZNE.TabIndex = 1;
            this.tabOPERACJETECHNOLOGICZNE.Text = "OPERACJE TECHNOLOGICZNE";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(362, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Wyszukaj Operacje Zlecenia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(767, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Zużycie materiału [kg]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(766, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Czas Operacji [min]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(765, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Data wykonanej Operacji";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(765, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nazwa Operacji ";
            // 
            // numZUZMAT
            // 
            this.numZUZMAT.DecimalPlaces = 2;
            this.numZUZMAT.Location = new System.Drawing.Point(768, 326);
            this.numZUZMAT.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numZUZMAT.Name = "numZUZMAT";
            this.numZUZMAT.Size = new System.Drawing.Size(120, 20);
            this.numZUZMAT.TabIndex = 7;
            // 
            // numCZASOP
            // 
            this.numCZASOP.Location = new System.Drawing.Point(768, 274);
            this.numCZASOP.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numCZASOP.Name = "numCZASOP";
            this.numCZASOP.Size = new System.Drawing.Size(120, 20);
            this.numCZASOP.TabIndex = 6;
            // 
            // dtDATAOPERACJI
            // 
            this.dtDATAOPERACJI.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDATAOPERACJI.Location = new System.Drawing.Point(768, 223);
            this.dtDATAOPERACJI.Name = "dtDATAOPERACJI";
            this.dtDATAOPERACJI.Size = new System.Drawing.Size(120, 20);
            this.dtDATAOPERACJI.TabIndex = 5;
            // 
            // cbWOPERACJI
            // 
            this.cbWOPERACJI.DataSource = this.oPERACJEBindingSource;
            this.cbWOPERACJI.DisplayMember = "NAZWA_OPERACJI";
            this.cbWOPERACJI.FormattingEnabled = true;
            this.cbWOPERACJI.Location = new System.Drawing.Point(768, 171);
            this.cbWOPERACJI.Name = "cbWOPERACJI";
            this.cbWOPERACJI.Size = new System.Drawing.Size(120, 21);
            this.cbWOPERACJI.TabIndex = 4;
            this.cbWOPERACJI.ValueMember = "ID_OPERACJI";
            // 
            // oPERACJEBindingSource
            // 
            this.oPERACJEBindingSource.DataMember = "OPERACJE";
            this.oPERACJEBindingSource.DataSource = this.bAZA_MALARNIADataSet9;
            // 
            // bAZA_MALARNIADataSet9
            // 
            this.bAZA_MALARNIADataSet9.DataSetName = "BAZA_MALARNIADataSet9";
            this.bAZA_MALARNIADataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvOPERACJE
            // 
            this.dgvOPERACJE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOPERACJE.Location = new System.Drawing.Point(226, 96);
            this.dgvOPERACJE.Name = "dgvOPERACJE";
            this.dgvOPERACJE.Size = new System.Drawing.Size(438, 250);
            this.dgvOPERACJE.TabIndex = 3;
            // 
            // btnDODAJOPER
            // 
            this.btnDODAJOPER.Location = new System.Drawing.Point(750, 96);
            this.btnDODAJOPER.Name = "btnDODAJOPER";
            this.btnDODAJOPER.Size = new System.Drawing.Size(160, 36);
            this.btnDODAJOPER.TabIndex = 2;
            this.btnDODAJOPER.Text = "Dodaj Operacje Do Wybraniego Zlecenia";
            this.btnDODAJOPER.UseVisualStyleBackColor = true;
            this.btnDODAJOPER.Click += new System.EventHandler(this.btnDODAJOPER_Click);
            // 
            // cbNRZLECENIA
            // 
            this.cbNRZLECENIA.DataSource = this.zLECENIABindingSource1;
            this.cbNRZLECENIA.DisplayMember = "NR_ZLECENIA";
            this.cbNRZLECENIA.FormattingEnabled = true;
            this.cbNRZLECENIA.Location = new System.Drawing.Point(365, 69);
            this.cbNRZLECENIA.Name = "cbNRZLECENIA";
            this.cbNRZLECENIA.Size = new System.Drawing.Size(140, 21);
            this.cbNRZLECENIA.TabIndex = 0;
            this.cbNRZLECENIA.ValueMember = "ID_ZLECENIA";
            this.cbNRZLECENIA.SelectedIndexChanged += new System.EventHandler(this.cbNRZLECENIA_SelectedIndexChanged);
            // 
            // zLECENIABindingSource1
            // 
            this.zLECENIABindingSource1.DataMember = "ZLECENIA";
            this.zLECENIABindingSource1.DataSource = this.wYSZUKANIE_OPERACJI_ZLECENIA;
            // 
            // wYSZUKANIE_OPERACJI_ZLECENIA
            // 
            this.wYSZUKANIE_OPERACJI_ZLECENIA.DataSetName = "WYSZUKANIE_OPERACJI_ZLECENIA";
            this.wYSZUKANIE_OPERACJI_ZLECENIA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabSLOWNIKDANYCH
            // 
            this.tabSLOWNIKDANYCH.BackColor = System.Drawing.SystemColors.Control;
            this.tabSLOWNIKDANYCH.Controls.Add(this.tbDOPERACJE);
            this.tabSLOWNIKDANYCH.Controls.Add(this.tbDSTATUS);
            this.tabSLOWNIKDANYCH.Controls.Add(this.tbDTYPRAL);
            this.tabSLOWNIKDANYCH.Controls.Add(this.tbDPOLYSK);
            this.tabSLOWNIKDANYCH.Controls.Add(this.tbDPOWIERZCHNIA);
            this.tabSLOWNIKDANYCH.Controls.Add(this.tbDKLIENT);
            this.tabSLOWNIKDANYCH.Controls.Add(this.tbDRAL);
            this.tabSLOWNIKDANYCH.Controls.Add(this.tbDDOSTAWCE);
            this.tabSLOWNIKDANYCH.Controls.Add(this.btnDODAJOPERACJE);
            this.tabSLOWNIKDANYCH.Controls.Add(this.btnDODAJSTATUS);
            this.tabSLOWNIKDANYCH.Controls.Add(this.btnDODAJTYP);
            this.tabSLOWNIKDANYCH.Controls.Add(this.btnDODAJPOLYSK);
            this.tabSLOWNIKDANYCH.Controls.Add(this.btnDODAJPOWIERZCHNIE);
            this.tabSLOWNIKDANYCH.Controls.Add(this.btnDODAJKLIENT);
            this.tabSLOWNIKDANYCH.Controls.Add(this.btnDODAJRAL);
            this.tabSLOWNIKDANYCH.Controls.Add(this.btnDODAJDOSTAWCA);
            this.tabSLOWNIKDANYCH.Location = new System.Drawing.Point(4, 22);
            this.tabSLOWNIKDANYCH.Name = "tabSLOWNIKDANYCH";
            this.tabSLOWNIKDANYCH.Padding = new System.Windows.Forms.Padding(3);
            this.tabSLOWNIKDANYCH.Size = new System.Drawing.Size(1110, 435);
            this.tabSLOWNIKDANYCH.TabIndex = 2;
            this.tabSLOWNIKDANYCH.Text = "SŁOWNIKI DANYCH";
            // 
            // tbDOPERACJE
            // 
            this.tbDOPERACJE.Location = new System.Drawing.Point(580, 358);
            this.tbDOPERACJE.Name = "tbDOPERACJE";
            this.tbDOPERACJE.Size = new System.Drawing.Size(143, 20);
            this.tbDOPERACJE.TabIndex = 15;
            // 
            // tbDSTATUS
            // 
            this.tbDSTATUS.Location = new System.Drawing.Point(580, 318);
            this.tbDSTATUS.Name = "tbDSTATUS";
            this.tbDSTATUS.Size = new System.Drawing.Size(143, 20);
            this.tbDSTATUS.TabIndex = 14;
            // 
            // tbDTYPRAL
            // 
            this.tbDTYPRAL.Location = new System.Drawing.Point(580, 273);
            this.tbDTYPRAL.Name = "tbDTYPRAL";
            this.tbDTYPRAL.Size = new System.Drawing.Size(143, 20);
            this.tbDTYPRAL.TabIndex = 13;
            // 
            // tbDPOLYSK
            // 
            this.tbDPOLYSK.Location = new System.Drawing.Point(580, 228);
            this.tbDPOLYSK.Name = "tbDPOLYSK";
            this.tbDPOLYSK.Size = new System.Drawing.Size(143, 20);
            this.tbDPOLYSK.TabIndex = 12;
            // 
            // tbDPOWIERZCHNIA
            // 
            this.tbDPOWIERZCHNIA.Location = new System.Drawing.Point(580, 181);
            this.tbDPOWIERZCHNIA.Name = "tbDPOWIERZCHNIA";
            this.tbDPOWIERZCHNIA.Size = new System.Drawing.Size(143, 20);
            this.tbDPOWIERZCHNIA.TabIndex = 11;
            // 
            // tbDKLIENT
            // 
            this.tbDKLIENT.Location = new System.Drawing.Point(580, 134);
            this.tbDKLIENT.Name = "tbDKLIENT";
            this.tbDKLIENT.Size = new System.Drawing.Size(143, 20);
            this.tbDKLIENT.TabIndex = 10;
            // 
            // tbDRAL
            // 
            this.tbDRAL.Location = new System.Drawing.Point(580, 93);
            this.tbDRAL.MaxLength = 7;
            this.tbDRAL.Name = "tbDRAL";
            this.tbDRAL.Size = new System.Drawing.Size(143, 20);
            this.tbDRAL.TabIndex = 10;
            // 
            // tbDDOSTAWCE
            // 
            this.tbDDOSTAWCE.Location = new System.Drawing.Point(580, 52);
            this.tbDDOSTAWCE.Name = "tbDDOSTAWCE";
            this.tbDDOSTAWCE.Size = new System.Drawing.Size(143, 20);
            this.tbDDOSTAWCE.TabIndex = 9;
            // 
            // btnDODAJOPERACJE
            // 
            this.btnDODAJOPERACJE.Location = new System.Drawing.Point(343, 355);
            this.btnDODAJOPERACJE.Name = "btnDODAJOPERACJE";
            this.btnDODAJOPERACJE.Size = new System.Drawing.Size(199, 23);
            this.btnDODAJOPERACJE.TabIndex = 8;
            this.btnDODAJOPERACJE.Text = "Dodaj Operacje Technologiczna";
            this.btnDODAJOPERACJE.UseVisualStyleBackColor = true;
            this.btnDODAJOPERACJE.Click += new System.EventHandler(this.btnDODAJOPERACJE_Click);
            // 
            // btnDODAJSTATUS
            // 
            this.btnDODAJSTATUS.Location = new System.Drawing.Point(343, 315);
            this.btnDODAJSTATUS.Name = "btnDODAJSTATUS";
            this.btnDODAJSTATUS.Size = new System.Drawing.Size(199, 23);
            this.btnDODAJSTATUS.TabIndex = 6;
            this.btnDODAJSTATUS.Text = "Dodaj Status";
            this.btnDODAJSTATUS.UseVisualStyleBackColor = true;
            this.btnDODAJSTATUS.Click += new System.EventHandler(this.btnDODAJSTATUS_Click);
            // 
            // btnDODAJTYP
            // 
            this.btnDODAJTYP.Location = new System.Drawing.Point(343, 270);
            this.btnDODAJTYP.Name = "btnDODAJTYP";
            this.btnDODAJTYP.Size = new System.Drawing.Size(199, 23);
            this.btnDODAJTYP.TabIndex = 5;
            this.btnDODAJTYP.Text = "Dodaj Typ Farby";
            this.btnDODAJTYP.UseVisualStyleBackColor = true;
            this.btnDODAJTYP.Click += new System.EventHandler(this.btnDODAJTYP_Click);
            // 
            // btnDODAJPOLYSK
            // 
            this.btnDODAJPOLYSK.Location = new System.Drawing.Point(343, 225);
            this.btnDODAJPOLYSK.Name = "btnDODAJPOLYSK";
            this.btnDODAJPOLYSK.Size = new System.Drawing.Size(199, 23);
            this.btnDODAJPOLYSK.TabIndex = 4;
            this.btnDODAJPOLYSK.Text = "Dodaj Połysk";
            this.btnDODAJPOLYSK.UseVisualStyleBackColor = true;
            this.btnDODAJPOLYSK.Click += new System.EventHandler(this.btnDODAJPOLYSK_Click);
            // 
            // btnDODAJPOWIERZCHNIE
            // 
            this.btnDODAJPOWIERZCHNIE.Location = new System.Drawing.Point(343, 179);
            this.btnDODAJPOWIERZCHNIE.Name = "btnDODAJPOWIERZCHNIE";
            this.btnDODAJPOWIERZCHNIE.Size = new System.Drawing.Size(199, 23);
            this.btnDODAJPOWIERZCHNIE.TabIndex = 3;
            this.btnDODAJPOWIERZCHNIE.Text = "Dodaj Powierzchnie";
            this.btnDODAJPOWIERZCHNIE.UseVisualStyleBackColor = true;
            this.btnDODAJPOWIERZCHNIE.Click += new System.EventHandler(this.btnDODAJPOWIERZCHNIE_Click);
            // 
            // btnDODAJKLIENT
            // 
            this.btnDODAJKLIENT.Location = new System.Drawing.Point(343, 131);
            this.btnDODAJKLIENT.Name = "btnDODAJKLIENT";
            this.btnDODAJKLIENT.Size = new System.Drawing.Size(199, 23);
            this.btnDODAJKLIENT.TabIndex = 2;
            this.btnDODAJKLIENT.Text = "Dodaj Klienta";
            this.btnDODAJKLIENT.UseVisualStyleBackColor = true;
            this.btnDODAJKLIENT.Click += new System.EventHandler(this.btnDODAJKLIENT_Click);
            // 
            // btnDODAJRAL
            // 
            this.btnDODAJRAL.Location = new System.Drawing.Point(343, 90);
            this.btnDODAJRAL.Name = "btnDODAJRAL";
            this.btnDODAJRAL.Size = new System.Drawing.Size(199, 23);
            this.btnDODAJRAL.TabIndex = 1;
            this.btnDODAJRAL.Text = "Dodaj RAL Farby";
            this.btnDODAJRAL.UseVisualStyleBackColor = true;
            this.btnDODAJRAL.Click += new System.EventHandler(this.btnDODAJRAL_Click);
            // 
            // btnDODAJDOSTAWCA
            // 
            this.btnDODAJDOSTAWCA.Location = new System.Drawing.Point(343, 50);
            this.btnDODAJDOSTAWCA.Name = "btnDODAJDOSTAWCA";
            this.btnDODAJDOSTAWCA.Size = new System.Drawing.Size(199, 23);
            this.btnDODAJDOSTAWCA.TabIndex = 0;
            this.btnDODAJDOSTAWCA.Text = "Dodaj Dostawce";
            this.btnDODAJDOSTAWCA.UseVisualStyleBackColor = true;
            this.btnDODAJDOSTAWCA.Click += new System.EventHandler(this.btnDODAJDOSTAWCA_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.dtpPLAN);
            this.tabPage1.Controls.Add(this.btnDODAJDOPLANU);
            this.tabPage1.Controls.Add(this.cbIDDOPLANU);
            this.tabPage1.Controls.Add(this.btnDODAJPLAN);
            this.tabPage1.Controls.Add(this.dtgPLAN);
            this.tabPage1.Controls.Add(this.cbPLAN);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1110, 435);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "PLAN ZLECEN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Wybierz Plan";
            // 
            // dtpPLAN
            // 
            this.dtpPLAN.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPLAN.Location = new System.Drawing.Point(136, 20);
            this.dtpPLAN.Name = "dtpPLAN";
            this.dtpPLAN.Size = new System.Drawing.Size(98, 20);
            this.dtpPLAN.TabIndex = 15;
            // 
            // btnDODAJDOPLANU
            // 
            this.btnDODAJDOPLANU.Location = new System.Drawing.Point(464, 22);
            this.btnDODAJDOPLANU.Name = "btnDODAJDOPLANU";
            this.btnDODAJDOPLANU.Size = new System.Drawing.Size(105, 23);
            this.btnDODAJDOPLANU.TabIndex = 14;
            this.btnDODAJDOPLANU.Text = "Dodaj Do Planu";
            this.btnDODAJDOPLANU.UseVisualStyleBackColor = true;
            this.btnDODAJDOPLANU.Click += new System.EventHandler(this.btnDODAJDOPLANU_Click);
            // 
            // cbIDDOPLANU
            // 
            this.cbIDDOPLANU.DataSource = this.zLECENIABindingSource1;
            this.cbIDDOPLANU.DisplayMember = "NR_ZLECENIA";
            this.cbIDDOPLANU.FormattingEnabled = true;
            this.cbIDDOPLANU.Location = new System.Drawing.Point(575, 24);
            this.cbIDDOPLANU.Name = "cbIDDOPLANU";
            this.cbIDDOPLANU.Size = new System.Drawing.Size(121, 21);
            this.cbIDDOPLANU.TabIndex = 13;
            this.cbIDDOPLANU.ValueMember = "ID_ZLECENIA";
            // 
            // btnDODAJPLAN
            // 
            this.btnDODAJPLAN.Location = new System.Drawing.Point(23, 20);
            this.btnDODAJPLAN.Name = "btnDODAJPLAN";
            this.btnDODAJPLAN.Size = new System.Drawing.Size(107, 23);
            this.btnDODAJPLAN.TabIndex = 12;
            this.btnDODAJPLAN.Text = "Dodaj Plan";
            this.btnDODAJPLAN.UseVisualStyleBackColor = true;
            this.btnDODAJPLAN.Click += new System.EventHandler(this.btnDODAJPLAN_Click);
            // 
            // dtgPLAN
            // 
            this.dtgPLAN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPLAN.Location = new System.Drawing.Point(23, 49);
            this.dtgPLAN.Name = "dtgPLAN";
            this.dtgPLAN.ReadOnly = true;
            this.dtgPLAN.Size = new System.Drawing.Size(1064, 365);
            this.dtgPLAN.TabIndex = 11;
            // 
            // cbPLAN
            // 
            this.cbPLAN.DataSource = this.pLANZLECENBindingSource;
            this.cbPLAN.DisplayMember = "DATA_PLANU";
            this.cbPLAN.FormattingEnabled = true;
            this.cbPLAN.Location = new System.Drawing.Point(297, 20);
            this.cbPLAN.Name = "cbPLAN";
            this.cbPLAN.Size = new System.Drawing.Size(89, 21);
            this.cbPLAN.TabIndex = 1;
            this.cbPLAN.ValueMember = "ID_PLANU";
            this.cbPLAN.SelectedIndexChanged += new System.EventHandler(this.cbPLAN_SelectedIndexChanged);
            // 
            // pLANZLECENBindingSource
            // 
            this.pLANZLECENBindingSource.DataMember = "PLAN_ZLECEN";
            this.pLANZLECENBindingSource.DataSource = this.bAZA_MALARNIADataSet26;
            // 
            // bAZA_MALARNIADataSet26
            // 
            this.bAZA_MALARNIADataSet26.DataSetName = "BAZA_MALARNIADataSet26";
            this.bAZA_MALARNIADataSet26.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dANEOPERACJIBindingSource
            // 
            this.dANEOPERACJIBindingSource.DataMember = "DANE_OPERACJI";
            this.dANEOPERACJIBindingSource.DataSource = this.bAZA_MALARNIADataSet22;
            // 
            // bAZA_MALARNIADataSet22
            // 
            this.bAZA_MALARNIADataSet22.DataSetName = "BAZA_MALARNIADataSet22";
            this.bAZA_MALARNIADataSet22.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oPERACJEBindingSource1
            // 
            this.oPERACJEBindingSource1.DataMember = "OPERACJE";
            this.oPERACJEBindingSource1.DataSource = this.bAZA_MALARNIADataSet20;
            // 
            // bAZA_MALARNIADataSet20
            // 
            this.bAZA_MALARNIADataSet20.DataSetName = "BAZA_MALARNIADataSet20";
            this.bAZA_MALARNIADataSet20.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewZlecenieBindingSource1
            // 
            this.viewZlecenieBindingSource1.DataMember = "View_Zlecenie";
            this.viewZlecenieBindingSource1.DataSource = this.bAZA_MALARNIADataSet2;
            // 
            // bAZA_MALARNIADataSet2
            // 
            this.bAZA_MALARNIADataSet2.DataSetName = "BAZA_MALARNIADataSet2";
            this.bAZA_MALARNIADataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_ZlecenieTableAdapter1
            // 
            this.view_ZlecenieTableAdapter1.ClearBeforeFill = true;
            // 
            // bAZA_MALARNIADataSet8
            // 
            this.bAZA_MALARNIADataSet8.DataSetName = "BAZA_MALARNIADataSet8";
            this.bAZA_MALARNIADataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zLECENIABindingSource
            // 
            this.zLECENIABindingSource.DataMember = "ZLECENIA";
            this.zLECENIABindingSource.DataSource = this.bAZA_MALARNIADataSet8;
            // 
            // zLECENIATableAdapter
            // 
            this.zLECENIATableAdapter.ClearBeforeFill = true;
            // 
            // zLECENIATableAdapter1
            // 
            this.zLECENIATableAdapter1.ClearBeforeFill = true;
            // 
            // oPERACJETableAdapter
            // 
            this.oPERACJETableAdapter.ClearBeforeFill = true;
            // 
            // oPERACJETableAdapter1
            // 
            this.oPERACJETableAdapter1.ClearBeforeFill = true;
            // 
            // dANE_OPERACJITableAdapter
            // 
            this.dANE_OPERACJITableAdapter.ClearBeforeFill = true;
            // 
            // pLAN_ZLECENTableAdapter
            // 
            this.pLAN_ZLECENTableAdapter.ClearBeforeFill = true;
            // 
            // btnWYDZLECEN
            // 
            this.btnWYDZLECEN.Location = new System.Drawing.Point(403, 19);
            this.btnWYDZLECEN.Name = "btnWYDZLECEN";
            this.btnWYDZLECEN.Size = new System.Drawing.Size(125, 23);
            this.btnWYDZLECEN.TabIndex = 10;
            this.btnWYDZLECEN.Text = "Wydajności Zleceń";
            this.btnWYDZLECEN.UseVisualStyleBackColor = true;
            this.btnWYDZLECEN.Click += new System.EventHandler(this.btnWYDZLECEN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 479);
            this.Controls.Add(this.multipage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bAZAMALARNIADataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewZlecenieBindingSource)).EndInit();
            this.multipage.ResumeLayout(false);
            this.tabZLECENIE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZLECENIE)).EndInit();
            this.tabOPERACJETECHNOLOGICZNE.ResumeLayout(false);
            this.tabOPERACJETECHNOLOGICZNE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numZUZMAT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCZASOP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPERACJEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAZA_MALARNIADataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOPERACJE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zLECENIABindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wYSZUKANIE_OPERACJI_ZLECENIA)).EndInit();
            this.tabSLOWNIKDANYCH.ResumeLayout(false);
            this.tabSLOWNIKDANYCH.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPLAN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLANZLECENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAZA_MALARNIADataSet26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dANEOPERACJIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAZA_MALARNIADataSet22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPERACJEBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAZA_MALARNIADataSet20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewZlecenieBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAZA_MALARNIADataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAZA_MALARNIADataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zLECENIABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bAZAMALARNIADataSetBindingSource;
        private System.Windows.Forms.BindingSource viewZlecenieBindingSource;
        private System.Windows.Forms.Button DODAJZLECENIE;
        private System.Windows.Forms.TabControl multipage;
        private System.Windows.Forms.TabPage tabZLECENIE;
        private System.Windows.Forms.TabPage tabOPERACJETECHNOLOGICZNE;
        private System.Windows.Forms.DataGridView dgvZLECENIE;
        private System.Windows.Forms.TabPage tabSLOWNIKDANYCH;
        private System.Windows.Forms.Button btnDODAJRAL;
        private System.Windows.Forms.Button btnDODAJDOSTAWCA;
        private System.Windows.Forms.Button btnDODAJTYP;
        private System.Windows.Forms.Button btnDODAJPOLYSK;
        private System.Windows.Forms.Button btnDODAJPOWIERZCHNIE;
        private System.Windows.Forms.Button btnDODAJKLIENT;
        private System.Windows.Forms.Button btnDODAJOPERACJE;
        private System.Windows.Forms.Button btnDODAJSTATUS;
        private BAZA_MALARNIADataSet2 bAZA_MALARNIADataSet2;
        private System.Windows.Forms.BindingSource viewZlecenieBindingSource1;
        private BAZA_MALARNIADataSet2TableAdapters.View_ZlecenieTableAdapter view_ZlecenieTableAdapter1;
        private BAZA_MALARNIADataSet8 bAZA_MALARNIADataSet8;
        private System.Windows.Forms.BindingSource zLECENIABindingSource;
        private BAZA_MALARNIADataSet8TableAdapters.ZLECENIATableAdapter zLECENIATableAdapter;
        private System.Windows.Forms.TextBox tbDOPERACJE;
        private System.Windows.Forms.TextBox tbDSTATUS;
        private System.Windows.Forms.TextBox tbDTYPRAL;
        private System.Windows.Forms.TextBox tbDPOLYSK;
        private System.Windows.Forms.TextBox tbDPOWIERZCHNIA;
        private System.Windows.Forms.TextBox tbDKLIENT;
        private System.Windows.Forms.TextBox tbDRAL;
        private System.Windows.Forms.TextBox tbDDOSTAWCE;
        private System.Windows.Forms.ComboBox cbNRZLECENIA;
        private WYSZUKANIE_OPERACJI_ZLECENIA wYSZUKANIE_OPERACJI_ZLECENIA;
        private System.Windows.Forms.BindingSource zLECENIABindingSource1;
        private WYSZUKANIE_OPERACJI_ZLECENIATableAdapters.ZLECENIATableAdapter zLECENIATableAdapter1;
        private System.Windows.Forms.Button btnDODAJOPER;
        private System.Windows.Forms.DataGridView dgvOPERACJE;
        private System.Windows.Forms.NumericUpDown numZUZMAT;
        private System.Windows.Forms.NumericUpDown numCZASOP;
        private System.Windows.Forms.DateTimePicker dtDATAOPERACJI;
        private System.Windows.Forms.ComboBox cbWOPERACJI;
        private BAZA_MALARNIADataSet9 bAZA_MALARNIADataSet9;
        private System.Windows.Forms.BindingSource oPERACJEBindingSource;
        private BAZA_MALARNIADataSet9TableAdapters.OPERACJETableAdapter oPERACJETableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEDYTZLEC;
        private System.Windows.Forms.Button btnPOKAZZLEC;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label9;
        private BAZA_MALARNIADataSet20 bAZA_MALARNIADataSet20;
        private System.Windows.Forms.BindingSource oPERACJEBindingSource1;
        private BAZA_MALARNIADataSet20TableAdapters.OPERACJETableAdapter oPERACJETableAdapter1;
        private BAZA_MALARNIADataSet22 bAZA_MALARNIADataSet22;
        private System.Windows.Forms.BindingSource dANEOPERACJIBindingSource;
        private BAZA_MALARNIADataSet22TableAdapters.DANE_OPERACJITableAdapter dANE_OPERACJITableAdapter;
        private System.Windows.Forms.ComboBox cbPLAN;
        private System.Windows.Forms.Button btnDODAJDOPLANU;
        private System.Windows.Forms.ComboBox cbIDDOPLANU;
        private System.Windows.Forms.Button btnDODAJPLAN;
        private System.Windows.Forms.DataGridView dtgPLAN;
        private BAZA_MALARNIADataSet26 bAZA_MALARNIADataSet26;
        private System.Windows.Forms.BindingSource pLANZLECENBindingSource;
        private BAZA_MALARNIADataSet26TableAdapters.PLAN_ZLECENTableAdapter pLAN_ZLECENTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpPLAN;
        private System.Windows.Forms.Button btnWYDZLECEN;
    }
}

