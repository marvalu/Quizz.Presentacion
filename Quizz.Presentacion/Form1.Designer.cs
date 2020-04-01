namespace Quizz.Presentacion
{
    partial class Form1
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
            this.eliminar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PaisText = new System.Windows.Forms.TextBox();
            this.ProvinciaText = new System.Windows.Forms.TextBox();
            this.DistritoText = new System.Windows.Forms.TextBox();
            this.Detalles1Text = new System.Windows.Forms.TextBox();
            this.Detalles2Text = new System.Windows.Forms.TextBox();
            this.TelFijoText = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.IDText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(265, 20);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 0;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // eliminar
            // 
            this.eliminar.Location = new System.Drawing.Point(344, 19);
            this.eliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(56, 19);
            this.eliminar.TabIndex = 1;
            this.eliminar.Text = "Eliminar";
            this.eliminar.UseVisualStyleBackColor = true;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(422, 20);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 19);
            this.button3.TabIndex = 2;
            this.button3.Text = "Modificar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pais";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Provincia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Distrito";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Detalles1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 154);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Detalles2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 188);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tel Fijo";
            // 
            // PaisText
            // 
            this.PaisText.Location = new System.Drawing.Point(146, 20);
            this.PaisText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PaisText.Name = "PaisText";
            this.PaisText.Size = new System.Drawing.Size(76, 20);
            this.PaisText.TabIndex = 10;
            // 
            // ProvinciaText
            // 
            this.ProvinciaText.Location = new System.Drawing.Point(146, 50);
            this.ProvinciaText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ProvinciaText.Name = "ProvinciaText";
            this.ProvinciaText.Size = new System.Drawing.Size(76, 20);
            this.ProvinciaText.TabIndex = 11;
            // 
            // DistritoText
            // 
            this.DistritoText.Location = new System.Drawing.Point(146, 83);
            this.DistritoText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DistritoText.Name = "DistritoText";
            this.DistritoText.Size = new System.Drawing.Size(76, 20);
            this.DistritoText.TabIndex = 12;
            // 
            // Detalles1Text
            // 
            this.Detalles1Text.Location = new System.Drawing.Point(146, 114);
            this.Detalles1Text.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Detalles1Text.Name = "Detalles1Text";
            this.Detalles1Text.Size = new System.Drawing.Size(76, 20);
            this.Detalles1Text.TabIndex = 13;
            // 
            // Detalles2Text
            // 
            this.Detalles2Text.Location = new System.Drawing.Point(146, 150);
            this.Detalles2Text.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Detalles2Text.Name = "Detalles2Text";
            this.Detalles2Text.Size = new System.Drawing.Size(76, 20);
            this.Detalles2Text.TabIndex = 14;
            // 
            // TelFijoText
            // 
            this.TelFijoText.Location = new System.Drawing.Point(146, 184);
            this.TelFijoText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TelFijoText.Name = "TelFijoText";
            this.TelFijoText.Size = new System.Drawing.Size(76, 20);
            this.TelFijoText.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(265, 102);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(310, 212);
            this.dataGridView1.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 223);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "ID";
            // 
            // IDText
            // 
            this.IDText.Location = new System.Drawing.Point(146, 220);
            this.IDText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IDText.Name = "IDText";
            this.IDText.Size = new System.Drawing.Size(76, 20);
            this.IDText.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.IDText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TelFijoText);
            this.Controls.Add(this.Detalles2Text);
            this.Controls.Add(this.Detalles1Text);
            this.Controls.Add(this.DistritoText);
            this.Controls.Add(this.ProvinciaText);
            this.Controls.Add(this.PaisText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PaisText;
        private System.Windows.Forms.TextBox ProvinciaText;
        private System.Windows.Forms.TextBox DistritoText;
        private System.Windows.Forms.TextBox Detalles1Text;
        private System.Windows.Forms.TextBox Detalles2Text;
        private System.Windows.Forms.TextBox TelFijoText;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox IDText;
    }
}

