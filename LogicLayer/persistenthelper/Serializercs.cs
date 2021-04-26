
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace LogicLayer.persistenthelper
{
    public class Serialize
    {

        public string serialize(object objeto, string directiorio, string fileName)
        {
            crearDirectorio(directiorio);
            IFormatter formatter = new BinaryFormatter();

            Stream stream = new FileStream(Directory.GetCurrentDirectory() + "/" + directiorio + "/" + fileName, FileMode.Create, FileAccess.Write);

            formatter.Serialize(stream, objeto);
            stream.Close();
            stream.Dispose();
            return Directory.GetCurrentDirectory() + "/" + directiorio + "/" + fileName;
        }

        public object deserialize(string directorio, string fileName)
        {
            crearDirectorio(directorio);
            object datos = null;

            if (File.Exists(directorio + "/" + fileName))
            {
                IFormatter formatter = new BinaryFormatter();

                Stream stream = new FileStream(Directory.GetCurrentDirectory() + "/" + directorio + "/" + fileName, FileMode.Open, FileAccess.Read);
                datos = formatter.Deserialize(stream);
                stream.Close();
                stream.Dispose();
            }
            return datos;
        }


        public void crearDirectorio(string directorio)
        {
            if (!Directory.Exists(directorio))
            {
                Directory.CreateDirectory(directorio);
            }
        }

    }
}