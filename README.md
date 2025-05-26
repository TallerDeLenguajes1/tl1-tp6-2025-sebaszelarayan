[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/24pP-Pw_)
# Tp6
 Zelarayan Sebastian 

## Respuetas

# ¿String es una tipo por valor o un tipo por referencia?
string es un tipo por referencia en C#.
Sin embargo, es inmutable (no se puede modificar su contenido una vez creado).
Aunque sea por referencia, su comportamiento puede parecer de valor porque cada vez que modificás un string, se crea uno nuevo en memoria.
# ¿Qué secuencias de escape tiene el tipo string?
| Secuencia | Significado           |
| --------- | --------------------- |
| `\\`      | Barra invertida (`\`) |
| `\'`      | Comilla simple        |
| `\"`      | Comilla doble         |
| `\n`      | Nueva línea           |
| `\r`      | Retorno de carro      |
| `\t`      | Tabulación            |
| `\b`      | Retroceso             |
| `\f`      | Avance de página      |
| `\0`      | Null (cero)           |

# ¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?
@ (verbatim string literal)
Trata la cadena literalmente.
No interpreta secuencias de escape (\n, \t, etc.).
Te permite escribir en varias líneas.
Las barras invertidas \ no se escapan (muy útil para rutas de archivos).

$ (string interpolated)
Permite interpolación: insertar variables o expresiones dentro de la cadena usando {}.