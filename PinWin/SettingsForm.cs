using System.Runtime.CompilerServices;
using System.Windows.Forms;
using PinWin.BusinessLayer;

namespace PinWin
{
    public partial class SettingsForm : Form
    {
        private readonly ApplicationSettings _settings;

        /// <summary>
        ///  Constructor reserved for windows designer, use the other one in code.
        /// </summary>
        public SettingsForm()
        {
            InitializeComponent();

            txt_ShortcutPinWindowPrompt.PreviewKeyDown += txt_PreviewKeyDown;
            txt_ShortcutPinWindowUnderCursor.PreviewKeyDown += txt_PreviewKeyDown;
        }

        /// <summary>
        ///  Use this constructor in code.
        /// </summary>
        /// <param name="initialSettings">Initial application settings.</param>
        public SettingsForm(ApplicationSettings initialSettings) : this()
        {
            this._settings = initialSettings;

            //TODO: implement data binding
            txt_ShortcutPinWindowPrompt.Text = KeysStringConverter.ToString(initialSettings.ShortcutPinWindowPrompt);
            txt_ShortcutPinWindowUnderCursor.Text = KeysStringConverter.ToString(initialSettings.ShortcutPinWindowUnderCursor);
        }
        
        private void txt_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (!(sender is TextBox senderTextBox))
            {
                return;
            }

            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                //delete current key combination
                senderTextBox.Text = string.Empty;
            }

            string shortcutString = KeysStringConverter.ToString(e.KeyCode | e.Modifiers);
            if (shortcutString == null)
            {
                //invalid shortcut pressed by user - do not overwrite previous shortcut
                return;
            }

            senderTextBox.Text = shortcutString;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            //save key combinations
            //TODO: implement data binding
            this._settings.ShortcutPinWindowPrompt = KeysStringConverter.FromString(txt_ShortcutPinWindowPrompt.Text);
            this._settings.ShortcutPinWindowUnderCursor = KeysStringConverter.FromString(txt_ShortcutPinWindowUnderCursor.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_Cancel_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public static ApplicationSettings ShowSettingsDialog(IWin32Window owner, ApplicationSettings settings)
        {
            var settingsForm = new SettingsForm(settings);
            if (settingsForm.ShowDialog(owner) != DialogResult.OK)
            {
                return null;
            }
            return settingsForm._settings;
        }
    }
}