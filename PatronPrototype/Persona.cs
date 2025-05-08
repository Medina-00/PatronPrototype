
namespace PatronPrototype // Define el espacio de nombres del código
{
    // Clase Persona implementa el patrón Prototype con una copia superficial (Shallow Copy)
    public class Persona : ICloneable
    {
        public string nombleCompleto { get; set; } // Propiedad para almacenar el nombre
        public int edad { get; set; } // Propiedad para almacenar la edad

        // Método Clone() que crea una COPIA SUPERFICIAL del objeto Persona
        public object Clone()
        {
            return this.MemberwiseClone(); // Clona el objeto sin duplicar referencias internas
        }
    }
}