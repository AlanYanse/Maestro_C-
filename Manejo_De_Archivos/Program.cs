using System;
using System.Collections.Generic;
using System.IO;

namespace Manejo_De_Archivos
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Create a new directory

           // string path = @"C:\Users\alan_\OneDrive\Escritorio\Magalan\Diseño\Cursos\Curso C# Udemy\ClaseArchivo\Estudiantes"; // final at path add to directory name in this case "Estudiantes"
           // string path2 = @"C:\Users\alan_\OneDrive\Escritorio\Magalan\Diseño\Cursos\Curso C# Udemy\ClaseArchivo\Profesores";
            string path3 = @"C:\Users\alan_\OneDrive\Escritorio\Magalan\Diseño\Cursos\Curso C# Udemy\ClaseArchivo\Alumnos";


           //  Directory.CreateDirectory(path);

            // Delete a directory
            
           // Directory.Delete(path, true);// true params to force the directory delete
         
       // List<string> dirs = new List<string>(Directory.EnumerateDirectories(path2));

        // dirs.ForEach(p=>Console.WriteLine(p));
        

        List<string> dirs = new List<string>(Directory.EnumerateFiles(path3));

        dirs.ForEach(p=>Console.WriteLine(p));


            // ---------Directories information--------------

            
            string path3 = @"C:\Users\alan_\OneDrive\Escritorio\Magalan\Diseño\Cursos\Curso C# Udemy\ClaseArchivo";

            DirectoryInfo dir = new DirectoryInfo(path3);

            if(dir.Exists){
                Console.WriteLine("Existe el directorio");
            }else{
                Console.WriteLine("No existe el directorio");
            }

           // string path4 = @"C:\Users\alan_\OneDrive\Escritorio\Magalan\Diseño\Cursos\Curso C# Udemy\ClaseArchivo\Alumnos";
            string path5 = @"C:\Users\alan_\OneDrive\Escritorio\Magalan\Diseño\Cursos\Curso C# Udemy\ClaseArchivo\Entidades";


            DirectoryInfo dir = new DirectoryInfo(path5);


            // Console.WriteLine(dir.Root);

            // dir.Create();

            // dir.Delete();


            //------------------ Class File ----------------------
            



        string path6 = @"C:\Users\alan_\OneDrive\Escritorio\Magalan\Diseño\Cursos\Curso C# Udemy\ClaseArchivo\cisar.txt";

       // File.Create(path6);


        if(File.Exists(path6)){
            File.Delete(path6);
            Console.WriteLine("El archivo se ha borrado con succesfully");
        }else{
            File.Create(path6);
            Console.WriteLine("file has been created with succesfully");
        }

       
        List <string> nombres = new List <string>();

        nombres.Add("Din");
        nombres.Add("maga");
        nombres.Add("alan");
        nombres.Add("wuacho");
        nombres.Add("chuck");
        nombres.Add("cisco");
        nombres.Add("facu");

        File.AppendAllLines(@"C:\Users\alan_\OneDrive\Escritorio\Magalan\Diseño\Cursos\Curso C# Udemy\ClaseArchivo\cisar.txt", nombres);


        // Example for create a some kind text editor

        List <string> writeText = new List <string>();

        int i = 0;

        while(i < 50){

            writeText.Add(Console.ReadLine());
            i ++;
        }

        
        File.AppendAllLines(@"C:\Users\alan_\OneDrive\Escritorio\Magalan\Diseño\Cursos\Curso C# Udemy\ClaseArchivo\cisar.txt", writeText);



        // -------------- for enumerates files and directories -------------------    

        string path7 = @"C:\Users\alan_\OneDrive\Escritorio\Magalan\Diseño\Cursos\Curso C# Udemy\ClaseArchivo\Alumnos";

        

        List<string> dirsAndFiles = new List<string>(Directory.EnumerateFileSystemEntries(path7));

        dirsAndFiles.ForEach(p=>Console.WriteLine(p));

        string directorioActual = Directory.GetCurrentDirectory();

        Console.WriteLine("El directorio actual es :" +  directorioActual);

        


        // -------------- for move  files and directories and create a new directory -------------------    

            string path8 = @"C:\Users\alan_\OneDrive\Escritorio\Magalan\Diseño\Cursos\Curso C# Udemy\ClaseArchivo\Alumnos";

            string pathFinal = @"C:\Users\alan_\OneDrive\Escritorio\Magalan\Diseño\Cursos\Curso C# Udemy\ClaseArchivo\ruta-mover";

            Directory.Move(path8, pathFinal);




        // -------------- for copy a file in specific path -------------------    

            string pathOrigen = @"C:\Users\alan_\OneDrive\Escritorio\Magalan\Diseño\Cursos\Curso C# Udemy\ClaseArchivo\examen.txt";
       
            string pathDestino = @"C:\Users\alan_\OneDrive\Escritorio\Magalan\Diseño\Cursos\Curso C# Udemy\ClaseArchivo\ruta-mover\examen.txt";

            try{
                
                File.Copy(pathOrigen, pathDestino);
                Console.WriteLine("Archivo copiado con succesfully");
            }catch(Exception ex){
                
                Console.WriteLine(ex.Message);
            }


        

            string path9 = @"C:\Users\alan_\OneDrive\Escritorio\Magalan\Diseño\Cursos\Curso C# Udemy\ClaseArchivo\prueba.txt";

             using (StreamWriter sw = File.CreateText(path9)){

                sw.Write("Hola");     

            }


            string path10 = @"C:\Users\alan_\OneDrive\Escritorio\Magalan\Diseño\Cursos\Curso C# Udemy\ClaseArchivo\prueba.txt";

            if(File.Exists(path10)){

                 File.Delete(path10);
                Console.WriteLine("file has been deleted");
            }


            
            string path1Origin = @"C:\Users\alan_\OneDrive\Escritorio\Magalan\Diseño\Cursos\Curso C# Udemy\ClaseArchivo\examen.txt";

            string path2Final = @"C:\Users\alan_\OneDrive\Escritorio\Magalan\Diseño\Cursos\Curso C# Udemy\ClaseArchivo\ruta-mover\examen.txt";

            try{
                
                File.Move(path1Origin, path2Final);
                Console.WriteLine("file has been moved with succesfully");

            }catch(Exception ex){
                
                Console.WriteLine(ex.Message);
            }


            // ------------------------ ReadAllBytes and WriteAllBytes ---------------------------

            string pathImage = @"C:\Users\alan_\OneDrive\Escritorio\Magalan\Diseño\Cursos\Curso C# Udemy\ClaseArchivo\imagenes\mounstritos.jpg";

            string pathImageFinal = @"C:\Users\alan_\OneDrive\Escritorio\Magalan\Diseño\Cursos\Curso C# Udemy\ClaseArchivo\ruta-mover\mounstritos.jpg";

            byte[] imagen = File.ReadAllBytes(pathImage);

           // Array.ForEach(imagen, b=> Console.WriteLine(b));


            try{
                
                File.WriteAllBytes(pathImageFinal, imagen);
                Console.WriteLine("Image has been copied  with succesfully");

            }catch(Exception ex){

                Console.WriteLine(ex.Message);
            }



        string path20 = @"C:\Users\alan_\OneDrive\Escritorio\Magalan\Diseño\Cursos\Curso C# Udemy\ClaseArchivo\ruta-mover\examen.txt";

        string content = "today i am learning to match";

        File.WriteAllText(path20, content);

            string pathOrigen = @"C:\Users\alan_\OneDrive\Escritorio\Magalan\Diseño\Cursos\Curso C# Udemy\ClaseArchivo\ruta-mover\examen.txt";
            
            string pathDestino = @"C:\Users\alan_\OneDrive\Escritorio\Magalan\Diseño\Cursos\Curso C# Udemy\ClaseArchivo\ruta-mover\contenido.txt";

            string contenidoArchivo = File.ReadAllText(pathOrigen);

            try{
                File.WriteAllText(pathDestino, contenidoArchivo);
                Console.WriteLine("content has been copied with succesfully");
            }catch(Exception ex){
                
                 Console.WriteLine(ex.Message);
            }


            
            //----------- File.ReadAllLines() -----------------

            string nuevoPath =  @"C:\Users\alan_\OneDrive\Escritorio\Magalan\Diseño\Cursos\Curso C# Udemy\ClaseArchivo\ruta-mover\contenido.txt";

            string[] lines = File.ReadAllLines(nuevoPath);

            Array.ForEach(lines, p=>Console.WriteLine(p));


        */
            //------------ Class FileInfo ------------------------


            string otroPath =  @"C:\Users\alan_\OneDrive\Escritorio\Magalan\Diseño\Cursos\Curso C# Udemy\ClaseArchivo\ruta-mover\contenido.txt";

            FileInfo f = new FileInfo(otroPath);

            Console.WriteLine(f.Exists);
            Console.WriteLine(f.Length);
            Console.WriteLine(f.Directory);
            Console.WriteLine(f.Name);






























             









        }
    }
}
