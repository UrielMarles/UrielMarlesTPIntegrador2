
namespace BACK.Entidades
{
    public class AnimatronicoEntidad : Funciones
    {
        private int id;
        private string nombre;
        private string descripcion;
        private bool activo;
        private int cantidadUsos;

        public override int Id { get { return id; } }
        public string Nombre { get { return nombre; } }
        public override bool Activo { get { return activo; } }
        public int CantidadUsos { get {  return cantidadUsos; } }

        public string Descripcion {  get { return descripcion; } }  
        public AnimatronicoEntidad(Dictionary<string, string> dict)
        {
            this.CargarInfoDeDict(dict);
        }

        public AnimatronicoEntidad(int id,string nombre,string descripcion,bool activo,int cantidadUsos)
        {
            this.id = id;
            this.nombre = nombre;
            this.activo = activo;   
            this.cantidadUsos = cantidadUsos;
            this.descripcion = descripcion;
        }

        public override void CargarInfoDeDict(Dictionary<string, string> dict)
        {
            try
            {
                this.id = int.Parse(dict["id"]);
                this.nombre = dict["nombre"];
                if(dict["activo"]!= "1" && dict["activo"] != "0")
                {
                    throw new ExcepcionConstruyendoEntidad("valor de activo no valido");
                }
                this.activo = dict["activo"] == "1";
                this.cantidadUsos = int.Parse(dict["cantidadUsos"]);
            }
            catch (Exception e)
            {
                throw new ExcepcionConstruyendoEntidad("Error creando la entidad de un animatronico", e);
            }
        }

        public override Dictionary<string, string> DevolverInfoEnDict()
        {
            return new Dictionary<string, string>
            {
                {"id",this.id.ToString()},
                {"nombre",this.nombre},
                {"activo",this.activo ? "1" : "0"},
                {"cantidadUsos",this.cantidadUsos.ToString()}
            };
        }

        public override void CrearEntradaEnLaTabla(ConexionConTabla cnH)
        {
            cnH.cargarDiccionarioATabla(this.DevolverInfoEnDict(), "animatronicos");
        }


    }
}
