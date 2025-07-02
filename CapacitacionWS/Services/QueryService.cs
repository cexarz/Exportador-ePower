using System;
using System.Collections.Generic;
using System.Linq;

namespace CapacitacionWS.Services
{
    public class QueryService
    {
        private readonly ePower.ewsmSoapClient _conexion;
        private readonly int _connectionId;

        public QueryService(int connectionId)
        {
            _conexion = new ePower.ewsmSoapClient();
            _connectionId = connectionId;
        }

        public List<AppInfo> GetApplications()
        {
            try
            {
                var aplicaciones = _conexion.getAppList(_connectionId);
                return aplicaciones.Select(a => new AppInfo
                {
                    Id = a.AppId,
                    Name = a.AppName,
                    Description = a.AppDsc
                }).ToList();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error obteniendo aplicaciones", ex);
            }
        }

        // Similar para GetDocumentTypes() y GetQueries()
    }
}