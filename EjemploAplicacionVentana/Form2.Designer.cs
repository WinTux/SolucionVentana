namespace EjemploAplicacionVentana
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.est_dat_3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_elemento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.est_dat_1 = new System.Windows.Forms.TabPage();
            this.est_dat_2 = new System.Windows.Forms.TabPage();
            this.txt_salida = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.est_dat_3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(627, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.est_dat_3);
            this.tabControl1.Controls.Add(this.est_dat_1);
            this.tabControl1.Controls.Add(this.est_dat_2);
            this.tabControl1.Location = new System.Drawing.Point(10, 52);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(715, 268);
            this.tabControl1.TabIndex = 2;
            // 
            // est_dat_3
            // 
            this.est_dat_3.Controls.Add(this.groupBox2);
            this.est_dat_3.Controls.Add(this.groupBox1);
            this.est_dat_3.Location = new System.Drawing.Point(4, 24);
            this.est_dat_3.Name = "est_dat_3";
            this.est_dat_3.Size = new System.Drawing.Size(707, 240);
            this.est_dat_3.TabIndex = 2;
            this.est_dat_3.Text = "List";
            this.est_dat_3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_salida);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(274, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 234);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Salida";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(60, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Mostrar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txt_elemento);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entrada";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(107, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Agregar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_elemento
            // 
            this.txt_elemento.Location = new System.Drawing.Point(82, 27);
            this.txt_elemento.Name = "txt_elemento";
            this.txt_elemento.Size = new System.Drawing.Size(100, 23);
            this.txt_elemento.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Elemento:";
            // 
            // est_dat_1
            // 
            this.est_dat_1.Location = new System.Drawing.Point(4, 24);
            this.est_dat_1.Name = "est_dat_1";
            this.est_dat_1.Padding = new System.Windows.Forms.Padding(3);
            this.est_dat_1.Size = new System.Drawing.Size(707, 240);
            this.est_dat_1.TabIndex = 0;
            this.est_dat_1.Text = "Stack";
            this.est_dat_1.UseVisualStyleBackColor = true;
            // 
            // est_dat_2
            // 
            this.est_dat_2.Location = new System.Drawing.Point(4, 24);
            this.est_dat_2.Name = "est_dat_2";
            this.est_dat_2.Padding = new System.Windows.Forms.Padding(3);
            this.est_dat_2.Size = new System.Drawing.Size(707, 240);
            this.est_dat_2.TabIndex = 1;
            this.est_dat_2.Text = "Queue";
            this.est_dat_2.UseVisualStyleBackColor = true;
            // 
            // txt_salida
            // 
            this.txt_salida.AutoSize = true;
            this.txt_salida.Location = new System.Drawing.Point(34, 73);
            this.txt_salida.Name = "txt_salida";
            this.txt_salida.Size = new System.Drawing.Size(38, 15);
            this.txt_salida.TabIndex = 1;
            this.txt_salida.Text = "label2";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 386);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Servicio X";
            this.tabControl1.ResumeLayout(false);
            this.est_dat_3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage est_dat_1;
        private System.Windows.Forms.TabPage est_dat_2;
        private System.Windows.Forms.TabPage est_dat_3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_elemento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txt_salida;
    }
}