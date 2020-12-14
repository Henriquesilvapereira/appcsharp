
namespace appcsharp
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
            this.btnfech = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtempresa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtvis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txttel = new System.Windows.Forms.TextBox();
            this.btnlist = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnfech
            // 
            this.btnfech.Location = new System.Drawing.Point(708, 375);
            this.btnfech.Name = "btnfech";
            this.btnfech.Size = new System.Drawing.Size(80, 39);
            this.btnfech.TabIndex = 0;
            this.btnfech.Text = "Fechar";
            this.btnfech.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome Completo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(20, 75);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(210, 20);
            this.txtnome.TabIndex = 2;
            this.txtnome.TextChanged += new System.EventHandler(this.txtnome_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Empresa";
            // 
            // txtempresa
            // 
            this.txtempresa.Location = new System.Drawing.Point(20, 126);
            this.txtempresa.Name = "txtempresa";
            this.txtempresa.Size = new System.Drawing.Size(210, 20);
            this.txtempresa.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(462, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Visita";
            // 
            // txtvis
            // 
            this.txtvis.Location = new System.Drawing.Point(465, 42);
            this.txtvis.Name = "txtvis";
            this.txtvis.Size = new System.Drawing.Size(203, 20);
            this.txtvis.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(462, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefone";
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(465, 76);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(112, 20);
            this.txttel.TabIndex = 7;
            // 
            // btnlist
            // 
            this.btnlist.Location = new System.Drawing.Point(708, 318);
            this.btnlist.Name = "btnlist";
            this.btnlist.Size = new System.Drawing.Size(80, 35);
            this.btnlist.TabIndex = 9;
            this.btnlist.Text = "Listar";
            this.btnlist.UseVisualStyleBackColor = true;
            this.btnlist.Click += new System.EventHandler(this.btnlist_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(631, 272);
            this.dataGridView1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "ID";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(20, 36);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(45, 20);
            this.txtid.TabIndex = 12;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(708, 272);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 29);
            this.btnInserir.TabIndex = 13;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(708, 230);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(77, 26);
            this.btnexcluir.TabIndex = 14;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnlist);
            this.Controls.Add(this.txtvis);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtempresa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnfech);
            this.Name = "Form1";
            this.Text = "Contatos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnfech;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtempresa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtvis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.Button btnlist;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnexcluir;
    }
}

