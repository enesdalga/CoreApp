using System;
using CoreApp.Web.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace CoreApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
             var controller = new HomeController();
            Assert.IsType<Int32>(controller.Index());
        }
    }
}
