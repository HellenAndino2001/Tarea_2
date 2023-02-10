namespace Ejercicio2_Tarea
{
    partial class UserControl1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nota1 = new System.Windows.Forms.Label();
            this.nota2 = new System.Windows.Forms.Label();
            this.nota3 = new System.Windows.Forms.Label();
            this.nota4 = new System.Windows.Forms.Label();
            this.TB1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TB4 = new System.Windows.Forms.TextBox();
            this.TB3 = new System.Windows.Forms.TextBox();
            this.TB2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(266, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calcular ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Promedio Final";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nota1
            // 
            this.nota1.AutoSize = true;
            this.nota1.Location = new System.Drawing.Point(88, 127);
            this.nota1.Name = "nota1";
            this.nota1.Size = new System.Drawing.Size(74, 13);
            this.nota1.TabIndex = 2;
            this.nota1.Text = "Nota Parcial I:";
            this.nota1.Click += new System.EventHandler(this.label2_Click);
            // 
            // nota2
            // 
            this.nota2.AutoSize = true;
            this.nota2.Location = new System.Drawing.Point(88, 165);
            this.nota2.Name = "nota2";
            this.nota2.Size = new System.Drawing.Size(77, 13);
            this.nota2.TabIndex = 3;
            this.nota2.Text = "Nota Parcial II:";
            // 
            // nota3
            // 
            this.nota3.AutoSize = true;
            this.nota3.Location = new System.Drawing.Point(88, 201);
            this.nota3.Name = "nota3";
            this.nota3.Size = new System.Drawing.Size(80, 13);
            this.nota3.TabIndex = 4;
            this.nota3.Text = "Nota Parcial III:";
            this.nota3.Click += new System.EventHandler(this.label4_Click);
            // 
            // nota4
            // 
            this.nota4.AutoSize = true;
            this.nota4.Location = new System.Drawing.Point(88, 232);
            this.nota4.Name = "nota4";
            this.nota4.Size = new System.Drawing.Size(81, 13);
            this.nota4.TabIndex = 5;
            this.nota4.Text = "Nota Parcial IV:";
            this.nota4.Click += new System.EventHandler(this.label5_Click);
            // 
            // TB1
            // 
            this.TB1.Location = new System.Drawing.Point(182, 120);
            this.TB1.Name = "TB1";
            this.TB1.Size = new System.Drawing.Size(120, 20);
            this.TB1.TabIndex = 6;
            this.TB1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // TB4
            // 
            this.TB4.Location = new System.Drawing.Point(182, 229);
            this.TB4.Name = "TB4";
            this.TB4.Size = new System.Drawing.Size(120, 20);
            this.TB4.TabIndex = 8;
            // 
            // TB3
            // 
            this.TB3.Location = new System.Drawing.Point(182, 198);
            this.TB3.Name = "TB3";
            this.TB3.Size = new System.Drawing.Size(120, 20);
            this.TB3.TabIndex = 9;
            this.TB3.TextChanged += new System.EventHandler(this.TB3_TextChanged);
            // 
            // TB2
            // 
            this.TB2.Location = new System.Drawing.Point(182, 158);
            this.TB2.Name = "TB2";
            this.TB2.Size = new System.Drawing.Size(120, 20);
            this.TB2.TabIndex = 10;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TB2);
            this.Controls.Add(this.TB3);
            this.Controls.Add(this.TB4);
            this.Controls.Add(this.TB1);
            this.Controls.Add(this.nota4);
            this.Controls.Add(this.nota3);
            this.Controls.Add(this.nota2);
            this.Controls.Add(this.nota1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(800, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nota1;
        private System.Windows.Forms.Label nota2;
        private System.Windows.Forms.Label nota3;
        private System.Windows.Forms.Label nota4;
        private System.Windows.Forms.TextBox TB1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox TB4;
        private System.Windows.Forms.TextBox TB3;
        private System.Windows.Forms.TextBox TB2;
    }
}
