using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SYSPROWCFServicesClientLibrary40;
using System.Xml;

namespace WCF_Client_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                SYSPROWCFServicesPrimitiveClient sc = new SYSPROWCFServicesPrimitiveClient("net.tcp://10.2.3.10:500/SYSPROWCFService/Soap", SYSPROWCFBinding.NetTcp);
                string guid = sc.Logon("ENET5", "", "0", "");
                //MessageBox.Show("GUID: " + guid);

                #region APSTIN
                /**
                string XMLparams = "<PostApInvoice>" +
                "<Parameters>" +
                "<PostingPeriod>C</PostingPeriod>" +
                "<IgnoreWarnings>N</IgnoreWarnings>" +
                "<ApplyIfEntireDocumentValid>Y</ApplyIfEntireDocumentValid>" +
                "<ValidateOnly>N</ValidateOnly>" +
                "<PostZeroAdjustments>N</PostZeroAdjustments>" +
                "<DefaultDiscountDate/>" +
                "<DefaultDueDate/>" +
                "<LedgerDistributionCurrency>L</LedgerDistributionCurrency>" +
                "<AutomaticTaxCalculation>N</AutomaticTaxCalculation>" +
                "<PermissibleTaxVariance>0.05</PermissibleTaxVariance>" +
                "<ApArContraTrx>N</ApArContraTrx>" +
                "<IgnoreAnalysis>Y</IgnoreAnalysis>" +
                "</Parameters>" +
                "</PostApInvoice>";
                **/
                /*string XMLin = "<Query><Key><StockCode><![CDATA[101047]]></StockCode></Key></Query>";*/
                /**
                string XMLin = "<PostApInvoice>" +
                "<Item>" +
                "<Supplier>" +supplier.Text +"</Supplier>" +
                "<TransactionCode>I</TransactionCode>" +                
                "<Invoice>0876541</Invoice>" + //0876541
                "<TransactionValue>100.00</TransactionValue>" +
                "<FreightCharge>2.00</FreightCharge>" +
                "<MiscellaneousCharge/>" +
                "<Notation>Notation for invoice 1</Notation>" +
                "<TransactionReference>Invoice reference</TransactionReference>" +
                "<JournalNotation>Journal notation</JournalNotation>" +
                "<DiscountBasis>P</DiscountBasis>" +
                "<DiscountableValue>100.00</DiscountableValue>" +
                "<DiscountPercentageValue>2.50</DiscountPercentageValue>" +
                "<InvoiceDate/>" +                
                "<ExchRateAtEntry/>" +
                "<FixedExchRate/>" +
                "<TaxBasis>E</TaxBasis>" +
                "<TaxCode>B</TaxCode>" +
                "<TaxValue></TaxValue>" +
                "<LedgerDistribution>" +
                "<LedgerCode>00-8052</LedgerCode>" +
                "<LedgerTaxCode>B</LedgerTaxCode>" +
                "<LedgerNotation></LedgerNotation>" +
                "<LedgerValue>100.00</LedgerValue>" +
                "</LedgerDistribution>" +
                "</Item>" +
                "</PostApInvoice>";

                //MessageBox.Show(sc.QueryQuery(guid, "INVQRY", XMLin));
                MessageBox.Show(sc.TransactionPost(guid, "APSTIN", XMLparams, XMLin));
                **/
                #endregion

                #region SORTOI
                /*string XMLparams = "<SalesOrders>" +
                "<Parameters>" +
                "<InBoxMsgReqd>Y</InBoxMsgReqd>" +
                "<Process>IMPORT</Process>" +
                "<CustomerToUse/>" +
                "<WarehouseListToUse></WarehouseListToUse>" +
                "<TypeOfOrder>ORD</TypeOfOrder>" +
                "<OrderStatus>1</OrderStatus>" +
                "<MinimumDaysToShip>4</MinimumDaysToShip>" +
                "<AllowNonStockItems>Y</AllowNonStockItems>" +
                "<AcceptOrdersIfNoCredit>Y</AcceptOrdersIfNoCredit>" +
                "<AcceptEarlierShipDate>N</AcceptEarlierShipDate>" +
                "<OperatorToInform>ADMIN</OperatorToInform>" +
                "<CreditFailMessage>No credit available</CreditFailMessage>" +
                "<ValidProductClassList></ValidProductClassList>" +
                "<ShipFromDefaultBin>N</ShipFromDefaultBin>" +
                "<AllowDuplicateOrderNumbers>N</AllowDuplicateOrderNumbers>" +
                "<CheckForCustomerPoNumbers>N</CheckForCustomerPoNumbers>" +
                "<AllowInvoiceInformationEntry/>" +
                "<AlwaysUsePriceEntered/>" +
                "<AllowZeroPrice/>" +
                "<AllowChangeToZeroPrice></AllowChangeToZeroPrice>" +
                "<AddStockSalesOrderText>N</AddStockSalesOrderText>" +
                "<AddDangerousGoodsText>N</AddDangerousGoodsText>" +
                "<UseStockDescSupplied/>" +
                "<ValidateShippingInstrs/>" +
                "<AllocationAction></AllocationAction>" +
                "<IgnoreWarnings>N</IgnoreWarnings>" +
                "<AddAttachedServiceCharges></AddAttachedServiceCharges>" +
                "<StatusInProcess></StatusInProcess>" +
                "<StatusInProcessResponse></StatusInProcessResponse>" +
                "<WarnIfCustomerOnHold>N</WarnIfCustomerOnHold>" +
                "<AcceptKitOptional>N</AcceptKitOptional>" +
                "<AllowBackOrderForPartialHold></AllowBackOrderForPartialHold>" +
                "<AllowBackOrderForSuperseded></AllowBackOrderForSuperseded>" +
                "<OverrideCustomerBackOrder></OverrideCustomerBackOrder>" +
                "<UseMasterAccountForCustomerPartNo></UseMasterAccountForCustomerPartNo>" +
                "<ApplyLeadTimeCalculation></ApplyLeadTimeCalculation>" +
                "<ApplyParentDiscountToComponents>N</ApplyParentDiscountToComponents>" +
                "<AllowManualOrderNumberToBeUsed>N</AllowManualOrderNumberToBeUsed>" +
                "<ReserveStock></ReserveStock>" +
                "<ReserveStockRequestAllocs></ReserveStockRequestAllocs>" +
                "<AllowBackOrderForNegativeMerchLine>N</AllowBackOrderForNegativeMerchLine>" +
                "</Parameters>" +
                "</SalesOrders>";

                string XMLin = "<SalesOrders>" +
                "<Orders>" +
                "<OrderHeader>" +
                "<CustomerPoNumber></CustomerPoNumber>" +
                "<OrderActionType>" +box1.Text+"</OrderActionType>" +
                "<Customer>" + box2.Text + "</Customer>" +
                "<OrderDate></OrderDate>" +
                "<ShippingInstrs>" + box3.Text + "</ShippingInstrs>" +
                "<SpecialInstrs>" + box4.Text + "</SpecialInstrs>" +
                "<SalesOrder></SalesOrder>" +
                "<RequestedShipDate></RequestedShipDate>" +
                "<InvoiceNumberEntered/>" +
                "<InvoiceDateEntered/>" +
                "<OrderComments/>" +
                "</OrderHeader>" +
                "<OrderDetails>" +
                "<StockLine>" +
                "<CustomerPoLine>" + box5.Text + "</CustomerPoLine>" +
                "<LineActionType>" + box6.Text + "</LineActionType>" +
                "<StockCode>" + box7.Text + "</StockCode>" +
                "<Warehouse>" + box8.Text + "</Warehouse>" +
                "<OrderQty>" + box9.Text + "</OrderQty>" +
                "<OrderUom>" + box10.Text + "</OrderUom>" +
                "<Price>" + box11.Text + "</Price>" +
                "<PriceUom>" + box12.Text + "</PriceUom>" +
                "<LineDiscPercent1>" + box13.Text + "</LineDiscPercent1>" +
                "<LineDiscPercent2>" + box14.Text + "</LineDiscPercent2>" +
                "<LineDiscPercent3>" + box15.Text + "</LineDiscPercent3>" +
                "</StockLine>" +
                "</OrderDetails>" +
                "</Orders>" +
                "</SalesOrders>";

                MessageBox.Show(sc.TransactionPost(guid, "SORTOI", XMLparams, XMLin));*/
                #endregion

                #region ARSTIN
                string XMLparams = "<PostArInvoices>" +
                "<Parameters>" +
                "<IgnoreWarnings>N</IgnoreWarnings>" +
                "<ApplyIfEntireDocumentValid>Y</ApplyIfEntireDocumentValid>" +
                "<ValidateOnly>N</ValidateOnly>" +
                "<PostingPeriod>C</PostingPeriod>" +
                "</Parameters>" +
                "</PostArInvoices>";

                string XMLin = "<PostArInvoices>" +
                "<Item>" +
                "<TransactionType>" + textBox1.Text + "</TransactionType>" + //I
                "<Customer>" + textBox2.Text + "</Customer>" + //000001
                "<PostToExistingInvoice>" + textBox3.Text + "</PostToExistingInvoice>" + //N
                "<GenerateInvoiceNumber>" + textBox4.Text + "</GenerateInvoiceNumber>" + //Y
                "<Invoice/>" +
                "<InvoiceDate>" + textBox5.Text + "</InvoiceDate>" + //2006-10-16
                "<Reference>" + textBox6.Text + "</Reference>" + //Purchase order 999
                "<InvoiceValue>" + textBox7.Text + "</InvoiceValue>" + //15000.00
                "<CostValue>" + textBox8.Text + "</CostValue>" + //10000.00
                "<ProductClass>" + textBox9.Text + "</ProductClass>" + //BA
                "<InvoiceTerms>" + textBox10.Text + "</InvoiceTerms>" + //0
                "</Item>" +
                "</PostArInvoices>";

                MessageBox.Show(sc.TransactionPost(guid, "ARSTIN", XMLparams, XMLin));
                #endregion

                #region ARSTPY
                /*string XMLparams = "<PostArPayment>" +
                "<Parameters>" +
                "<PostingPeriod>C</PostingPeriod>" +
                "<IgnoreWarnings>N</IgnoreWarnings>" +
                "<ApplyIfEntireDocumentValid>Y</ApplyIfEntireDocumentValid>" +
                "<ValidateOnly>N</ValidateOnly>" +
                "<AutoCorrectPaymentValue>N</AutoCorrectPaymentValue>" +
                "<ApplySpecificBranch>N</ApplySpecificBranch>" +
                "<BranchToUse/>" +
                "<AreaToUseForLedgerIntegration/>" +
                "<IntegrateToCashBookInDetail>N</IntegrateToCashBookInDetail>" +
                "<AutoCalculateTax>N</AutoCalculateTax>" +
                "<IgnoreAnalysis>Y</IgnoreAnalysis>" +
                "</Parameters>" +
                "</PostArPayment>";

                string XMLin = "<PostArPayment>" +
                "<Item>" +
                "<Payment>" +
                "<Customer>000001</Customer>" +
                "<PaymentValue>30.00</PaymentValue>" +
                "<Reference/>" +
                "<PaymentDate/>" +
                "<JournalNotation/>" +
                "<PaymentNarration/>" +
                "<ApplyDuePostDatedChecks>N</ApplyDuePostDatedChecks>" +
                "<Bank>GB</Bank>" +
                "<PaymentType>C</PaymentType>" +
                "<DrawerName/>" +
                "<DrawerBank/>" +
                "<DrawerBranch/>" +
                "<InvoiceToPay>" +
                "<TransactionType>I</TransactionType>" +
                "<Invoice>100466</Invoice>" +
                "<GrossPaymentValue>20.00</GrossPaymentValue>" +
                "</InvoiceToPay>" +
                    "<UnappliedPayment>" +
                    "<GrossPaymentValue>10.00</GrossPaymentValue>" +
                    "<DiscountValue/>" +
                    "<TaxPortionOfDiscount/>" +
                    "<WithholdingTaxValue/>" +
                    "<ExchangeRateToUse/>" +
                    "<CustomerPurchaseOrder/>" +
                    "</UnappliedPayment>" +
                "</Payment>" +
                "</Item>" +
                "</PostArPayment>";

                MessageBox.Show(sc.TransactionPost(guid, "ARSTPY", XMLparams, XMLin));*/
                #endregion

                sc.Logoff(guid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonArstpyOK_Click(object sender, EventArgs e)
        {
            try
            {
                SYSPROWCFServicesPrimitiveClient sc = new SYSPROWCFServicesPrimitiveClient("net.tcp://10.2.3.10:500/SYSPROWCFService/Soap", SYSPROWCFBinding.NetTcp);
                string guid = sc.Logon("ENET5", "", "0", "");

                #region ARSTPY
                string XMLparams = "<PostArPayment>" +
                "<Parameters>" +
                "<PostingPeriod>C</PostingPeriod>" +
                "<IgnoreWarnings>N</IgnoreWarnings>" +
                "<ApplyIfEntireDocumentValid>Y</ApplyIfEntireDocumentValid>" +
                "<ValidateOnly>N</ValidateOnly>" +
                "<AutoCorrectPaymentValue>N</AutoCorrectPaymentValue>" +
                "<ApplySpecificBranch>N</ApplySpecificBranch>" +
                "<BranchToUse/>" +
                "<AreaToUseForLedgerIntegration/>" +
                "<IntegrateToCashBookInDetail>N</IntegrateToCashBookInDetail>" +
                "<AutoCalculateTax>N</AutoCalculateTax>" +
                "<IgnoreAnalysis>Y</IgnoreAnalysis>" +
                "</Parameters>" +
                "</PostArPayment>";

                string XMLin = "<PostArPayment>" +
                "<Item>" +
                "<Payment>" +
                "<Customer>" + textBox11.Text + "</Customer>" + //000001
                "<PaymentValue>" + textBox12.Text + "</PaymentValue>" + //30.00
                "<Reference/>" +
                "<PaymentDate/>" +
                "<JournalNotation/>" +
                "<PaymentNarration/>" +
                "<ApplyDuePostDatedChecks>" + textBox13.Text + "</ApplyDuePostDatedChecks>" + //N
                "<Bank>" + textBox14.Text + "</Bank>" + //GB
                "<PaymentType>" + textBox15.Text + "</PaymentType>" + //C
                "<DrawerName/>" +
                "<DrawerBank/>" +
                "<DrawerBranch/>" +
                "<InvoiceToPay>" +
                "<TransactionType>" + textBox16.Text + "</TransactionType>" + //I
                "<Invoice>" + textBox17.Text + "</Invoice>" + //100466
                "<GrossPaymentValue>" + textBox18.Text + "</GrossPaymentValue>" + //20.00
                "</InvoiceToPay>" +
                    /*"<UnappliedPayment>" +
                    "<GrossPaymentValue>10.00</GrossPaymentValue>" +
                    "<DiscountValue/>" +
                    "<TaxPortionOfDiscount/>" +
                    "<WithholdingTaxValue/>" +
                    "<ExchangeRateToUse/>" +
                    "<CustomerPurchaseOrder/>" +
                    "</UnappliedPayment>" +*/
                "</Payment>" +
                "</Item>" +
                "</PostArPayment>";

                MessageBox.Show(sc.TransactionPost(guid, "ARSTPY", XMLparams, XMLin));
                #endregion

                sc.Logoff(guid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*string output = "";
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("http://rss.cnn.com/rss/edition_world.rss");
            XmlNodeList titleNodes = xmlDoc.SelectNodes("//rss/channel/item/title");
            foreach (XmlNode titleNode in titleNodes)
            {
                output += (titleNode.InnerText + "\n");
            }
            MessageBox.Show(output);*/

            try
            {
                SYSPROWCFServicesPrimitiveClient sc = new SYSPROWCFServicesPrimitiveClient("net.tcp://10.2.3.10:500/SYSPROWCFService/Soap", SYSPROWCFBinding.NetTcp);
                string guid = sc.Logon("ENET5", "", "0", "");
                string output = "";
                string XMLin = "<Query><Key><StockCode><![CDATA[101047]]></StockCode></Key></Query>";

                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(sc.QueryQuery(guid, "INVQRY", XMLin));

                XmlNodeList itemNodes = xmlDoc.SelectNodes("//Warehouse");
                foreach (XmlNode xmlNode in itemNodes)
                {
                    output += ("Name: " + xmlNode.Name + "\nInner Text: " + xmlNode.InnerText + "\n\n");
                }
                MessageBox.Show(output);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
