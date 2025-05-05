﻿using Newtonsoft.Json;

namespace ProjektSklepTI.Infrastructure
{
    public static class SessionHelper
    {

        public static void SetObjectAsJson(this ISession session, string key, object value)
        {

            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static T GetObjectAsJson<T>(this ISession session, string key )
        {
            var value = session.GetString(key);

            return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }
    }
}
