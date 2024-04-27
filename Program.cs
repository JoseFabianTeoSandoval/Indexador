using Indexador.Clases;

ColeccionAnimales coleccion = new ColeccionAnimales(3);

coleccion[0] = new Animal("Perro");
coleccion[1] = new Animal("Gato");
coleccion[2] = new Animal("Pájaro");

Console.WriteLine("Animales en la colección:");
for (int i = 0; i < 3; i++)
{
    Console.WriteLine(coleccion[i].Nombre);
}