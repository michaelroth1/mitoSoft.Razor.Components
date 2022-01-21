using System;

namespace mitoSoft.Razor.Components
{
    public class ErrorBoundaryHandler
    {
        public event EventHandler<ErrorBoundaryEventArgs> OnExceptionFired;

        internal void InvokeExceptionFiredEvent(ErrorBoundaryEventArgs e)
        {
            this.OnExceptionFired?.Invoke(this, e);
        }
    }
}