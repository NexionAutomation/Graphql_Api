using HotChocolate;
using HotChocolate.Types;
using System;
using System.Collections;
using System.Collections.Generic;

namespace GraphQl.Api.Utility.Custom
{
    public static class ResponseMSG<U> where U : class
    {
        public static ResponseData<U> Success<T>(T Detail,string ID= default,string code= default,string Status=default)
        {
           
            return new ResponseData<U> { Message = "Success", Code = code, Detail = (ICollection<U>)Detail, ID = Guid.NewGuid().ToString(), Status = Status };
        }
        public static ResponseData<U> Failed<T>(T Detail, string ID = default, string code = default, string Status = default)
        {
            return new ResponseData<U> { Message = "Failed", Code = code, Detail = (ICollection<U>)Detail, ID = Guid.NewGuid().ToString(), Status = Status };
        }
        public static ResponseData<U> Error<T>(T Detail, string ID = default, string code = default, string Status = default)
        {
            return new ResponseData<U> { Message = "Error", Code = code, Detail = (ICollection<U>)Detail, ID = Guid.NewGuid().ToString(), Status = Status };
        }

       
    }

    public class ExampleInput
    {
        [GraphQLType(typeof(NonNullType<UploadType>))]
        public IFile File { get; set; }
    }
}
