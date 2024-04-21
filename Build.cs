﻿namespace LIN.Access.Calendar;


public class Build
{

    internal static string Application { get; set; } = string.Empty;

    public static void SetAuth(string app)
    {
        Application = app;
    }


    public static void Init(string? url = null)
    {
        Service._Service = new();
        Service._Service.SetDefault(url ?? "http://localhost:5253/");
    }

}