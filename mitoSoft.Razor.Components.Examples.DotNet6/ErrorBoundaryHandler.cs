namespace mitoSoft.Razor.Components.Examples.DotNet6
{
    public class ErrorBoundaryHandler : IErrorBoundaryHandler
    {
        public string OnExceptionFired(Exception exception)
        {
            return "Changed exception Text";
        }
    }
}