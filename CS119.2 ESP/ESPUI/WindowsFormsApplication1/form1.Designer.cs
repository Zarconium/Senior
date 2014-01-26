namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.transactionType = new System.Windows.Forms.ComboBox();
            this.transactionType_label = new System.Windows.Forms.Label();
            this.receipts_gb = new System.Windows.Forms.GroupBox();
            this.tb_receiptCost_receipts = new System.Windows.Forms.TextBox();
            this.tb_quantity_receipts = new System.Windows.Forms.TextBox();
            this.tb_longDescription_receipts = new System.Windows.Forms.TextBox();
            this.tb_stockCode_receipts = new System.Windows.Forms.TextBox();
            this.tb_description_receipts = new System.Windows.Forms.TextBox();
            this.tb_warehouse_receipts = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.adjustments_gb = new System.Windows.Forms.GroupBox();
            this.tb_quantity_adjustments = new System.Windows.Forms.TextBox();
            this.tb_longDescription_adjustments = new System.Windows.Forms.TextBox();
            this.tb_stockCode_adjustments = new System.Windows.Forms.TextBox();
            this.tb_description_adjustments = new System.Windows.Forms.TextBox();
            this.tb_warehouse_adjustments = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.costChanges_gb = new System.Windows.Forms.GroupBox();
            this.tb_newCost_costChanges = new System.Windows.Forms.TextBox();
            this.tb_longDescription_costChanges = new System.Windows.Forms.TextBox();
            this.tb_stockCode_costChanges = new System.Windows.Forms.TextBox();
            this.tb_description_costChanges = new System.Windows.Forms.TextBox();
            this.tb_warehouse_costChanges = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.costModifications_gb = new System.Windows.Forms.GroupBox();
            this.tb_prevCost_costMod = new System.Windows.Forms.TextBox();
            this.tb_quantity_costMod = new System.Windows.Forms.TextBox();
            this.tb_longDescription_costMod = new System.Windows.Forms.TextBox();
            this.tb_stockCode_costMod = new System.Windows.Forms.TextBox();
            this.tb_description_costMod = new System.Windows.Forms.TextBox();
            this.tb_warehouse_costMod = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.transfersOut_gb = new System.Windows.Forms.GroupBox();
            this.tb_revision_transfersOut = new System.Windows.Forms.TextBox();
            this.tb_quantity_transfersOut = new System.Windows.Forms.TextBox();
            this.tb_longDescription_transfersOut = new System.Windows.Forms.TextBox();
            this.tb_stockCode_transfersOut = new System.Windows.Forms.TextBox();
            this.tb_description_transfersOut = new System.Windows.Forms.TextBox();
            this.tb_warehouse_transfersOut = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.transfersIn_gb = new System.Windows.Forms.GroupBox();
            this.tb_revision_transfersIn = new System.Windows.Forms.TextBox();
            this.tb_quantity_transfersIn = new System.Windows.Forms.TextBox();
            this.tb_longDescription_transfersIn = new System.Windows.Forms.TextBox();
            this.tb_stockCode_transfersIn = new System.Windows.Forms.TextBox();
            this.tb_description_transfersIn = new System.Windows.Forms.TextBox();
            this.tb_warehouse_transfersIn = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.tb_newCost_costMod = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tb_release_transfersOut = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.tb_newWarehouse_transfersOut = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.tb_release_transfersIn = new System.Windows.Forms.TextBox();
            this.post_costChanges = new System.Windows.Forms.Button();
            this.post_costModifications = new System.Windows.Forms.Button();
            this.post_transfersOut = new System.Windows.Forms.Button();
            this.post_transfersIn = new System.Windows.Forms.Button();
            this.post_adjustments = new System.Windows.Forms.Button();
            this.post_receipts = new System.Windows.Forms.Button();
            this.receipts_gb.SuspendLayout();
            this.adjustments_gb.SuspendLayout();
            this.costChanges_gb.SuspendLayout();
            this.costModifications_gb.SuspendLayout();
            this.transfersOut_gb.SuspendLayout();
            this.transfersIn_gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // transactionType
            // 
            this.transactionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.transactionType.FormattingEnabled = true;
            this.transactionType.Items.AddRange(new object[] {
            "Receipts",
            "Adjustments",
            "Cost Changes",
            "Cost Modifications",
            "Transfers OUT",
            "Transfers IN"});
            this.transactionType.Location = new System.Drawing.Point(110, 12);
            this.transactionType.Name = "transactionType";
            this.transactionType.Size = new System.Drawing.Size(130, 21);
            this.transactionType.TabIndex = 1;
            this.transactionType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // transactionType_label
            // 
            this.transactionType_label.AutoSize = true;
            this.transactionType_label.Location = new System.Drawing.Point(11, 15);
            this.transactionType_label.Name = "transactionType_label";
            this.transactionType_label.Size = new System.Drawing.Size(93, 13);
            this.transactionType_label.TabIndex = 2;
            this.transactionType_label.Text = "Transaction Type:";
            // 
            // receipts_gb
            // 
            this.receipts_gb.Controls.Add(this.post_receipts);
            this.receipts_gb.Controls.Add(this.tb_receiptCost_receipts);
            this.receipts_gb.Controls.Add(this.tb_quantity_receipts);
            this.receipts_gb.Controls.Add(this.tb_longDescription_receipts);
            this.receipts_gb.Controls.Add(this.tb_stockCode_receipts);
            this.receipts_gb.Controls.Add(this.tb_description_receipts);
            this.receipts_gb.Controls.Add(this.tb_warehouse_receipts);
            this.receipts_gb.Controls.Add(this.label6);
            this.receipts_gb.Controls.Add(this.label5);
            this.receipts_gb.Controls.Add(this.label4);
            this.receipts_gb.Controls.Add(this.label3);
            this.receipts_gb.Controls.Add(this.label2);
            this.receipts_gb.Controls.Add(this.label1);
            this.receipts_gb.Location = new System.Drawing.Point(12, 48);
            this.receipts_gb.Name = "receipts_gb";
            this.receipts_gb.Size = new System.Drawing.Size(251, 326);
            this.receipts_gb.TabIndex = 3;
            this.receipts_gb.TabStop = false;
            this.receipts_gb.Text = "Transaction Details";
            this.receipts_gb.Enter += new System.EventHandler(this.transactionDetails_Enter);
            // 
            // tb_receiptCost_receipts
            // 
            this.tb_receiptCost_receipts.Location = new System.Drawing.Point(82, 149);
            this.tb_receiptCost_receipts.Name = "tb_receiptCost_receipts";
            this.tb_receiptCost_receipts.Size = new System.Drawing.Size(144, 20);
            this.tb_receiptCost_receipts.TabIndex = 11;
            this.tb_receiptCost_receipts.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // tb_quantity_receipts
            // 
            this.tb_quantity_receipts.Location = new System.Drawing.Point(61, 125);
            this.tb_quantity_receipts.Name = "tb_quantity_receipts";
            this.tb_quantity_receipts.Size = new System.Drawing.Size(165, 20);
            this.tb_quantity_receipts.TabIndex = 10;
            this.tb_quantity_receipts.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // tb_longDescription_receipts
            // 
            this.tb_longDescription_receipts.Location = new System.Drawing.Point(102, 102);
            this.tb_longDescription_receipts.Name = "tb_longDescription_receipts";
            this.tb_longDescription_receipts.Size = new System.Drawing.Size(124, 20);
            this.tb_longDescription_receipts.TabIndex = 9;
            this.tb_longDescription_receipts.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // tb_stockCode_receipts
            // 
            this.tb_stockCode_receipts.Location = new System.Drawing.Point(78, 53);
            this.tb_stockCode_receipts.Name = "tb_stockCode_receipts";
            this.tb_stockCode_receipts.Size = new System.Drawing.Size(148, 20);
            this.tb_stockCode_receipts.TabIndex = 8;
            this.tb_stockCode_receipts.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // tb_description_receipts
            // 
            this.tb_description_receipts.Location = new System.Drawing.Point(78, 78);
            this.tb_description_receipts.Name = "tb_description_receipts";
            this.tb_description_receipts.Size = new System.Drawing.Size(148, 20);
            this.tb_description_receipts.TabIndex = 7;
            this.tb_description_receipts.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tb_warehouse_receipts
            // 
            this.tb_warehouse_receipts.Location = new System.Drawing.Point(78, 27);
            this.tb_warehouse_receipts.Name = "tb_warehouse_receipts";
            this.tb_warehouse_receipts.Size = new System.Drawing.Size(148, 20);
            this.tb_warehouse_receipts.TabIndex = 6;
            this.tb_warehouse_receipts.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Receipt cost:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Long Description:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stock code:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Warehouse:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // adjustments_gb
            // 
            this.adjustments_gb.Controls.Add(this.post_adjustments);
            this.adjustments_gb.Controls.Add(this.tb_quantity_adjustments);
            this.adjustments_gb.Controls.Add(this.tb_longDescription_adjustments);
            this.adjustments_gb.Controls.Add(this.tb_stockCode_adjustments);
            this.adjustments_gb.Controls.Add(this.tb_description_adjustments);
            this.adjustments_gb.Controls.Add(this.tb_warehouse_adjustments);
            this.adjustments_gb.Controls.Add(this.label8);
            this.adjustments_gb.Controls.Add(this.label9);
            this.adjustments_gb.Controls.Add(this.label10);
            this.adjustments_gb.Controls.Add(this.label11);
            this.adjustments_gb.Controls.Add(this.label12);
            this.adjustments_gb.Location = new System.Drawing.Point(12, 48);
            this.adjustments_gb.Name = "adjustments_gb";
            this.adjustments_gb.Size = new System.Drawing.Size(251, 326);
            this.adjustments_gb.TabIndex = 4;
            this.adjustments_gb.TabStop = false;
            this.adjustments_gb.Text = "Transaction Details";
            // 
            // tb_quantity_adjustments
            // 
            this.tb_quantity_adjustments.Location = new System.Drawing.Point(61, 125);
            this.tb_quantity_adjustments.Name = "tb_quantity_adjustments";
            this.tb_quantity_adjustments.Size = new System.Drawing.Size(165, 20);
            this.tb_quantity_adjustments.TabIndex = 10;
            // 
            // tb_longDescription_adjustments
            // 
            this.tb_longDescription_adjustments.Location = new System.Drawing.Point(102, 102);
            this.tb_longDescription_adjustments.Name = "tb_longDescription_adjustments";
            this.tb_longDescription_adjustments.Size = new System.Drawing.Size(124, 20);
            this.tb_longDescription_adjustments.TabIndex = 9;
            // 
            // tb_stockCode_adjustments
            // 
            this.tb_stockCode_adjustments.Location = new System.Drawing.Point(78, 53);
            this.tb_stockCode_adjustments.Name = "tb_stockCode_adjustments";
            this.tb_stockCode_adjustments.Size = new System.Drawing.Size(148, 20);
            this.tb_stockCode_adjustments.TabIndex = 8;
            // 
            // tb_description_adjustments
            // 
            this.tb_description_adjustments.Location = new System.Drawing.Point(78, 78);
            this.tb_description_adjustments.Name = "tb_description_adjustments";
            this.tb_description_adjustments.Size = new System.Drawing.Size(148, 20);
            this.tb_description_adjustments.TabIndex = 7;
            // 
            // tb_warehouse_adjustments
            // 
            this.tb_warehouse_adjustments.Location = new System.Drawing.Point(78, 27);
            this.tb_warehouse_adjustments.Name = "tb_warehouse_adjustments";
            this.tb_warehouse_adjustments.Size = new System.Drawing.Size(148, 20);
            this.tb_warehouse_adjustments.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Quantity:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Long Description:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Description:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Stock code:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Warehouse:";
            // 
            // costChanges_gb
            // 
            this.costChanges_gb.Controls.Add(this.post_costChanges);
            this.costChanges_gb.Controls.Add(this.tb_newCost_costChanges);
            this.costChanges_gb.Controls.Add(this.tb_longDescription_costChanges);
            this.costChanges_gb.Controls.Add(this.tb_stockCode_costChanges);
            this.costChanges_gb.Controls.Add(this.tb_description_costChanges);
            this.costChanges_gb.Controls.Add(this.tb_warehouse_costChanges);
            this.costChanges_gb.Controls.Add(this.label16);
            this.costChanges_gb.Controls.Add(this.label17);
            this.costChanges_gb.Controls.Add(this.label18);
            this.costChanges_gb.Controls.Add(this.label19);
            this.costChanges_gb.Controls.Add(this.label20);
            this.costChanges_gb.Location = new System.Drawing.Point(12, 48);
            this.costChanges_gb.Name = "costChanges_gb";
            this.costChanges_gb.Size = new System.Drawing.Size(251, 326);
            this.costChanges_gb.TabIndex = 13;
            this.costChanges_gb.TabStop = false;
            this.costChanges_gb.Text = "Transaction Details";
            // 
            // tb_newCost_costChanges
            // 
            this.tb_newCost_costChanges.Location = new System.Drawing.Point(64, 125);
            this.tb_newCost_costChanges.Name = "tb_newCost_costChanges";
            this.tb_newCost_costChanges.Size = new System.Drawing.Size(162, 20);
            this.tb_newCost_costChanges.TabIndex = 10;
            // 
            // tb_longDescription_costChanges
            // 
            this.tb_longDescription_costChanges.Location = new System.Drawing.Point(102, 102);
            this.tb_longDescription_costChanges.Name = "tb_longDescription_costChanges";
            this.tb_longDescription_costChanges.Size = new System.Drawing.Size(124, 20);
            this.tb_longDescription_costChanges.TabIndex = 9;
            // 
            // tb_stockCode_costChanges
            // 
            this.tb_stockCode_costChanges.Location = new System.Drawing.Point(78, 53);
            this.tb_stockCode_costChanges.Name = "tb_stockCode_costChanges";
            this.tb_stockCode_costChanges.Size = new System.Drawing.Size(148, 20);
            this.tb_stockCode_costChanges.TabIndex = 8;
            // 
            // tb_description_costChanges
            // 
            this.tb_description_costChanges.Location = new System.Drawing.Point(78, 78);
            this.tb_description_costChanges.Name = "tb_description_costChanges";
            this.tb_description_costChanges.Size = new System.Drawing.Size(148, 20);
            this.tb_description_costChanges.TabIndex = 7;
            // 
            // tb_warehouse_costChanges
            // 
            this.tb_warehouse_costChanges.Location = new System.Drawing.Point(78, 27);
            this.tb_warehouse_costChanges.Name = "tb_warehouse_costChanges";
            this.tb_warehouse_costChanges.Size = new System.Drawing.Size(148, 20);
            this.tb_warehouse_costChanges.TabIndex = 6;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 128);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "New Cost:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 104);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(90, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "Long Description:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 79);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 13);
            this.label18.TabIndex = 2;
            this.label18.Text = "Description:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 54);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 13);
            this.label19.TabIndex = 1;
            this.label19.Text = "Stock code:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(7, 30);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Warehouse:";
            // 
            // costModifications_gb
            // 
            this.costModifications_gb.Controls.Add(this.post_costModifications);
            this.costModifications_gb.Controls.Add(this.tb_newCost_costMod);
            this.costModifications_gb.Controls.Add(this.label42);
            this.costModifications_gb.Controls.Add(this.tb_prevCost_costMod);
            this.costModifications_gb.Controls.Add(this.tb_quantity_costMod);
            this.costModifications_gb.Controls.Add(this.tb_longDescription_costMod);
            this.costModifications_gb.Controls.Add(this.tb_stockCode_costMod);
            this.costModifications_gb.Controls.Add(this.tb_description_costMod);
            this.costModifications_gb.Controls.Add(this.tb_warehouse_costMod);
            this.costModifications_gb.Controls.Add(this.label22);
            this.costModifications_gb.Controls.Add(this.label23);
            this.costModifications_gb.Controls.Add(this.label24);
            this.costModifications_gb.Controls.Add(this.label25);
            this.costModifications_gb.Controls.Add(this.label26);
            this.costModifications_gb.Controls.Add(this.label27);
            this.costModifications_gb.Location = new System.Drawing.Point(12, 48);
            this.costModifications_gb.Name = "costModifications_gb";
            this.costModifications_gb.Size = new System.Drawing.Size(251, 326);
            this.costModifications_gb.TabIndex = 14;
            this.costModifications_gb.TabStop = false;
            this.costModifications_gb.Text = "Transaction Details";
            // 
            // tb_prevCost_costMod
            // 
            this.tb_prevCost_costMod.Location = new System.Drawing.Point(82, 149);
            this.tb_prevCost_costMod.Name = "tb_prevCost_costMod";
            this.tb_prevCost_costMod.Size = new System.Drawing.Size(144, 20);
            this.tb_prevCost_costMod.TabIndex = 11;
            // 
            // tb_quantity_costMod
            // 
            this.tb_quantity_costMod.Location = new System.Drawing.Point(61, 125);
            this.tb_quantity_costMod.Name = "tb_quantity_costMod";
            this.tb_quantity_costMod.Size = new System.Drawing.Size(165, 20);
            this.tb_quantity_costMod.TabIndex = 10;
            // 
            // tb_longDescription_costMod
            // 
            this.tb_longDescription_costMod.Location = new System.Drawing.Point(102, 102);
            this.tb_longDescription_costMod.Name = "tb_longDescription_costMod";
            this.tb_longDescription_costMod.Size = new System.Drawing.Size(124, 20);
            this.tb_longDescription_costMod.TabIndex = 9;
            // 
            // tb_stockCode_costMod
            // 
            this.tb_stockCode_costMod.Location = new System.Drawing.Point(78, 53);
            this.tb_stockCode_costMod.Name = "tb_stockCode_costMod";
            this.tb_stockCode_costMod.Size = new System.Drawing.Size(148, 20);
            this.tb_stockCode_costMod.TabIndex = 8;
            // 
            // tb_description_costMod
            // 
            this.tb_description_costMod.Location = new System.Drawing.Point(78, 78);
            this.tb_description_costMod.Name = "tb_description_costMod";
            this.tb_description_costMod.Size = new System.Drawing.Size(148, 20);
            this.tb_description_costMod.TabIndex = 7;
            // 
            // tb_warehouse_costMod
            // 
            this.tb_warehouse_costMod.Location = new System.Drawing.Point(78, 27);
            this.tb_warehouse_costMod.Name = "tb_warehouse_costMod";
            this.tb_warehouse_costMod.Size = new System.Drawing.Size(148, 20);
            this.tb_warehouse_costMod.TabIndex = 6;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 152);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(75, 13);
            this.label22.TabIndex = 5;
            this.label22.Text = "Previous Cost:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 128);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(49, 13);
            this.label23.TabIndex = 4;
            this.label23.Text = "Quantity:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 104);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(90, 13);
            this.label24.TabIndex = 3;
            this.label24.Text = "Long Description:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 79);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(63, 13);
            this.label25.TabIndex = 2;
            this.label25.Text = "Description:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 54);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(65, 13);
            this.label26.TabIndex = 1;
            this.label26.Text = "Stock code:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(7, 30);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(65, 13);
            this.label27.TabIndex = 0;
            this.label27.Text = "Warehouse:";
            // 
            // transfersOut_gb
            // 
            this.transfersOut_gb.Controls.Add(this.post_transfersOut);
            this.transfersOut_gb.Controls.Add(this.tb_newWarehouse_transfersOut);
            this.transfersOut_gb.Controls.Add(this.label43);
            this.transfersOut_gb.Controls.Add(this.tb_release_transfersOut);
            this.transfersOut_gb.Controls.Add(this.label15);
            this.transfersOut_gb.Controls.Add(this.tb_revision_transfersOut);
            this.transfersOut_gb.Controls.Add(this.tb_quantity_transfersOut);
            this.transfersOut_gb.Controls.Add(this.tb_longDescription_transfersOut);
            this.transfersOut_gb.Controls.Add(this.tb_stockCode_transfersOut);
            this.transfersOut_gb.Controls.Add(this.tb_description_transfersOut);
            this.transfersOut_gb.Controls.Add(this.tb_warehouse_transfersOut);
            this.transfersOut_gb.Controls.Add(this.label29);
            this.transfersOut_gb.Controls.Add(this.label30);
            this.transfersOut_gb.Controls.Add(this.label31);
            this.transfersOut_gb.Controls.Add(this.label32);
            this.transfersOut_gb.Controls.Add(this.label33);
            this.transfersOut_gb.Controls.Add(this.label34);
            this.transfersOut_gb.Location = new System.Drawing.Point(12, 48);
            this.transfersOut_gb.Name = "transfersOut_gb";
            this.transfersOut_gb.Size = new System.Drawing.Size(251, 326);
            this.transfersOut_gb.TabIndex = 15;
            this.transfersOut_gb.TabStop = false;
            this.transfersOut_gb.Text = "Transaction Details";
            // 
            // tb_revision_transfersOut
            // 
            this.tb_revision_transfersOut.Location = new System.Drawing.Point(63, 149);
            this.tb_revision_transfersOut.Name = "tb_revision_transfersOut";
            this.tb_revision_transfersOut.Size = new System.Drawing.Size(163, 20);
            this.tb_revision_transfersOut.TabIndex = 11;
            // 
            // tb_quantity_transfersOut
            // 
            this.tb_quantity_transfersOut.Location = new System.Drawing.Point(61, 125);
            this.tb_quantity_transfersOut.Name = "tb_quantity_transfersOut";
            this.tb_quantity_transfersOut.Size = new System.Drawing.Size(165, 20);
            this.tb_quantity_transfersOut.TabIndex = 10;
            // 
            // tb_longDescription_transfersOut
            // 
            this.tb_longDescription_transfersOut.Location = new System.Drawing.Point(102, 102);
            this.tb_longDescription_transfersOut.Name = "tb_longDescription_transfersOut";
            this.tb_longDescription_transfersOut.Size = new System.Drawing.Size(124, 20);
            this.tb_longDescription_transfersOut.TabIndex = 9;
            // 
            // tb_stockCode_transfersOut
            // 
            this.tb_stockCode_transfersOut.Location = new System.Drawing.Point(78, 53);
            this.tb_stockCode_transfersOut.Name = "tb_stockCode_transfersOut";
            this.tb_stockCode_transfersOut.Size = new System.Drawing.Size(148, 20);
            this.tb_stockCode_transfersOut.TabIndex = 8;
            // 
            // tb_description_transfersOut
            // 
            this.tb_description_transfersOut.Location = new System.Drawing.Point(78, 78);
            this.tb_description_transfersOut.Name = "tb_description_transfersOut";
            this.tb_description_transfersOut.Size = new System.Drawing.Size(148, 20);
            this.tb_description_transfersOut.TabIndex = 7;
            // 
            // tb_warehouse_transfersOut
            // 
            this.tb_warehouse_transfersOut.Location = new System.Drawing.Point(78, 27);
            this.tb_warehouse_transfersOut.Name = "tb_warehouse_transfersOut";
            this.tb_warehouse_transfersOut.Size = new System.Drawing.Size(148, 20);
            this.tb_warehouse_transfersOut.TabIndex = 6;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(6, 152);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(51, 13);
            this.label29.TabIndex = 5;
            this.label29.Text = "Revision:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(6, 128);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(49, 13);
            this.label30.TabIndex = 4;
            this.label30.Text = "Quantity:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(6, 104);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(90, 13);
            this.label31.TabIndex = 3;
            this.label31.Text = "Long Description:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(6, 79);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(63, 13);
            this.label32.TabIndex = 2;
            this.label32.Text = "Description:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(6, 54);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(65, 13);
            this.label33.TabIndex = 1;
            this.label33.Text = "Stock code:";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(7, 30);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(65, 13);
            this.label34.TabIndex = 0;
            this.label34.Text = "Warehouse:";
            // 
            // transfersIn_gb
            // 
            this.transfersIn_gb.Controls.Add(this.post_transfersIn);
            this.transfersIn_gb.Controls.Add(this.tb_release_transfersIn);
            this.transfersIn_gb.Controls.Add(this.label44);
            this.transfersIn_gb.Controls.Add(this.tb_revision_transfersIn);
            this.transfersIn_gb.Controls.Add(this.tb_quantity_transfersIn);
            this.transfersIn_gb.Controls.Add(this.tb_longDescription_transfersIn);
            this.transfersIn_gb.Controls.Add(this.tb_stockCode_transfersIn);
            this.transfersIn_gb.Controls.Add(this.tb_description_transfersIn);
            this.transfersIn_gb.Controls.Add(this.tb_warehouse_transfersIn);
            this.transfersIn_gb.Controls.Add(this.label36);
            this.transfersIn_gb.Controls.Add(this.label37);
            this.transfersIn_gb.Controls.Add(this.label38);
            this.transfersIn_gb.Controls.Add(this.label39);
            this.transfersIn_gb.Controls.Add(this.label40);
            this.transfersIn_gb.Controls.Add(this.label41);
            this.transfersIn_gb.Location = new System.Drawing.Point(12, 48);
            this.transfersIn_gb.Name = "transfersIn_gb";
            this.transfersIn_gb.Size = new System.Drawing.Size(251, 326);
            this.transfersIn_gb.TabIndex = 15;
            this.transfersIn_gb.TabStop = false;
            this.transfersIn_gb.Text = "Transaction Details";
            // 
            // tb_revision_transfersIn
            // 
            this.tb_revision_transfersIn.Location = new System.Drawing.Point(61, 149);
            this.tb_revision_transfersIn.Name = "tb_revision_transfersIn";
            this.tb_revision_transfersIn.Size = new System.Drawing.Size(165, 20);
            this.tb_revision_transfersIn.TabIndex = 11;
            // 
            // tb_quantity_transfersIn
            // 
            this.tb_quantity_transfersIn.Location = new System.Drawing.Point(61, 125);
            this.tb_quantity_transfersIn.Name = "tb_quantity_transfersIn";
            this.tb_quantity_transfersIn.Size = new System.Drawing.Size(165, 20);
            this.tb_quantity_transfersIn.TabIndex = 10;
            // 
            // tb_longDescription_transfersIn
            // 
            this.tb_longDescription_transfersIn.Location = new System.Drawing.Point(102, 102);
            this.tb_longDescription_transfersIn.Name = "tb_longDescription_transfersIn";
            this.tb_longDescription_transfersIn.Size = new System.Drawing.Size(124, 20);
            this.tb_longDescription_transfersIn.TabIndex = 9;
            // 
            // tb_stockCode_transfersIn
            // 
            this.tb_stockCode_transfersIn.Location = new System.Drawing.Point(78, 53);
            this.tb_stockCode_transfersIn.Name = "tb_stockCode_transfersIn";
            this.tb_stockCode_transfersIn.Size = new System.Drawing.Size(148, 20);
            this.tb_stockCode_transfersIn.TabIndex = 8;
            // 
            // tb_description_transfersIn
            // 
            this.tb_description_transfersIn.Location = new System.Drawing.Point(78, 78);
            this.tb_description_transfersIn.Name = "tb_description_transfersIn";
            this.tb_description_transfersIn.Size = new System.Drawing.Size(148, 20);
            this.tb_description_transfersIn.TabIndex = 7;
            // 
            // tb_warehouse_transfersIn
            // 
            this.tb_warehouse_transfersIn.Location = new System.Drawing.Point(78, 27);
            this.tb_warehouse_transfersIn.Name = "tb_warehouse_transfersIn";
            this.tb_warehouse_transfersIn.Size = new System.Drawing.Size(148, 20);
            this.tb_warehouse_transfersIn.TabIndex = 6;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(6, 152);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(51, 13);
            this.label36.TabIndex = 5;
            this.label36.Text = "Revision:";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(6, 128);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(49, 13);
            this.label37.TabIndex = 4;
            this.label37.Text = "Quantity:";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(6, 104);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(90, 13);
            this.label38.TabIndex = 3;
            this.label38.Text = "Long Description:";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(6, 79);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(63, 13);
            this.label39.TabIndex = 2;
            this.label39.Text = "Description:";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(6, 54);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(65, 13);
            this.label40.TabIndex = 1;
            this.label40.Text = "Stock code:";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(7, 30);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(65, 13);
            this.label41.TabIndex = 0;
            this.label41.Text = "Warehouse:";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(7, 175);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(56, 13);
            this.label42.TabIndex = 13;
            this.label42.Text = "New Cost:";
            // 
            // tb_newCost_costMod
            // 
            this.tb_newCost_costMod.Location = new System.Drawing.Point(69, 174);
            this.tb_newCost_costMod.Name = "tb_newCost_costMod";
            this.tb_newCost_costMod.Size = new System.Drawing.Size(157, 20);
            this.tb_newCost_costMod.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 175);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 13;
            this.label15.Text = "Release:";
            // 
            // tb_release_transfersOut
            // 
            this.tb_release_transfersOut.Location = new System.Drawing.Point(62, 173);
            this.tb_release_transfersOut.Name = "tb_release_transfersOut";
            this.tb_release_transfersOut.Size = new System.Drawing.Size(164, 20);
            this.tb_release_transfersOut.TabIndex = 14;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(7, 201);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(90, 13);
            this.label43.TabIndex = 15;
            this.label43.Text = "New Warehouse:";
            // 
            // tb_newWarehouse_transfersOut
            // 
            this.tb_newWarehouse_transfersOut.Location = new System.Drawing.Point(98, 197);
            this.tb_newWarehouse_transfersOut.Name = "tb_newWarehouse_transfersOut";
            this.tb_newWarehouse_transfersOut.Size = new System.Drawing.Size(128, 20);
            this.tb_newWarehouse_transfersOut.TabIndex = 16;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(6, 178);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(49, 13);
            this.label44.TabIndex = 13;
            this.label44.Text = "Release:";
            // 
            // tb_release_transfersIn
            // 
            this.tb_release_transfersIn.Location = new System.Drawing.Point(61, 175);
            this.tb_release_transfersIn.Name = "tb_release_transfersIn";
            this.tb_release_transfersIn.Size = new System.Drawing.Size(165, 20);
            this.tb_release_transfersIn.TabIndex = 14;
            // 
            // post_costChanges
            // 
            this.post_costChanges.Location = new System.Drawing.Point(82, 297);
            this.post_costChanges.Name = "post_costChanges";
            this.post_costChanges.Size = new System.Drawing.Size(90, 23);
            this.post_costChanges.TabIndex = 13;
            this.post_costChanges.Text = "Post";
            this.post_costChanges.UseVisualStyleBackColor = true;
            // 
            // post_costModifications
            // 
            this.post_costModifications.Location = new System.Drawing.Point(82, 297);
            this.post_costModifications.Name = "post_costModifications";
            this.post_costModifications.Size = new System.Drawing.Size(90, 23);
            this.post_costModifications.TabIndex = 15;
            this.post_costModifications.Text = "Post";
            this.post_costModifications.UseVisualStyleBackColor = true;
            // 
            // post_transfersOut
            // 
            this.post_transfersOut.Location = new System.Drawing.Point(82, 297);
            this.post_transfersOut.Name = "post_transfersOut";
            this.post_transfersOut.Size = new System.Drawing.Size(90, 23);
            this.post_transfersOut.TabIndex = 17;
            this.post_transfersOut.Text = "Post";
            this.post_transfersOut.UseVisualStyleBackColor = true;
            // 
            // post_transfersIn
            // 
            this.post_transfersIn.Location = new System.Drawing.Point(82, 297);
            this.post_transfersIn.Name = "post_transfersIn";
            this.post_transfersIn.Size = new System.Drawing.Size(90, 23);
            this.post_transfersIn.TabIndex = 15;
            this.post_transfersIn.Text = "Post";
            this.post_transfersIn.UseVisualStyleBackColor = true;
            // 
            // post_adjustments
            // 
            this.post_adjustments.Location = new System.Drawing.Point(82, 297);
            this.post_adjustments.Name = "post_adjustments";
            this.post_adjustments.Size = new System.Drawing.Size(90, 23);
            this.post_adjustments.TabIndex = 14;
            this.post_adjustments.Text = "Post";
            this.post_adjustments.UseVisualStyleBackColor = true;
            // 
            // post_receipts
            // 
            this.post_receipts.Location = new System.Drawing.Point(82, 297);
            this.post_receipts.Name = "post_receipts";
            this.post_receipts.Size = new System.Drawing.Size(90, 23);
            this.post_receipts.TabIndex = 14;
            this.post_receipts.Text = "Post";
            this.post_receipts.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 383);
            this.Controls.Add(this.transfersIn_gb);
            this.Controls.Add(this.costModifications_gb);
            this.Controls.Add(this.costChanges_gb);
            this.Controls.Add(this.transfersOut_gb);
            this.Controls.Add(this.adjustments_gb);
            this.Controls.Add(this.receipts_gb);
            this.Controls.Add(this.transactionType_label);
            this.Controls.Add(this.transactionType);
            this.Name = "Form1";
            this.Text = "Inventory Movements";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.receipts_gb.ResumeLayout(false);
            this.receipts_gb.PerformLayout();
            this.adjustments_gb.ResumeLayout(false);
            this.adjustments_gb.PerformLayout();
            this.costChanges_gb.ResumeLayout(false);
            this.costChanges_gb.PerformLayout();
            this.costModifications_gb.ResumeLayout(false);
            this.costModifications_gb.PerformLayout();
            this.transfersOut_gb.ResumeLayout(false);
            this.transfersOut_gb.PerformLayout();
            this.transfersIn_gb.ResumeLayout(false);
            this.transfersIn_gb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox transactionType;
        private System.Windows.Forms.Label transactionType_label;
        private System.Windows.Forms.GroupBox receipts_gb;
        private System.Windows.Forms.TextBox tb_receiptCost_receipts;
        private System.Windows.Forms.TextBox tb_quantity_receipts;
        private System.Windows.Forms.TextBox tb_longDescription_receipts;
        private System.Windows.Forms.TextBox tb_stockCode_receipts;
        private System.Windows.Forms.TextBox tb_description_receipts;
        private System.Windows.Forms.TextBox tb_warehouse_receipts;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox adjustments_gb;
        private System.Windows.Forms.TextBox tb_quantity_adjustments;
        private System.Windows.Forms.TextBox tb_longDescription_adjustments;
        private System.Windows.Forms.TextBox tb_stockCode_adjustments;
        private System.Windows.Forms.TextBox tb_description_adjustments;
        private System.Windows.Forms.TextBox tb_warehouse_adjustments;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox costChanges_gb;
        private System.Windows.Forms.TextBox tb_newCost_costChanges;
        private System.Windows.Forms.TextBox tb_longDescription_costChanges;
        private System.Windows.Forms.TextBox tb_stockCode_costChanges;
        private System.Windows.Forms.TextBox tb_description_costChanges;
        private System.Windows.Forms.TextBox tb_warehouse_costChanges;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox costModifications_gb;
        private System.Windows.Forms.TextBox tb_prevCost_costMod;
        private System.Windows.Forms.TextBox tb_quantity_costMod;
        private System.Windows.Forms.TextBox tb_longDescription_costMod;
        private System.Windows.Forms.TextBox tb_stockCode_costMod;
        private System.Windows.Forms.TextBox tb_description_costMod;
        private System.Windows.Forms.TextBox tb_warehouse_costMod;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.GroupBox transfersOut_gb;
        private System.Windows.Forms.GroupBox transfersIn_gb;
        private System.Windows.Forms.TextBox tb_revision_transfersIn;
        private System.Windows.Forms.TextBox tb_quantity_transfersIn;
        private System.Windows.Forms.TextBox tb_longDescription_transfersIn;
        private System.Windows.Forms.TextBox tb_stockCode_transfersIn;
        private System.Windows.Forms.TextBox tb_description_transfersIn;
        private System.Windows.Forms.TextBox tb_warehouse_transfersIn;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox tb_revision_transfersOut;
        private System.Windows.Forms.TextBox tb_quantity_transfersOut;
        private System.Windows.Forms.TextBox tb_longDescription_transfersOut;
        private System.Windows.Forms.TextBox tb_stockCode_transfersOut;
        private System.Windows.Forms.TextBox tb_description_transfersOut;
        private System.Windows.Forms.TextBox tb_warehouse_transfersOut;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox tb_newCost_costMod;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox tb_newWarehouse_transfersOut;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.TextBox tb_release_transfersOut;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tb_release_transfersIn;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Button post_receipts;
        private System.Windows.Forms.Button post_adjustments;
        private System.Windows.Forms.Button post_costChanges;
        private System.Windows.Forms.Button post_costModifications;
        private System.Windows.Forms.Button post_transfersOut;
        private System.Windows.Forms.Button post_transfersIn;
    }
}

