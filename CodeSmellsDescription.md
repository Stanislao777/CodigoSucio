1. **Codigo repetido**
2. **método largo**

(13 - 49) la asignación de los atributos de la clase se realizan de dos diferentes formas en dos constructores, agrupando muchas responsabilidades en cada uno. 

(14 - 25) Se refactoriza dividiendo responsabilidades en nuevas funciones, ya que el constructor solo debe tener la responsabilidad de inicializar los atributos y si se va a requerir esos datos como una entrada el constructor debería quedar por defecto y crear otros métodos, estos métodos serían: pedir de consola -> validar cadena vacia -> asignación de variable.

3. **Clase larga**

(5 - 71) La clase Agenda es mas grande de lo que debería, contiene métodos que no croreesponden a la abstracción del objeto, como el metodo Main y procesos dentro de otros métodos igual largos.

(5-30, 31-54) Se refactoriza extrayendo el método Main y otro método creado de una refactorización llamado "validarTamString" en una clase aparte encargada de la ejecución principal del programa llamada "Program".

4. **Complejidad artificiosa**

(52 - 57) StringBuilder es usado para optimizar el uso de memoria con cadenas que se estan modificando y ocupando nuevos espacios de memoria con cada modificación, en este caso se esta usando para crear una cadena nueva y devolverla inmediatamente.

(28) Se refactoriza simplificando el retorno a un string con formato simple

5. **Magic numbers**

(27, 33, 41, 48) El tamaño de los strings son comparados con un literal tipo numero que no ayuda de ninguna forma la facil lectura del código.

(7-8, 16-19) Se factoriza creando constantes con nombres explicitos que contengan estos valores y faciliten la lectura del código.
