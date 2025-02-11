using FS0924_BE_S1_L2.Models;


var persona1 = new Persona("Federico","Tonti",29);
var persona2 = new Persona("Vittorio", "Turiaci");





Console.WriteLine(persona1.GetNome());
Console.WriteLine(persona1.GetCognome());
Console.WriteLine(persona1.GetEta());
Console.WriteLine(persona1.GetDettagli());
Console.WriteLine(persona2.GetNome());
Console.WriteLine(persona2.GetCognome());
Console.WriteLine(persona2.GetEta());
Console.WriteLine(persona2.GetDettagli());
