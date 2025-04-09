
    
        var salarioMinimo = 1500000m;
        int horasSalario = 160;
        var valorHora = salarioMinimo / horasSalario;

        Console.Write("Ingrese el nombre del empleado: ");
        string nombre = Console.ReadLine();

        Console.Write("Ingrese las horas trabajadas en días normales: ");
        int horasNormales = int.Parse(Console.ReadLine());

        int horasDominicales = 0;
        Console.Write("¿Trabajó el domingo? (s/n): ");
        string trabajaDomingo = Console.ReadLine().Trim().ToLower();

        if (trabajaDomingo == "s")
        {
            Console.Write("Ingrese cuántas horas trabajó el domingo: ");
            horasDominicales = int.Parse(Console.ReadLine());
        }

        decimal pagoHoraNormal = valorHora;
        decimal pagoHoraDomingo = valorHora * 2;

        decimal pagoHorasNormales = horasNormales * pagoHoraNormal;
        decimal pagoHorasDominicales = horasDominicales * pagoHoraDomingo;
        decimal totalPagar = pagoHorasNormales + pagoHorasDominicales;

        if (totalPagar < salarioMinimo)
        {
            totalPagar = salarioMinimo;
        }

        
        Console.WriteLine($"\nResumen de nómina para {nombre}:");
        Console.WriteLine($"Horas normales: {horasNormales} x ${pagoHoraNormal} = ${pagoHorasNormales}");
        Console.WriteLine($"Horas en domingo: {horasDominicales} x ${pagoHoraDomingo} = ${pagoHorasDominicales}");
        Console.WriteLine($"Total a pagar: ${totalPagar}");
    





