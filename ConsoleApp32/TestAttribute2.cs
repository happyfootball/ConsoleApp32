using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp32
{
    [AttributeUsage(AttributeTargets.Class|AttributeTargets.Method,AllowMultiple =true,Inherited =
        false)]
    public class TestAttribute2:Attribute
    {
        private DateTime dateModified;
        private string changes;
        private string issues;

        public TestAttribute2(string dateModified, string changes)
        {
            this.changes = changes;
            this.dateModified = DateTime.Parse(dateModified);
        }

        public DateTime DateModified
        {
            get {
                return dateModified;
            }
        }

        public string Changes
        {
            get{
                return changes;
            }
        }

        public string Issues
        {
            get {
                return issues;
            }
            set {
                issues = value;
            }
        }
    }


    [AttributeUsage(AttributeTargets.Assembly)]  //通过此类能够载入操纵一个程序集，并获取程序集内部信息 
    public class SupportsWhatsNewAttribute : Attribute {
    }
}

