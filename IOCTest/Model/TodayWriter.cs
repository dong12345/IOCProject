using IOCTest.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOCTest.Model
{
    public class TodayWriter : IDateWriter
    {
        private IOutput _output;
        public void WriteDate()
        {
            this._output.Write(DateTime.Now.ToString());
        }

        public TodayWriter(IOutput output)
        {
            this._output = output;
        }

    }
}
