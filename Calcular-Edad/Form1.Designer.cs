using System;
using System.Drawing;
using System.Windows.Forms;

namespace Calcular_Edad
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
            this.Text = "Calcular edad";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // prevent resizing the form
            
            // Labels

            Label labelValor1 = new Label();
            labelValor1.AutoSize = true;
            labelValor1.Font = new Font("Arial", 10); // Allow change size and the font
            labelValor1.Text = "Ingresar edad :";
            labelValor1.Location = new Point(100, 50);
            


            // NumericUpDown

            NumericUpDown numericUpDown1 = new NumericUpDown();
            numericUpDown1.Location = new Point(300, 50);
            numericUpDown1.Width = 200;

            NumericUpDown numericUpDown2 = new NumericUpDown();
            numericUpDown2.Location = new Point(300, 100);
            numericUpDown2.Width = 200;
            
            NumericUpDown numericUpDown3 = new NumericUpDown();
            numericUpDown3.Location = new Point(300, 150);
            numericUpDown3.Width = 200;
            
            // TextBox

            TextBox miTextBox = new TextBox();
            miTextBox.Location = new Point(300, 200);
            miTextBox.Width = 200;
            miTextBox.ReadOnly = true; // Prevent to the data entries

            // Buttons

            Button btn1 = new Button();
            btn1.Location = new Point(100, 200);
            btn1.Text = "calcular";
            btn1.Size = new Size(100, 50);
            
          // Suscribe Event 

            btn1.Click+=(s,e)=>{
            


              Action <decimal> calcularEdad = (edad)=>{
                    
                  if(edad < 18){
                      
                      miTextBox.Text = "sois menor de edad";
                      
                  }else{
                       miTextBox.Text = "sois mayor de edad";
                  }

                };

                    calcularEdad(numericUpDown1.Value);


            };


            // Add to Form

            this.Controls.Add(labelValor1);
            this.Controls.Add(numericUpDown1);
            this.Controls.Add(miTextBox);
            this.Controls.Add(btn1);


        }

        #endregion
    }
}

