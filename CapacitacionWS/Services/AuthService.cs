using System;
using System.ServiceModel;

namespace CapacitacionWS.Services
{
    public class AuthService
    {
        private ePower.ewsmSoapClient _conexion;
        public int CurrentConnectionId { get; private set; }
        public bool IsAuthenticated => CurrentConnectionId > 0;

        public AuthService()
        {
            _conexion = new ePower.ewsmSoapClient();
        }

        public (bool Success, string Message) Logout()
        {
            if (!IsAuthenticated)
                return (false, "No hay sesión activa");

            try
            {
                bool result = _conexion.doLogout(CurrentConnectionId);
                if (result)
                {
                    CurrentConnectionId = 0;
                    return (true, "Sesión cerrada correctamente");
                }
                return (false, "No se pudo cerrar la sesión");
            }
            catch (Exception ex)
            {
                return (false, $"Error al cerrar sesión: {ex.Message}");
            }
        }
}

        public bool Logout()
        {
            if (IsAuthenticated)
            {
                bool result = _conexion.doLogout(CurrentConnectionId);
                if (result) CurrentConnectionId = 0;
                return result;
            }
            return false;
        }
    }
}