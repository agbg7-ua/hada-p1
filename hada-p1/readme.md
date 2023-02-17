Práctica 1 - Uso de git

P1. ¿Qué crees que significa la opción -n en el comando revert?
-n se usa para que no se generen comentarios automáticos al hacer un revert

P2. ¿Qué cambios se han producido al ejecutar el comando reset?
Al ejecutar reset hacemos que la rama vuelva al commit especificado.

P3. ¿Qué diferencias observas entre revert y reset?
La diferencia es que mientras que reset vuelve al commit especificado volviendo al estado en el que estaba en ese commit el revert cra un nuevo commit deshaciendo lo anteriormente hecho que queremos deshacer.

P4. ¿Qué diferencias observas entre merge y rebase?
La principal diferencia es que con merge se creaun nuevo commit en master con todos los commits de la otra rama que queremos unir sin modificar los logs de esta rama mientras que rebase añade los commits de la rama que queremos unir a master modificando los logs de la rama a unir.