using System;
using System.Windows.Forms;

namespace Rixpert
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.PictureReposo = new System.Windows.Forms.PictureBox();
            this.PictureMinimizarYMaximinar = new System.Windows.Forms.PictureBox();
            this.Rixpert = new System.Windows.Forms.Label();
            this.PictureCerrar = new System.Windows.Forms.PictureBox();
            this.TxtAnalista1 = new System.Windows.Forms.TextBox();
            this.ControlFases = new System.Windows.Forms.TabControl();
            this.FrmFase01 = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.LbFase1 = new System.Windows.Forms.Label();
            this.BtnAgregar1 = new System.Windows.Forms.Button();
            this.BtnEliminar1 = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.DataGridFase1 = new System.Windows.Forms.DataGridView();
            this.FrmFase02 = new System.Windows.Forms.TabPage();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.TxtAnalista2 = new System.Windows.Forms.TextBox();
            this.LbFase2 = new System.Windows.Forms.Label();
            this.BtnGuardar2 = new System.Windows.Forms.Button();
            this.DataGridFase2 = new System.Windows.Forms.DataGridView();
            this.FrmFase03 = new System.Windows.Forms.TabPage();
            this.BtnGuardar3 = new System.Windows.Forms.Button();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.TxtAnalista3 = new System.Windows.Forms.TextBox();
            this.LbFase3 = new System.Windows.Forms.Label();
            this.DataGridFase3 = new System.Windows.Forms.DataGridView();
            this.FrmFase04 = new System.Windows.Forms.TabPage();
            this.BtnGuardar4 = new System.Windows.Forms.Button();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.TxtAnalista4 = new System.Windows.Forms.TextBox();
            this.LbFase4 = new System.Windows.Forms.Label();
            this.DataGridFase4 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.BtnFase01 = new System.Windows.Forms.Button();
            this.BtnFase02 = new System.Windows.Forms.Button();
            this.BtnFase03 = new System.Windows.Forms.Button();
            this.BtnFase04 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.FrmFase3 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureReposo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureMinimizarYMaximinar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureCerrar)).BeginInit();
            this.ControlFases.SuspendLayout();
            this.FrmFase01.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridFase1)).BeginInit();
            this.FrmFase02.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridFase2)).BeginInit();
            this.FrmFase03.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridFase3)).BeginInit();
            this.FrmFase04.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridFase4)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel3;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.panel3.Controls.Add(this.FrmFase3);
            this.panel3.Controls.Add(this.PictureReposo);
            this.panel3.Controls.Add(this.PictureMinimizarYMaximinar);
            this.panel3.Controls.Add(this.Rixpert);
            this.panel3.Controls.Add(this.PictureCerrar);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1200, 112);
            this.panel3.TabIndex = 1;
            // 
            // PictureReposo
            // 
            this.PictureReposo.Image = ((System.Drawing.Image)(resources.GetObject("PictureReposo.Image")));
            this.PictureReposo.Location = new System.Drawing.Point(868, 39);
            this.PictureReposo.Name = "PictureReposo";
            this.PictureReposo.Size = new System.Drawing.Size(24, 24);
            this.PictureReposo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureReposo.TabIndex = 8;
            this.PictureReposo.TabStop = false;
            // 
            // PictureMinimizarYMaximinar
            // 
            this.PictureMinimizarYMaximinar.Image = ((System.Drawing.Image)(resources.GetObject("PictureMinimizarYMaximinar.Image")));
            this.PictureMinimizarYMaximinar.Location = new System.Drawing.Point(898, 39);
            this.PictureMinimizarYMaximinar.Name = "PictureMinimizarYMaximinar";
            this.PictureMinimizarYMaximinar.Size = new System.Drawing.Size(24, 24);
            this.PictureMinimizarYMaximinar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureMinimizarYMaximinar.TabIndex = 6;
            this.PictureMinimizarYMaximinar.TabStop = false;
            // 
            // Rixpert
            // 
            this.Rixpert.AutoSize = true;
            this.Rixpert.Font = new System.Drawing.Font("Monoton", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rixpert.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Rixpert.Location = new System.Drawing.Point(17, 8);
            this.Rixpert.Name = "Rixpert";
            this.Rixpert.Size = new System.Drawing.Size(361, 100);
            this.Rixpert.TabIndex = 5;
            this.Rixpert.Text = "RIXPERT";
            // 
            // PictureCerrar
            // 
            this.PictureCerrar.Image = ((System.Drawing.Image)(resources.GetObject("PictureCerrar.Image")));
            this.PictureCerrar.Location = new System.Drawing.Point(928, 39);
            this.PictureCerrar.Name = "PictureCerrar";
            this.PictureCerrar.Size = new System.Drawing.Size(24, 24);
            this.PictureCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureCerrar.TabIndex = 4;
            this.PictureCerrar.TabStop = false;
            // 
            // TxtAnalista1
            // 
            this.TxtAnalista1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.TxtAnalista1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAnalista1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.TxtAnalista1.Location = new System.Drawing.Point(26, 75);
            this.TxtAnalista1.Multiline = true;
            this.TxtAnalista1.Name = "TxtAnalista1";
            this.TxtAnalista1.Size = new System.Drawing.Size(193, 33);
            this.TxtAnalista1.TabIndex = 13;
            this.TxtAnalista1.Text = "Analista";
            this.TxtAnalista1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ControlFases
            // 
            this.ControlFases.Controls.Add(this.FrmFase01);
            this.ControlFases.Controls.Add(this.FrmFase02);
            this.ControlFases.Controls.Add(this.FrmFase03);
            this.ControlFases.Controls.Add(this.FrmFase04);
            this.ControlFases.Location = new System.Drawing.Point(10, 89);
            this.ControlFases.Multiline = true;
            this.ControlFases.Name = "ControlFases";
            this.ControlFases.SelectedIndex = 0;
            this.ControlFases.Size = new System.Drawing.Size(969, 620);
            this.ControlFases.TabIndex = 3;
            // 
            // FrmFase01
            // 
            this.FrmFase01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.FrmFase01.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FrmFase01.Controls.Add(this.dateTimePicker1);
            this.FrmFase01.Controls.Add(this.TxtAnalista1);
            this.FrmFase01.Controls.Add(this.LbFase1);
            this.FrmFase01.Controls.Add(this.BtnAgregar1);
            this.FrmFase01.Controls.Add(this.BtnEliminar1);
            this.FrmFase01.Controls.Add(this.BtnGuardar);
            this.FrmFase01.Controls.Add(this.DataGridFase1);
            this.FrmFase01.Location = new System.Drawing.Point(4, 22);
            this.FrmFase01.Name = "FrmFase01";
            this.FrmFase01.Padding = new System.Windows.Forms.Padding(3);
            this.FrmFase01.Size = new System.Drawing.Size(961, 594);
            this.FrmFase01.TabIndex = 0;
            this.FrmFase01.Text = "FrmFase01";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(49)))), ((int)(((byte)(79)))));
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePicker1.Location = new System.Drawing.Point(17, 114);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(214, 20);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // LbFase1
            // 
            this.LbFase1.AutoSize = true;
            this.LbFase1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbFase1.ForeColor = System.Drawing.SystemColors.Menu;
            this.LbFase1.Location = new System.Drawing.Point(743, 52);
            this.LbFase1.Name = "LbFase1";
            this.LbFase1.Size = new System.Drawing.Size(195, 55);
            this.LbFase1.TabIndex = 17;
            this.LbFase1.Text = "FASE 1";
            // 
            // BtnAgregar1
            // 
            this.BtnAgregar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(149)))), ((int)(((byte)(189)))));
            this.BtnAgregar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar1.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar1.Location = new System.Drawing.Point(735, 171);
            this.BtnAgregar1.Name = "BtnAgregar1";
            this.BtnAgregar1.Size = new System.Drawing.Size(203, 47);
            this.BtnAgregar1.TabIndex = 16;
            this.BtnAgregar1.Text = "Agregar";
            this.BtnAgregar1.UseVisualStyleBackColor = false;
            this.BtnAgregar1.Click += new System.EventHandler(this.BtnAgregar1_Click);
            // 
            // BtnEliminar1
            // 
            this.BtnEliminar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(49)))), ((int)(((byte)(79)))));
            this.BtnEliminar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar1.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar1.Location = new System.Drawing.Point(735, 241);
            this.BtnEliminar1.Name = "BtnEliminar1";
            this.BtnEliminar1.Size = new System.Drawing.Size(203, 47);
            this.BtnEliminar1.TabIndex = 15;
            this.BtnEliminar1.Text = "Eliminar";
            this.BtnEliminar1.UseVisualStyleBackColor = false;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(189)))), ((int)(((byte)(79)))));
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.Location = new System.Drawing.Point(735, 313);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(203, 47);
            this.BtnGuardar.TabIndex = 14;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // DataGridFase1
            // 
            this.DataGridFase1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            this.DataGridFase1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.DataGridFase1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridFase1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridFase1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(65)))));
            this.DataGridFase1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridFase1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DataGridFase1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridFase1.DefaultCellStyle = dataGridViewCellStyle14;
            this.DataGridFase1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.DataGridFase1.Location = new System.Drawing.Point(17, 171);
            this.DataGridFase1.MultiSelect = false;
            this.DataGridFase1.Name = "DataGridFase1";
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            this.DataGridFase1.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.DataGridFase1.Size = new System.Drawing.Size(693, 332);
            this.DataGridFase1.TabIndex = 0;
            this.DataGridFase1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridFase1_CellContentClick);
            this.DataGridFase1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridFase1_CellEndEdit);
            // 
            // FrmFase02
            // 
            this.FrmFase02.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.FrmFase02.Controls.Add(this.dateTimePicker2);
            this.FrmFase02.Controls.Add(this.TxtAnalista2);
            this.FrmFase02.Controls.Add(this.LbFase2);
            this.FrmFase02.Controls.Add(this.BtnGuardar2);
            this.FrmFase02.Controls.Add(this.DataGridFase2);
            this.FrmFase02.Location = new System.Drawing.Point(4, 22);
            this.FrmFase02.Name = "FrmFase02";
            this.FrmFase02.Padding = new System.Windows.Forms.Padding(3);
            this.FrmFase02.Size = new System.Drawing.Size(962, 515);
            this.FrmFase02.TabIndex = 1;
            this.FrmFase02.Text = "FrmFase02";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(49)))), ((int)(((byte)(79)))));
            this.dateTimePicker2.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePicker2.Location = new System.Drawing.Point(692, 93);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(214, 20);
            this.dateTimePicker2.TabIndex = 20;
            // 
            // TxtAnalista2
            // 
            this.TxtAnalista2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.TxtAnalista2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAnalista2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.TxtAnalista2.Location = new System.Drawing.Point(701, 54);
            this.TxtAnalista2.Multiline = true;
            this.TxtAnalista2.Name = "TxtAnalista2";
            this.TxtAnalista2.Size = new System.Drawing.Size(193, 33);
            this.TxtAnalista2.TabIndex = 19;
            this.TxtAnalista2.Text = "Analista";
            this.TxtAnalista2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LbFase2
            // 
            this.LbFase2.AutoSize = true;
            this.LbFase2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbFase2.ForeColor = System.Drawing.SystemColors.Menu;
            this.LbFase2.Location = new System.Drawing.Point(34, 32);
            this.LbFase2.Name = "LbFase2";
            this.LbFase2.Size = new System.Drawing.Size(195, 55);
            this.LbFase2.TabIndex = 18;
            this.LbFase2.Text = "FASE 2";
            // 
            // BtnGuardar2
            // 
            this.BtnGuardar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(189)))), ((int)(((byte)(79)))));
            this.BtnGuardar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar2.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar2.Location = new System.Drawing.Point(44, 134);
            this.BtnGuardar2.Name = "BtnGuardar2";
            this.BtnGuardar2.Size = new System.Drawing.Size(203, 47);
            this.BtnGuardar2.TabIndex = 15;
            this.BtnGuardar2.Text = "Guardar";
            this.BtnGuardar2.UseVisualStyleBackColor = false;
            this.BtnGuardar2.Click += new System.EventHandler(this.BtGuardar2_Click);
            // 
            // DataGridFase2
            // 
            this.DataGridFase2.AllowDrop = true;
            this.DataGridFase2.AllowUserToOrderColumns = true;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            this.DataGridFase2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.DataGridFase2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridFase2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridFase2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(65)))));
            this.DataGridFase2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DataGridFase2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridFase2.DefaultCellStyle = dataGridViewCellStyle17;
            this.DataGridFase2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.DataGridFase2.Location = new System.Drawing.Point(54, 211);
            this.DataGridFase2.Name = "DataGridFase2";
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            this.DataGridFase2.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.DataGridFase2.Size = new System.Drawing.Size(843, 295);
            this.DataGridFase2.TabIndex = 1;
            this.DataGridFase2.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridFase2_CellValueChanged);
            // 
            // FrmFase03
            // 
            this.FrmFase03.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.FrmFase03.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FrmFase03.Controls.Add(this.BtnGuardar3);
            this.FrmFase03.Controls.Add(this.dateTimePicker3);
            this.FrmFase03.Controls.Add(this.TxtAnalista3);
            this.FrmFase03.Controls.Add(this.LbFase3);
            this.FrmFase03.Controls.Add(this.DataGridFase3);
            this.FrmFase03.Location = new System.Drawing.Point(4, 22);
            this.FrmFase03.Name = "FrmFase03";
            this.FrmFase03.Padding = new System.Windows.Forms.Padding(3);
            this.FrmFase03.Size = new System.Drawing.Size(962, 515);
            this.FrmFase03.TabIndex = 2;
            this.FrmFase03.Text = "FrmFase03";
            // 
            // BtnGuardar3
            // 
            this.BtnGuardar3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(255)))));
            this.BtnGuardar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar3.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar3.Location = new System.Drawing.Point(31, 119);
            this.BtnGuardar3.Name = "BtnGuardar3";
            this.BtnGuardar3.Size = new System.Drawing.Size(203, 47);
            this.BtnGuardar3.TabIndex = 22;
            this.BtnGuardar3.Text = "Finalizar";
            this.BtnGuardar3.UseVisualStyleBackColor = false;
            this.BtnGuardar3.Click += new System.EventHandler(this.BtnGuardar3_Click);
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(49)))), ((int)(((byte)(79)))));
            this.dateTimePicker3.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePicker3.Location = new System.Drawing.Point(691, 92);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(214, 20);
            this.dateTimePicker3.TabIndex = 21;
            // 
            // TxtAnalista3
            // 
            this.TxtAnalista3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.TxtAnalista3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAnalista3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.TxtAnalista3.Location = new System.Drawing.Point(700, 53);
            this.TxtAnalista3.Multiline = true;
            this.TxtAnalista3.Name = "TxtAnalista3";
            this.TxtAnalista3.Size = new System.Drawing.Size(193, 33);
            this.TxtAnalista3.TabIndex = 20;
            this.TxtAnalista3.Text = "Analista";
            this.TxtAnalista3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LbFase3
            // 
            this.LbFase3.AutoSize = true;
            this.LbFase3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbFase3.ForeColor = System.Drawing.SystemColors.Menu;
            this.LbFase3.Location = new System.Drawing.Point(33, 31);
            this.LbFase3.Name = "LbFase3";
            this.LbFase3.Size = new System.Drawing.Size(195, 55);
            this.LbFase3.TabIndex = 19;
            this.LbFase3.Text = "FASE 3";
            // 
            // DataGridFase3
            // 
            this.DataGridFase3.AllowUserToOrderColumns = true;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black;
            this.DataGridFase3.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.DataGridFase3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridFase3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridFase3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(65)))));
            this.DataGridFase3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridFase3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DataGridFase3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridFase3.DefaultCellStyle = dataGridViewCellStyle20;
            this.DataGridFase3.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.DataGridFase3.Location = new System.Drawing.Point(31, 210);
            this.DataGridFase3.Name = "DataGridFase3";
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            this.DataGridFase3.RowsDefaultCellStyle = dataGridViewCellStyle21;
            this.DataGridFase3.Size = new System.Drawing.Size(898, 295);
            this.DataGridFase3.TabIndex = 2;
            this.DataGridFase3.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridFase3_CellFormatting);
            this.DataGridFase3.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridFase3_CellValueChanged);
            // 
            // FrmFase04
            // 
            this.FrmFase04.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.FrmFase04.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FrmFase04.Controls.Add(this.BtnGuardar4);
            this.FrmFase04.Controls.Add(this.dateTimePicker4);
            this.FrmFase04.Controls.Add(this.TxtAnalista4);
            this.FrmFase04.Controls.Add(this.LbFase4);
            this.FrmFase04.Controls.Add(this.DataGridFase4);
            this.FrmFase04.Location = new System.Drawing.Point(4, 22);
            this.FrmFase04.Name = "FrmFase04";
            this.FrmFase04.Padding = new System.Windows.Forms.Padding(3);
            this.FrmFase04.Size = new System.Drawing.Size(962, 515);
            this.FrmFase04.TabIndex = 3;
            this.FrmFase04.Text = "FrmFase04";
            // 
            // BtnGuardar4
            // 
            this.BtnGuardar4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(255)))));
            this.BtnGuardar4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar4.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar4.Location = new System.Drawing.Point(31, 120);
            this.BtnGuardar4.Name = "BtnGuardar4";
            this.BtnGuardar4.Size = new System.Drawing.Size(203, 47);
            this.BtnGuardar4.TabIndex = 24;
            this.BtnGuardar4.Text = "Finalizar";
            this.BtnGuardar4.UseVisualStyleBackColor = false;
            this.BtnGuardar4.Click += new System.EventHandler(this.BtnGuardar4_Click);
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(49)))), ((int)(((byte)(79)))));
            this.dateTimePicker4.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePicker4.Location = new System.Drawing.Point(691, 92);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(214, 20);
            this.dateTimePicker4.TabIndex = 23;
            // 
            // TxtAnalista4
            // 
            this.TxtAnalista4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.TxtAnalista4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAnalista4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.TxtAnalista4.Location = new System.Drawing.Point(700, 53);
            this.TxtAnalista4.Multiline = true;
            this.TxtAnalista4.Name = "TxtAnalista4";
            this.TxtAnalista4.Size = new System.Drawing.Size(193, 33);
            this.TxtAnalista4.TabIndex = 22;
            this.TxtAnalista4.Text = "Analista";
            this.TxtAnalista4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LbFase4
            // 
            this.LbFase4.AutoSize = true;
            this.LbFase4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbFase4.ForeColor = System.Drawing.SystemColors.Menu;
            this.LbFase4.Location = new System.Drawing.Point(33, 31);
            this.LbFase4.Name = "LbFase4";
            this.LbFase4.Size = new System.Drawing.Size(195, 55);
            this.LbFase4.TabIndex = 21;
            this.LbFase4.Text = "FASE 4";
            // 
            // DataGridFase4
            // 
            this.DataGridFase4.AllowUserToOrderColumns = true;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.Black;
            this.DataGridFase4.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle22;
            this.DataGridFase4.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridFase4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(65)))));
            this.DataGridFase4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridFase4.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DataGridFase4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridFase4.DefaultCellStyle = dataGridViewCellStyle23;
            this.DataGridFase4.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.DataGridFase4.Location = new System.Drawing.Point(31, 213);
            this.DataGridFase4.Name = "DataGridFase4";
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.White;
            this.DataGridFase4.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.DataGridFase4.Size = new System.Drawing.Size(898, 295);
            this.DataGridFase4.TabIndex = 3;
            this.DataGridFase4.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridFase4_CellFormatting);
            this.DataGridFase4.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridFase4_CellValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.ControlFases);
            this.panel1.Location = new System.Drawing.Point(230, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 700);
            this.panel1.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.BtnFase04);
            this.panel7.Controls.Add(this.BtnFase03);
            this.panel7.Controls.Add(this.BtnFase02);
            this.panel7.Controls.Add(this.BtnFase01);
            this.panel7.Location = new System.Drawing.Point(-1, -1);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(245, 700);
            this.panel7.TabIndex = 16;
            // 
            // BtnFase01
            // 
            this.BtnFase01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(49)))), ((int)(((byte)(79)))));
            this.BtnFase01.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFase01.ForeColor = System.Drawing.Color.White;
            this.BtnFase01.Location = new System.Drawing.Point(21, 271);
            this.BtnFase01.Name = "BtnFase01";
            this.BtnFase01.Size = new System.Drawing.Size(203, 47);
            this.BtnFase01.TabIndex = 0;
            this.BtnFase01.Text = "Fase 1";
            this.BtnFase01.UseVisualStyleBackColor = false;
            this.BtnFase01.Click += new System.EventHandler(this.BtnFase01_Click);
            // 
            // BtnFase02
            // 
            this.BtnFase02.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(49)))), ((int)(((byte)(79)))));
            this.BtnFase02.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFase02.ForeColor = System.Drawing.Color.White;
            this.BtnFase02.Location = new System.Drawing.Point(21, 333);
            this.BtnFase02.Name = "BtnFase02";
            this.BtnFase02.Size = new System.Drawing.Size(203, 47);
            this.BtnFase02.TabIndex = 10;
            this.BtnFase02.Text = "Fase 2";
            this.BtnFase02.UseVisualStyleBackColor = false;
            this.BtnFase02.Click += new System.EventHandler(this.BtnFase02_Click);
            // 
            // BtnFase03
            // 
            this.BtnFase03.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(49)))), ((int)(((byte)(79)))));
            this.BtnFase03.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFase03.ForeColor = System.Drawing.Color.White;
            this.BtnFase03.Location = new System.Drawing.Point(21, 395);
            this.BtnFase03.Name = "BtnFase03";
            this.BtnFase03.Size = new System.Drawing.Size(203, 47);
            this.BtnFase03.TabIndex = 11;
            this.BtnFase03.Text = "Fase 3";
            this.BtnFase03.UseVisualStyleBackColor = false;
            this.BtnFase03.Click += new System.EventHandler(this.BtnFase03_Click);
            // 
            // BtnFase04
            // 
            this.BtnFase04.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(49)))), ((int)(((byte)(79)))));
            this.BtnFase04.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFase04.ForeColor = System.Drawing.Color.White;
            this.BtnFase04.Location = new System.Drawing.Point(21, 458);
            this.BtnFase04.Name = "BtnFase04";
            this.BtnFase04.Size = new System.Drawing.Size(203, 47);
            this.BtnFase04.TabIndex = 12;
            this.BtnFase04.Text = "Fase 4";
            this.BtnFase04.UseVisualStyleBackColor = false;
            this.BtnFase04.Click += new System.EventHandler(this.BtnFase04_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monoton", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(33, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 187);
            this.label2.TabIndex = 9;
            this.label2.Text = "R";
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(3, 86);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(979, 508);
            this.panel5.TabIndex = 3;
            // 
            // FrmFase3
            // 
            this.FrmFase3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.FrmFase3.Location = new System.Drawing.Point(0, 595);
            this.FrmFase3.Name = "FrmFase3";
            this.FrmFase3.Size = new System.Drawing.Size(1059, 10);
            this.FrmFase3.TabIndex = 4;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.MinimumSize = new System.Drawing.Size(960, 480);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenu";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureReposo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureMinimizarYMaximinar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureCerrar)).EndInit();
            this.ControlFases.ResumeLayout(false);
            this.FrmFase01.ResumeLayout(false);
            this.FrmFase01.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridFase1)).EndInit();
            this.FrmFase02.ResumeLayout(false);
            this.FrmFase02.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridFase2)).EndInit();
            this.FrmFase03.ResumeLayout(false);
            this.FrmFase03.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridFase3)).EndInit();
            this.FrmFase04.ResumeLayout(false);
            this.FrmFase04.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridFase4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        private void DataGridFase1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl ControlFases;
        private System.Windows.Forms.TabPage FrmFase01;
        private System.Windows.Forms.DataGridView DataGridFase1;
        private System.Windows.Forms.TabPage FrmFase02;
        private System.Windows.Forms.TabPage FrmFase03;
        private System.Windows.Forms.TabPage FrmFase04;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox PictureReposo;
        private System.Windows.Forms.PictureBox PictureMinimizarYMaximinar;
        private System.Windows.Forms.Label Rixpert;
        private System.Windows.Forms.PictureBox PictureCerrar;
        private System.Windows.Forms.TextBox TxtAnalista1;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnEliminar1;
        private System.Windows.Forms.Button BtnAgregar1;
        private System.Windows.Forms.DataGridView DataGridFase2;
        private System.Windows.Forms.Label LbFase1;
        private System.Windows.Forms.Label LbFase2;
        private System.Windows.Forms.Button BtnGuardar2;
        private System.Windows.Forms.DataGridView DataGridFase3;
        private System.Windows.Forms.Label LbFase3;
        private System.Windows.Forms.Label LbFase4;
        private System.Windows.Forms.DataGridView DataGridFase4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox TxtAnalista2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.TextBox TxtAnalista3;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.TextBox TxtAnalista4;
        private System.Windows.Forms.Button BtnGuardar3;
        private System.Windows.Forms.Button BtnGuardar4;
        private Panel panel7;
        private Label label2;
        private Button BtnFase04;
        private Button BtnFase03;
        private Button BtnFase02;
        private Button BtnFase01;
        private Panel panel5;
        private Panel FrmFase3;
    }
}