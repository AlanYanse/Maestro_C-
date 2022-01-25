using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Combo_Box
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {

            // The Form

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "ComboBox";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // prevent resizing the form

            // ComboBox

            ComboBox miCombito = new ComboBox();
            miCombito.Location = new Point(300, 100);
            miCombito.Width = 200;


            // Load Event Form

            this.Load +=(s, e)=>{
              
                List <Persona> listaPersona = new List <Persona>();

                listaPersona.Add(new Persona(1, "Din"));
                listaPersona.Add(new Persona(2, "Maga"));
                listaPersona.Add(new Persona(3, "Alan"));
                
                miCombito.DataSource = listaPersona;
                miCombito.DisplayMember = "Nombre";
                miCombito.ValueMember = "Id";
               

            };


            
            // Buttons

            Button btn1 = new Button();
            btn1.Location = new Point(100, 200);
            btn1.Text = "Mostrar";
            btn1.Size = new Size(100, 50);
            
            // Suscribe Event

            btn1.Click += (s, e)=>{

                string nombrePersona = miCombito.Text;

                MessageBox.Show(nombrePersona);

            };



            Button btn2 = new Button();
            btn2.Location = new Point(250, 200);
            btn2.Text = "Valor";
            btn2.Size = new Size(100, 50);
            
            // Suscribe Event

            btn2.Click += (s, e)=>{

                string valorPersona = miCombito.SelectedValue.ToString();

                MessageBox.Show(valorPersona);

            };


            Button btn3 = new Button();
            btn3.Location = new Point(400, 200);
            btn3.Text = "Mostar mas";
            btn3.Size = new Size(100, 50);
            
            // Suscribe Event

            btn3.Click += (s, e)=>{

                Persona objPersona =(Persona) miCombito.SelectedItem;

                MessageBox.Show("ID " + objPersona.Id + " Nombre " + objPersona.Nombre);

            };




            // Add ComboBox to the Form

            this.Controls.Add(miCombito);
            this.Controls.Add(btn1);
            this.Controls.Add(btn2);
            this.Controls.Add(btn3);




        }

        #endregion
    }
}

