namespace EjemplosASPNET.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Foto { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }
        // Constructor por defecto
        public Producto() { }
        // Constructor con parámetros
        public Producto(int id, string nombre, string foto, double precio, int cantidad)
        {
            Id = id;
            Nombre = nombre;
            Foto = foto;
            Precio = precio;
            Cantidad = cantidad;
        }
    }
}
