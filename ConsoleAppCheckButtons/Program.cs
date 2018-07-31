using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


    class Program
    {


    static IWebDriver driver = new ChromeDriver();
    static IWebElement checkButton;

        static void Main()
        {

        string url = "http://testing.todvachev.com/special-elements/check-button-test-3/";
        string option = "1";
     

        driver.Navigate().GoToUrl(url);

        //El único número que cambia es e 1, para esto vamos a crear la siguiente variable option
        checkButton = driver.FindElement(By.CssSelector("#post-33 > div > p:nth-child(8) > input[type=\"checkbox\"]:nth-child("+option+")"));


        //seleccionar el checkbutton 1
        checkButton.Click();
        Thread.Sleep(5000);


       // Console.WriteLine(checkButton.GetAttribute("value"));



        //ESCENARIO 1: 
        //Identificar que campo esta checked


        /* if (checkButton.GetAttribute("checked")== "true"){

             Console.WriteLine("The checkbox is checked");

         }
         else
         {
             Console.WriteLine("The checkbok is not checked");
         }*/


        //ESCENARIO 2: 

        /*option = "3";
      checkButton = driver.FindElement(By.CssSelector("#post-33 > div > p:nth-child(8) > input[type=\"checkbox\"]:nth-child("+option+")"));
      Console.WriteLine(checkButton.GetAttribute("value"));*/

        driver.Quit();

        }
    }

