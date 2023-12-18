public class BolonModel
{
    public string PrepararBolon(List<string> ingredientes)
    {
        if (ingredientes.Contains("Platano verde") && ingredientes.Contains("Aceite"))
        {
            if (ingredientes.Contains("Queso") && ingredientes.Contains("Chicharron"))
                return "Bolon Mixto preparado con éxito.";
            else if (ingredientes.Contains("Queso"))
                return "Bolon de Queso preparado con éxito.";
            else if (ingredientes.Contains("Chicharron"))
                return "Bolon de Chicharron preparado con éxito.";
        }

        return "Por favor, seleccione una de las 3 opciones.";
    }
}
