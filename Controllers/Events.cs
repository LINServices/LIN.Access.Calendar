namespace LIN.Access.Calendar.Controllers;


public static class Events
{


    /// <summary>
    /// Crear un contacto.
    /// </summary>
    /// <param name="token">Token de acceso.</param>
    public async static Task<CreateResponse> Create(string token, EventModel modelo)
    {

        // Cliente HTTP.
        Client client = Service.GetClient("events");

        // Headers.
        client.AddHeader("token", token);
        // Resultado.
        var Content = await client.Post<CreateResponse>(modelo);

        // Retornar.
        return Content;

    }



    /// <summary>
    /// Obtiene los contactos asociados a un perfil.
    /// </summary>
    /// <param name="token">Token de acceso</param>
    public async static Task<ReadAllResponse<EventModel>> ReadAll(string token)
    {

        // Cliente HTTP.
        Client client = Service.GetClient("events/all");

        // Headers.
        client.AddHeader("token", token);

        // Resultado.
        var Content = await client.Get<ReadAllResponse<EventModel>>();

        // Retornar.
        return Content;

    }


}