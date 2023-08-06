using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 游戏框架.Component;
using 游戏框架.Properties;

namespace 游戏框架.Object
{
    public class BackgroundRender : SpriteRender
    {
        public BackgroundRender()
        {
            SpriteImage = Resources.gamebackdrop;
            ZIndex = 0;
        }

        public override void OnUpdate(GameObject go, System.Drawing.Rectangle rec, System.Drawing.Graphics g)
        {
            base.OnUpdate(go, rec, g);
            Task.Add(new SpriteTask()
            {
                SourceImage = SpriteImage,
                DesRectangle = new System.Drawing.Rectangle(0, 0, 320, 480),
                SrcRectangle = new System.Drawing.Rectangle(0, 0, 320, 480),
                ZIndex = ZIndex
            });
        }
    }
}
