namespace Calculadora
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.display = new System.Windows.Forms.Label();
            this.num7 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Button();
            this.igual = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.suma = new System.Windows.Forms.Button();
            this.resta = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.producto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.display.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.ForeColor = System.Drawing.Color.Lime;
            this.display.Location = new System.Drawing.Point(13, 13);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(330, 74);
            this.display.TabIndex = 0;
            this.display.Text = "0";
            this.display.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // num7
            // 
            this.num7.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num7.Location = new System.Drawing.Point(20, 91);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(54, 55);
            this.num7.TabIndex = 1;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = true;
            this.num7.Click += new System.EventHandler(this.numero_Click);
            // 
            // num8
            // 
            this.num8.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num8.Location = new System.Drawing.Point(80, 91);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(54, 55);
            this.num8.TabIndex = 2;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = true;
            this.num8.Click += new System.EventHandler(this.numero_Click);
            // 
            // num9
            // 
            this.num9.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num9.Location = new System.Drawing.Point(140, 91);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(54, 55);
            this.num9.TabIndex = 3;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = true;
            this.num9.Click += new System.EventHandler(this.numero_Click);
            // 
            // num6
            // 
            this.num6.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num6.Location = new System.Drawing.Point(140, 152);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(54, 55);
            this.num6.TabIndex = 6;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = true;
            this.num6.Click += new System.EventHandler(this.numero_Click);
            // 
            // num5
            // 
            this.num5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num5.Location = new System.Drawing.Point(80, 152);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(54, 55);
            this.num5.TabIndex = 5;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = true;
            this.num5.Click += new System.EventHandler(this.numero_Click);
            // 
            // num4
            // 
            this.num4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num4.Location = new System.Drawing.Point(20, 152);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(54, 55);
            this.num4.TabIndex = 4;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = true;
            this.num4.Click += new System.EventHandler(this.numero_Click);
            // 
            // num3
            // 
            this.num3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num3.Location = new System.Drawing.Point(140, 213);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(54, 55);
            this.num3.TabIndex = 9;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = true;
            this.num3.Click += new System.EventHandler(this.numero_Click);
            // 
            // num2
            // 
            this.num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2.Location = new System.Drawing.Point(80, 213);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(54, 55);
            this.num2.TabIndex = 8;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = true;
            this.num2.Click += new System.EventHandler(this.numero_Click);
            // 
            // num1
            // 
            this.num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1.Location = new System.Drawing.Point(20, 213);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(54, 55);
            this.num1.TabIndex = 7;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = true;
            this.num1.Click += new System.EventHandler(this.numero_Click);
            // 
            // igual
            // 
            this.igual.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igual.Location = new System.Drawing.Point(80, 274);
            this.igual.Name = "igual";
            this.igual.Size = new System.Drawing.Size(114, 55);
            this.igual.TabIndex = 12;
            this.igual.Text = "=";
            this.igual.UseVisualStyleBackColor = true;
            this.igual.Click += new System.EventHandler(this.igual_Click);
            // 
            // num0
            // 
            this.num0.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num0.Location = new System.Drawing.Point(20, 274);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(54, 55);
            this.num0.TabIndex = 11;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = true;
            this.num0.Click += new System.EventHandler(this.numero_Click);
            // 
            // suma
            // 
            this.suma.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.suma.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.suma.Location = new System.Drawing.Point(201, 91);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(142, 55);
            this.suma.TabIndex = 13;
            this.suma.Text = "+";
            this.suma.UseVisualStyleBackColor = true;
            this.suma.Click += new System.EventHandler(this.operacion_Click);
            // 
            // resta
            // 
            this.resta.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.resta.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.resta.Location = new System.Drawing.Point(200, 152);
            this.resta.Name = "resta";
            this.resta.Size = new System.Drawing.Size(142, 55);
            this.resta.TabIndex = 14;
            this.resta.Text = "-";
            this.resta.UseVisualStyleBackColor = true;
            this.resta.Click += new System.EventHandler(this.operacion_Click);
            // 
            // division
            // 
            this.division.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.division.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.division.Location = new System.Drawing.Point(200, 213);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(142, 55);
            this.division.TabIndex = 15;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            // 
            // producto
            // 
            this.producto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.producto.Location = new System.Drawing.Point(200, 274);
            this.producto.Name = "producto";
            this.producto.Size = new System.Drawing.Size(142, 55);
            this.producto.TabIndex = 16;
            this.producto.Text = "*";
            this.producto.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 347);
            this.Controls.Add(this.producto);
            this.Controls.Add(this.division);
            this.Controls.Add(this.resta);
            this.Controls.Add(this.suma);
            this.Controls.Add(this.igual);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.display);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label display;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button igual;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.Button suma;
        private System.Windows.Forms.Button resta;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button producto;
    }
}

