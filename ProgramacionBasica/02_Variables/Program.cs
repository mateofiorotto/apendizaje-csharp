//
// REPASO VARIABLES (para ver otras chequear notion o docs)
//

int number = 80;
Console.WriteLine(number);

string text = "Hola soy Mateo";
Console.WriteLine(text);

char initial = 'h'; // se define con ' '
Console.WriteLine(initial);

bool condition = true;
Console.WriteLine(condition);

decimal price = 10.99m;
Console.WriteLine(price);

//
// CONDICIONALES + Operadores de comparacion
//
int age = 18;
//Si es valido devolvera "puedes trabajar aqui"
//si tiene menos de 18, no puede
if (age >= 18)
{
    Console.WriteLine("Puedes trabajar aqui");
} else if (age == 17)
{
    Console.WriteLine("Puedes realizar una pasantia sin contrato");
}
else 
{
    Console.WriteLine("NO Puedes trabajar aqui");
}

// OPERADORES LOGICOS BOOLEANOS
bool ganasDeCafe = false;
float precioCafeAmericano = 1.49f;
float precioCapuccino = 2.19f;
float dinero = 1.19f;

if (ganasDeCafe == true && dinero >= precioCapuccino)
{
    Console.WriteLine("Te alcanza para un Capuccino y un Café Americano");
} else if (ganasDeCafe == true && dinero >= precioCafeAmericano && dinero < precioCapuccino)
{
    Console.WriteLine("Te alcanza para un café Americano");
} else if(ganasDeCafe == true && dinero < precioCafeAmericano)
{
    Console.WriteLine("No te alcanza para nada"); 
} else
{
    Console.WriteLine("No tienes ganas de cafe");
}

bool isMoving = true;

if (!isMoving)
{
    Console.WriteLine("No se mueve");
}
else
{
    Console.WriteLine("Se mueve");
}

// SWITCH
string bestProgrammingLanguage = "C#";

switch (bestProgrammingLanguage)
{
    case "C#":
        Console.WriteLine("C# es el mejor lenguaje de programación");
        break;
    case "Java":
        Console.WriteLine("Java es el mejor lenguaje de programación");
        break;
    case "Python":
        Console.WriteLine("Python es el mejor lenguaje de programación");
        break;
    default:
        Console.WriteLine("No existe tal lenguaje de programación");
        break;
}

// WHILE
int counter = 0;
int times = 5;

while (counter < times)
{
    Console.WriteLine("Contador: " + counter);
    counter++; // tambien se puede poner counter = counter +1
}

// DO WHILE
int counter2 = 0;
int times2 = 5;

do
{
    Console.WriteLine("Contador: " + counter2);
    counter2++;
} while (counter2 < times2);


//FOR
for (int i = 1; i < 3; i++)
{
    Console.WriteLine("Ejecutado " + i + " veces");
}

//FUNCIONES
//Void indica que no regresa ningun valor con return
void Hola()
{
    Console.WriteLine("Hola");
}

//ejecutamos la funcion 3 veces
Hola();
Hola();
Hola();

//CON PARAMETROS:
void holaConParametros(string name, string lastName)
{
    Console.WriteLine("Hola, " + name + " " + lastName );
}

//Le mandamos los valores
holaConParametros("Mateo", "Fiorotto");

// CON RETURN

//int indica que nuestra funcion regresa un valor int
int Add(int num1, int num2)
{
    //con return, devolvemos el valor
    return num1 + num2;
}

//asignamos a res la funcion pasandole 1 y 2 por lo que sumara los numeros y devolvera 3
int res = Add(1, 2);
Console.WriteLine(res);