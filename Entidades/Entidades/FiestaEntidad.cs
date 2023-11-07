using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BACK.Entidades
{
    public class FiestaEntidad : InterfazEntidades
    {
        private List<int> idsAnimatronicos;
        private int id;
        private bool activo;
        private int precio;
        private string lugar;
        private string nombreCliente;
        private string telefonoCliente;
        private string correoCliente;
        private DateTime fecha;

        public bool Activo { get { return activo; } }
        public int Id { get { return Id; } }

        public FiestaEntidad(string lugar, List<int> animatronicosId,int id,bool activo,int precio, string nombreCliente,string telefonoCliente,string correoCliente,DateTime fechaFiesta)
        {
            this.idsAnimatronicos = animatronicosId;
            this.id = id;
            this.activo = activo;
            this.lugar = lugar;
            this.precio = precio;
            this.nombreCliente = nombreCliente;
            this.telefonoCliente = telefonoCliente;
            this.correoCliente = correoCliente;
            this.fecha = fechaFiesta;
            ValidarTamanio();
        }

        public FiestaEntidad(Dictionary<string, string> dict)
        {
            CargarInfoDeDict(dict);
            ValidarTamanio();
        }

        public void CargarInfoDeDict(Dictionary<string, string> dict)
        {
            this.idsAnimatronicos = Funciones.StringToIntList(dict["idsAnimatronicos"]);
            this.lugar = dict["lugar"];
            this.id = int.Parse(dict["id"]);
            this.activo = dict["activo"] == "1";
            this.precio = int.Parse(dict["precio"]);
            this.nombreCliente = dict["nombreCliente"];
            this.telefonoCliente = dict["telefonoCliente"];
            this.correoCliente = dict["correoCliente"];
            this.fecha = DateTime.ParseExact(dict["fecha"], "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None);
        }

        public Dictionary<string, string> DevolverInfoEnDict()
        {
            return new Dictionary<string, string>
            {
                ["idsAnimatronicos"] = Funciones.IntListToString(this.idsAnimatronicos),
                ["id"] = this.id.ToString(),
                ["lugar"] = this.lugar,
                ["activo"] = this.activo ? "1" : "0",
                ["precio"] = this.precio.ToString(),
                ["nombreCliente"] = this.nombreCliente,
                ["telefonoCliente"] = this.telefonoCliente.ToString(),
                ["correoCliente"] = this.correoCliente,
                ["fecha"] = this.fecha.ToString("yyyy-MM-dd")
            };
       
        }

        public void CrearEntradaEnLaTabla(ConexionConTabla cnH)
        {
            Dictionary<string, string> dict = DevolverInfoEnDict();
            dict.Remove("idsAnimatronicos");
            cnH.cargarDiccionarioATabla(dict, "fiestas");

            StringBuilder sb = new StringBuilder("DECLARE @MaximoID INT; SELECT @MaximoID = MAX(id) FROM fiestas;");
            foreach (int id in this.idsAnimatronicos)
            {
                sb.Append("INSERT INTO  animatronicosFiesta (fiestaId,animatronicoId,fechaFiesta) VALUES (@MaximoId, ");
                sb.Append(id);
                sb.Append(", '");
                sb.Append(dict["fecha"]);
                sb.Append("');");   
            }
            Console.WriteLine(sb.ToString());
            cnH.Ejecutar(sb.ToString());
        }

        private void ValidarTamanio()
        {
            if (precio != 1000 && precio!=1500 && precio != 2000) 
            {
                throw new ExcepcionConstruyendoEntidad("Precio de fiesta invalido");
            }
        }

    }
}
