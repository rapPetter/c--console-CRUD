using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DEVinDocuments
{
    public static class EntradaDecimal
    {
        public static decimal EntradaConverterParaDecimalValorTotal()
        {
            ConsolesTextoUsuario.ConsoleWriteLineAmountInvoice();
            string entrada = Console.ReadLine();
            try
            {
                return Convert.ToDecimal(entrada);
            }
            catch
            {
                ConsolesTextoUsuario.ConsoleMessageInsertNumber();
                return EntradaConverterParaDecimalValorTotal();
            }
        }
        public static decimal EntradaConverterParaDecimalValorTotalDoImposto()
        {
            ConsolesTextoUsuario.ConsoleWriteLineValorTotalDoImposto();
            string entrada = Console.ReadLine();
            try
            {
                return Convert.ToDecimal(entrada);
            }
            catch
            {
                ConsolesTextoUsuario.ConsoleMessageInsertNumber();
                return EntradaConverterParaDecimalValorTotalDoImposto();
            }
        }
    }
}