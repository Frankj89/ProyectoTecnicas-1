using SistemaVentas.ModelClass.Interfaces;



namespace SistemaVentas.ModelClass

/// <summary>
/// Represents the model of a product
/// </summary>
/// <seealso cref="ModelClase.Interface.Productos"/>

{
    public class Productos: IProducto
    {
        public Productos() 
        { 
        
        }
        
        // <summary>
        /// Initializes a new instance of the <seealso cref="Productos"/> class.
        /// </summary>
        ///<param id = "id"> The ID.</param>
        ///<param name = "name"> The name.</param>
        ///<param price = "price"> The price.</param>

        public Productos(int codigo , string nombre, int precio)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Precio = precio;
        }

        

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


        public override string ToString()
        {
            return this.Codigo + " " + this.Nombre + " " + this.Precio;
        }


    }
}
