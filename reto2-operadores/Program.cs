// Variables iniciales
int width = 7;
int height = 5;

// Calcular valores iniciales
int area = width * height;
int perimeter = (2 * width) + (2 * height);

Console.WriteLine($"----- VALORES INICIALES -----");
Console.WriteLine($"width: {width}");
Console.WriteLine($"height: {height}");
Console.WriteLine($"area: {area}");
Console.WriteLine($"perimeter: {perimeter}");
/////////////////////////////////////////////////

// Incrementar valores iniciales
width += 3;
height -= 2;

// Re-calcular valores
area = width * height;
perimeter = (2 * width) + (2 * height);

Console.WriteLine($"----- VALORES FINALES -----");
Console.WriteLine($"width: {width}");
Console.WriteLine($"height: {height}");
Console.WriteLine($"area: {area}");
Console.WriteLine($"perimeter: {perimeter}");
/////////////////////////////////////////////////