using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;


namespace Momondo
{
    [TestFixture]
    public class UnitTest
    {

        [TestCase]
        public void CheckifOriginTextBoxExists()
        {
            CheckIfTextFieldExists originTextbox = new CheckIfTextFieldExists();
            originTextbox.url = "https://www.momondo.co.uk/";
            originTextbox.name = "origin";

            bool result = originTextbox.checkIfTextFieldExists();

            Assert.That(result == true);

        }

        [TestCase]
        public void CheckifDestinationTextBoxExists()
        {
            CheckIfTextFieldExists destinationTextbox = new CheckIfTextFieldExists();
            destinationTextbox.url = "https://www.momondo.co.uk/";
            destinationTextbox.name = "destination";

            bool result = destinationTextbox.checkIfTextFieldExists();

            Assert.That(result == true);

        }


        [TestCase]
        public void CheckifDatePickerExists()
        {


            CheckIfDatePickerExists datePicker = new CheckIfDatePickerExists();
            datePicker.url = "https://www.momondo.co.uk/";
            datePicker.xPath = "//*[contains(@id, '-depart-input')]";

            bool result = datePicker.checkIfDatePickerExists();

            Assert.That(result == true);
            
        }



    }



}






