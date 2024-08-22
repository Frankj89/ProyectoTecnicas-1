

using SistemaVentas.ModelClass.Interfaces;

namespace SistemaVentas.ControllerClass
{
    /// <summary>
    /// Handles the products/Productos
    /// </summary>
    public class ProductController
    {
        private string FileName { get; set; } = "Productos.csv";
        private int ProductCount { get; set; } = 100;

        private FileController FileController { get; set; } = new FileController();
        
        /// <summary>
        /// Gets the products
        /// </summary>
        /// <returns>The list of the system products.</returns>
        public List<IProducto> GetProductos()  
        
        {
            var filepath = this.GetFile();
            var result = this.FileController.LoadProducto(filepath);
            return result;
        }
    
         
        private string GetFile()
        {
            var filepath = Path.Combine(Directory.GetCurrentDirectory(), this.FileName);
            if (!File.Exists(filepath)) 
            {
                this.GenerateProducts(filepath, this.ProductCount);
            }
            
            return filepath;
        }
    
        private void GenerateProducts(string filepath, int data) 
        {
            var codigos = new string[] {"10", "30", "35", "90","47", "89" };
            var nombres = new string[] { "Pintura", "martillo", "cinta", "taladro", "alicate", "tornillador" };
            var precios = new string[] { "1000", "1500", "2000", "20000", "3000", "2500" };

            var random = new Random();

            using (var sw = new StreamWriter(filepath, false, encoding.UTF8)) 
            
            {
                sw.WriteLine("Codigo,Nombre,Precio");
                var rowCount = 0;

                for (int i = 0, j = 0, k = 0; rowCount < data; k++, i++, j++) 
                
                {
                    if (codigos.Length - 1 == i || nombres.Length - 1 == j || precios.Length - 1 == k) 
                    {
                        i = 0;
                        j = 0;
                        k = 0;
                    }
                
                    var codigoRand = random.Next(0, codigos.Length);
                    var nombreRand = random.Next(0, nombres.Length);
                    var precioRand = random.Next(0, precios.Length);

                    sw.WriteLine($"{codigos[codigoRand]}, {nombres[nombreRand]}, {precios[precioRand]}");
                
                }
                
            }
        }


    }
}
