using System;
using System.Diagnostics;
using DocumentFormat.OpenXml;
using System.IO;
using System.Text;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Row = DocumentFormat.OpenXml.Spreadsheet.Row;
using Cell = DocumentFormat.OpenXml.Spreadsheet.Cell;
using DocumentFormat.OpenXml.Wordprocessing;
using Paragraph = DocumentFormat.OpenXml.Wordprocessing.Paragraph;
using Run = DocumentFormat.OpenXml.Wordprocessing.Run;
using Text = DocumentFormat.OpenXml.Wordprocessing.Text;
using Break = DocumentFormat.OpenXml.Wordprocessing.Break;
using Document = iTextSharp.text.Document;
using Table = DocumentFormat.OpenXml.Wordprocessing.Table;

namespace AppProyectoFinal
{
    public partial class FrmCodigoPostal : Form
    {
        public FrmCodigoPostal()
        {
            InitializeComponent();
            lstvDatos.View = System.Windows.Forms.View.Details;
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogo = new OpenFileDialog();
            if (dialogo.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            lstvDatos.Clear();
            string rutaArchivo = dialogo.FileName;
            StreamReader sr = new StreamReader(rutaArchivo, Encoding.GetEncoding(1252));
            string columnas = sr.ReadLine();
            string[] columna = columnas.Split('|');
            for (int i = 0; i < columna.Length; i++)
            {
                lstvDatos.Columns.Add(columna[i]);
            }
            string renglon;
            while ((renglon = sr.ReadLine()) != null)
            {
                string[] datos = renglon.Split('|');
                ListViewItem item = new ListViewItem(datos[0]);
                for (int i = 1; i < datos.Length; i++)
                {
                    item.SubItems.Add(datos[i]);
                }
                lstvDatos.Items.Add(item);
            }
            sr.Close();
        }

        private void btnGuardarConInterop_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos de Excel (*.xlsx)|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Crea una instancia de la aplicación Excel
                var excelApp = new Microsoft.Office.Interop.Excel.Application();

                // Crea un nuevo libro de Excel
                var workbook = excelApp.Workbooks.Add();

                // Crea una hoja de Excel
                var worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];

                // Exporta el contenido del ListView a la hoja de Excel
                for (int i = 0; i < lstvDatos.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = lstvDatos.Columns[i].Text;
                }

                for (int i = 0; i < lstvDatos.Items.Count; i++)
                {
                    for (int j = 0; j < lstvDatos.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = lstvDatos.Items[i].SubItems[j].Text;
                    }
                }
                // Guarda el archivo de Excel
                workbook.SaveAs(saveFileDialog.FileName);

                // Cierra el archivo y la aplicación Excel
                workbook.Close();
                excelApp.Quit();
            }
        }

        private void btnGuardarOpenXml_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel files (.xlsx)|.xlsx|All files (.)|.";
            if (sfd.ShowDialog() != DialogResult.OK)
            { return; }

            if (sfd.FileName != "")
            {
                SpreadsheetDocument document = SpreadsheetDocument.Create(sfd.FileName, SpreadsheetDocumentType.Workbook);
                // Agregar una hoja de trabajo
                WorkbookPart workbookPart = document.AddWorkbookPart();
                workbookPart.Workbook = new DocumentFormat.OpenXml.Spreadsheet.Workbook();
                WorksheetPart worksheetPart = workbookPart.AddNewPart<WorksheetPart>();
                worksheetPart.Worksheet = new DocumentFormat.OpenXml.Spreadsheet.Worksheet(new SheetData());
                DocumentFormat.OpenXml.Spreadsheet.Sheets sheets = workbookPart.Workbook.AppendChild(new DocumentFormat.OpenXml.Spreadsheet.Sheets());
                Sheet sheet = new Sheet() { Id = workbookPart.GetIdOfPart(worksheetPart), SheetId = 1, Name = "ListView" };
                sheets.Append(sheet);

                // Obtener la colección de celdas
                SheetData sheetData = worksheetPart.Worksheet.GetFirstChild<SheetData>();

                // Recorrer las columnas y filas de la ListView
                for (int i = 0; i < lstvDatos.Columns.Count; i++)
                {
                    // Crear una fila para los encabezados
                    if (i == 0)
                    {
                        Row row = new Row() { RowIndex = 1 };
                        sheetData.Append(row);
                    }
                    // Obtener el encabezado de la columna
                    string headerText = lstvDatos.Columns[i].Text;
                    // Crear una celda para el encabezado
                    Cell headerCell = new Cell()
                    {
                        CellReference = GetColumnName(i + 1) + "1",
                        DataType = CellValues.String,
                        CellValue = new CellValue(headerText)
                    };
                    // Agregar la celda al final de la fila
                    Row headerRow = (Row)sheetData.ChildElements.GetItem(0);
                    headerRow.AppendChild(headerCell);

                    // Recorrer las filas de la columna
                    for (int j = 0; j < lstvDatos.Items.Count; j++)
                    {
                        // Crear una fila para los datos
                        if (i == 0)
                        {
                            Row row = new Row() { RowIndex = (uint)(j + 2) };
                            sheetData.Append(row);
                        }
                        // Obtener el valor del dato
                        string dataText = lstvDatos.Items[j].SubItems[i].Text;
                        // Crear una celda para el dato
                        Cell dataCell = new Cell()
                        {
                            CellReference = GetColumnName(i + 1) + (j + 2),
                            DataType = CellValues.String,
                            CellValue = new CellValue(dataText)
                        };
                        // Agregar la celda al final de la fila
                        Row dataRow = (Row)sheetData.ChildElements.GetItem(j + 1);
                        dataRow.AppendChild(dataCell);
                    }
                }
                // Guardar y cerrar el documento
                workbookPart.Workbook.Save();
                document.Close();
                Process.Start(sfd.FileName);
            }
        }
        

        private void btnGuardarPDF_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos PDF (*.pdf)|*.pdf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Código para guardar en PDF utilizando una biblioteca de terceros como iTextSharp o PDFSharp.
                // Asegúrate de agregar la referencia y los using necesarios para la biblioteca de tu elección.
                // Aquí se muestra un ejemplo utilizando iTextSharp:

                // Crea un nuevo documento PDF
                Document document = new Document();

                // Crea un escritor PDF para el documento y lo vincula al archivo de destino
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(saveFileDialog.FileName, FileMode.Create));

                // Abre el documento para escritura
                document.Open();

                // Agrega el contenido del ListView al documento PDF
                PdfPTable table = new PdfPTable(lstvDatos.Columns.Count);

                // Agrega los encabezados de columna al documento
                foreach (ColumnHeader column in lstvDatos.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.Text));
                    table.AddCell(cell);
                }

                // Agrega los datos de las filas al documento
                foreach (ListViewItem item in lstvDatos.Items)
                {
                    foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(subItem.Text));
                        table.AddCell(cell);
                    }
                }

                // Agrega la tabla al documento
                document.Add(table);

                // Cierra el documento
                document.Close();

                // Abre el archivo PDF resultante
                Process.Start(saveFileDialog.FileName);
            }
        }
        private string GetColumnName(int index)
        {
            int dividend = index;
            string columnName = String.Empty;
            int modulo;

            while (dividend > 0)
            {
                modulo = (dividend - 1) % 26;
                columnName = Convert.ToChar(65 + modulo).ToString() + columnName;
                dividend = (int)((dividend - modulo) / 26);
            }
            return columnName;
        }

        private void btnGuardarWord_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos de Word (*.docx)|*.docx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Crea un nuevo documento de Word
                Document document = new Document();

                // Crea un escritor de Word para el documento y lo vincula al archivo de destino
                using (var writer = WordprocessingDocument.Create(saveFileDialog.FileName, WordprocessingDocumentType.Document))
                {
                    // Agrega un cuerpo al documento
                    MainDocumentPart mainPart = writer.AddMainDocumentPart();
                    mainPart.Document = new DocumentFormat.OpenXml.Wordprocessing.Document();
                    Body body = mainPart.Document.AppendChild(new Body());

                    // Crea una tabla
                    Table table = new Table();

                    // Crea la primera fila como encabezados de columna
                    TableRow headerRow = new TableRow();
                    foreach (ColumnHeader column in lstvDatos.Columns)
                    {
                        TableCell headerCell = new TableCell(new Paragraph(new Run(new Text(column.Text))));
                        headerRow.Append(headerCell);
                    }
                    table.Append(headerRow);

                    // Agrega los datos de las filas al documento
                    foreach (ListViewItem item in lstvDatos.Items)
                    {
                        TableRow dataRow = new TableRow();
                        foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                        {
                            TableCell dataCell = new TableCell(new Paragraph(new Run(new Text(subItem.Text))));
                            dataRow.Append(dataCell);
                        }
                        table.Append(dataRow);
                    }

                    // Agrega la tabla al cuerpo del documento
                    body.Append(table);
                }

                // Abre el archivo de Word resultante
                Process.Start(saveFileDialog.FileName);
            }
        }

        private void btnGuardarCSV_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos CSV (*.csv)|*.csv";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtener el carácter de separación ingresado por el usuario
                char separador = ObtenerCaracterSeparador();

                // Crear el contenido CSV a partir de los datos del ListView
                StringBuilder contenidoCSV = new StringBuilder();

                // Agregar los encabezados de columna al contenido CSV
                for (int i = 0; i < lstvDatos.Columns.Count; i++)
                {
                    contenidoCSV.Append(lstvDatos.Columns[i].Text);
                    if (i < lstvDatos.Columns.Count - 1)
                    {
                        contenidoCSV.Append(separador);
                    }
                }
                contenidoCSV.AppendLine();

                // Agregar los datos de las filas al contenido CSV
                foreach (ListViewItem item in lstvDatos.Items)
                {
                    for (int i = 0; i < item.SubItems.Count; i++)
                    {
                        contenidoCSV.Append(item.SubItems[i].Text);
                        if (i < item.SubItems.Count - 1)
                        {
                            contenidoCSV.Append(separador);
                        }
                    }
                    contenidoCSV.AppendLine();
                }

                // Guardar el contenido CSV en el archivo
                File.WriteAllText(saveFileDialog.FileName, contenidoCSV.ToString());

                // Mostrar un mensaje de éxito al usuario
                MessageBox.Show("Archivo guardado exitosamente.", "Guardar CSV", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private char ObtenerCaracterSeparador()
        {
            if (!string.IsNullOrWhiteSpace(txtCaracterSeparador.Text))
            {
                return txtCaracterSeparador.Text[0];
            }
            else
            {
                return ',';
            }
        }
    }
}
