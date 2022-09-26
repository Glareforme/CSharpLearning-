using System;
using System.Collections.Generic;
using System.Text;

namespace APITest.Constants
{
    public class ResponceConstants
    {
        public const string GetMethod = "Get";
        public const string PostMethod = "Post";
        public const string PutMethod = "Put";
        public const string Status = "success";
        public const string ErrorStatus = "error";
        public const string ErrorMassageNotFound = "Not found record";
        public const int Status400 = 400;
        public const string ErrorContentIdEmpty = "id is empty";
        public const string MessagePost = "Successfully! Record has been added.";
        public const string MessagePut = "Successfully! Record has been updated.";
        public const string MessageGet = "Successfully! Record has been fetched.";
        public const string MessageDelete = "Successfully! Record has been deleted";
    }
}
