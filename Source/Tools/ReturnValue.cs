using System;

namespace Hush.Tools
{

    class ReturnValue
    {

        public String Message;
        public Boolean Success;

        public ReturnValue()
        {

            Message = String.Empty;
            Success = false;

        }

        public ReturnValue(String Message, Boolean Success)
        {

            this.Message = Message;
            this.Success = Success;

        }

    }

}
