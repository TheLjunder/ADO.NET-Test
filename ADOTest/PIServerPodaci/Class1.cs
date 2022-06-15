using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIServerPodaci
{
    public static class Class1
    {
        public static List<Prijava> GetPrijava()
        {
            using (var konteks = new PI2221_DBEntities())
            {
                var upit = from u in konteks.Prijavas
                           select u;
                return upit.ToList();
            }

        }
    }
}
