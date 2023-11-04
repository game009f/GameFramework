using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 游戏框架.Common;
using 游戏框架.Object;

namespace 游戏框架.Component
{
    public class ShootingComponent : Component
    {
        readonly Random r = new Random();

        public void Shooting()
        {
            GameObject bullet = new GameObject
            {
                GType = GType.Bullet
            };
            bullet.TransForm.Position = Owner.TransForm.Position;
            bullet.AddComponent<BulletRender>();
            bullet.GetGameObject<BulletRender>().EnemyType = r.Next(0, 6);
            
            
            Owner.Owner.AddGameObject(bullet);
        }


        public override void OnMouseClickLeft(GameObject go, System.Windows.Forms.MouseEventArgs e)
        {
            Shooting();
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
