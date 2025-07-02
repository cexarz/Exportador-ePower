using System;
using System.IO;

namespace CapacitacionWS.Services
{
    public class DocumentService
    {
        public (int Downloaded, int Failed) DownloadDocuments(int connectionId, int appId,
            int docType, int queryId, int documentId, string savePath)
        {
            int downloaded = 0, failed = 0;

            try
            {
                var conexion = new ePower.ewsmSoapClient();
                var documento = conexion.getFullDocument(connectionId, appId, docType, queryId, documentId);

                // Lógica de descarga...

                return (downloaded, failed);
            }
            catch (Exception ex)
            {
                FileLogger.LogError(ex); // Implementar este método
                return (downloaded, failed);
            }
        }
    }
}