using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using LiteDB;

namespace Rixpert
{
    public partial class FrmMenu : Form
    {
        private string dbPath = "Rizxpert.db"; // Ruta para la base de datos LiteDB
        private LiteDatabase db;
        private int currentPhase = 1; // Variable para rastrear la fase actual
        private DataTable dataTableFase1; // Tabla para almacenar los datos de la primera fase
        private DataTable dataTableFase2; // Tabla para almacenar los datos de la segunda fase
        private DataTable dataTableFase3; // Tabla para almacenar los datos de la tercera fase
        private DataTable dataTableFase4; // Tabla para almacenar los datos de la cuarta fase

        public FrmMenu()
        {
            InitializeComponent();
            db = new LiteDatabase(dbPath);
            ControlFases.Selected += ControlFases_Selected;

            BtnAgregar1.Click += BtnAgregar1_Click;

            TxtAnalista1.TextChanged += TxtAnalista_TextChanged;
            TxtAnalista2.TextChanged += TxtAnalista_TextChanged;
            TxtAnalista3.TextChanged += TxtAnalista_TextChanged;
            TxtAnalista4.TextChanged += TxtAnalista_TextChanged;

            TxtAnalista1.Enter += TxtAnalista1_Enter;

            BtnFase01.Click += BtnFase01_Click;
            BtnFase02.Click += BtnFase02_Click;
            BtnFase03.Click += BtnFase03_Click;
            BtnFase04.Click += BtnFase04_Click;

            BtnGuardar.Click += BtnGuardar_Click;
            BtnGuardar2.Click += BtGuardar2_Click;
            BtnGuardar3.Click += BtnGuardar3_Click;
            BtnGuardar4.Click += BtnGuardar4_Click;

            // Agregar columnas a DataGridFase1
            dataTableFase1 = new DataTable();
            dataTableFase1.Columns.Add("ID", typeof(string));
            dataTableFase1.Columns.Add("Activo", typeof(string));
            dataTableFase1.Columns.Add("Riesgo", typeof(string));
            dataTableFase1.Columns.Add("Daño", typeof(string));

            // Agregar columnas a DataGridFase2
            dataTableFase2 = new DataTable();
            dataTableFase2.Columns.Add("ID", typeof(string));
            dataTableFase2.Columns.Add("Activo", typeof(string));
            dataTableFase2.Columns.Add("Riesgo", typeof(string));
            dataTableFase2.Columns.Add("Daño", typeof(string));
            dataTableFase2.Columns.Add("S", typeof(int));
            dataTableFase2.Columns.Add("F", typeof(int));
            dataTableFase2.Columns.Add("P", typeof(int));
            dataTableFase2.Columns.Add("A", typeof(int));
            dataTableFase2.Columns.Add("V", typeof(int));
            dataTableFase2.Columns.Add("E", typeof(int));

            // Agregar columnas a DataGridFase3
            dataTableFase3 = new DataTable();
            dataTableFase3.Columns.Add("ID", typeof(string));
            dataTableFase3.Columns.Add("Activo", typeof(string));
            dataTableFase3.Columns.Add("Riesgo", typeof(string));
            dataTableFase3.Columns.Add("Daño", typeof(string));
            dataTableFase3.Columns.Add("S", typeof(int));
            dataTableFase3.Columns.Add("F", typeof(int));
            dataTableFase3.Columns.Add("P", typeof(int));
            dataTableFase3.Columns.Add("A", typeof(int));
            dataTableFase3.Columns.Add("V", typeof(int));
            dataTableFase3.Columns.Add("E", typeof(int)); 
            dataTableFase3.Columns.Add("I", typeof(int));
            dataTableFase3.Columns.Add("C", typeof(int));
            dataTableFase3.Columns.Add("D", typeof(int));
            dataTableFase3.Columns.Add("PB", typeof(int));
            dataTableFase3.Columns.Add("ER", typeof(int));

            // Agregar columnas a DataGridFase4
            dataTableFase4 = new DataTable();
            dataTableFase4.Columns.Add("ID", typeof(string));
            dataTableFase4.Columns.Add("Activo", typeof(string));
            dataTableFase4.Columns.Add("Riesgo", typeof(string));
            dataTableFase4.Columns.Add("Daño", typeof(string));
            dataTableFase4.Columns.Add("S", typeof(int));
            dataTableFase4.Columns.Add("F", typeof(int));
            dataTableFase4.Columns.Add("P", typeof(int));
            dataTableFase4.Columns.Add("A", typeof(int));
            dataTableFase4.Columns.Add("V", typeof(int));
            dataTableFase4.Columns.Add("E", typeof(int));
            dataTableFase4.Columns.Add("I", typeof(int));
            dataTableFase4.Columns.Add("C", typeof(int));
            dataTableFase4.Columns.Add("D", typeof(int));
            dataTableFase4.Columns.Add("PB", typeof(int));
            dataTableFase4.Columns.Add("ER", typeof(int));
            dataTableFase4.Columns.Add("Gravedad", typeof(string));
            dataTableFase4.Columns.Add("Mitigación", typeof(string));

            // Asignar los DataTable a las DataGridView correspondientes
            DataGridFase1.DataSource = dataTableFase1;
            DataGridFase2.DataSource = dataTableFase2;
            DataGridFase3.DataSource = dataTableFase3;
            DataGridFase4.DataSource = dataTableFase4;


            // Evento CellEndEdit para calcular el ID en DataGridFase1
            DataGridFase1.CellEndEdit += DataGridFase1_CellEndEdit;

            // Evento CellEndEdit para calcular el ID en DataGridFase1
            DataGridFase1.CellEndEdit += DataGridFase1_CellEndEdit;

            // Evento CellValueChanged para actualizar el color en DataGridFase2
            DataGridFase2.CellValueChanged += DataGridFase2_CellValueChanged;

            // Evento CellValueChanged para realizar cálculos en DataGridFase3
            DataGridFase3.CellValueChanged += DataGridFase3_CellValueChanged;

            // Evento CellValueChanged para clasificar la gravedad en DataGridFase4
            DataGridFase4.CellValueChanged += DataGridFase4_CellValueChanged;

            // Evento CellFormatting para DataGridFase3
            DataGridFase3.CellFormatting += DataGridFase3_CellFormatting;

            // Evento CellFormatting para DataGridFase4
            DataGridFase4.CellFormatting += DataGridFase4_CellFormatting;
        }

        private void ControlFases_Selected(object sender, TabControlEventArgs e)
        {
            currentPhase = ControlFases.SelectedIndex + 1;
            BtnFase01.Enabled = currentPhase != 1;
            BtnFase02.Enabled = currentPhase != 2;
            BtnFase03.Enabled = currentPhase != 3;
            BtnFase04.Enabled = currentPhase != 4;

            CargarContenidoDesdeDB();
        }

        private List<object> nuevaFilaDataGridFase1 = new List<object>();

        // Evento Click del botón BtnAgregar1
        private void BtnAgregar1_Click(object sender, EventArgs e)
        {
            // Crear un nuevo objeto para representar la fila y agregarlo a la fuente de datos
            // Por ejemplo, si estás utilizando un DataTable, puedes hacer lo siguiente:
            DataRow nuevaFila = ((DataTable)DataGridFase1.DataSource).NewRow();
            ((DataTable)DataGridFase1.DataSource).Rows.Add(nuevaFila);

            // Obtener el índice de la nueva fila agregada
            int nuevaFilaIndex = DataGridFase1.Rows.Count - 1;

            // Habilitar la edición solo para la nueva fila
            DataGridFase1.ReadOnly = false;
            for (int i = 0; i < DataGridFase1.Rows.Count - 1; i++)
            {
                DataGridFase1.Rows[i].ReadOnly = true;
            }

            // Seleccionar la nueva fila para que el usuario pueda editarla
            DataGridFase1.CurrentCell = DataGridFase1.Rows[nuevaFilaIndex].Cells[0];
        }

        private void TxtAnalista_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            TxtAnalista2.Text = TxtAnalista1.Text;
            TxtAnalista3.Text = TxtAnalista1.Text;
            TxtAnalista4.Text = TxtAnalista1.Text;

            string clave = "Analista" + textBox.Name[textBox.Name.Length - 1];
            GuardarContenidoEnDB(clave, textBox.Text);
        }

        private void TxtAnalista1_Enter(object sender, EventArgs e)
        {
            if (TxtAnalista1.Text == "Analista")
            {
                TxtAnalista1.Text = "";
            }
        }

        private void GuardarContenidoEnDB(string clave, string contenido)
        {
            var collection = db.GetCollection<BsonDocument>("analistas");
            var doc = new BsonDocument
            {
                { clave, contenido }
            };
            collection.Upsert(doc);
        }

        private void CargarContenidoDesdeDB()
        {
            var collection = db.GetCollection<BsonDocument>("analistas");
            var doc = collection.FindOne(Query.All(Query.Ascending));
            if (doc != null)
            {
                TxtAnalista1.Text = doc["Analista1"].AsString;
                TxtAnalista2.Text = doc["Analista2"].AsString;
                TxtAnalista3.Text = doc["Analista3"].AsString;
                TxtAnalista4.Text = doc["Analista4"].AsString;

                TxtAnalista1.Enabled = true;
                TxtAnalista2.Enabled = false;
                TxtAnalista3.Enabled = false;
                TxtAnalista4.Enabled = false;
            }
        }

        // Método para actualizar los demás DataGridFases con los datos de la nueva fila
        private void ActualizarDataGridFases()
        {
            // Limpiar los DataGridFase2, DataGridFase3 y DataGridFase4
            DataGridFase2.Rows.Clear();
            DataGridFase3.Rows.Clear();
            DataGridFase4.Rows.Clear();

            // Agregar la nueva fila a DataGridFase2
            DataGridFase2.Rows.Add(nuevaFilaDataGridFase1.ToArray());

            // Agregar la nueva fila a DataGridFase3
            DataGridFase3.Rows.Add(nuevaFilaDataGridFase1.ToArray());

            // Agregar la nueva fila a DataGridFase4
            DataGridFase4.Rows.Add(nuevaFilaDataGridFase1.ToArray());
        }

        private void DataGridFase1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si el valor ha sido cambiado en la nueva fila (la última fila)
            if (e.RowIndex == DataGridFase1.Rows.Count - 1 && e.RowIndex >= 0)
            {
                // Obtener los datos de la nueva fila agregada y almacenarlos en la variable global
                nuevaFilaDataGridFase1.Clear();
                foreach (DataGridViewCell cell in DataGridFase1.Rows[e.RowIndex].Cells)
                {
                    nuevaFilaDataGridFase1.Add(cell.Value);
                }

                // Actualizar los demás DataGridFases con los datos de la nueva fila
                ActualizarDataGridFases();
            }

            if (e.ColumnIndex == DataGridFase1.Columns["Riesgo"].Index)
            {
                // Generar el ID basado en la primera inicial del Riesgo y la cantidad de vocales
                string riesgo = DataGridFase1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Trim();
                if (!string.IsNullOrEmpty(riesgo))
                {
                    string primeraInicial = riesgo.Substring(0, 1).ToUpper();
                    int cantidadVocales = ContarVocales(riesgo);
                    string id = "#" + primeraInicial + cantidadVocales.ToString("00");
                    DataGridFase1.Rows[e.RowIndex].Cells["ID"].Value = id;
                }
            }
        }

        // Método para contar las vocales en un texto
        private int ContarVocales(string texto)
        {
            int count = 0;
            foreach (char c in texto)
            {
                if ("AEIOUaeiou".Contains(c))
                {
                    count++;
                }
            }
            return count;
        }

        private void BtnFase01_Click(object sender, EventArgs e)
        {
            currentPhase = 1;
            ControlFases.SelectedTab = FrmFase01;
        }

        private void BtnFase02_Click(object sender, EventArgs e)
        {
            currentPhase = 2;
            ControlFases.SelectedTab = FrmFase02;
        }

        private void BtnFase03_Click(object sender, EventArgs e)
        {
            currentPhase = 3;
            ControlFases.SelectedTab = FrmFase03;
        }

        private void BtnFase04_Click(object sender, EventArgs e)
        {
            currentPhase = 4;
            ControlFases.SelectedTab = FrmFase04;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (currentPhase == 1)
            {
                BtnFase01.BackColor = Color.FromArgb(49, 189, 79);
                // Transferir datos de DataGridFase1 a DataGridFase2
                foreach (DataRow row in dataTableFase1.Rows)
                {
                    DataRow newRow = dataTableFase2.Rows.Add();
                    newRow.ItemArray = row.ItemArray.Clone() as object[];
                }
            }

            // Solo avanzar a la fase 2 si se hizo clic en el botón de guardar de la fase 1
            if (currentPhase == 1)
            {
                currentPhase++;
                ControlFases.SelectedIndex = currentPhase - 1;
            }
        }

        private void BtGuardar2_Click(object sender, EventArgs e)
        {
            if (currentPhase == 2)
            {
                BtnFase02.BackColor = Color.FromArgb(49, 189, 79);
                // Transferir datos de DataGridFase2 a DataGridFase3
                foreach (DataRow row in dataTableFase2.Rows)
                {
                    DataRow newRow = dataTableFase3.Rows.Add();
                    newRow.ItemArray = row.ItemArray.Clone() as object[];
                }
            }

            // Solo avanzar a la fase 3 si se hizo clic en el botón de guardar de la fase 2
            if (currentPhase == 2)
            {
                currentPhase++;
                ControlFases.SelectedIndex = currentPhase - 1;
            }
        }

        private void BtnGuardar3_Click(object sender, EventArgs e)
        {
            if (currentPhase == 3)
            {
                BtnFase03.BackColor = Color.FromArgb(49, 189, 79);
                // Transferir datos de DataGridFase3 a DataGridFase4
                TransferirCalculosDesdeFase3();
            }

            // Solo avanzar a la fase 4 si se hizo clic en el botón de guardar de la fase 3
            if (currentPhase == 3)
            {
                currentPhase++;
                ControlFases.SelectedIndex = currentPhase - 1;
            }
        }

        private void BtnGuardar4_Click(object sender, EventArgs e)
        {
            if (currentPhase == 4)
            {
                BtnFase04.BackColor = Color.FromArgb(49, 189, 79);
            }

            // No hay necesidad de avanzar a otra fase en el botón de guardar de la fase 4
        }
        private void ActualizarColoresFase3YFase4(int fila)
        {
            // Obtener los valores de las celdas S, F, P, A, V y E en DataGridFase2
            int? valorS = ObtenerValorNumerico(DataGridFase2.Rows[fila].Cells["S"].Value);
            int? valorF = ObtenerValorNumerico(DataGridFase2.Rows[fila].Cells["F"].Value);
            int? valorP = ObtenerValorNumerico(DataGridFase2.Rows[fila].Cells["P"].Value);
            int? valorA = ObtenerValorNumerico(DataGridFase2.Rows[fila].Cells["A"].Value);
            int? valorV = ObtenerValorNumerico(DataGridFase2.Rows[fila].Cells["V"].Value);
            int? valorE = ObtenerValorNumerico(DataGridFase2.Rows[fila].Cells["E"].Value);

            // Establecer los colores correspondientes en DataGridFase3
            EstablecerColorEnCelda(DataGridFase3.Rows[fila].Cells["S"], valorS);
            EstablecerColorEnCelda(DataGridFase3.Rows[fila].Cells["F"], valorF);
            EstablecerColorEnCelda(DataGridFase3.Rows[fila].Cells["P"], valorP);
            EstablecerColorEnCelda(DataGridFase3.Rows[fila].Cells["A"], valorA);
            EstablecerColorEnCelda(DataGridFase3.Rows[fila].Cells["V"], valorV);
            EstablecerColorEnCelda(DataGridFase3.Rows[fila].Cells["E"], valorE);

            // Establecer los colores correspondientes en DataGridFase4
            EstablecerColorEnCelda(DataGridFase4.Rows[fila].Cells["S"], valorS);
            EstablecerColorEnCelda(DataGridFase4.Rows[fila].Cells["F"], valorF);
            EstablecerColorEnCelda(DataGridFase4.Rows[fila].Cells["P"], valorP);
            EstablecerColorEnCelda(DataGridFase4.Rows[fila].Cells["A"], valorA);
            EstablecerColorEnCelda(DataGridFase4.Rows[fila].Cells["V"], valorV);
            EstablecerColorEnCelda(DataGridFase4.Rows[fila].Cells["E"], valorE);
        }

        private int? ObtenerValorNumerico(object valor)
        {
            // Si el valor es DBNull o nulo, devolver null
            if (valor == DBNull.Value || valor == null)
            {
                return null;
            }

            // Si es un entero válido, devolver el valor numérico
            if (int.TryParse(valor.ToString(), out int resultado))
            {
                return resultado;
            }

            return null;
        }

        private void EstablecerColorEnCelda(DataGridViewCell celda, int? valor)
        {
            if (valor != null)
            {
                celda.Style.BackColor = ObtenerColorPorValor((int)valor);
            }
            else
            {
                celda.Style.BackColor = Color.White;
            }
        }
        private Color ObtenerColorPorValor(int valor)
        {
            // Asignar los colores según el valor
            switch (valor)
            {
                case 1:
                    return Color.FromArgb(49, 189, 79); // Verde
                case 2:
                    return Color.FromArgb(255, 255, 0); // Amarillo
                case 3:
                    return Color.FromArgb(255, 165, 0); // Naranja
                case 4:
                    return Color.FromArgb(255, 69, 0);  // Rojo
                case 5:
                    return Color.FromArgb(128, 0, 0);   // Marrón
                default:
                    return Color.White;
            }
        }

        private void DataGridFase2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegurarse de que se haya modificado una fila válida
            {
                // Actualizar los colores en DataGridFase3 y DataGridFase4
                ActualizarColoresFase3YFase4(e.RowIndex);
            }

            // Actualizar el color de las celdas en la columna "S", "F", "P", "A", "V" y "E"
            if (e.RowIndex >= 0 && e.ColumnIndex >= DataGridFase2.Columns["S"].Index && e.ColumnIndex <= DataGridFase2.Columns["E"].Index)
            {
                object cellValue = DataGridFase2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                int valor = 0;
                if (cellValue != null && cellValue != DBNull.Value)
                {
                    valor = Convert.ToInt32(cellValue);
                }

                Color color = valor switch
                {
                    1 => Color.FromArgb(49, 189, 79), // Verde
                    2 => Color.FromArgb(255, 255, 0), // Amarillo
                    3 => Color.FromArgb(255, 165, 0), // Naranja
                    4 => Color.FromArgb(255, 69, 0),  // Rojo
                    5 => Color.FromArgb(128, 0, 0),   // Marrón
                    _ => Color.White,
                };

                DataGridFase2.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = color;

                // Transferir el valor y el color a DataGridFase3 y DataGridFase4
                string columnName = DataGridFase2.Columns[e.ColumnIndex].Name;
                int rowIndex = e.RowIndex;

                // Asegurar que las filas existan en dataTableFase3 y dataTableFase4 antes de acceder a ellas
                if (dataTableFase3.Rows.Count <= rowIndex)
                {
                    dataTableFase3.Rows.Add(dataTableFase2.Rows[rowIndex].ItemArray);
                }

                if (dataTableFase4.Rows.Count <= rowIndex)
                {
                    dataTableFase4.Rows.Add(dataTableFase2.Rows[rowIndex].ItemArray);
                }

                DataGridFase3.Rows[e.RowIndex].Cells[columnName].Value = valor;
                DataGridFase3.Rows[e.RowIndex].Cells[columnName].Style.BackColor = color;

                DataGridFase4.Rows[e.RowIndex].Cells[columnName].Value = valor;
                DataGridFase4.Rows[e.RowIndex].Cells[columnName].Style.BackColor = color;

                // Actualizar la tabla interna dataTableFase3 y dataTableFase4 con el nuevo valor y color
                dataTableFase3.Rows[rowIndex][columnName] = valor;
                dataTableFase3.AcceptChanges();

                dataTableFase4.Rows[rowIndex][columnName] = valor;
                dataTableFase4.AcceptChanges();

                // Verificar si la columna "I" existe en DataGridFase3 y agregarla si no está presente
                if (!DataGridFase3.Columns.Contains("I"))
                {
                    DataGridFase3.Columns.Add("I", "I");
                }
            }

            // Realizar cálculos adicionales para DataGridFase3 si todas las celdas requeridas tienen valores válidos
            if (DataGridFase2.Rows[e.RowIndex].Cells["S"].Value != DBNull.Value &&
                DataGridFase2.Rows[e.RowIndex].Cells["F"].Value != DBNull.Value &&
                DataGridFase2.Rows[e.RowIndex].Cells["P"].Value != DBNull.Value &&
                DataGridFase2.Rows[e.RowIndex].Cells["A"].Value != DBNull.Value &&
                DataGridFase2.Rows[e.RowIndex].Cells["V"].Value != DBNull.Value &&
                DataGridFase2.Rows[e.RowIndex].Cells["E"].Value != DBNull.Value)
            {
                // Realizar los cálculos solo si la columna "I" está presente en DataGridFase3
                if (DataGridFase3.Columns.Contains("I"))
                {
                    int valorF = Convert.ToInt32(DataGridFase2.Rows[e.RowIndex].Cells["F"].Value);
                    int valorS = Convert.ToInt32(DataGridFase2.Rows[e.RowIndex].Cells["S"].Value);
                    int i = valorF * valorS;
                    DataGridFase3.Rows[e.RowIndex].Cells["I"].Value = i;

                    int valorP = Convert.ToInt32(DataGridFase2.Rows[e.RowIndex].Cells["P"].Value);
                    int valorE = Convert.ToInt32(DataGridFase2.Rows[e.RowIndex].Cells["E"].Value);
                    int d = valorP * valorE;
                    DataGridFase3.Rows[e.RowIndex].Cells["D"].Value = d;

                    int c = i + d;
                    DataGridFase3.Rows[e.RowIndex].Cells["C"].Value = c;

                    int valorA = Convert.ToInt32(DataGridFase2.Rows[e.RowIndex].Cells["A"].Value);
                    int valorV = Convert.ToInt32(DataGridFase2.Rows[e.RowIndex].Cells["V"].Value);
                    int pb = valorA * valorV;
                    DataGridFase3.Rows[e.RowIndex].Cells["PB"].Value = pb;

                    int er = c * pb;
                    DataGridFase3.Rows[e.RowIndex].Cells["ER"].Value = er;
                }
            } // Actualizar el color de las celdas en la columna "S", "F", "P", "A", "V" y "E"
            if (e.RowIndex >= 0 && e.ColumnIndex >= DataGridFase2.Columns["S"].Index && e.ColumnIndex <= DataGridFase2.Columns["E"].Index)
            {
                object cellValue = DataGridFase2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                int valor = 0;
                if (cellValue != null && cellValue != DBNull.Value)
                {
                    valor = Convert.ToInt32(cellValue);
                }

                Color color = valor switch
                {
                    1 => Color.FromArgb(49, 189, 79), // Verde
                    2 => Color.FromArgb(255, 255, 0), // Amarillo
                    3 => Color.FromArgb(255, 165, 0), // Naranja
                    4 => Color.FromArgb(255, 69, 0),  // Rojo
                    5 => Color.FromArgb(128, 0, 0),   // Marrón
                    _ => Color.White,
                };

                DataGridFase2.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = color;

                // Transferir el valor y el color a DataGridFase3 y DataGridFase4
                string columnName = DataGridFase2.Columns[e.ColumnIndex].Name;
                int rowIndex = e.RowIndex;

                // Asegurar que las filas existan en dataTableFase3 y dataTableFase4 antes de acceder a ellas
                if (dataTableFase3.Rows.Count <= rowIndex)
                {
                    dataTableFase3.Rows.Add(dataTableFase2.Rows[rowIndex].ItemArray);
                }

                if (dataTableFase4.Rows.Count <= rowIndex)
                {
                    dataTableFase4.Rows.Add(dataTableFase2.Rows[rowIndex].ItemArray);
                }

                DataGridFase3.Rows[e.RowIndex].Cells[columnName].Value = valor;
                DataGridFase3.Rows[e.RowIndex].Cells[columnName].Style.BackColor = color;

                DataGridFase4.Rows[e.RowIndex].Cells[columnName].Value = valor;
                DataGridFase4.Rows[e.RowIndex].Cells[columnName].Style.BackColor = color;

                // Actualizar la tabla interna dataTableFase3 y dataTableFase4 con el nuevo valor y color
                dataTableFase3.Rows[rowIndex][columnName] = valor;
                dataTableFase3.AcceptChanges();

                dataTableFase4.Rows[rowIndex][columnName] = valor;
                dataTableFase4.AcceptChanges();

                // Verificar si la columna "I" existe en DataGridFase3 y agregarla si no está presente
                if (!DataGridFase3.Columns.Contains("I"))
                {
                    DataGridFase3.Columns.Add("I", "I");
                }
            }

            // Realizar cálculos adicionales para DataGridFase3 si todas las celdas requeridas tienen valores válidos
            if (DataGridFase2.Rows[e.RowIndex].Cells["S"].Value != DBNull.Value &&
                DataGridFase2.Rows[e.RowIndex].Cells["F"].Value != DBNull.Value &&
                DataGridFase2.Rows[e.RowIndex].Cells["P"].Value != DBNull.Value &&
                DataGridFase2.Rows[e.RowIndex].Cells["A"].Value != DBNull.Value &&
                DataGridFase2.Rows[e.RowIndex].Cells["V"].Value != DBNull.Value &&
                DataGridFase2.Rows[e.RowIndex].Cells["E"].Value != DBNull.Value)
            {
                // Realizar los cálculos solo si la columna "I" está presente en DataGridFase3
                if (DataGridFase3.Columns.Contains("I"))
                {
                    int valorF = Convert.ToInt32(DataGridFase2.Rows[e.RowIndex].Cells["F"].Value);
                    int valorS = Convert.ToInt32(DataGridFase2.Rows[e.RowIndex].Cells["S"].Value);
                    int i = valorF * valorS;
                    DataGridFase3.Rows[e.RowIndex].Cells["I"].Value = i;

                    int valorP = Convert.ToInt32(DataGridFase2.Rows[e.RowIndex].Cells["P"].Value);
                    int valorE = Convert.ToInt32(DataGridFase2.Rows[e.RowIndex].Cells["E"].Value);
                    int d = valorP * valorE;
                    DataGridFase3.Rows[e.RowIndex].Cells["D"].Value = d;

                    int c = i + d;
                    DataGridFase3.Rows[e.RowIndex].Cells["C"].Value = c;

                    int valorA = Convert.ToInt32(DataGridFase2.Rows[e.RowIndex].Cells["A"].Value);
                    int valorV = Convert.ToInt32(DataGridFase2.Rows[e.RowIndex].Cells["V"].Value);
                    int pb = valorA * valorV;
                    DataGridFase3.Rows[e.RowIndex].Cells["PB"].Value = pb;

                    int er = c * pb;
                    DataGridFase3.Rows[e.RowIndex].Cells["ER"].Value = er;
                }
            }
        }

        private void DataGridFase3_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Realizar cálculos en DataGridFase3
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == DataGridFase3.Columns["S"].Index || e.ColumnIndex == DataGridFase3.Columns["F"].Index)
                {
                    int valorS = Convert.ToInt32(DataGridFase3.Rows[e.RowIndex].Cells["S"].Value);
                    int valorF = Convert.ToInt32(DataGridFase3.Rows[e.RowIndex].Cells["F"].Value);
                    int i = valorF * valorS;
                    DataGridFase3.Rows[e.RowIndex].Cells["C"].Value = i;
                }
                else if (e.ColumnIndex == DataGridFase3.Columns["P"].Index || e.ColumnIndex == DataGridFase3.Columns["E"].Index)
                {
                    // Verificar si las celdas contienen valores válidos antes de realizar cálculos
                    object valorP = DataGridFase3.Rows[e.RowIndex].Cells["P"].Value;
                    object valorE = DataGridFase3.Rows[e.RowIndex].Cells["E"].Value;

                    if (valorP != DBNull.Value && valorE != DBNull.Value)
                    {
                        int valorPInt = Convert.ToInt32(valorP);
                        int valorEInt = Convert.ToInt32(valorE);
                        int d = valorPInt * valorEInt;
                        DataGridFase3.Rows[e.RowIndex].Cells["D"].Value = d;
                    }
                }
                else if (e.ColumnIndex == DataGridFase3.Columns["C"].Index || e.ColumnIndex == DataGridFase3.Columns["D"].Index)
                {
                    // Verificar si las celdas contienen valores válidos antes de realizar cálculos
                    object valorC = DataGridFase3.Rows[e.RowIndex].Cells["C"].Value;
                    object valorD = DataGridFase3.Rows[e.RowIndex].Cells["D"].Value;

                    if (valorC != DBNull.Value && valorD != DBNull.Value)
                    {
                        int valorCInt = Convert.ToInt32(valorC);
                        int valorDInt = Convert.ToInt32(valorD);
                        int pb = valorCInt + valorDInt;
                        DataGridFase3.Rows[e.RowIndex].Cells["PB"].Value = pb;
                    }
                }
                else if (e.ColumnIndex == DataGridFase3.Columns["A"].Index || e.ColumnIndex == DataGridFase3.Columns["V"].Index)
                {
                    // Verificar si la celda "V" contiene un valor válido antes de realizar el cálculo
                    object valorV = DataGridFase3.Rows[e.RowIndex].Cells["V"].Value;

                    if (valorV != DBNull.Value)
                    {
                        int valorA = Convert.ToInt32(DataGridFase3.Rows[e.RowIndex].Cells["A"].Value);
                        int valorVInt = Convert.ToInt32(valorV);
                        int er = valorA * valorVInt;
                        DataGridFase3.Rows[e.RowIndex].Cells["ER"].Value = er;
                    }

                }
            }
        }
        private void DataGridFase3_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string columnName = DataGridFase3.Columns[e.ColumnIndex].Name;
                if (columnName == "S" || columnName == "F" || columnName == "P" || columnName == "A" || columnName == "V" || columnName == "E")
                {
                    object value = e.Value;

                    // Verificar si el valor es DBNull
                    if (value == DBNull.Value)
                    {
                        // Puedes proporcionar un valor predeterminado o un valor en blanco
                        value = 0; // Por ejemplo, establecemos el valor predeterminado como 0
                    }

                    int valor = Convert.ToInt32(value);
                    EstablecerColorEnCelda(DataGridFase3.Rows[e.RowIndex].Cells[e.ColumnIndex], valor);
                }
            }
        }

        private void DataGridFase4_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Clasificar la gravedad en DataGridFase4
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == DataGridFase4.Columns["ER"].Index)
                {
                    int valorER = Convert.ToInt32(DataGridFase4.Rows[e.RowIndex].Cells["ER"].Value);
                    string gravedad = "";
                    if (valorER >= 2 && valorER <= 250)
                        gravedad = "Muy pequeña";
                    else if (valorER >= 251 && valorER <= 500)
                        gravedad = "Pequeña";
                    else if (valorER >= 501 && valorER <= 750)
                        gravedad = "Normal";
                    else if (valorER >= 751 && valorER <= 1000)
                        gravedad = "Grave";
                    else if (valorER >= 1001 && valorER <= 1500)
                        gravedad = "Muy Grave";

                    DataGridFase4.Rows[e.RowIndex].Cells["Gravedad"].Value = gravedad;
                }
            }
        }
        private void DataGridFase4_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string columnName = DataGridFase4.Columns[e.ColumnIndex].Name;
                if (columnName == "S" || columnName == "F" || columnName == "P" || columnName == "A" || columnName == "V" || columnName == "E")
                {
                    object value = e.Value;

                    // Verificar si el valor es DBNull
                    if (value == DBNull.Value)
                    {
                        // Puedes proporcionar un valor predeterminado o un valor en blanco
                        value = 0; // Por ejemplo, establecemos el valor predeterminado como 0
                    }

                    int valor = Convert.ToInt32(value);
                    EstablecerColorEnCelda(DataGridFase4.Rows[e.RowIndex].Cells[e.ColumnIndex], valor);
                }
            }
        }

            private void TransferirCalculosDesdeFase3()
        {
            dataTableFase4.Clear();

            foreach (DataRow row in dataTableFase3.Rows)
            {
                DataRow newRow = dataTableFase4.NewRow();
                for (int i = 0; i < dataTableFase3.Columns.Count; i++)
                {
                    if (i == DataGridFase3.Columns["S"].Index || i == DataGridFase3.Columns["F"].Index ||
                        i == DataGridFase3.Columns["P"].Index || i == DataGridFase3.Columns["A"].Index ||
                        i == DataGridFase3.Columns["V"].Index || i == DataGridFase3.Columns["E"].Index ||
                        i == DataGridFase3.Columns["C"].Index || i == DataGridFase3.Columns["D"].Index ||
                        i == DataGridFase3.Columns["PB"].Index || i == DataGridFase3.Columns["ER"].Index)
                    {
                        if (row[i] is int)
                        {
                            newRow[i] = row[i];
                        }
                        else if (row[i] is DBNull)
                        {
                            newRow[i] = DBNull.Value;
                        }
                    }
                    else
                    {
                        newRow[i] = row[i];
                    }
                }
                dataTableFase4.Rows.Add(newRow);
            }
        }
    }
}
