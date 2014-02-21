using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EnterpriseTraining.ErrorHandling
{
    public static class ExceptionHandler
    {
        public delegate void Target();

        public static void Invoke(IWin32Window owner, Target target)
        {
            try
            {
                target();
            }
            catch (Exception ex)
            {
                DisplayException(owner, ex);
            }
        }

        private static void DisplayException(IWin32Window owner, Exception exception)
        {
            ShowError(owner, GetErrorMessage(exception));
        }

        private static string GetErrorMessage(Exception exception)
        {
            var errorMessage = new StringBuilder();

            Exception current = exception;
            while (current != null)
            {
                errorMessage.AppendLine(current.Message);

                current = current.InnerException;
            }

            return errorMessage.ToString();
        }

        private static void ShowError(IWin32Window owner, string message)
        {
            MessageBox.Show(owner, message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
