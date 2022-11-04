using Newtonsoft.Json;
using System;
using System.Text;
using zuri_week_1.DTO_s;
using zuri_week_1.Model;

namespace zuri_week_1.Service
{
    public class ArithemeticOperations : IArithemeticOperations
    {
        public ResponseDto BasicOperation(InputDto input)
        {
            var res = new ResponseDto();
            res.SlackUsername = "ogbeidebest";
            if (input.operation_type.ToLower().Contains("add") || input.operation_type.ToLower().Contains("addition"))
            {
                res.Result = input.x + input.y;
                res.Operation_type = OperationType.addition;


            }
            else if (input.operation_type.ToLower().Contains("subtract") || input.operation_type.ToLower().Contains("subtraction"))
            {

                res.Result = input.x - input.y;
                res.Operation_type = OperationType.subtraction;


            }
            else if (input.operation_type.ToLower().Contains("multiply") || input.operation_type.ToLower().Contains("multiplication"))
            {

                res.Result = input.x * input.y;
                res.Operation_type = OperationType.multiplication;
            }
            else
            {
                res.Result = 00;
            }
            return res;
        }
      
      
    }
}
