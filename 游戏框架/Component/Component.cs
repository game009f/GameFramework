using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 游戏框架.Component
{
    public class Component:IComponents
    {
        //组件所在游戏对象
        public GameObject Owner
        {
            get;
            set;
        }

        public virtual void OnUpdate(GameObject go, System.Drawing.Rectangle rec, System.Drawing.Graphics g)
        {
        }

        public virtual void OnMouseClickLeft(GameObject go, System.Windows.Forms.MouseEventArgs e)
        {
        }

        public virtual void OnMouseClickRight(GameObject go, System.Windows.Forms.MouseEventArgs e)
        {
        }

        public virtual void OnMouseMove(GameObject go, System.Windows.Forms.MouseEventArgs e)
        {
        }
    }
}
