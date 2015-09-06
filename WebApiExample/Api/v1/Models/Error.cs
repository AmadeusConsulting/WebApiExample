using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiExample.Api.v1.Models
{
    public class Error
    {
        public String Message { get; set; }
        public String StackTrace { get; set; }
    }
}