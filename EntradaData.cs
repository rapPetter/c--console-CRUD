using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DEVinDocuments
{
    public static class EntradaData
    {
        public static string EntradaConverterParaAnoData()
        {
            ConsolesTextoUsuario.ConsoleWriteLineAnoExpiraContrato();
            string Ano = Console.ReadLine();
            try
            {
                if (Ano.Length == 4)
                {
                    return Ano;
                }
                else
                {
                    return EntradaConverterParaAnoData();
                }
            }
            catch
            {
                return EntradaConverterParaAnoData();
            }
        }
        public static string EntradaConverterParaMesData()
        {
            ConsolesTextoUsuario.ConsoleWriteLineMesExpiraContrato();
            string Mes = Console.ReadLine();
            try
            {
                if (Mes.Length <= 2 && Convert.ToDecimal(Mes) <= 12)
                {
                    return Mes;
                }
                else
                {
                    return EntradaConverterParaMesData();
                }
            }
            catch
            {
                return EntradaConverterParaMesData();
            }
        }
        public static string EntradaConverterParaDiaData()
        {
            ConsolesTextoUsuario.ConsoleWriteLineDiaExpiraContrato();
            string Dia = Console.ReadLine();
            try
            {
                if (Dia.Length <= 2 && Convert.ToDecimal(Dia) <= 31)
                {
                    return Dia;
                }
                else
                {
                    return EntradaConverterParaDiaData();
                }
            }
            catch
            {
                return EntradaConverterParaDiaData();
            }
        }
        public static DateTime PegarData()
        {
            string dia = EntradaConverterParaDiaData();
            string mes = EntradaConverterParaMesData();
            string ano = EntradaConverterParaAnoData();
            string juntar = dia + "/" + mes + "/" + ano;
            try
            {
                return DateTime.Parse(juntar);
            }
            catch
            {
                ConsolesTextoUsuario.ConsoleMessageErroDataNaoExiste();
                return PegarData();
            }
        }
    }
}