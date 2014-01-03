namespace OUTDOORS
{
    partial class Invqry
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_invqry_stockCode = new System.Windows.Forms.TextBox();
            this.button_invqry = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stock Code:";
            // 
            // tb_invqry_stockCode
            // 
            this.tb_invqry_stockCode.Location = new System.Drawing.Point(84, 12);
            this.tb_invqry_stockCode.Name = "tb_invqry_stockCode";
            this.tb_invqry_stockCode.Size = new System.Drawing.Size(188, 20);
            this.tb_invqry_stockCode.TabIndex = 1;
            // 
            // button_invqry
            // 
            this.button_invqry.Location = new System.Drawing.Point(197, 38);
            this.button_invqry.Name = "button_invqry";
            this.button_invqry.Size = new System.Drawing.Size(75, 23);
            this.button_invqry.TabIndex = 2;
            this.button_invqry.Text = "OK";
            this.button_invqry.UseVisualStyleBackColor = true;
            this.button_invqry.Click += new System.EventHandler(this.button_invqry_Click);
            // 
            // Invqry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 73);
            this.Controls.Add(this.button_invqry);
            this.Controls.Add(this.tb_invqry_stockCode);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Invqry";
            this.Text = "Inventory Query";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_invqry_stockCode;
        private System.Windows.Forms.Button button_invqry;
    }
}