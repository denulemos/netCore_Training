# netCore_Training - Apuntes


--INYECCION DEPENDENCIAS--


Tipos de inyeccion =>

AddTransient => services.AddTransient<IMyService, MyService>(); 


Una nueva instancia por peticion, multiples instancias en memoria


AddScoped => services.AddScoped<IMyService , MyService>();


Una instancia por request, similar al singleton pero en cuanto entra un pedido nuevo genera
una nueva instancia
Cada GET genera una nueva instancia de lo mismo


AddSingleton => services.AddSingleton<IMyService , MyService>();


Unica instancia por peticion en contenedor, una sola en memoria


--RESTFUL SERVICES--


*Toda aplicacion Core deberia ser REST. Hacer un Backend independendiente de la presentacion.


*Se consume mediante Postman


*Los objetos REST son manipulados mediante un URI (endpoint) hace de identificador unico
en cada recurso del sistema REST, no puede ser compartida por + de un recurso


{protocolo}://{hostname}:{puerto}/{ruta recurso}?{parametros filtro opcionales}


*El protocolo http nos permite hacer una llamada a un recurso remoto, una URL. 


*La URI a diferencia de la URL es mas amplia, puede llamar servicios, imagenes, etc.. 


*En vez de llamar a una pagina se llama a un metodo de la API que devuelve un JSON con el contenido


*HTTP Resquest => Verb (GET, POST..) , Uri, version, request header y request message/body


*HTTP Response => Response code, Http version, Response header y response message/body


*API => Una forma de exponer un conjunto de codigo para que esta sea consumida por otro codigo.


POST: Crear Recurso


PUT: Modificar recurso


GET: Consultar informacion


DELETE: eliminar recurso


PATCH: modificar solo un atributo del recurso


200 OK => Respuesta estandar para peticiones correctas


201 => Created, cuando hago un POST salio todo OK


202 => Accepted , proceso aceptado pero todavia no hecho


400 => Bad Request


403 => Sin permisos


404 => No encontrado


500 => Problema ejecucion (Internal server error)


--PROTOCOLO CLIENTE/SERVIDOR SIN ESTADO--


*Las peticiones HTTP contienen toda la informacion necesaria para ejecutarla, lo que permite
que ni cliente ni servidor necesiten recordar ningun estado previo a satisfacer


*Algunas aplicaciones HTTP incorporan memoria cache, con el objetivo de que el cliente
pueda ejecutar en un futuro la misma respuesta para peticiones iguales


--USO DE RECURSOS HYPERMEDIA--


*Principio HATEOAS* cuando yo devuelva un recurso como una lista de productos, ademas de devolver
los datos del producto, se devuelva la URL donde pueda clickear y se pueda navegar al detalle del producto,
permite la navegacion entre recursos. 


*Esto no se usa mucho. 


Postman => aplicacion para probar restApis

Swagger => Un administrador de tu API 
Instalar Swagger en Nuget => Install-Package Swashbuckle.AspNetCore -Version 5.0.0
Configurar en el proyecto desde el Startup.cs
acceder a Swagger => /swagger/index.html


--AAAS/PAAS/SAAS-- (As a service..)


*En vez de tener el producto en tu PC, se tiene el producto como servicio. 
*IAAS => infrastructure as a service (Solo manejamos la aplicacion, data, runtime, middleware y O/S, ofrece flexibilidad y escalabilidad, se usa cuando no estas seguro de la demanda de la aplicacion)


*PaaS => Platform as a service (Solo manejamos la aplicacion y la data. Desarollo y deploy barato y rapido, la infraestructura no la manejamos nosotros no nos interesa sobre que esta corriendo)


*SaaS => Software as a service (Nada es manejado por nosotros, ya tenemos todo hecho, solo tenemos que usarlo de Interfaz. Administrado por su proveedor, un ejemplo es Wordpress)


Lo que no es manejado por nosotros es manejado por la Nube, y su proveedor. En un servidor On-premise manejamos todo nosotros ya que tenemos el equipo nosotros. 


--DOCKERS--


Son contenedores donde se nos facilita la implementacion de aplicaciones de software. Permite a desarolladores, administradores, etc.. implementar sus aplicaciones en un entorno limitado (contenedores).
Nos olvidamos de copiar archivos y solo nos concentramos en los componentes que queremos. Esto da a que haya mejor portabilidad entre sistemas operativos y ambientes.


--MIDDLEWARES--


Es un intermediario, sirve en una aplicacion con muchos servicios o componentes, es codigo en comun entre todos. 
Se ensambla en un pipeline para manejar solicitudes y respuestas a la mismas, como concatenar la fecha de hoy a cada respuesta de cada request. Un Middleware puede ser la entrada / salida de otro middleware. 


--LOGGER--


Puedo logear distintas cosas, problemas, informacion, etc.. En appsettings en "LogLevel" se va a definir cual es el nivel de loggeo, el cual es de Information. 
