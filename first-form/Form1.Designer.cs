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
            miLabel.Text = "into value";
            miLabel.Location = new Point(45, 0);

            Label labelImage = new Label();
            labelImage.AutoSize = false;
            Image newImage2 = Image.FromFile(@"C:\Users\alan_\OneDrive\Escritorio\Magalan\Diseño\Cursos\Curso C# Udemy\Maestro_C#\first-form\imgs\steich.png");
            labelImage.Size = new Size(50, 50);
            labelImage.Image = newImage2;

            Label labelShowValue = new Label();
            labelShowValue.AutoSize = true;
            labelShowValue.Font = new Font("Arial", 10); // Allow change size and the font
            labelShowValue.Text = "El valor ingresado es: ";
            labelShowValue.Location = new Point(300, 50);
            

            Label labelShowCombo = new Label();
            labelShowCombo.AutoSize = true;
            labelShowCombo.Font = new Font("Arial", 10); // Allow change size and the font
            labelShowCombo.Text = "valor del combo : ";
            labelShowCombo.Location = new Point(300, 175);

            Label labelShowValueNumeric = new Label();
            labelShowValueNumeric.AutoSize = true;
            labelShowValueNumeric.Font = new Font("Arial", 10); // Allow change size and the font
            labelShowValueNumeric.Text = "Valor : ";
            labelShowValueNumeric.Location = new Point(300, 230);

          //---------TextBox----------------
            TextBox miTextBox = new TextBox();
            miTextBox.Location = new Point(50,50);
            miTextBox.Width = 200;


          //---------ComboBox----------------
            ComboBox miCombito = new ComboBox();
            miCombito.Location = new Point (50, 175);
            miCombito.Width = 200;
            miCombito.Items.AddRange(new string []{"Messi", "Ronaldo", "Modric", "Carlos Perciavale"});

            
          //---------NumericUpDown----------------
            NumericUpDown numericUpDown1 = new NumericUpDown();
            numericUpDown1.Location = new Point(50, 230);
            numericUpDown1.Width = 200;

          //---------Button----------------
            Button btn1 = new Button();
            btn1.Location = new Point(50, 100);
            btn1.Text = "Send";
            btn1.Size = new Size(100, 50);
            
          // Suscribe Event 

            btn1.Click+=(s,e)=>{
            
              string valor = miTextBox.Text;

              labelShowValue.Text = "El valor ingresado es : " + valor;

            };


            Button btn2 = new Button();
            btn2.Location = new Point(50, 280);
            btn2.Text = "Show";
            btn2.Size = new Size(100, 50);
            
          // Suscribe Event 

            btn2.Click+=(s,e)=>{
            
              var valorNumeric = numericUpDown1.Value;

              labelShowValueNumeric.Text = "Valor : " + valorNumeric;

            };

            

            Button btn3 = new Button();
            btn3.Location = new Point(50, 205);
            btn3.Text = "Submit";
            btn3.Size = new Size(100, 25);
            
          // Suscribe Event 

            btn3.Click+=(s,e)=>{
            
              var valorCombo = miCombito.Text;

              labelShowCombo.Text = "valor del combo : " + valorCombo;

            };


          //---------DateTimePicker----------------
            DateTimePicker myDateTimePicker1 = new DateTimePicker();
            myDateTimePicker1.Location = new Point(50, 380);
            myDateTimePicker1.Width = 200;
            myDateTimePicker1.Format = DateTimePickerFormat.Short;

          //---------Add controls to Form----------------

             this.Controls.Add(miLabel);
           // this.Controls.Add(labelImage);
             this.Controls.Add(miTextBox);
             this.Controls.Add(btn1);
             this.Controls.Add(btn2);
             this.Controls.Add(btn3);
             this.Controls.Add(miCombito);
             this.Controls.Add(numericUpDown1);
             this.Controls.Add(myDateTimePicker1);
             this.Controls.Add(myDateTimePicker1);
             this.Controls.Add(labelShowValue);
             this.Controls.Add(labelShowValueNumeric);
             this.Controls.Add(labelShowCombo);
            





























        }

        #endregion
    }
}

