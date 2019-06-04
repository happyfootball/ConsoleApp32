using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp32
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method,AllowMultiple=true,Inherited=false)]
    public class TestAttributeDemo:Attribute
    {
        private DateTime dateModified;
        private string changes;
        private string issues;

        public TestAttributeDemo(string dateModified,string changes) {
            this.dateModified = DateTime.Parse(dateModified);
            this.changes = changes;
        }

        public DateTime DateModified {
            get {
                return dateModified;
            }
        }

        public string Changes {
            get {
                return changes;
            }
        }

        public string Issues {
            get {
                return issues;
            }
            set {
                issues = value;
            }
        }
    }
}
