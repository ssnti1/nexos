# Conversión de Moneda

## Parte 1: Respuestas Teóricas

### 1. **Adaptabilidad**
Si toca cambiar de tecnología, busco en internet algo rápido, como un tutorial o la documentación, también pregunto a alguien del equipo que la maneje bien y trato de hacer algo simple para ir agarrándole la idea antes de meterle mano al proyecto real


### 2. **Resolución de Problemas**
Si en mi computador funciona y en el servidor no, reviso que estén usando las mismas versiones y configuraciones, si no es voy directo a los logs del servidor porque ahí siempre dice el error


### 3. **Conocimientos en Desarrollo (.NET)**
Uso .NET si el proyecto es de Microsoft o necesito algo rápido para web o escritorio. Pero si el proyecto tiene que correr en varios sistemas operativos o es algo más grande uso Java


### 4. **Escenario: Arquitectura de Capas para API**
**Justificación:** Lo divido para que cada parte tenga su función y no se haga un desorden. Si mañana hay que cambiar algo no hay que tocar todo el proyecto, solo la parte que le corresponde

#### proyecto.DAL
- **Model:** Es donde creo las clases que describen los datos, como una clase "Persona" con nombre, edad, etc
- **Interfaces:** Son como las reglas para conectar con la base de datos

#### proyecto.Business
Aquí pongo toda la lógica, como validar datos o manejar cómo se guardan

#### proyecto.API
Esta es la parte que recibe las solicitudes del cliente, llama a la lógica **Business** y devuelve las respuestas


## Parte 2: Introducción

## Cómo usar el programa
1. Clona o descarga el repositorio
2. Ejecuta el programa
3. Escribe "dotnet run" e ingresa monto en **pesos colombianos**
4. Se te mostrará la conversión a Dólares y Euros

**PSDT:** La aplicación valida que el monto sea un número válido y mayor a 0, de lo contrario te pedirá que intentes nuevamente
