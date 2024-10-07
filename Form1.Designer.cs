namespace ColorCode
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HexCode = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.B = new System.Windows.Forms.TextBox();
            this.G = new System.Windows.Forms.TextBox();
            this.R = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.C = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.M = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.K = new System.Windows.Forms.TextBox();
            this.Y = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.L = new System.Windows.Forms.TextBox();
            this.S = new System.Windows.Forms.TextBox();
            this.H = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(29, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 252);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.HexCode);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 289);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 110);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "HexCode";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "HexCode";
            // 
            // HexCode
            // 
            this.HexCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HexCode.Location = new System.Drawing.Point(23, 58);
            this.HexCode.MaxLength = 6;
            this.HexCode.Name = "HexCode";
            this.HexCode.Size = new System.Drawing.Size(133, 30);
            this.HexCode.TabIndex = 0;
            this.HexCode.TextChanged += new System.EventHandler(this.HexCode_TextChanged);
            this.HexCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HexCode_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.B);
            this.groupBox2.Controls.Add(this.G);
            this.groupBox2.Controls.Add(this.R);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(253, 289);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(177, 156);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RGB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "G";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "R";
            // 
            // B
            // 
            this.B.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B.Location = new System.Drawing.Point(62, 101);
            this.B.MaxLength = 3;
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(95, 30);
            this.B.TabIndex = 0;
            this.B.TextChanged += new System.EventHandler(this.RGB_TextChanged);
            this.B.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RGB_KeyPress);
            // 
            // G
            // 
            this.G.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G.Location = new System.Drawing.Point(62, 65);
            this.G.MaxLength = 3;
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(95, 30);
            this.G.TabIndex = 0;
            this.G.TextChanged += new System.EventHandler(this.RGB_TextChanged);
            this.G.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RGB_KeyPress);
            // 
            // R
            // 
            this.R.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R.Location = new System.Drawing.Point(62, 31);
            this.R.MaxLength = 3;
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(95, 30);
            this.R.TabIndex = 0;
            this.R.TextChanged += new System.EventHandler(this.RGB_TextChanged);
            this.R.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RGB_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.C);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.M);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.K);
            this.groupBox3.Controls.Add(this.Y);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(29, 416);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(182, 187);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CMYK";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "K";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "Y";
            // 
            // C
            // 
            this.C.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C.Location = new System.Drawing.Point(45, 28);
            this.C.MaxLength = 3;
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(95, 30);
            this.C.TabIndex = 0;
            this.C.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CMYK_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "M";
            // 
            // M
            // 
            this.M.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M.Location = new System.Drawing.Point(45, 66);
            this.M.MaxLength = 3;
            this.M.Name = "M";
            this.M.Size = new System.Drawing.Size(95, 30);
            this.M.TabIndex = 0;
            this.M.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CMYK_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "C";
            // 
            // K
            // 
            this.K.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.K.Location = new System.Drawing.Point(45, 142);
            this.K.MaxLength = 3;
            this.K.Name = "K";
            this.K.Size = new System.Drawing.Size(95, 30);
            this.K.TabIndex = 0;
            this.K.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CMYK_KeyPress);
            // 
            // Y
            // 
            this.Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Y.Location = new System.Drawing.Point(45, 104);
            this.Y.MaxLength = 3;
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(95, 30);
            this.Y.TabIndex = 0;
            this.Y.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CMYK_KeyPress);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.L);
            this.groupBox4.Controls.Add(this.S);
            this.groupBox4.Controls.Add(this.H);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(253, 447);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(177, 156);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "HSL";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 25);
            this.label9.TabIndex = 1;
            this.label9.Text = "L";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 25);
            this.label10.TabIndex = 1;
            this.label10.Text = "S";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 25);
            this.label11.TabIndex = 1;
            this.label11.Text = "H";
            // 
            // L
            // 
            this.L.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L.Location = new System.Drawing.Point(62, 103);
            this.L.MaxLength = 3;
            this.L.Name = "L";
            this.L.Size = new System.Drawing.Size(95, 30);
            this.L.TabIndex = 0;
            this.L.TextChanged += new System.EventHandler(this.RGB_TextChanged);
            this.L.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RGB_KeyPress);
            // 
            // S
            // 
            this.S.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S.Location = new System.Drawing.Point(62, 67);
            this.S.MaxLength = 3;
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(95, 30);
            this.S.TabIndex = 0;
            this.S.TextChanged += new System.EventHandler(this.RGB_TextChanged);
            this.S.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RGB_KeyPress);
            // 
            // H
            // 
            this.H.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.H.Location = new System.Drawing.Point(62, 31);
            this.H.MaxLength = 3;
            this.H.Name = "H";
            this.H.Size = new System.Drawing.Size(95, 30);
            this.H.TabIndex = 0;
            this.H.TextChanged += new System.EventHandler(this.RGB_TextChanged);
            this.H.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RGB_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 633);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox HexCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox G;
        private System.Windows.Forms.TextBox R;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox B;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox C;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox M;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox K;
        private System.Windows.Forms.TextBox Y;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox L;
        private System.Windows.Forms.TextBox S;
        private System.Windows.Forms.TextBox H;
    }
}

