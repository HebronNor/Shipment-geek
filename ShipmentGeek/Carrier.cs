using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipmentGeek
{
    class Carrier
    {
        public string Name { set; get; }
        public string TrackURL { set; get; }

        public static List<Carrier> List = new List<Carrier>
        {
            new Carrier
            {
                Name = "Norway Post", 
                TrackURL = @"http://sporing.posten.no/sporing.html?q={0}"
            },
            new Carrier
            {
                Name = "US Postal Service", 
                TrackURL = @"http://trkcnfrm1.smi.usps.com/PTSInternetWeb/InterLabelInquiry.do?strOrigTrackNum={0}"
            },
            new Carrier
            {
                Name = "FedEx", 
                TrackURL = @"http://www.fedex.com/Tracking?ascend_header=1&clienttype=dotcom&cntry_code=us&language=english&tracknumbers={0}"
            },
            new Carrier
            {
                Name = "UPS", 
                TrackURL = @"http://wwwapps.ups.com/WebTracking/processInputRequest?HTMLVersion=5.0&loc=en_US&Requester=UPSHome&tracknum={0}&AgreeToTermsAndConditions=yes&ignore=&track.x=35&track.y=9"
            },
            new Carrier
            {
                Name = "DHL", 
                TrackURL = @"http://www.dhl.com/content/g0/en/express/tracking.shtml?brand=DHL&AWB={0}%0D%0A"
            }
        };

        public static Comparison<Carrier> NameComparison = delegate(Carrier c1, Carrier c2) { return c1.Name.CompareTo(c2.Name); };
    }
}
