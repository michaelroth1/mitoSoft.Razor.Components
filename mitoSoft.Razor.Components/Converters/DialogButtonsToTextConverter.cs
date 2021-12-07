using mitoSoft.Razor.Components.Enums;

namespace mitoSoft.Razor.Components.Converters
{
    internal static class DialogButtonsToTextConverter
    {
        public static string ToNoText(this DialogButtons dialogResult)
        {
            if (dialogResult == DialogButtons.OkCancle)
            {
                return Properties.Resources.Cancle;
            }
            else
            {
                return Properties.Resources.No;
            }            
        }

        public static string ToYesText(this DialogButtons dialogResult)
        {
            if (dialogResult == DialogButtons.YesNo)
            {
                return Properties.Resources.Yes;
            }
            else
            {
                return "OK";
            }
        }
    }
}
