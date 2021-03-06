﻿using Joyride.Extensions;
using Joyride.Platforms;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Tests.Android.Native.SampleApp.ApiDemo.Screens.App
{
    public class AlertDialogsScreen : ApiDemoScreen
    {
        [FindsBy(How = How.Id, Using = "io.appium.android.apis:id/two_buttons")]
        private IWebElement OkCancelDialog;

        [FindsBy(How = How.Id, Using = "io.appium.android.apis:id/two_buttons2")]
        private IWebElement OkCancelDialogWithLongMessage ;
        
        public override bool IsOnScreen(int timeOutSecs)
        {
            var xpath = @"//android.widget.TextView[@text='App/Alert Dialogs']";
            var header = Driver.FindElement(By.XPath(xpath), timeOutSecs);
            return header != null;
        }

        public override string Name
        {
            get { return "Alert Dialogs"; }
        }

        public override Screen GoBack()
        {
            Driver.Navigate().Back();
            return ScreenFactory.CreateScreen<AppScreen>();
        }
    }
}
