using Newtonsoft.Json;
using System.Collections.Generic;

namespace IATCINDIA.APPLICATION.CommonServices.Class
{
    public static class CommonServices<T>   
    {
        public static string ConvertJSONString(object input)
        {
             return JsonConvert.SerializeObject(input);
        }

        public static List<T> ConvertJSONStringtoClass(string input)
        {
            return JsonConvert.DeserializeObject<List<T>>(input);
        }

       
    }
}
