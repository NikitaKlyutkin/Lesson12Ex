using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12Ex
{
        public class WrongLoginException : Exception
        {
            public WrongLoginException() 
            {
            
            }
            public WrongLoginException(string message) : base(message) 
            { 
            
            }
        }
        public class WrongPasswordException : Exception
        {
            public WrongPasswordException() 
            {

            }
            public WrongPasswordException(string message) : base(message) 
            {
        
            }
        }

}
