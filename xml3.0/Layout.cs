using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace xml3._0
{
    class Layout
    {
        string path = @"C:\Users\ShenBY\Desktop\乌将线CTC\Data-土墩子\土墩子\Station_TDZ\LayOut反.xml";
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
        public static List<TrainWin> Layout_trainWins = new List<TrainWin>();
        private IEnumerable<XElement> elementss;
        public IEnumerable LayoutLoad()
        {
            XElement xElement = XElement.Load(path);
            IEnumerable<XElement> elementss1 = from el in xElement.Elements("DeviceType")
                                              select el;
            elementss = from el in elementss1.Elements("DeviceInfo")
                        select el;
            return elementss;
        }

        public IEnumerable<XElement> Load(string devtype)
        {
            LayoutLoad();
            elementss.Attributes();
            IEnumerable<XElement> elements = from el in elementss.Elements(devtype) 
                                             select el;
            return elements;
        }
        public void Load()
        {
            Layout_TrainWin trainWin = new Layout_TrainWin();
            trainWin.TrainWinLoad();
            Track track = new Track();
            track.TrackLoad();
        }
    }
    class Layout_TrainWin : Layout
    {
        public void TrainWinLoad()
        {
            foreach (var ele in Load("Device"))
            {
                TrainWin trainwin = new TrainWin();
                trainwin.id = ele.Attribute("id").Value;
                trainwin.name = ele.Attribute("Name").Value;
                trainwin.Alias = ele.Attribute("Alias").Value;
                Layout_trainWins.Add(trainwin);
            }
        }
    }

}
