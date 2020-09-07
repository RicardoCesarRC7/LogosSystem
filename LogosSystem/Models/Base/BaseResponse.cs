using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LogosSystem.Models.Base
{
    public class BaseResponse
    {
        public bool Success { get; set; }
        public string Description { get; set; }
    }
}