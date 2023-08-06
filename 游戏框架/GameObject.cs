using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 游戏框架.Common;
using 游戏框架.Component;

namespace 游戏框架
{
    public class GameObject
    {
        //控制游戏对象的旋转，缩放，位置
        public TransForm TransForm { get; set; }

        //游戏状态
        public GState GState { get; set; }

        //游戏类型
        public GType GType { get; set; }

        //所在游戏场景引用
        public GameSence Owner { get; set; }

        //存储组件对象
        public List<IComponents> Components { get; set; }

        //在游戏对象中使用组件提供的功能
        public event Delegates.DUpdate update;
        public event Delegates.DMouseLeftClick mouseLeftClick;
        public event Delegates.DMouseRightClick mouseRightClick;
        public event Delegates.DMouseMove mouseMove;

        public GameObject()
        {
            TransForm = new TransForm()
            {
                Position = new Position(0, 0),
                Scale = new Scale(1, 1),
                Rotation = 0 //不旋转
            };
            Components = new List<IComponents>();
        }
        /// <summary>
        /// 重绘事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnUpdate(object sender, PaintEventArgs e)
        {
            if (update != null)
            {
                update(this, e.ClipRectangle, e.Graphics);
            }
        }

        /// <summary>
        /// 鼠标事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnMouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (mouseLeftClick != null)
                {
                    mouseLeftClick(this, e);
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (mouseRightClick != null)
                {
                    mouseRightClick(this, e);
                }
            }
        }

        public void OnMouseMove(object sender, MouseEventArgs e)
        {
            if (mouseMove != null)
            {
                mouseMove(this, e);
            }
        }

        //添加游戏组件
        public T AddComponent<T>() where T : IComponents, new()
        {
            //SpriteRender
            //根据泛型创建相应的游戏组件
            T component = new T
            {
                Owner = this
            };

            this.Components.Add(component);

            //将组件的方法注册给游戏对象的事件
            this.update += component.OnUpdate;
            this.mouseLeftClick += component.OnMouseClickLeft;
            this.mouseRightClick += component.OnMouseClickRight;
            this.mouseMove += component.OnMouseMove;

            return component;
        }

        //移除组件 
        public void RemoveComponent<T>() where T : class,IComponents, new()
        {
            this.Components.Remove(Components.FirstOrDefault(o => o.GetType() == typeof(T)) as T);
        }

        /// <summary>
        /// 获取对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T GetGameObject<T>() where T : class
        {
            return Components.FirstOrDefault(o => o.GetType() == typeof(T)) as T;
        }

    }
}
