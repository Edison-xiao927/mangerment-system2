﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using NAPS2.Lang.Resources;
using NAPS2.Util;

namespace NAPS2.WinForms
{
    public class MessageBoxErrorOutput : IErrorOutput
    {
        private readonly DialogHelper dialogHelper;

        public MessageBoxErrorOutput(DialogHelper dialogHelper)
        {
            this.dialogHelper = dialogHelper;
        }

        public void DisplayError(string errorMessage)
        {
            Invoker.Current.SafeInvoke(() => MessageBox.Show(errorMessage, MiscResources.Error, MessageBoxButtons.OK, MessageBoxIcon.Error));
        }

        public void DisplayError(string errorMessage, string details)
        {
            Invoker.Current.SafeInvoke(() => dialogHelper.ShowErrorWithDetails(errorMessage, details));
        }

        public void DisplayError(string errorMessage, Exception exception)
        {
            Invoker.Current.SafeInvoke(() => dialogHelper.ShowErrorWithDetails(errorMessage, exception.ToString()));
        }
    }
}