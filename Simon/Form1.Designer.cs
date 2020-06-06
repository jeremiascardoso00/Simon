using System.Windows.Forms;

namespace Simon
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.imagen_0 = new System.Windows.Forms.PictureBox();
            this.imagen_1 = new System.Windows.Forms.PictureBox();
            this.imagen_3 = new System.Windows.Forms.PictureBox();
            this.imagen_2 = new System.Windows.Forms.PictureBox();
            this.btn_iniciar = new System.Windows.Forms.Button();
            this.lbl_puntaje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imagen_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen_2)).BeginInit();
            this.SuspendLayout();
            // 
            // imagen_0
            // 
            this.imagen_0.Image = global::Simon.Properties.Resources.button_blue;
            this.imagen_0.InitialImage = global::Simon.Properties.Resources.button_blue;
            this.imagen_0.Location = new System.Drawing.Point(47, 41);
            this.imagen_0.MaximumSize = new System.Drawing.Size(200, 200);
            this.imagen_0.Name = "imagen_0";
            this.imagen_0.Size = new System.Drawing.Size(200, 200);
            this.imagen_0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagen_0.TabIndex = 0;
            this.imagen_0.TabStop = false;
            this.imagen_0.Tag = "0";
            this.imagen_0.WaitOnLoad = true;
            this.imagen_0.Click += new System.EventHandler(this.imagen_0_Click);
            this.imagen_0.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imagen_0_MouseDown);
            this.imagen_0.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imagen_0_MouseUp);
            // 
            // imagen_1
            // 
            this.imagen_1.Image = global::Simon.Properties.Resources.button_yellow;
            this.imagen_1.InitialImage = global::Simon.Properties.Resources.button_yellow;
            this.imagen_1.Location = new System.Drawing.Point(286, 41);
            this.imagen_1.MaximumSize = new System.Drawing.Size(200, 200);
            this.imagen_1.Name = "imagen_1";
            this.imagen_1.Size = new System.Drawing.Size(200, 200);
            this.imagen_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagen_1.TabIndex = 1;
            this.imagen_1.TabStop = false;
            this.imagen_1.Tag = "1";
            this.imagen_1.WaitOnLoad = true;
            this.imagen_1.Click += new System.EventHandler(this.imagen_1_Click);
            this.imagen_1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imagen_1_MouseDown);
            this.imagen_1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imagen_1_MouseUp);
            // 
            // imagen_3
            // 
            this.imagen_3.Image = global::Simon.Properties.Resources.button_green;
            this.imagen_3.InitialImage = global::Simon.Properties.Resources.button_green;
            this.imagen_3.Location = new System.Drawing.Point(286, 282);
            this.imagen_3.MaximumSize = new System.Drawing.Size(200, 200);
            this.imagen_3.Name = "imagen_3";
            this.imagen_3.Size = new System.Drawing.Size(200, 200);
            this.imagen_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagen_3.TabIndex = 2;
            this.imagen_3.TabStop = false;
            this.imagen_3.Tag = "3";
            this.imagen_3.WaitOnLoad = true;
            this.imagen_3.Click += new System.EventHandler(this.imagen_3_Click);
            this.imagen_3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imagen_3_MouseDown);
            this.imagen_3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imagen_3_MouseUp);
            // 
            // imagen_2
            // 
            this.imagen_2.Image = global::Simon.Properties.Resources.button_red;
            this.imagen_2.InitialImage = global::Simon.Properties.Resources.button_red;
            this.imagen_2.Location = new System.Drawing.Point(47, 282);
            this.imagen_2.MaximumSize = new System.Drawing.Size(200, 200);
            this.imagen_2.Name = "imagen_2";
            this.imagen_2.Size = new System.Drawing.Size(200, 200);
            this.imagen_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagen_2.TabIndex = 3;
            this.imagen_2.TabStop = false;
            this.imagen_2.Tag = "2";
            this.imagen_2.WaitOnLoad = true;
            this.imagen_2.Click += new System.EventHandler(this.imagen_2_Click);
            this.imagen_2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imagen_2_MouseDown);
            this.imagen_2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imagen_2_MouseUp);
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_iniciar.Location = new System.Drawing.Point(47, 497);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(439, 63);
            this.btn_iniciar.TabIndex = 4;
            this.btn_iniciar.Text = "Iniciar Juego";
            this.btn_iniciar.UseVisualStyleBackColor = true;
            this.btn_iniciar.Click += new System.EventHandler(this.btn_iniciar_Click);
            // 
            // lbl_puntaje
            // 
            this.lbl_puntaje.AutoSize = true;
            this.lbl_puntaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_puntaje.Location = new System.Drawing.Point(248, 244);
            this.lbl_puntaje.Name = "lbl_puntaje";
            this.lbl_puntaje.Size = new System.Drawing.Size(37, 37);
            this.lbl_puntaje.TabIndex = 5;
            this.lbl_puntaje.Text = "--";
            this.lbl_puntaje.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 572);
            this.Controls.Add(this.lbl_puntaje);
            this.Controls.Add(this.btn_iniciar);
            this.Controls.Add(this.imagen_2);
            this.Controls.Add(this.imagen_3);
            this.Controls.Add(this.imagen_1);
            this.Controls.Add(this.imagen_0);
            this.Name = "Form1";
            this.Text = "Simon dice";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.imagen_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen_2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imagen_0;
        private System.Windows.Forms.PictureBox imagen_1;
        private System.Windows.Forms.PictureBox imagen_3;
        private System.Windows.Forms.PictureBox imagen_2;
        private System.Windows.Forms.Button btn_iniciar;
        private System.Windows.Forms.Label lbl_puntaje;

        public void SetImagen_0(System.Drawing.Image imagen)
        {
            this.imagen_0.Image = imagen;
        }
        public void SetImagen_1(System.Drawing.Image imagen)
        {
            this.imagen_1.Image = imagen;
        }
        public void SetImagen_2(System.Drawing.Image imagen)
        {
            this.imagen_2.Image = imagen;
        }
        public void SetImagen_3(System.Drawing.Image imagen)
        {
            this.imagen_3.Image = imagen;
        }
    }
}

