using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System.IO;
using System.Xml;


public class xmlparsing : MonoBehaviour
{

   
    public TextReader uiText;

    // Start is called before the first frame update
    void Start()
    {
        string url = "http://www.heritage.go.kr/heri/gungDetail/gogungListOpenApi.do";
        WWW www = new WWW(url);
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(www.text.Trim());
        parseXmlFile(xmlDoc.SelectNodes("//result/script/list"));
    }
    void parseXmlFile(XmlNodeList nodes)
    {

        foreach (XmlNode node in nodes)
        {
            string totVal = "";
            XmlNode serial_number = node.FirstChild;
            XmlNode explanation_eng = serial_number.NextSibling;

            if (serial_number.InnerXml == "161")
            {
                totVal += "explanation_eng.InnerXml";
                Debug.Log(totVal);
            }



        }

    }
}
