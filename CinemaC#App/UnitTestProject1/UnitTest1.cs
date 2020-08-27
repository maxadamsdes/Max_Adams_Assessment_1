using NUnit;
using NUnit.Framework;



namespace CinemaCSharpApp
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase]
        public void Adult_Before_5_Test()
        {
            var adult_before_5 = Form.getAdultTicketPrice(3, false, true, true);
            Assert.AreEqual(46.5, adult_before_5);
        }

        [TestCase]
        public void Adult_After_5_Test()
        {
            var adult_after_5 = Form.getAdultTicketPrice(3, false, false, true);
            Assert.AreEqual(55.5, adult_after_5);
        }

        [TestCase]
        public void Adult_Tuesday_Test()
        {
            var adult_tuesday = Form.getAdultTicketPrice(3, true, false, true);
            Assert.AreEqual(46.5, adult_tuesday);
        }

        [TestCase]
        public void Child_Under_16_Test()
        {
            var child = Form.getChildrenTicketPrice(3, true);
            Assert.AreEqual(40.5, child);
        }

        [TestCase]
        public void Senior_Test()
        {
            var senior = Form.getSeniorTicketPrice(3, true);
            Assert.AreEqual(42, senior);
        }

        [TestCase]
        public void Student_Test()
        {
            var student = Form.getStudentTicketPrice(3, true);
            Assert.AreEqual(46.5, student);
        }

        [TestCase]
        public void Family_Pass_Test()
        {
            var familyPass = Form.getFamilyPassPrice(2, 2, true);
            Assert.AreEqual(53, familyPass);
        }

        [TestCase]
        public void Chick_Flick_Thursday_Test()
        {
            var chickFlick = Form.getChickFlickPrice(3);
            Assert.AreEqual(64.5, chickFlick);
        }

        [TestCase]
        public void Kids_Carers_Test()
        {
            var kidsCarers = Form.getKidsCarersPrice(3, "wednesday", false);
            Assert.AreEqual(36, kidsCarers);
        }



    }
}