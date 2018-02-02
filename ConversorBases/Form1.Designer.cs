namespace ConversorBases
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Hex1 = new System.Windows.Forms.RadioButton();
            this.Oc1 = new System.Windows.Forms.RadioButton();
            this.Dec1 = new System.Windows.Forms.RadioButton();
            this.Binary1 = new System.Windows.Forms.RadioButton();
            this.Hex2 = new System.Windows.Forms.RadioButton();
            this.Oc2 = new System.Windows.Forms.RadioButton();
            this.Dec2 = new System.Windows.Forms.RadioButton();
            this.Binary2 = new System.Windows.Forms.RadioButton();
            this.btnConvert = new System.Windows.Forms.Button();
            this.NumTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ConvertTXT = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Hex1);
            this.panel1.Controls.Add(this.Oc1);
            this.panel1.Controls.Add(this.Dec1);
            this.panel1.Controls.Add(this.Binary1);
            this.panel1.Location = new System.Drawing.Point(12, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 203);
            this.panel1.TabIndex = 0;
            // 
            // Hex1
            // 
            this.Hex1.AutoSize = true;
            this.Hex1.Location = new System.Drawing.Point(22, 100);
            this.Hex1.Name = "Hex1";
            this.Hex1.Size = new System.Drawing.Size(86, 17);
            this.Hex1.TabIndex = 3;
            this.Hex1.TabStop = true;
            this.Hex1.Text = "Hexadecimal";
            this.Hex1.UseVisualStyleBackColor = true;
            // 
            // Oc1
            // 
            this.Oc1.AutoSize = true;
            this.Oc1.Location = new System.Drawing.Point(22, 76);
            this.Oc1.Name = "Oc1";
            this.Oc1.Size = new System.Drawing.Size(50, 17);
            this.Oc1.TabIndex = 2;
            this.Oc1.TabStop = true;
            this.Oc1.Text = "Octal";
            this.Oc1.UseVisualStyleBackColor = true;
            this.Oc1.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // Dec1
            // 
            this.Dec1.AutoSize = true;
            this.Dec1.Location = new System.Drawing.Point(22, 52);
            this.Dec1.Name = "Dec1";
            this.Dec1.Size = new System.Drawing.Size(63, 17);
            this.Dec1.TabIndex = 1;
            this.Dec1.TabStop = true;
            this.Dec1.Text = "Decimal";
            this.Dec1.UseVisualStyleBackColor = true;
            // 
            // Binary1
            // 
            this.Binary1.AutoSize = true;
            this.Binary1.Location = new System.Drawing.Point(22, 28);
            this.Binary1.Name = "Binary1";
            this.Binary1.Size = new System.Drawing.Size(57, 17);
            this.Binary1.TabIndex = 0;
            this.Binary1.TabStop = true;
            this.Binary1.Text = "Binário";
            this.Binary1.UseVisualStyleBackColor = true;
            // 
            // Hex2
            // 
            this.Hex2.AutoSize = true;
            this.Hex2.Location = new System.Drawing.Point(340, 197);
            this.Hex2.Name = "Hex2";
            this.Hex2.Size = new System.Drawing.Size(86, 17);
            this.Hex2.TabIndex = 7;
            this.Hex2.TabStop = true;
            this.Hex2.Text = "Hexadecimal";
            this.Hex2.UseVisualStyleBackColor = true;
            // 
            // Oc2
            // 
            this.Oc2.AutoSize = true;
            this.Oc2.Location = new System.Drawing.Point(340, 173);
            this.Oc2.Name = "Oc2";
            this.Oc2.Size = new System.Drawing.Size(50, 17);
            this.Oc2.TabIndex = 6;
            this.Oc2.TabStop = true;
            this.Oc2.Text = "Octal";
            this.Oc2.UseVisualStyleBackColor = true;
            // 
            // Dec2
            // 
            this.Dec2.AutoSize = true;
            this.Dec2.Location = new System.Drawing.Point(340, 149);
            this.Dec2.Name = "Dec2";
            this.Dec2.Size = new System.Drawing.Size(63, 17);
            this.Dec2.TabIndex = 5;
            this.Dec2.TabStop = true;
            this.Dec2.Text = "Decimal";
            this.Dec2.UseVisualStyleBackColor = true;
            // 
            // Binary2
            // 
            this.Binary2.AutoSize = true;
            this.Binary2.Location = new System.Drawing.Point(340, 125);
            this.Binary2.Name = "Binary2";
            this.Binary2.Size = new System.Drawing.Size(57, 17);
            this.Binary2.TabIndex = 4;
            this.Binary2.TabStop = true;
            this.Binary2.Text = "Binário";
            this.Binary2.UseVisualStyleBackColor = true;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(196, 176);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(90, 38);
            this.btnConvert.TabIndex = 8;
            this.btnConvert.Text = "Converter";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // NumTXT
            // 
            this.NumTXT.Location = new System.Drawing.Point(71, 60);
            this.NumTXT.Name = "NumTXT";
            this.NumTXT.Size = new System.Drawing.Size(100, 20);
            this.NumTXT.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Número:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Número Convertido:";
            // 
            // ConvertTXT
            // 
            this.ConvertTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvertTXT.Location = new System.Drawing.Point(340, 60);
            this.ConvertTXT.Name = "ConvertTXT";
            this.ConvertTXT.ReadOnly = true;
            this.ConvertTXT.Size = new System.Drawing.Size(143, 20);
            this.ConvertTXT.TabIndex = 11;
            this.ConvertTXT.TextChanged += new System.EventHandler(this.ConvertTXT_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 236);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ConvertTXT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumTXT);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.Hex2);
            this.Controls.Add(this.Oc2);
            this.Controls.Add(this.Dec2);
            this.Controls.Add(this.Binary2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Conversor de Bases";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton Hex1;
        private System.Windows.Forms.RadioButton Oc1;
        private System.Windows.Forms.RadioButton Dec1;
        private System.Windows.Forms.RadioButton Binary1;
        private System.Windows.Forms.RadioButton Hex2;
        private System.Windows.Forms.RadioButton Oc2;
        private System.Windows.Forms.RadioButton Dec2;
        private System.Windows.Forms.RadioButton Binary2;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox NumTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ConvertTXT;
    }
}

