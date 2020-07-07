namespace ProjetoPOO
{
    partial class PedidosCliente
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Cliente = new System.Windows.Forms.Label();
            this.Localizacao = new System.Windows.Forms.Label();
            this.Destino = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.confirmar = new System.Windows.Forms.Button();
            this.Rejeitar = new System.Windows.Forms.Button();
            this.txtcliente = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.loc = new System.Windows.Forms.TextBox();
            this.dest = new System.Windows.Forms.TextBox();
            this.pag = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cliente
            // 
            this.Cliente.AutoSize = true;
            this.Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cliente.Location = new System.Drawing.Point(16, 32);
            this.Cliente.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Cliente.Name = "Cliente";
            this.Cliente.Size = new System.Drawing.Size(60, 18);
            this.Cliente.TabIndex = 0;
            this.Cliente.Text = "Cliente";
            // 
            // Localizacao
            // 
            this.Localizacao.AutoSize = true;
            this.Localizacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Localizacao.Location = new System.Drawing.Point(16, 79);
            this.Localizacao.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Localizacao.Name = "Localizacao";
            this.Localizacao.Size = new System.Drawing.Size(99, 18);
            this.Localizacao.TabIndex = 1;
            this.Localizacao.Text = "Localização";
            // 
            // Destino
            // 
            this.Destino.AutoSize = true;
            this.Destino.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Destino.Location = new System.Drawing.Point(16, 134);
            this.Destino.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Destino.Name = "Destino";
            this.Destino.Size = new System.Drawing.Size(66, 18);
            this.Destino.TabIndex = 2;
            this.Destino.Text = "Destino";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 176);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Foma de pagamento";
            // 
            // confirmar
            // 
            this.confirmar.BackColor = System.Drawing.Color.LimeGreen;
            this.confirmar.ForeColor = System.Drawing.Color.White;
            this.confirmar.Location = new System.Drawing.Point(590, 79);
            this.confirmar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.confirmar.Name = "confirmar";
            this.confirmar.Size = new System.Drawing.Size(167, 50);
            this.confirmar.TabIndex = 4;
            this.confirmar.Text = "Confirmar";
            this.confirmar.UseVisualStyleBackColor = false;
            this.confirmar.Click += new System.EventHandler(this.confirmar_Click);
            // 
            // Rejeitar
            // 
            this.Rejeitar.BackColor = System.Drawing.Color.Red;
            this.Rejeitar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Rejeitar.Location = new System.Drawing.Point(590, 144);
            this.Rejeitar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Rejeitar.Name = "Rejeitar";
            this.Rejeitar.Size = new System.Drawing.Size(167, 50);
            this.Rejeitar.TabIndex = 5;
            this.Rejeitar.Text = "Rejeitar";
            this.Rejeitar.UseVisualStyleBackColor = false;
            // 
            // txtcliente
            // 
            this.txtcliente.BackColor = System.Drawing.SystemColors.Control;
            this.txtcliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcliente.Location = new System.Drawing.Point(84, 22);
            this.txtcliente.Multiline = true;
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.Size = new System.Drawing.Size(308, 28);
            this.txtcliente.TabIndex = 6;
            this.txtcliente.TextChanged += new System.EventHandler(this.txtcliente_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // loc
            // 
            this.loc.BackColor = System.Drawing.SystemColors.Control;
            this.loc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loc.Location = new System.Drawing.Point(143, 79);
            this.loc.Multiline = true;
            this.loc.Name = "loc";
            this.loc.Size = new System.Drawing.Size(439, 28);
            this.loc.TabIndex = 8;
            this.loc.TextChanged += new System.EventHandler(this.loc_TextChanged);
            // 
            // dest
            // 
            this.dest.BackColor = System.Drawing.SystemColors.Control;
            this.dest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dest.Location = new System.Drawing.Point(143, 124);
            this.dest.Multiline = true;
            this.dest.Name = "dest";
            this.dest.Size = new System.Drawing.Size(439, 28);
            this.dest.TabIndex = 9;
            // 
            // pag
            // 
            this.pag.BackColor = System.Drawing.SystemColors.Control;
            this.pag.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pag.Location = new System.Drawing.Point(200, 175);
            this.pag.Multiline = true;
            this.pag.Name = "pag";
            this.pag.Size = new System.Drawing.Size(172, 28);
            this.pag.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(590, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 29);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(457, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Valor da corrida";
            // 
            // PedidosCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pag);
            this.Controls.Add(this.dest);
            this.Controls.Add(this.loc);
            this.Controls.Add(this.txtcliente);
            this.Controls.Add(this.Rejeitar);
            this.Controls.Add(this.confirmar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Destino);
            this.Controls.Add(this.Localizacao);
            this.Controls.Add(this.Cliente);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "PedidosCliente";
            this.Size = new System.Drawing.Size(777, 208);
            this.Load += new System.EventHandler(this.PedidosCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Cliente;
        private System.Windows.Forms.Label Localizacao;
        private System.Windows.Forms.Label Destino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button confirmar;
        private System.Windows.Forms.Button Rejeitar;
        private System.Windows.Forms.TextBox txtcliente;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox loc;
        private System.Windows.Forms.TextBox dest;
        private System.Windows.Forms.TextBox pag;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}
