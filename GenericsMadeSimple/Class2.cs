using GenericsMadeSimple1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsMadeSimple
{
    class Class2<T, U>
    {
       public void GetT(T t1) { }
       public void GetT(U u1) { }

        public void GetT(U u1, T t) { }
    }


    class PlayGround
    {
        void SandBox()
        {
            Class2<int, string> class2a = new Class2<int, string>();
           
            
            Class2<string, int> clas2b1 = new Class2<string, int>();

            class2a.GetT(5);
            class2a.GetT("");
            //class2a.GetT(5, 30);
            class2a.GetT("", 64);

        }
    }
}
