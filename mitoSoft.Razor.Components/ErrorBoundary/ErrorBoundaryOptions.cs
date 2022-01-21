namespace mitoSoft.Razor.Components
{
    public class ErrorBoundaryOptions
    {
        public bool Reload { get; set; } = false;

        public ErrorBoundaryMode Mode { get; set; } = ErrorBoundaryMode.ErrorText;

        public bool ShowChildContentOnError { get; set; } = false;
    }
}