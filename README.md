# Todo-en-uno
Aplicacion para Todo En Uno

#Requerimientos
*Inicio de sesion con cambio de contraseña.
/--------------------------------------------/
*Carga de venta
  Datos: nombre producto, valor, codigo de barra, cant producto
  ¿Que hace?
  Suma total de todos los productos cargado.
  Si lee dos veces el mismo codigo la cantidad se tiene que poner en dos.
  Descontar del stock
  Se debe separar cigarrillos del resto de productos.
  Se debe guardat monto total (sacando cigarrillos), monto total cigarillos, cant de cigarrillos(paquetes)
  Opcion de editar /borrar
  Se debe mostrar en pantalla las siguientes tres cosas
    1)Sumatoria total de producto (al guardarse se guardan separados)
    2)Debito = A los pucho se le suma un 10%
    3)Credito = A todo se le suma un 15%

/---------------------------------------------------------------------------------------------------------------/
*Venta propia 
  Datos: nombre producto, valor, codigo de barra,cant producto
  ¿que hace?
  uma total de todos los productos cargado.
  Si lee dos veces el mismo codigo la cantidad se tiene que poner en dos.
  Descontar del stock
  Se debe separar cigarrillos del resto de productos.
  Se debe guardat monto total (sacando cigarrillos), monto total cigarillos, cant de cigarrillos(paquetes)
  Opcion de editar /borrar
/--------------------------------------/
*Cirre del dia/caja
  Guardar los siguientes datos:
  total de venta en el dia(sin cigarrillos)
  ganacia mercaderia = 25% del total de ventas en el dia.
  total venta cigarrillos (en $)
  ganancia cigarrillo = cant cigarrillos * 20
  plata reponer = total venta cigarrillo - ganancia cigarrillo
  pago al negocio mercaderia= sumatoria venta propia - 25% 
  pago negocia cigarrillo = sumatoria venta propia cigarrillo 
  /--------------------------------------------------------------------------------------/
  *Lista de producto
    Filtro por cod de barra y nombre
    Opcion de modificar, eliminar, agregar (valor = caja / cant)
    Datos del producto:nombre, valor, stock, cod de barra, stock min
  /----------------------------------------------------------------------/
  *Cierre del mes
    Idem caja del dia pero del mes
   /---------------------------------/
   *Poner en algun lado boton que cheque el stock--> Genera una lista de productos donde su stock <= stock minimo
   /-----------------------------------------------------------------------------------------------------------------/
   *Carga fiado
    Datos: Nombre unico, texto
    Opcion de borrar y editar
