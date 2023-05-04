namespace lista_211494
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblS = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDespesa = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtProduto1 = new System.Windows.Forms.TextBox();
            this.lblDespesa = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDespesa = new System.Windows.Forms.Button();
            this.listDespesa = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtValortotal = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnProduto = new System.Windows.Forms.Button();
            this.listProdutos = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuant = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(511, 544);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 49);
            this.button1.TabIndex = 60;
            this.button1.Text = "FECHAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(187, 535);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(0, 19);
            this.lblSaldo.TabIndex = 59;
            // 
            // lblS
            // 
            this.lblS.AutoSize = true;
            this.lblS.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.lblS.Location = new System.Drawing.Point(12, 533);
            this.lblS.Name = "lblS";
            this.lblS.Size = new System.Drawing.Size(169, 20);
            this.lblS.TabIndex = 58;
            this.lblS.Text = "SALDO DA EMPRESA: R$";
            this.lblS.Click += new System.EventHandler(this.lblS_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(357, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 20);
            this.label10.TabIndex = 57;
            this.label10.Text = "DESPESA";
            // 
            // txtDespesa
            // 
            this.txtDespesa.Location = new System.Drawing.Point(435, 12);
            this.txtDespesa.Name = "txtDespesa";
            this.txtDespesa.Size = new System.Drawing.Size(105, 20);
            this.txtDespesa.TabIndex = 56;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 20);
            this.label9.TabIndex = 55;
            this.label9.Text = "PRODUTO";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtProduto1
            // 
            this.txtProduto1.Location = new System.Drawing.Point(102, 9);
            this.txtProduto1.Name = "txtProduto1";
            this.txtProduto1.Size = new System.Drawing.Size(114, 20);
            this.txtProduto1.TabIndex = 54;
            this.txtProduto1.TextChanged += new System.EventHandler(this.txtProduto1_TextChanged);
            // 
            // lblDespesa
            // 
            this.lblDespesa.AutoSize = true;
            this.lblDespesa.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDespesa.Location = new System.Drawing.Point(488, 392);
            this.lblDespesa.Name = "lblDespesa";
            this.lblDespesa.Size = new System.Drawing.Size(0, 34);
            this.lblDespesa.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(333, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 20);
            this.label6.TabIndex = 52;
            this.label6.Text = "TOTAL DA DESPESA: ";
            // 
            // btnDespesa
            // 
            this.btnDespesa.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.btnDespesa.Location = new System.Drawing.Point(379, 110);
            this.btnDespesa.Name = "btnDespesa";
            this.btnDespesa.Size = new System.Drawing.Size(184, 38);
            this.btnDespesa.TabIndex = 51;
            this.btnDespesa.Text = "INSERIR DESPESA";
            this.btnDespesa.UseVisualStyleBackColor = true;
            this.btnDespesa.Click += new System.EventHandler(this.btnDespesa_Click);
            // 
            // listDespesa
            // 
            this.listDespesa.FormattingEnabled = true;
            this.listDespesa.Location = new System.Drawing.Point(337, 164);
            this.listDespesa.Name = "listDespesa";
            this.listDespesa.Size = new System.Drawing.Size(274, 186);
            this.listDespesa.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(375, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 49;
            this.label7.Text = "VALOR";
            // 
            // txtValortotal
            // 
            this.txtValortotal.Location = new System.Drawing.Point(435, 53);
            this.txtValortotal.Name = "txtValortotal";
            this.txtValortotal.Size = new System.Drawing.Size(105, 20);
            this.txtValortotal.TabIndex = 48;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.btnLimpar.Location = new System.Drawing.Point(494, 471);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(121, 49);
            this.btnLimpar.TabIndex = 47;
            this.btnLimpar.Text = "NOVA VENDA";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(149, 383);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 34);
            this.lblTotal.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(12, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "TOTAL DA VENDA: ";
            // 
            // btnProduto
            // 
            this.btnProduto.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.btnProduto.Location = new System.Drawing.Point(84, 120);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Size = new System.Drawing.Size(154, 38);
            this.btnProduto.TabIndex = 44;
            this.btnProduto.Text = "INSERIR PRODUTO";
            this.btnProduto.UseVisualStyleBackColor = true;
            this.btnProduto.Click += new System.EventHandler(this.btnProduto_Click);
            // 
            // listProdutos
            // 
            this.listProdutos.FormattingEnabled = true;
            this.listProdutos.Location = new System.Drawing.Point(12, 164);
            this.listProdutos.Name = "listProdutos";
            this.listProdutos.Size = new System.Drawing.Size(274, 186);
            this.listProdutos.TabIndex = 43;
            this.listProdutos.SelectedIndexChanged += new System.EventHandler(this.listProdutos_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(38, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = "QUANT.";
            // 
            // txtQuant
            // 
            this.txtQuant.Location = new System.Drawing.Point(111, 51);
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.Size = new System.Drawing.Size(105, 20);
            this.txtQuant.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "VALOR UNI.";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(111, 91);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(105, 20);
            this.txtValor.TabIndex = 39;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(621, 598);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblS);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtDespesa);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtProduto1);
            this.Controls.Add(this.lblDespesa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDespesa);
            this.Controls.Add(this.listDespesa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtValortotal);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnProduto);
            this.Controls.Add(this.listProdutos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtQuant);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtValor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_saldo_final;
        private System.Windows.Forms.Label lbl_valor_saldo_final;
        private System.Windows.Forms.Button btn_encerrar;
        private System.Windows.Forms.Button btn_novo_lancamento;
        private System.Windows.Forms.GroupBox grb_total_despesas;
        private System.Windows.Forms.Label lbl_valor_total_despesas;
        private System.Windows.Forms.GroupBox grb_total_pedidos;
        private System.Windows.Forms.Label lbl_valor_total_pedidos;
        private System.Windows.Forms.ListBox lsb_despesas;
        private System.Windows.Forms.ListBox lsb_pedidos;
        private System.Windows.Forms.Button btn_inserir_despesa;
        private System.Windows.Forms.Button btn_inserir_pedido;
        private System.Windows.Forms.GroupBox grb_despesas;
        private System.Windows.Forms.TextBox txt_valor_despesa;
        private System.Windows.Forms.Label lbl_valor_despesa;
        private System.Windows.Forms.TextBox txt_despesa;
        private System.Windows.Forms.Label lbl_despesa;
        private System.Windows.Forms.GroupBox grb_pedidos;
        private System.Windows.Forms.TextBox txt_valor_pedido;
        private System.Windows.Forms.TextBox txt_nome_cliente;
        private System.Windows.Forms.TextBox txt_numero_pedido;
        private System.Windows.Forms.Label lbl_valor_pedido;
        private System.Windows.Forms.Label lbl_nome_cliente;
        private System.Windows.Forms.Label lbl_numero_pedido;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblS;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDespesa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtProduto1;
        private System.Windows.Forms.Label lblDespesa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDespesa;
        private System.Windows.Forms.ListBox listDespesa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtValortotal;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnProduto;
        private System.Windows.Forms.ListBox listProdutos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQuant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValor;
    }
}

