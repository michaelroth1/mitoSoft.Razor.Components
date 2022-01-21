using System;

namespace mitoSoft.Razor.Components
{
    public interface IErrorBoundaryHandler
    {
        public string OnExceptionFired(Exception exception);
    }
}