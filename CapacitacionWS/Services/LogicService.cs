using System;
using System.Collections.Generic;
using System.Data;

namespace CapacitacionWS.Services
{
    public class LogicService
    {
        private ePower.ewsmSoapClient conexion;
        private int idconection;
        private int appid;
        private int tipoDocumento;
        private int consulta;

        public LogicService()
        {
            conexion = new ePower.ewsmSoapClient();
        }

        public bool Login(string usuario, string password)
        {
            try
            {
                idconection = conexion.doLogin(usuario, password, "eAccess");
                return true;
            }
            catch (Exception ex)
            {
                // Log del error si es necesario
                return false;
            }
        }

        public List<Documento> ObtenerDocumentos(int consultaId)
        {
            // Mover aquí tu lógica de obtención de documentos
            var resultados = new List<Documento>();
            // ... (tu código actual de button4_Click)
            return resultados;
        }

        // Continúa moviendo todos tus métodos de negocio aquí
    }

    public class Documento
    {
        public int DocId { get; set; }
        public string Nombre { get; set; }
        // Agrega otras propiedades según necesites
    }
}