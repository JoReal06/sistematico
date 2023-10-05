using Dispostivos_electronicos;

Celular samsung = new Celular("foto de la palya", 5);
Console.WriteLine("El  celular sansumg realizo\n");

samsung.MostrarAppCamara();
samsung.TomarFoto();
Console.WriteLine($"El nombre de la foto es: {samsung.NombreFoto} y la cantidad de fotos " +
    $"que se tomaron son {samsung.CantidadDEFotos}\n");

Tablets blue = new Tablets("Foto en la boda", 10);
Console.WriteLine("La tablet realizo\n");
blue.MostrarAppCamara();
blue.TomarFoto();
blue.localizar();
blue.ObtenerCoordenadas();

Console.WriteLine($"El nombre de la fotos es: {blue.NombreFoto} y la cantidad de " +
    $"fotos que se tomaron son : {blue.CantidadDEFotos}");


