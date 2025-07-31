# 🦁 Sistema de Gestión de Zoológico 2024

Un sistema de gestión para zoológicos desarrollado en C# que permite administrar diferentes tipos de animales y sus cuidadores.

## 📋 Descripción

Este proyecto implementa un sistema de gestión para zoológicos que utiliza conceptos de programación orientada a objetos como herencia, polimorfismo e interfaces. El sistema permite agregar, eliminar y administrar diferentes tipos de animales, así como gestionar los cuidadores responsables de su cuidado.

## 🌟 Características

- **Gestión de Animales**: Agregar, eliminar y listar diferentes tipos de animales
- **Tipos de Animales Soportados**:
  - 🐘 Mamíferos (con capacidad de amamantar)
  - 🦅 Aves (con capacidad de volar)
  - 🐟 Peces (con capacidad de nadar)
  - 🌱 Plantas Carnívoras
- **Gestión de Cuidadores**: Administrar el personal del zoológico
- **Sistema de Alimentación**: Los cuidadores pueden alimentar a los animales
- **Interfaz de Consola**: Menú interactivo para facilitar el uso

## 🏗️ Arquitectura del Proyecto

### Clases Principales

#### `IAnimal` (Interfaz)
- Define el contrato básico para todos los animales
- Propiedades: `nombre`
- Métodos: `comer()`, `presentarse()`

#### `Animal` (Clase Base)
- Implementa la interfaz `IAnimal`
- Propiedades: `nombre`, `especie`, `comida`
- Métodos virtuales que pueden ser sobrescritos por las clases derivadas

#### Clases Derivadas
- **`mamifero`**: Hereda de `Animal`, incluye método `Amamantar()`
- **`ave`**: Hereda de `Animal`, incluye método `Volar()`
- **`pez`**: Hereda de `Animal`, incluye método `Nadar()`
- **`PlantaCarnivora`**: Hereda de `Animal`

#### `Cuidador`
- Hereda de la clase `persona`
- Propiedades: `nombre`, `legajo`
- Método `alimentar()` para alimentar listas de animales

#### `Zoologico`
- Clase principal que gestiona el zoológico
- Mantiene listas de animales y cuidadores
- Métodos CRUD para animales y cuidadores

## 🚀 Requisitos del Sistema

- **.NET Core 3.1** o superior
- **Visual Studio** 2019 o superior (recomendado)
- **Sistema Operativo**: Windows, macOS o Linux

## 📦 Instalación

1. **Clonar el repositorio**:
   ```bash
   git clone https://github.com/Franc0-1/LabPorjectZoo.git
   cd LabPorjectZoo
   ```

2. **Abrir en Visual Studio**:
   - Abrir el archivo `zoologico2-2024.sln`

3. **Compilar el proyecto**:
   ```bash
   dotnet build
   ```

4. **Ejecutar la aplicación**:
   ```bash
   dotnet run --project zoologico2-2024
   ```

## 🎮 Uso

Al ejecutar la aplicación, se mostrará un menú interactivo con las siguientes opciones:

```
Por favor, selecciona una opción:
1. Agregar animal
2. Eliminar animal
3. Actualizar animal
4. Mostrar animales
5. Salir
6. Terminar programa
```

### Ejemplo de Uso

```csharp
// Crear una instancia del zoológico
Zoologico z = new Zoologico();

// Agregar diferentes tipos de animales
z.AgregarAnimal(new ave("Águila", "Ave", "carne"));
z.AgregarAnimal(new mamifero("Elefante", "Paquidermo", "pasto"));
z.AgregarAnimal(new pez("Tiburón", "Pez", "Carne"));

// Mostrar la población del zoológico
z.poblacion();
```

## 🔧 Funcionalidades Implementadas

- ✅ **Agregar animales**: Permite añadir nuevos animales al zoológico
- ✅ **Eliminar animales**: Permite remover animales específicos
- ✅ **Mostrar población**: Lista todos los animales del zoológico
- ✅ **Gestión de cuidadores**: Administrar el personal del zoológico
- ✅ **Sistema de alimentación**: Los cuidadores pueden alimentar a los animales
- ⚠️ **Actualizar animales**: Funcionalidad en desarrollo
- ⚠️ **Mostrar animales detallado**: Funcionalidad en desarrollo

## 🏛️ Patrones de Diseño Utilizados

1. **Herencia**: Las clases `mamifero`, `ave`, `pez` y `PlantaCarnivora` heredan de `Animal`
2. **Polimorfismo**: Método `presentarse()` sobrescrito en cada clase derivada
3. **Interfaces**: `IAnimal` define el contrato para todos los animales
4. **Composición**: La clase `Zoologico` contiene listas de animales y cuidadores

## 📁 Estructura del Proyecto

```
zoologico2-2024/
├── zoologico2-2024.sln          # Archivo de solución de Visual Studio
├── zoologico2-2024/
│   ├── Animal.cs                # Definición de animales e interfaz
│   ├── Cuidador.cs             # Clases de cuidador y persona
│   ├── Zoologico.cs            # Clase principal del zoológico
│   ├── Program.cs              # Punto de entrada de la aplicación
│   └── zoologico2-2024.csproj  # Archivo de proyecto
├── .gitignore                  # Archivos ignorados por Git
├── .gitattributes             # Configuración de Git
└── README.md                  # Este archivo
```

## 🤝 Contribuir

1. Fork el proyecto
2. Crea una rama para tu feature (`git checkout -b feature/AmazingFeature`)
3. Commit tus cambios (`git commit -m 'Add some AmazingFeature'`)
4. Push a la rama (`git push origin feature/AmazingFeature`)
5. Abre un Pull Request

## 📝 Tareas Pendientes

- [ ] Implementar funcionalidad completa de "Actualizar animal"
- [ ] Mejorar la funcionalidad "Mostrar animales"
- [ ] Agregar validaciones de entrada
- [ ] Implementar persistencia de datos
- [ ] Agregar más tipos de animales
- [ ] Mejorar la interfaz de usuario
- [ ] Agregar pruebas unitarias

## 🐛 Problemas Conocidos

- El código en `Program.cs` línea 47 tiene un error de sintaxis (`{z` en lugar de `{`)
- Algunas funcionalidades del menú no están completamente implementadas
- Falta manejo de excepciones para entradas inválidas

## 📄 Licencia

Este proyecto es de código abierto y está disponible bajo la licencia MIT.

## 👥 Autores

- **Desarrollador Principal** - *Trabajo inicial* - [Franc0-1](https://github.com/Franc0-1)

## 🙏 Agradecimientos

- Proyecto desarrollado como parte del aprendizaje de programación orientada a objetos en C#
- Inspirado en sistemas de gestión de zoológicos reales

---

⭐ ¡Si te gustó este proyecto, no olvides darle una estrella en GitHub!
