using WebService_Challenge;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebService_Challenge.Tests
{
    [TestClass]
    public class UnitTest1
    {

        private const double expectedF2 = 1;
        private const double expectedF3 = 2;
        private const double expectedF4 = 3;
        private const double expectedF5 = 5;
        private const double expectedF6 = 8;
        private const double expectedF0 = -1;
        private const double expectedFneg = -1;
        private const double expectedF1000 = -1;

        [TestMethod]
        public void Shoud_return_1_when_N_isEqual_1()
        {
            int n = 1;
            double expected = 1;
          
            MyWebService ws = new MyWebService();

            double res = ws.Fibonacci(n);

            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void Shoud_return_1_when_N_isEqual_2()
        {
            int n = 2;
            double expected = 1;

            MyWebService ws = new MyWebService();

            double res = ws.Fibonacci(n);

            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void Shoud_return_2_when_N_isEqual_3()
        {
            int n = 3;
            double expected = 2;

            MyWebService ws = new MyWebService();

            double res = ws.Fibonacci(n);

            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void Shoud_return_3_when_N_isEqual_4()
        {
            int n = 4;
            double expected = 3;

            MyWebService ws = new MyWebService();

            double res = ws.Fibonacci(n);

            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void Shoud_return_5_when_N_isEqual_5()
        {
            int n = 5;
            double expected = 5;

            MyWebService ws = new MyWebService();

            double res = ws.Fibonacci(n);

            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void Shoud_return_8_when_N_isEqual_6()
        {
            int n = 5;
            double expected = 5;

            MyWebService ws = new MyWebService();

            double res = ws.Fibonacci(n);

            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void Shoud_return_minus1_when_N_isEqual_0()
        {
            int n = 0;
            double expected = -1;

            MyWebService ws = new MyWebService();

            double res = ws.Fibonacci(n);

            Assert.AreEqual(expected, res);
        }


        [TestMethod]
        public void Shoud_return_minus1_when_N_isEqual_101()
        {
            int n = 101;
            double expected = -1;

            MyWebService ws = new MyWebService();

            double res = ws.Fibonacci(n);

            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void Shoud_return_minus1_when_N_isEqual_minus101()
        {
            int n = -101;
            double expected = -1;

            MyWebService ws = new MyWebService();

            double res = ws.Fibonacci(n);

            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void Shoud_return_simpleJson()
        {
            string xml = @"<foo>bar</foo>";
            string expected = "{\"foo\":\"bar\"}";

            MyWebService ws = new MyWebService();

            string json = ws.XmlToJson(xml, false);

            Assert.AreEqual(expected, json);
        }


        [TestMethod]
        public void Shoud_return_Bad_Xml_formatL()
        {
            string xml = "<foo>hello</bar>";
            string expected = "Bad Xml format";

            MyWebService ws = new MyWebService();

            string json = ws.XmlToJson(xml, false);

            Assert.AreEqual(expected, json);
        }


        [TestMethod]
        public void Shoud_return_complexJson()
        {
            string xml = "<TRANS><HPAY><ID>103</ID><STATUS>3</STATUS><EXTRA><IS3DS>0</IS3DS><AUTH>031183</AUTH></EXTRA><INT_MSG/><MLABEL>501767XXXXXX6700</MLABEL><MTOKEN>project01</MTOKEN></HPAY></TRANS>";
            string expected = "{\"TRANS\":{\"HPAY\":{\"ID\":\"103\",\"STATUS\":\"3\",\"EXTRA\":{\"IS3DS\":\"0\",\"AUTH\":\"031183\"},\"INT_MSG\":null,\"MLABEL\":\"501767XXXXXX6700\",\"MTOKEN\":\"project01\"}}}";

            MyWebService ws = new MyWebService();

            string json = ws.XmlToJson(xml, false);

            Assert.AreEqual(expected, json);
        }

    }
}
