namespace PinWin.Controls
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    using BusinessLayer;
    using WinApi;
    using static WinApi.ApiWinEventHook;

    public partial class PinForm : Form
    {
        private WinEventHook _winEventHook;
        private bool _receivesParentMoveEvents;

        private readonly IntPtr _parentHandle;
        private readonly string _parentFormTitle;
        // ReSharper disable once UnusedMember.Global - used by Windows forms data binding
        public string ParentTitle => $"{this._parentFormTitle} ({this._parentHandle})";

        public IntPtr ParentHandle => this._parentHandle;
        public bool ReceivesParentMoveEvents => _receivesParentMoveEvents;

        public PinForm()
        {
            InitializeComponent();
        }

        public PinForm(IntPtr parentHandle) : this()
        {
            this._parentHandle = parentHandle;
            this._parentFormTitle = ApiWindowTitle.FromHandle(parentHandle);
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            ApiTopMost.Clear(this._parentHandle);
            this._winEventHook.Dispose();

            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        public static PinForm Create(IntPtr parentHandle)
        {
            PinForm pinForm = new PinForm(parentHandle);
            ApiTopMost.Set(parentHandle);
            PinForm.ShowSetOwnerHandle(pinForm, parentHandle);
            return pinForm;
        }

        /// <summary>
        ///  Resets pinned icon location relative to parent when parent is moved.
        /// </summary>
        public void MoveToParentWindow()
        {
            Point newLocation = PinForm.GetRelativeLocation(this._parentHandle);
            this.Left = newLocation.X;
            this.Top = newLocation.Y;
        }

        /// <summary>
        ///  Determines if the parent form handle is still open.
        /// </summary>
        public bool IsParentOpen => ApiWindowPos.IsWindow(this.ParentHandle);

        /// <summary>
        ///  Determines if the parent form is minimized to tray.
        /// </summary>
        public bool IsParentMinimized => ApiWindowPos.IsIconic(this.ParentHandle);

        private void PinForm_Load(object sender, EventArgs e)
        {
            if (this._parentHandle == IntPtr.Zero)
            {
                return;
            }

            this._winEventHook = new WinEventHook(this._parentHandle);
            this._winEventHook.Add(EventId.EVENT_OBJECT_LOCATIONCHANGE, ParentForm_Moved);
            this._winEventHook.Add(EventId.EVENT_SYSTEM_MOVESIZEEND, ParentForm_Moved);
            this._winEventHook.Add(EventId.EVENT_OBJECT_DESTROY, ParentForm_Destroyed);

            this.MoveToParentWindow();
        }

        private void ParentForm_Moved(IntPtr hWinEventHook, uint eventType, IntPtr hwnd, int idObject, int idChild,
            uint dwEventThread, uint dwmsEventTime)
        {
            if (hwnd != this._parentHandle)
            {
                //skip unwanted events
                return;
            }

            this._receivesParentMoveEvents = true;
            this.MoveToParentWindow();
        }

        private void ParentForm_Destroyed(IntPtr hWinEventHook, uint eventType, IntPtr hwnd, int idObject, int idChild,
            uint dwEventThread, uint dwmsEventTime)
        {
            if (hwnd != this._parentHandle || idObject != 0)
            {
                //skip unwanted events
                return;
            }

            this.Close();
        }

        /// <summary>
        ///  OnPaint is used to make it work in XP, as well as later OS.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            var pinnedBitmap = Resources.Pinned;
            pinnedBitmap.MakeTransparent();
            e.Graphics.DrawImage(pinnedBitmap, new Point(0, 0));
        }

        private void PinForm_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        /// <summary>
        ///  Used for debugging purposes.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{this._parentHandle} - {this._parentFormTitle}";
        }

        /// <summary>
        ///  Calculates absolute location of pin icon based on parent form's handle.
        /// </summary>
        /// <param name="handle">Parent window handle.</param>
        /// <returns>Absolute location of pin icon.</returns>
        private static Point GetRelativeLocation(IntPtr handle)
        {
            var style = new WindowStyle(handle);
            int rightMargin = style.GetControlBoxWidth() + 20;
            Rectangle move = ApiWindowPos.Get(handle);

            return new Point(move.Left + move.Width - rightMargin, move.Top + 5);
        }

        public static void ShowSetOwnerHandle(Form form, IntPtr ownerHandle)
        {
            NativeWindow nativeWindow = new NativeWindow();
            nativeWindow.AssignHandle(ownerHandle);
            form.Show(nativeWindow);
            nativeWindow.ReleaseHandle();
        }
    }
}