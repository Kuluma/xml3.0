﻿
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
namespace xml3._0
{
    class DevProps
    {
        //string path = FilePath.filePath+ "\\DevProps.xml";
        string path = @"C:\Users\ShenBoyi\Desktop\大丽线\Station_HDZ\DevProps.xml";
        public DevProps()
        {

        }
        private string Type;
        public string type
        {
            get { return Type; }
            set { Type = value; }
        }
        private string Name;
        public string name
        {
            get { return Name; }
            set { Name = value; }
        }
        private string Id;
        public string id
        {
            get { return Id; }
            set { Id = value; }
        }
        private string alias;
        public string Alias
        {
            get { return alias; }
            set { alias = value; }
        }
        private string throatType;
        public string ThroatType
        {
            get { return throatType; }
            set { throatType = value; }
        }
        private string relatedDev;
        public string RelatedDev
        {
            get { return relatedDev; }
            set { relatedDev = value; }
        }
        private string fieldNo;
        public string FieldNo
        {
            get { return fieldNo; }
            set { fieldNo = value; }
        }
        private string tSRLineNo;
        public string TSRLineNo
        {
            get { return tSRLineNo; }
            set { tSRLineNo = value; }
        }
        private string front;
        public string Front
        {
            get { return front; }
            set { front = value; }
        }
        private string back;
        public string Back
        {
            get { return back; }
            set { back = value; }
        }
        private string lFY;
        public string LFY
        {
            get { return lFY; }
            set { lFY = value; }
        }
        private string DevNoCmdCheck;
        public string devNoCmdCheck
        {
            get { return DevNoCmdCheck; }
            set { DevNoCmdCheck = value; }
        }
        private string DevNoCmdExe;
        public string devNoCmdExe
        {
            get { return DevNoCmdExe; }
            set { DevNoCmdExe = value; }
        }
        private string transparentDev;
        public string TransparentDev
        {
            get { return transparentDev; }
            set { transparentDev = value; }
        }
        private string bendPosition;
        public string BendPosition
        {
            get { return bendPosition; }
            set { bendPosition = value; }
        }
        private string switchNo;
        public string SwitchNo
        {
            get { return switchNo; }
            set { switchNo = value; }
        }
        private string backNormal;
        public string BackNormal
        {
            get { return backNormal; }
            set { backNormal = value; }
        }
        private string backReverse;
        public string BackReverse
        {
            get { return backReverse; }
            set { backReverse = value; }
        }
        private string Subtype;
        public string subtype
        {
            get { return Subtype; }
            set { Subtype = value; }
        }
        private string lineNo;
        public string LineNo
        {
            get { return lineNo; }
            set { lineNo = value; }
        }
        private string isComeBack;
        public string IsComeBack
        {
            get { return isComeBack; }
            set { isComeBack = value; }
        }

        // public static List<TrainWin> trainWins = new List<TrainWin>();   
        private IEnumerable<XElement> elementss;
        public void DevPropsLoad()
        {

            XElement xElement = XElement.Load(path);
            elementss = from el in xElement.Elements("Devs")
                        select el;
            XmlDocument doc = new XmlDocument();

            doc.Load(path);
            XmlNodeList Activity2Nodes = doc.SelectNodes("DevProps");
            PrintChildNodes(Activity2Nodes);
        }

        

        static void PrintChildNodes(XmlNodeList childnodelist)
        {
            Hashtable hashtable_DevProps = new Hashtable();
            try
            {
                foreach (XmlNode node in childnodelist)
                {
                    //(node.NodeType 是Text时，即是最内层 即innertext值，node.Attributes为null。
                    if (node.NodeType == XmlNodeType.Text)
                    {
                        Console.WriteLine("NodeType:" + node.NodeType + "\t" + node.Name + "\t:" + node.Value);
                        
                        //    List<string> Dev = new List<string>();
                        //    Dev.Add(node.Name);
                        //    Dev.Add(node.Value);
                        //if (node.Name=="name")
                        //{
                        //    string name =;
                        //}
                        //hashtable_DevProps.Add(node.Name, node.Value);



                        continue;
                    }
                    Console.WriteLine("==========node.Name:" + node.Name + "===========");
                    foreach (XmlAttribute atr in node.Attributes)
                    {
                        Console.WriteLine("NodeType:" + atr.NodeType + "\t" + atr.Name + "\t:" + atr.Value);
                        //hashtable_DevProps.Add(atr.Name, atr.Value);
                    }
                    if (node.ChildNodes.Count > 0)
                    {
                        PrintChildNodes(node.ChildNodes);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //public IEnumerable<XElement> Load( string devtype)
        //{

        //    DevPropsLoad(path);
        //        IEnumerable<XElement> elements = from el in elementss.Elements(devtype)
        //                                         select el;


        //    return elements;
        //}
    }
    //class TrainWin: DevProps
    //{
    //    public TrainWin()
    //    {
    //    }
    //    public  void  TrainWinLoad()
    //    {
    //        foreach (var ele in Load("TrainWin"))
    //        {
    //            TrainWin trainwin = new TrainWin();
    //            trainwin.id = ele.Attribute("id").Value;
    //            trainwin.name = ele.Attribute("name").Value;
    //            trainwin.Alias= ele.Attribute("Alias").Value;
    //            trainwin.RelatedDev= ele.Attribute("RelatedDev").Value;
    //            trainwin.ThroatType= ele.Attribute("ThroatType").Value;
    //            trainWins.Add(trainwin);
    //        }
    //    }
}





