using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_2_2_2023
{
    public partial class Form1 : Form
    {
        Graphics myGraphics;

        Pen myPen1, myPen2;
        int startX, startY, endX, endY;
        bool draw = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            myPen1 = new Pen(btnShowColor.ForeColor, int.Parse(txtW.Text));
            //myGraphics.DrawLine(myPen1, 100, 100, 200, 200);
            startX = int.Parse(sX.Text);
            startY = int.Parse(sY.Text);

            endX = int.Parse(eX.Text);
            endX = int.Parse(eY.Text);
            myGraphics.DrawLine(myPen1, startX, startY, endX, endY);
        }

        private void form1_MouseMove(object sender, MouseEventArgs e)
        {
            lblCo.Text = "Position: " + e.X + " , " + e.Y;
        }

        private void form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (chkDraw.Checked == true)
            {
                startX = e.X;
                startY = e.Y;
                draw = true;
            }


        }

        private void chkDraw_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (chkDraw.Checked == true)
            {
                draw = false;
                endX = e.X;
                endY = e.Y;
                myPen1 = new Pen(btnShowColor.ForeColor, int.Parse(txtW.Text));
                myGraphics.DrawLine(myPen1, startX, startY, endX, endY);
            }

        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string str = null;
                str = dlg.Color.Name;
                btnShowColor.Text = str;
                btnShowColor.ForeColor = dlg.Color;
                // https://www.codeproject.com/Tips/811495/Simple-Paint-Application-in-Csharp
                btnShowColor.BackColor = dlg.Color;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myGraphics = CreateGraphics();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Invalidate();
            // Last Updated: 3-2-2023
            // Set button to Default between Input TextBox and Checkbox 
            this.Invalidate();
            this.sX.Clear();
            this.sY.Clear();
            this.eX.Clear();
            this.eY.Clear();
            this.chkDraw.Checked = false;
            //this.txtW.Clear();
        }
    }
}
