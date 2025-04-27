using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace lab06
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        int Add(int a, int b);
    }
}
