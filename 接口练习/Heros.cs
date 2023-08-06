using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口练习
{
    public class Heros
    {
        public List<IComponent> list = new List<IComponent>();

        public Heros()
        {
        }

        public T AddComponent<T>() where T : IComponent, new()
        {
            T com = new T();
            list.Add(com);
            return com;
        }

        public void RemoveComponent<T>() where T : IComponent, new()
        {
            list.Remove(new T());
        }

        public T GetComponent<T>() where T : class
        {
            return list.FirstOrDefault(o => o.GetType() == typeof(T)) as T;
        }
    }
}
