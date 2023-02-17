
namespace Boletos
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.CalcBtn = new System.Windows.Forms.Button();
            this.LeaveBtn = new System.Windows.Forms.Button();
            this.EraseBtn = new System.Windows.Forms.Button();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.ValueBox = new System.Windows.Forms.TextBox();
            this.EndLabel = new System.Windows.Forms.Label();
            this.PayLabel = new System.Windows.Forms.Label();
            this.TicketBox = new System.Windows.Forms.TextBox();
            this.TicketLabel = new System.Windows.Forms.Label();
            this.FeesBox = new System.Windows.Forms.TextBox();
            this.FeeLabel = new System.Windows.Forms.Label();
            this.DiscountBox = new System.Windows.Forms.TextBox();
            this.DescountLabel = new System.Windows.Forms.Label();
            this.TotalBox = new System.Windows.Forms.TextBox();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.AddBox = new System.Windows.Forms.TextBox();
            this.AddLabel = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.FeesValueLabel = new System.Windows.Forms.Label();
            this.DiscountValueBox = new System.Windows.Forms.TextBox();
            this.DiscountValueLabel = new System.Windows.Forms.Label();
            this.TicketValueBox = new System.Windows.Forms.TextBox();
            this.TicketValueLabel = new System.Windows.Forms.Label();
            this.DelayBox = new System.Windows.Forms.TextBox();
            this.DealyLabel = new System.Windows.Forms.Label();
            this.EndDate = new System.Windows.Forms.MaskedTextBox();
            this.PayDate = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // CalcBtn
            // 
            this.CalcBtn.Location = new System.Drawing.Point(215, 64);
            this.CalcBtn.Name = "CalcBtn";
            this.CalcBtn.Size = new System.Drawing.Size(75, 23);
            this.CalcBtn.TabIndex = 0;
            this.CalcBtn.Text = "Calcular";
            this.CalcBtn.UseVisualStyleBackColor = true;
            this.CalcBtn.Click += new System.EventHandler(this.CalcBtn_Click);
            // 
            // LeaveBtn
            // 
            this.LeaveBtn.Location = new System.Drawing.Point(215, 164);
            this.LeaveBtn.Name = "LeaveBtn";
            this.LeaveBtn.Size = new System.Drawing.Size(75, 23);
            this.LeaveBtn.TabIndex = 1;
            this.LeaveBtn.Text = "Sair";
            this.LeaveBtn.UseVisualStyleBackColor = true;
            // 
            // EraseBtn
            // 
            this.EraseBtn.Location = new System.Drawing.Point(215, 115);
            this.EraseBtn.Name = "EraseBtn";
            this.EraseBtn.Size = new System.Drawing.Size(75, 23);
            this.EraseBtn.TabIndex = 2;
            this.EraseBtn.Text = "Apagar";
            this.EraseBtn.UseVisualStyleBackColor = true;
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Location = new System.Drawing.Point(12, 48);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(34, 13);
            this.ValueLabel.TabIndex = 3;
            this.ValueLabel.Text = "Valor:";
            // 
            // ValueBox
            // 
            this.ValueBox.Location = new System.Drawing.Point(13, 64);
            this.ValueBox.Name = "ValueBox";
            this.ValueBox.Size = new System.Drawing.Size(100, 20);
            this.ValueBox.TabIndex = 4;
            // 
            // EndLabel
            // 
            this.EndLabel.AutoSize = true;
            this.EndLabel.Location = new System.Drawing.Point(12, 99);
            this.EndLabel.Name = "EndLabel";
            this.EndLabel.Size = new System.Drawing.Size(66, 13);
            this.EndLabel.TabIndex = 5;
            this.EndLabel.Text = "Vencimento:";
            // 
            // PayLabel
            // 
            this.PayLabel.AutoSize = true;
            this.PayLabel.Location = new System.Drawing.Point(11, 149);
            this.PayLabel.Name = "PayLabel";
            this.PayLabel.Size = new System.Drawing.Size(64, 13);
            this.PayLabel.TabIndex = 7;
            this.PayLabel.Text = "Pagamento:";
            // 
            // TicketBox
            // 
            this.TicketBox.Location = new System.Drawing.Point(12, 217);
            this.TicketBox.Name = "TicketBox";
            this.TicketBox.Size = new System.Drawing.Size(100, 20);
            this.TicketBox.TabIndex = 10;
            // 
            // TicketLabel
            // 
            this.TicketLabel.AutoSize = true;
            this.TicketLabel.Location = new System.Drawing.Point(11, 201);
            this.TicketLabel.Name = "TicketLabel";
            this.TicketLabel.Size = new System.Drawing.Size(36, 13);
            this.TicketLabel.TabIndex = 9;
            this.TicketLabel.Text = "Multa:";
            // 
            // FeesBox
            // 
            this.FeesBox.Location = new System.Drawing.Point(13, 271);
            this.FeesBox.Name = "FeesBox";
            this.FeesBox.Size = new System.Drawing.Size(100, 20);
            this.FeesBox.TabIndex = 12;
            // 
            // FeeLabel
            // 
            this.FeeLabel.AutoSize = true;
            this.FeeLabel.Location = new System.Drawing.Point(12, 255);
            this.FeeLabel.Name = "FeeLabel";
            this.FeeLabel.Size = new System.Drawing.Size(35, 13);
            this.FeeLabel.TabIndex = 11;
            this.FeeLabel.Text = "Juros:";
            // 
            // DiscountBox
            // 
            this.DiscountBox.Location = new System.Drawing.Point(13, 328);
            this.DiscountBox.Name = "DiscountBox";
            this.DiscountBox.Size = new System.Drawing.Size(100, 20);
            this.DiscountBox.TabIndex = 14;
            // 
            // DescountLabel
            // 
            this.DescountLabel.AutoSize = true;
            this.DescountLabel.Location = new System.Drawing.Point(12, 312);
            this.DescountLabel.Name = "DescountLabel";
            this.DescountLabel.Size = new System.Drawing.Size(56, 13);
            this.DescountLabel.TabIndex = 13;
            this.DescountLabel.Text = "Desconto:";
            // 
            // TotalBox
            // 
            this.TotalBox.Enabled = false;
            this.TotalBox.Location = new System.Drawing.Point(390, 328);
            this.TotalBox.Name = "TotalBox";
            this.TotalBox.Size = new System.Drawing.Size(100, 20);
            this.TotalBox.TabIndex = 26;
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Enabled = false;
            this.TotalLabel.Location = new System.Drawing.Point(389, 312);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(34, 13);
            this.TotalLabel.TabIndex = 25;
            this.TotalLabel.Text = "Total:";
            // 
            // AddBox
            // 
            this.AddBox.Enabled = false;
            this.AddBox.Location = new System.Drawing.Point(390, 271);
            this.AddBox.Name = "AddBox";
            this.AddBox.Size = new System.Drawing.Size(100, 20);
            this.AddBox.TabIndex = 24;
            // 
            // AddLabel
            // 
            this.AddLabel.AutoSize = true;
            this.AddLabel.Enabled = false;
            this.AddLabel.Location = new System.Drawing.Point(389, 255);
            this.AddLabel.Name = "AddLabel";
            this.AddLabel.Size = new System.Drawing.Size(64, 13);
            this.AddLabel.TabIndex = 23;
            this.AddLabel.Text = "Acrescimos:";
            // 
            // textBox9
            // 
            this.textBox9.Enabled = false;
            this.textBox9.Location = new System.Drawing.Point(391, 164);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 22;
            // 
            // FeesValueLabel
            // 
            this.FeesValueLabel.AutoSize = true;
            this.FeesValueLabel.Enabled = false;
            this.FeesValueLabel.Location = new System.Drawing.Point(390, 148);
            this.FeesValueLabel.Name = "FeesValueLabel";
            this.FeesValueLabel.Size = new System.Drawing.Size(35, 13);
            this.FeesValueLabel.TabIndex = 21;
            this.FeesValueLabel.Text = "Juros:";
            // 
            // DiscountValueBox
            // 
            this.DiscountValueBox.Enabled = false;
            this.DiscountValueBox.Location = new System.Drawing.Point(390, 217);
            this.DiscountValueBox.Name = "DiscountValueBox";
            this.DiscountValueBox.Size = new System.Drawing.Size(100, 20);
            this.DiscountValueBox.TabIndex = 20;
            // 
            // DiscountValueLabel
            // 
            this.DiscountValueLabel.AutoSize = true;
            this.DiscountValueLabel.Enabled = false;
            this.DiscountValueLabel.Location = new System.Drawing.Point(388, 200);
            this.DiscountValueLabel.Name = "DiscountValueLabel";
            this.DiscountValueLabel.Size = new System.Drawing.Size(56, 13);
            this.DiscountValueLabel.TabIndex = 19;
            this.DiscountValueLabel.Text = "Desconto:";
            // 
            // TicketValueBox
            // 
            this.TicketValueBox.Enabled = false;
            this.TicketValueBox.Location = new System.Drawing.Point(390, 115);
            this.TicketValueBox.Name = "TicketValueBox";
            this.TicketValueBox.Size = new System.Drawing.Size(100, 20);
            this.TicketValueBox.TabIndex = 18;
            // 
            // TicketValueLabel
            // 
            this.TicketValueLabel.AutoSize = true;
            this.TicketValueLabel.Enabled = false;
            this.TicketValueLabel.Location = new System.Drawing.Point(389, 99);
            this.TicketValueLabel.Name = "TicketValueLabel";
            this.TicketValueLabel.Size = new System.Drawing.Size(82, 13);
            this.TicketValueLabel.TabIndex = 17;
            this.TicketValueLabel.Text = "Valor de multas:";
            // 
            // DelayBox
            // 
            this.DelayBox.Enabled = false;
            this.DelayBox.Location = new System.Drawing.Point(390, 64);
            this.DelayBox.Name = "DelayBox";
            this.DelayBox.Size = new System.Drawing.Size(100, 20);
            this.DelayBox.TabIndex = 16;
            // 
            // DealyLabel
            // 
            this.DealyLabel.AutoSize = true;
            this.DealyLabel.Enabled = false;
            this.DealyLabel.Location = new System.Drawing.Point(389, 48);
            this.DealyLabel.Name = "DealyLabel";
            this.DealyLabel.Size = new System.Drawing.Size(80, 13);
            this.DealyLabel.TabIndex = 15;
            this.DealyLabel.Text = "Dias atrasados:";
            // 
            // EndDate
            // 
            this.EndDate.Location = new System.Drawing.Point(13, 115);
            this.EndDate.Mask = "00/00/0000";
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(100, 20);
            this.EndDate.TabIndex = 27;
            this.EndDate.ValidatingType = typeof(System.DateTime);
            // 
            // PayDate
            // 
            this.PayDate.Location = new System.Drawing.Point(14, 167);
            this.PayDate.Mask = "00/00/0000";
            this.PayDate.Name = "PayDate";
            this.PayDate.Size = new System.Drawing.Size(100, 20);
            this.PayDate.TabIndex = 28;
            this.PayDate.ValidatingType = typeof(System.DateTime);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 366);
            this.Controls.Add(this.PayDate);
            this.Controls.Add(this.EndDate);
            this.Controls.Add(this.TotalBox);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.AddBox);
            this.Controls.Add(this.AddLabel);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.FeesValueLabel);
            this.Controls.Add(this.DiscountValueBox);
            this.Controls.Add(this.DiscountValueLabel);
            this.Controls.Add(this.TicketValueBox);
            this.Controls.Add(this.TicketValueLabel);
            this.Controls.Add(this.DelayBox);
            this.Controls.Add(this.DealyLabel);
            this.Controls.Add(this.DiscountBox);
            this.Controls.Add(this.DescountLabel);
            this.Controls.Add(this.FeesBox);
            this.Controls.Add(this.FeeLabel);
            this.Controls.Add(this.TicketBox);
            this.Controls.Add(this.TicketLabel);
            this.Controls.Add(this.PayLabel);
            this.Controls.Add(this.EndLabel);
            this.Controls.Add(this.ValueBox);
            this.Controls.Add(this.ValueLabel);
            this.Controls.Add(this.EraseBtn);
            this.Controls.Add(this.LeaveBtn);
            this.Controls.Add(this.CalcBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalcBtn;
        private System.Windows.Forms.Button LeaveBtn;
        private System.Windows.Forms.Button EraseBtn;
        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.TextBox ValueBox;
        private System.Windows.Forms.Label EndLabel;
        private System.Windows.Forms.Label PayLabel;
        private System.Windows.Forms.TextBox TicketBox;
        private System.Windows.Forms.Label TicketLabel;
        private System.Windows.Forms.TextBox FeesBox;
        private System.Windows.Forms.Label FeeLabel;
        private System.Windows.Forms.TextBox DiscountBox;
        private System.Windows.Forms.Label DescountLabel;
        private System.Windows.Forms.TextBox TotalBox;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.TextBox AddBox;
        private System.Windows.Forms.Label AddLabel;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label FeesValueLabel;
        private System.Windows.Forms.TextBox DiscountValueBox;
        private System.Windows.Forms.Label DiscountValueLabel;
        private System.Windows.Forms.TextBox TicketValueBox;
        private System.Windows.Forms.Label TicketValueLabel;
        private System.Windows.Forms.TextBox DelayBox;
        private System.Windows.Forms.Label DealyLabel;
        private System.Windows.Forms.MaskedTextBox EndDate;
        private System.Windows.Forms.MaskedTextBox PayDate;
    }
}

