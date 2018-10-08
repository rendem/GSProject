using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Fuel_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
              
        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        double D_Gasoline95 = 0, D_Gasoline97 = 0, D_Diesel = 0, D_euroDiesel = 0, D_lpg = 0;
        double E_Gasoline95 = 0, E_Gasoline97 = 0, E_Diesel = 0, E_euroDiesel = 0, E_lpg = 0;
        double F_Gasoline95 = 0, F_Gasoline97 = 0, F_Diesel = 0, F_euroDiesel = 0, F_lpg = 0;
        double S_Gasoline95 = 0, S_Gasoline97 = 0, S_Diesel = 0, S_euroDiesel = 0, S_lpg = 0;

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            S_Gasoline95 = double.Parse(numericUpDown1.Value.ToString());
            S_Gasoline97 = double.Parse(numericUpDown2.Value.ToString());
            S_Diesel = double.Parse(numericUpDown3.Value.ToString());
            S_euroDiesel = double.Parse(numericUpDown4.Value.ToString());
            S_lpg = double.Parse(numericUpDown5.Value.ToString());

            if (numericUpDown1.Enabled == true)
            {
                D_Gasoline95 = D_Gasoline95 - S_Gasoline95;
                label29.Text = Convert.ToString(S_Gasoline95 * F_Gasoline95);
            }
            else if (numericUpDown2.Enabled == true)
            {
                D_Gasoline97 = D_Gasoline97 - S_Gasoline97;
                label29.Text = Convert.ToString(S_Gasoline97 * F_Gasoline97);
            }
            else if (numericUpDown3.Enabled == true)
            {
                D_Diesel = D_Diesel - S_Diesel;
                label29.Text = Convert.ToString(S_Diesel * F_Diesel);
            }
            else if (numericUpDown4.Enabled == true)
            {
                D_euroDiesel = D_euroDiesel - S_euroDiesel;
                label29.Text = Convert.ToString(S_euroDiesel * F_euroDiesel);
            }
            else if (numericUpDown5.Enabled == true)
            {
                D_lpg = D_lpg - S_lpg;
                label29.Text = Convert.ToString(S_lpg * F_lpg);
            }

            tank_info[0] = Convert.ToString(D_Gasoline95);
            tank_info[1] = Convert.ToString(D_Gasoline97);
            tank_info[2] = Convert.ToString(D_Diesel);
            tank_info[3] = Convert.ToString(D_euroDiesel);
            tank_info[4] = Convert.ToString(D_lpg);

            System.IO.File.WriteAllLines(Application.StartupPath + "\\tank.txt", tank_info);
            txt_tank_read();
            txt_tank_write();
            progressBar_update();
            numericupdown_value();

            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
            numericUpDown5.Value = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Gasoline 95 Octane")
            {
                numericUpDown1.Enabled = true;
                numericUpDown2.Enabled = false;
                numericUpDown3.Enabled = false;
                numericUpDown4.Enabled = false;
                numericUpDown5.Enabled = false;
            }
            else if (comboBox1.Text == "Gasoline 97 Octane")
            {
                numericUpDown1.Enabled = false;
                numericUpDown2.Enabled = true;
                numericUpDown3.Enabled = false;
                numericUpDown4.Enabled = false;
                numericUpDown5.Enabled = false;
            }
            else if (comboBox1.Text == "Diesel")
            {
                numericUpDown1.Enabled = false;
                numericUpDown2.Enabled = false;
                numericUpDown3.Enabled = true;
                numericUpDown4.Enabled = false;
                numericUpDown5.Enabled = false;
            }
            else if (comboBox1.Text == "Euro Diesel")
            {
                numericUpDown1.Enabled = false;
                numericUpDown2.Enabled = false;
                numericUpDown3.Enabled = false;
                numericUpDown4.Enabled = true;
                numericUpDown5.Enabled = false;
            }
            else if (comboBox1.Text == "LPG")
            {
                numericUpDown1.Enabled = false;
                numericUpDown2.Enabled = false;
                numericUpDown3.Enabled = false;
                numericUpDown4.Enabled = false;
                numericUpDown5.Enabled = true;
            }

            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
            numericUpDown5.Value = 0;

            label29.Text = "_______";
        }

        string[] tank_info;
        string[] price_info;

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                F_Gasoline95 = F_Gasoline95+(F_Gasoline95*Convert.ToDouble(textBox6.Text)/100);
                price_info[0] = Convert.ToString(F_Gasoline95);
            }
            catch (Exception)
            {
                textBox6.Text = "Error";
            }

            try
            {                
                F_Gasoline97 = F_Gasoline97 + (F_Gasoline97 * Convert.ToDouble(textBox7.Text) / 100);
                price_info[1] = Convert.ToString(F_Gasoline97);
            }
            catch (Exception)
            {
                textBox7.Text = "Error";
            }

            try
            {               
                F_Diesel = F_Diesel + (F_Diesel * Convert.ToDouble(textBox8.Text) / 100);
                price_info[2] = Convert.ToString(F_Diesel);
            }
            catch (Exception)
            {
                textBox8.Text = "Error";
            }

            try
            {                
                F_euroDiesel = F_euroDiesel + (F_euroDiesel * Convert.ToDouble(textBox9.Text) / 100);
                price_info[3] = Convert.ToString(F_euroDiesel);
            }
            catch (Exception)
            {
                textBox9.Text = "Error";
            }

            try
            {                
                F_lpg = F_lpg + (F_lpg * Convert.ToDouble(textBox10.Text) / 100);
                price_info[4] = Convert.ToString(F_lpg);
            }
            catch (Exception)
            {
                textBox10.Text = "Error";
            }     
            System.IO.File.WriteAllLines(Application.StartupPath + "\\price.txt", price_info);
            txt_price_read();
            txt_price_write();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                E_Gasoline95 = Convert.ToDouble(textBox1.Text);
                if (1000 < D_Gasoline95 + E_Gasoline95 || E_Gasoline95 <= 0)
                {
                    textBox1.Text = "Error!";
                }
                else
                {
                    tank_info[0] = Convert.ToString(D_Gasoline95 + E_Gasoline95);
                }
            }
            catch (Exception)
            {
                textBox1.Text = "Error!";
            }

            try
            {
                E_Gasoline97 = Convert.ToDouble(textBox2.Text);
                if (1000 < D_Gasoline97 + E_Gasoline97 || E_Gasoline97 <= 0)
                {
                    textBox2.Text = "Error!";
                }
                else
                {
                    tank_info[1] = Convert.ToString(D_Gasoline97 + E_Gasoline97);
                }
            }
            catch (Exception)
            {
                textBox2.Text = "Error!";
            }

            try
            {
                E_Diesel = Convert.ToDouble(textBox3.Text);
                if (1000 < D_Diesel + E_Diesel || E_Diesel <= 0)
                {
                    textBox3.Text = "Error!";
                }
                else
                {
                    tank_info[2] = Convert.ToString(D_Diesel + E_Diesel);
                }
            }
            catch (Exception)
            {
                textBox3.Text = "Error!";
            }

            try
            {
                E_euroDiesel = Convert.ToDouble(textBox4.Text);
                if (1000 < D_euroDiesel + E_euroDiesel || E_euroDiesel <= 0)
                {
                    textBox4.Text = "Error!";
                }
                else
                {
                    tank_info[3] = Convert.ToString(D_euroDiesel + E_euroDiesel);
                }
            }
            catch (Exception)
            {
                textBox4.Text = "Error!";
            }

            try
            {
                E_lpg = Convert.ToDouble(textBox5.Text);
                if (1000 < D_lpg + E_lpg || E_lpg <= 0)
                {
                    textBox5.Text = "Error!";
                }
                else
                {
                    tank_info[4] = Convert.ToString(D_lpg + E_lpg);
                }
            }
            catch (Exception)
            {
                textBox5.Text = "Error!";
            }

            System.IO.File.WriteAllLines(Application.StartupPath + "\\tank.txt",tank_info);
            txt_tank_read();
            txt_tank_write();
            progressBar_update();
            numericupdown_value();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Fuel Automation";
            progressBar1.Maximum = 1000;progressBar2.Maximum = 1000;progressBar3.Maximum = 1000;
            progressBar4.Maximum = 1000;progressBar5.Maximum = 1000;

            txt_tank_read();
            txt_tank_write();

            txt_price_read();
            txt_price_write();

            progressBar_update();

            numericupdown_value();

            string[] yakit_turleri = { "Gasoline 95 Octane", "Gasoline 97 Octane", "Diesel", "Euro Diesel", "LPG" };
            comboBox1.Items.AddRange(yakit_turleri);

            numericUpDown1.Enabled = false;
            numericUpDown2.Enabled = false;
            numericUpDown3.Enabled = false;
            numericUpDown4.Enabled = false;
            numericUpDown5.Enabled = false;

            numericUpDown1.DecimalPlaces = 2;
            numericUpDown2.DecimalPlaces = 2;
            numericUpDown3.DecimalPlaces = 2;
            numericUpDown4.DecimalPlaces = 2;
            numericUpDown5.DecimalPlaces = 2;

            numericUpDown1.Increment = 0.1M;
            numericUpDown2.Increment = 0.1M;
            numericUpDown3.Increment = 0.1M;
            numericUpDown4.Increment = 0.1M;
            numericUpDown5.Increment = 0.1M;

            numericUpDown1.ReadOnly = true;
            numericUpDown2.ReadOnly = true;
            numericUpDown3.ReadOnly = true;
            numericUpDown4.ReadOnly = true;
            numericUpDown5.ReadOnly = true;

        }

        private void progressBar_update()
        {
            progressBar1.Value = Convert.ToInt16(D_Gasoline95); 
            progressBar2.Value = Convert.ToInt16(D_Gasoline97);
            progressBar3.Value = Convert.ToInt16(D_Diesel);
            progressBar4.Value = Convert.ToInt16(D_euroDiesel);
            progressBar5.Value = Convert.ToInt16(D_lpg);
        }

        private void txt_tank_read()
        {
            tank_info = System.IO.File.ReadAllLines(Application.StartupPath + "\\tank.txt");
            D_Gasoline95 = Convert.ToDouble(tank_info[0]);
            D_Gasoline97 = Convert.ToDouble(tank_info[1]);
            D_Diesel = Convert.ToDouble(tank_info[2]);
            D_euroDiesel = Convert.ToDouble(tank_info[3]);
            D_lpg = Convert.ToDouble(tank_info[4]);
        }

        private void txt_tank_write()
        {
            label6.Text = D_Gasoline95.ToString("N");
            label7.Text = D_Gasoline97.ToString("N");
            label8.Text = D_Diesel.ToString("N");
            label9.Text = D_euroDiesel.ToString("N");
            label10.Text = D_lpg.ToString("N"); 
        }

        private void txt_price_read()
        {
            price_info = System.IO.File.ReadAllLines(Application.StartupPath + "\\price.txt");
            F_Gasoline95 = Convert.ToDouble(price_info[0]);
            F_Gasoline97 = Convert.ToDouble(price_info[1]);
            F_Diesel = Convert.ToDouble(price_info[2]);
            F_euroDiesel = Convert.ToDouble(price_info[3]);
            F_lpg = Convert.ToDouble(price_info[4]);
        }

        private void txt_price_write()
        {
            label16.Text = F_Gasoline95.ToString("N");
            label17.Text = F_Gasoline97.ToString("N");
            label18.Text = F_Diesel.ToString("N");
            label19.Text = F_euroDiesel.ToString("N");
            label20.Text = F_lpg.ToString("N");
        }

        private void numericupdown_value()
        {
            numericUpDown1.Maximum =decimal.Parse(D_Gasoline95.ToString());
            numericUpDown2.Maximum = decimal.Parse(D_Gasoline97.ToString());
            numericUpDown3.Maximum = decimal.Parse(D_Diesel.ToString());
            numericUpDown4.Maximum = decimal.Parse(D_euroDiesel.ToString());
            numericUpDown5.Maximum = decimal.Parse(D_lpg.ToString());

        }

    }
}
