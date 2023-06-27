using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweetshop
{
    class FirmsSettings
    {

        public string firmName { get; set; }

        public string txtFirm { get; set; }

        public string firmCity { get; set; }

        public FirmsSettings(string firmName, string txtFirm, string firmCity)
        {
            this.firmName = firmName;
            this.txtFirm = txtFirm;
            this.firmCity = firmCity;
        }
    }
}
