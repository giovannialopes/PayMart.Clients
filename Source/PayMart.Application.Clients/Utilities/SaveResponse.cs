﻿using System.Net.Http;

namespace PayMart.Application.Clients.Utilities;

public class SaveResponse
{
    private static int _userId;
    public static void SaveUserId(int userId) => _userId = userId;
    public static int GetUserId() => _userId;




}
