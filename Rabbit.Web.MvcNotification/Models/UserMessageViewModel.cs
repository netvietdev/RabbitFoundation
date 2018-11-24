namespace Rabbit.Web.MvcNotification.Models
{
    public class UserMessageViewModel
    {
        public string Title { get; set; }

        public string Message { get; set; }

        /// <summary>
        /// The action URL for Confirm/Next button
        /// </summary>
        public string NextAction { get; set; }

        /// <summary>
        /// The action URL for Cancel/Back button
        /// </summary>
        public string BackAction { get; set; }
    }
}