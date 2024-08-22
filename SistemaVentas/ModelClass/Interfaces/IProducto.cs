using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.ModelClass.Interfaces
{
    /// <summary>
    /// Represents the interface for a product
    /// </summary>
    public interface IProducto
    {

        /// <summary>
        /// Gets or sets the ID
        /// </summary>
        /// <value>
        /// The ID
        ///</value>>
        public int Codigo { get; set; }

        /// <summary>
        /// Gets or sets the name
        /// </summary>
        /// <value>
        /// The name
        ///</value>>
        public string Nombre { get; set; }

        /// <summary>
        /// Gets or sets the Price
        /// </summary>
        /// <value>
        /// The price
        ///</value>>
        public int Precio { get; set; }
    }
}
