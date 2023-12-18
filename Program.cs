class Program
{
    static void Main(string[] args)
    {
        BolonModel model = new BolonModel();
        BolonView view = new BolonView();
        BolonController controller = new BolonController(model, view);

        view.MostrarOpciones();

        Console.Write("Seleccione el tipo de bolon (1, 2 o 3): ");
        int opcion = int.Parse(Console.ReadLine());

        controller.ManejarInput(opcion);
    }
}
