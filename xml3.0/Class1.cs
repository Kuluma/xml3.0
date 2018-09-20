using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xml3._0
{
    class Class1
    {
        //XmlDocument doc = new XmlDocument();

        //doc.Load(path);
        //XmlNodeList Activity2Nodes = doc.SelectNodes("DevProps");

        // XmlNodeList Activity2Nodes = doc.SelectNodes("StationLayout");
        //PrintChildNodes(Activity2Nodes);

        //static void PrintChildNodes(XmlNodeList childnodelist)
        //{
        //    Hashtable hashtable_DevProps = new Hashtable();
        //    try
        //    {
        //        foreach (XmlNode node in childnodelist)
        //        {
        //            (node.NodeType 是Text时，即是最内层 即innertext值，node.Attributes为null。
        //            int a = node.ChildNodes.Count;
        //            Console.WriteLine("节点数:" + a);
        //            Console.WriteLine("node.InnerText:" + node.InnerText);
        //            if (node.NodeType == XmlNodeType.Text)
        //            {
        //                Console.WriteLine("NodeType:" + node.NodeType + "\t" + node.Name + "\t:" + node.Value);
        //                Console.WriteLine("214124214124124124124521641278392104");
        //                node.SelectSingleNode("name");
        //                List<string> Dev = new List<string>();
        //                Dev.Add(node.Name);
        //                Dev.Add(node.Value);
        //                if (node.Name == "name")
        //                {
        //                    string name =;
        //                }
        //                hashtable_DevProps.Add(node.Name, node.Value);



        //                continue;
        //            }
        //            Console.WriteLine("==========node.Name:" + node.Name + "===========");

        //            foreach (XmlAttribute atr in node.Attributes)
        //            {
        //                Console.WriteLine("NodeType:" + atr.NodeType + "\t" + atr.Name + "\t:" + atr.Value);
        //                Console.WriteLine(atr.InnerText);
        //                hashtable_DevProps.Add(atr.Name, atr.Value);
        //                List<string> Dev = new List<string>();
        //            }

        //            if (node.ChildNodes.Count > 0)
        //            {
        //                PrintChildNodes(node.ChildNodes);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //}
    }
}
