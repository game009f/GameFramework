using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 游戏框架.Component
{
    public interface IComponents
    {
        GameObject Owner { get; set; }
        //游戏对象去执行
        void OnUpdate(GameObject go, Rectangle rec, Graphics g);

        void OnMouseClickLeft(GameObject go, MouseEventArgs e);

        void OnMouseClickRight(GameObject go, MouseEventArgs e);

        void OnMouseMove(GameObject go, MouseEventArgs e);
    }
}
