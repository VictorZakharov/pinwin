using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PinWin.WinApi;

namespace PinWin.BusinessLayer
{
  public class HotKeyList
  {
    private readonly Form _parentForm;
    private readonly List<HotKey> _hotKeyList;

    public HotKeyList(Form form)
    {
      this._parentForm = form;
      this._hotKeyList = new List<HotKey>();
    }

    public void Add(Keys keys, Action action)
    {
      int keyId = this._hotKeyList.Count;
      this._hotKeyList.Add(new HotKey(keys, action));
      ApiHotKey.Set(this._parentForm, keys, keyId);
    }

    public void Clear()
    {
      for (int index = this._hotKeyList.Count - 1; index >= 0; index--)
      {
        ApiHotKey.Clear(this._parentForm, index);
        this._hotKeyList.RemoveAt(index);
      }
    }

    public HotKey Find(Message m)
    {
      if (m.Msg != ApiHotKey.WM_HOTKEY)
      {
        return null;
      }

      int keyId = m.WParam.ToInt32();
      HotKey hotKey = this._hotKeyList[keyId];
      return hotKey;
    }
  }
}