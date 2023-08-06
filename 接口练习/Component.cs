using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口练习
{
    public class Component : IComponent
    {
        public virtual void Say()
        {
            Console.WriteLine("会说话");
        }
    }
}
