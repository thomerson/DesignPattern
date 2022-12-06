using System;
using System.Collections.Generic;
using System.Text;

namespace 过滤器模式
{
    interface Criteria
    {
        List<Person> MeetCriteria(List<Person> persons);
    }
}
