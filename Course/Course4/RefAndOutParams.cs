using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course4
{
    internal class RefAndOutParams
    {
        //Ref - referência,  colocando-se o ref na variável de chamada e no seu parametro
        //O parâmetro se tornará uma refêrencia ao original
        public static void Triple(ref int x)
        {
            x = x * 3;
        }

        //Agora com o Out
        public static void OutTriple(int origin, out int result)
        {
            result = origin * 3;
        }
    }
}
