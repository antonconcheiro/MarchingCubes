# MarchingCubes

## Contenido:
Python:
- images/ -> imágenes de TAC
- imageToMatrix.py -> convierte cada imagen en una matriz en la carpeta output
- output/ -> matriz en escala de grises de cada imagen

Unity:
-  matrixImages/ -> igual que output/ en un entorno de Unity
-  ReadMatrix.cs -> Lee la carpeta matrixImages y lo transforma todo en una matriz 3d
-  MarchingCubes.cs -> Usa ReadMatrix.cs para construir el objeto a partir de la matriz 

## Uso:
Si se desea usar nuevas imágenes, colocarlas en la carpeta images, ejecutar imageToMatrix y copiar la salida de output a matrixImages.

El contenido de Unity deberá estar en la carpeta Assets.
Crear en la escena un GameObject vacío. Añadirle al GameObject los scripts ReadMatrix y MarchingCubes. Añadir al GameObjects los componentes de Unity de MeshFilter y MeshRenderer. Añadir un material cualquiera a MeshRenderer para poder visualizar la figura.

Ejecutar.

El código original se puede encontrar en el siguiente enlace:
[Código original](https://github.com/antonconcheiro/MarchingCubes.git)

El tutorial y explicación del código se puede visualizar en el siguiente enlace:
[Tutorial](https://www.youtube.com/watch?v=BZg8TCCj1gY&ab_channel=Flaroon)
