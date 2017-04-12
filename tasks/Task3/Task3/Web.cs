using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;


namespace Task3
{

    public class Web
    {
        public static void GetValue()
        {
        var webclient = new System.Net.WebClient();
        var url = "http://finance.yahoo.com/d/quotes.csv?s=TSLA&f=snbaopl1";
       
        var text = webclient.DownloadString(url);
        //Console.WriteLine(text);

            var parts = text.Split(',');
            var value = decimal.Parse(parts[7], CultureInfo.InvariantCulture);
            Console.WriteLine(value);
        }

    }

}
