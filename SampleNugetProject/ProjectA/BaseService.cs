using ProjectB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA
{
    public class BaseService
    {
        public string GetBaseData()
        {
            return "This is from the Base Service";
        }

        public string GetDerviedData()
        {
            var ob = new DerivedService();
            return ob.GetDerivedData();
        }

        public string GetNewService()
        {
            return "This is newly created Service";
        }
    }
}
