using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Create
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICalculator" in both code and config file together.
    [ServiceContract]
    public interface ICalculator
    {
        [OperationContract]
        int sum(int num1, int num2);//Addition

        [OperationContract]
        int sub(int num1, int num2);//Substraction

        [OperationContract]
        int mul(int num1, int num2);//Multiplication

        [OperationContract]
        int div(int num1, int num2);//Division
    }
}

//Use a data contract to composite types to service operations.
[DataContract] //Declare and assign the variables
public class CompositeType
{
    bool boolvalue = true;//Boolean valiable assignrd true
    string stringvalue = "Hello world";//string variable returning "HelloWorld"

    [DataMember]//You will call or invoke the information
    public bool BoolValue
    {
        get { return boolvalue; }
        set { boolvalue = value; }
    }

    [DataMember]
    public string StringValue
    {
        get { return stringvalue; }
        set { stringvalue = value; }
    }
}

