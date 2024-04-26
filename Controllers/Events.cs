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



    /// <summary>
    /// Eliminar un evento.
    /// </summary>
    /// <param name="id">Id del evento.</param>
    /// <param name="token">Token de acceso.</param>
    public async static Task<ResponseBase> Delete(int id, string token)
    {

        // Cliente HTTP.
        Client client = Service.GetClient("events");

        // Headers.
        client.AddHeader("token", token);

        // Id del evento.
        client.AddParameter("id", id);

        // Resultado.
        var Content = await client.Delete<ResponseBase>();

        // Retornar.
        return Content;

    }



    /// <summary>
    /// Actualizar un evento.
    /// </summary>
    /// <param name="modelo">Modelo del evento.</param>
    /// <param name="token">Token de acceso.</param>
    public async static Task<ResponseBase> Update(EventModel modelo, string token)
    {

        // Cliente HTTP.
        Client client = Service.GetClient("events");

        // Headers.
        client.AddHeader("token", token);

        // Resultado.
        var Content = await client.Patch<ResponseBase>(modelo);

        // Retornar.
        return Content;

    }



}