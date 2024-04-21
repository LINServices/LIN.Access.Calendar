namespace LIN.Access.Calendar.Controllers;


public static class Profiles
{


    /// <summary>
    /// Iniciar sesión
    /// </summary>
    /// <param name="cuenta">Cuenta</param>
    /// <param name="password">Contraseña</param>
    /// <param name="app">App de contexto</param>
    public async static Task<ReadOneResponse<Types.Cloud.Identity.Abstracts.AuthModel<ProfileModel>>> Login(string cuenta, string password)
    {

        // Cliente HTTP.
        Client client = Service.GetClient("profile/login");

        // Params.
        client.AddParameter("user", cuenta);
        client.AddParameter("password", password);

        // Resultado.
        var Content = await client.Get<ReadOneResponse<Types.Cloud.Identity.Abstracts.AuthModel<ProfileModel>>>();

        // Retornar.
        return Content;

    }



    /// <summary>
    /// Login
    /// </summary>
    /// <param name="token">Token de acceso</param>
    public async static Task<ReadOneResponse<Types.Cloud.Identity.Abstracts.AuthModel<ProfileModel>>> Login(string token)
    {

        // Cliente HTTP.
        Client client = Service.GetClient("profile/login/token");

        // Params.
        client.AddParameter("token", token);

        // Resultado.
        var Content = await client.Get<ReadOneResponse<Types.Cloud.Identity.Abstracts.AuthModel<ProfileModel>>>();

        // Retornar.
        return Content;

    }



}
