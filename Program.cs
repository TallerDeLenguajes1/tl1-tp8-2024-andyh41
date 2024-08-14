// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var TareasPendientes = new List<Tarea>();
var TareasRealizadas = new List<Tarea>();
int opcion=0;
do
{
    Console.WriteLine("\n MENU INTERACTIVO\n");
    Console.WriteLine("1) Agregar Tareas Pendientes");
    Console.WriteLine("2) Cambiar Tarea Pendiente a Tarea Realizada");
    Console.WriteLine("3) Mostrar Lista Pendiente");
    Console.WriteLine("4) Mostrar Lista Realizada");
    Console.WriteLine("5) Buscar Tarea por ID");
    Console.WriteLine("6) Buscar Tarea por Palabra Clave");
    Console.WriteLine("7) Salir");
    Console.Write("\nIngrese la opcion deseada: ");
    int.TryParse(Console.ReadLine(), out opcion);
    

    switch (opcion)
    {
        case 1:
            int condicion=0;
            do
            {
                
                int id = TareasPendientes.Count+1;
                string? desc = Console.ReadLine();
                Console.Write("\nIngrese el tiempo estimado: ");
                int.TryParse(Console.ReadLine(), out int tiempo);

                if (desc !=null)
                {
                    var ejemplo = new Tarea(id,desc,tiempo,EstadoTarea.pendiente);
                }
                
                
                Console.WriteLine("\nTarea agregada correctamente");
                Console.WriteLine("\nDeseas agregar otra Tarea Pendiente:");
                Console.WriteLine("1) Si");
                Console.WriteLine("2) No");

                int.TryParse(Console.ReadLine(), out condicion);
            } while (condicion == 1);
            break;

        case 2:
            Console.WriteLine("\nElija la tarea de la Lista de Pendientes que desea pasar a la Lista de Realizadas(Ingrese ID): ");
            string? cambiarTarea = Console.ReadLine();
            int.TryParse(cambiarTarea, out int opcionElegida);

            foreach (var tarea in TareasPendientes)
            {
                if(tarea.Tareaid == opcionElegida)
                {
                    TareasRealizadas.Add(tarea);
                    TareasPendientes.Remove(tarea);
                    break;
                }
            }
            
            Console.WriteLine("\nLa tarea fue pasada correctamente");
            break;

        case 3:

            int cantidad = TareasPendientes.Count();
            if (cantidad == 0)
            {
                Console.WriteLine("\nLa lista esta vacia");
            }
            else
            {
                foreach (var tarea in TareasPendientes)
                {
                    Console.WriteLine(tarea.ShowTarea());
                }
            }
            break;


        case 4:
            int cantidad2 = TareasRealizadas.Count();
            if (cantidad2 == 0)
            {
                Console.WriteLine("\nLa lista esta vacia");
            }
            else
            {
                foreach (var tarea in TareasRealizadas)
                {
                    Console.WriteLine(tarea.ShowTarea());
                }
            }
            break;

        case 5:
            Console.WriteLine("\n\nIngrese el ID de la tarea buscada: ");
            int.TryParse(Console.ReadLine(), out int identificador);

            foreach (var tarea in TareasPendientes)
            {
                if(tarea.Tareaid == identificador)
                {
                   tarea.ShowTarea();
                }
            }
            foreach (var tarea in TareasRealizadas)
            {
                if(tarea.Tareaid == identificador)
                {
                    tarea.ShowTarea();
                }
            }
            break;

        case 6:
            Console.WriteLine("\n\nIngrese una palabra clave por la cual quiere buscar una tarea: ");
            string? palabra = Console.ReadLine();
            if (palabra!=null)
            {
                foreach (var tarea in TareasRealizadas)
                    {
                        if(tarea.Descripcion.IndexOf(palabra, StringComparison.OrdinalIgnoreCase) != -1)
                        {
                            tarea.ShowTarea();
                        }
                        else 
                        {
                            Console.WriteLine("La palabra no se encuentra");

                        }
                    }
                foreach (var tarea in TareasRealizadas)
                    {
                        if(tarea.Descripcion.IndexOf(palabra, StringComparison.OrdinalIgnoreCase) != -1)
                        {
                            tarea.ShowTarea();
                        }
                        else 
                        {
                            Console.WriteLine("La palabra no se encuentra");

                        }
                    }    
            }
            
            break;

        case 7:
            break;

        default:
            Console.WriteLine("\nOpcion no valida. Por favor, ingrese una opcion valida.\n");
            break;
    }

} while (opcion != 7);


/* var ejemplo = new Tarea(1,"terminar tp8",60,EstadoTarea.pendiente);
TareasPendientes.Add(ejemplo);
Console.WriteLine("la cantidad de elementos de tareas pendiente es: " + TareasPendientes.Count);
TareasPendientes.Remove(ejemplo);
TareasPendientes.RemoveAt(0); */

   


