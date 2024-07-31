using SistemaVentas.ControllerClass.Interface;
using SistemaVentas.ModelClass;
using SistemaVentas.ModelClass.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.ControllerClass
{

    /// <summary>
    /// Implements the file handle
    /// </summary>
    /// <seealso cref="ControllerClase.Interface.IFileHandler" />
    public class FileController : IFileHandler
    {

        /// <summary>
        /// Loads the file 
        /// </summary>
        /// <param name="filepath">The filepath.</param>
        /// <returns>content of a file</returns>
        
        public string LoadFile(string filePath)
        {
            var content = File.ReadAllText(filePath);
            return content;
        }

        /// <summary>
        /// Loads the products
        /// </summary>
        /// <param name="path">The path</param>
        /// <returns>A list of people from the file</returns>
        
        public List<Productos> LoadProducto (string path)
        {
            var result = new List<Productos>();
            var content = this.LoadFile(path);
            var lines = content.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines) 
            {
                var parts = line.Split(',');
                var product  = new Product();
                product.Codigo = parts[0];
                product.Nombre = parts[1];
                product.Precio = parts[2];
                result.Add(product);
            }
            return result;
        }

        /// <summary>
        /// Saves the file
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool SaveFile(string path)
        {
            throw new NotImplementedException();
        }
    }
}
