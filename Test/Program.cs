using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LANS.SystemsBiology.Assembly.SBML.ExportServices;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = LANS.SystemsBiology.Assembly.SBML.Level2.XmlFile.Load(@"F:\1.13.RegPrecise_network\FBA\xcam314565\19.0\data\metabolic-reactions.xml");
            var dd = file.Model.listOfReactions.First();
            double l = dd.LowerBound;
            double u = dd.UpperBound;
            var rxns = LANS.SystemsBiology.Assembly.SBML.ExportServices.KEGG.GetReactions(file,true);
            Console.Read();
        }
    }
}
