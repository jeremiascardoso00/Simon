using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simon
{
    public partial class Form1 : Form
    {

        private int contadorBoton =0;
        private Random r;
        private List<int> SimonDice = new List<int>();
        private List<int> JugadorDice;
        private int tiempo = 900;
        private bool enable = false;
        
        private int puntaje = 0;

        public Form1()
        {
            InitializeComponent();
            r = new Random();

        }
        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            lbl_puntaje.Text = "--";
            this.puntaje = 0;
            this.contadorBoton = 0;
            SimonDice = new List<int>();
            //cargamos la lista
            SimonDice.Add(r.Next(0, 4));
            JugadorDice = new List<int>();


            //creo un nuevo subproceso para poder usar la funcion sleep
            //y dormirlo
            

            IniciarJuego();
            
        }

        public void IniciarJuego()
        {
            //vi en internet que esto sirve para esperar un tiempo,
            //en este caso sirve para que las imagenes no se prendan ni bien apretas el boton.
            //podia escribirlo asi como abajo o podia simplemente importar la biblioteca 
            //threading y aca abajo poner: Thread.Sleep(tiempo);

            Console.WriteLine("iniciando juego");
            foreach (int ParteActiva in SimonDice)
            {
                
                switch (ParteActiva)
                {
                    case 0:
                        Console.WriteLine("trampa: 1");
                        
                        imagen_0.Image = Properties.Resources.button_blue___copia;
                        imagen_0.Refresh();
                        Thread.Sleep(tiempo);
                        this.imagen_0.Image = Properties.Resources.button_blue;
                        imagen_0.Refresh();
                        Console.WriteLine(".");
                        break;
                    case 1:
                        Console.WriteLine("trampa: 2");
                        
                        SetImagen_1(Properties.Resources.button_yellow___copia);
                        imagen_1.Refresh();
                        Thread.Sleep(tiempo);
                        SetImagen_1(Properties.Resources.button_yellow);
                        imagen_1.Refresh();
                        Console.WriteLine(".");
                        break;
                    case 2:
                        Console.WriteLine("trampa: 3");
                        
                        SetImagen_2(Properties.Resources.button_red___copia);
                        imagen_2.Refresh();
                        Thread.Sleep(tiempo);
                        SetImagen_2(Properties.Resources.button_red);
                        imagen_2.Refresh();
                        Console.WriteLine(".");
                        break;
                    case 3:
                        Console.WriteLine("trampa: 4");
                        SetImagen_3(Properties.Resources.button_green___copia);
                        imagen_3.Refresh();
                        Thread.Sleep(tiempo);
                        SetImagen_3(Properties.Resources.button_green);
                        imagen_3.Refresh();
                        Console.WriteLine(".");
                        break;
                }

            }
            this.enable = true;


            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        private void imagen_0_Click(object sender, EventArgs e)
        {

            

        }
        private void imagen_1_Click(object sender, EventArgs e)
        {
           
        }
        private void imagen_2_Click(object sender, EventArgs e)
        {
           
        }
        private void imagen_3_Click(object sender, EventArgs e)
        {
            
            
            
        }

        private void Control()
        {
            for(int  i=0; i<contadorBoton; i++)
            {
                if (SimonDice[i] != JugadorDice[i])
                {
                    
                    lbl_puntaje.Text = $"Puntaje final: {this.puntaje}";
                    return;
                }
                
            }
            if (this.contadorBoton == SimonDice.Count())
            {
                this.contadorBoton = 0;
                this.puntaje++;
                lbl_puntaje.Text = this.puntaje.ToString();
                lbl_puntaje.Refresh();
                //cargamos la lista
                SimonDice.Add(r.Next(0, 4));
                JugadorDice = new List<int>();
                this.enable = false;

                Thread.Sleep(2000);

                //creo un nuevo subproceso para poder usar la funcion sleep
                //y dormirlo


                //pruebo esto

                IniciarJuego();
            }
            else
            {
                return;
            }
            
        }

        private void imagen_0_MouseDown(object sender, MouseEventArgs e)
        {
            imagen_0.Image = Properties.Resources.button_blue___copia;
        }

        private void imagen_0_MouseUp(object sender, MouseEventArgs e)
        {
            imagen_0.Image = Properties.Resources.button_blue;
            imagen_0.Refresh();
            if (enable)
            {
                String numeroDeImagen = ((PictureBox)sender).Tag.ToString();
                Console.WriteLine("boton 1: " + numeroDeImagen);

                JugadorDice.Add(int.Parse(numeroDeImagen));
                contadorBoton++;
                Control();
            }
        }

        private void imagen_1_MouseDown(object sender, MouseEventArgs e)
        {
            imagen_1.Image = Properties.Resources.button_yellow___copia;
        }

        private void imagen_1_MouseUp(object sender, MouseEventArgs e)
        {
            imagen_1.Image = Properties.Resources.button_yellow;
            imagen_1.Refresh();
            if (enable)
            {
                String numeroDeImagen = ((PictureBox)sender).Tag.ToString();
                Console.WriteLine("boton 2");
                JugadorDice.Add(int.Parse(numeroDeImagen));
                contadorBoton++;
                Control();
            }
        }

        private void imagen_2_MouseDown(object sender, MouseEventArgs e)
        {
            imagen_2.Image = Properties.Resources.button_red___copia;
        }

        private void imagen_2_MouseUp(object sender, MouseEventArgs e)
        {
            imagen_2.Image = Properties.Resources.button_red;
            imagen_2.Refresh();
            if (enable)
            {
                String numeroDeImagen = ((PictureBox)sender).Tag.ToString();
                Console.WriteLine("boton 3");
                JugadorDice.Add(int.Parse(numeroDeImagen));
                contadorBoton++;
                Control();
            }
        }

        private void imagen_3_MouseDown(object sender, MouseEventArgs e)
        {
            imagen_3.Image = Properties.Resources.button_green___copia;

        }

        private void imagen_3_MouseUp(object sender, MouseEventArgs e)
        {
            imagen_3.Image = Properties.Resources.button_green;
            imagen_3.Refresh();
            if (enable && imagen_3.Tag.Equals("3"))
            {
                String numeroDeImagen = ((PictureBox)sender).Tag.ToString();
                Console.WriteLine("boton 4");
                JugadorDice.Add(int.Parse(numeroDeImagen));
                contadorBoton++;
                Control();
            }
        }

    }
}
