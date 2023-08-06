using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 游戏框架.Component;
using 游戏框架.Properties;

namespace 游戏框架.Object
{
    public class BulletRender : SpriteRender
    {
        public static int EnWidth = 8;
        public static int EnHeight = 16;

        /// <summary>
        ///类型
        /// </summary>
        public int EnemyType { get; set; }

        public BulletRender()
        {
            SpriteImage = Resources.playermissile;
            ZIndex = 2;
        }

        /// <summary>
        /// 获取目标图片区域
        /// </summary>
        /// <param name="go">获取的对象</param>
        /// <param name="type">类型0-3</param>
        /// <param name="index">索引0-3</param>
        /// <returns></returns>
        private System.Drawing.Rectangle GetSrcRectangle(GameObject go, int IndexX, int Indexy)
        {
            return new System.Drawing.Rectangle(
                IndexX * EnWidth, Indexy * EnHeight, EnWidth, EnHeight
            );
        }

        public override void OnUpdate(GameObject go, System.Drawing.Rectangle rec, System.Drawing.Graphics g)
        {
            base.OnUpdate(go, rec, g);
            go.TransForm.Position = new Common.Position(go.TransForm.Position._x, go.TransForm.Position._y - EnemyType - 5);

            Task.Add(new SpriteTask()
            {
                SourceImage = SpriteImage,
                DesRectangle = new System.Drawing.Rectangle(go.TransForm.Position._x, go.TransForm.Position._y, EnWidth, EnHeight),
                SrcRectangle = GetSrcRectangle(go, 0, EnemyType),
                ZIndex = ZIndex
            });
            

            if (go.TransForm.Position._y < -20)
                Owner.Owner.RemoveGameObject(go);
        }
    }
}
