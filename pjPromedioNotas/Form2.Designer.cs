namespace pjPromedioNotas
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cboNacimiento = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtSueldo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnRegis = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtAños = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.rbdMas = new MetroFramework.Controls.MetroRadioButton();
            this.rbdFem = new MetroFramework.Controls.MetroRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::registroDocentes.Properties.Resources.docentes1;
            this.pictureBox1.Location = new System.Drawing.Point(62, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Depth = 0;
            this.txtNombre.Hint = "Nombre";
            this.txtNombre.Location = new System.Drawing.Point(62, 132);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.Size = new System.Drawing.Size(177, 23);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TabStop = false;
            this.txtNombre.UseSystemPasswordChar = false;
            // 
            // cboNacimiento
            // 
            this.cboNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cboNacimiento.Location = new System.Drawing.Point(117, 198);
            this.cboNacimiento.MinimumSize = new System.Drawing.Size(0, 29);
            this.cboNacimiento.Name = "cboNacimiento";
            this.cboNacimiento.Size = new System.Drawing.Size(162, 29);
            this.cboNacimiento.Style = MetroFramework.MetroColorStyle.Green;
            this.cboNacimiento.TabIndex = 17;
            this.cboNacimiento.Tag = "das";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(31, 208);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(79, 19);
            this.metroLabel1.TabIndex = 19;
            this.metroLabel1.Text = "Nacimiento:";
            // 
            // txtSueldo
            // 
            this.txtSueldo.Depth = 0;
            this.txtSueldo.Hint = "Sueldo Basico";
            this.txtSueldo.Location = new System.Drawing.Point(31, 245);
            this.txtSueldo.MaxLength = 32767;
            this.txtSueldo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.PasswordChar = '\0';
            this.txtSueldo.SelectedText = "";
            this.txtSueldo.SelectionLength = 0;
            this.txtSueldo.SelectionStart = 0;
            this.txtSueldo.Size = new System.Drawing.Size(105, 23);
            this.txtSueldo.TabIndex = 24;
            this.txtSueldo.TabStop = false;
            this.txtSueldo.UseSystemPasswordChar = false;
            // 
            // btnRegis
            // 
            this.btnRegis.ActiveBorderThickness = 1;
            this.btnRegis.ActiveCornerRadius = 20;
            this.btnRegis.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnRegis.ActiveForecolor = System.Drawing.Color.White;
            this.btnRegis.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnRegis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRegis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegis.BackgroundImage")));
            this.btnRegis.ButtonText = "Registrar";
            this.btnRegis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegis.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegis.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnRegis.IdleBorderThickness = 1;
            this.btnRegis.IdleCornerRadius = 20;
            this.btnRegis.IdleFillColor = System.Drawing.Color.White;
            this.btnRegis.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnRegis.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnRegis.Location = new System.Drawing.Point(58, 286);
            this.btnRegis.Margin = new System.Windows.Forms.Padding(5);
            this.btnRegis.Name = "btnRegis";
            this.btnRegis.Size = new System.Drawing.Size(181, 41);
            this.btnRegis.TabIndex = 31;
            this.btnRegis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRegis.Click += new System.EventHandler(this.btnRegis_Click);
            // 
            // txtAños
            // 
            this.txtAños.Depth = 0;
            this.txtAños.Hint = "Años trabajados";
            this.txtAños.Location = new System.Drawing.Point(157, 245);
            this.txtAños.MaxLength = 32767;
            this.txtAños.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAños.Name = "txtAños";
            this.txtAños.PasswordChar = '\0';
            this.txtAños.SelectedText = "";
            this.txtAños.SelectionLength = 0;
            this.txtAños.SelectionStart = 0;
            this.txtAños.Size = new System.Drawing.Size(121, 23);
            this.txtAños.TabIndex = 32;
            this.txtAños.TabStop = false;
            this.txtAños.UseSystemPasswordChar = false;
            // 
            // rbdMas
            // 
            this.rbdMas.AutoSize = true;
            this.rbdMas.Checked = true;
            this.rbdMas.Location = new System.Drawing.Point(58, 167);
            this.rbdMas.Name = "rbdMas";
            this.rbdMas.Size = new System.Drawing.Size(78, 15);
            this.rbdMas.Style = MetroFramework.MetroColorStyle.Green;
            this.rbdMas.TabIndex = 39;
            this.rbdMas.TabStop = true;
            this.rbdMas.Text = "Masculino";
            this.rbdMas.Theme = MetroFramework.MetroThemeStyle.Light;
            this.rbdMas.UseSelectable = true;
            // 
            // rbdFem
            // 
            this.rbdFem.AutoSize = true;
            this.rbdFem.Location = new System.Drawing.Point(163, 167);
            this.rbdFem.Name = "rbdFem";
            this.rbdFem.Size = new System.Drawing.Size(76, 15);
            this.rbdFem.Style = MetroFramework.MetroColorStyle.Green;
            this.rbdFem.TabIndex = 40;
            this.rbdFem.Text = "Femenino";
            this.rbdFem.UseSelectable = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 346);
            this.Controls.Add(this.rbdFem);
            this.Controls.Add(this.rbdMas);
            this.Controls.Add(this.txtAños);
            this.Controls.Add(this.btnRegis);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cboNacimiento);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Opacity = 0.96D;
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public Bunifu.Framework.UI.BunifuThinButton2 btnRegis;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtAños;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtNombre;
        public MetroFramework.Controls.MetroDateTime cboNacimiento;
        public MetroFramework.Controls.MetroLabel metroLabel1;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtSueldo;
        private MetroFramework.Controls.MetroRadioButton rbdMas;
        private MetroFramework.Controls.MetroRadioButton rbdFem;
    }
}