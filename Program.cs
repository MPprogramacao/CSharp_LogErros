using System;


namespace CSharp_LogErros
{
    class Program
    {
        static void Main(string[] args)
        {
            RegistraLog.Log(String.Format($"{"Log criado em "} : {DateTime.Now}"), "ArquivoLog");
            RegistraLog.Log("Registro de log de auditoria");

           Console.WriteLine("Log criado e registrado com sucesso");
           Console.ReadLine();
        }
    }
}
