# Patrón Prototype en C# - Copia Superficial

Este proyecto es una demostración sencilla de cómo implementar el **Patrón Prototype** en C# utilizando una **copia superficial (shallow copy)**.

## 🧠 ¿Qué es el Patrón Prototype?

El patrón de diseño **Prototype** se utiliza para crear nuevos objetos copiando una instancia existente (prototipo), en lugar de crearlos desde cero. Esto es útil cuando la creación de un objeto es costosa o compleja. Existen dos tipos de copia:
- **Copia superficial (Shallow Copy)**: Clona el objeto, pero las referencias internas apuntan a los mismos objetos.
- **Copia profunda (Deep Copy)**: Clona el objeto y también todos los objetos referenciados internamente.

