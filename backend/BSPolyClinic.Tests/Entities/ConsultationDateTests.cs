using BSPolyClinic.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace BSPolyClinic.Tests.Entities
{
    [TestClass]
    public class ConsultationDateTests
    {
        
        private Consultation _consultation;
        private ConsultationDate _consultationDate;


        public ConsultationDateTests()
        {
            _consultation = new Consultation(Guid.NewGuid(), Guid.NewGuid(), true);
            _consultationDate = new ConsultationDate(_consultation.Id, _consultation.HealthCenterId, DateTime.Now.AddDays(5), "10:30");
        }

        [TestMethod]
        public void CreateConsultation()
        {

            Assert.AreEqual(true, _consultationDate.IsValid);
        }
    }
}
