using System.Collections.Generic;

namespace IPM.Business.Helper
{
    public class Data<T> where T : class
    {
        // List data
        public IEnumerable<T> ListData { get; set; }

        // Content of message
        public string Content { get; set; }

        // Type notificate error, success, danger,...
        public string Alert { get; set; }

        // Flag check true false
        public bool Status { get; set; }
    }
}