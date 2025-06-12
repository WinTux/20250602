﻿using EjemplosASPNET.Models;
using Newtonsoft.Json;
namespace EjemplosASPNET.Herramientas
{
    public static class ConversorSupremo
    {
        public static void CsharpToJson(this ISession sesion, object p, string key) { 
            sesion.SetString(key, JsonConvert.SerializeObject(p));
        }

        public static T JsonToCsharp<T>(this ISession sesion, string key) { 
            var valor = sesion.GetString(key);
            return valor == null ? default(T) : JsonConvert.DeserializeObject<T>(valor);
        }
    }
}
