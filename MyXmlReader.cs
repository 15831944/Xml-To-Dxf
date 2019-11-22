using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Schema;
using netDxf;
namespace ParcelsConverter
{
    static class MyXmlReader
    {

        public static List<Spatial> spatials = new List<Spatial>(); //Спарсеные участки
        private static string cadastralNumber;

        public static string CadastralNumber { get => cadastralNumber; private set => cadastralNumber = value; }

        public static void Start(string path)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US"); //Разделитель дробной части .

            XmlTextReader xtr = new XmlTextReader(path);

            while (xtr.Read())
            {
                if(xtr.Name == "Parcel")
                {
                    if(CadastralNumber == null)
                    CadastralNumber = xtr.GetAttribute("CadastralNumber");
                }
                if(xtr.Name == "spa:SpatialElement")
                {
                    var tempSpat = new Spatial();
                    while (xtr.Read())
                    {
                        if(xtr.Name == "spa:Ordinate")
                        {
                            var tempVector = new Vector2(Double.Parse(xtr.GetAttribute("Y")), Double.Parse(xtr.GetAttribute("X")));
                            tempSpat.Points.Add(tempVector);
                        }

                        if (xtr.Name == "spa:SpatialElement")
                        {
                            spatials.Add(tempSpat);
                            break; 
                        }
                    }
                }
                //В будущем сделать определение зон - отдельно
            }
        }
    }
}
