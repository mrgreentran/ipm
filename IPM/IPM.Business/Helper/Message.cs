namespace IPM.Business.Helper
{
    /// <summary>
    /// Message of active
    /// </summary>
    public class Message
    {
        // Content of message
        public string Content { get; set; }

        // Type notificate error, success, danger,...
        public string Alert { get; set; }

        // Flag check true false
        public bool Status { get; set; }
    }
}