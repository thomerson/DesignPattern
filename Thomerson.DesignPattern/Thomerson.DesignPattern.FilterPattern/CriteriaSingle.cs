using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace 过滤器模式
{
    class CriteriaSingle : Criteria
    {
        public List<Person> MeetCriteria(List<Person> persons)
        {
            return persons.Where(w => string.Compare(w.MaritalStatus, "SINGLE", true) == 0).ToList();
        }
    }
}