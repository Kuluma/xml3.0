
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
        string path = @"C:\Users\ShenBY\Desktop\乌将线CTC\Data-土墩子\土墩子\Station_TDZ\DevProps.xml";
        //string path = @"C:\Users\ShenBY\Desktop\乌将线CTC\Data-北三台+沙地\北三台\Station_BST\LayOut反.xml";
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

        public static List<TrainWin> trainWins = new List<TrainWin>();
        public static List<Track> tracks = new List<Track>();
        private IEnumerable<XElement> elementss;
        private List<XElement> elementsss = new List<XElement>();
        public IEnumerable DevPropsLoad()
        {
            XElement xElement = XElement.Load(path);
            elementss = from el in xElement.Elements("Devs")
                        select el;
            return elementss;
        }

        public IEnumerable<XElement> Load(string devtype)
        {
            DevPropsLoad();
            IEnumerable<XElement> elements = from el in elementss.Elements(devtype)
                                             select el;
            return elements;
        }
        public void Load()
        {
            TrainWin trainWin = new TrainWin();
            trainWin.TrainWinLoad();
            Track track = new Track();
            track.TrackLoad();
        }
    }
    class TrainWin : DevProps
    {
        public void TrainWinLoad()
        {
            foreach (var ele in Load("TrainWin"))
            {
                TrainWin trainwin = new TrainWin();
                trainwin.id = ele.Attribute("id").Value;
                trainwin.name = ele.Attribute("name").Value;
                trainwin.Alias = ele.Attribute("Alias").Value;
                trainwin.RelatedDev = ele.Attribute("RelatedDev").Value;
                trainwin.ThroatType = ele.Attribute("ThroatType").Value;
                trainWins.Add(trainwin);
            }
        }
    }
    class Track : DevProps
    {
        public void TrackLoad()
        {
            foreach (var ele in Load("Track"))
            {
                Track track = new Track();
                track.id = ele.Attribute("id").Value;
                track.name = ele.Attribute("name").Value;
                track.Alias = ele.Attribute("Alias").Value;
                track.FieldNo = ele.Attribute("FieldNo").Value;
                track.TSRLineNo = ele.Attribute("TSRLineNo").Value;
                track.ThroatType = ele.Attribute("ThroatType").Value;
                track.Front = ele.Attribute("Front").Value;
                track.Back  = ele.Attribute("Back").Value;
                track.LFY  = ele.Attribute("LFY").Value;
                track.devNoCmdCheck  = ele.Attribute("devNoCmdCheck").Value;
                track.devNoCmdExe  = ele.Attribute("devNoCmdExe").Value;
                tracks.Add(track);
            }
        }
    }
}





