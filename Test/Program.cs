using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LANS.SystemsBiology.Assembly.SBML.ExportServices;
using Microsoft.VisualBasic;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            var ddd = new Biopax.MetaCyc.Biopax.Level3.File { Owl = new Biopax.MetaCyc.Biopax.Level3.Elements.owlOntology()};

            ddd.SaveAsXml(@"X:\fffff.xml");

            var owl =    Biopax.MetaCyc.Biopax.Level3.File.LoadDoc(@"F:\SBML\data\Escherichia_coli.owl");




            var file = LANS.SystemsBiology.Assembly.SBML.Level2.XmlFile.Load(@"F:\1.13.RegPrecise_network\FBA\xcam314565\19.0\data\metabolic-reactions.xml");
            var dd = file.Model.listOfReactions.First();
            double l = dd.LowerBound;
            double u = dd.UpperBound;
            var rxns = LANS.SystemsBiology.Assembly.SBML.ExportServices.KEGG.GetReactions(file,true);
            Console.Read();
        }
    }
}
