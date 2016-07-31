namespace WindowsFormsApplication1
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
            this.lblAviso = new System.Windows.Forms.Label();
            this.lblHex = new System.Windows.Forms.Label();
            this.txbInput = new System.Windows.Forms.TextBox();
            this.txbOutput = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Location = new System.Drawing.Point(12, 9);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(435, 17);
            this.lblAviso.TabIndex = 0;
            this.lblAviso.Text = "O código inserido não deve conter o preâmbulo e nem a parte final.";
            // 
            // lblHex
            // 
            this.lblHex.AutoSize = true;
            this.lblHex.Location = new System.Drawing.Point(12, 50);
            this.lblHex.Name = "lblHex";
            this.lblHex.Size = new System.Drawing.Size(82, 17);
            this.lblHex.TabIndex = 1;
            this.lblHex.Text = "Pronto Hex:";
            // 
            // txbInput
            // 
            this.txbInput.Location = new System.Drawing.Point(100, 48);
            this.txbInput.Name = "txbInput";
            this.txbInput.Size = new System.Drawing.Size(625, 22);
            this.txbInput.TabIndex = 2;
            this.txbInput.TextChanged += new System.EventHandler(this.txbInput_TextChanged);
            // 
            // txbOutput
            // 
            this.txbOutput.Location = new System.Drawing.Point(164, 254);
            this.txbOutput.Name = "txbOutput";
            this.txbOutput.ReadOnly = true;
            this.txbOutput.Size = new System.Drawing.Size(561, 22);
            this.txbOutput.TabIndex = 4;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(12, 257);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(146, 17);
            this.lblCode.TabIndex = 3;
            this.lblCode.Text = "Resultado em binário:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(309, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 78);
            this.button1.TabIndex = 5;
            this.button1.Text = "Converter\r\n ↓";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Número de códigos hex: 0 ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tamanho do binário: 0 ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Resultado em hexa:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(164, 295);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(561, 22);
            this.textBox1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 345);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbOutput);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.txbInput);
            this.Controls.Add(this.lblHex);
            this.Controls.Add(this.lblAviso);
            this.Name = "Form1";
            this.Text = "Conversor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.Label lblHex;
        private System.Windows.Forms.TextBox txbInput;
        private System.Windows.Forms.TextBox txbOutput;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
    }
}

