using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDI练习.Properties;

namespace GDI练习
{
    public partial class Form1 : Form
    {
        const int LeftX = 0;
        const int LeftY = 0;

        int x = 0;
        int y = 0;

        public Form1()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer
                      | ControlStyles.ResizeRedraw
                      | ControlStyles.Selectable
                      | ControlStyles.AllPaintingInWmPaint
                      | ControlStyles.UserPaint
                      | ControlStyles.SupportsTransparentBackColor,
                    true);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Red), new Rectangle(0, 0, 800, 600));

            //绘制说明
            e.Graphics.DrawImage(Resources.bg, new System.Drawing.Rectangle(x, y, 1600, 1200), new System.Drawing.Rectangle(0, 0, 800, 600), GraphicsUnit.Pixel);
            //e.Graphics.DrawImage(Resources.bg, new System.Drawing.Rectangle(400, 300, 400, 300), new System.Drawing.Rectangle(0, 0, 800, 600), GraphicsUnit.Pixel);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Point screenPoint = Control.MousePosition;//鼠标相对于屏幕左上角的坐标
            Point formPoint = this.PointToClient(Control.MousePosition);//鼠标相对于窗体左上角的坐标
            //Point contextMenuPoint = contextMenuStrip1.PointToClient(Control.MousePosition); //鼠标相对于contextMenuStrip1左上角的坐标

            this.x = LeftX - formPoint.X;
            this.y = LeftY - formPoint.Y;
            this.Invalidate();
        }
    }
}
