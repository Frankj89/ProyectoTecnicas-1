using SistemaVentas.ModelClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.ControllerClass.Interface
{

    /// <summary>
    /// Interface for file handle
    /// </summary>
    public interface IFileHandler
    {

        /// <summary>
        /// Loads the file
        /// </summary>
        /// <param name="filepath">The filepath.</param>
        string LoadFile(string filePath);

        /// <summary>
        /// Loads the products
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        List<Productos> LoadProducto(string path);

        /// <summary>
        /// Save the file
        /// </summary>
        /// <param name="path">The path.</param>
        bool SaveFile(string path);
    }
}
