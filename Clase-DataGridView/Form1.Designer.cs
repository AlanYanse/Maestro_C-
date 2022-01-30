using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
namespace Clase_DataGridView
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
            this.Text = "DataGrid";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // prevent resizing the form         

            // DataGridView

            DataGridView miDataGrid = new DataGridView();
            miDataGrid.Size = new Size(600, 400);
            miDataGrid.Location = new Point(100, 25);
            
            // Create an unbound DataGridView by declaring a column count.

            miDataGrid.ColumnCount = 2;
            miDataGrid.ColumnHeadersVisible = true;

            // Fill to  DataGrid header 
          
            miDataGrid.Columns[0].Name = "Nombre";
            miDataGrid.Columns[1].Name = "Apellido";
            
            // Fill to DataGrid rows
            
            miDataGrid.Rows.Add("Din", "Yanse");

            // Add component to form

            this.Controls.Add(miDataGrid);

        }

        #endregion
    }
}

