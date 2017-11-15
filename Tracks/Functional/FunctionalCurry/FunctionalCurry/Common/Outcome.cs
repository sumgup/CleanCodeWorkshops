using System;

namespace FunctionalCurry.Common
{
    public class Outcome
    {
        public bool IsSuccess { get; private set; }

        public string Message { get; private set; }

        public string[] ErrorMessage { get; private set; }


        protected Outcome(bool isSuccess, string message)
        {
            this.IsSuccess = isSuccess;
            if (IsSuccess)
            {
                Message = message;
            }
            else
            {
                ErrorMessage = new string[] { message };
            }
        }



        protected Outcome(string[] errorMessages)
        {
            this.IsSuccess = false;
            this.ErrorMessage = errorMessages;
        }



        public static Outcome Ok()
        {
            return new Outcome( true, String.Empty);
        }
        public static Outcome Ok( string message)
        {
            return new Outcome( true, message);
        }

        public static Outcome Fail(string errorMessage)
        {
            return new Outcome( false, errorMessage);
        }
        public static Outcome Fail(string[] errorMessage)
        {
            return new Outcome(errorMessage);
        }
    }


    public class Outcome<T> : Outcome

    {
        protected Outcome(T data, bool isSuccess, string message) : base(isSuccess, message)
        {
            this.Data = data;
        }
        protected Outcome(T data, string[] errorMessage) : base(errorMessage)
        {
            this.Data = data;
        }

        public T Data { get; private set; }


        public static Outcome<Tout> Ok<Tout>(Tout value)
        {
            return new Outcome<Tout>(value, true, String.Empty);
        }
        public static Outcome<Tout> Ok<Tout>(Tout value, string message)
        {
            return new Outcome<Tout>(value, true, message);
        }

        public static Outcome<Tout> Fail<Tout>(string message)
        {
            return new Outcome<Tout>(default(Tout), false, message);
        }
        public static Outcome<Tout> Fail<Tout>(string[] messages)
        {
            return new Outcome<Tout>(default(Tout),messages);
        }

        internal static Outcome<UserInfo> Ok<UserInfo>(Common.UserInfo data)
        {
            throw new NotImplementedException();
        }
    }


    
}
