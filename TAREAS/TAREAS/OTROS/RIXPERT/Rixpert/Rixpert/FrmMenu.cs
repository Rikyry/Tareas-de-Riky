using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using LiteDB;

namespace Rixpert
{
    public partial class FrmMenu : Form
    {
        private string dbPath = "myData.db"; // Ruta para la base de datos LiteDB
        private LiteDatabase db;
        private int currentPhase = 1; // Variable para rastrear la fase actual
        private DataTable dataTableFase1; // Tabla para almacenar los datos de la primera fase
        private DataTable dataTableFase2; // Tabla para almacenar los datos de la segunda fase

        public FrmMenu()
        {
            InitializeComponent();
            db = new LiteDatabase(dbPath);
            ControlFases.Selected += ControlFases_Selected;

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
            BtGuardar2.Click += BtGuardar2_Click;
            BtnGuardar3.Click += BtnGuardar3_Click;
            BtnGuardar4.Click += BtnGuardar4_Click;

            // Inicializar la tabla para la primera fase
            dataTableFase1 = new DataTable();
            DataGridFase1.DataSource = dataTableFase1;

            // Inicializar la tabla para la segunda fase
            dataTableFase2 = new DataTable();
            DataGridFase2.DataSource = dataTableFase2;

            // Configurar la Fase 2 para que la columna ID sea de solo lectura
            if (DataGridFase2.Columns["ID"] != null)
            {
                DataGridFase2.Columns["ID"].ReadOnly = true;
            }

            // Agregar las columnas a la tabla de la Fase 2
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

            // Llenar las demás DataGridView con datos de ejemplo (esto puede variar dependiendo de tus necesidades)
            DataGridFase3.DataSource = new DataTable();
            DataGridFase4.DataSource = new DataTable();
        }

        private void ControlFases_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == FrmFase01)
            {
                currentPhase = 1;
                BtnFase01.Enabled = true;
                BtnFase02.Enabled = false;
                BtnFase03.Enabled = false;
                BtnFase04.Enabled = false;
            }
            else if (e.TabPage == FrmFase02)
            {
                currentPhase = 2;
                BtnFase01.Enabled = false;
                BtnFase02.Enabled = true;
                BtnFase03.Enabled = false;
                BtnFase04.Enabled = false;
            }
            else if (e.TabPage == FrmFase03)
            {
                currentPhase = 3;
                BtnFase01.Enabled = false;
                BtnFase02.Enabled = false;
                BtnFase03.Enabled = true;
                BtnFase04.Enabled = false;
            }
            else if (e.TabPage == FrmFase04)
            {
                currentPhase = 4;
                BtnFase01.Enabled = false;
                BtnFase02.Enabled = false;
                BtnFase03.Enabled = false;
                BtnFase04.Enabled = true;
            }

            CargarContenidoDesdeDB();
        }

        private void PictureCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool maximizado = false;
        private void PictureMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void PictureReposo_Click(object sender, EventArgs e)
        {

        }

        private void DataGridFase1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DataGridFase1.Columns["Riesgo"].Index)
            {
                // Generar el ID basado en la primera inicial del Riesgo y la cantidad de vocales
                string riesgo = DataGridFase1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Trim();
                if (!string.IsNullOrEmpty(riesgo))
                {
                    string primeraInicial = riesgo.Substring(0, 1).ToUpper();
                    int cantidadVocales = ContarVocales(riesgo);
                    string id = primeraInicial + cantidadVocales.ToString("00");
                    DataGridFase1.Rows[e.RowIndex].Cells["ID"].Value = id;
                }
            }
        }

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

        private void DataGridFase2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Actualizar el color de las celdas en la columna "S", "F", "P", "A", "V" y "E"
            if (e.ColumnIndex >= DataGridFase2.Columns["S"].Index && e.ColumnIndex <= DataGridFase2.Columns["E"].Index)
            {
                int valor = Convert.ToInt32(DataGridFase2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                Color color = valor switch
                {
                    1 => Color.FromArgb(49, 189, 79), // Verde
                    2 => Color.FromArgb(255, 255, 0), // Amarillo
                    3 => Color.FromArgb(255, 165, 0), // Naranja
                    4 => Color.FromArgb(255, 69, 0), // Rojo
                    5 => Color.FromArgb(128, 0, 0), // Marrón
                    _ => Color.White,
                };
                DataGridFase2.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = color;
            }
        }

        private void BtnFase01_Click(object sender, EventArgs e)
        {
            ControlFases.SelectedTab = FrmFase01;
        }

        private void BtnFase02_Click(object sender, EventArgs e)
        {
            ControlFases.SelectedTab = FrmFase02;
        }

        private void BtnFase03_Click(object sender, EventArgs e)
        {
            ControlFases.SelectedTab = FrmFase03;
        }

        private void BtnFase04_Click(object sender, EventArgs e)
        {
            ControlFases.SelectedTab = FrmFase04;
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

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            CargarContenidoDesdeDB();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (currentPhase == 1)
            {
                BtnFase01.BackColor = Color.FromArgb(49, 189, 79);
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

        private void GridViewFase2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GridViewFase3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GridViewFase4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

