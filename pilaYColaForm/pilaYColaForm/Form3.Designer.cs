
namespace pilaYColaForm
{
    partial class Form3
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
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnElementoABorrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAgregarElemento = new System.Windows.Forms.Button();
            this.txtBoxElemento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(8, 140);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(94, 29);
            this.btnBorrar.TabIndex = 13;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnElementoABorrar
            // 
            this.btnElementoABorrar.Location = new System.Drawing.Point(7, 104);
            this.btnElementoABorrar.Name = "btnElementoABorrar";
            this.btnElementoABorrar.Size = new System.Drawing.Size(204, 29);
            this.btnElementoABorrar.TabIndex = 12;
            this.btnElementoABorrar.Text = "Mostrar Elemento a borrar";
            this.btnElementoABorrar.UseVisualStyleBackColor = true;
            this.btnElementoABorrar.Click += new System.EventHandler(this.btnElementoABorrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Elementos insertados";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(241, 35);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(172, 244);
            this.listBox1.TabIndex = 10;
            // 
            // btnAgregarElemento
            // 
            this.btnAgregarElemento.Location = new System.Drawing.Point(7, 68);
            this.btnAgregarElemento.Name = "btnAgregarElemento";
            this.btnAgregarElemento.Size = new System.Drawing.Size(94, 29);
            this.btnAgregarElemento.TabIndex = 9;
            this.btnAgregarElemento.Text = "Agregar";
            this.btnAgregarElemento.UseVisualStyleBackColor = true;
            this.btnAgregarElemento.Click += new System.EventHandler(this.btnAgregarElemento_Click);
            // 
            // txtBoxElemento
            // 
            this.txtBoxElemento.Location = new System.Drawing.Point(7, 35);
            this.txtBoxElemento.Name = "txtBoxElemento";
            this.txtBoxElemento.Size = new System.Drawing.Size(125, 27);
            this.txtBoxElemento.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Agregar elemento";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 295);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnElementoABorrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnAgregarElemento);
            this.Controls.Add(this.txtBoxElemento);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnElementoABorrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnAgregarElemento;
        private System.Windows.Forms.TextBox txtBoxElemento;
        private System.Windows.Forms.Label label1;
    }
}