using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 游戏框架.Common
{
    /// <summary>
    /// 游戏对象的变换组件
    /// </summary>
    public class TransForm
    {
        /// <summary>
        /// 坐标
        /// </summary>
        public Position Position { get; set; }

        /// <summary>
        /// 缩放正常是1
        /// </summary>
        public Scale Scale { get; set; }

        /// <summary>
        /// 旋转角度
        /// </summary>
        public double Rotation { get; set; }
    }

    /// <summary>
    /// 坐标类
    /// </summary>
    public struct Position
    {
        public int _x;
        public int _y;
        public Position(int x, int y)
        {
            this._x = x;
            this._y = y;
        }
    }

    /// <summary>
    /// XY轴缩放比例
    /// </summary>
    public struct Scale
    {
        public double _x;
        public double _y;
        public Scale(double x, double y)
        {
            this._x = x;
            this._y = y;
        }
    }
}
