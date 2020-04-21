# netCore_Training
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
