﻿using System;
using System.IO.MemoryMappedFiles;
using System.Text;
using System.Threading;
using System.Xml;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using OpenHardwareMonitor;
using OpenHardwareMonitor.Hardware;

namespace NingMonitorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //AIDA64.Start();
        }

        [TestMethod]
        public void TestMethod2()
        {
            UpdateVisitor updateVisitor = new UpdateVisitor();
            Computer computer = new Computer();
            computer.CPUEnabled = true;
            computer.FanControllerEnabled = true;
            computer.GPUEnabled = true;
            computer.HDDEnabled = true;
            computer.MainboardEnabled = true;
            computer.RAMEnabled = true;
            computer.Open();
            computer.Accept(updateVisitor);


        }

        [TestMethod]
        public void OHMTest()
        {
            //OHM.Start(); Thread.Sleep(2000);
            //var test =JsonConvert.SerializeObject(PerformanceParams.AllItems);
            

        }
    }
    public class UpdateVisitor : IVisitor
    {
        public void VisitComputer(IComputer computer)
        {
            computer.Traverse(this);
        }

        public void VisitHardware(IHardware hardware)
        {
            hardware.Update();
            foreach (IHardware subHardware in hardware.SubHardware)
                subHardware.Accept(this);
        }

        public void VisitSensor(ISensor sensor) { }

        public void VisitParameter(IParameter parameter) { }
    }
}
