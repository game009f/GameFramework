using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class Form1 : Form
    {
        Random r = new Random();

        GameSence gs;//场景
        public Form1()
        {
            InitializeComponent();
            //防止闪屏
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer
                      | ControlStyles.ResizeRedraw
                      | ControlStyles.Selectable
                      | ControlStyles.AllPaintingInWmPaint
                      | ControlStyles.UserPaint
                      | ControlStyles.SupportsTransparentBackColor,
                    true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Cursor.Hide();
            InitGame();
        }


        private void InitGame()
        {
            //创建场景对象
            gs = new GameSence(this);


            //添加背景
            GameObject bk = new GameObject
            {
                Owner = gs,
                GType = GType.Background
            };
            bk.AddComponent<BackgroundRender>();
            gs.AddGameObject(bk);

            //添加玩家
            GameObject play = new GameObject
            {
                Owner = gs,
                GType = GType.Player
            };
            play.AddComponent<PlayerRender>();
            play.AddComponent<ShootingComponent>();
            gs.AddGameObject(play);


        }

    }
}
