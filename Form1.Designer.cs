
namespace FormEjercicio04
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grpNewNum = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMns = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.grpOrden = new System.Windows.Forms.GroupBox();
            this.rdBtnAscendente = new System.Windows.Forms.RadioButton();
            this.rdBtnDescendente = new System.Windows.Forms.RadioButton();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.grpNumeros = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.grpNewNum.SuspendLayout();
            this.grpOrden.SuspendLayout();
            this.grpNumeros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpNewNum
            // 
            this.grpNewNum.Controls.Add(this.groupBox1);
            this.grpNewNum.Controls.Add(this.lblMns);
            this.grpNewNum.Controls.Add(this.textBox1);
            this.grpNewNum.Controls.Add(this.btnAgregar);
            this.grpNewNum.Location = new System.Drawing.Point(12, 12);
            this.grpNewNum.Name = "grpNewNum";
            this.grpNewNum.Size = new System.Drawing.Size(310, 124);
            this.grpNewNum.TabIndex = 0;
            this.grpNewNum.TabStop = false;
            this.grpNewNum.Text = "Ingrese un nuevo número";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Location = new System.Drawing.Point(98, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 163);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "grpCalificacion";
            // 
            // lblMns
            // 
            this.lblMns.AutoSize = true;
            this.lblMns.BackColor = System.Drawing.Color.LightCoral;
            this.lblMns.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMns.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMns.Location = new System.Drawing.Point(6, 19);
            this.lblMns.Name = "lblMns";
            this.lblMns.Size = new System.Drawing.Size(275, 16);
            this.lblMns.TabIndex = 4;
            this.lblMns.Text = "Para ingresar un numero primero elegir un orden";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 23);
            this.textBox1.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(163, 40);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(102, 34);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // grpOrden
            // 
            this.grpOrden.Controls.Add(this.rdBtnAscendente);
            this.grpOrden.Controls.Add(this.rdBtnDescendente);
            this.grpOrden.Controls.Add(this.btnOrdenar);
            this.grpOrden.Location = new System.Drawing.Point(12, 142);
            this.grpOrden.Name = "grpOrden";
            this.grpOrden.Size = new System.Drawing.Size(310, 159);
            this.grpOrden.TabIndex = 0;
            this.grpOrden.TabStop = false;
            this.grpOrden.Text = "Orden";
            // 
            // rdBtnAscendente
            // 
            this.rdBtnAscendente.AutoSize = true;
            this.rdBtnAscendente.Location = new System.Drawing.Point(19, 42);
            this.rdBtnAscendente.Name = "rdBtnAscendente";
            this.rdBtnAscendente.Size = new System.Drawing.Size(87, 19);
            this.rdBtnAscendente.TabIndex = 4;
            this.rdBtnAscendente.TabStop = true;
            this.rdBtnAscendente.Text = "Ascendente";
            this.rdBtnAscendente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdBtnAscendente.UseVisualStyleBackColor = true;
            // 
            // rdBtnDescendente
            // 
            this.rdBtnDescendente.AutoSize = true;
            this.rdBtnDescendente.Location = new System.Drawing.Point(19, 110);
            this.rdBtnDescendente.Name = "rdBtnDescendente";
            this.rdBtnDescendente.Size = new System.Drawing.Size(93, 19);
            this.rdBtnDescendente.TabIndex = 5;
            this.rdBtnDescendente.TabStop = true;
            this.rdBtnDescendente.Text = "Descendente";
            this.rdBtnDescendente.UseVisualStyleBackColor = true;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(163, 69);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(102, 33);
            this.btnOrdenar.TabIndex = 1;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // grpNumeros
            // 
            this.grpNumeros.Controls.Add(this.listBox1);
            this.grpNumeros.Location = new System.Drawing.Point(353, 12);
            this.grpNumeros.Name = "grpNumeros";
            this.grpNumeros.Size = new System.Drawing.Size(255, 326);
            this.grpNumeros.TabIndex = 0;
            this.grpNumeros.TabStop = false;
            this.grpNumeros.Text = "Lista de números";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(20, 30);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(214, 274);
            this.listBox1.TabIndex = 6;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(12, 307);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(310, 31);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 350);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.grpOrden);
            this.Controls.Add(this.grpNumeros);
            this.Controls.Add(this.grpNewNum);
            this.Name = "Form1";
            this.Text = "FrmPrincipal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpNewNum.ResumeLayout(false);
            this.grpNewNum.PerformLayout();
            this.grpOrden.ResumeLayout(false);
            this.grpOrden.PerformLayout();
            this.grpNumeros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNewNum;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox grpOrden;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.GroupBox grpNumeros;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.RadioButton rdBtnAscendente;
        private System.Windows.Forms.RadioButton rdBtnDescendente;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblMns;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

