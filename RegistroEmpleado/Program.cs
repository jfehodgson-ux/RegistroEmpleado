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
    Console.ResetColor();

    
}

int menu()
{ 
    Console.WriteLine("1. Agregar \n2. Mostrar \n3. Eliminar \n4. Salir \nDigite su opcion");
    int op = int.Parse(Console.ReadLine());
    return op;
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