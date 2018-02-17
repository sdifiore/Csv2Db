using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Csv2Db.Models;

namespace Csv2Db
{
    public static class Read
    {
        public static void Vendedor()
        {
            var db = new EntityContext();
            var vendedores = db.Vendedores;
            string[] lines = File.ReadAllLines(Files.vendedor, Encoding.Default);
            bool header = true;

            foreach (string line in lines)
            {
                if (header) header = false;
                else
                {
                    var reg = line.Split(';');

                    Vendedor vendedor = new Vendedor();
                    vendedor.Representante = reg[0];
                    string comissao = reg[1].Substring(0, reg[1].Length - 1);
                    vendedor.PctComissao = float.Parse(comissao) / 100;
                    vendedor.Cidade = reg[2];
                    vendedor.Estado = reg[3];

                    vendedores.Add(vendedor);
                }
            }

            db.SaveChanges();
        }

        public static void FatHistorico()
        {
            string[] lines = File.ReadAllLines(Files.cuboTeste, Encoding.Default);

        }

        
    }
}
