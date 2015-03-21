namespace HolaMundoForms
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CB_1 = new System.Windows.Forms.ComboBox();
            this.nudnumero1 = new System.Windows.Forms.NumericUpDown();
            this.nudnumero2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.bsumar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudnumero1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudnumero2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CB_1);
            this.groupBox1.Controls.Add(this.nudnumero1);
            this.groupBox1.Controls.Add(this.nudnumero2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Orange;
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 233);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese los datos de la sumadora";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Operación";
            // 
            // CB_1
            // 
            this.CB_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CB_1.FormattingEnabled = true;
            this.CB_1.Items.AddRange(new object[] {
            "Suma",
            "Resta",
            "Multiplicación",
            "División (#1 / #2)"});
            this.CB_1.Location = new System.Drawing.Point(102, 159);
            this.CB_1.Name = "CB_1";
            this.CB_1.Size = new System.Drawing.Size(177, 29);
            this.CB_1.TabIndex = 5;
            this.CB_1.SelectedIndexChanged += new System.EventHandler(this.CB_1_SelectedIndexChanged);
            // 
            // nudnumero1
            // 
            this.nudnumero1.DecimalPlaces = 2;
            this.nudnumero1.Location = new System.Drawing.Point(102, 37);
            this.nudnumero1.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.nudnumero1.Name = "nudnumero1";
            this.nudnumero1.Size = new System.Drawing.Size(177, 29);
            this.nudnumero1.TabIndex = 4;
            // 
            // nudnumero2
            // 
            this.nudnumero2.DecimalPlaces = 2;
            this.nudnumero2.Location = new System.Drawing.Point(102, 98);
            this.nudnumero2.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.nudnumero2.Name = "nudnumero2";
            this.nudnumero2.Size = new System.Drawing.Size(177, 29);
            this.nudnumero2.TabIndex = 3;
            this.nudnumero2.ValueChanged += new System.EventHandler(this.nudnumero2_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número 2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // bsumar
            // 
            this.bsumar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bsumar.FlatAppearance.BorderSize = 2;
            this.bsumar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bsumar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsumar.Location = new System.Drawing.Point(430, 178);
            this.bsumar.Name = "bsumar";
            this.bsumar.Size = new System.Drawing.Size(163, 52);
            this.bsumar.TabIndex = 2;
            this.bsumar.Text = "Resultado";
            this.bsumar.UseVisualStyleBackColor = true;
            this.bsumar.Click += new System.EventHandler(this.bsumar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsalir.BackgroundImage")));
            this.btnsalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.ForeColor = System.Drawing.Color.Transparent;
            this.btnsalir.Location = new System.Drawing.Point(544, 23);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(64, 67);
            this.btnsalir.TabIndex = 23;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(647, 331);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.bsumar);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Orange;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudnumero1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudnumero2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudnumero1;
        private System.Windows.Forms.NumericUpDown nudnumero2;
        private System.Windows.Forms.Button bsumar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CB_1;
        private System.Windows.Forms.Button btnsalir;
    }
}

