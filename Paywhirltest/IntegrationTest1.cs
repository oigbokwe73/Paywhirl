using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PayWhirlApi.Interface;
using System.Collections.Specialized;
using System.Data.Linq;
using System.Collections.Generic;


namespace PaywhirlTest
{

    //Look at the documentation to build the name/value information.
    //https://www.paywhirl.com/api/reference
    [TestClass]
    public class IntegrationTest1
    {
        private string api_key = "PW2BF7D8BBE8A19F4050D0DABCA606F1DE";
        private string api_secret = "PWSCD22C30BC10BB0FED41D44C30ED29370D";
        NameValueCollection nv = new NameValueCollection();

        [TestMethod]
        public void Get_All_Plans()
        {
            PayWhirlBC payWhirlBC = new PayWhirlBC(api_key, api_secret);
            var response = payWhirlBC.GetPlans();

        }
        [TestMethod]
        public void Get_Plan()
        {
            PayWhirlBC payWhirlBC = new PayWhirlBC(api_key, api_secret,true);
            nv.Add("id", "24369");
            var response = payWhirlBC.GetPlan(nv);
        }
        [TestMethod]
        public void Get_Current_User()
        {
            PayWhirlBC payWhirlBC = new PayWhirlBC(api_key, api_secret);
            var response = payWhirlBC.CurrentUser();

        }
        [TestMethod]
        public void Get_All_Subcriber()
        {
            PayWhirlBC payWhirlBC = new PayWhirlBC(api_key, api_secret);
            var response = payWhirlBC.GetSubcribers();

        }
        [TestMethod]
        public void GetSubcriber()
        {
            PayWhirlBC payWhirlBC = new PayWhirlBC(api_key, api_secret);
            nv.Add("id", "56926");
            nv.Add("email", "obinna.igbokwe@platformbasedsolutions.com");
            var response = payWhirlBC.GetSubcriber(nv);
        }
        [TestMethod]
        public void Create_Subscriber()
        {
            PayWhirlBC payWhirlBC = new PayWhirlBC(api_key, api_secret);
            nv.Add("email","obinna.igbokwe@platformbasedsolutions.com");
            var response = payWhirlBC.CreateSubcriber(nv);
        }
        [TestMethod]
        public void Update_Subscriber()
        {
            PayWhirlBC payWhirlBC = new PayWhirlBC(api_key, api_secret,true);
            var response1 = payWhirlBC.GetSubcribers().FindAll(x=> x.Email.Equals("obinna.igbokwe@platformbasedsolutions.com"));
            if (response1 != null)
            {
                nv.Add("id", response1[0].Id);
                nv.Add("password", "Password@1");
                var response = payWhirlBC.UpdateSubcriber(nv);
            }
        }
        [TestMethod]
        public void Update_Plan()
        {
            PayWhirlBC payWhirlBC = new PayWhirlBC(api_key, api_secret, true);
            var response1 = payWhirlBC.GetPlans().FindAll(x => x.Id.Equals("24376"));
            if (response1 != null)
            {
                nv.Add("id", response1[0].Id);
                nv.Add("name", "Admin Package");
                nv.Add("feature_1", "Sell Register");
                var response = payWhirlBC.UpdatePlan(nv);
            }
        }
    }
}
