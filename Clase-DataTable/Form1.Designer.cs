using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data;

namespace Clase_DataTable
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
            this.Text = "DataTable";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // prevent resizing the form           


            // DataGridView

            DataGridView miDataGrid = new DataGridView();
            miDataGrid.Size = new Size(600, 400);
            miDataGrid.Location = new Point(100, 25);        
            miDataGrid.AllowUserToAddRows = false;
            miDataGrid.ReadOnly = true;
            miDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            
            this.Controls.Add(miDataGrid);


            // Event zone
            

            this.Load += (s, e)=>{

                ConfigureDataTable(miDataGrid);


            };


        
         }

        
        private void ConfigureDataTable(DataGridView grilla){

            
            // Create a DataTable

            DataTable tablaPersona = new DataTable();
           
            tablaPersona.Columns.Add("Nombre ", Type.GetType("System.String") );
            tablaPersona.Columns.Add("Edad ", Type.GetType("System.Int32") );
            tablaPersona.Columns.Add("Sueldo ", Type.GetType("System.Double") );

            // fill Data fields

            DataRow fila1 = tablaPersona.NewRow();

            fila1[0] = "din";
            fila1[1] =  3;
            fila1[2] = 1000.5;

            DataRow fila2 = tablaPersona.NewRow();
           
            fila2[0] = "cisco";
            fila2[1] = 33;
            fila2[2] = 800.8;

            DataRow fila3 = tablaPersona.NewRow();
           
            fila3[0] = "Chuck";
            fila3[1] = 34;
            fila3[2] = 500;

            // Add rows to Table
            
            tablaPersona.Rows.Add(fila1);
            tablaPersona.Rows.Add(fila2);
            tablaPersona.Rows.Add(fila3);

            // Add Table to Grid

            grilla.DataSource = tablaPersona;


        }







        
         #endregion
    }
}

