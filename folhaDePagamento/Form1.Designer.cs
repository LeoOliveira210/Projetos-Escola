
namespace folhaDePagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tituloLabel = new System.Windows.Forms.Label();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.horasLabel = new System.Windows.Forms.Label();
            this.valorHoraLabel = new System.Windows.Forms.Label();
            this.valorInssLabel = new System.Windows.Forms.Label();
            this.impostoLabel = new System.Windows.Forms.Label();
            this.fundoDeGarantiaLabel = new System.Windows.Forms.Label();
            this.valeTransLabel = new System.Windows.Forms.Label();
            this.salarioBrutoLabel = new System.Windows.Forms.Label();
            this.descontosLabel = new System.Windows.Forms.Label();
            this.salarioLiquidoLabel = new System.Windows.Forms.Label();
            this.nomeTB = new System.Windows.Forms.TextBox();
            this.horasTB = new System.Windows.Forms.TextBox();
            this.valorHoraTB = new System.Windows.Forms.TextBox();
            this.valorInssTB = new System.Windows.Forms.TextBox();
            this.impostoTB = new System.Windows.Forms.TextBox();
            this.garantiaTB = new System.Windows.Forms.TextBox();
            this.valeTransporteTB = new System.Windows.Forms.TextBox();
            this.salarioBrutoTB = new System.Windows.Forms.TextBox();
            this.descontosTB = new System.Windows.Forms.TextBox();
            this.salarioLiquidoTB = new System.Windows.Forms.TextBox();
            this.calculoGeralBTT = new System.Windows.Forms.Button();
            this.limparBTT = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tituloLabel
            // 
            this.tituloLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.Location = new System.Drawing.Point(336, 9);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(385, 46);
            this.tituloLabel.TabIndex = 0;
            this.tituloLabel.Text = "Folha de pagamento";
            // 
            // nomeLabel
            // 
            this.nomeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.nomeLabel.Location = new System.Drawing.Point(67, 100);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(171, 23);
            this.nomeLabel.TabIndex = 1;
            this.nomeLabel.Text = "Entre com o nome";
            // 
            // horasLabel
            // 
            this.horasLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.horasLabel.AutoSize = true;
            this.horasLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horasLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.horasLabel.Location = new System.Drawing.Point(67, 150);
            this.horasLabel.Name = "horasLabel";
            this.horasLabel.Size = new System.Drawing.Size(272, 23);
            this.horasLabel.TabIndex = 2;
            this.horasLabel.Text = "Entre com o número de horas";
            // 
            // valorHoraLabel
            // 
            this.valorHoraLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valorHoraLabel.AutoSize = true;
            this.valorHoraLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorHoraLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.valorHoraLabel.Location = new System.Drawing.Point(67, 200);
            this.valorHoraLabel.Name = "valorHoraLabel";
            this.valorHoraLabel.Size = new System.Drawing.Size(238, 23);
            this.valorHoraLabel.TabIndex = 3;
            this.valorHoraLabel.Text = "Entre com o valor da hora";
            // 
            // valorInssLabel
            // 
            this.valorInssLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valorInssLabel.AutoSize = true;
            this.valorInssLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorInssLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.valorInssLabel.Location = new System.Drawing.Point(67, 250);
            this.valorInssLabel.Name = "valorInssLabel";
            this.valorInssLabel.Size = new System.Drawing.Size(106, 23);
            this.valorInssLabel.TabIndex = 4;
            this.valorInssLabel.Text = "Valor INSS";
            // 
            // impostoLabel
            // 
            this.impostoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.impostoLabel.AutoSize = true;
            this.impostoLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.impostoLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.impostoLabel.Location = new System.Drawing.Point(67, 300);
            this.impostoLabel.Name = "impostoLabel";
            this.impostoLabel.Size = new System.Drawing.Size(240, 23);
            this.impostoLabel.TabIndex = 5;
            this.impostoLabel.Text = "Imposto a ser descontado";
            // 
            // fundoDeGarantiaLabel
            // 
            this.fundoDeGarantiaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fundoDeGarantiaLabel.AutoSize = true;
            this.fundoDeGarantiaLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fundoDeGarantiaLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.fundoDeGarantiaLabel.Location = new System.Drawing.Point(67, 350);
            this.fundoDeGarantiaLabel.Name = "fundoDeGarantiaLabel";
            this.fundoDeGarantiaLabel.Size = new System.Drawing.Size(169, 23);
            this.fundoDeGarantiaLabel.TabIndex = 6;
            this.fundoDeGarantiaLabel.Text = "Fundo de garantia";
            // 
            // valeTransLabel
            // 
            this.valeTransLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valeTransLabel.AutoSize = true;
            this.valeTransLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valeTransLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.valeTransLabel.Location = new System.Drawing.Point(67, 400);
            this.valeTransLabel.Name = "valeTransLabel";
            this.valeTransLabel.Size = new System.Drawing.Size(144, 23);
            this.valeTransLabel.TabIndex = 7;
            this.valeTransLabel.Text = "Vale transporte";
            // 
            // salarioBrutoLabel
            // 
            this.salarioBrutoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.salarioBrutoLabel.AutoSize = true;
            this.salarioBrutoLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salarioBrutoLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.salarioBrutoLabel.Location = new System.Drawing.Point(648, 100);
            this.salarioBrutoLabel.Name = "salarioBrutoLabel";
            this.salarioBrutoLabel.Size = new System.Drawing.Size(124, 23);
            this.salarioBrutoLabel.TabIndex = 8;
            this.salarioBrutoLabel.Text = "Salário Bruto";
            // 
            // descontosLabel
            // 
            this.descontosLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descontosLabel.AutoSize = true;
            this.descontosLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descontosLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.descontosLabel.Location = new System.Drawing.Point(648, 150);
            this.descontosLabel.Name = "descontosLabel";
            this.descontosLabel.Size = new System.Drawing.Size(148, 23);
            this.descontosLabel.TabIndex = 9;
            this.descontosLabel.Text = "Total descontos";
            // 
            // salarioLiquidoLabel
            // 
            this.salarioLiquidoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.salarioLiquidoLabel.AutoSize = true;
            this.salarioLiquidoLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salarioLiquidoLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.salarioLiquidoLabel.Location = new System.Drawing.Point(648, 200);
            this.salarioLiquidoLabel.Name = "salarioLiquidoLabel";
            this.salarioLiquidoLabel.Size = new System.Drawing.Size(132, 23);
            this.salarioLiquidoLabel.TabIndex = 10;
            this.salarioLiquidoLabel.Text = "Salario liquido";
            // 
            // nomeTB
            // 
            this.nomeTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nomeTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomeTB.Location = new System.Drawing.Point(381, 99);
            this.nomeTB.Name = "nomeTB";
            this.nomeTB.Size = new System.Drawing.Size(137, 26);
            this.nomeTB.TabIndex = 11;
            // 
            // horasTB
            // 
            this.horasTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.horasTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.horasTB.Location = new System.Drawing.Point(381, 150);
            this.horasTB.Name = "horasTB";
            this.horasTB.Size = new System.Drawing.Size(137, 26);
            this.horasTB.TabIndex = 12;
            this.horasTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.horasTB_KeyPress);
            // 
            // valorHoraTB
            // 
            this.valorHoraTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valorHoraTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valorHoraTB.Location = new System.Drawing.Point(381, 200);
            this.valorHoraTB.Name = "valorHoraTB";
            this.valorHoraTB.Size = new System.Drawing.Size(137, 26);
            this.valorHoraTB.TabIndex = 13;
            this.valorHoraTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valorHoraTB_KeyPress);
            // 
            // valorInssTB
            // 
            this.valorInssTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valorInssTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.valorInssTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valorInssTB.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.valorInssTB.Enabled = false;
            this.valorInssTB.ForeColor = System.Drawing.Color.Red;
            this.valorInssTB.Location = new System.Drawing.Point(381, 250);
            this.valorInssTB.Name = "valorInssTB";
            this.valorInssTB.Size = new System.Drawing.Size(137, 26);
            this.valorInssTB.TabIndex = 14;
            // 
            // impostoTB
            // 
            this.impostoTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.impostoTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.impostoTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.impostoTB.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.impostoTB.Enabled = false;
            this.impostoTB.ForeColor = System.Drawing.Color.Red;
            this.impostoTB.Location = new System.Drawing.Point(381, 300);
            this.impostoTB.Name = "impostoTB";
            this.impostoTB.ReadOnly = true;
            this.impostoTB.Size = new System.Drawing.Size(137, 26);
            this.impostoTB.TabIndex = 15;
            // 
            // garantiaTB
            // 
            this.garantiaTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.garantiaTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.garantiaTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.garantiaTB.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.garantiaTB.Enabled = false;
            this.garantiaTB.Location = new System.Drawing.Point(381, 350);
            this.garantiaTB.Name = "garantiaTB";
            this.garantiaTB.Size = new System.Drawing.Size(137, 26);
            this.garantiaTB.TabIndex = 16;
            // 
            // valeTransporteTB
            // 
            this.valeTransporteTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valeTransporteTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.valeTransporteTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valeTransporteTB.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.valeTransporteTB.Enabled = false;
            this.valeTransporteTB.Location = new System.Drawing.Point(381, 400);
            this.valeTransporteTB.Name = "valeTransporteTB";
            this.valeTransporteTB.Size = new System.Drawing.Size(137, 26);
            this.valeTransporteTB.TabIndex = 17;
            this.valeTransporteTB.TextChanged += new System.EventHandler(this.valeTransporteTB_TextChanged);
            // 
            // salarioBrutoTB
            // 
            this.salarioBrutoTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.salarioBrutoTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.salarioBrutoTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.salarioBrutoTB.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.salarioBrutoTB.Enabled = false;
            this.salarioBrutoTB.Location = new System.Drawing.Point(822, 100);
            this.salarioBrutoTB.Name = "salarioBrutoTB";
            this.salarioBrutoTB.Size = new System.Drawing.Size(137, 26);
            this.salarioBrutoTB.TabIndex = 18;
            // 
            // descontosTB
            // 
            this.descontosTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descontosTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.descontosTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descontosTB.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.descontosTB.Enabled = false;
            this.descontosTB.Location = new System.Drawing.Point(822, 150);
            this.descontosTB.Name = "descontosTB";
            this.descontosTB.Size = new System.Drawing.Size(137, 26);
            this.descontosTB.TabIndex = 19;
            // 
            // salarioLiquidoTB
            // 
            this.salarioLiquidoTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.salarioLiquidoTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.salarioLiquidoTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.salarioLiquidoTB.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.salarioLiquidoTB.Enabled = false;
            this.salarioLiquidoTB.Location = new System.Drawing.Point(822, 200);
            this.salarioLiquidoTB.Name = "salarioLiquidoTB";
            this.salarioLiquidoTB.Size = new System.Drawing.Size(137, 26);
            this.salarioLiquidoTB.TabIndex = 20;
            // 
            // calculoGeralBTT
            // 
            this.calculoGeralBTT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.calculoGeralBTT.BackColor = System.Drawing.Color.LightBlue;
            this.calculoGeralBTT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calculoGeralBTT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculoGeralBTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculoGeralBTT.Location = new System.Drawing.Point(729, 274);
            this.calculoGeralBTT.Name = "calculoGeralBTT";
            this.calculoGeralBTT.Size = new System.Drawing.Size(132, 40);
            this.calculoGeralBTT.TabIndex = 21;
            this.calculoGeralBTT.Text = "Calcul&ar";
            this.calculoGeralBTT.UseVisualStyleBackColor = false;
            this.calculoGeralBTT.Click += new System.EventHandler(this.calculoGeralBTT_Click);
            // 
            // limparBTT
            // 
            this.limparBTT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.limparBTT.BackColor = System.Drawing.Color.LightBlue;
            this.limparBTT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.limparBTT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.limparBTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limparBTT.Location = new System.Drawing.Point(729, 333);
            this.limparBTT.Name = "limparBTT";
            this.limparBTT.Size = new System.Drawing.Size(132, 40);
            this.limparBTT.TabIndex = 22;
            this.limparBTT.Text = "&Limpar";
            this.limparBTT.UseVisualStyleBackColor = false;
            this.limparBTT.Click += new System.EventHandler(this.limparBTT_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(634, 400);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1027, 485);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.limparBTT);
            this.Controls.Add(this.calculoGeralBTT);
            this.Controls.Add(this.salarioLiquidoTB);
            this.Controls.Add(this.descontosTB);
            this.Controls.Add(this.salarioBrutoTB);
            this.Controls.Add(this.valeTransporteTB);
            this.Controls.Add(this.garantiaTB);
            this.Controls.Add(this.impostoTB);
            this.Controls.Add(this.valorInssTB);
            this.Controls.Add(this.valorHoraTB);
            this.Controls.Add(this.horasTB);
            this.Controls.Add(this.nomeTB);
            this.Controls.Add(this.salarioLiquidoLabel);
            this.Controls.Add(this.descontosLabel);
            this.Controls.Add(this.salarioBrutoLabel);
            this.Controls.Add(this.valeTransLabel);
            this.Controls.Add(this.fundoDeGarantiaLabel);
            this.Controls.Add(this.impostoLabel);
            this.Controls.Add(this.valorInssLabel);
            this.Controls.Add(this.valorHoraLabel);
            this.Controls.Add(this.horasLabel);
            this.Controls.Add(this.nomeLabel);
            this.Controls.Add(this.tituloLabel);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Folha de pagamento";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.Label horasLabel;
        private System.Windows.Forms.Label valorHoraLabel;
        private System.Windows.Forms.Label valorInssLabel;
        private System.Windows.Forms.Label impostoLabel;
        private System.Windows.Forms.Label fundoDeGarantiaLabel;
        private System.Windows.Forms.Label valeTransLabel;
        private System.Windows.Forms.Label salarioBrutoLabel;
        private System.Windows.Forms.Label descontosLabel;
        private System.Windows.Forms.Label salarioLiquidoLabel;
        private System.Windows.Forms.TextBox nomeTB;
        private System.Windows.Forms.TextBox horasTB;
        private System.Windows.Forms.TextBox valorHoraTB;
        private System.Windows.Forms.TextBox valorInssTB;
        private System.Windows.Forms.TextBox impostoTB;
        private System.Windows.Forms.TextBox garantiaTB;
        private System.Windows.Forms.TextBox valeTransporteTB;
        private System.Windows.Forms.TextBox salarioBrutoTB;
        private System.Windows.Forms.TextBox descontosTB;
        private System.Windows.Forms.TextBox salarioLiquidoTB;
        private System.Windows.Forms.Button calculoGeralBTT;
        private System.Windows.Forms.Button limparBTT;
        private System.Windows.Forms.TextBox textBox1;
    }
}

