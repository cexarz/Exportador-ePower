using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.ServiceModel;
using System.Web.Services.Protocols;





namespace CapacitacionWS
{
    public partial class Form1 : Form
    {
        ePower.ewsmSoapClient conexion = null;// instancia el entry point.
        int idconection = 0;//id de conexion de ePower.
        int appid = 0; //id de aplicación de ePower.
        int tipoDocumento = 0;//id del tipo de documento seleccionado.
        int consulta = 0;//Id de la consulta seleccionada.
        int DocumentoId = 0;//id del documento a procesar
        int idconeccionSecurity = 0; //id de conexión con el eSecurity

        public Form1()
        {
            InitializeComponent();

            inicializaconexion();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Método para realizar conexión en ePower, retorna id conexión que es un entero.
                idconection = conexion.doLogin(txtUser.Text, txtPassword.Text, "eAccess");
                MessageBox.Show("Id Asignado " + idconection, "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Imposible realizar loguin " + ex.ToString(), "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void inicializaconexion()
        {
            try
            {
                //instancia el entry point para comunicación con el WS de epower 
                conexion = new ePower.ewsmSoapClient();
            }
            catch (Exception e)
            {
                MessageBox.Show("Imposible establecer la conexion" + e.ToString(), "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            try
            {
                if (idconection > 0)
                {
                    // Método para realizar la desconexión, retorna boolean
                    if (conexion.doLogout(idconection))
                    {
                        // Limpiar todos los DataGridView
                        dtgAplicaciones.Rows.Clear();
                        dtgTipoDocumental.Rows.Clear();
                        dtgConsultas.Rows.Clear();
                        dtgResultados.Rows.Clear();

                        // Reiniciar todas las variables de sesión
                        idconection = 0;
                        appid = 0;
                        tipoDocumento = 0;
                        consulta = 0;
                        DocumentoId = 0;

                        // Limpiar otros controles (opcional)
                        txtUser.Text = "";
                        txtPassword.Text = "";
                        

                        MessageBox.Show("Desconexión Exitosa", "Mensaje",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo realizar la desconexión", "Mensaje",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró una conexión activa", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Imposible realizar logout: " + ex.ToString(), "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            ePower.App[] Aplic = null;//objeto que contiene lista de aplicaciones de ePower
            try
            {
                //Método que retorna la lista de aplicaciones en ePower, retorna objeto de tipo App[]
                Aplic = conexion.getAppList(idconection);
                //funcionalidad para limpiar el datagrid y añadir un row por cada registro encontrado
                dtgAplicaciones.Rows.Clear();
                for (int i = 0; i < Aplic.Length; i++)
                {
                    DataGridViewRow dt = new DataGridViewRow();
                    dt.CreateCells(dtgAplicaciones);
                    dt.Cells[0].Value = Aplic[i].AppId;
                    dt.Cells[1].Value = Aplic[i].AppName;
                    dt.Cells[2].Value = Aplic[i].AppDsc;
                    dtgAplicaciones.Rows.Insert(i, dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Imposible obtener la lista de aplicaciones " + ex.ToString(), "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ePower.DocType[] TipoDoc = null;//contenedor para el tipo documental
                appid = int.Parse(dtgAplicaciones.CurrentCell.Value.ToString());//obtiene el appid del datagrid
                //Método que obtiene la lista de tipos documentales asociada a una aplicación.
                TipoDoc = conexion.getDocTypeList(idconection, appid);
                //funcionalidad para pintar el datagrid
                dtgTipoDocumental.Rows.Clear();
                for (int i = 0; i < TipoDoc.Length; i++)
                {
                    DataGridViewRow dt = new DataGridViewRow();
                    dt.CreateCells(dtgTipoDocumental);
                    dt.Cells[0].Value = TipoDoc[i].DocTypeId;
                    dt.Cells[1].Value = TipoDoc[i].DocTypeName;
                    dt.Cells[2].Value = TipoDoc[i].DocTypeDsc;
                    dtgTipoDocumental.Rows.Insert(i, dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Imposible obtener la lista de Documentos " + ex.ToString(), "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ePower.Query[] ListaQuerys = null;//objeto ePower que contiene las consultas 
                tipoDocumento = int.Parse(dtgTipoDocumental.CurrentCell.Value.ToString());//obtiene el id del tipo de documento seleccionado
                //Método utilizado para obtener la lista de consultas.
                ListaQuerys = conexion.getQueryList(idconection, appid, tipoDocumento);
                //Funcionalidad para pintar el grid
                dtgConsultas.Rows.Clear();
                for (int i = 0; i < ListaQuerys.Length; i++)
                {
                    DataGridViewRow dt = new DataGridViewRow();
                    dt.CreateCells(dtgConsultas);
                    dt.Cells[0].Value = ListaQuerys[i].QueryId;
                    dt.Cells[1].Value = ListaQuerys[i].QueryName;
                    dt.Cells[2].Value = ListaQuerys[i].QueryDsc;
                    dtgConsultas.Rows.Insert(i, dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Imposible obtener consultas " + ex.ToString(), "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);



            }
        }
            // Variables de paginación
            private int currentPage = 0;
            private int pageSize = 500; // Tamaño de la página
            private List<ePower.DocInst> allDocs = new List<ePower.DocInst>();

            // Declarar Columnas como variable de clase
            private ePower.Column[] Columnas = null;

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                ePower.Field[] campos = null;
                ePower.QueryInst Results = null;
                consulta = int.Parse(dtgConsultas.CurrentCell.Value.ToString());

                // Ejecutar la consulta sin paginación (obtener todos los datos)
                Results = conexion.doExecuteQuery(idconection, appid, tipoDocumento, consulta, -1, null, null, null);

                // Asignar Columnas (ahora es una variable de clase)
                Columnas = Results.Column;

                // Almacenar todos los documentos
                allDocs = Results.DocInst.ToList();

                // Mostrar solo la página actual
                DisplayCurrentPage();

                // Actualizar los botones de paginación
                btnAtras.Enabled = currentPage > 0;
                btnSiguiente.Enabled = (currentPage + 1) * pageSize < allDocs.Count;
            }
            catch (TimeoutException ex)
            {
                MessageBox.Show("La consulta ha excedido el tiempo de espera. Inténtalo de nuevo o aumenta el tiempo de espera.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Imposible ejecutar consulta: " + ex.ToString(), "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayCurrentPage()
            {
                // Obtener los registros de la página actual
                var currentPageDocs = allDocs.Skip(currentPage * pageSize).Take(pageSize).ToList();

                // Configurar el DataGridView
                dtgResultados.ColumnCount = (Columnas.Count() + 1);
                dtgResultados.ColumnHeadersVisible = true;

                dtgResultados.Columns[0].Name = "DocId";
                for (int i = 0; i < Columnas.Count(); i++)
                {
                    dtgResultados.Columns[i + 1].Name = Columnas[i].Name;
                }

                // Limpiar y llenar el DataGridView
                dtgResultados.Rows.Clear();
                for (int i = 0; i < currentPageDocs.Count; i++)
                {
                    var campos = currentPageDocs[i].Field;
                    DataGridViewRow dt = new DataGridViewRow();
                    dt.CreateCells(dtgResultados);
                    dt.Cells[0].Value = currentPageDocs[i].DocId;
                    for (int j = 0; j < Columnas.Count(); j++)
                    {
                        dt.Cells[j + 1].Value = campos[j].Value;
                    }
                    dtgResultados.Rows.Insert(i, dt);
                }
            }

            private void btnSiguiente_Click(object sender, EventArgs e)
            {
                currentPage++;
                DisplayCurrentPage();
                btnAtras.Enabled = true;
                btnSiguiente.Enabled = (currentPage + 1) * pageSize < allDocs.Count;
            }

            private void btnAtras_Click(object sender, EventArgs e)
            {
                currentPage--;
                DisplayCurrentPage();
                btnAtras.Enabled = currentPage > 0;
                btnSiguiente.Enabled = true;
            }
        



        private string GenerarNombreUnico(string rutaBase, string nombreBase, string extension)
        {
            string rutaCompleta = Path.Combine(rutaBase, $"{nombreBase}{extension}");
            int contador = 1;

            // Buscar un nombre único
            while (File.Exists(rutaCompleta))
            {
                rutaCompleta = Path.Combine(rutaBase, $"{nombreBase}_{contador}{extension}");
                contador++;
            }

            return rutaCompleta;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            int totalArchivosDescargados = 0; // Contador total de archivos descargados correctamente
            int totalArchivosFallidos = 0;    // Contador total de archivos que fallaron al descargar

            try
            {
                // Verificar si hay filas seleccionadas
                if (dtgResultados.SelectedRows.Count == 0)
                {
                    MessageBox.Show("No hay filas seleccionadas.", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Verificar si la columna "DocId" existe en el DataGridView
                if (!dtgResultados.Columns.Contains("DocId"))
                {
                    MessageBox.Show("La columna 'DocId' no existe en el DataGridView.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Ruta base para el archivo CSV
                string rutaBase = Path.Combine(Properties.Settings.Default.RutaTrabajo, "Exportaciones");

                // Crear la carpeta Exportaciones si no existe
                if (!Directory.Exists(rutaBase))
                {
                    Directory.CreateDirectory(rutaBase);
                }

                // Generar un nombre único para el archivo CSV
                string rutaArchivoCsv = GenerarNombreUnico(rutaBase, "RegistrosDescargados", ".csv");

                // Crear el archivo CSV
                using (StreamWriter writer = new StreamWriter(rutaArchivoCsv, false)) // false para sobrescribir el archivo
                {
                    // Escribir los encabezados (nombres de las columnas + "Ruta")
                    var encabezados = dtgResultados.Columns
                        .Cast<DataGridViewColumn>()
                        .Select(col => col.HeaderText)
                        .ToList();
                    encabezados.Add("Ruta"); // Agregar la columna "Ruta"
                    writer.WriteLine(string.Join(",", encabezados));

                    // Dividir las filas seleccionadas en lotes de 200
                    int batchSize = 200; // Tamaño del lote
                    var selectedRows = dtgResultados.SelectedRows.Cast<DataGridViewRow>().ToList();
                    for (int i = 0; i < selectedRows.Count; i += batchSize)
                    {
                        var batch = selectedRows.Skip(i).Take(batchSize).ToList();

                        // Descargar los archivos del lote actual
                        foreach (DataGridViewRow fila in batch)
                        {
                            // Obtener el DocumentoId de la fila seleccionada
                            int documentoId = int.Parse(fila.Cells["DocId"].Value?.ToString() ?? "0");

                            // Si no se pudo obtener el DocumentoId, continuar con la siguiente fila
                            if (documentoId == 0)
                            {
                                continue;
                            }

                            // Descargar los documentos asociados al DocumentoId
                            var (archivosDescargados, archivosFallidos) = DescargarDocumentos(documentoId);

                            // Actualizar los contadores totales
                            totalArchivosDescargados += archivosDescargados;
                            totalArchivosFallidos += archivosFallidos;

                            // Solo escribir en el CSV si se descargaron archivos correctamente
                            if (archivosDescargados > 0)
                            {
                                // Obtener los valores de las celdas
                                var valores = fila.Cells
                                    .Cast<DataGridViewCell>()
                                    .Select(cell => cell.Value?.ToString() ?? "SinDato")
                                    .ToList();

                                // Agregar la ruta de descarga a la lista de valores
                                string carpetaDestino = Path.Combine("\\C:Exportaciones\\", $"Documento_{documentoId}");
                                valores.Add(carpetaDestino);

                                // Escribir los valores en el archivo CSV
                                writer.WriteLine(string.Join(",", valores));
                            }
                        }

                        // Verificar la sesión después de cada lote
                        VerificarSesion();
                    }
                }

                // Mostrar un mensaje final con el resultado de todas las descargas
                MessageBox.Show($"Descarga completada para todos los registros seleccionados:\n" +
                               $"- Archivos descargados correctamente: {totalArchivosDescargados}\n" +
                               $"- Archivos fallidos: {totalArchivosFallidos}\n" +
                               $"Archivo CSV guardado en: {rutaArchivoCsv}", "Información",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al descargar los documentos: " + ex.ToString(), "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VerificarSesion()
        {
            try
            {
                // Llamar a un método simple para verificar si la sesión sigue activa
                var aplicaciones = conexion.getAppList(idconection);

                // Si no hay excepción, la sesión sigue activa
                File.AppendAllText(@"C:\LogDescarga\log.txt", $"Sesión verificada correctamente.\n");
            }
            catch (System.Web.Services.Protocols.SoapException ex)
            {
                // Si la sesión ha expirado, reconectar
                if (ex.Message.Contains("sesión expirada") || ex.Message.Contains("sesión inválida"))
                {
                    File.AppendAllText(@"C:\LogDescarga\log.txt", $"Sesión expirada. Reconectando...\n");
                    Reconectar();
                }
                else
                {
                    // Registrar otros errores SOAP en el archivo de log
                    File.AppendAllText(@"C:\LogDescarga\log.txt", $"Error SOAP al verificar la sesión: {ex.Message}\n");
                }
            }
            catch (Exception ex)
            {
                // Registrar otros errores en el archivo de log
                File.AppendAllText(@"C:\LogDescarga\log.txt", $"Error al verificar la sesión: {ex.Message}\n");
            }
        }
        private void Reconectar()
        {
            try
            {
                // Realizar el logueo nuevamente
                idconection = conexion.doLogin(txtUser.Text, txtPassword.Text, "eAccess");
                File.AppendAllText(@"C:\LogDescarga\log.txt", $"Reconexión exitosa. Nueva sesión ID: {idconection}\n");
            }
            catch (Exception ex)
            {
                // Registrar el error en el archivo de log
                File.AppendAllText(@"C:\LogDescarga\log.txt", $"Error al reconectar: {ex.Message}\n");
                throw; // Relanzar la excepción si no se pudo reconectar
            }
        }

        private (int archivosDescargados, int archivosFallidos) DescargarDocumentos(int documentoId)
        {
            int archivosDescargados = 0; // Contador de archivos descargados correctamente
            int archivosFallidos = 0;    // Contador de archivos que fallaron al descargar

            // Ruta del archivo de log en C:\LogDescarga
            string rutaLog = @"C:\LogDescarga\log.txt";

            try
            {
                // Crear la carpeta LogDescarga si no existe
                if (!Directory.Exists(@"C:\LogDescarga"))
                {
                    Directory.CreateDirectory(@"C:\LogDescarga");
                }

                ePower.refInfo info = null;
                ePower.Collection Documento;

                // Obtener la información del documento desde el Web Service
                Documento = conexion.getFullDocument(idconection, appid, tipoDocumento, consulta, documentoId);

                // Verificar si el documento tiene referencias (archivos asociados)
                if (Documento.References.Length == 0)
                {
                    // Si no hay archivos, incrementar el contador de fallidos
                    archivosFallidos++;
                    File.AppendAllText(rutaLog, $"El documento {documentoId} no tiene archivos asociados.\n");
                    return (archivosDescargados, archivosFallidos);
                }

                // Crear la carpeta de destino en la ruta de red
                string carpetaDestino = Path.Combine(Properties.Settings.Default.RutaTrabajo, "Exportaciones", $"Documento_{documentoId}");
                if (!Directory.Exists(carpetaDestino))
                {
                    Directory.CreateDirectory(carpetaDestino);
                }

                // Descargar cada archivo asociado al documento
                foreach (var referencia in Documento.References)
                {
                    int intentos = 3; // Número de intentos de descarga
                    bool descargaExitosa = false;

                    for (int i = 0; i < intentos; i++)
                    {
                        try
                        {
                            // Obtener la información del archivo
                            info = conexion.obtainCacheRef(idconection, tipoDocumento, consulta, documentoId, referencia.ReferenceId);

                            if (info != null && info.fileSize > 0)
                            {
                                // Descargar el archivo en bloques
                                byte[] img = new byte[info.fileSize];
                                for (int j = 0; j < info.packLen; j++)
                                {
                                    byte[] res = conexion.getBlockRef(idconection, j);
                                    res.CopyTo(img, j * info.packSize);
                                }

                                // Guardar el archivo en la carpeta de destino
                                string rutaArchivo = Path.Combine(carpetaDestino, $"{referencia.DisplayAlias}.{info.ext}");
                                using (FileStream file = File.Open(rutaArchivo, FileMode.Create, FileAccess.Write))
                                {
                                    file.Write(img, 0, img.Length);
                                    file.Flush();
                                }

                                // Incrementar el contador de archivos descargados correctamente
                                archivosDescargados++;
                                descargaExitosa = true;
                                File.AppendAllText(rutaLog, $"Archivo {referencia.DisplayAlias} descargado correctamente.\n");
                                break; // Salir del bucle de intentos si la descarga fue exitosa
                            }
                            else
                            {
                                // Incrementar el contador de archivos fallidos
                                archivosFallidos++;
                                File.AppendAllText(rutaLog, $"Error: El archivo {referencia.DisplayAlias} no tiene información válida.\n");
                            }
                        }
                        catch (System.Web.Services.Protocols.SoapException ex)
                        {
                            // Registrar el error SOAP en el archivo de log
                            File.AppendAllText(rutaLog, $"Error SOAP al descargar el archivo {referencia.DisplayAlias} (Intento {i + 1}): {ex.Message}\n");

                            // Esperar un momento antes de reintentar
                            System.Threading.Thread.Sleep(1000); // Esperar 1 segundo antes de reintentar
                        }
                        catch (Exception ex)
                        {
                            // Registrar otros errores en el archivo de log
                            File.AppendAllText(rutaLog, $"Error al descargar el archivo {referencia.DisplayAlias} (Intento {i + 1}): {ex.Message}\n");

                            // Esperar un momento antes de reintentar
                            System.Threading.Thread.Sleep(1000); // Esperar 1 segundo antes de reintentar
                        }
                    }

                    if (!descargaExitosa)
                    {
                        // Incrementar el contador de archivos fallidos si todos los intentos fallaron
                        archivosFallidos++;
                        File.AppendAllText(rutaLog, $"Error: No se pudo descargar el archivo {referencia.DisplayAlias} después de {intentos} intentos.\n");
                    }
                }

                // Liberar la caché de referencia
                conexion.releaseCacheRef(idconection);
            }
            catch (System.Web.Services.Protocols.SoapException ex)
            {
                // Registrar el error SOAP en el archivo de log
                File.AppendAllText(rutaLog, $"Error SOAP al descargar el documento {documentoId}: {ex.Message}\n");
                archivosFallidos++;
            }
            catch (Exception ex)
            {
                // Registrar otros errores en el archivo de log
                File.AppendAllText(rutaLog, $"Error al descargar el documento {documentoId}: {ex.Message}\n");
                archivosFallidos++;
            }

            // Devolver los contadores de archivos descargados y fallidos
            return (archivosDescargados, archivosFallidos);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                String info = null;
                ePower.Collection Documento;
                DocumentoId = int.Parse(dtgResultados.CurrentCell.Value.ToString());
                Documento = conexion.getFullDocument(idconection, appid, tipoDocumento, consulta, DocumentoId);
                if (Documento.References.Length > 0)
                {
                    info = conexion.getUrlRef(idconection, tipoDocumento, consulta, DocumentoId, Documento.References[0].ReferenceId);
                    System.Diagnostics.Process.Start(@info);
                }
                else
                {
                    MessageBox.Show("El documento no contiene contenidos ", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Imposible generar ruta para imagen " + ex.ToString(), "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);



            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                ePower.DocFile info1 = null;
                ePower.Collection Documento;
                DocumentoId = int.Parse(dtgResultados.CurrentCell.Value.ToString());
                Documento = conexion.getFullDocument(idconection, appid, tipoDocumento, consulta, DocumentoId);
                if (Documento.References.Length > 0)
                {
                    info1 = conexion.getPdfRef(idconection, tipoDocumento, consulta, DocumentoId, Documento.References[0].ReferenceId, false, false, false);//false son permisos del pdf
                    if (info1 != null)
                    {
                        System.IO.FileStream file = System.IO.File.Open(Properties.Settings.Default.RutaTrabajo + Documento.References[0].DisplayAlias + "." + info1.ext, System.IO.FileMode.CreateNew, System.IO.FileAccess.ReadWrite);
                        file.Write(info1.base64Binary, 0, info1.base64Binary.Length);
                        file.Flush();
                        file.Close();
                        MessageBox.Show("Documento exportado ", "Información",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("El documento no contiene contenidos ", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Imposible generar documento PDF " + ex.ToString(), "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public class PaginatedDataGridView : Form
        {
            private DataGridView dataGridView;
            private Button btnSiguiente;
            private Button btnAtras;
            private int currentPage = 0;
            private int pageSize = 500;
            private DataTable allData;

            public PaginatedDataGridView()
            {
                InitializeComponents();
                LoadData();
            }

            private void InitializeComponents()
            {
                this.dataGridView = new DataGridView();
                this.btnSiguiente = new Button();
                this.btnAtras = new Button();

                // Configuración del DataGridView
                this.dataGridView.Dock = DockStyle.Fill;
                this.Controls.Add(this.dataGridView);

                // Configuración del botón "Siguiente"
                this.btnSiguiente.Text = "Siguiente";
                this.btnSiguiente.Dock = DockStyle.Bottom;
                this.btnSiguiente.Click += new EventHandler(BtnSiguiente_Click);
                this.Controls.Add(this.btnSiguiente);

                // Configuración del botón "Atrás"
                this.btnAtras.Text = "Atrás";
                this.btnAtras.Dock = DockStyle.Bottom;
                this.btnAtras.Click += new EventHandler(BtnAtras_Click);
                this.Controls.Add(this.btnAtras);
            }

            private void BtnAtras_Click(object sender, EventArgs e)
            {
                currentPage--;
                UpdateDataGridView();
            }

            private void BtnSiguiente_Click(object sender, EventArgs e)
            {
                currentPage++;
                UpdateDataGridView();
            }

            private void LoadData()
            {
                // Simula la carga de datos desde una base de datos
                allData = GetDataFromDatabase();

                // Muestra la primera página
                UpdateDataGridView();
            }

            private DataTable GetDataFromDatabase()
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("ID", typeof(int));
                dt.Columns.Add("Nombre", typeof(string));

                for (int i = 1; i <= 10000; i++)
                {
                    dt.Rows.Add(i, "Nombre " + i);
                }

                return dt;
            }

            private void UpdateDataGridView()
            {
                var rows = allData.AsEnumerable()
                                  .Skip(currentPage * pageSize)
                                  .Take(pageSize)
                                  .CopyToDataTable();

                dataGridView.DataSource = rows;

                // Habilita o deshabilita los botones según la página actual
                btnAtras.Enabled = currentPage > 0;
                btnSiguiente.Enabled = (currentPage + 1) * pageSize < allData.Rows.Count;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Resultados_Enter(object sender, EventArgs e)
        {

        }
    }
}
