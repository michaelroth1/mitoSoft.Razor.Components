using System;

namespace mitoSoft.Razor.Components
{
    public class ErrorBoundaryEventArgs : EventArgs
    {
        public ErrorBoundaryEventArgs(string message, bool reload, ErrorBoundaryMode mode, bool showChildContentOnError)
        {
            this.Message = message;
            this.Reload = reload;
            this.Mode = mode;
            this.ShowChildContentOnError = showChildContentOnError;
        }

        public bool Reload { get; set; } = false;

        public string Message { get; set; } = string.Empty;

        public ErrorBoundaryMode Mode { get; set; } = ErrorBoundaryMode.ErrorText;

        public bool ShowChildContentOnError { get; set; } = false;
    }
}