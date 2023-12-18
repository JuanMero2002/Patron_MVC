public class BolonController
{
    private BolonModel model;
    private BolonView view;

    public BolonController(BolonModel model, BolonView view)
    {
        this.model = model;
        this.view = view;
    }

    public void ManejarInput(int opcion)
    {
        List<string> ingredientes = new List<string> { "Platano verde", "Aceite" };

        if (opcion == 1)
            ingredientes.Add("Queso");
        else if (opcion == 2)
            ingredientes.Add("Chicharron");
        else if (opcion == 3)
        {
            ingredientes.Add("Queso");
            ingredientes.Add("Chicharron");
        }

        string resultado = model.PrepararBolon(ingredientes);
        view.MostrarMensaje(resultado);
    }
}
