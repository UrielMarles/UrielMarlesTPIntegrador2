using BACK;
using BACK.Entidades;
using System.Data.SqlClient;

namespace TESTING
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ConexionConTabla conec = new ConexionConTabla("Data Source=DESKTOP-FT8QR65\\NEWSERVER; Initial Catalog=RENT-A-TRONICDB;Integrated Security=True");

            }
            catch (Exception ex)
            {
                Funciones.imprimirErrores(ex);
            }

        }


    }
}

//PRUEBA CREADO ANIMATRONICO:

//ConexionConTabla.ImprimirListaDict(conec.LecturaCompleta("SELECT * FROM animatronicos"));

//AnimatronicoEntidad Freddy = new AnimatronicoEntidad(-1, "Golden Freddy","Es fachero", true, 1);

//Freddy.CrearEntradaEnLaTabla(conec);

//ConexionConTabla.ImprimirListaDict(conec.LecturaCompleta("SELECT * FROM animatronicos"));

// PRUEBA CREADO FIESTA:

//FiestaEntidad fiesta = new FiestaEntidad("mi casa", new List<int> { 1, 2, 3 }, -1, true, 1500, "Juan", "+54 9 11 4194 3821", "correo@hotmail.com", new DateTime(2023, 12, 1));

//fiesta.CrearEntradaEnLaTabla(conec);

//ConexionConTabla.ImprimirListaDict(conec.LecturaCompleta("SELECT * FROM fiestas"));
//ConexionConTabla.ImprimirListaDict(conec.LecturaCompleta("SELECT * FROM animatronicosFiesta"));