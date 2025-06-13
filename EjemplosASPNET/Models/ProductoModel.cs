using carrito = EjemplosASPNET.Models.ParaCarrito;

namespace EjemplosASPNET.Models
{
    public class ProductoModel
    {
        private List<carrito::Producto> _products;
        public ProductoModel()
        {
            _products = new List<carrito::Producto>() { 
                new carrito::Producto{ 
                    Id = "prod01",
                    Nombre = "Arroz",
                    Precio = 12.5,
                    Foto = "arroz-1.png"
                },
                new carrito::Producto{
                    Id = "prod02",
                    Nombre = "Leche",
                    Precio = 22.5,
                    Foto = "leche.webp"
                },
                new carrito::Producto{
                    Id = "prod03",
                    Nombre = "Pancito",
                    Precio = 15,
                    Foto = "pan.jpeg"
                },
                new carrito::Producto{
                    Id = "prod04",
                    Nombre = "Queso cheddar",
                    Precio = 16,
                    Foto = "queso.jpg"
                }
            };
        }

        public List<carrito::Producto> getTodo() { 
            return _products;
        }
        public carrito::Producto getById(string id) {
            return _products.Single(p => p.Id.Equals(id)); // SELECT * FROM producto WHERE Id = id;
        }

        
    }
}
