using IOCTest.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOCTest.Model
{
    public class TomorrowWriter : IDateWriter
    {
        private IOutput _output;

        public TomorrowWriter(IOutput output)
        {
            this._output = output;
        }

        public void WriteDate()
        {
            this._output.Write(DateTime.Now.AddDays(1).ToString());
        }
    }
}
