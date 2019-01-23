using System.Collections.Generic;
using System.Linq;

namespace Jackyfei.Framework.Contract.Util
{
    public class ValidatorContainer : List<Validator>
    {
        public object ValidatorObj{ get; set; }

        public bool IsTrue()
        {
            return this.All(validator => validator.IsTrue());
        }
    }
}