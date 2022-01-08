using System.Drawing;
using System.Windows.Forms;
namespace first_form

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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.Text = "My first form with dotnet";
           // Image newImage = Image.FromFile(@"C:\Users\alan_\OneDrive\Escritorio\Magalan\Diseño\Cursos\Curso C# Udemy\Maestro_C#\first-form\imgs\el duraznito 2021.jpg");
           // this.BackgroundImage = newImage;
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // prevent resizing the form
            
          //---------ADD Controls----------------
          
          //---------Label----------------

            Label miLabel = new Label();
            miLabel.AutoSize = true;
            miLabel.Font = new Font("Arial", 16); // Allow change size and the font
            miLabel.Text = "Press the dinovin button";
            miLabel.Location = new Point(45, 0);

            Label labelImage = new Label();
            labelImage.AutoSize = false;
            Image newImage2 = Image.FromFile(@"C:\Users\alan_\OneDrive\Escritorio\Magalan\Diseño\Cursos\Curso C# Udemy\Maestro_C#\first-form\imgs\steich.png");
            labelImage.Size = new Size(50, 50);
            labelImage.Image = newImage2;

          //---------TextBox----------------
            TextBox miTextBox = new TextBox();
            miTextBox.Location = new Point(50,50);
            miTextBox.Width = 200;

          //---------Button----------------
            Button btn1 = new Button();
            btn1.Location = new Point(50, 100);
            btn1.Text = "Dinovin";
            btn1.Size = new Size(100, 50);

          //---------ComboBox----------------
            ComboBox miCombito = new ComboBox();
            miCombito.Location = new Point (50, 175);
            miCombito.Width = 200;
            miCombito.Items.AddRange(new string []{"Maga", "Din", "Alan", "Sao"});

          //---------NumericUpDown----------------
            NumericUpDown numericUpDown1 = new NumericUpDown();
            numericUpDown1.Location = new Point(50, 230);
            numericUpDown1.Width = 200;

          //---------DateTimePicker----------------
            DateTimePicker myDateTimePicker1 = new DateTimePicker();
            myDateTimePicker1.Location = new Point(50, 280);
            myDateTimePicker1.Width = 200;
            myDateTimePicker1.Format = DateTimePickerFormat.Short;

          //---------Add controls to Form----------------

             this.Controls.Add(miLabel);
           // this.Controls.Add(labelImage);
             this.Controls.Add(miTextBox);
             this.Controls.Add(btn1);
             this.Controls.Add(miCombito);
             this.Controls.Add(numericUpDown1);
             this.Controls.Add(myDateTimePicker1);

            





























        }

        #endregion
    }
}

