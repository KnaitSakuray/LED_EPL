using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LED_EPL.Class
{
    class Global
    {
        private static string _Linha = "";
        public static string Linha
        {
            get { return _Linha; }
            set { _Linha = value; }
        }
        private static string _statusParada = "";
        public static string statusParada
        {
            get { return _statusParada; }
            set { _statusParada = value; }
        }

        private static int _Id_User = 0;
        public static int Id_User
        {
            get { return _Id_User; }
            set { _Id_User = value; }
        }

        private static string _Nome = "";
        public static string Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }

        private static string _Setor = "";
        public static string Setor
        {
            get { return _Setor; }
            set { _Setor = value; }
        }

        private static string _Funcao = "";
        public static string Funcao
        {
            get { return _Funcao; }
            set { _Funcao = value; }
        }

        private static int _Status_User = 0;
        public static int Status_User
        {
            get { return _Status_User; }
            set { _Status_User = value; }
        }

        private static int _Producao = 0;
        public static int Producao
        {
            get { return _Producao; }
            set { _Producao = value; }
        }

        private static int _Ckd = 0;
        public static int Ckd
        {
            get { return _Ckd; }
            set { _Ckd = value; }
        }

        private static string _CkdInfo = "";
        public static string CkdInfo
        {
            get { return _CkdInfo; }
            set { _CkdInfo = value; }
        }

        private static int _Caixote = 0;
        public static int Caixote
        {
            get { return _Caixote; }
            set { _Caixote = value; }
        }
        private static int _Adm = 0;
        public static int Adm
        {
            get { return _Adm; }
            set { _Adm = value; }
        }
    }
}
