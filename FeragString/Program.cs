// See https://aka.ms/new-console-template for more information
using feragstring;

// create a FERAG string object
var fs = new FeragString();
fs.SetTitleName("DEMO2009");

// set title parameters
fs.TitleInfo.PrintObjectName = "EDITION1A";
fs.TitleInfo.PublicationDate = "2022-10-29";
fs.TitleInfo.CountryCode = "13";
fs.TitleInfo.PrintObjectColor = "03368448";

// add a product

// add a route

string feragString = fs.PrintOut();
Console.WriteLine(feragString);
