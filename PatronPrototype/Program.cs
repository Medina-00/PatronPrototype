// Importa el espacio de nombres PatronPrototype
using PatronPrototype;
using System.Text.Json; // Espacio de nombres para trabajar con serialización JSON
using System.Text.Json.Nodes; // Trabaja con nodos JSON

// Creación de un objeto Persona original
var persona1 = new Persona { nombleCompleto = "Luis Angel Morel", edad = 20 };

// Creación de una COPIA del objeto persona1 utilizando el método Clone()
var persona2 = persona1.Clone() as Persona;

// Se cambia el nombre y edad en la copia para verificar que afecta solo a la referencia compartida
persona2.nombleCompleto = "Felix Morel";
persona2.edad = 45;

// Se serializan ambos objetos a formato JSON para mostrar los datos en consola
var datos = JsonSerializer.Serialize(persona1);
var datos1 = JsonSerializer.Serialize(persona2);

// Muestra los objetos serializados en consola
Console.WriteLine(datos);
Console.WriteLine(datos1);