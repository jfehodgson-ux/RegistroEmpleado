

Empleado[] empleados = new Empleado[10];

void agregarEmpleado(int pos)
{
    Console.WriteLine("Nombres: ");
    empleados[pos].nombres = Console.ReadLine();
    Console.Write("Apellidos: ");
    empleados[pos].apellidos = Console.ReadLine();
    Console.Write("Cargo: ");
    empleados[pos].cargo = Console.ReadLine();
    Console.Write("Salario: ");
    empleados[pos].salario = Double.Parse(Console.ReadLine());
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Empleado agregado con éxito");
    Console.ReadKey();
    Console.ResetColor();
   
    
}

void mostrarDatos(int pos)
{
    Console.WriteLine("Mostrar registros");
    for (int i = 0; i < pos; i++)
    {
        Console.WriteLine($"Nombre: {empleados[i].nombres}" +
            $"\nApellidos: {empleados[i].apellidos} \nCargo:" +
            $"{empleados[i].cargo} \nSalario: {empleados[i].salario}");
        Console.ReadKey();
    }
}

int menu()
{
    Console.ForegroundColor=ConsoleColor.Green;
    Console.Clear();
    Console.WriteLine("1. Agregar \n2. Mostrar \n3. Guardar \n4. Salir \nDigite su opcion");
    Console.ForegroundColor=ConsoleColor.Blue;
    int op = int.Parse(Console.ReadLine());
    Console.ResetColor();
    return op;
}

void guardarEmpleados(int pos)
{
    StreamWriter archivo = new StreamWriter("C:\\programacion\\aempleados.csv");
    for (int i = 0; i < pos; i++)
    {
        archivo.WriteLine($"{empleados[i].nombres};" +
            $"{empleados[i].apellidos}; {empleados[i].cargo};" +
            $"{empleados[i].salario}");
    }
    archivo.Close();
    Console.WriteLine("Registros guardados");
    Console.ReadKey();
}
int main()
{ 
    int op = 0, i = 0;
    do
    {
        Console.WriteLine($"Registro #{i+1}");op++;
        op = menu();
        switch (op)
        {
            case 1:
                agregarEmpleado(i++);
                break;
            case 2:
                mostrarDatos(i);
                break;
            case 3:
                guardarEmpleados(i);
                break;
            default:
                Console.WriteLine("Error, Opcion Invalida..");
                break;
        }
       
    } while (op != 4);
    return 0;
}

main();
struct Empleado
{
   public string nombres;
   public string apellidos;
    public string cargo;
    public double salario;
}