using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LED_EPL.Class
{
    class Conexao
    {

        /// <summary>
        /// ATENÇÃO!!! PRIMEIRA região é os processos de conexão da 06
        /// </summary>

        #region
       
        private static string _filial = "06";
        public static string filial
        {
            get { return _filial; }
            set { _filial = value; }
        }

        private static string _ROTA = "";
        public static string ROTA
        {
            get { return _ROTA; }
            set { _ROTA = value; }
        }

        private static string _SN = "";
        public static string SN
        {
            get { return _SN; }
            set { _SN = value; }
        }

        private static string _API = "";
        public static string API
        {
            get { return _API; }
            set { _API = value; }
        }

        private static string _TypeScan = "";
        public static string TypeScan
        {
            get { return _TypeScan; }
            set { _TypeScan = value; }
        }

        private static string _PrintWay = "";
        public static string PrintWay
        {
            get { return _PrintWay; }
            set { _PrintWay = value; }
        }

        #endregion
    }
}
