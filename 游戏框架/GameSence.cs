using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 游戏框架.Common;
using 游戏框架.Component;
using 游戏框架.Object;
using 游戏框架.Properties;

namespace 游戏框架
{
    /// <summary>
    /// 游戏场景
    /// </summary>
    public class GameSence
    {
        //是否放大背景
        public bool IsAim { get; set; }

        //存储游戏对象
        public List<GameObject> GameObjects { get; set; }

        //目标窗体
        public Form1 Target { get; set; }

        /// <summary>
        /// 鼠标位置
        /// </summary>
        public Point MousePoint = new Point(0, 0);

        public GameSence(Form1 form1)
        {
            this.Target = form1;
            GameObjects = new List<GameObject>();
            Target.Paint += Target_Paint;

            Timer timer = new Timer();
            timer.Interval = 50;
            timer.Tick += timer_Tick;
            timer.Start();
        }

        private void Target_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            SpriteRender.RenderFrame(e.Graphics);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //鼠标相对于窗体左上角的坐标
            MousePoint = Target.PointToClient(Control.MousePosition);
            //重绘事件
            this.Target.Invalidate(true);

        }

        public Position Get_Mouse_Position()
        {
            var pos = Target.PointToClient(Control.MousePosition);
            return new Position(pos.X, pos.Y);
        }

        public void AddGameObject(GameObject go)
        {
            go.Owner = this;    
            GameObjects.Add(go);
            this.Target.Paint += go.OnUpdate;
            this.Target.MouseClick += go.OnMouseClick;
            this.Target.MouseMove += go.OnMouseMove;
        }

        public void RemoveGameObject(GameObject go)
        {
            go.Owner = null;
            this.Target.Paint -= go.OnUpdate;
            this.Target.MouseClick -= go.OnMouseClick;
            this.Target.MouseMove -= go.OnMouseMove;
            this.GameObjects.Remove(go);
        }
    }
}
