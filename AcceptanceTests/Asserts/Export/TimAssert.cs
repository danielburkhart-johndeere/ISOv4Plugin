using System.Collections.Generic;
using System.Linq;
using AgGateway.ADAPT.ApplicationDataModel.Common;
using AgGateway.ADAPT.ISOv4Plugin.Models;
using NUnit.Framework;

namespace AcceptanceTests.Asserts.Export
{
    public class TimAssert
    {
        public static void AreEqual(List<TimeScope> timescopes, List<TIM> tims)
        {
            for (var i = 0; i < timescopes.Count(); i++)
            {
                AreEqual(timescopes[i], tims[i]);
            }
        }

        private static void AreEqual(TimeScope timeScope, TIM tim)
        {
            Assert.AreEqual(timeScope.TimeStamp1, tim.A);
            Assert.AreEqual(timeScope.TimeStamp2, tim.B);

            // todo.  check other attributes and PTN, dlvs,....
        }
    }
}