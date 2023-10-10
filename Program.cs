using tp1._1B;

Galaxia viaLactea = new Galaxia();
bool fin = false;

while (!fin)
{
    viaLactea.ProcesarSistema();
    viaLactea.InformarSistema();
    fin = MenuSeleccion();
    if(!fin) viaLactea.ProximoSistema();
}
viaLactea.InformarGalaxia();

bool MenuSeleccion()
{
    Console.WriteLine("======= ### =======");
    Console.WriteLine("Entrar a otro sistema? y/n");
    string seleccion = Console.ReadKey().KeyChar.ToString().ToLower();
    Console.WriteLine("\n======= ### =======");
    return seleccion != "y";
}