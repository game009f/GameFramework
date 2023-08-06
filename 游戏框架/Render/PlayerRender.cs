using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 游戏框架.Common;
using 游戏框架.Component;
using 游戏框架.Properties;

namespace 游戏框架.Object
{
    /// <summary>
    /// 玩家
    /// </summary>
    public class PlayerRender : SpriteRender
    {
        //尺寸
        public static int EnWidth = 48;
        public static int EnHeight = 32;

        public PlayerRender()
        {
            SpriteImage = Resources.playericon;
            ZIndex = 1;
        }

        public override void OnUpdate(GameObject go, System.Drawing.Rectangle rec, System.Drawing.Graphics g)
        {
            base.OnUpdate(go, rec, g);
            int x = Owner.Owner.MousePoint.X - 24;
            int y = Owner.Owner.MousePoint.Y - 16;
            go.TransForm.Position = new Position(x,y);
            if (x < 0)
                x = 0;
            else if (x > 266)
                x = 266;
            if (y < 0)
                y = 0;
            else if (y > 410)
                y = 410;

            Task.Add(new SpriteTask()
            {
                SourceImage = SpriteImage,
                DesRectangle = new System.Drawing.Rectangle(x, y, EnWidth, EnHeight),
                SrcRectangle = new System.Drawing.Rectangle(0, 0, EnWidth, EnHeight),
                ZIndex = ZIndex
            });

            
        }

    }
}
