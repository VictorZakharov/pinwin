namespace PinWin.BusinessLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Windows.Forms;

    using Controls;

    /// <summary>
    ///  Business object representing list of pinned windows, used for UI binding.
    /// </summary>
    public class PinFormFactory : BindingList<PinForm>
    {
        #region " Public methods "

        /// <summary>
        ///  Try to retrieve a window with the same handle from the list of owned windows.
        /// </summary>
        /// <param name="handle">Window to be found.</param>
        /// <returns>Found window or null, if cannot be found.</returns>
        public PinForm TryGetItem(IntPtr handle)
        {
            return this.FirstOrDefault(pinForm => pinForm.ParentHandle == handle);
        }

        /// <summary>
        ///  Remove a range of items from the list using window handle as key.
        /// </summary>
        /// <param name="items">Items to be removed.</param>
        public void RemoveRange(IList<PinForm> items)
        {
            for (int index = items.Count - 1; index >= 0; index--)
            {
                PinForm selectedForm = items[index];
                selectedForm.Close();
            }
        }

        /// <summary>
        ///  Try to add a window to the list of pinned items.
        /// </summary>
        /// <param name="handle">Item to be added.</param>
        /// <returns><c>true</c> if item was added, <c>false</c> if already exists.</returns>
        public bool TryAddPinned(IntPtr handle)
        {
            PinForm existingItem = this.TryGetItem(handle);
            if (existingItem != null)
            {
                return false;
            }

            try
            {
                PinForm newForm = PinForm.Create(handle);
                newForm.FormClosing += PinFormOnClosing;
                this.Add(newForm);
                return true;
            }
            catch (Win32Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
                return false;
            }
        }

        private void PinFormOnClosing(object sender, FormClosingEventArgs formClosingEventArgs)
        {
            PinForm pinForm = (PinForm) sender;
            this.Remove(pinForm);
        }

        #endregion
    }
}