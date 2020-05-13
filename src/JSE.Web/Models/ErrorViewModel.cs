using System;

namespace JSE.Web.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        public string ErrorMessage { get; set; }

        public bool ShowErrorMessage => !string.IsNullOrEmpty(ErrorMessage);

        public string Path { get; set; }

        public bool ShowPath => !string.IsNullOrEmpty(Path);
    }
}
