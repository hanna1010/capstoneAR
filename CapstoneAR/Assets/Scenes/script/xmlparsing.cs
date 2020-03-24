using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System.IO;
using System.Xml;


public class xmlparsing : MonoBehaviour
{

    public TextAsset xmlRawFile;
    public TextReader uiText;

    // Start is called before the first frame update
    void Start()
    {
        string data = xmlRawFile.text;
        parseXmlFile(data);

    }
    void parseXmlFile(string xmlData)
    {
        string url = "http://www.heritage.go.kr/heri/gungDetail/gogungListOpenApi.do";
        WWW www = new WWW(url);
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(www.text);

        string xmlPathPattern = "//result/script/list";
        XmlNodeList myNodeList = xmlDoc.SelectNodes(xmlPathPattern);

        foreach (XmlNode node in myNodeList)
        { 
            
        }

    }
}
