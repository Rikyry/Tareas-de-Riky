using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using LiteDB;
using System.IO;
using System.ComponentModel;

namespace Rixpert
{
    public partial class FrmMenu : Form
    {
        private string dbPath = "Risxpert.db"; // Ruta para la base de datos LiteDB
        private LiteDatabase database;
        private int currentPhase = 1; // Variable para rastrear la fase actual
        private DataTable dataTableFase1; // Tabla para almacenar los datos de la primera fase
        private DataTable dataTableFase2; // Tabla para almacenar los datos de la segunda fase
        private DataTable dataTableFase3; // Tabla para almacenar los datos de la tercera fase
        private DataTable dataTableFase4; // Tabla para almacenar los datos de la cuarta fase

         // Clase para almacenar los datos
        public class DataItem
        {
            public string ID { get; set; }
            public string ANALISTA { get; set; }
            public string RIESGO { get; set; }
            public string ACTIVO { get; set; }
            public string DAÑO { get; set; }
        }

        public FrmMenu()
        {
            InitializeComponent();
            database = new LiteDatabase("Risk.db"); // Crear o abrir la base de datos "Risk.db"

            TxtAnalista1.TextChanged += TxtAnalista1_TextChanged;

            ControlFases.Selected += ControlFases_Selected;

            BtnFase01.Click += BtnFase01_Click;
            BtnFase02.Click += BtnFase02_Click;
            BtnFase03.Click += BtnFase03_Click;
            BtnFase04.Click += BtnFase04_Click;

            BtnContinuar1.Click += BtnContinuar1_Click;
            BtnContinuar2.Click += BtnContinuar2_Click;
            BtnContinuar3.Click += BtnContinuar3_Click;
            BtnContinuar4.Click += BtnContinuar4_Click; 

            // Agregar columnas a DataGridFase1
            dataTableFase1 = new DataTable();
            dataTableFase1.Columns.Add("ID", typeof(string));
            dataTableFase1.Columns.Add("ANALISTA", typeof(string));
            dataTableFase1.Columns.Add("RIESGO", typeof(string));
            dataTableFase1.Columns.Add("ACTIVO", typeof(string));
            dataTableFase1.Columns.Add("DAÑO", typeof(string));

            // Agregar columnas a DataGridFase2
            dataTableFase2 = new DataTable();
            dataTableFase2.Columns.Add("ID", typeof(string));
            dataTableFase2.Columns.Add("ANALISTA", typeof(string));
            dataTableFase2.Columns.Add("RIESGO", typeof(string));
            dataTableFase2.Columns.Add("ACTIVO", typeof(string));
            dataTableFase2.Columns.Add("DAÑO", typeof(string));
            dataTableFase2.Columns.Add("S", typeof(int));
            dataTableFase2.Columns.Add("F", typeof(int));
            dataTableFase2.Columns.Add("P", typeof(int));
            dataTableFase2.Columns.Add("A", typeof(int));
            dataTableFase2.Columns.Add("V", typeof(int));
            dataTableFase2.Columns.Add("E", typeof(int));

            // Agregar columnas a DataGridFase3
            dataTableFase3 = new DataTable();
            dataTableFase3.Columns.Add("ID", typeof(string));
            dataTableFase3.Columns.Add("ANALISTA", typeof(string));
            dataTableFase3.Columns.Add("RIESGO", typeof(string));
            dataTableFase3.Columns.Add("ACTIVO", typeof(string));
            dataTableFase3.Columns.Add("DAÑO", typeof(string));
            dataTableFase3.Columns.Add("S", typeof(int));
            dataTableFase3.Columns.Add("F", typeof(int));
            dataTableFase3.Columns.Add("P", typeof(int));
            dataTableFase3.Columns.Add("A", typeof(int));
            dataTableFase3.Columns.Add("V", typeof(int));
            dataTableFase3.Columns.Add("E", typeof(int));
            dataTableFase3.Columns.Add("I", typeof(int));
            dataTableFase3.Columns.Add("D", typeof(int));
            dataTableFase3.Columns.Add("C", typeof(int));
            dataTableFase3.Columns.Add("PB", typeof(int));
            dataTableFase3.Columns.Add("ER", typeof(int));

            // Agregar columnas a DataGridFase4
            dataTableFase4 = new DataTable();
            dataTableFase4.Columns.Add("ID", typeof(string));
            dataTableFase4.Columns.Add("ANALISTA", typeof(string));
            dataTableFase4.Columns.Add("RIESGO", typeof(string));
            dataTableFase4.Columns.Add("ACTIVO", typeof(string));
            dataTableFase4.Columns.Add("DAÑO", typeof(string));
            dataTableFase4.Columns.Add("S", typeof(int));
            dataTableFase4.Columns.Add("F", typeof(int));
            dataTableFase4.Columns.Add("P", typeof(int));
            dataTableFase4.Columns.Add("A", typeof(int));
            dataTableFase4.Columns.Add("V", typeof(int));
            dataTableFase4.Columns.Add("E", typeof(int));
            dataTableFase4.Columns.Add("I", typeof(int));
            dataTableFase4.Columns.Add("D", typeof(int));
            dataTableFase4.Columns.Add("C", typeof(int));
            dataTableFase4.Columns.Add("PB", typeof(int));
            dataTableFase4.Columns.Add("ER", typeof(int));
            dataTableFase4.Columns.Add("GRAVEDAD", typeof(string));
            dataTableFase4.Columns.Add("MITIGACIÓN", typeof(string));

            // Asignar los DataTable a las DataGridView correspondientes
            DataGridFase1.DataSource = dataTableFase1;
            DataGridFase2.DataSource = dataTableFase2;
            DataGridFase3.DataSource = dataTableFase3;
            DataGridFase4.DataSource = dataTableFase4;

            // Establecer las columnas no editables en DataGridFase1
            DataGridFase1.Columns["ID"].ReadOnly = true;
            DataGridFase1.Columns["ANALISTA"].ReadOnly = false;
            DataGridFase1.Columns["RIESGO"].ReadOnly = false;
            DataGridFase1.Columns["ACTIVO"].ReadOnly = false;
            DataGridFase1.Columns["DAÑO"].ReadOnly = false;

            // Establecer las columnas no editables en DataGridFase2
            DataGridFase2.Columns["ID"].ReadOnly = true;
            DataGridFase2.Columns["ANALISTA"].ReadOnly = true;
            DataGridFase2.Columns["RIESGO"].ReadOnly = true;
            DataGridFase2.Columns["ACTIVO"].ReadOnly = true;
            DataGridFase2.Columns["DAÑO"].ReadOnly = true;
            DataGridFase2.Columns["S"].ReadOnly = false;
            DataGridFase2.Columns["F"].ReadOnly = false;
            DataGridFase2.Columns["P"].ReadOnly = false;
            DataGridFase2.Columns["A"].ReadOnly = false;
            DataGridFase2.Columns["V"].ReadOnly = false;
            DataGridFase2.Columns["E"].ReadOnly = false;


            // Establecer las columnas no editables en DataGridFase3
            DataGridFase3.Columns["ID"].ReadOnly = true;
            DataGridFase3.Columns["ANALISTA"].ReadOnly = true;
            DataGridFase3.Columns["RIESGO"].ReadOnly = true;
            DataGridFase3.Columns["ACTIVO"].ReadOnly = true;
            DataGridFase3.Columns["DAÑO"].ReadOnly = true;
            DataGridFase3.Columns["S"].ReadOnly = true;
            DataGridFase3.Columns["F"].ReadOnly = true;
            DataGridFase3.Columns["P"].ReadOnly = true;
            DataGridFase3.Columns["A"].ReadOnly = true;
            DataGridFase3.Columns["V"].ReadOnly = true;
            DataGridFase3.Columns["E"].ReadOnly = true;
            DataGridFase3.Columns["I"].ReadOnly = true;
            DataGridFase3.Columns["D"].ReadOnly = true;
            DataGridFase3.Columns["C"].ReadOnly = true;
            DataGridFase3.Columns["PB"].ReadOnly = true;
            DataGridFase3.Columns["ER"].ReadOnly = true;

            // Establecer las columnas no editables en DataGridFase4
            DataGridFase4.Columns["ID"].ReadOnly = true;
            DataGridFase4.Columns["ANALISTA"].ReadOnly = true;
            DataGridFase4.Columns["RIESGO"].ReadOnly = true;
            DataGridFase4.Columns["ACTIVO"].ReadOnly = true;
            DataGridFase4.Columns["DAÑO"].ReadOnly = true;
            DataGridFase4.Columns["S"].ReadOnly = true;
            DataGridFase4.Columns["F"].ReadOnly = true;
            DataGridFase4.Columns["P"].ReadOnly = true;
            DataGridFase4.Columns["A"].ReadOnly = true;
            DataGridFase4.Columns["V"].ReadOnly = true;
            DataGridFase4.Columns["E"].ReadOnly = true;
            DataGridFase4.Columns["I"].ReadOnly = true;
            DataGridFase4.Columns["D"].ReadOnly = true;
            DataGridFase4.Columns["C"].ReadOnly = true;
            DataGridFase4.Columns["PB"].ReadOnly = true;
            DataGridFase4.Columns["ER"].ReadOnly = true;
            DataGridFase4.Columns["GRAVEDAD"].ReadOnly = true;
            DataGridFase4.Columns["MITIGACIÓN"].ReadOnly = true;

            // Evento CellEndEdit para calcular el ID en DataGridFase1
            DataGridFase1.CellEndEdit += DataGridFase1_CellEndEdit;

            // Evento CellEndEdit para calcular el ID en DataGridFase1
            DataGridFase1.CellEndEdit += DataGridFase1_CellEndEdit;

            // Evento CellValueChanged para actualizar datos en DataGridFase1   
            DataGridFase1.CellValueChanged += DataGridFase1_CellValueChanged;

            // Evento CellValueChanged para actualizar el color en DataGridFase2
            DataGridFase2.CellValueChanged += DataGridFase2_CellValueChanged;

            // Evento CellFormatting para DataGridFase3
            DataGridFase3.CellFormatting += DataGridFase3_CellFormatting;

            // Evento CellFormatting para DataGridFase4
            DataGridFase4.CellFormatting += DataGridFase4_CellFormatting;
        }

        private void TxtAnalista1_TextChanged(object sender, EventArgs e)
        {
            string texto = TxtAnalista1.Text;
            // Actualizar los otros TextBoxes en un bloque de actualización
            TxtAnalista2.BeginInvoke(new Action(() => TxtAnalista2.Text = texto));
            TxtAnalista3.BeginInvoke(new Action(() => TxtAnalista3.Text = texto));
            TxtAnalista4.BeginInvoke(new Action(() => TxtAnalista4.Text = texto));
        }

        private void ControlFases_Selected(object sender, TabControlEventArgs e)
        {
            currentPhase = ControlFases.SelectedIndex + 1;
            BtnFase01.Enabled = currentPhase != 1;
            BtnFase02.Enabled = currentPhase != 2;
            BtnFase03.Enabled = currentPhase != 3;

            if (currentPhase == 4)
            {
                BtnFase04.Enabled = datosGuardados; // Habilitar solo si los datos se han guardado
            }
            else
            {
                BtnFase04.Enabled = false; // Deshabilitar para otras fases
            }
        }

        //Agrega filas al DataGridFase1
        private void BtnAgregar1_Click(object sender, EventArgs e)
        {
            AgregarNuevaFila();

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

        private void BtnEliminar1_Click(object sender, EventArgs e)
        {
            if (DataGridFase1.Rows.Count > 0)
            {
                // Encuentra el índice de la última fila
                int lastRowIndex = DataGridFase1.Rows.Count - 1;

                // Remueve la fila del DataGridView
                DataGridFase1.Rows.RemoveAt(lastRowIndex);
            }
            else
            {
                MessageBox.Show("No hay filas para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Boton para transferir lo del DataGridFase1 a DataGridFase2 y cambiar de Fase
        private void BtnContinuar1_Click(object sender, EventArgs e)
        {
            if (currentPhase == 1)
            {
                BtnFase01.BackColor = Color.FromArgb(49, 189, 79);

                // Transferir datos de DataGridFase1 a dataTableFase2
                foreach (DataGridViewRow row in DataGridFase1.Rows)
                {
                    DataRow newRow = dataTableFase2.NewRow();

                    // Copiar el valor de la columna ID
                    newRow["ID"] = row.Cells["ID"].Value;

                    // Copiar las celdas editables (las que no son ReadOnly)
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (!cell.ReadOnly && cell.OwningColumn.Name != "ID")
                        {
                            newRow[cell.OwningColumn.Name] = cell.Value;
                        }
                    }

                    // Agregar la nueva fila al dataTableFase2
                    dataTableFase2.Rows.Add(newRow);
                }
            }

            // Realizar el proceso de guardar para la fase 01
            faseMaximaAlcanzada = Math.Max(faseMaximaAlcanzada, 1);
            HabilitarBotonesFase();

            // Solo avanzar a la fase 2 si se hizo clic en el botón de guardar de la fase 1
            if (currentPhase == 1)
            {
                currentPhase++;
                ControlFases.SelectedIndex = currentPhase - 1;
            }
        }

        private void BtnContinuar2_Click(object sender, EventArgs e)
        {
            for (int rowIndex = 0; rowIndex < DataGridFase2.Rows.Count; rowIndex++)
            {
                if (!RequiereLlenarTodasLasCeldas(rowIndex))
                {
                    MessageBox.Show("Debe completar todas las celdas requeridas (S, F, P, A, V, E) antes de guardar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (currentPhase == 2)
            {
                BtnFase02.BackColor = Color.FromArgb(49, 189, 79);

                foreach (DataGridViewRow row in DataGridFase2.Rows)
                {
                    int S = Convert.ToInt32(row.Cells["S"].Value);
                    int F = Convert.ToInt32(row.Cells["F"].Value);
                    int P = Convert.ToInt32(row.Cells["P"].Value);
                    int A = Convert.ToInt32(row.Cells["A"].Value);
                    int V = Convert.ToInt32(row.Cells["V"].Value);
                    int E = Convert.ToInt32(row.Cells["E"].Value);

                    int I = F * S;
                    int D = P * E;
                    int C = I + D;
                    int PB = A * V;
                    int ER = C * PB;

                    DataRow newRow = dataTableFase3.NewRow();

                    newRow["ID"] = row.Cells["ID"].Value;
                    newRow["ANALISTA"] = row.Cells["ANALISTA"].Value;
                    newRow["RIESGO"] = row.Cells["RIESGO"].Value;
                    newRow["ACTIVO"] = row.Cells["ACTIVO"].Value;
                    newRow["DAÑO"] = row.Cells["DAÑO"].Value;
                    newRow["S"] = S;
                    newRow["F"] = F;
                    newRow["P"] = P;
                    newRow["A"] = A;
                    newRow["V"] = V;
                    newRow["E"] = E;
                    newRow["I"] = I;
                    newRow["D"] = D;
                    newRow["C"] = C;
                    newRow["PB"] = PB;
                    newRow["ER"] = ER;

                    dataTableFase3.Rows.Add(newRow);
                }

                // Cambiar a la pestaña de DataGridFase3 después de guardar
                ControlFases.SelectedIndex = 2; // Cambiar al índice de la pestaña tres
            }
        }

        //Boton para transferir lo del DataGridFase3 a DataGridFase4 y cambiar de Fase
        private void BtnContinuar3_Click(object sender, EventArgs e)
        {
            if (currentPhase == 3)
            {
                BtnFase03.BackColor = Color.FromArgb(49, 189, 79);

                // Transferir datos de DataGridFase3 a DataGridFase4
                TransferirCalculosDesdeFase3();

                // Calcular y mostrar la clasificación de gravedad en DataGridFase4
                CalcularYMostrarGravedadEnDataGridFase4();
            }

            // Solo avanzar a la fase 4 si se hizo clic en el botón de guardar de la fase 3
            if (currentPhase == 3)
            {
                currentPhase++;
                ControlFases.SelectedIndex = currentPhase - 1;
            }
        }

        private void BtnContinuar4_Click(object sender, EventArgs e)
        {
            if (currentPhase == 4)
            {
                if (datosGuardados)
                {
                    BtnFase04.BackColor = Color.FromArgb(49, 189, 79);

                    // Eliminar la fila agregada por BtnCargar1 en DataGridFase1
                    if (DataGridFase1.Rows.Count > 0)
                    {
                        // Encuentra el índice de la última fila
                        int lastRowIndex = DataGridFase1.Rows.Count - 1;

                        // Remueve la fila del DataGridView
                        DataGridFase1.Rows.RemoveAt(lastRowIndex);
                    }

                    // Limpiar y regresar a la fase 1
                    LimpiarDataGridFase1YVolverAFase1();
                }
                else
                {
                    MessageBox.Show("Debes guardar los datos antes de continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        //Abre el menu donde se ingresa el ID para presentar algun riesgo guardado
        private void BtnCargar1_Click(object sender, EventArgs e)
        {
            string enteredID = PromptForID();
            if (!string.IsNullOrEmpty(enteredID))
            {
                var collection = database.GetCollection("Risk");
                var data = collection.FindOne(Query.EQ("ID", enteredID));

                if (data != null)
                {
                    // Limpiar cualquier filtro de DataGridFase1
                    if (DataGridFase1.DataSource is BindingSource bindingSource)
                    {
                        bindingSource.Filter = "";
                    }

                    // Limpiar la selección de filas
                    DataGridFase1.ClearSelection();

                    // Agregar datos al DataGridFase1 utilizando un BindingList
                    var dataList = new BindingList<DataItem>();
                    dataList.Add(new DataItem
                    {
                        ID = data["ID"].AsString,
                        ANALISTA = data["ANALISTA"].AsString,
                        RIESGO = data["RIESGO"].AsString,
                        ACTIVO = data["ACTIVO"].AsString,
                        DAÑO = data["DAÑO"].AsString
                    });

                    // Establecer el DataSource del DataGridFase1
                    DataGridFase1.DataSource = new BindingSource(dataList, null);
                }
                else
                {
                    MessageBox.Show("ID no encontrado en la base de datos.");
                }
            }
        }

        private void LimpiarDataGridFase1YVolverAFase1()
        {
            // Limpia el DataGridFase1
            dataTableFase1.Clear();

            // Limpia el DataGridFase2
            dataTableFase2.Clear();

            // Limpia el DataGridFase3
            dataTableFase3.Clear();

            // Limpia el DataGridFase4
            dataTableFase4.Clear();

            datosGuardados = false; // Restablecer a no guardados

            // Cambia a la primera fase
            currentPhase = 1;
            ControlFases.SelectedTab = FrmFase01;
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

        private int faseMaximaAlcanzada = 1;
        private void BtnFase01_Click(object sender, EventArgs e)
        {
            currentPhase = 1;
            ControlFases.SelectedTab = FrmFase01;
            HabilitarBotonesFase();
        }

        private void BtnFase02_Click(object sender, EventArgs e)
        {
            if (faseMaximaAlcanzada >= 2)
            {
                currentPhase = 2;
                ControlFases.SelectedTab = FrmFase02;
                HabilitarBotonesFase();
            }
            else
            {
                MessageBox.Show("Completa las fases anteriores antes de pasar a la Fase 02.");
            }
        }

        private void BtnFase03_Click(object sender, EventArgs e)
        {
            if (faseMaximaAlcanzada >= 3)
            {
                currentPhase = 3;
                ControlFases.SelectedTab = FrmFase03;
                HabilitarBotonesFase();
            }
            else
            {
                MessageBox.Show("Completa las fases anteriores antes de pasar a la Fase 03.");
            }
        }

        private void BtnFase04_Click(object sender, EventArgs e)
        {
            if (faseMaximaAlcanzada >= 4)
            {
                currentPhase = 4;
                ControlFases.SelectedTab = FrmFase04;
                HabilitarBotonesFase();
            }
            else
            {
                MessageBox.Show("Completa las fases anteriores antes de pasar a la Fase 04.");
            }
        }

        private void HabilitarBotonesFase()
        {
            BtnFase01.Enabled = faseMaximaAlcanzada >= 1;
            BtnFase02.Enabled = faseMaximaAlcanzada >= 2;
            BtnFase03.Enabled = faseMaximaAlcanzada >= 3;
            BtnFase04.Enabled = faseMaximaAlcanzada >= 4;
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            HabilitarBotonesFase();
        }

        private void CalcularYMostrarGravedadEnDataGridFase4()
        {
            foreach (DataGridViewRow row in DataGridFase4.Rows)
            {
                int valorER = Convert.ToInt32(row.Cells["ER"].Value);
                string gravedad = CalcularClasificacionGravedad(valorER);
                row.Cells["Gravedad"].Value = gravedad;
            }
        }

        private string CalcularClasificacionGravedad(int valorER)
        {
            if (valorER >= 2 && valorER <= 250)
                return "Muy pequeña";
            else if (valorER >= 251 && valorER <= 500)
                return "Pequeña";
            else if (valorER >= 501 && valorER <= 750)
                return "Normal";
            else if (valorER >= 751 && valorER <= 1000)
                return "Grave";
            else if (valorER >= 1001 && valorER <= 1500)
                return "Muy Grave";

            return string.Empty;
        }

        // Asignar los colores según el valor
        private Color ObtenerColorPorValor(int valor)
        {
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

        private void DataGridFase1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == DataGridFase1.Columns["ANALISTA"].Index)
            {
                string analistaValue = DataGridFase1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                TxtAnalista1.Text = analistaValue;
            }
        }

        private List<object> nuevaFilaDataGridFase1 = new List<object>();
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

        private void DataGridFase2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= DataGridFase2.Columns["S"].Index && e.ColumnIndex <= DataGridFase2.Columns["E"].Index)
            {
                UpdateCellColor(e.RowIndex, e.ColumnIndex);
            }
        }

        private void UpdateCellColor(int rowIndex, int columnIndex)
        {
            object cellValue = DataGridFase2.Rows[rowIndex].Cells[columnIndex].Value;
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

            DataGridFase2.Rows[rowIndex].Cells[columnIndex].Style.BackColor = color;
        }

        private bool RequiereLlenarTodasLasCeldas(int rowIndex)
        {
            DataGridViewRow dataGridFase2Row = DataGridFase2.Rows[rowIndex];
            return dataGridFase2Row.Cells["S"].Value != DBNull.Value &&
            dataGridFase2Row.Cells["F"].Value != DBNull.Value &&
            dataGridFase2Row.Cells["P"].Value != DBNull.Value &&
            dataGridFase2Row.Cells["A"].Value != DBNull.Value &&
            dataGridFase2Row.Cells["V"].Value != DBNull.Value &&
            dataGridFase2Row.Cells["E"].Value != DBNull.Value;
        }

        private void DataGridFase2_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex >= DataGridFase2.Columns["S"].Index && e.ColumnIndex <= DataGridFase2.Columns["E"].Index)
            {
                string inputValue = e.FormattedValue.ToString();

                // Try to parse the input value as an integer
                if (!int.TryParse(inputValue, out int numericValue))
                {
                    e.Cancel = true; // Cancel the edit if the value is not numeric
                    MessageBox.Show("Inserte valor numérico.", "Valor no Válido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if the value is within the desired range (1 to 5)
                if (numericValue < 1 || numericValue > 5)
                {
                    e.Cancel = true; // Cancel the edit if the value is not within the desired range
                    MessageBox.Show("Inserte valor entre 1 y 5.", "Valor no Válido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DataGridFase3_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = DataGridFase3.Rows[e.RowIndex];
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

        private void AgregarNuevaFila()
        {
            // Crear un nuevo objeto para representar la fila
            DataRow nuevaFila = ((DataTable)DataGridFase1.DataSource).NewRow();

            // Agregar la nueva fila a la fuente de datos (DataTable)
            ((DataTable)DataGridFase1.DataSource).Rows.Add(nuevaFila);

            // Actualizar el DataGridView para reflejar los cambios
            DataGridFase1.Refresh();
        }

        private bool datosGuardados = false;
        private void BtnGuardar1_Click(object sender, EventArgs e)
        {
            var collection = database.GetCollection("Risk");

            foreach (DataRow dataRow in dataTableFase4.Rows)
            {
                string id = dataRow["ID"].ToString();

                var existingData = collection.FindOne(Query.EQ("ID", id));

                if (existingData != null)
                {
                    // Si existe, actualiza los valores de los parámetros modificados
                    existingData["ANALISTA"] = dataRow["ANALISTA"].ToString();
                    existingData["RIESGO"] = dataRow["RIESGO"].ToString();
                    existingData["ACTIVO"] = dataRow["ACTIVO"].ToString();
                    existingData["DAÑO"] = dataRow["DAÑO"].ToString();
                    // ... actualizar otros campos si es necesario

                    collection.Update(existingData);
                }
                else
                {
                    // Si no existe, crea una nueva entrada en la base de datos
                    var newData = new BsonDocument
            {
                { "ID", id },
                { "ANALISTA", dataRow["ANALISTA"].ToString() },
                { "RIESGO", dataRow["RIESGO"].ToString() },
                { "ACTIVO", dataRow["ACTIVO"].ToString() },
                { "DAÑO", dataRow["DAÑO"].ToString() },
                // ... otros campos
            };

                    collection.Insert(newData);
                }
            }
            datosGuardados = true; // Marcar los datos como guardados
            MessageBox.Show("Datos guardados en la base de datos.");
        }

        //Menu para ingresar ID y cargarlo
        private string PromptForID()
        {
            using (Form prompt = new Form())
            {
                prompt.Width = 300;
                prompt.Height = 150;
                prompt.Text = "Ingresar ID";
                prompt.BackColor = Color.FromArgb(64, 69, 76); // Color de fondo

                Label lblID = new Label() { Left = 20, Top = 20, Text = "ID:", ForeColor = Color.White };
                TextBox txtID = new TextBox() { Left = 120, Top = 20, Width = 150, PasswordChar = '\0', MaxLength = 0 };

                // Valor predeterminado y manejo de evento TextChanged
                string defaultValue = "#"; // Cambia esto al valor predeterminado deseado
                txtID.Text = defaultValue;

                txtID.TextChanged += (sender, e) =>
                {
                    if (txtID.Text == "")
                    {
                        txtID.Text = defaultValue;
                        txtID.Select(txtID.Text.Length, 0); // Coloca el cursor al final
                    }
                };

                Button confirmBtn = new Button() { Text = "Confirmar", Left = 110, Width = 80, Top = txtID.Bottom + 20, DialogResult = DialogResult.OK, BackColor = Color.FromArgb(60, 120, 85), ForeColor = Color.White };
                Button cancelBtn = new Button() { Text = "Cancelar", Left = 200, Width = 80, Top = txtID.Bottom + 20, DialogResult = DialogResult.Cancel, BackColor = Color.FromArgb(60, 120, 85), ForeColor = Color.White };

                confirmBtn.Click += (sender, e) => prompt.Close();
                cancelBtn.Click += (sender, e) => prompt.Close();

                prompt.Controls.Add(lblID);
                prompt.Controls.Add(txtID);
                prompt.Controls.Add(confirmBtn);
                prompt.Controls.Add(cancelBtn);

                prompt.AcceptButton = confirmBtn;
                prompt.CancelButton = cancelBtn;

                // Configuración para centrar el formulario en la pantalla
                prompt.StartPosition = FormStartPosition.CenterScreen;

                return prompt.ShowDialog() == DialogResult.OK ? txtID.Text : null;
            }
        }

        private void PictureCerrar_Click(object sender, EventArgs e)
        {
            // Cierra la aplicación
            Application.Exit();
        }
        private void DataGridFase1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            ActualizarEstadoBotonContinuar();
        }

        private void DataGridFase1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            ActualizarEstadoBotonContinuar();
        }

        private void ActualizarEstadoBotonContinuar()
        {
            if (DataGridFase1.Rows.Count > 0)
            {
                BtnContinuar1.Enabled = true; // Habilitar el botón si hay filas en el DataGrid
            }
            else
            {
                BtnContinuar1.Enabled = false; // Deshabilitar el botón si no hay filas en el DataGrid
            }
        }
    }
}

