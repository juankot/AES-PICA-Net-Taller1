# AES-PICA-Net-Taller1

Taller #1 del Módulo de .Net de la clase de Proyecto de Implementación Centrado en Arquitectura de la Especialización de Arquitectura Empresarial de Software de la Pontificia Universidad Javeriana.

El taller fue implementado en .Net Core, y consta de 2 proyectos. El primero de ellos corresponde a una aplicación de tipo WebApi, y el segundo de tipo MVC

## web_api
Este proyecto contiene una API REST sencilla con un servicio y una capacidad que recibe un modelo (JSON/XML) de tipo Contacto, cuya estructura se muestra a continuación (soporta Content Negotiation):

**Ejemplo JSON**

```
{
    "nombres": "Homero j.",
    "apellidos": "Simpson",
    "direccion": "Avenida Siempreviva 742",
    "correo": "homero.j@simpsons.com",
    "telefono": "1234567",
    "comentario": "Este es un ejemplo para el consumo del servicio"
}
```

**Ejemplo XML**

```
<ContactoViewModel xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
    <Nombres>Homero j.</Nombres>
    <Apellidos>Simpson</Apellidos>
    <Direccion>Avenida Siempreviva 742</Direccion>
    <Correo>homero.j@simpsons.com</Correo>
    <Telefono>1234567</Telefono>
    <Comentario>Este es un ejemplo para el consumo del servicio</Comentario>
</ContactoViewModel>
```

Esta es la información necesaria para acceder a la API:

```
Method: POST
Protocol: http
Host: localhost
Port: 5000
Source: api/contacto
Content-Type: application/json, application/xml
Accept: application/json, application/xml
```

Ejemplo:

```
http://localhost:5000/api/contacto
```

## mvc-app
Este proyecto usa el patrón MVC, por lo que existe una separación de lógica en Modelos, Vistas y Controladores.

El proyecto consta de una página sencilla con un menú de navegación en la parte superior, un espacio para el contenido, y un footer.

En la opción "Contacto" del menú, se muestra un formulario que validará el contenido de los campos a través del Modelo, y una vez se haga clic en "Enviar", enviará una petición al servicio "web_api", el cuál responderá positiva o negativamente de acuerdo al contenido enviado.

En la opción "Login" del menú, se muestran los campos para el inicio de sesión. Por motivos del ejercicio académico no se implementó ninguna estratégia de persistencia, por lo que el usuario que se valida está "quemado" en el código y es: **_juan_**. Una vez ingresa, se mostrará una pantalla de bienvenida para el usuario.

La aplicación _falla con gracia_ por lo que de presentarse algún error en el consumo del servicio o en el inicio de sesión, aparecerá una pantalla indicando que hubo un problema, pero ocultando información técnica.

Esta aplicación por defecto se ejecuta en:

```
http://localhost:5001/
```
