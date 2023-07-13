using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary1
{
    // NOTE: If you change the class name "Service1" here, you must also update the reference to "Service1" in App.config.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public List<CompositeType> GetList()
        {
            List<CompositeType> list = new List<CompositeType>();
            CompositeType composite1 = new CompositeType();
            composite1.StringValue = "One - From GetList()";
            list.Add(composite1);
            CompositeType composite2 = new CompositeType();
            composite2.StringValue = "Two - From GetList()";
            list.Add(composite2);
            CompositeType composite3 = new CompositeType();
            composite3.StringValue = "Three - From GetList()";
            list.Add(composite3);
            return list;
        }
    }
}
