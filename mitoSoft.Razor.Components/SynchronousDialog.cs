using Microsoft.AspNetCore.Components;
using mitoSoft.Razor.Components.Enums;
using System.Threading.Tasks;

namespace mitoSoft.Razor.Components
{
    public class SynchronousDialog : ComponentBase
    {
        protected System.Threading.ManualResetEvent mre = new(false);

        public DialogResult DialogResult { get; set; }

        private bool _visibility;
        public bool Visibility
        {
            get
            {
                return _visibility;
            }
            set
            {
                _visibility = value;
                InvokeAsync(StateHasChanged);
            }
        }

        public virtual void Show()
        {
            DialogResult = DialogResult.None;
            mre = new(false);
            Visibility = true;
        }

        public virtual async Task<DialogResult> ShowDialog()
        {
            Show();

            await InvokeAsync(StateHasChanged);

            await Task.Run(Wait);

            return DialogResult;
        }

        private void Wait()
        {
            mre.WaitOne();
        }

        public virtual void Close(DialogResult dialogResult)
        {
            mre.Set();
            Visibility = false;
            DialogResult = dialogResult;
            InvokeAsync(StateHasChanged);
        }
    }
}