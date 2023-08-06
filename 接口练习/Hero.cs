using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口练习
{
    public class Hero : Component
    {
        public string Name { get; set; }

        public override void Say()
        {
            Console.WriteLine(this.Name + "会说话");
        }
    }
}
