// Decompiled with JetBrains decompiler
// Type: PointBlank.Battle.Data.Xml.CharaXml
// Assembly: PointBlank.Battle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5534FC46-6392-4D1E-A8AF-9FA212DDCBF9
// Assembly location: D:\Servers\Debug\PointBlank.Battle.exe

using PointBlank.Battle.Data.Models;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace PointBlank.Battle.Data.Xml
{
  public class CharaXml
  {
    public static List<CharaModel> _charas = new List<CharaModel>();

    public static int getLifeById(int charaId, int type)
    {
      for (int index = 0; index < CharaXml._charas.Count; ++index)
      {
        CharaModel chara = CharaXml._charas[index];
        if (chara.Id == charaId && chara.Type == type)
          return chara.Life;
      }
      return 100;
    }

    public static void Load()
    {
      string path = "Data/Battle/Charas.xml";
      if (File.Exists(path))
        CharaXml.parse(path);
      else
        Logger.warning("File not found: " + path);
    }

    private static void parse(string path)
    {
      XmlDocument xmlDocument = new XmlDocument();
      using (FileStream fileStream = new FileStream(path, FileMode.Open))
      {
        if (fileStream.Length > 0L)
        {
          try
          {
            xmlDocument.Load((Stream) fileStream);
            for (XmlNode xmlNode1 = xmlDocument.FirstChild; xmlNode1 != null; xmlNode1 = xmlNode1.NextSibling)
            {
              if ("List".Equals(xmlNode1.Name))
              {
                for (XmlNode xmlNode2 = xmlNode1.FirstChild; xmlNode2 != null; xmlNode2 = xmlNode2.NextSibling)
                {
                  if ("Chara".Equals(xmlNode2.Name))
                  {
                    XmlNamedNodeMap attributes = (XmlNamedNodeMap) xmlNode2.Attributes;
                    CharaModel charaModel = new CharaModel() { Id = int.Parse(attributes.GetNamedItem("Id").Value), Type = int.Parse(attributes.GetNamedItem("Type").Value), Life = int.Parse(attributes.GetNamedItem("Life").Value) };
                    CharaXml._charas.Add(charaModel);
                  }
                }
              }
            }
          }
          catch (XmlException ex)
          {
            Logger.warning(ex.ToString());
          }
        }
        fileStream.Dispose();
        fileStream.Close();
      }
      Logger.info("Loaded: " + (object) CharaXml._charas.Count + " charas information");
    }
  }
}
