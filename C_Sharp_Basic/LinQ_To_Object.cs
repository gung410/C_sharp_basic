using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Basic
{
    public  class LinQ_To_Object
    {
       
       public void lin()
        {
            Object[] Mang = new string[4] { "hung", "ha", "hiu", "dsv" };
            string[] Mang2 = new string[4] { "hung", "as", "hiu2", "sup" };


            //generic và  delegate
            //lambda
            Func<object, bool> filler = x => x =="hung"; //lambda 




            //linq
            IEnumerable<object> ten = Mang.Take(4).Where(filler);
            Object_Delegate od = new Object_Delegate();
            var ha = od.Lop1();
            var lopnew = ha.Take(4);

            foreach(var item in ten)
            {
                Console.WriteLine("{0}", item);
            }
            foreach (var item in lopnew)
            {
                Console.WriteLine("{0}", item);
            }
      
        }
     
        public void Exxx()
        {

            string s = "chao hung ";

            int i = s.wordcout();
        }
    }
}
