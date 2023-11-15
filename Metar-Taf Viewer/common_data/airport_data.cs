using System.Xml;

namespace Metar_Taf_Viewer.common_data
{
    class airport_data
    {

        public static string GetAirportInfo(string airport_name)
        {
            string reply = "Unknown";

            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("airport_data.xml");

                XmlNodeList nodeList;
                XmlNode root = doc.DocumentElement;

                nodeList = root.SelectNodes("descendant::airport_info[airport_name ='" + airport_name + "']");


                foreach (XmlNode data in nodeList)
                {
                    reply = data["icao_code"].InnerText;
                }
            }
            catch
            {
                reply = "Check the airport name is correct";
            }


            return reply;
        }


    }
}
