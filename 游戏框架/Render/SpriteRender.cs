using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace 游戏框架.Component
{
    public class SpriteTask
    {
        //渲染需要将对象做一个简单的封装
        public Image SourceImage { get; set; }

        /// <summary>
        /// 目标矩形
        /// </summary>
        public Rectangle DesRectangle { get; set; }

        /// <summary>
        /// 要绘制的原矩形
        /// </summary>
        public Rectangle SrcRectangle { get; set; }

        //索引小的先绘制到窗体
        public int ZIndex { get; set; }
    }


    /// <summary>
    /// 渲染组件
    /// </summary>
    public class SpriteRender : Component
    {
        //渲染图片
        public Image SpriteImage { get; set; }
        //缓冲图片
        public static Image BufferImage { get; set; }

        public static Graphics BufferGraphics { get; set; }

        //索引小的先绘制到窗体
        public int ZIndex { get; set; }


        //所有要绘制的对象
        public static List<SpriteTask> Task { get; set; }

        public SpriteRender()
        {
            Task = new List<SpriteTask>();
            BufferImage = new Bitmap(328, 488);
            BufferGraphics = Graphics.FromImage(BufferImage);
            ZIndex = 0;
        }

        /// <summary>
        /// 每帧都在渲染
        /// </summary>
        public static void RenderFrame(Graphics g)
        {
            if (Task.Count > 0)
            {
                //g.Clear(Color.Black);   
                //排序
                Task = Task.OrderBy(n => n.ZIndex).ToList();
                //黑色清空画布
                BufferGraphics.Clear(Color.Black);
                foreach (var item in Task)
                {
                    //绘制到缓冲区
                    BufferGraphics.DrawImage(item.SourceImage, item.DesRectangle, item.SrcRectangle, GraphicsUnit.Pixel);
                }
                //绘制元素数量
                BufferGraphics.DrawString(Task.Count.ToString(), new Font("Arial", 16), new SolidBrush(Color.Red), 0, 0);
                //绘制到界面
                g.DrawImage(BufferImage,new Point(0,0));
                //绘制完成之后将之前的元素清空
                Task.Clear();
            }
        }

        public override void OnMouseClickLeft(GameObject go, System.Windows.Forms.MouseEventArgs e)
        {
            base.OnMouseClickLeft(go, e);
        }

        public override void OnMouseClickRight(GameObject go, System.Windows.Forms.MouseEventArgs e)
        {
            base.OnMouseClickRight(go, e);
        }

        public override void OnUpdate(GameObject go, Rectangle rec, Graphics graphics)
        {
            base.OnUpdate(go, rec, graphics);
        }

        public override void OnMouseMove(GameObject go, System.Windows.Forms.MouseEventArgs e)
        {
            base.OnMouseMove(go, e);
        }
    }
}
