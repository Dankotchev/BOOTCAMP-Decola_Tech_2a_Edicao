namespace Construtores_Propriedades_Delegates_e_Eventos_em_NET.Models
{
    public class Log
    {
        private static Log contLog;
        public string PropriedadeLog { get; set; }
        private Log()
        {

        }
        public static Log Instancia()
        {
            if (contLog == null)
            {
                contLog = new Log();
            }
            return contLog;
        }
    }
}