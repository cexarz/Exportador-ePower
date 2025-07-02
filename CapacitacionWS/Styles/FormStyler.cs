using System.Drawing;
using System.Windows.Forms;
using System;

public static class FormStyler
{
    public static void ApplyModernStyle(Form form)
    {
        // Estilo básico del formulario
        form.BackColor = AppColors.LightBackground;
        form.Font = new Font("Segoe UI", 9f);
        form.StartPosition = FormStartPosition.CenterScreen;
        form.FormBorderStyle = FormBorderStyle.FixedSingle;
        form.MaximizeBox = false;

        // Efecto de sombra (requiere referencia a System.Runtime.InteropServices)
        if (Environment.OSVersion.Version.Major >= 6)
        {
            NativeMethods.SetWindowShadow(form.Handle, 2);
        }
    }

    // Para controles DataGridView
    public static void StyleDataGridView(DataGridView dgv)
    {
        dgv.BackgroundColor = AppColors.LightBackground;
        dgv.BorderStyle = BorderStyle.None;
        dgv.EnableHeadersVisualStyles = false;
        dgv.ColumnHeadersDefaultCellStyle.BackColor = AppColors.Dark;
        dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
        dgv.RowsDefaultCellStyle.BackColor = AppColors.LightBackground;
        dgv.RowsDefaultCellStyle.ForeColor = AppColors.TextDark;
        dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        dgv.GridColor = Color.FromArgb(224, 224, 224);
    }
}

// Clase para efectos avanzados (opcional)
internal static class NativeMethods
{
    [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
    public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

    public static void SetWindowShadow(IntPtr handle, int shadowValue)
    {
        DwmSetWindowAttribute(handle, 2, ref shadowValue, sizeof(int));
    }
}