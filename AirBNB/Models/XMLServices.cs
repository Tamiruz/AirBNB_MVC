using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;
using System.Xml.XPath;

namespace WebApplication2.Models
{
    public class XMLServices
    {

        // ****************** Read an RSS file ***************************/
        public List<string> ReadRss() {

            //  Using a live RSS feed.
            string RSSFileName = "https://weather-broker-cdn.api.bbci.co.uk/en/forecast/rss/3day/2759794";

            // find all the titles and descriptions of weather in the items
            String xpath = "//item//description | //title";

            try
            {
                List<string> list = ReadXMLField(RSSFileName, xpath);
                return list;
            }
            catch (Exception ex) {
                throw new Exception("faild to read the XML file, The error is " + ex.Message);
            }
            
        }

        // ***** returns a list of a specific field within a given XML file *******/
        public List<string> ReadXMLField (string xmlFile, string xpath) {

            List<string> list = new List<string>();

            // This is the class you want to work with when using Xpath
            XPathDocument doc = new XPathDocument(xmlFile);

            // Create a navigator
            XPathNavigator nav = doc.CreateNavigator();

            foreach (XPathNavigator node in nav.Select(xpath))
            {
                list.Add(node.Value);
            }

            return list;
        }

    }
}



