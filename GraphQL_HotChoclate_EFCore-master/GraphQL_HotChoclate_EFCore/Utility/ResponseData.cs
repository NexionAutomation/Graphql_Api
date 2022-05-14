using HotChocolate;
using System;
using System.Collections;
using System.Collections.Generic;

namespace GraphQl.Api.Utility
{
    public class ResponseData<T> where T : class
    {
      
        public string ID { get; set; }
        public string Code { get; set; }
        public string Message { get; set; }
        public  string Status { get; set; }
        
        
        public virtual  ICollection<T> Detail { get; set; }    




    }
    public static class ResponseStatus <T> where T : IEnumerable
    {

        public static string Status { get; set; }

    }






    }
