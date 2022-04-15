using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Xml;
using HtmlAgilityPack;
using System.Text.RegularExpressions;

namespace 作业7_1
{
    class Program
    {
        static void Main()
        {
            GetHtmlAsync();
            Console.ReadLine();
        }

        private static async void GetHtmlAsync()
        {
            var url = "https://www.ebay.com/sch/i.html?_from=R40&_trksid=p2334524.m570.l1313&_nkw=xbox&_sacat=0&LH_TitleDesc=0&_odkw=graphic+card&_osacat=0";

            var httpClient = new HttpClient();
            var html = await httpClient.GetStringAsync(url);

            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(html);

            var ProductHtml = htmlDocument.DocumentNode.Descendants("ul")
                .Where(node => node.GetAttributeValue("id", "")
                .Equals("ListViewInner")).ToList();

            var ProductListItems = htmlDocument.DocumentNode.Descendants("li")
               .Where(node => node.GetAttributeValue("id", "")
               .Equals("item")).ToList();

            foreach (var ProductListItem in ProductListItems)
            {
                //id
                Console.WriteLine(ProductListItem.GetAttributeValue("listingid", ""));

                //Product
                Console.WriteLine(ProductListItem.Descendants("h3")
                        .Where(node => node.GetAttributeValue("class", "")
                        .Equals("lvtitle")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t')
                        );
                //price
                Console.WriteLine(
                    Regex.Match(ProductListItem.Descendants("li")
                    .Where(node => node.GetAttributeValue("class", "")
                    .Equals("lvprice prc")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t')
                    , @"\d +.\d+")
                    );

                //url
                Console.WriteLine(
                    ProductListItem.Descendants("a").FirstOrDefault().GetAttributeValue("href", "")
                    );

                Console.WriteLine();
            }


        }
    }
}
