using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BACK.Entidades
{
    public interface InterfazEntidades
    {
        int Id { get; }
        bool Activo { get; }

        void CargarInfoDeDict(Dictionary<string, string> dict);

        Dictionary<string, string> DevolverInfoEnDict();

        void CrearEntradaEnLaTabla(ConexionConTabla cnH);
    }
}
