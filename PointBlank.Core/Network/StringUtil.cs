// Decompiled with JetBrains decompiler
// Type: PointBlank.Core.Network.StringUtil
// Assembly: PointBlank.Core, Version=0.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: 65DC4F5C-10DD-4A35-B456-FD3CF4AB2BB5
// Assembly location: D:\Servers\Debug\PointBlank.Core.dll

using System.Text;

namespace PointBlank.Core.Network
{
  public class StringUtil
  {
    private static StringBuilder builder;

    public StringUtil()
    {
      StringUtil.builder = new StringBuilder();
    }

    public void AppendLine(string text)
    {
      StringUtil.builder.AppendLine(text);
    }

    public string getString()
    {
      if (StringUtil.builder.Length == 0)
        return StringUtil.builder.ToString();
      return StringUtil.builder.Remove(StringUtil.builder.Length - 1, 1).ToString();
    }
  }
}
