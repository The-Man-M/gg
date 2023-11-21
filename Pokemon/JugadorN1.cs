using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon
{
    public partial class JugadorN1 : Form
    {
        bool listo1 = false;
        bool listo2 = false;
        bool turno1 = false;
        bool turno2 = false;

        List<Pokémon> pokémons = new List<Pokémon>();
        List<Pokémon> pokémons2 = new List<Pokémon>();

        int daño1;
        int daño2;
        int daño3;
        int daño4;
        int daño12;
        int daño22;
        int daño32;
        int daño42;

        public JugadorN1()
        {
            InitializeComponent();

            btnAtaque1.Visible = false;
            btnAtaque3.Visible = false;
            btnAtaque2.Visible = false;
            btnAtaque4.Visible = false;
            btnAtaque12.Visible = false;
            btnAtaque22.Visible = false;
            btnAtaque32.Visible = false;
            btnAtaque42.Visible = false;

            foreach (var item in pokémons)
            {

            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            
            Pokémon pokémon = (Pokémon)listBoxEquipo1.SelectedItem;

            progressBarVida1.Value = barra(pokémon.estadisticas.vidaMax, pokémon.estadisticas.vida);//----------------
            lbl_barra_vida_1.Text = "Vida: " + pokémon.estadisticas.vida.ToString();//----------------


            lblNombre.Text = pokémon.nombre;
            lblTipo1.Text = pokémon.tipo.ToString();
            lblTipo2.Text = pokémon.tipo2.ToString();
            lblVida.Text = pokémon.estadisticas.vida.ToString();
            lblAtaque.Text = pokémon.estadisticas.ataque.ToString();
            lblDefensa.Text = pokémon.estadisticas.defensa.ToString();
            lblVelocidad.Text = pokémon.estadisticas.velocidad.ToString();

            listBoxAtaque1.Items.Clear();
            foreach (var ataque in pokémon.ataques)
            {
                listBoxAtaque1.Items.Add(ataque.Key + " - " + ataque.Value);
            }

            listo1 = true;
            listos();
            btnSeleccion1.Visible = false;
            listBoxEquipo1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Pokémon pokémon = (Pokémon)listBoxEquipo2.SelectedItem;

            progressBarVida2.Value = barra(pokémon.estadisticas.vidaMax, pokémon.estadisticas.vida);//----------------
            lbl_barra_vida_2.Text = "Vida: " + pokémon.estadisticas.vida.ToString();//---------------- 


            lblNombre2.Text = pokémon.nombre;
            lblTipo12.Text = pokémon.tipo.ToString();
            lblTipo22.Text = pokémon.tipo2.ToString();
            lblVida2.Text = pokémon.estadisticas.vida.ToString();
            lblAtaque2.Text = pokémon.estadisticas.ataque.ToString();
            lblDefensa2.Text = pokémon.estadisticas.defensa.ToString();
            lblVelocidad2.Text = pokémon.estadisticas.velocidad.ToString();

            listBoxAtaque2.Items.Clear();
            foreach (var ataque in pokémon.ataques)
            {
                listBoxAtaque2.Items.Add(ataque.Key + " - " + ataque.Value);

            }

            listo2 = true;
            listos();
            btnSeleccion2.Visible = false;
            listBoxEquipo2.Enabled = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarEquipo1();

            btnAtaque1.Visible = false;
            btnAtaque3.Visible = false;
            btnAtaque2.Visible = false;
            btnAtaque4.Visible = false;
        }

        private void listBoxEquipo2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarEquipo2();

            btnAtaque12.Visible = false;
            btnAtaque22.Visible = false;
            btnAtaque32.Visible = false;
            btnAtaque42.Visible = false;
        }

        private void btnAtaque1_Click(object sender, EventArgs e)
        {
            Pokémon pokémon1 = (Pokémon)listBoxEquipo1.SelectedItem;

            dañoAtaque1(daño1, pokémon1.tipo, pokémon1.tipo2);
            botonesDes2();

        }

        private void btnAtaque12_Click(object sender, EventArgs e)
        {
            Pokémon pokémon2 = (Pokémon)listBoxEquipo2.SelectedItem;

            dañoAtaque2(daño12, pokémon2.tipo, pokémon2.tipo2);
            botonesDes1();
        }
        private void btnAtaque2_Click(object sender, EventArgs e)
        {
            Pokémon pokémon1 = (Pokémon)listBoxEquipo1.SelectedItem;

            dañoAtaque1(daño2, pokémon1.tipo, pokémon1.tipo2);
            botonesDes2();
        }

        private void btnAtaque22_Click(object sender, EventArgs e)
        {
            Pokémon pokémon2 = (Pokémon)listBoxEquipo2.SelectedItem;

            dañoAtaque2(daño22, pokémon2.tipo, pokémon2.tipo2);
            botonesDes1();
        }

        private void btnAtaque3_Click(object sender, EventArgs e)
        {
            Pokémon pokémon1 = (Pokémon)listBoxEquipo1.SelectedItem;

            dañoAtaque1(daño3, pokémon1.tipo, pokémon1.tipo2);
            botonesDes2();
        }

        private void btnAtaque32_Click(object sender, EventArgs e)
        {
            Pokémon pokémon2 = (Pokémon)listBoxEquipo2.SelectedItem;

            dañoAtaque2(daño32, pokémon2.tipo, pokémon2.tipo2);
            botonesDes1();
        }

        private void btnAtaque4_Click(object sender, EventArgs e)
        {
            Pokémon pokémon1 = (Pokémon)listBoxEquipo1.SelectedItem;

            dañoAtaque1(daño4, pokémon1.tipo, pokémon1.tipo2);
            botonesDes2();
        }

        private void btnAtaque42_Click(object sender, EventArgs e)
        {
            Pokémon pokémon2 = (Pokémon)listBoxEquipo2.SelectedItem;

            dañoAtaque2(daño42, pokémon2.tipo, pokémon2.tipo2);
            botonesDes1();
        }

        private void botonesDes1()
        {
            btnSeleccion1.Visible = true;
            btnSeleccion2.Visible = false;

            listBoxEquipo1.Enabled = true;
            listBoxEquipo2.Enabled = false;

            if (listBoxEquipo1.Enabled = true)
            {
                turnoEquipo2.BackColor = Color.Red;
                turnoEquipo1.BackColor = Color.Green;
            }

            btnAtaque1.Visible = true;
            btnAtaque3.Visible = true;
            btnAtaque2.Visible = true;
            btnAtaque4.Visible = true;

            btnAtaque12.Visible = false;
            btnAtaque22.Visible = false;
            btnAtaque32.Visible = false;
            btnAtaque42.Visible = false;

            cargarEquipo1();
        }
        private void botonesDes2()
        {
            btnSeleccion1.Visible = false;
            btnSeleccion2.Visible = true;

            listBoxEquipo1.Enabled = false;
            listBoxEquipo2.Enabled = true;

            if (listBoxEquipo2.Enabled = true)
            {
                turnoEquipo2.BackColor = Color.Green;
                turnoEquipo1.BackColor = Color.Red;
            }

            btnAtaque1.Visible = false;
            btnAtaque3.Visible = false;
            btnAtaque2.Visible = false;
            btnAtaque4.Visible = false;

            btnAtaque12.Visible = true;
            btnAtaque22.Visible = true;
            btnAtaque32.Visible = true;
            btnAtaque42.Visible = true;

            cargarEquipo2();
        }
        private void listos()
        {
            if (listo1 == true && listo2 == true)
            {
                Pokémon pokémon1 = (Pokémon)listBoxEquipo1.SelectedItem;
                Pokémon pokémon2 = (Pokémon)listBoxEquipo2.SelectedItem;

                if (pokémon1.estadisticas.velocidad >= pokémon2.estadisticas.velocidad)
                {
                    turno1 = true;
                    turno2 = false;
                }
                if (pokémon1.estadisticas.velocidad < pokémon2.estadisticas.velocidad)
                {
                    turno1 = false;
                    turno2 = true;
                }
            }
            turno();
        }
        private void cargarEquipo1()
        {
            Pokémon pokémon = (Pokémon)listBoxEquipo1.SelectedItem;
            lblNombre.Text = pokémon.nombre;
            lblTipo1.Text = pokémon.tipo.ToString();
            lblTipo2.Text = pokémon.tipo2.ToString();
            lblVida.Text = pokémon.estadisticas.vida.ToString();
            lblAtaque.Text = pokémon.estadisticas.ataque.ToString();
            lblDefensa.Text = pokémon.estadisticas.defensa.ToString();
            lblVelocidad.Text = pokémon.estadisticas.velocidad.ToString();

            listBoxAtaque1.Items.Clear();
            foreach (var ataque in pokémon.ataques)
            {
                listBoxAtaque1.Items.Add(ataque.Key + " - " + ataque.Value);
            }

            int i = 1;
            foreach (var ataque in pokémon.ataques)
            {
                switch (i)
                {
                    case 1:
                        btnAtaque1.Text = ataque.Key;
                        daño1 = ataque.Value;
                        break;
                    case 2:
                        btnAtaque3.Text = ataque.Key;
                        daño2 = ataque.Value;
                        break;
                    case 3:
                        btnAtaque2.Text = ataque.Key;
                        daño3 = ataque.Value;
                        break;
                    case 4:
                        btnAtaque4.Text = ataque.Key;
                        daño4 = ataque.Value;
                        break;
                }
                i++;
            }
        }
        private void cargarEquipo2()
        {
            Pokémon pokémon = (Pokémon)listBoxEquipo2.SelectedItem;
            lblNombre2.Text = pokémon.nombre;
            lblTipo12.Text = pokémon.tipo.ToString();
            lblTipo22.Text = pokémon.tipo2.ToString();
            lblVida2.Text = pokémon.estadisticas.vida.ToString();
            lblAtaque2.Text = pokémon.estadisticas.ataque.ToString();
            lblDefensa2.Text = pokémon.estadisticas.defensa.ToString();
            lblVelocidad2.Text = pokémon.estadisticas.velocidad.ToString();

            listBoxAtaque2.Items.Clear();
            foreach (var ataque in pokémon.ataques)
            {
                listBoxAtaque2.Items.Add(ataque.Key + " - " + ataque.Value);

            }

            int i = 1;
            foreach (var ataque in pokémon.ataques)
            {
                switch (i)
                {
                    case 1:
                        btnAtaque12.Text = ataque.Key;
                        daño12 = ataque.Value;
                        break;
                    case 2:
                        btnAtaque22.Text = ataque.Key;
                        daño22 = ataque.Value;
                        break;
                    case 3:
                        btnAtaque32.Text = ataque.Key;
                        daño32 = ataque.Value;
                        break;
                    case 4:
                        btnAtaque42.Text = ataque.Key;
                        daño42 = ataque.Value;
                        break;
                }
                i++;
            }
        }
        private void turno()
        {
            if (turno1 == true && turno2 == false)
            {
                botonesDes1();
            }
            if (turno1 == false && turno2 == true)
            {
                botonesDes2();
            }

        }
        private void dañoAtaque1(int dañoHabilidad, Tipo tipoAtaque, Tipo tipoAtaque2)
        {
            Pokémon pokémon = (Pokémon)listBoxEquipo1.SelectedItem;
            Pokémon pokémon2 = (Pokémon)listBoxEquipo2.SelectedItem;
            Random random = new Random();
            int vida = pokémon2.estadisticas.vidaMax;
            int ataqueRival = pokémon.estadisticas.ataque;
            int defensa = pokémon2.estadisticas.defensa;

            bool esDebilidad = pokémon2.debilidades.debilidades.Contains(tipoAtaque);
            bool esDebilidad2 = pokémon2.debilidades.debilidades.Contains(tipoAtaque2);

            int daño = calcularDaño(vida, defensa, ataqueRival, dañoHabilidad);

            if (esDebilidad)
            {
                daño = (int)(daño * 1.25);
            }
            else if (esDebilidad2)
            {
                daño = (int)(daño * 1.25);
            }

            int numero = random.Next(1,11);
            switch (numero)
            {
                case 1:
                    daño = (daño * 2);
                    MessageBox.Show("Entreo en el critico 1");
                    break;
                case 2:
                    daño = (daño * 2);
                    MessageBox.Show("Entreo en el critico 2");
                    break;
                case 3:
                    daño = (daño * 2);
                    MessageBox.Show("Entreo en el critico 3");
                    break;
                case 4:
                    daño = (daño * 2);
                    MessageBox.Show("Entreo en el critico 4");
                    break;
                default:
                    break;
            }

            if (daño < 0)
            {
                pokémon2.estadisticas.vida -= Math.Abs(daño);
            }

            if (pokémon2.estadisticas.vida <= 0)
            {
                foreach (var item in listBoxEquipo1.Items)
                {
                    listBoxEquipo1.Items.Remove(item);
                    progressBarVida1.Value = 0;//----------------
                }
                
            }
            progressBarVida1.Value = barra(pokémon.estadisticas.vidaMax, pokémon.estadisticas.vida);//----------------
            lbl_barra_vida_1.Text = "Vida: " + pokémon.estadisticas.vida.ToString();//----------------

            borrarDatos1();
        }
        private void dañoAtaque2(int dañoHabilidad, Tipo tipoAtaque, Tipo tipoAtaque2)
        {
            Pokémon pokémon = (Pokémon)listBoxEquipo1.SelectedItem;
            Pokémon pokémon2 = (Pokémon)listBoxEquipo2.SelectedItem;
            Random random = new Random();
            int vida = pokémon.estadisticas.vidaMax;
            int ataqueRival = pokémon2.estadisticas.ataque;
            int defensa = pokémon.estadisticas.defensa;

            bool esDebilidad = pokémon.debilidades.debilidades.Contains(tipoAtaque);
            bool esDebilidad2 = pokémon.debilidades.debilidades.Contains(tipoAtaque2);

            int daño = calcularDaño(vida, defensa, ataqueRival, dañoHabilidad);

            if (esDebilidad)
            {
                daño = (int)(daño * 1.25);
            }
            else if (esDebilidad2)
            {
                daño = (int)(daño * 1.25);
            }

            int numero = random.Next(1, 11);
            switch (numero)
            {
                case 1:
                    daño = (daño * 2);
                    MessageBox.Show("Entreo en el critico 1");
                    break;
                case 2:
                    daño = (daño * 2);
                    MessageBox.Show("Entreo en el critico 2");
                    break;
                case 3:
                    daño = (daño * 2);
                    MessageBox.Show("Entreo en el critico 3");
                    break;
                case 4:
                    daño = (daño * 2);
                    MessageBox.Show("Entreo en el critico 4");
                    break;
                default:
                    break;
            }

            if (daño < 0)
            {
                pokémon.estadisticas.vida -= Math.Abs(daño);
            }

            if (pokémon.estadisticas.vida <= 0)
            {
                foreach (var item in listBoxEquipo1.Items)
                {
                    listBoxEquipo1.Items.Remove(item);
                    progressBarVida1.Value = 0;//----------------
                }

            }
            progressBarVida2.Value = barra(pokémon.estadisticas.vidaMax, pokémon.estadisticas.vida);//----------------
            lbl_barra_vida_1.Text = "Vida: "+pokémon.estadisticas.vida.ToString();//----------------
            borrarDatos2();
        }
        private int calcularDaño(int vida, int defensa, int ataqueRival, int ataque)
        {
            int daño = (vida + defensa) - (ataqueRival + ataque);

            return daño;
        }

        private void borrarDatos1()
        {
            lblNombre.Text = "";
            lblTipo1.Text = "";
            lblTipo2.Text = "";
            lblVida.Text = "";
            lblAtaque.Text = "";
            lblDefensa.Text = "";
            lblVelocidad.Text = "";

            listBoxAtaque1.Items.Clear();
        }
        private void borrarDatos2()
        {
            lblNombre2.Text = "";
            lblTipo12.Text = "";
            lblTipo22.Text = "";
            lblVida2.Text = "";
            lblAtaque2.Text = "";
            lblDefensa2.Text = "";
            lblVelocidad2.Text = "";

            listBoxAtaque2.Items.Clear();
        }
        int barra(int vida_maxima, int vida)
        {
            int retornar = 0;
            if (vida > 0)
            {

                retornar = (vida * 100) / vida_maxima;
            }
            else retornar = 0;

            return retornar;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
