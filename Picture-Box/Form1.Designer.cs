using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;

namespace Picture_Box
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
            this.Text = "Picture";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // prevent resizing the form 

            // PictureBox
            
            PictureBox miPicture = new PictureBox();
            miPicture.Size = new Size(380, 200);
            miPicture.BorderStyle = BorderStyle.FixedSingle;
            miPicture.Location = new Point(200, 100);
            miPicture.SizeMode = PictureBoxSizeMode.StretchImage;

            // Load Event

            this.Load += (s,e)=>{


                try{
                    

                   string path = @"C:\Users\alan_\OneDrive\Escritorio\Magalan\Diseño\Cursos\Curso C# Udemy\Resources\na.jpg";

                   byte[] arrayImage = File.ReadAllBytes(path); // stored Image in an bytes array

                   using (MemoryStream ms = new MemoryStream(arrayImage)){ // the image array is stored in memory

                        miPicture.Image = Image.FromStream(ms); // Read the Image stored

                   }



                }catch(Exception ex){
                    
                    MessageBox.Show(ex.ToString());
                }



            }; 


            this.Controls.Add(miPicture);
             
        }

        #endregion
    }
}

