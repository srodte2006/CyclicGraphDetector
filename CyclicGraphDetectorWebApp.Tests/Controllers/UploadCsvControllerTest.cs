﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CyclicGraphDetectorWebApp;
using CyclicGraphDetectorWebApp.Controllers;
using CyclicGraphDetectorBusinessLayer;
using Moq;

namespace CyclicGraphDetectorWebApp.Tests.Controllers
{
    [TestClass]
    public class UploadCsvControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            var mockCsvUploadManager = new Mock<ICsvUploadManager>().Object;
            UploadCsvController controller =new UploadCsvController(mockCsvUploadManager);

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            var mockCsvUploadManager = new Mock<ICsvUploadManager>().Object;
            UploadCsvController controller = new UploadCsvController(mockCsvUploadManager);

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            var mockCsvUploadManager = new Mock<ICsvUploadManager>().Object;
            UploadCsvController controller = new UploadCsvController(mockCsvUploadManager);
            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
