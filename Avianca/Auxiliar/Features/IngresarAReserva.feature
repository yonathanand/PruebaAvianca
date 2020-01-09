Feature: IngresarAReserva


Scenario: Validar ingreso a la aplicacion Avianca
Given que abro la aplicacion en un celular Nexus
And le doy permisos de multimedia y archivos
When le doy permisos de ubicacion
Then debe presentar el texto Añadir un Vuelo
And finalizo el escenario

Scenario: Validar ingreso a opcion Viejemos
Given que abro la aplicacion en un celular Nexus
And le doy permisos de multimedia y archivos
And le doy permisos de ubicacion
When Selecciono opcion Comprar vuelos
Then debe presentar el titulo de la pagina de reservas ¡Viajemos!
And finalizo el escenario
