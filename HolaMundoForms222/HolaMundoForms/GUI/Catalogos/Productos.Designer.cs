namespace HolaMundoForms.Catalogos
{
    partial class Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
            this.button3 = new System.Windows.Forms.Button();
            this.txt_Nombre_completo = new System.Windows.Forms.TextBox();
            this.txt_Cod_producto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NuevoUsusario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_Fecha = new System.Windows.Forms.DateTimePicker();
            this.nud_Precio = new System.Windows.Forms.NumericUpDown();
            this.nud_Costo = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Precio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Costo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(586, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 68);
            this.button3.TabIndex = 27;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txt_Nombre_completo
            // 
            this.txt_Nombre_completo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre_completo.Location = new System.Drawing.Point(213, 104);
            this.txt_Nombre_completo.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Nombre_completo.Name = "txt_Nombre_completo";
            this.txt_Nombre_completo.Size = new System.Drawing.Size(434, 32);
            this.txt_Nombre_completo.TabIndex = 34;
            // 
            // txt_Cod_producto
            // 
            this.txt_Cod_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cod_producto.Location = new System.Drawing.Point(252, 56);
            this.txt_Cod_producto.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Cod_producto.Name = "txt_Cod_producto";
            this.txt_Cod_producto.Size = new System.Drawing.Size(253, 32);
            this.txt_Cod_producto.TabIndex = 33;
            this.txt_Cod_producto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 207);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 26);
            this.label4.TabIndex = 32;
            this.label4.Text = "Costo:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 26);
            this.label3.TabIndex = 31;
            this.label3.Text = "Precio:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 104);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 26);
            this.label1.TabIndex = 29;
            this.label1.Text = "Nombre Completo:";
            // 
            // NuevoUsusario
            // 
            this.NuevoUsusario.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoUsusario.Location = new System.Drawing.Point(2, 60);
            this.NuevoUsusario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NuevoUsusario.Name = "NuevoUsusario";
            this.NuevoUsusario.Size = new System.Drawing.Size(231, 26);
            this.NuevoUsusario.TabIndex = 28;
            this.NuevoUsusario.Text = "Código del Producto:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 259);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 24);
            this.label2.TabIndex = 37;
            this.label2.Text = "Fecha:";
            // 
            // dtp_Fecha
            // 
            this.dtp_Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.dtp_Fecha.Location = new System.Drawing.Point(169, 259);
            this.dtp_Fecha.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_Fecha.Name = "dtp_Fecha";
            this.dtp_Fecha.Size = new System.Drawing.Size(375, 32);
            this.dtp_Fecha.TabIndex = 38;
            // 
            // nud_Precio
            // 
            this.nud_Precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_Precio.Location = new System.Drawing.Point(198, 159);
            this.nud_Precio.Margin = new System.Windows.Forms.Padding(2);
            this.nud_Precio.Name = "nud_Precio";
            this.nud_Precio.Size = new System.Drawing.Size(90, 32);
            this.nud_Precio.TabIndex = 39;
            this.nud_Precio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nud_Costo
            // 
            this.nud_Costo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_Costo.Location = new System.Drawing.Point(198, 204);
            this.nud_Costo.Margin = new System.Windows.Forms.Padding(2);
            this.nud_Costo.Name = "nud_Costo";
            this.nud_Costo.Size = new System.Drawing.Size(90, 32);
            this.nud_Costo.TabIndex = 40;
            this.nud_Costo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 320);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(694, 90);
            this.panel1.TabIndex = 131;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(463, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 68);
            this.button2.TabIndex = 129;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(694, 410);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nud_Costo);
            this.Controls.Add(this.nud_Precio);
            this.Controls.Add(this.dtp_Fecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Nombre_completo);
            this.Controls.Add(this.txt_Cod_producto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NuevoUsusario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_Precio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Costo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txt_Nombre_completo;
        private System.Windows.Forms.TextBox txt_Cod_producto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NuevoUsusario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_Fecha;
        private System.Windows.Forms.NumericUpDown nud_Precio;
        private System.Windows.Forms.NumericUpDown nud_Costo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;

    }
}