using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using SYSPROWCFServicesClientLibrary40;

namespace OUTDOORS
{
    public partial class Main : Form
    {
        private List<XmlDocument> documents;
        private List<string> fileNames;

        public Main()
        {
            InitializeComponent();
            transactionType.SelectedIndex = 0;
            transactionType.SelectedIndexChanged += new EventHandler(comboBox1_SelectedIndexChanged);

            documents = new List<XmlDocument>();
            fileNames = new List<string>();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (transactionType.SelectedIndex)
            {
                case 0:
                    receipts_gb.Visible = true;

                    adjustments_gb.Visible = false;
                    costChanges_gb.Visible = false;
                    costModifications_gb.Visible = false;
                    transfersOut_gb.Visible = false;
                    transfersIn_gb.Visible = false;
                    break;

                case 1:
                    adjustments_gb.Visible = true;
                    
                    receipts_gb.Visible = false;
                    costChanges_gb.Visible = false;
                    costModifications_gb.Visible = false;
                    transfersOut_gb.Visible = false;
                    transfersIn_gb.Visible = false;
                    break;

                case 2:
                    costChanges_gb.Visible = true;

                    adjustments_gb.Visible = false;
                    receipts_gb.Visible = false;
                    costModifications_gb.Visible = false;
                    transfersOut_gb.Visible = false;
                    transfersIn_gb.Visible = false;
                    break;

                case 3:
                    costModifications_gb.Visible = true;

                    costChanges_gb.Visible = false;
                    adjustments_gb.Visible = false;
                    receipts_gb.Visible = false;
                    transfersOut_gb.Visible = false;
                    transfersIn_gb.Visible = false;
                    break;

                case 4:
                    transfersOut_gb.Visible = true;

                    costModifications_gb.Visible = false;
                    costChanges_gb.Visible = false;
                    adjustments_gb.Visible = false;
                    receipts_gb.Visible = false;
                    transfersIn_gb.Visible = false;
                    break;

                case 5:
                    transfersIn_gb.Visible = true;

                    transfersOut_gb.Visible = false;
                    costModifications_gb.Visible = false;
                    costChanges_gb.Visible = false;
                    adjustments_gb.Visible = false;
                    receipts_gb.Visible = false;
                    break;

                default:
                    break;
            }
        }

        private void post_receipts_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            XmlNode root = doc.CreateElement("PostInvReceipts");

            //XML Input
            XmlNode input = doc.CreateElement("Item");
            input.AppendChild(doc.CreateElement("Journal")).InnerText = tb_receipts_journal.Text;
            input.AppendChild(doc.CreateElement("Warehouse")).InnerText = tb_receipts_warehouse.Text;
            input.AppendChild(doc.CreateElement("StockCode")).InnerText = tb_receipts_stockCode.Text;
            input.AppendChild(doc.CreateElement("Version")).InnerText = tb_receipts_version.Text;
            input.AppendChild(doc.CreateElement("Release")).InnerText = tb_receipts_release.Text;
            input.AppendChild(doc.CreateElement("Quantity")).InnerText = tb_receipts_quantity.Text;
            input.AppendChild(doc.CreateElement("UnitOfMeasure")).InnerText = tb_receipts_unitOfMeasure.Text;
            input.AppendChild(doc.CreateElement("Units")).InnerText = tb_receipts_units.Text;
            input.AppendChild(doc.CreateElement("Pieces")).InnerText = tb_receipts_pieces.Text;
            input.AppendChild(doc.CreateElement("UnitCost")).InnerText = tb_receipts_unitCost.Text;
            input.AppendChild(doc.CreateElement("TotalCost")).InnerText = tb_receipts_totalCost.Text;
            input.AppendChild(doc.CreateElement("FifoBucket")).InnerText = tb_receipts_fifoBucket.Text;
            input.AppendChild(doc.CreateElement("Lot")).InnerText = tb_receipts_lot.Text;
            input.AppendChild(doc.CreateElement("LotConcession")).InnerText = tb_receipts_lotConcession.Text;
            input.AppendChild(doc.CreateElement("LotExpiryDate")).InnerText = tb_receipts_lotExpiryDate.Text;
            input.AppendChild(doc.CreateElement("UseSingleTypeABCElements")).InnerText = tb_receipts_useSingleTypeAbcElements.Text;

                //Bins
                XmlNode bins = doc.CreateElement("Bins");
                bins.AppendChild(doc.CreateElement("BinLocation")).InnerText = tb_receipts_binLocation.Text;
                bins.AppendChild(doc.CreateElement("BinQuantity")).InnerText = tb_receipts_binQuantity.Text;
                bins.AppendChild(doc.CreateElement("BinUnits")).InnerText = tb_receipts_binUnits.Text;
                bins.AppendChild(doc.CreateElement("BinPieces")).InnerText = tb_receipts_binPieces.Text;
                input.AppendChild(bins);
                //Serials
                XmlNode serials = doc.CreateElement("Serials");
                serials.AppendChild(doc.CreateElement("SerialNumber")).InnerText = tb_receipts_serialNumber.Text;
                serials.AppendChild(doc.CreateElement("SerialQuantity")).InnerText = tb_receipts_serialQuantity.Text;
                serials.AppendChild(doc.CreateElement("SerialUnits")).InnerText = tb_receipts_serialUnits.Text;
                serials.AppendChild(doc.CreateElement("SerialPieces")).InnerText = tb_receipts_serialPieces.Text;
                serials.AppendChild(doc.CreateElement("SerialExpiryDate")).InnerText = tb_receipts_serialExpiryDate.Text;
                serials.AppendChild(doc.CreateElement("SerialLocation")).InnerText = tb_receipts_serialLocation.Text;
                input.AppendChild(serials);
                //SerialRange
                XmlNode serialRange = doc.CreateElement("SerialRange");
                serialRange.AppendChild(doc.CreateElement("SerialPrefix")).InnerText = tb_receipts_serialPrefix.Text;
                serialRange.AppendChild(doc.CreateElement("SerialSuffix")).InnerText = tb_receipts_serialSuffix.Text;
                serialRange.AppendChild(doc.CreateElement("SerialQuantity")).InnerText = tb_receipts_serialQuantity2.Text;
                serialRange.AppendChild(doc.CreateElement("SerialExpiryDate")).InnerText = tb_receipts_serialExpiryDate2.Text;
                serialRange.AppendChild(doc.CreateElement("SerialLocation")).InnerText = tb_receipts_serialLocation2.Text;
                input.AppendChild(serialRange);
                //SerialAllocation
                XmlNode serialAllocation = doc.CreateElement("SerialAllocation");
                serialAllocation.AppendChild(doc.CreateElement("FromSerialNumber")).InnerText = tb_receipts_fromSerialNumber.Text;
                serialAllocation.AppendChild(doc.CreateElement("ToSerialNumber")).InnerText = tb_receipts_toSerialNumber.Text;
                serialAllocation.AppendChild(doc.CreateElement("SerialQuantity")).InnerText = tb_receipts_serialQuantity3.Text;
                input.AppendChild(serialAllocation);

            input.AppendChild(doc.CreateElement("ApplyCostMultiplier")).InnerText = tb_receipts_applyCostMultiplier.Text;
            input.AppendChild(doc.CreateElement("CostMultiplier")).InnerText = tb_receipts_costMultiplier.Text;
            input.AppendChild(doc.CreateElement("NonMerchandiseCost")).InnerText = tb_receipts_nonMerchandiseCost.Text;

                //NonMerchandiseDistribution
                XmlNode nonMerchandiseDistribution = doc.CreateElement("NonMerchandiseDistribution");
                nonMerchandiseDistribution.AppendChild(doc.CreateElement("NmReference")).InnerText = tb_receipts_nmReference.Text;
                nonMerchandiseDistribution.AppendChild(doc.CreateElement("NmLedgerCode")).InnerText = tb_receipts_nmLedgerCode.Text;
                nonMerchandiseDistribution.AppendChild(doc.CreateElement("NmAmount")).InnerText = tb_receipts_nmAmount.Text;
                input.AppendChild(nonMerchandiseDistribution);

            input.AppendChild(doc.CreateElement("Reference")).InnerText = tb_receipts_Reference.Text;
            input.AppendChild(doc.CreateElement("Notation")).InnerText = tb_receipts_Notation.Text;
            input.AppendChild(doc.CreateElement("LedgerCode")).InnerText = tb_receipts_ledgerCode.Text;
            input.AppendChild(doc.CreateElement("PasswordForLedgerCode")).InnerText = tb_receipts_passwordForLedgerCode.Text;
            input.AppendChild(doc.CreateElement("eSignature")).InnerText = tb_receipts_eSignature.Text;
            input.AppendChild(doc.CreateElement("AnalysisEntry")).InnerText = tb_receipts_analysisEntry.Text;

                //AnalysisLineEntry
                XmlNode analysisLineEntry = doc.CreateElement("AnalysisLineEntry");
                analysisLineEntry.AppendChild(doc.CreateElement("AnalysisCode1")).InnerText = tb_receipts_analysisCode1.Text;
                analysisLineEntry.AppendChild(doc.CreateElement("AnalysisCode2")).InnerText = tb_receipts_analysisCode2.Text;
                analysisLineEntry.AppendChild(doc.CreateElement("AnalysisCode3")).InnerText = tb_receipts_analysisCode3.Text;
                analysisLineEntry.AppendChild(doc.CreateElement("AnalysisCode4")).InnerText = tb_receipts_analysisCode4.Text;
                analysisLineEntry.AppendChild(doc.CreateElement("AnalysisCode5")).InnerText = tb_receipts_analysisCode5.Text;
                analysisLineEntry.AppendChild(doc.CreateElement("StartDate")).InnerText = tb_receipts_startDate.Text;
                analysisLineEntry.AppendChild(doc.CreateElement("EndDate")).InnerText = tb_receipts_endDate.Text;
                analysisLineEntry.AppendChild(doc.CreateElement("EntryAmount")).InnerText = tb_receipts_entryAmount.Text;
                analysisLineEntry.AppendChild(doc.CreateElement("Comment")).InnerText = tb_receipts_comment.Text;
                input.AppendChild(analysisLineEntry);

            root.AppendChild(input);
            doc.AppendChild(root);

            saveFileDialog.FileName = "INVTMR_" + getCurrentTimestamp();
            if (DialogResult.OK == saveFileDialog.ShowDialog())
            {
                doc.Save(saveFileDialog.FileName);
                MessageBox.Show("Transaction saved as " + saveFileDialog.FileName, "Transaction Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void post_costChanges_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            XmlNode root = doc.CreateElement("PostInvCostChange");
            
            //XML Input
            XmlNode input = doc.CreateElement("Item");
            input.AppendChild(doc.CreateElement("Journal")).InnerText = tb_costChanges_journal.Text;
            input.AppendChild(doc.CreateElement("Warehouse")).InnerText = tb_costChanges_warehouse.Text;
            input.AppendChild(doc.CreateElement("StockCode")).InnerText = tb_costChanges_stockCode.Text;
            input.AppendChild(doc.CreateElement("NewUnitCost")).InnerText = tb_costChanges_newUnitCost.Text;
            input.AppendChild(doc.CreateElement("NewTotalCost")).InnerText = tb_costChanges_newTotalCost.Text;
            input.AppendChild(doc.CreateElement("UpdateLastCost")).InnerText = tb_costChanges_updateLastCost.Text;
            input.AppendChild(doc.CreateElement("FifoBucket")).InnerText = tb_costChanges_fifoBucket.Text;
            input.AppendChild(doc.CreateElement("Reference")).InnerText = tb_costChanges_reference.Text;
            input.AppendChild(doc.CreateElement("Notation")).InnerText = tb_costChanges_notation.Text;
            input.AppendChild(doc.CreateElement("LedgerCode")).InnerText = tb_costChanges_ledgerCode.Text;
            input.AppendChild(doc.CreateElement("PasswordForLedgerCode")).InnerText = tb_costChanges_passwordForLedgerCode.Text;
            input.AppendChild(doc.CreateElement("eSignature")).InnerText = tb_costChanges_eSignature.Text;
            input.AppendChild(doc.CreateElement("AnalysisEntry")).InnerText = tb_costChanges_analysisEntry.Text;

                //AnalysisLineEntry
                XmlNode analysisLineEntry = doc.CreateElement("AnalysisLineEntry");
                analysisLineEntry.AppendChild(doc.CreateElement("AnalysisCode1")).InnerText = tb_receipts_analysisCode1.Text;
                analysisLineEntry.AppendChild(doc.CreateElement("AnalysisCode2")).InnerText = tb_receipts_analysisCode2.Text;
                analysisLineEntry.AppendChild(doc.CreateElement("AnalysisCode3")).InnerText = tb_receipts_analysisCode3.Text;
                analysisLineEntry.AppendChild(doc.CreateElement("AnalysisCode4")).InnerText = tb_receipts_analysisCode4.Text;
                analysisLineEntry.AppendChild(doc.CreateElement("AnalysisCode5")).InnerText = tb_receipts_analysisCode5.Text;
                analysisLineEntry.AppendChild(doc.CreateElement("StartDate")).InnerText = tb_receipts_startDate.Text;
                analysisLineEntry.AppendChild(doc.CreateElement("EndDate")).InnerText = tb_receipts_endDate.Text;
                analysisLineEntry.AppendChild(doc.CreateElement("EntryAmount")).InnerText = tb_receipts_entryAmount.Text;
                analysisLineEntry.AppendChild(doc.CreateElement("Comment")).InnerText = tb_receipts_comment.Text;
                input.AppendChild(analysisLineEntry);

            root.AppendChild(input);
            doc.AppendChild(root);

            saveFileDialog.FileName = "INVTMC_" + getCurrentTimestamp();
            if (DialogResult.OK == saveFileDialog.ShowDialog())
            {
                doc.Save(saveFileDialog.FileName);
                MessageBox.Show("Transaction saved as " + saveFileDialog.FileName, "Transaction Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void post_transfersOut_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            XmlNode root = doc.CreateElement("PostInvWhTransferOut");

            //XML Input
            XmlNode input = doc.CreateElement("Item");
            input.AppendChild(doc.CreateElement("Journal")).InnerText = tb_transfersOut_journal.Text;
            input.AppendChild(doc.CreateElement("Immediate")).InnerText = tb_transfersOut_immediate.Text;
            input.AppendChild(doc.CreateElement("NoDestination")).InnerText = tb_transfersOut_noDestination.Text;
            input.AppendChild(doc.CreateElement("FromWarehouse")).InnerText = tb_transfersOut_fromWarehouse.Text;
            input.AppendChild(doc.CreateElement("FromBin")).InnerText = tb_transfersOut_fromBin.Text;
            input.AppendChild(doc.CreateElement("StockCode")).InnerText = tb_transfersOut_stockCode.Text;
            input.AppendChild(doc.CreateElement("Version")).InnerText = tb_transfersOut_version.Text;
            input.AppendChild(doc.CreateElement("Release")).InnerText = tb_transfersOut_release.Text;
            input.AppendChild(doc.CreateElement("Quantity")).InnerText = tb_transfersOut_quantity.Text;
            input.AppendChild(doc.CreateElement("UnitOfMeasure")).InnerText = tb_transfersOut_unitOfMeasure.Text;
            input.AppendChild(doc.CreateElement("Units")).InnerText = tb_transfersOut_units.Text;
            input.AppendChild(doc.CreateElement("Pieces")).InnerText = tb_transfersOut_pieces.Text;
            input.AppendChild(doc.CreateElement("ToWarehouse")).InnerText = tb_transfersOut_toWarehouse.Text;
            input.AppendChild(doc.CreateElement("ToBin")).InnerText = tb_transfersOut_toBin.Text;
            input.AppendChild(doc.CreateElement("ToWhJournal")).InnerText = tb_transfersOut_toWhJournal.Text;
            input.AppendChild(doc.CreateElement("Lot")).InnerText = tb_transfersOut_lot.Text;
            input.AppendChild(doc.CreateElement("Reference")).InnerText = tb_transfersOut_reference.Text;
            input.AppendChild(doc.CreateElement("Notation")).InnerText = tb_transfersOut_notation.Text;
            input.AppendChild(doc.CreateElement("LedgerCode")).InnerText = tb_transfersOut_ledgerCode.Text;
            input.AppendChild(doc.CreateElement("PasswordForLedgerCode")).InnerText = tb_transfersOut_passwordForLedgerCode.Text;

                //Serials
                XmlNode serials = doc.CreateElement("Serials");
                serials.AppendChild(doc.CreateElement("SerialNumber")).InnerText = tb_transfersOut_serialNumber.Text;
                serials.AppendChild(doc.CreateElement("SerialQuantity")).InnerText = tb_transfersOut_serialQuantity.Text;
                serials.AppendChild(doc.CreateElement("SerialUnits")).InnerText = tb_transfersOut_serialUnits.Text;
                serials.AppendChild(doc.CreateElement("SerialPieces")).InnerText = tb_transfersOut_serialPieces.Text;
                serials.AppendChild(doc.CreateElement("SerialLocation")).InnerText = tb_transfersOut_serialLocation.Text;
                input.AppendChild(serials);
                //SerialAllocation
                XmlNode serialAllocation = doc.CreateElement("SerialAllocation");
                serialAllocation.AppendChild(doc.CreateElement("FromSerialNumber")).InnerText = tb_transfersOut_fromSerialNumber.Text;
                serialAllocation.AppendChild(doc.CreateElement("ToSerialNumber")).InnerText = tb_transfersOut_toSerialNumber.Text;
                serialAllocation.AppendChild(doc.CreateElement("SerialQuantity")).InnerText = tb_transfersOut_serialQuantity2.Text;
                input.AppendChild(serialAllocation);

                input.AppendChild(doc.CreateElement("eSignature")).InnerText = tb_transfersOut_eSignature.Text;

            root.AppendChild(input);
            doc.AppendChild(root);

            saveFileDialog.FileName = "INVTMO_" + getCurrentTimestamp();
            if (DialogResult.OK == saveFileDialog.ShowDialog())
            {
                doc.Save(saveFileDialog.FileName);
                MessageBox.Show("Transaction saved as " + saveFileDialog.FileName, "Transaction Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void post_transfersIn_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            XmlNode root = doc.CreateElement("PostInvWhTransferIn");

            //XML Input
            XmlNode input = doc.CreateElement("Item");
            input.AppendChild(doc.CreateElement("Journal")).InnerText = tb_transfersIn_journal.Text;
            input.AppendChild(doc.CreateElement("StockCode")).InnerText = tb_transfersIn_stockCode.Text;
            input.AppendChild(doc.CreateElement("Version")).InnerText = tb_transfersIn_version.Text;
            input.AppendChild(doc.CreateElement("Release")).InnerText = tb_transfersIn_release.Text;
            input.AppendChild(doc.CreateElement("Quantity")).InnerText = tb_transfersIn_quantity.Text;
            input.AppendChild(doc.CreateElement("UnitOfMeasure")).InnerText = tb_transfersIn_unitOfMeasure.Text;
            input.AppendChild(doc.CreateElement("Units")).InnerText = tb_transfersIn_units.Text;
            input.AppendChild(doc.CreateElement("Pieces")).InnerText = tb_transfersIn_pieces.Text;
            input.AppendChild(doc.CreateElement("Warehouse")).InnerText = tb_transfersIn_warehouse.Text;
            input.AppendChild(doc.CreateElement("Bin")).InnerText = tb_transfersIn_bin.Text;
            input.AppendChild(doc.CreateElement("Lot")).InnerText = tb_transfersIn_lot.Text;
            input.AppendChild(doc.CreateElement("Reference")).InnerText = tb_transfersIn_reference.Text;
            input.AppendChild(doc.CreateElement("Notation")).InnerText = tb_transfersIn_notation.Text;
            input.AppendChild(doc.CreateElement("LedgerCode")).InnerText = tb_transfersIn_ledgerCode.Text;
            input.AppendChild(doc.CreateElement("PasswordForLedgerCode")).InnerText = tb_transfersIn_passwordForLedgerCode.Text;

                //Serials
                XmlNode serials = doc.CreateElement("Serials");
                serials.AppendChild(doc.CreateElement("SerialNumber")).InnerText = tb_transfersIn_serialNumber.Text;
                serials.AppendChild(doc.CreateElement("SerialQuantity")).InnerText = tb_transfersIn_serialQuantity.Text;
                serials.AppendChild(doc.CreateElement("SerialUnits")).InnerText = tb_transfersIn_serialUnits.Text;
                serials.AppendChild(doc.CreateElement("SerialPieces")).InnerText = tb_transfersIn_serialPieces.Text;
                input.AppendChild(serials);
                //SerialAllocation
                XmlNode serialAllocation = doc.CreateElement("SerialAllocation");
                serialAllocation.AppendChild(doc.CreateElement("FromSerialNumber")).InnerText = tb_transfersIn_fromSerialNumber.Text;
                serialAllocation.AppendChild(doc.CreateElement("ToSerialNumber")).InnerText = tb_transfersIn_toSerialNumber.Text;
                serialAllocation.AppendChild(doc.CreateElement("SerialQuantity")).InnerText = tb_transfersIn_serialQuantity2.Text;
                input.AppendChild(serialAllocation);

            input.AppendChild(doc.CreateElement("eSignature")).InnerText = tb_transfersIn_eSignature.Text;

            root.AppendChild(input);
            doc.AppendChild(root);
            
            saveFileDialog.FileName = "INVTMI_" + getCurrentTimestamp();
            if (DialogResult.OK == saveFileDialog.ShowDialog())
            {
                doc.Save(saveFileDialog.FileName);
                MessageBox.Show("Transaction saved as " + saveFileDialog.FileName, "Transaction Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void post_costModifications_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            XmlNode root = doc.CreateElement("PostInvCostModification");
            
            //XML Input
            XmlNode input = doc.CreateElement("Item");
            input.AppendChild(doc.CreateElement("Journal")).InnerText = tb_costModifications_journal.Text;
            input.AppendChild(doc.CreateElement("Warehouse")).InnerText = tb_costModifications_warehouse.Text;
            input.AppendChild(doc.CreateElement("StockCode")).InnerText = tb_costModifications_stockCode.Text;
            input.AppendChild(doc.CreateElement("Quantity")).InnerText = tb_costModifications_quantity.Text;
            input.AppendChild(doc.CreateElement("UnitOfMeasure")).InnerText = tb_costModifications_unitOfMeasure.Text;
            input.AppendChild(doc.CreateElement("Units")).InnerText = tb_costModifications_units.Text;
            input.AppendChild(doc.CreateElement("Pieces")).InnerText = tb_costModifications_pieces.Text;
            input.AppendChild(doc.CreateElement("PreviousCost")).InnerText = tb_costModifications_previousCost.Text;
            input.AppendChild(doc.CreateElement("NewUnitCost")).InnerText = tb_costModifications_newUnitCost.Text;
            input.AppendChild(doc.CreateElement("NewTotalCost")).InnerText = tb_costModifications_newTotalCost.Text;
            input.AppendChild(doc.CreateElement("Reference")).InnerText = tb_costModifications_reference.Text;
            input.AppendChild(doc.CreateElement("Notation")).InnerText = tb_costModifications_notation.Text;
            input.AppendChild(doc.CreateElement("LedgerCode")).InnerText = tb_costModifications_ledgerCode.Text;
            input.AppendChild(doc.CreateElement("PasswordForLedgerCode")).InnerText = tb_costModifications_passwordForLedgerCode.Text;
            input.AppendChild(doc.CreateElement("eSignature")).InnerText = tb_costModifications_eSignature.Text;
            input.AppendChild(doc.CreateElement("AnalysisEntry")).InnerText = tb_costModifications_analysisEntry.Text;

                //AnalysisLineEntry
                XmlNode analysisLineEntry = doc.CreateElement("AnalysisLineEntry");
                analysisLineEntry.AppendChild(doc.CreateElement("AnalysisCode1")).InnerText = tb_costModifications_analysisCode1.Text;
                analysisLineEntry.AppendChild(doc.CreateElement("AnalysisCode2")).InnerText = tb_costModifications_analysisCode2.Text;
                analysisLineEntry.AppendChild(doc.CreateElement("AnalysisCode3")).InnerText = tb_costModifications_analysisCode3.Text;
                analysisLineEntry.AppendChild(doc.CreateElement("AnalysisCode4")).InnerText = tb_costModifications_analysisCode4.Text;
                analysisLineEntry.AppendChild(doc.CreateElement("AnalysisCode5")).InnerText = tb_costModifications_analysisCode5.Text;
                analysisLineEntry.AppendChild(doc.CreateElement("StartDate")).InnerText = tb_costModifications_startDate.Text;
                analysisLineEntry.AppendChild(doc.CreateElement("EndDate")).InnerText = tb_costModifications_endDate.Text;
                analysisLineEntry.AppendChild(doc.CreateElement("EntryAmount")).InnerText = tb_costModifications_entryAmount.Text;
                analysisLineEntry.AppendChild(doc.CreateElement("Comment")).InnerText = tb_costModifications_comment.Text;
                input.AppendChild(analysisLineEntry);

            root.AppendChild(input);
            doc.AppendChild(root);
            
            saveFileDialog.FileName = "INVTMM_" + getCurrentTimestamp();
            if (DialogResult.OK == saveFileDialog.ShowDialog())
            {
                doc.Save(saveFileDialog.FileName);
                MessageBox.Show("Transaction saved as " + saveFileDialog.FileName, "Transaction Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void post_adjustments_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            XmlNode root = doc.CreateElement("PostInvCostModification");
            
            //XML Input
            XmlNode input = doc.CreateElement("Item");
            input.AppendChild(doc.CreateElement("Journal")).InnerText = tb_adjustments_journal.Text;
            input.AppendChild(doc.CreateElement("Warehouse")).InnerText = tb_adjustments_warehouse.Text;
            input.AppendChild(doc.CreateElement("StockCode")).InnerText = tb_adjustments_stockCode.Text;
            input.AppendChild(doc.CreateElement("Version")).InnerText = tb_adjustments_version.Text;
            input.AppendChild(doc.CreateElement("Release")).InnerText = tb_adjustments_release.Text;
            input.AppendChild(doc.CreateElement("Quantity")).InnerText = tb_adjustments_quantity.Text;
            input.AppendChild(doc.CreateElement("UnitOfMeasure")).InnerText = tb_adjustments_unitOfMeasure.Text;
            input.AppendChild(doc.CreateElement("Units")).InnerText = tb_adjustments_units.Text;
            input.AppendChild(doc.CreateElement("Pieces")).InnerText = tb_adjustments_pieces.Text;
            input.AppendChild(doc.CreateElement("BinLocation")).InnerText = tb_adjustments_binLocation.Text;
            input.AppendChild(doc.CreateElement("FifoBucket")).InnerText = tb_adjustments_fifoBucket.Text;
            input.AppendChild(doc.CreateElement("Lot")).InnerText = tb_adjustments_lot.Text;
            input.AppendChild(doc.CreateElement("Reference")).InnerText = tb_adjustments_reference.Text;
            input.AppendChild(doc.CreateElement("Notation")).InnerText = tb_adjustments_notation.Text;
            input.AppendChild(doc.CreateElement("LedgerCode")).InnerText = tb_adjustments_ledgerCode.Text;
            input.AppendChild(doc.CreateElement("PasswordForLedgerCode")).InnerText = tb_adjustments_passwordForLedgerCode.Text;
            
                //Serials
                XmlNode serials = doc.CreateElement("Serials");
                serials.AppendChild(doc.CreateElement("SerialNumber")).InnerText = tb_adjustments_serialNumber.Text;
                serials.AppendChild(doc.CreateElement("SerialQuantity")).InnerText = tb_adjustments_serialQuantity.Text;
                serials.AppendChild(doc.CreateElement("SerialUnits")).InnerText = tb_adjustments_serialUnits.Text;
                serials.AppendChild(doc.CreateElement("SerialPieces")).InnerText = tb_adjustments_serialPieces.Text;
                serials.AppendChild(doc.CreateElement("SerialFifoBucket")).InnerText = tb_adjustments_serialFifoBucket.Text;
                input.AppendChild(serials);
                //SerialAllocation
                XmlNode serialAllocation = doc.CreateElement("SerialAllocation");
                serialAllocation.AppendChild(doc.CreateElement("FromSerialNumber")).InnerText = tb_adjustments_fromSerialNumber.Text;
                serialAllocation.AppendChild(doc.CreateElement("ToSerialNumber")).InnerText = tb_adjustments_toSerialNumber.Text;
                serialAllocation.AppendChild(doc.CreateElement("SerialQuantity")).InnerText = tb_adjustments_serialQuantity2.Text;
                input.AppendChild(serialAllocation);

            input.AppendChild(doc.CreateElement("eSignature")).InnerText = tb_adjustments_eSignature.Text;
            input.AppendChild(doc.CreateElement("AnalysisEntry")).InnerText = tb_adjustments_analysisEntry.Text;
            
                //AnalysisLineEntry
                XmlNode analysisLineEntry = doc.CreateElement("AnalysisLineEntry");
                analysisLineEntry.AppendChild(doc.CreateElement("AnalysisCode1")).InnerText = tb_adjustments_analysisCode1.Text;
                analysisLineEntry.AppendChild(doc.CreateElement("AnalysisCode2")).InnerText = tb_adjustments_analysisCode2.Text;
                analysisLineEntry.AppendChild(doc.CreateElement("AnalysisCode3")).InnerText = tb_adjustments_analysisCode3.Text;
                analysisLineEntry.AppendChild(doc.CreateElement("AnalysisCode4")).InnerText = tb_adjustments_analysisCode4.Text;
                analysisLineEntry.AppendChild(doc.CreateElement("AnalysisCode5")).InnerText = tb_adjustments_analysisCode5.Text;
                analysisLineEntry.AppendChild(doc.CreateElement("StartDate")).InnerText = tb_adjustments_startDate.Text;
                analysisLineEntry.AppendChild(doc.CreateElement("EndDate")).InnerText = tb_adjustments_endDate.Text;
                analysisLineEntry.AppendChild(doc.CreateElement("EntryAmount")).InnerText = tb_adjustments_entryAmount.Text;
                analysisLineEntry.AppendChild(doc.CreateElement("Comment")).InnerText = tb_adjustments_comment.Text;
                input.AppendChild(analysisLineEntry);

            root.AppendChild(input);
            doc.AppendChild(root);

            saveFileDialog.FileName = "INVTMA_" + getCurrentTimestamp();
            if (DialogResult.OK == saveFileDialog.ShowDialog())
            {
                doc.Save(saveFileDialog.FileName);
                MessageBox.Show("Transaction saved as " + saveFileDialog.FileName, "Transaction Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void postToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == openFileDialog.ShowDialog())
            {
                List<XmlDocument> openDocuments = new List<XmlDocument>();

                foreach (string fileName in openFileDialog.FileNames)
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load(fileName);

                    documents.Add(doc);
                    fileNames.Add(fileName);
                    openDocuments.Add(doc);
                }

                postTransactions(openDocuments);
            }
        }

        private void queryInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Invqry invqry = new Invqry();
            invqry.ShowDialog();
        }

        private void generateDailyReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rCount = 0, aCount = 0, cCount = 0, mCount = 0, oCount = 0, iCount = 0;
            string output = "Transaction Report - " + DateTime.Now.ToShortDateString();
            output += "\r\n\r\nTransactions processed";

            foreach (XmlDocument doc in documents)
            {
                switch (doc.FirstChild.Name)
                {
                    case "PostInvReceipts":
                        rCount++;
                        break;

                    case "PostInvAdjustments":
                        aCount++;
                        break;

                    case "PostInvCostChange":
                        cCount++;
                        break;

                    case "PostInvCostModification":
                        mCount++;
                        break;

                    case "PostInvWhTransferOut":
                        oCount++;
                        break;

                    case "PostInvWhTransferIn":
                        iCount++;
                        break;

                    default:
                        break;
                }
            }

            output += "\r\nReceipts: " + rCount;
            output += "\r\nAdjustments: " + aCount;
            output += "\r\nCost Change: " + cCount;
            output += "\r\nCost Modification: " + mCount;
            output += "\r\nTransfer OUT: " + oCount;
            output += "\r\nTransfer IN: " + iCount;

            output += "\r\n\r\nFiles:";

            foreach (string fileName in fileNames)
            {
                output += "\r\n" + fileName;
            }

            Output outputForm = new Output();
            outputForm.OutputString = output;
            outputForm.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void postTransactions(List<XmlDocument> docs)
        {
            foreach (XmlDocument doc in docs)
            {
                try
                {
                    SYSPROWCFServicesPrimitiveClient sc = new SYSPROWCFServicesPrimitiveClient("net.tcp://10.2.3.10:500/SYSPROWCFService/Soap", SYSPROWCFBinding.NetTcp);
                    string guid = sc.Logon("ENET5", "", "0", "");
                    XmlDocument paramsDoc = new XmlDocument();
                    XmlNode root;
                    XmlNode parameters = doc.CreateElement("Parameters");
                    
                    switch (doc.FirstChild.Name)
                    {
                        case "PostInvReceipts":
                            root = doc.CreateElement("PostInvReceipts");
                            
                            parameters.AppendChild(doc.CreateElement("TransactionDate")).InnerText = getCurrentDate();
                            parameters.AppendChild(doc.CreateElement("IgnoreWarnings")).InnerText = "N";
                            parameters.AppendChild(doc.CreateElement("ApplyIfEntireDocumentValid")).InnerText = "Y";
                            parameters.AppendChild(doc.CreateElement("ValidateOnly")).InnerText = "N";
                            parameters.AppendChild(doc.CreateElement("ManualSerialTransfersAllowed")).InnerText = "N";
                            parameters.AppendChild(doc.CreateElement("ReturnDetailedReceipt")).InnerText = "N";
                            parameters.AppendChild(doc.CreateElement("IgnoreAnalysis")).InnerText = "Y";
                            
                            root.AppendChild(parameters);
                            doc.AppendChild(root);

                            sc.TransactionPost(guid, "INVTMR", paramsDoc.OuterXml, doc.OuterXml);
                            break;

                        case "PostInvAdjustments":
                            root = doc.CreateElement("PostInvAdjustments");

                            parameters.AppendChild(doc.CreateElement("TransactionDate")).InnerText = getCurrentDate();
                            parameters.AppendChild(doc.CreateElement("PhysicalCount")).InnerText = "N";
                            parameters.AppendChild(doc.CreateElement("PostingPeriod")).InnerText = "C";
                            parameters.AppendChild(doc.CreateElement("IgnoreWarnings")).InnerText = "N";
                            parameters.AppendChild(doc.CreateElement("ApplyIfEntireDocumentValid")).InnerText = "Y";
                            parameters.AppendChild(doc.CreateElement("ValidateOnly")).InnerText = "N";
                            parameters.AppendChild(doc.CreateElement("IgnoreAnalysis")).InnerText = "Y";

                            root.AppendChild(parameters);
                            doc.AppendChild(root);

                            sc.TransactionPost(guid, "INVTMA", paramsDoc.OuterXml, doc.OuterXml);
                            break;

                        case "PostInvCostChange":
                            root = doc.CreateElement("PostInvCostChange");

                            parameters.AppendChild(doc.CreateElement("TransactionDate")).InnerText = getCurrentDate();
                            parameters.AppendChild(doc.CreateElement("IgnoreWarnings")).InnerText = "N";
                            parameters.AppendChild(doc.CreateElement("ApplyIfEntireDocumentValid")).InnerText = "Y";
                            parameters.AppendChild(doc.CreateElement("ValidateOnly")).InnerText = "N";
                            parameters.AppendChild(doc.CreateElement("IgnoreAnalysis")).InnerText = "Y";

                            root.AppendChild(parameters);
                            doc.AppendChild(root);

                            sc.TransactionPost(guid, "INVTMC", paramsDoc.OuterXml, doc.OuterXml);
                            break;

                        case "PostInvCostModification":
                            root = doc.CreateElement("PostInvCostModification");

                            parameters.AppendChild(doc.CreateElement("TransactionDate")).InnerText = getCurrentDate();
                            parameters.AppendChild(doc.CreateElement("IgnoreWarnings")).InnerText = "N";
                            parameters.AppendChild(doc.CreateElement("ApplyIfEntireDocumentValid")).InnerText = "Y";
                            parameters.AppendChild(doc.CreateElement("ValidateOnly")).InnerText = "N";
                            parameters.AppendChild(doc.CreateElement("IgnoreAnalysis")).InnerText = "Y";

                            root.AppendChild(parameters);
                            doc.AppendChild(root);

                            sc.TransactionPost(guid, "INVTMM", paramsDoc.OuterXml, doc.OuterXml);
                            break;

                        case "PostInvWhTransferOut":
                            root = doc.CreateElement("PostInvWhTransferOut");

                            parameters.AppendChild(doc.CreateElement("TransactionDate")).InnerText = getCurrentDate();
                            parameters.AppendChild(doc.CreateElement("IgnoreWarnings")).InnerText = "N";
                            parameters.AppendChild(doc.CreateElement("CreateDestinationWarehouse")).InnerText = "N";
                            parameters.AppendChild(doc.CreateElement("ApplyIfEntireDocumentValid")).InnerText = "Y";
                            parameters.AppendChild(doc.CreateElement("ValidateOnly")).InnerText = "N";

                            root.AppendChild(parameters);
                            doc.AppendChild(root);

                            sc.TransactionPost(guid, "INVTMO", paramsDoc.OuterXml, doc.OuterXml);
                            break;

                        case "PostInvWhTransferIn":
                            root = doc.CreateElement("PostInvWhTransferIn");

                            parameters.AppendChild(doc.CreateElement("TransactionDate")).InnerText = getCurrentDate();
                            parameters.AppendChild(doc.CreateElement("IgnoreWarnings")).InnerText = "N";
                            parameters.AppendChild(doc.CreateElement("ApplyIfEntireDocumentValid")).InnerText = "Y";
                            parameters.AppendChild(doc.CreateElement("ValidateOnly")).InnerText = "N";

                            root.AppendChild(parameters);
                            doc.AppendChild(root);

                            sc.TransactionPost(guid, "INVTMI", paramsDoc.OuterXml, doc.OuterXml);
                            break;

                        default:
                            break;
                    }

                    sc.Logoff(guid);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }
        
        private String getCurrentDate()
        {
            return DateTime.Now.ToString("yyyy-MM-dd"); ;
        }

        private String getCurrentTimestamp()
        {
            return DateTime.Now.ToString("ddMMyy_HHmm");
        }

    }
}
