using System;
using System.Collections.Generic;
using System.Text;
using FireScan;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;

namespace FireScanTests
{
    public class FireScanIOTests
    {
        [Test]
        public void TestThatProgramConvertsEventsToLiens()
        {
            string[] correctLines =
            {
                "Timestamp: 1577993764: Sub: actualidad, Votes: 163, Comments: 45, " +
                "News: El consejero de Vivienda de Madrid gastó 65.000 euros en colocar 21 " +
                "banderas de España cuando era alcalde de Alcorcon, Author: 82.47&hellip;, Status: publicada",

                "Timestamp: 1577993762: Sub: actualidad, Votes: 431, Comments: 59, News: La Comunidad de " +
                "Madrid deja sin gastar el 65% del presupuesto para reducir las " +
                "listas de espera, Author: 46.6&hellip;, Status: publicada"
            };

            List<Event> events = new List<Event>();
            events.Add(new Event("publicada", "actualidad", null, 1577993764, 163, 45, null,
                "El consejero de Vivienda de Madrid gastó 65.000 euros en colocar 21 banderas de España cuando era alcalde de Alcorcon", "82.47&hellip;", 0, 0, null));
            events.Add(new Event("publicada", "actualidad", null, 1577993762, 431, 59, null,
                "La Comunidad de Madrid deja sin gastar el 65% del presupuesto para reducir las listas de espera",
                "46.6&hellip;", 0, 0, null));

            WebData data = new WebData(null, 0,0, events);
            string[] lines = FireScanIO.WebDataToLines(data);
            Assert.AreEqual(correctLines, lines);
            
        }
    }
}
