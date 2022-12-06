namespace Nomlyzer
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.NomBox = new System.Windows.Forms.TextBox();
            this.nom = new System.Windows.Forms.Label();
            this.capitob = new System.Windows.Forms.Button();
            this.DescGroup = new System.Windows.Forms.GroupBox();
            this.tcHTMLc = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tcURLc = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tcSHA256 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tcMD5 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tcSHA1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tInMay = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tMin = new System.Windows.Forms.TextBox();
            this.tMay = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nomBur = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nomVes = new System.Windows.Forms.TextBox();
            this.alrev = new System.Windows.Forms.Label();
            this.ConNums = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NoVocs = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NoCons = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MiniNom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.genc = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.inicio = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repositorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label11 = new System.Windows.Forms.Label();
            this.DescGroup.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escribe un nombre:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "&Ingresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // NomBox
            // 
            this.NomBox.Location = new System.Drawing.Point(123, 31);
            this.NomBox.Name = "NomBox";
            this.NomBox.Size = new System.Drawing.Size(164, 20);
            this.NomBox.TabIndex = 2;
            // 
            // nom
            // 
            this.nom.BackColor = System.Drawing.Color.Transparent;
            this.nom.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom.Location = new System.Drawing.Point(0, 9);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(659, 85);
            this.nom.TabIndex = 3;
            this.nom.Text = "NOMBRE";
            this.nom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nom.Visible = false;
            // 
            // capitob
            // 
            this.capitob.Location = new System.Drawing.Point(31, 335);
            this.capitob.Name = "capitob";
            this.capitob.Size = new System.Drawing.Size(256, 23);
            this.capitob.TabIndex = 5;
            this.capitob.Text = "A&veriguar significado";
            this.capitob.UseVisualStyleBackColor = true;
            this.capitob.Visible = false;
            this.capitob.Click += new System.EventHandler(this.capitob_Click);
            // 
            // DescGroup
            // 
            this.DescGroup.Controls.Add(this.tcHTMLc);
            this.DescGroup.Controls.Add(this.label17);
            this.DescGroup.Controls.Add(this.tcURLc);
            this.DescGroup.Controls.Add(this.label16);
            this.DescGroup.Controls.Add(this.tcSHA256);
            this.DescGroup.Controls.Add(this.label15);
            this.DescGroup.Controls.Add(this.label14);
            this.DescGroup.Controls.Add(this.tcMD5);
            this.DescGroup.Controls.Add(this.label13);
            this.DescGroup.Controls.Add(this.tcSHA1);
            this.DescGroup.Controls.Add(this.label12);
            this.DescGroup.Controls.Add(this.tInMay);
            this.DescGroup.Controls.Add(this.label10);
            this.DescGroup.Controls.Add(this.tMin);
            this.DescGroup.Controls.Add(this.tMay);
            this.DescGroup.Controls.Add(this.label9);
            this.DescGroup.Controls.Add(this.nomBur);
            this.DescGroup.Controls.Add(this.label8);
            this.DescGroup.Controls.Add(this.nomVes);
            this.DescGroup.Controls.Add(this.alrev);
            this.DescGroup.Controls.Add(this.ConNums);
            this.DescGroup.Controls.Add(this.label6);
            this.DescGroup.Controls.Add(this.NoVocs);
            this.DescGroup.Controls.Add(this.label5);
            this.DescGroup.Controls.Add(this.NoCons);
            this.DescGroup.Controls.Add(this.label4);
            this.DescGroup.Controls.Add(this.MiniNom);
            this.DescGroup.Controls.Add(this.label2);
            this.DescGroup.Location = new System.Drawing.Point(16, 81);
            this.DescGroup.Name = "DescGroup";
            this.DescGroup.Size = new System.Drawing.Size(650, 211);
            this.DescGroup.TabIndex = 6;
            this.DescGroup.TabStop = false;
            this.DescGroup.Visible = false;
            // 
            // tcHTMLc
            // 
            this.tcHTMLc.BackColor = System.Drawing.Color.White;
            this.tcHTMLc.Location = new System.Drawing.Point(138, 182);
            this.tcHTMLc.Name = "tcHTMLc";
            this.tcHTMLc.ReadOnly = true;
            this.tcHTMLc.Size = new System.Drawing.Size(184, 20);
            this.tcHTMLc.TabIndex = 27;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(13, 185);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(98, 13);
            this.label17.TabIndex = 26;
            this.label17.Text = "Codificación HTML";
            // 
            // tcURLc
            // 
            this.tcURLc.BackColor = System.Drawing.Color.White;
            this.tcURLc.Location = new System.Drawing.Point(453, 182);
            this.tcURLc.Name = "tcURLc";
            this.tcURLc.ReadOnly = true;
            this.tcURLc.Size = new System.Drawing.Size(184, 20);
            this.tcURLc.TabIndex = 25;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(330, 185);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 13);
            this.label16.TabIndex = 24;
            this.label16.Text = "Codificación URL";
            // 
            // tcSHA256
            // 
            this.tcSHA256.BackColor = System.Drawing.Color.White;
            this.tcSHA256.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tcSHA256.Location = new System.Drawing.Point(453, 128);
            this.tcSHA256.Name = "tcSHA256";
            this.tcSHA256.ReadOnly = true;
            this.tcSHA256.Size = new System.Drawing.Size(184, 20);
            this.tcSHA256.TabIndex = 23;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(328, 132);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(122, 13);
            this.label15.TabIndex = 22;
            this.label15.Text = "Encriptado con SHA256";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(328, 159);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "Encriptado con MD5";
            // 
            // tcMD5
            // 
            this.tcMD5.BackColor = System.Drawing.Color.White;
            this.tcMD5.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tcMD5.Location = new System.Drawing.Point(453, 156);
            this.tcMD5.Name = "tcMD5";
            this.tcMD5.ReadOnly = true;
            this.tcMD5.Size = new System.Drawing.Size(184, 20);
            this.tcMD5.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(328, 105);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Encriptado con SHA1";
            // 
            // tcSHA1
            // 
            this.tcSHA1.BackColor = System.Drawing.Color.White;
            this.tcSHA1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tcSHA1.Location = new System.Drawing.Point(453, 102);
            this.tcSHA1.Name = "tcSHA1";
            this.tcSHA1.ReadOnly = true;
            this.tcSHA1.Size = new System.Drawing.Size(184, 20);
            this.tcSHA1.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(328, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Inicial en mayúsculas";
            // 
            // tInMay
            // 
            this.tInMay.BackColor = System.Drawing.Color.White;
            this.tInMay.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tInMay.Location = new System.Drawing.Point(453, 75);
            this.tInMay.Name = "tInMay";
            this.tInMay.ReadOnly = true;
            this.tInMay.Size = new System.Drawing.Size(184, 20);
            this.tInMay.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(328, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Todo en minúsculas";
            // 
            // tMin
            // 
            this.tMin.BackColor = System.Drawing.Color.White;
            this.tMin.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tMin.Location = new System.Drawing.Point(453, 49);
            this.tMin.Name = "tMin";
            this.tMin.ReadOnly = true;
            this.tMin.Size = new System.Drawing.Size(184, 20);
            this.tMin.TabIndex = 14;
            // 
            // tMay
            // 
            this.tMay.BackColor = System.Drawing.Color.White;
            this.tMay.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tMay.Location = new System.Drawing.Point(453, 22);
            this.tMay.Name = "tMay";
            this.tMay.ReadOnly = true;
            this.tMay.Size = new System.Drawing.Size(184, 20);
            this.tMay.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(328, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Todo en mayúsculas";
            // 
            // nomBur
            // 
            this.nomBur.BackColor = System.Drawing.Color.White;
            this.nomBur.Location = new System.Drawing.Point(138, 152);
            this.nomBur.Name = "nomBur";
            this.nomBur.ReadOnly = true;
            this.nomBur.Size = new System.Drawing.Size(184, 20);
            this.nomBur.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "En versalitas";
            // 
            // nomVes
            // 
            this.nomVes.BackColor = System.Drawing.SystemColors.Window;
            this.nomVes.Location = new System.Drawing.Point(138, 125);
            this.nomVes.Name = "nomVes";
            this.nomVes.ReadOnly = true;
            this.nomVes.Size = new System.Drawing.Size(184, 20);
            this.nomVes.TabIndex = 9;
            // 
            // alrev
            // 
            this.alrev.AutoSize = true;
            this.alrev.Location = new System.Drawing.Point(12, 126);
            this.alrev.Name = "alrev";
            this.alrev.Size = new System.Drawing.Size(45, 13);
            this.alrev.TabIndex = 8;
            this.alrev.Text = "Al revés";
            // 
            // ConNums
            // 
            this.ConNums.BackColor = System.Drawing.SystemColors.Window;
            this.ConNums.Location = new System.Drawing.Point(138, 98);
            this.ConNums.Name = "ConNums";
            this.ConNums.ReadOnly = true;
            this.ConNums.Size = new System.Drawing.Size(184, 20);
            this.ConNums.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nombre con números";
            // 
            // NoVocs
            // 
            this.NoVocs.BackColor = System.Drawing.SystemColors.Window;
            this.NoVocs.Location = new System.Drawing.Point(138, 71);
            this.NoVocs.Name = "NoVocs";
            this.NoVocs.ReadOnly = true;
            this.NoVocs.Size = new System.Drawing.Size(184, 20);
            this.NoVocs.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sin vocales";
            // 
            // NoCons
            // 
            this.NoCons.BackColor = System.Drawing.SystemColors.Window;
            this.NoCons.Location = new System.Drawing.Point(138, 44);
            this.NoCons.Name = "NoCons";
            this.NoCons.ReadOnly = true;
            this.NoCons.Size = new System.Drawing.Size(184, 20);
            this.NoCons.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Sin consonantes";
            // 
            // MiniNom
            // 
            this.MiniNom.BackColor = System.Drawing.Color.White;
            this.MiniNom.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MiniNom.Location = new System.Drawing.Point(138, 19);
            this.MiniNom.Name = "MiniNom";
            this.MiniNom.ReadOnly = true;
            this.MiniNom.Size = new System.Drawing.Size(184, 20);
            this.MiniNom.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre minimalista";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Elige su sexo:";
            // 
            // genc
            // 
            this.genc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genc.FormattingEnabled = true;
            this.genc.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.genc.Location = new System.Drawing.Point(123, 54);
            this.genc.Name = "genc";
            this.genc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.genc.Size = new System.Drawing.Size(164, 21);
            this.genc.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Género";
            this.label7.Visible = false;
            // 
            // inicio
            // 
            this.inicio.Location = new System.Drawing.Point(493, 335);
            this.inicio.Name = "inicio";
            this.inicio.Size = new System.Drawing.Size(73, 23);
            this.inicio.TabIndex = 10;
            this.inicio.Text = "&Regresar";
            this.inicio.UseVisualStyleBackColor = true;
            this.inicio.Click += new System.EventHandler(this.inicio_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.AutoSize = true;
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(237, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Historial";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nombreToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(334, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nombreToolStripMenuItem
            // 
            this.nombreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historialToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.nombreToolStripMenuItem.Name = "nombreToolStripMenuItem";
            this.nombreToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.nombreToolStripMenuItem.Text = "&Nombre";
            // 
            // historialToolStripMenuItem
            // 
            this.historialToolStripMenuItem.Enabled = false;
            this.historialToolStripMenuItem.Name = "historialToolStripMenuItem";
            this.historialToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.historialToolStripMenuItem.Text = "&Historial";
            this.historialToolStripMenuItem.Click += new System.EventHandler(this.historialToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(115, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.repositorioToolStripMenuItem,
            this.licenciaToolStripMenuItem,
            this.toolStripSeparator2,
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "&Ayuda";
            // 
            // repositorioToolStripMenuItem
            // 
            this.repositorioToolStripMenuItem.Name = "repositorioToolStripMenuItem";
            this.repositorioToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.repositorioToolStripMenuItem.Text = "&Repositorio";
            this.repositorioToolStripMenuItem.Click += new System.EventHandler(this.repositorioToolStripMenuItem_Click);
            // 
            // licenciaToolStripMenuItem
            // 
            this.licenciaToolStripMenuItem.Name = "licenciaToolStripMenuItem";
            this.licenciaToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.licenciaToolStripMenuItem.Text = "&Licencia";
            this.licenciaToolStripMenuItem.Click += new System.EventHandler(this.licenciaToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(131, 6);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.acercaDeToolStripMenuItem.Text = "&Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(271, 315);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Contador de letras";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 126);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.inicio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.genc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.capitob);
            this.Controls.Add(this.NomBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DescGroup);
            this.Controls.Add(this.nom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Nomlyzer";
            this.DescGroup.ResumeLayout(false);
            this.DescGroup.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox NomBox;
        private System.Windows.Forms.Label nom;
        private System.Windows.Forms.Button capitob;
        private System.Windows.Forms.GroupBox DescGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MiniNom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox genc;
        private System.Windows.Forms.TextBox NoCons;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NoVocs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ConNums;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button inicio;
        private System.Windows.Forms.TextBox nomVes;
        private System.Windows.Forms.Label alrev;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox nomBur;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nombreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repositorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tMin;
        private System.Windows.Forms.TextBox tMay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolStripMenuItem licenciaToolStripMenuItem;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tInMay;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tcMD5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tcSHA1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.TextBox tcSHA256;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tcURLc;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tcHTMLc;
        private System.Windows.Forms.Label label17;

    }
}

