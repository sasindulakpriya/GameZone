using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace pcUse
{
    class beanLinked
    {
        static LinkedList<Thread> linked = new LinkedList<Thread>();

        public void setLinkFirst(Thread thread)
        {
            linked.AddFirst(thread);
        }
        public Thread getLinkFirst()
        {
            return linked.First();
        }

        public Boolean isEmpty()
        {

            if (linked.Count() == 0)
            {
                return true;

            }
            else
            {
                return false;
            }
            return false;
        }

    }
}
