using System;
using System.IO;
namespace Serialization_Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Serialization");
            #region csv format
            /* Data csv format
            FistName,            LastName,       Age
            FirstName0,           LastName0,        25
            FirstName1,           LastName1,        21
            FirstName2,           LastName2,        25
            FirstName3,           LastName3,        25
            FirstName4,           LastName4,        22
            FirstName5,           LastName5,        23
            FirstName6,           LastName6,        24
            FirstName7,           LastName7,        22
            FirstName8,           LastName8,        28
            FirstName9,           LastName9,        23
            FirstName10,          LastName10,        27
            FirstName11,          LastName11,        29
            FirstName12,          LastName12,        27
            FirstName13,          LastName13,        24
            FirstName14,          LastName14,        29
            FirstName15,          LastName15,        20
            FirstName16,          LastName16,        26
            FirstName17,          LastName17,        27
            FirstName18,          LastName18,        28
            FirstName19,          LastName19,        21
             */
            #endregion

            #region xml format
            /*<?xml version="1.0" encoding="UTF-8"?>
              <breakfast_menu>
              <food>
              <name>Belgian Waffles</name>
              <price>$5.95</price>
              <description>
              Two of our famous Belgian Waffles with plenty of real maple syrup
              </description>
              <calories>650</calories>
              </food>
              <food>
              <name>Strawberry Belgian Waffles</name>
              <price>$7.95</price>
              <description>
              Light Belgian waffles covered with strawberries and whipped cream
              </description>
              <calories>900</calories>
              </food>
              <food>
              <name>Berry-Berry Belgian Waffles</name>
              <price>$8.95</price>
              <description>
              Belgian waffles covered with assorted fresh berries and whipped cream
              </description>
              <calories>900</calories>
              </food>
              <food>
              <name>French Toast</name>
              <price>$4.50</price>
              <description>
              Thick slices made from our homemade sourdough bread
              </description>
              <calories>600</calories>
              </food>
              <food>
              <name>Homestyle Breakfast</name>
              <price>$6.95</price>
              <description>
              Two eggs, bacon or sausage, toast, and our ever-popular hash browns
              </description>
              <calories>950</calories>
              </food>
              </breakfast_menu>*/
            #endregion

            #region json format
            /*
               {
                   "web-app": {
                       "servlet": [
                         {
                           "servlet-name": "cofaxCDS",
            "servlet-class": "org.cofax.cds.CDSServlet",
            "init-param": {
                               "configGlossary:installationAt": "Philadelphia, PA",
            "configGlossary:adminEmail": "ksm@pobox.com",
            "configGlossary:poweredBy": "Cofax",
            "configGlossary:poweredByIcon": "/images/cofax.gif",
            "configGlossary:staticPath": "/content/static",
            "templateProcessorClass": "org.cofax.WysiwygTemplate",
            "templateLoaderClass": "org.cofax.FilesTemplateLoader",
            "templatePath": "templates",
            "templateOverridePath": "",
            "defaultListTemplate": "listTemplate.htm",
            "defaultFileTemplate": "articleTemplate.htm",
            "useJSP": false,
            "jspListTemplate": "listTemplate.jsp",
            "jspFileTemplate": "articleTemplate.jsp",
            "cachePackageTagsTrack": 200,
            "cachePackageTagsStore": 200,
            "cachePackageTagsRefresh": 60,
            "cacheTemplatesTrack": 100,
            "cacheTemplatesStore": 50,
            "cacheTemplatesRefresh": 15,
            "cachePagesTrack": 200,
            "cachePagesStore": 100,
            "cachePagesRefresh": 10,
            "cachePagesDirtyRead": 10,
            "searchEngineListTemplate": "forSearchEnginesList.htm",
            "searchEngineFileTemplate": "forSearchEngines.htm",
            "searchEngineRobotsDb": "WEB-INF/robots.db",
            "useDataStore": true,
            "dataStoreClass": "org.cofax.SqlDataStore",
            "redirectionClass": "org.cofax.SqlRedirection",
            "dataStoreName": "cofax",
            "dataStoreDriver": "com.microsoft.jdbc.sqlserver.SQLServerDriver",
            "dataStoreUrl": "jdbc:microsoft:sqlserver://LOCALHOST:1433;DatabaseName=goon",
            "dataStoreUser": "sa",
            "dataStorePassword": "dataStoreTestQuery",
            "dataStoreTestQuery": "SET NOCOUNT ON;select test='test';",
            "dataStoreLogFile": "/usr/local/tomcat/logs/datastore.log",
            "dataStoreInitConns": 10,
            "dataStoreMaxConns": 100,
            "dataStoreConnUsageLimit": 100,
            "dataStoreLogLevel": "debug",
            "maxUrlLength": 500}
                       },
            {
                           "servlet-name": "cofaxEmail",
            "servlet-class": "org.cofax.cds.EmailServlet",
            "init-param": {
                               "mailHost": "mail1",
            "mailHostOverride": "mail2"}
                       },
            {
                           "servlet-name": "cofaxAdmin",
            "servlet-class": "org.cofax.cds.AdminServlet"},

            {
                           "servlet-name": "fileServlet",
            "servlet-class": "org.cofax.cds.FileServlet"},
            {
                           "servlet-name": "cofaxTools",
            "servlet-class": "org.cofax.cms.CofaxToolsServlet",
            "init-param": {
                               "templatePath": "toolstemplates/",
            "log": 1,
            "logLocation": "/usr/local/tomcat/logs/CofaxTools.log",
            "logMaxSize": "",
            "dataLog": 1,
            "dataLogLocation": "/usr/local/tomcat/logs/dataLog.log",
            "dataLogMaxSize": "",
            "removePageCache": "/content/admin/remove?cache=pages&id=",
            "removeTemplateCache": "/content/admin/remove?cache=templates&id=",
            "fileTransferFolder": "/usr/local/tomcat/webapps/content/fileTransferFolder",
            "lookInContext": 1,
            "adminGroupID": 4,
            "betaServer": true}
                       }],
            "servlet-mapping": {
                           "cofaxCDS": "/",
            "cofaxEmail": "/cofaxutil/aemail/*",
            "cofaxAdmin": "/admin/*",
            "fileServlet": "/static/*",
            "cofaxTools": "/tools/*"},

            "taglib": {
                           "taglib-uri": "cofax.tld",
            "taglib-location": "/WEB-INF/tlds/cofax.tld"}
                   }
               }

            }
            }
            }

            */
            #endregion
        }
    }
}