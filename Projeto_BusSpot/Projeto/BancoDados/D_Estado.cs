using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;



namespace BancoDados
{
    internal class D_Estado
    {

        public int _ID_ESTADO { get; private set; }
        public string _Estado { get; private set; }
        public string _sigla { get; private set; }
        public string Buscar { get; private set; }



        public D_Estado()
        {
        }

        public D_Estado(int iD_ESTADO, string estado, string sigla, string buscar)
        {
            _ID_ESTADO = iD_ESTADO;
            _Estado = estado;
            _sigla = sigla;
            Buscar = buscar;
        }


    }

    
}
