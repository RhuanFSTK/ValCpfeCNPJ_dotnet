using System;

namespace ValCpfeCNPJ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CPFCNPJ.IMain checkCFPCNPJ = new CPFCNPJ.Main();
            var resultCNPJ = checkCFPCNPJ.IsValidCPFCNPJ("CNPJ");

            Console.WriteLine(resultCNPJ);

            var resultCPF = checkCFPCNPJ.IsValidCPFCNPJ("CPF");

            Console.WriteLine(resultCNPJ);
        }
    }
}
