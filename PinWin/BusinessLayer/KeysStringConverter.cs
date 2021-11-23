namespace PinWin.BusinessLayer
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Windows.Forms;

    /// <summary>
    ///  Converts Keys enum values with modifiers to and from string, using standard keyboard shortcut notation.
    /// </summary>
    internal class KeysStringConverter
    {
        /// <summary>
        ///  Converts keyboard shortcut into its user friendly string representation.
        /// </summary>
        /// <param name="keys">Keys pressed by user.</param>
        /// <returns>User friendly string representation of the keyboard shortcut, including modifiers.</returns>
        public static string ToString(Keys keys)
        {
            if ((keys & ~Keys.ShiftKey & ~Keys.ControlKey & ~Keys.Menu &
                        ~Keys.Shift    & ~Keys.Control    & ~Keys.Alt) == Keys.None)
            {
                //do not capture if modifiers keys are pressed on their own
                return null;
            }
            
            string modifierKeysString = KeysStringConverter.ModifierKeysToString(ref keys);
            if (modifierKeysString == string.Empty)
            {
                //do not accept keys pressed without a modifier
                return null;
            }

            string keyName = keys.ToString();
            return modifierKeysString + keyName;
        }

        /// <summary>
        ///  Converts user friendly string representation of the keyboard shortcuts to Keys enum.
        /// </summary>
        /// <param name="keys">String representing keyboard shortcut.</param>
        /// <returns>Keys enum that includes the actual key pressed as well as any modifiers.</returns>
        public static Keys FromString(string keys)
        {
            Keys retValue = Keys.None;
            if (keys == null)
            {
                return retValue;
            }

            string[] parts = keys.Split('+'); //modifier separator

            for (int i = 0; i < parts.Length; i++)
            {
                //ignore spaces in between modifier separators (+)
                string keyName = parts[i].Trim();

                if (i < parts.Length - 1)
                {
                    //(n-1) elements are all modifiers
                    retValue |= ParseModifierKeyFromString(parts[i]);
                }
                else
                {
                    //last element is the actual key
                    if (!Enum.TryParse(keyName, true, out Keys parseResult))
                    {
                        //modifier without a valid key is not a valid key combination
                        return Keys.None;
                    }

                    //key is valid, append to result
                    retValue |= parseResult;
                }
            }

            return retValue;
        }

        /// <summary>
        ///  Converts modifier keys value into a user friendly string.
        /// </summary>
        /// <param name="modifiersKeys">Modifier keys, for example, from a KeyDown event.</param>
        /// <returns>User friendly string representation of modifier keys pressed by user.</returns>
        private static string ModifierKeysToString(ref Keys modifiersKeys)
        {
            // ReSharper disable once UseObjectOrCollectionInitializer
            var modifiersDictionary = new Dictionary<Keys, string>();
            modifiersDictionary.Add(Keys.Shift, "SHIFT");
            modifiersDictionary.Add(Keys.Control, "CTRL");
            modifiersDictionary.Add(Keys.Alt, "ALT");

            var keyString = new StringBuilder();
            foreach (KeyValuePair<Keys, string> keyValuePair in modifiersDictionary)
            {
                Keys modifierKey = keyValuePair.Key;
                if ((modifiersKeys & modifierKey) != modifierKey) continue;

                //good, this is a valid modifier key, append its string name to result
                string modifierKeyName = keyValuePair.Value;
                keyString.Append(modifierKeyName + " + ");

                //then modify the original by ref Keys enum to exclude this modifier
                //after for loop completes, the original key will be without any modifiers
                modifiersKeys &= ~modifierKey;
            }

            return keyString.ToString();
        }

        /// <summary>
        ///  Parses modifier key value from a user friendly string.
        /// </summary>
        /// <param name="modifier">A single modifier represented as string.</param>
        /// <returns>Keys enum value.</returns>
        private static Keys ParseModifierKeyFromString(string modifier)
        {
            switch (modifier.Trim())
            {
                case "SHIFT": return Keys.Shift;
                case "CTRL": return Keys.Control;
                case "ALT": return Keys.Alt;
            }

            return Keys.None;
        }
    }
}