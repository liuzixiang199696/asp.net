using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class Email
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string ValidationCode { get; set; }
        public DateTime? EmailHasValidated { get; set; }
        public int OwnerId { get; set;}
        public void MakeValidationCode()
        {
            if (!string.IsNullOrEmpty(ValidationCode))
            {
                throw new InvalidOperationException($"在ValidationCode已有值的情况下（当前值为：{ValidationCode}），试图再次生成");
            }
            ValidationCode = new Random().Next().ToString();
        }
        public void Send(string validationUrl)
        {

        }
    }
}
