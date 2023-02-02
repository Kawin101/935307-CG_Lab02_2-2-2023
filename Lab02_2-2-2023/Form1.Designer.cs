namespace Lab02_2_2_2023
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
            this.btnDraw = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtW = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnShowColor = new System.Windows.Forms.Button();
            this.lblCo = new System.Windows.Forms.Label();
            this.chkDraw = new System.Windows.Forms.CheckBox();
            this.lbl_sXY = new System.Windows.Forms.Label();
            this.lbl_eXY = new System.Windows.Forms.Label();
            this.sX = new System.Windows.Forms.TextBox();
            this.sY = new System.Windows.Forms.TextBox();
            this.eX = new System.Windows.Forms.TextBox();
            this.eY = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDraw
            // 
            this.btnDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDraw.Location = new System.Drawing.Point(505, 160);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(121, 51);
            this.btnDraw.TabIndex = 0;
            this.btnDraw.Text = "Pen";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(505, 229);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(121, 52);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Line Size:";
            // 
            // txtW
            // 
            this.txtW.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtW.Location = new System.Drawing.Point(167, 99);
            this.txtW.Name = "txtW";
            this.txtW.Size = new System.Drawing.Size(100, 31);
            this.txtW.TabIndex = 3;
            this.txtW.Text = "5";
            // 
            // btnColor
            // 
            this.btnColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColor.Location = new System.Drawing.Point(49, 46);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(112, 36);
            this.btnColor.TabIndex = 4;
            this.btnColor.Text = "Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnShowColor
            // 
            this.btnShowColor.Enabled = false;
            this.btnShowColor.Location = new System.Drawing.Point(177, 47);
            this.btnShowColor.Name = "btnShowColor";
            this.btnShowColor.Size = new System.Drawing.Size(78, 35);
            this.btnShowColor.TabIndex = 5;
            this.btnShowColor.UseVisualStyleBackColor = true;
            // 
            // lblCo
            // 
            this.lblCo.AutoSize = true;
            this.lblCo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCo.Location = new System.Drawing.Point(62, 392);
            this.lblCo.Name = "lblCo";
            this.lblCo.Size = new System.Drawing.Size(95, 25);
            this.lblCo.TabIndex = 6;
            this.lblCo.Text = "Position:";
            // 
            // chkDraw
            // 
            this.chkDraw.AutoSize = true;
            this.chkDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDraw.Location = new System.Drawing.Point(284, 46);
            this.chkDraw.Name = "chkDraw";
            this.chkDraw.Size = new System.Drawing.Size(144, 28);
            this.chkDraw.TabIndex = 7;
            this.chkDraw.Text = "Need to Draw";
            this.chkDraw.UseVisualStyleBackColor = true;
            this.chkDraw.CheckedChanged += new System.EventHandler(this.chkDraw_CheckedChanged);
            // 
            // lbl_sXY
            // 
            this.lbl_sXY.AutoSize = true;
            this.lbl_sXY.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sXY.Location = new System.Drawing.Point(500, 36);
            this.lbl_sXY.Name = "lbl_sXY";
            this.lbl_sXY.Size = new System.Drawing.Size(91, 25);
            this.lbl_sXY.TabIndex = 8;
            this.lbl_sXY.Text = "Start X:";
            // 
            // lbl_eXY
            // 
            this.lbl_eXY.AutoSize = true;
            this.lbl_eXY.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_eXY.Location = new System.Drawing.Point(509, 99);
            this.lbl_eXY.Name = "lbl_eXY";
            this.lbl_eXY.Size = new System.Drawing.Size(82, 25);
            this.lbl_eXY.TabIndex = 10;
            this.lbl_eXY.Text = "End X:";
            // 
            // sX
            // 
            this.sX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sX.Location = new System.Drawing.Point(597, 30);
            this.sX.Name = "sX";
            this.sX.Size = new System.Drawing.Size(56, 31);
            this.sX.TabIndex = 11;
            // 
            // sY
            // 
            this.sY.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sY.Location = new System.Drawing.Point(666, 30);
            this.sY.Name = "sY";
            this.sY.Size = new System.Drawing.Size(59, 31);
            this.sY.TabIndex = 12;
            // 
            // eX
            // 
            this.eX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eX.Location = new System.Drawing.Point(597, 94);
            this.eX.Name = "eX";
            this.eX.Size = new System.Drawing.Size(58, 31);
            this.eX.TabIndex = 13;
            // 
            // eY
            // 
            this.eY.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eY.Location = new System.Drawing.Point(666, 93);
            this.eY.Name = "eY";
            this.eY.Size = new System.Drawing.Size(59, 31);
            this.eY.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 450);
            this.Controls.Add(this.eY);
            this.Controls.Add(this.eX);
            this.Controls.Add(this.sY);
            this.Controls.Add(this.sX);
            this.Controls.Add(this.lbl_eXY);
            this.Controls.Add(this.lbl_sXY);
            this.Controls.Add(this.chkDraw);
            this.Controls.Add(this.lblCo);
            this.Controls.Add(this.btnShowColor);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.txtW);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDraw);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtW;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnShowColor;
        private System.Windows.Forms.Label lblCo;
        private System.Windows.Forms.CheckBox chkDraw;
        private System.Windows.Forms.Label lbl_sXY;
        private System.Windows.Forms.Label lbl_eXY;
        private System.Windows.Forms.TextBox sX;
        private System.Windows.Forms.TextBox sY;
        private System.Windows.Forms.TextBox eX;
        private System.Windows.Forms.TextBox eY;
    }
}

