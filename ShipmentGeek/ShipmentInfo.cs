using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Linq.Expressions;

namespace ShipmentGeek
{
    public class ShipmentInfo
    {
        public int ID { set; get; }
        public bool Incomming { set; get; }
        public bool Outgoing { set; get; }
        public string Name { set; get; }
        public DateTime Date { set; get; }
        public string Comment { set; get; }
        public bool Received { set; get; }
        public bool Missing { set; get; }

        public List<ShipmentItem> Items = new List<ShipmentItem>();

        public struct Test
        {
            public string Text { set; get; }
        }

        [XmlArray]
        public static List<ShipmentInfo> List = new List<ShipmentInfo>();

        [XmlIgnore]
        public static int GetID 
        { 
            get 
            {
                if (List.Count > 0) return List.Max(f => f.ID) + 1;
                else return 1;
            } 
        }

        [XmlIgnore]
        public static Comparison<ShipmentInfo> IdComparison = delegate(ShipmentInfo s1, ShipmentInfo s2) { return s2.ID.CompareTo(s1.ID); };

        [XmlIgnore]
        public static Comparison<ShipmentInfo> NameComparison = delegate(ShipmentInfo s1, ShipmentInfo s2) { return s1.Name.CompareTo(s2.Name); };

        [XmlIgnore]
        public static Comparison<ShipmentInfo> DateComparison = delegate(ShipmentInfo s1, ShipmentInfo s2) { return s1.Date.CompareTo(s2.Date); };

        [XmlIgnore]
        public static Comparison<ShipmentInfo> ItemComparison = delegate(ShipmentInfo s1, ShipmentInfo s2) { return s2.Items.Sum(f => f.Count).CompareTo(s1.Items.Sum(f => f.Count)); };
    }

    public class ShipmentItem
    {
        public int ID { set; get; }
        public string Text { set; get; }
        public int Count { set; get; }

        [XmlIgnore]
        public static Comparison<ShipmentItem> CountComparison = delegate(ShipmentItem s1, ShipmentItem s2) { return s2.Count.CompareTo(s1.Count); };

        [XmlIgnore]
        public static Comparison<ShipmentItem> TextComparison = delegate(ShipmentItem s1, ShipmentItem s2) { return s1.Text.CompareTo(s2.Text); };
    }
}
