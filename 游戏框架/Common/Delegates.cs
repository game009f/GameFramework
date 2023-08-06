using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 游戏框架.Common
{
    public class Delegates
    {
        public delegate void DUpdate(GameObject go,Rectangle rec ,Graphics g);

        public delegate void DMouseLeftClick(GameObject go,MouseEventArgs e);

        public delegate void DMouseRightClick(GameObject go, MouseEventArgs e);

        public delegate void DMouseMove(GameObject go, MouseEventArgs e);
    }
}
