using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyectro
{
    public partial class Form1 : Form
    {
        private int click = 0;

        //Filas para agregar o quitar filas en el datagrid
         private int conteoFilas=0;


        private void PropiedadesCeldas()
        {
            for (int i = 0; i < getCF(); i++)
            {
                for (int j = 0; j < 5; j++)
                {

                    if (i == 0 && j % 2 == 0)
                    {
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Gray;
                        dataGridView1.Rows[i].Cells[j].ReadOnly = true;
                        dataGridView1.Rows[0].Cells[0].Value = "#Grupo";
                        dataGridView1.Rows[0].Cells[1].Value = "Usuario";
                        dataGridView1.Rows[0].Cells[2].Value = "Clave";
                        dataGridView1.Rows[0].Cells[3].Value = "Nombre";
                        dataGridView1.Rows[0].Cells[4].Value = "Asesores";
                        dataGridView1.Rows[i].Cells[j].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        dataGridView1.Rows[i].Cells[j].Style.Font = new System.Drawing.Font("Museo Sans Cyrl 100", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        dataGridView1.Rows[i].Height = 100;
                        dataGridView1.Columns[j].Width = 138;
                    }
                    if (i == 0 && j % 2 != 0)
                    {
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Gray;
                        dataGridView1.Rows[i].Cells[j].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        dataGridView1.Rows[i].Cells[j].Style.Font = new System.Drawing.Font("Museo Sans Cyrl 100", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        dataGridView1.Rows[i].Cells[j].ReadOnly = true;
                    }
                    if (i % 2 != 0 && j % 2 == 0)
                    {
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.White;

                    }
                    if (i % 2 != 0 && j % 2 != 0)
                    {
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.White;
                        dataGridView1.Rows[i].Height = 100;
                        dataGridView1.Columns[j].Width = 138;

                    }
                }
            }
        }
        public void setCF(int x)
        {
            conteoFilas = conteoFilas+x;
        }
        public int getCF()
        {
            return conteoFilas;
        }
        public Form1()
        {
            InitializeComponent();
            this.WindowState= System.Windows.Forms.FormWindowState.Maximized;
            setCF(2);

            for (int i = 0; i < 5; i++)
            {
                dataGridView1.Columns.Add(i.ToString(), i.ToString());
            }
            for (int j = 0; j < getCF(); j++)
            {
                dataGridView1.Rows.Add();
            }

            PropiedadesCeldas();
        }
    

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void setClick(int x)
        {
            int y = getClick();
            y = getClick() + x;
            this.click = y;
        }
        private int getClick()
        {
            return click;
        }


        public void selector()
        {
            
            if(click == 1)
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                dataGridView1.Visible = true;
                dataGridView2.Visible = true;
                pictureBox9.Visible = true;
                pictureBox10.Visible = true;
                pictureBox9.Visible = true;
            }
            else if(click ==0)
            {
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                dataGridView1.Visible = false;
            }
        }

        

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            setClick(1);
            selector();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            setClick(2);
            selector();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            setClick(3);
            selector();
        }



        private void pictureBox8_Click_1(object sender, EventArgs e)
        {
            setClick(-1);
            selector();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        //Agrega filas
        private void pictureBox12_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
            setCF(1);
            PropiedadesCeldas();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

            //Leer datagrid y asignar los valores 

            for(int i=0;i<conteoFilas;i++)
            {
                
            }
        }
    }
}

