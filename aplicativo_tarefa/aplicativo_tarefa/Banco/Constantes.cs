using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace aplicativo_tarefa.Banco
{
    public class Constantes
    {
        public const string NomeDoArquivo = "AppTarefa.db3";

        public static string CaminhoDoBanco
        {
            get
            {
                var caminhoBase = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                return Path.Combine(caminhoBase, NomeDoArquivo);
            }
        }
    }
}
