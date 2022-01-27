using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace List_Box
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
            this.Text = "List-Box";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // prevent resizing the form        

            // ListBox

            ListBox listBox1 = new ListBox();
            listBox1.Location = new Point(150, 50);
            listBox1.Size = new Size(500, 350);
            listBox1.MultiColumn = true; // Set the ListBox to display items in multiple columns.
            listBox1.SelectionMode = SelectionMode.MultiExtended;// Set the selection mode to multiple and extended.


            /*
        
            listBox1.BeginUpdate();
            // Loop through and add 50 items to the ListBox.
               for (int i = 1; i <= 20; i++)
               {
                  listBox1.Items.Add("Item " + i.ToString());
               }
               // Allow the ListBox to repaint and display the new items.
            listBox1.EndUpdate();

               for (int j = 1; j <= 20; j++)
               {
                  listBox1.SetSelected(j-1, true);
               }

            */
            
            List <string> listaCursos = new List<string>{
                
                "curso-Hakell", "curso-c#", "curso-batch",
                "curso-JavaScript", "curso-Java"

            };

            listBox1.DataSource = listaCursos;




            // Add to Form
            

            this.Controls.Add(listBox1);



















        #endregion
    }
  }

}
