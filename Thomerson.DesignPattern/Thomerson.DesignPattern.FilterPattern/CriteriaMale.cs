using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace 过滤器模式
{
    class CriteriaMale : Criteria
    {
        public List<Person> MeetCriteria(List<Person> persons)
        {
            return persons.Where(w => string.Compare(w.Gender, "MALE", true) == 0).ToList();
        }
    }
}
