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
                return this._visibility;
            }
            set
            {
                this._visibility = value;
                InvokeAsync(StateHasChanged);
            }
        }

        public virtual void Show()
        {
            this.DialogResult = DialogResult.None;
            mre = new(false);
            this.Visibility = true;
        }

        public virtual async Task<DialogResult> ShowDialog()
        {
            this.Show();

            await InvokeAsync(StateHasChanged);

            await Task.Run(this.Wait);

            return this.DialogResult;
        }

        private void Wait()
        {
            mre.WaitOne();
        }

        public virtual void Close(DialogResult dialogResult)
        {
            mre.Set();
            this.Visibility = false;
            this.DialogResult = dialogResult;
            InvokeAsync(StateHasChanged);
        }
    }
}